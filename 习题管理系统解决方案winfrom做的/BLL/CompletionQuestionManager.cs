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
    /// 填空题数据业务逻辑类
    /// </summary>
    public class CompletionQuestionManager
    {
        CompletionQuestionService completionQuestionServiceObj = new CompletionQuestionService();
        public int AddCompletionQuestion(CompletionQuestion completionQuestionObj)
        {
            #region 判断问题和答案的个数是否一致

            //以  左括号 '(' 为分割起点， 右括号 ‘)’为终点,去掉内容中所有多于的空格后，如果左右括号()之间没有内容，则为一个需要填的空
           
            string content = completionQuestionObj.content;                         //填空题内容
            content = content.Trim();                                               //去掉两端的空格

            while(content.IndexOf("（")>-1)                                          
            {
                content=content.Replace("（", "(");                                          //把content中所有中文的 "（"替换中英文的 '('
            }


            while (content.IndexOf("）") > -1)
            {
                content=content.Replace("）", ")");                                          //把content中所有中文的 "）"替换中英文的 ')'
            }
            completionQuestionObj.content = content;
            while (content.IndexOf(" ") > -1)                                       //去掉内容中所有多余的空格
            {
                content = content.Replace(" ", "");
            }
            
            int countBracket = 0;                           //计算问题中有多少个空
            int startIndex = 0;
            int index = content.IndexOf("()", startIndex);
            while (index!=-1)
            {
                countBracket++;
                startIndex = index + 1;
                index = content.IndexOf("()", startIndex);                  
            }


            string answer = completionQuestionObj.answer.Trim();
            while (answer.IndexOf("  ") > -1)                                      
            {
                answer = answer.Replace("  ", " ");                 //答案中连续多于两个空格的替换成一个的空格
            }
            string[] answerList = answer.Split(' ');
            if (answerList.Length != countBracket)
            {
                throw new Exception("答案数和填空的数量对应不上");
            }

            
            
            #endregion
            try
            {
                return completionQuestionServiceObj.AddCompletionQuestion(completionQuestionObj);
            }
            catch (Exception)
            {
                
                throw;
            }
        }



        
        /// <summary>
        /// 通过填空题编号获取单个题目的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CompletionQuestion GetCompletionQuestionInfoById(string id)
        {
            try
            {
                return completionQuestionServiceObj.GetCompletionQuestionInfoById(id);
            }
            catch (Exception)
            {
                
                throw;
            }
        }



        /// <summary>
        /// 修改填空题
        /// </summary>
        /// <param name="completionQuestionObj">带有题目修改信息的实体类</param>
        /// <returns></returns>
        public int ModifyCompletionQuestion(CompletionQuestion completionQuestionObj)
        {
            try
            {
                return completionQuestionServiceObj.ModifyCompletionQuestion(completionQuestionObj);
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        /// <summary>
        /// 删除填空题
        /// </summary>
        /// <param name="id">题目编号</param>
        /// <returns></returns>
        public int DeleteCompletionQuestion(string id)
        {
            try
            {
                return completionQuestionServiceObj.DeleteCompletionQuestion(id);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
