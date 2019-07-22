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
    /// 简答题数据访问类
    /// </summary>
    public class ShortAnswerQuestionService
    {

        /// <summary>
        /// 通过场景名称获取简答题信息
        /// </summary>
        /// <param name="sceneName">场景名称</param>
        /// <returns></returns>
        public List<ShortAnswerQuestion> GetShortAnswerQuestionInfoBySceneName(string sceneName)
        {
            string sql = "select expName,sceneName,questionTypeNumber,content,picture,answer,score,keyword from ShortAnswerQuestion where sceneName='" + sceneName+"'";
            MySqlDataReader reader = null;
            List<ShortAnswerQuestion> shortAnswerQuestionList =new List<ShortAnswerQuestion>();
            try
            {
                reader = SqlHelper.GetReader(sql);
                while(reader.Read())
                {
                    ShortAnswerQuestion shortAnswerQuestionObj = new ShortAnswerQuestion();
                    shortAnswerQuestionObj.expName = reader["expName"].ToString();
                    shortAnswerQuestionObj.sceneName = reader["sceneName"].ToString();
                    shortAnswerQuestionObj.questionTypeNumber = Convert.ToInt32(reader["questionTypeNumber"]);
                    shortAnswerQuestionObj.content = reader["content"].ToString();

                    shortAnswerQuestionObj.picture = reader["picture"].ToString();
                    shortAnswerQuestionObj.answer = reader["answer"].ToString();
                    shortAnswerQuestionObj.score = reader["score"].ToString();
                    shortAnswerQuestionObj.keyword = reader["keyword"].ToString();

                    shortAnswerQuestionList.Add(shortAnswerQuestionObj);
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
            return shortAnswerQuestionList;
        }




        /// <summary>
        /// 通过简答题编号获取单个题目的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ShortAnswerQuestion GetShortAnswerQuestionInfoById(string id)
        {
            string sql = "select expName,sceneName,questionTypeNumber,content,picture,answer,score,keyword from ShortAnswerQuestion where id=" + id;
            MySqlDataReader reader = null;
            ShortAnswerQuestion shortAnswerQuestionObj = null;
            try
            {
                reader = SqlHelper.GetReader(sql);
                if (reader.Read())
                {
                    shortAnswerQuestionObj = new ShortAnswerQuestion();
                    shortAnswerQuestionObj.expName = reader["expName"].ToString();
                    shortAnswerQuestionObj.sceneName = reader["sceneName"].ToString();
                    shortAnswerQuestionObj.questionTypeNumber = Convert.ToInt32(reader["questionTypeNumber"]);
                    shortAnswerQuestionObj.content = reader["content"].ToString();

                    shortAnswerQuestionObj.picture = reader["picture"].ToString();
                    shortAnswerQuestionObj.answer = reader["answer"].ToString();
                    shortAnswerQuestionObj.score = reader["score"].ToString();
                    shortAnswerQuestionObj.keyword = reader["keyword"].ToString();
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
            return  shortAnswerQuestionObj;
        }
    }
}
