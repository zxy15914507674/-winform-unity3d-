using System.Collections;
using System.Collections.Generic;

using fvc.exp.model;
namespace fvc.exp.state
{
    public class StateStaticParams
    {
        public static QuestionType currentQuestionType;             //当前问题类型

        public static bool IsStartExercise;                        //是否进入习题阶段


        public static List<ChoiceQuestion> ChoiceQuestionList;             //存储从数据库查询回来的选择题的题目信息的列表
        public static List<CompletionQuestion> CompletionQuestionList;     //存储从数据库查询回来的填空题的题目信息的列表
        public static List<ShortAnswerQuestion> ShortAnswerQuestionList;   //存储从数据库查询回来的简答题的题目信息的列表
    }
}

