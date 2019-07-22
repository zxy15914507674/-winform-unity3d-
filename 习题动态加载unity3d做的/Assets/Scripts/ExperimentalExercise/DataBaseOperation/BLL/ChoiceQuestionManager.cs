
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using fvc.exp.dal;
using fvc.exp.model;

namespace fvc.exp.bll
{
    public class ChoiceQuestionManager
    {
        ChoiceQuestionService choiceQuestionService = new ChoiceQuestionService();
       
        
        /// <summary>
        /// 根据场景名称或者所有的选择题
        /// </summary>
        /// <param name="sceneName">场景名称</param>
        /// <returns></returns>
        public List<ChoiceQuestion> GetChoiceQuestionInfoBySceneName(string sceneName)
        {
            
            try
            {
                List<ChoiceQuestion> ChoiceQuestionList=choiceQuestionService.GetChoiceQuestionInfoBySceneName(sceneName);

                //为题目添加上题号
                for (int index = 0; index < ChoiceQuestionList.Count; index++)
                {
                    ChoiceQuestionList[index].content = (index + 1) +"  "+ ChoiceQuestionList[index].content;
                }

                    return ChoiceQuestionList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 通过id获取单个选择题的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ChoiceQuestion GetChoiceQuestionInfoById(string id)
        {
            try
            {
                return choiceQuestionService.GetChoiceQuestionInfoById(id);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
