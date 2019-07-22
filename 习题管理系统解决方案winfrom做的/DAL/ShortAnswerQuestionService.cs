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
    /// 简答题数据访问类
    /// </summary>
    public class ShortAnswerQuestionService
    {

        /// <summary>
        /// 添加简答题
        /// </summary>
        /// <param name="shortAnswerQuestion">包含习题信息的实体类</param>
        /// <returns></returns>
        public int AddShortAnswerQuestion(ShortAnswerQuestion shortAnswerQuestion)
        {
            string sql = "insert into ShortAnswerQuestion(expName,sceneName,questionTypeNumber,content,picture,answer,score,teacherName,keyword) values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}')";

            sql = string.Format(sql, shortAnswerQuestion.expName, shortAnswerQuestion.sceneName, shortAnswerQuestion.questionTypeNumber,
                shortAnswerQuestion.content, shortAnswerQuestion.picture, shortAnswerQuestion.answer, shortAnswerQuestion.score, shortAnswerQuestion.teacherName,shortAnswerQuestion.keyword);
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
        /// 通过简答题编号获取单个题目的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ShortAnswerQuestion GetShortAnswerQuestionInfoById(string id)
        {
            string sql = "select expName,sceneName,questionTypeNumber,content,picture,answer,score,teacherName,keyword from ShortAnswerQuestion where id=" + id;
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
                    shortAnswerQuestionObj.teacherName = reader["teacherName"].ToString();
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


        /// <summary>
        /// 修改简答题
        /// </summary>
        /// <param name="shortAnswerQuestionObj">包含修改信息的实体类</param>
        /// <returns></returns>
        public int ModifyShortAnswerQuestion(ShortAnswerQuestion shortAnswerQuestionObj)
        {
            string sql = "update  ShortAnswerQuestion set expName='{0}',sceneName='{1}',content='{2}',";
            sql += "picture='{3}',answer='{4}',score='{5}',teacherName='{6}',keyword='{7}' where id={8}";

            sql = string.Format(sql, shortAnswerQuestionObj.expName, shortAnswerQuestionObj.sceneName, shortAnswerQuestionObj.content,
                 shortAnswerQuestionObj.picture, shortAnswerQuestionObj.answer, shortAnswerQuestionObj.score, shortAnswerQuestionObj.teacherName,shortAnswerQuestionObj.keyword,shortAnswerQuestionObj.id
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
        /// 根据简答题编号删除习题
        /// </summary>
        /// <param name="id">习题编号</param>
        /// <returns></returns>
        public int DeleteShortAnswerQuestion(string id)
        {
            string sql = "delete from ShortAnswerQuestion where id=" + id;
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
