using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace fvc.exp.state
{
    public abstract class State
    {
        /// <summary>
        /// 切换回上一道题的业务逻辑
        /// </summary>
       
        public abstract void NextQuestion();                        //上一题
        
        /// <summary>
        /// 切换到下一道题的业务逻辑
        /// </summary>
       
        public abstract void PreviousQuestion();                    //下一题


      /// <summary>
        /// 状态进入时的业务逻辑，并显示相应的习题窗体
      /// </summary>
      /// <param name="QuestionUI">对应习题的UI</param>
      /// <param name="SceneName">场景名称</param>
        public abstract void StateEnter(GameObject QuestionUI,string SceneName);                                   //进入状态
    }
}


