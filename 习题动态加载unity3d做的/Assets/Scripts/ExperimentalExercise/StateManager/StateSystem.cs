using fvc.exp.state;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateSystem : MonoBehaviour
{
    private GameObject _ChoiceQuestionUI;                   //选择题UI
    private GameObject _CompletionQuestionUI;               //填空题UI
    private GameObject _ShortAnswerQuestionUI;                //简答题UI


    private Button  _ChoiceQuestionBtnPrevious;
    private Button _ChoiceQuestionBtnNext;                  //选择题界面中的  按钮 '上一题' 和 '下一题'
    private Button _CompletionQuestionBtnPrevious;
    private Button _CompletionQuestionBtnNext;              //填空题界面中的  '按钮' '上一题' 和 '下一题'
    private Button _ShortAnswerQeustionBtnPrevious;
    private Button _ShortAnswerQuestionBtnNext;             //简答题界面中的  '按钮' '上一题' 和 '下一题'


    private ChoiceQuestionState      _ChoiceQuestionState;         //选题题状态
    private CompletionQuestionState _CompletionQuestionState;      //填空题状态
    private ShortAnswerQuestionState _ShortAnswerQuestionState;    //简答题状态

    void Start()
    {
        _ChoiceQuestionUI = GameObject.Find("ChoiceQuestionUI");
        _CompletionQuestionUI = GameObject.Find("CompletionQuestionUI");
        _ShortAnswerQuestionUI = GameObject.Find("ShortAnswerQuestion");


        _ChoiceQuestionBtnPrevious = GameObject.Find("ChoiceQuestionUI/BtnPrevious").GetComponent<Button>();
        _ChoiceQuestionBtnNext = GameObject.Find("ChoiceQuestionUI/BtnNext").GetComponent<Button>();

        _CompletionQuestionBtnPrevious = GameObject.Find("CompletionQuestionUI/BtnPrevious").GetComponent<Button>();
        _CompletionQuestionBtnNext = GameObject.Find("CompletionQuestionUI/BtnNext").GetComponent<Button>();

        _ShortAnswerQeustionBtnPrevious = GameObject.Find("ShortAnswerQuestion/BtnPrevious").GetComponent<Button>();
        _ShortAnswerQuestionBtnNext = GameObject.Find("ShortAnswerQuestion/BtnNext").GetComponent<Button>();



        _ChoiceQuestionUI.SetActive(false);
        _CompletionQuestionUI.SetActive(false);
        _ShortAnswerQuestionUI.SetActive(false);


        




        //静态数据初始化
        StateStaticParams.currentQuestionType = QuestionType.ChoiceQuestion;                //从选择题开始
        StateStaticParams.IsStartExercise = false;
        StateStaticParams.ChoiceQuestionList = null;
        StateStaticParams.CompletionQuestionList = null;

        //测试数据
        StateStaticParams.IsStartExercise = true;
    }

    void Update()
    {
        if (StateStaticParams.IsStartExercise)
        {
            QuestionType currentQuestinType = StateStaticParams.currentQuestionType;
            if (currentQuestinType == QuestionType.ChoiceQuestion)          //选择题
            {
                _CompletionQuestionUI.SetActive(false);
                _ShortAnswerQuestionUI.SetActive(false);
                if (StateStaticParams.ChoiceQuestionList == null)
                {
                    _ChoiceQuestionState = new ChoiceQuestionState(_ChoiceQuestionUI, "Scene1");
                    //上一题和下一题按钮动态注册事件
                    _ChoiceQuestionBtnPrevious.onClick.AddListener(_ChoiceQuestionState.PreviousQuestion);
                    _ChoiceQuestionBtnNext.onClick.AddListener(_ChoiceQuestionState.NextQuestion);
                }
                else
                {
                    _ChoiceQuestionUI.SetActive(true);
                }
            }
            else if (currentQuestinType == QuestionType.CompletionQuestion) //填空题
            {
                _ChoiceQuestionUI.SetActive(false);
                _ShortAnswerQuestionUI.SetActive(false);

                if (StateStaticParams.CompletionQuestionList == null)
                {
                    _CompletionQuestionState = new CompletionQuestionState(_CompletionQuestionUI, "Scene1");
                    _CompletionQuestionBtnPrevious.onClick.AddListener(_CompletionQuestionState.PreviousQuestion);
                    _CompletionQuestionBtnNext.onClick.AddListener(_CompletionQuestionState.NextQuestion);
                }
                else
                {
                    _CompletionQuestionUI.SetActive(true);
                }
               
            }
            else if (currentQuestinType == QuestionType.ShortAnswerQuestion) //简答题
            {
                _ChoiceQuestionUI.SetActive(false);
                _CompletionQuestionUI.SetActive(false);
                if (StateStaticParams.ShortAnswerQuestionList == null)
                {
                    _ShortAnswerQuestionState = new ShortAnswerQuestionState(_ShortAnswerQuestionUI, "Scene1");
                    _ShortAnswerQeustionBtnPrevious.onClick.AddListener(_ShortAnswerQuestionState.PreviousQuestion);
                    _ShortAnswerQuestionBtnNext.onClick.AddListener(_ShortAnswerQuestionState.NextQuestion);
                }
                else
                {
                    _ShortAnswerQuestionUI.SetActive(true);
                }
            }

        }
    }
}


