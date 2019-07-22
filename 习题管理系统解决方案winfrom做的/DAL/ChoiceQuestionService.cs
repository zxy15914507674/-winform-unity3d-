using DAL.Helper;
using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class ChoiceQuestionService
    {

        /// <summary>
        /// 添加习题
        /// </summary>
        /// <returns></returns>
        public int AddChoiceQuestion(ChoiceQuestion choiceQuestion) 
        {
            string sql = "insert into ChoiceQuestion(expName,sceneName,questionTypeNumber,content,optionA,optionB,optionC,optionD,picture,answer,score,teacherName) values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')";
            sql = string.Format(sql, choiceQuestion.expName,choiceQuestion.sceneName, choiceQuestion.questionTypeNumber, choiceQuestion.content,
                                  choiceQuestion.optionA, choiceQuestion.optionB, choiceQuestion.optionC, choiceQuestion.optionD,
                                  choiceQuestion.picture, choiceQuestion.answer, choiceQuestion.score,choiceQuestion.teacherName
                              
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


        /// <summary>
        /// 修改习题
        /// </summary>
        /// <param name="choiceQuestion">包含单选题修改信息的实体类</param>
        /// <returns></returns>
        public int ModifyChoiceQueston(ChoiceQuestion choiceQuestion)
        {
            string sql = "update  ChoiceQuestion set expName='{0}',sceneName='{1}',content='{2}',optionA='{3}',";
            sql += "optionB='{4}',optionC='{5}',optionD='{6}',picture='{7}',answer='{8}',score='{9}',teacherName='{10}' where id={11}";

            sql = string.Format(sql,choiceQuestion.expName,choiceQuestion.sceneName,choiceQuestion.content,choiceQuestion.optionA,
                choiceQuestion.optionB,choiceQuestion.optionC,choiceQuestion.optionD,choiceQuestion.picture,choiceQuestion.answer,choiceQuestion.score,choiceQuestion.teacherName,choiceQuestion.id
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
        /// 通过习题编号id删除习题
        /// </summary>
        /// <param name="id">习题编号</param>
        /// <returns></returns>
        public int DeleteChoiceQuestion(string id)
        {
            string sql = "delete from ChoiceQuestion where id="+id;
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
