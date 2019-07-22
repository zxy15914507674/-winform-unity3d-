using fvc.exp.bll;
using fvc.exp.model;
using fvc.exp.state;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


namespace fvc.exp.state
{
    public class CompletionQuestionState : State
    {
        private GameObject _QuestionUI;
        private CreateAnswerPanel _createAnswerPanel;
        private int _NumberCount = 0;                                             //保存题目的下标

        public CompletionQuestionState(GameObject QuestionUI, string SceneName)
        {
            StateEnter(QuestionUI,SceneName);
        }

        /// <summary>
        /// 下一题按钮点击触发
        /// </summary>
        public override void NextQuestion()
        {
            if (StateStaticParams.CompletionQuestionList == null || this._QuestionUI == null)
            {
                return;
            }

            if (_NumberCount >= StateStaticParams.CompletionQuestionList.Count - 1)
            {
                bool saveResult = _SaveAnswer();                     //保存答案
                if (saveResult == false)
                {
                    return;
                }

                Debug.Log("切换到简答题");
                StateStaticParams.currentQuestionType = QuestionType.ShortAnswerQuestion;
            }

            if (_NumberCount >= 0 && _NumberCount < StateStaticParams.CompletionQuestionList.Count - 1)
            {
                bool saveResult = _SaveAnswer();                     //保存答案
                if (saveResult == false)
                {
                    return;
                }


                _NumberCount++;
                _ShowMessageOnUI(this._QuestionUI, StateStaticParams.CompletionQuestionList[_NumberCount]);
            }
        }

        /// <summary>
        /// 上一题按钮点击触发
        /// </summary>
        public override void PreviousQuestion()
        {
            if (StateStaticParams.CompletionQuestionList == null || this._QuestionUI == null)
            {
                return;
            }

            if (_NumberCount <= 0)
            {
                if (_NumberCount == 0)
                {
                    bool saveResult = _SaveAnswer();                     //保存答案
                    if (saveResult == false)
                    {
                        return;
                    }
                    Debug.Log("切换到选择题");
                    StateStaticParams.currentQuestionType = QuestionType.ChoiceQuestion;   //切换到选择题
                }
                return;
            }

            if (_NumberCount >= 0 && _NumberCount <= StateStaticParams.CompletionQuestionList.Count - 1)
            {
                bool saveResult = _SaveAnswer();                     //保存答案
                if (saveResult == false)
                {
                    return;
                }

                _NumberCount--;
                _ShowMessageOnUI(this._QuestionUI, StateStaticParams.CompletionQuestionList[_NumberCount]);
            }
        }


        /// <summary>
        /// 保存答案
        /// </summary>
        private bool _SaveAnswer()
        {
            string answer = StateStaticParams.CompletionQuestionList[_NumberCount].answer.Trim();
            while (answer.IndexOf("  ") > -1)
            {
                answer = answer.Replace("  ", " ");                 //答案中连续多于两个空格的替换成一个的空格
            }
            string[] answerList = answer.Split(' ');
            for (int index = 0; index < answerList.Length; index++)     
            {
                string inputAnswerName = "AnswerPanel/" + "AnswerPanel" + (index + 1) + "/AnswerInput" + (index + 1);
                InputField inputAnswer = GameObject.Find(inputAnswerName).GetComponent<InputField>();
                if (StateStaticParams.CompletionQuestionList[_NumberCount].userAnswerDic.ContainsKey(index))
                {
                    StateStaticParams.CompletionQuestionList[_NumberCount].userAnswerDic[index]=inputAnswer == null ? "" : inputAnswer.text.Trim();
                }
                else
                {
                    StateStaticParams.CompletionQuestionList[_NumberCount].userAnswerDic.Add(index, inputAnswer == null ? "" : inputAnswer.text.Trim());
                }
                
            }
            return true;
        }


        public override void StateEnter(GameObject QuestionUI, string SceneName)
        {
            if (QuestionUI == null || SceneName == null || SceneName.Length == 0)
            {
                return;
            }
            this._QuestionUI = QuestionUI;
            _createAnswerPanel = new CreateAnswerPanel();


            try
            {
                StateStaticParams.CompletionQuestionList = new CompletionQuestionManager().GetCompletionQuestionInfoBySceneName(SceneName);
            }
            catch (System.Exception)
            {
                //TODO 提示用户出错了

            }
            if (StateStaticParams.CompletionQuestionList != null && StateStaticParams.CompletionQuestionList.Count > 0)
            {
                this._QuestionUI.SetActive(true);

                _ShowMessageOnUI(this._QuestionUI, StateStaticParams.CompletionQuestionList[0]);
            }
            else
            {
                StateStaticParams.currentQuestionType = QuestionType.ShortAnswerQuestion;        //查询不到数据，直接进入简答题
            }
        }



