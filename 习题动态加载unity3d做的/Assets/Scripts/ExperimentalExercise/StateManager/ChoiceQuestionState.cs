using fvc.exp.state;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using fvc.exp.model;
using fvc.exp.bll;
using UnityEngine.UI;
using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace fvc.exp.state
{
    public class ChoiceQuestionState : State
    {
     
        private GameObject _QuestionUI;                                      //选择题UI界面游戏物体
        private int _NumberCount=0;                                             //保存题目的下标
        public ChoiceQuestionState(GameObject QuestionUI, string SceneName)
        {
            StateEnter(QuestionUI,SceneName);
        }


        /// <summary>
        /// 下一题按钮点击触发
        /// </summary>
        public override void NextQuestion()
        {
            if (StateStaticParams.ChoiceQuestionList == null || this._QuestionUI==null)
            {
                return;
            }

            if (_NumberCount >= StateStaticParams.ChoiceQuestionList.Count-1)
            {
                bool saveResult = _SaveAnswer();                     //保存答案
                if (saveResult == false)
                {
                    return;
                }

                Debug.Log("切换到填空题");
                StateStaticParams.currentQuestionType = QuestionType.CompletionQuestion;
            }

            if (_NumberCount >=0 && _NumberCount < StateStaticParams.ChoiceQuestionList.Count-1)
            {
                bool saveResult = _SaveAnswer();                     //保存答案
                if (saveResult == false)
                {
                    return;
                }


                _NumberCount++;
                _ShowMessageOnUI(this._QuestionUI, StateStaticParams.ChoiceQuestionList[_NumberCount]);
            }

            
            

        }

        /// <summary>
        /// 上一题按钮点击触发
        /// </summary>
        public override void PreviousQuestion()
        {
            if (StateStaticParams.ChoiceQuestionList == null || this._QuestionUI == null)
            {
                return;
            }

            if (_NumberCount <=0)
            {
                return;
            }

            if (_NumberCount >= 0 && _NumberCount <=StateStaticParams.ChoiceQuestionList.Count - 1)
            {
               bool saveResult= _SaveAnswer();                     //保存答案
               if (saveResult == false)
               {
                   return;
               }

                _NumberCount--;
                _ShowMessageOnUI(this._QuestionUI, StateStaticParams.ChoiceQuestionList[_NumberCount]);
            }
        }


        /// <summary>
        /// 保存答案
        /// </summary>
        private bool _SaveAnswer()
        {
            //保存答案
            InputField InputAnswer = GameObject.Find("ChoiceQuestionUI/InputAnswer").GetComponent<InputField>();
            if (InputAnswer != null && InputAnswer.text.Length > 0)
            {
                //输入验证

                if (!(InputAnswer.text.Contains("A") || InputAnswer.text.Contains("B") || InputAnswer.text.Contains("C") || InputAnswer.text.Contains("D")))
                {

                    //TODO  提示输入格式不正确
                    Debug.Log("请输入 A、B、C、D中的一个");
                    return false;

                }

                StateStaticParams.ChoiceQuestionList[_NumberCount].UserAnswer = InputAnswer.text;
            }
            return true;
        }


        /// <summary>
        /// 状态进入，初始化选择题窗体，并加载第一道习题
        /// </summary>
        /// <param name="QuestionUI"></param>
        public override void StateEnter(GameObject QuestionUI,string SceneName)
        {
            if (QuestionUI == null || SceneName== null || SceneName.Length == 0)
            {
                return;
            }
            this._QuestionUI = QuestionUI;

            
            
            try
            {
                StateStaticParams.ChoiceQuestionList = new ChoiceQuestionManager().GetChoiceQuestionInfoBySceneName(SceneName);
            }
            catch (System.Exception)
            {
                //TODO 提示用户出错了
                 
            }
            if (StateStaticParams.ChoiceQuestionList != null && StateStaticParams.ChoiceQuestionList.Count > 0)
            {
                this._QuestionUI.SetActive(true);

                _ShowMessageOnUI(this._QuestionUI, StateStaticParams.ChoiceQuestionList[0]);
            }
            else
            {
                StateStaticParams.currentQuestionType = QuestionType.CompletionQuestion;        //查询不到数据，直接进入填空题
            }
        }


        /// <summary>
        /// 把数据展示到UI上
        /// </summary>
        /// <param name="QuestionUI">选择题界面</param>
        /// <param name="ChoiceQuestion">问题信息</param>
        private void _ShowMessageOnUI(GameObject QuestionUI,ChoiceQuestion choiceQuestion) 
        {
            if (QuestionUI == null || choiceQuestion == null)
            {
                return;
            }




            #region 显示问题
            GameObject ChoiceQuestionContent = GameObject.Find("ChoiceQuestionContent");      //显示问题的游戏物体
            if (ChoiceQuestionContent != null && ChoiceQuestionContent.GetComponent<Text>() != null)
            {
                ChoiceQuestionContent.GetComponent<Text>().text = choiceQuestion.content;
            }
            #endregion


            #region 显示选项ABCD的内容
            GameObject OptionAContent = GameObject.Find("OptionAContent");
            GameObject OptionBContent = GameObject.Find("OptionBContent");
            GameObject OptionCContent = GameObject.Find("OptionCContent");
            GameObject OptionDContent = GameObject.Find("OptionDContent");

            if (OptionAContent == null || OptionBContent == null || OptionCContent == null || OptionDContent == null)
            {
                return;
            }
            OptionAContent.GetComponent<Text>().text = choiceQuestion.optionA;
            OptionBContent.GetComponent<Text>().text = choiceQuestion.optionB;
            OptionCContent.GetComponent<Text>().text = choiceQuestion.optionC;
            OptionDContent.GetComponent<Text>().text = choiceQuestion.optionD;

            #endregion


            #region 显示图片
            GameObject ChoiceQuestionImage = GameObject.Find("ChoiceQuestionImage");     //显示图片游戏物体

            //每次显示图片前都把原先的清空
            if (ChoiceQuestionImage != null && ChoiceQuestionImage.GetComponent<Image>() != null)
            {
                ChoiceQuestionImage.GetComponent<Image>().sprite = null;
            }

            if (choiceQuestion.picture != null && choiceQuestion.picture.Length > 0)
            {
                System.Drawing.Image image;
                byte[] bytes;
                try
                {
                    image = (new SerializeObjectToString().DeserializeObject(choiceQuestion.picture)) as System.Drawing.Image;
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


                if (ChoiceQuestionImage != null && ChoiceQuestionImage.GetComponent<Image>() != null && image != null)
                {
                    Texture2D texture2d = new Texture2D(800, 600);
                    texture2d.LoadImage(bytes);
                    ChoiceQuestionImage.GetComponent<Image>().sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), new Vector2(0.5f, 0.5f));

                }
            }

            #endregion


            #region 显示用户输入的答案

            InputField InputAnswer = GameObject.Find("ChoiceQuestionUI/InputAnswer").GetComponent<InputField>();
            if (InputAnswer != null)
            {

                InputAnswer.text = "";                  //显示前把输入框清空输入框清空
            }

            if (InputAnswer != null && StateStaticParams.ChoiceQuestionList[_NumberCount].UserAnswer != null && StateStaticParams.ChoiceQuestionList[_NumberCount].UserAnswer.Length > 0)
            {
                InputAnswer.text = StateStaticParams.ChoiceQuestionList[_NumberCount].UserAnswer;
            }
            #endregion
        }
    }
}


