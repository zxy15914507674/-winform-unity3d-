using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
namespace BLL
{
    public class ChoiceQuestionManager
    {
        ChoiceQuestionService choiceQuestionService = new ChoiceQuestionService();
        /// <summary>
        /// 添加习题
        /// </summary>
        /// <returns></returns>
        public int AddChoiceQuestion(ChoiceQuestion choiceQuestion)
        {
            try
            {
                return choiceQuestionService.AddChoiceQuestion(choiceQuestion);
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


        /// <summary>
        /// 修改习题
        /// </summary>
        /// <param name="choiceQuestion">包含单选题修改信息的实体类</param>
        /// <returns></returns>
        public int ModifyChoiceQueston(ChoiceQuestion choiceQuestion)
        {
            try
            {
                return choiceQuestionService.ModifyChoiceQueston(choiceQuestion);
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        /// <summary>
        /// 通过习题编号id删除习题
        /// </summary>
        /// <param name="id">习题编号</param>
        /// <returns></returns>
        public int DeleteChoiceQuestion(string id)
        {
            try
            {
                return choiceQuestionService.DeleteChoiceQuestion(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
