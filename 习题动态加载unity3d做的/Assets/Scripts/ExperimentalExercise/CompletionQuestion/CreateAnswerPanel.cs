/****
 * 
 *      动态生成填空题的空 
 * 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateAnswerPanel
{

    private RectTransform  _AnswerPanelTransform;
    private RectTransform _AnswerPanel1;
    private RectTransform _Scrollbar;
    private InputField _AnswerInput1;

    
    /// <summary>
    /// 动态生成填空输入框和提示文本
    /// </summary>
    /// <param name="completionNumber">填空的个数</param>
    public void CreateCompletionPanel(int completionNumber)
    {
        _AnswerInput1 = GameObject.Find("AnswerPanel1/AnswerInput1").GetComponent<InputField>();
        _AnswerInput1.text = "";
        
        if (completionNumber <= 1)
        {
            Debug.LogError("输入的空的个数不能小于1个");
            return;
        }
        _AnswerPanelTransform = GameObject.Find("AnswerPanel").GetComponent<RectTransform>();

        //每次绘制前，都把上一次绘制的删除
        for (int childIndex = _AnswerPanelTransform.childCount-1; childIndex >=0; childIndex--)
        {
            if (_AnswerPanelTransform.GetChild(childIndex).gameObject.name != "AnswerPanel1")
            {
                GameObject.DestroyImmediate(_AnswerPanelTransform.GetChild(childIndex).gameObject);
            }
           
        }
       


       
        _AnswerPanel1 = GameObject.Find("AnswerPanel1").GetComponent<RectTransform>();
        _Scrollbar = GameObject.Find("AnswerParent/Scrollbar").GetComponent<RectTransform>();
       

        for (int index = 2; index < completionNumber + 1; index++)
        {
            Transform itemTransform = GameObject.Instantiate(_AnswerPanel1).transform;
            itemTransform.SetParent(_AnswerPanelTransform);
            itemTransform.localPosition = Vector3.zero;
            itemTransform.localRotation = Quaternion.identity;
            itemTransform.localScale = Vector3.one;
            itemTransform.name = "AnswerPanel" + index;


            Transform answerNumber = itemTransform.FindChild("AnwerNumber1");
            answerNumber.name = "AnwerNumber" + index;
            answerNumber.GetComponent<Text>().text = "空" + index;


            Transform AnswerInput = itemTransform.FindChild("AnswerInput1");
            AnswerInput.name = "AnswerInput" + index;
        }

        _Scrollbar.GetComponent<Scrollbar>().value = 1;            //填空题的空动态绘制完毕，滚动条滑动到顶部显示
    }

	
}
