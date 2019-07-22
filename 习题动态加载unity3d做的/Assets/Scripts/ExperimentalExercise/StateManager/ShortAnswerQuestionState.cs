using fvc.exp.bll;
using fvc.exp.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


namespace fvc.exp.state
{
    public class ShortAnswerQuestionState : State
    {


        private GameObject _QuestionUI;                                      //选择题UI界面游戏物体
        private int _NumberCount=0;                                             //保存题目的下标
        public ShortAnswerQuestionState(GameObject QuestionUI, string SceneName)
        {
            StateEnter(QuestionUI,SceneName);
        }


        /// <summary>
        /// 下一题按钮点击触发
        /// </summary>
        public override void NextQuestion()
        {
            if (StateStaticParams.ShortAnswerQuestionList == null || this._QuestionUI == null)
            {
                return;
            }

            if (_NumberCount >= StateStaticParams.ShortAnswerQuestionList.Count - 1)
            {
                bool saveResult = _SaveAnswer();                     //保存答案
                if (saveResult == false)
                {
                    return;
                }

                Debug.Log("习题做完了");
                //TODO   计算分数
                
            }

            if (_NumberCount >= 0 && _NumberCount < StateStaticParams.ShortAnswerQuestionList.Count - 1)
            {
                bool saveResult = _SaveAnswer();                     //保存答案
                if (saveResult == false)
                {
                    return;
                }


                _NumberCount++;
                _ShowMessageOnUI(this._QuestionUI, StateStaticParams.ShortAnswerQuestionList[_NumberCount]);
            }
        }

        /// <summary>
        /// 上一题按钮点击触发
        /// </summary>
        public override void PreviousQuestion()
        {
            if (StateStaticParams.ShortAnswerQuestionList == null || this._QuestionUI == null)
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
                    Debug.Log("切换到填空题");
                    StateStaticParams.currentQuestionType = QuestionType.CompletionQuestion;   //切换到填空题
                }
                return;
            }

            if (_NumberCount >= 0 && _NumberCount <= StateStaticParams.ShortAnswerQuestionList.Count - 1)
            {
                bool saveResult = _SaveAnswer();                     //保存答案
                if (saveResult == false)
                {
                    return;
                }

                _NumberCount--;
                _ShowMessageOnUI(this._QuestionUI, StateStaticParams.ShortAnswerQuestionList[_NumberCount]);
            }
        }


        /// <summary>
        /// 保存答案
        /// </summary>
        private bool _SaveAnswer()
        {
            //保存答案
            InputField InputAnswer = GameObject.Find("ShortAnswerQuestion/AnswerInput").GetComponent<InputField>();
            if (InputAnswer != null && InputAnswer.text.Length > 0)
            {
                StateStaticParams.ShortAnswerQuestionList[_NumberCount].userAnswer = InputAnswer.text;
            }
            
            return true;
        }



        /// <summary>
        /// 状态进入，初始化选择题窗体，并加载第一道习题
        /// </summary>
        /// <param name="QuestionUI"></param>
        public override void StateEnter(GameObject QuestionUI, string SceneName)
        {
            if (QuestionUI == null || SceneName == null || SceneName.Length == 0)
            {
                return;
            }
            this._QuestionUI = QuestionUI;



            try
            {
                StateStaticParams.ShortAnswerQuestionList = new ShortAnswerQuestionManager().GetShortAnswerQuestionInfoBySceneName(SceneName);
            }
            catch (System.Exception)
            {
                //TODO 提示用户出错了

            }
            if (StateStaticParams.ShortAnswerQuestionList != null && StateStaticParams.ShortAnswerQuestionList.Count > 0)
            {
                this._QuestionUI.SetActive(true);

                _ShowMessageOnUI(this._QuestionUI, StateStaticParams.ShortAnswerQuestionList[0]);
            }
            else
            {
                Debug.Log("没有简答题，习题完毕");        //查询不到数据，直接提示结束
            }
        }



        /// <summary>
        /// 把数据展示到UI上
        /// </summary>
        /// <param name="QuestionUI">选择题界面</param>
        /// <param name="shortAnswerQuestion">问题信息</param>
        private void _ShowMessageOnUI(GameObject QuestionUI, ShortAnswerQuestion shortAnswerQuestion)
        {
            if (QuestionUI == null || shortAnswerQuestion == null)
            {
                return;
            }




            #region 显示问题
            GameObject ShortAnswerQuestionContent = GameObject.Find("ShortAnswerQuestionContent");      //显示问题的游戏物体
            if (ShortAnswerQuestionContent != null && ShortAnswerQuestionContent.GetComponent<Text>() != null)
            {
                ShortAnswerQuestionContent.GetComponent<Text>().text = shortAnswerQuestion.content;
            }
            #endregion




            #region 显示图片
            GameObject ShortAnswerQuestionImage = GameObject.Find("ShortAnswerQuestionImage");     //显示图片游戏物体

            //每次显示图片前都把原先的清空
            if (ShortAnswerQuestionImage != null && ShortAnswerQuestionImage.GetComponent<Image>() != null)
            {
                ShortAnswerQuestionImage.GetComponent<Image>().sprite = null;
            }

            if (shortAnswerQuestion.picture != null && shortAnswerQuestion.picture.Length > 0)
            {
                System.Drawing.Image image;
                byte[] bytes;
                try
                {
                    image = (new SerializeObjectToString().DeserializeObject(shortAnswerQuestion.picture)) as System.Drawing.Image;
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


                if (ShortAnswerQuestionImage != null && ShortAnswerQuestionImage.GetComponent<Image>() != null && image != null)
                {
                    Texture2D texture2d = new Texture2D(800, 600);
                    texture2d.LoadImage(bytes);
                    ShortAnswerQuestionImage.GetComponent<Image>().sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), new Vector2(0.5f, 0.5f));

                }
            }

            #endregion


            #region 显示用户输入的答案

            InputField InputAnswer = GameObject.Find("ShortAnswerQuestion/AnswerInput").GetComponent<InputField>();
            if (InputAnswer != null)
            {

                InputAnswer.text = "";                  //显示前把输入框清空输入框清空
            }

            if (InputAnswer != null && StateStaticParams.ShortAnswerQuestionList[_NumberCount].userAnswer != null && StateStaticParams.ShortAnswerQuestionList[_NumberCount].userAnswer.Length > 0)
            {
                InputAnswer.text = StateStaticParams.ShortAnswerQuestionList[_NumberCount].userAnswer;
            }
            #endregion
        }
    }
}


