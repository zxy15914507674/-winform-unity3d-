using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using fvc.exp.model;

namespace fvc.exp.dal
{

    public class ChoiceQuestionService
    {

        /// <summary>
        /// 根据场景名称或者所有的选择题
        /// </summary>
        /// <param name="sceneName">场景名称</param>
        /// <returns></returns>
        public List<ChoiceQuestion> GetChoiceQuestionInfoBySceneName(string sceneName)
        {
            string sql = "select expName,sceneName,questionTypeNumber,content,optionA,optionB,optionC,optionD,picture,answer,score,teacherName from ChoiceQuestion where sceneName='" + sceneName+"'";
            MySqlDataReader reader = null;
            List<ChoiceQuestion> choiceQuestionList = new List<ChoiceQuestion>();
            try
            {
                reader = SqlHelper.GetReader(sql);
                while(reader.Read())
                {
                    ChoiceQuestion choiceQuestionObj = new ChoiceQuestion();
                    choiceQuestionObj.expName = reader["expName"].ToString();
                    choiceQuestionObj.sceneName = reader["sceneName"].ToString();
                    choiceQuestionObj.questionTypeNumber = reader["questionTypeNumber"].ToString();
                    choiceQuestionObj.content = reader["content"].ToString();
                    choiceQuestionObj.optionA = reader["optionA"].ToString();
                    choiceQuestionObj.optionB = reader["optionB"].ToString();
                    choiceQuestionObj.optionC = reader["optionC"].ToString();
                    choiceQuestionObj.optionD = reader["optionD"].ToString();
                    choiceQuestionObj.picture = reader["picture"].ToString();
                    choiceQuestionObj.answer = reader["answer"].ToString();
                    choiceQuestionObj.score = reader["score"].ToString();
                    choiceQuestionObj.teacherName = reader["teacherName"].ToString();
                    choiceQuestionList.Add(choiceQuestionObj);
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
            return choiceQuestionList;
        }

        /// <summary>
        /// 通过id获取单个选择题的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ChoiceQuestion GetChoiceQuestionInfoById(string id)
        {
            string sql = "select expName,sceneName,questionTypeNumber,content,optionA,optionB,optionC,optionD,picture,answer,score,teacherName from ChoiceQuestion where id="+id;
            MySqlDataReader reader = null;
            ChoiceQuestion choiceQuestionObj =null;
            try
            {
                reader = SqlHelper.GetReader(sql);
                if(reader.Read()){
                    choiceQuestionObj = new ChoiceQuestion();
                    choiceQuestionObj.expName = reader["expName"].ToString();
                    choiceQuestionObj.sceneName = reader["sceneName"].ToString();
                    choiceQuestionObj.questionTypeNumber = reader["questionTypeNumber"].ToString();
                    choiceQuestionObj.content = reader["content"].ToString();
                    choiceQuestionObj.optionA = reader["optionA"].ToString();
                    choiceQuestionObj.optionB = reader["optionB"].ToString();
                    choiceQuestionObj.optionC = reader["optionC"].ToString();
                    choiceQuestionObj.optionD = reader["optionD"].ToString();
                    choiceQuestionObj.picture = reader["picture"].ToString();
                    choiceQuestionObj.answer = reader["answer"].ToString();
                    choiceQuestionObj.score = reader["score"].ToString();
                    choiceQuestionObj.teacherName = reader["teacherName"].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            { 
                if(reader!=null)
                {
                    reader.Close();                
                }
            }
            return choiceQuestionObj;
        }
    }
}
