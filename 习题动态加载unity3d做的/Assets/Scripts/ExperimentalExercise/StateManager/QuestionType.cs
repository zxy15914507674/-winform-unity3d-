using System.Collections;
using System.Collections.Generic;

/// <summary>
/// 问题类型的状态
/// </summary>
public enum QuestionType
{
	ChoiceQuestion=1,                       //选择题
    CompletionQuestion,                     //填空题
    ShortAnswerQuestion,                    //简答题
    Null                                    //空状态

}

public enum Transtion
{ 
    NotNull=1,                              //本类型的题目没有做完了
    Null                                    //本类型的题目做完了
}
