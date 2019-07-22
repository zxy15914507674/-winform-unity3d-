using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using fvc.exp.dal;
using fvc.exp.model;
namespace fvc.exp.bll
{
    /// <summary>
    /// 简答题业务逻辑类
    /// </summary>
    public class ShortAnswerQuestionManager
    {
        ShortAnswerQuestionService shortAnswerQuestionService = new ShortAnswerQuestionService();
       


        /// <summary>
        /// 通过场景名称获取简答题信息
        /// </summary>
        /// <param name="sceneName">场景名称</param>
        /// <returns></returns>
        public List<ShortAnswerQuestion> GetShortAnswerQuestionInfoBySceneName(string sceneName)
        {
            try
            {
                List<ShortAnswerQuestion> ShortAnswerQuestionList = shortAnswerQuestionService.GetShortAnswerQuestionInfoBySceneName(sceneName);

                //为题目添加上题号
                for (int index = 0; index < ShortAnswerQuestionList.Count; index++)
                {
                    ShortAnswerQuestionList[index].content = (index + 1) + "  " + ShortAnswerQuestionList[index].content;
                }

                return ShortAnswerQuestionList;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 通过简答题编号获取单个题目的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ShortAnswerQuestion GetShortAnswerQuestionInfoById(string id)
        {
            try
            {
                return shortAnswerQuestionService.GetShortAnswerQuestionInfoById(id);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
