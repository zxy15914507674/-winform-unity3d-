using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using fvc.exp.model;
using fvc.exp;
using MySql.Data.MySqlClient;
namespace fvc.exp.dal
{
    /// <summary>
    /// 填空题数据访问类
    /// </summary>
    public class CompletionQuestionService
    {
        /// <summary>
        /// 通过场景名称获取全部的填空题
        /// </summary>
        /// <param name="sceneName">场景名称</param>
        /// <returns></returns>
        public List<CompletionQuestion> GetCompletionQuestionInfoBySceneName(string sceneName) 
        {
            string sql = "select expName,sceneName,questionTypeNumber,content,picture,answer,score from CompletionQuestion where sceneName='" +sceneName+"'";
            MySqlDataReader reader = null;
            List<CompletionQuestion> completionQuestionObjList = new List<CompletionQuestion>();
            try
            {
                reader = SqlHelper.GetReader(sql);
                while(reader.Read())
                {
                    CompletionQuestion completionQuestionObj = new CompletionQuestion();
                    completionQuestionObj.expName = reader["expName"].ToString();
                    completionQuestionObj.sceneName = reader["sceneName"].ToString();
                    completionQuestionObj.questionTypeNumber = Convert.ToInt32(reader["questionTypeNumber"]);
                    completionQuestionObj.content = reader["content"].ToString();

                    completionQuestionObj.picture = reader["picture"].ToString();
                    completionQuestionObj.answer = reader["answer"].ToString();
                    completionQuestionObj.score = reader["score"].ToString();

                    completionQuestionObjList.Add(completionQuestionObj);
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
            return completionQuestionObjList;
        }



        /// <summary>
        /// 通过填空题编号获取单个题目的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CompletionQuestion GetCompletionQuestionInfoById(string id)
        {
            string sql = "select expName,sceneName,questionTypeNumber,content,picture,answer,score from CompletionQuestion where id=" + id;
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



    }
}