         /// <summary>
        /// 把数据展示到UI上
        /// </summary>
        /// <param name="QuestionUI">填空题界面</param>
        /// <param name="completionQuestion">问题信息</param>
        private void _ShowMessageOnUI(GameObject QuestionUI, CompletionQuestion completionQuestion)
        {
            if (QuestionUI == null || completionQuestion == null)
            {
                return;
            }

            #region 显示问题
            GameObject CompletionQuestionContent = GameObject.Find("CompletionQuestionContent");
            if (CompletionQuestionContent != null && CompletionQuestionContent.GetComponent<Text>() != null)
            {
                CompletionQuestionContent.GetComponent<Text>().text = completionQuestion.content;
            }
            #endregion

            #region 获取答案需要填空的个数并动态绘制空的个数
            string answer = completionQuestion.answer.Trim();
            while (answer.IndexOf("  ") > -1)                                      
            {
                answer = answer.Replace("  ", " ");                 //答案中连续多于两个空格的替换成一个的空格
            }
            string[] answerList = answer.Split(' ');
            int AnswerLength = answerList.Length;                   //需要填空的个数

            _createAnswerPanel.CreateCompletionPanel(AnswerLength);     
            #endregion


            #region 显示图片
            GameObject CompletionQuestionImage = GameObject.Find("CompletionQuestionImage");     //显示图片游戏物体

            //每次显示图片前都把原先的清空
            if (CompletionQuestionImage != null && CompletionQuestionImage.GetComponent<Image>() != null)
            {
                CompletionQuestionImage.GetComponent<Image>().sprite = null;
            }

            if (completionQuestion.picture != null && completionQuestion.picture.Length > 0)
            {
                System.Drawing.Image image;
                byte[] bytes;
                try
                {
                    image = (new SerializeObjectToString().DeserializeObject(completionQuestion.picture)) as System.Drawing.Image;
                    MemoryStream ms = new MemoryStream();
                    image.Save(ms, image.RawFormat);

                    ms.Flush();
                    ms.Seek(0, SeekOrigin.Begin);
                    //创建文件长度缓冲区
                    bytes = new byte[ms.Length];
                    //读取文件
                    ms.Read(bytes, 0, (int)ms.Length);
                    ms.Flush();
                    //释放文件读取流
                    ms.Close();
                    ms.Dispose();
                    ms = null;
                }
                catch (Exception)
                {

                    return;
                }


                if (CompletionQuestionImage != null && CompletionQuestionImage.GetComponent<Image>() != null && image != null)
                {
                    Texture2D texture2d = new Texture2D(800, 600);
                    texture2d.LoadImage(bytes);
                    CompletionQuestionImage.GetComponent<Image>().sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), new Vector2(0.5f, 0.5f));

                }
            }

            #endregion


            #region 显示用户输入的答案
           
            GameObject InputAnswerPanel = GameObject.Find("AnswerPanel");
            if (InputAnswerPanel != null)
            {
                for (int index = 0; index < answerList.Length; index++)     //显示前把输入框清空输入框清空
                {
                    string inputAnswerName = "AnswerPanel/" + "AnswerPanel" + (index + 1) + "/AnswerInput" + (index + 1);
                    InputField inputAnswer = GameObject.Find(inputAnswerName).GetComponent<InputField>();
                    inputAnswer.text = "";                                  //先清空上一次的输入
                    if (completionQuestion.userAnswerDic != null && completionQuestion.userAnswerDic.Count>0)
                    {
                        inputAnswer.text = completionQuestion.userAnswerDic[index];
                       
                    }
                    
                }
                
            }

            //for (int index = 0; index < StateStaticParams.CompletionQuestionList.Count; index++)
            //{
            //    for (int i = 0; i < StateStaticParams.CompletionQuestionList[index].userAnswerDic.Count; i++)
            //    {
            //        Debug.Log("第" + (index + 1) + "题： " + "  空"+(i+1)+":  "+StateStaticParams.CompletionQuestionList[index].userAnswerDic[i]);
            //    }
            //}

            
            #endregion
        }
    }
}


