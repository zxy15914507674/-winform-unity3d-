using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Model;
namespace BLL
{
    /// <summary>
    /// 简答题业务逻辑类
    /// </summary>
    public class ShortAnswerQuestionManager
    {
        ShortAnswerQuestionService shortAnswerQuestionService = new ShortAnswerQuestionService();
        /// <summary>
        /// 添加简答题
        /// </summary>
        /// <param name="shortAnswerQuestion">包含习题信息的实体类</param>
        /// <returns></returns>
        public int AddShortAnswerQuestion(ShortAnswerQuestion shortAnswerQuestion)
        {
            try
            {
                return shortAnswerQuestionService.AddShortAnswerQuestion(shortAnswerQuestion);
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


         /// <summary>
        /// 修改简答题
        /// </summary>
        /// <param name="shortAnswerQuestionObj">包含修改信息的实体类</param>
        /// <returns></returns>
        public int ModifyShortAnswerQuestion(ShortAnswerQuestion shortAnswerQuestionObj)
        {
            try
            {
                return shortAnswerQuestionService.ModifyShortAnswerQuestion(shortAnswerQuestionObj);
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// 根据简答题编号删除习题
        /// </summary>
        /// <param name="id">习题编号</param>
        /// <returns></returns>
        public int DeleteShortAnswerQuestion(string id)
        {
            try
            {
                return shortAnswerQuestionService.DeleteShortAnswerQuestion(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
