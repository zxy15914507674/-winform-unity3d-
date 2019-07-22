using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(1))
        {
            for (int index = 0; index <4; index++)     //显示前把输入框清空输入框清空
            {
                string inputAnswerName = "AnswerPanel/" + "AnswerPanel" + (index + 1) + "/AnswerInput" + (index + 1);
                InputField inputAnswer = GameObject.Find(inputAnswerName).GetComponent<InputField>();
                inputAnswer.text = "";                                  //先清空上一次的输入
                if (index == 0 || index == 2)
                {
                    inputAnswer.text = "测试输入:" + index;
                }
            }
        }

        if (Input.GetMouseButtonDown(2))
        {
            for (int index = 0; index < 4; index++)     //显示前把输入框清空输入框清空
            {
                string inputAnswerName = "AnswerPanel/" + "AnswerPanel" + (index + 1) + "/AnswerInput" + (index + 1);
                InputField inputAnswer = GameObject.Find(inputAnswerName).GetComponent<InputField>();
                inputAnswer.text = "";                                  //先清空上一次的输入
                if (index == 1 || index == 3)
                {
                    inputAnswer.text = "测试输入:" + index;
                }
            }
        }
	}
}
