using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using DAL.Helper;
using MySql.Data.MySqlClient;
namespace DAL
{
    /// <summary>
    /// 填空题数据访问类
    /// </summary>
    public class CompletionQuestionService
    {
        /// <summary>
        /// 添加填空题
        /// </summary>
        /// <param name="completionQuestionObj">包含题目信息的实体类</param>
        /// <returns></returns>
        public int AddCompletionQuestion(CompletionQuestion completionQuestionObj)
        {
            string sql = "insert into CompletionQuestion(expName,sceneName,questionTypeNumber,content,picture,answer,score,teacherName) values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}')";

            sql = string.Format(sql, completionQuestionObj.expName, completionQuestionObj.sceneName, completionQuestionObj.questionTypeNumber,
                completionQuestionObj.content, completionQuestionObj.picture, completionQuestionObj.answer, completionQuestionObj.score, completionQuestionObj.teacherName);
            try
            {
                return SqlHelper.Update(sql);
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
            string sql = "select expName,sceneName,questionTypeNumber,content,picture,answer,score,teacherName from CompletionQuestion where id=" + id;
            MySqlDataReader reader = null;
            CompletionQuestion completionQuestionObj = null;
            try
            {
                reader = SqlHelper.GetReader(sql);
                if (reader.Read())
                {
                    completionQuestionObj = new CompletionQuestion();
                    completionQuestionObj.expName = reader["expName"].ToString();
                    completionQuestionObj.sceneName = reader["sceneName"].ToString();
                    completionQuestionObj.questionTypeNumber =Convert.ToInt32(reader["questionTypeNumber"]);
                    completionQuestionObj.content = reader["content"].ToString();

                    completionQuestionObj.picture = reader["picture"].ToString();
                    completionQuestionObj.answer = reader["answer"].ToString();
                    completionQuestionObj.score =reader["score"].ToString();
                    completionQuestionObj.teacherName = reader["teacherName"].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return completionQuestionObj;
        }



        /// <summary>
        /// 修改填空题
        /// </summary>
        /// <param name="completionQuestionObj">带有题目修改信息的实体类</param>
        /// <returns></returns>
        public int ModifyCompletionQuestion(CompletionQuestion completionQuestionObj)
        {
            string sql = "update  CompletionQuestion set expName='{0}',sceneName='{1}',content='{2}',";
            sql += "picture='{3}',answer='{4}',score='{5}',teacherName='{6}' where id={7}";

            sql = string.Format(sql, completionQuestionObj.expName, completionQuestionObj.sceneName, completionQuestionObj.content,
                 completionQuestionObj.picture, completionQuestionObj.answer, completionQuestionObj.score, completionQuestionObj.teacherName, completionQuestionObj.id
                );

            try
            {
                return SqlHelper.Update(sql);
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
            string sql = "delete from CompletionQuestion where id=" + id;
            try
            {
                return SqlHelper.Update(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
