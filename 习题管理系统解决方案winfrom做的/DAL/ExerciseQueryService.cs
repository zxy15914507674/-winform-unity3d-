using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Model;
using MySql.Data.MySqlClient;
using DAL.Helper;
namespace DAL
{

    /// <summary>
    /// 习题信息查询数据访问类
    /// </summary>
    public class ExerciseQueryService
    {

        /// <summary>
        /// 根据实验场景查询相应的习题信息
        /// </summary>
        /// <param name="exerciseQuery">包含场景名称信息的实体类</param>
        /// <returns></returns>
        public List<ExerciseQuery> GetExerciseQueryInfoBySceneName(ExerciseQuery exerciseQuery)
        {
            string sql = "select id,expName,sceneName,questionTypeNumber,content,teacherName from ChoiceQuestion where sceneName='{0}'; ";
            sql += " select id,expName,sceneName,questionTypeNumber,content,teacherName from CompletionQuestion where sceneName='{0}'; ";
            sql += " select id,expName,sceneName,questionTypeNumber,content,teacherName from ShortAnswerQuestion where sceneName='{0}';";
            sql = string.Format(sql, exerciseQuery.sceneName);
            List<ExerciseQuery> exerciseQueryList = new List<ExerciseQuery>();
            MySqlDataReader reader = null;
            try
            {
                reader = SqlHelper.GetReader(sql);
                while(reader.Read())
                {
                    ExerciseQuery exerciseQueryObj = new ExerciseQuery();
                    exerciseQueryObj.id = Convert.ToInt32(reader["id"]);
                    exerciseQueryObj.sceneName=reader["sceneName"].ToString();
                    exerciseQueryObj.questionTypeNumber = Convert.ToInt32(reader["questionTypeNumber"]);
                    exerciseQueryObj.content = reader["content"].ToString();
                    exerciseQueryObj.ExpName = reader["expName"].ToString();
                    exerciseQueryObj.teacherName =reader["teacherName"].ToString();
                    exerciseQueryList.Add(exerciseQueryObj);
                }
                if(reader.NextResult()){
                    while (reader.Read())
                    {
                        ExerciseQuery exerciseQueryObj = new ExerciseQuery();
                        exerciseQueryObj.id = Convert.ToInt32(reader["id"]);
                        exerciseQueryObj.sceneName = reader["sceneName"].ToString();
                        exerciseQueryObj.questionTypeNumber = Convert.ToInt32(reader["questionTypeNumber"]);
                        exerciseQueryObj.content = reader["content"].ToString();
                        exerciseQueryObj.teacherName = reader["teacherName"].ToString();
                        exerciseQueryObj.ExpName = reader["expName"].ToString();
                        exerciseQueryList.Add(exerciseQueryObj);
                    }
                }

                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        ExerciseQuery exerciseQueryObj = new ExerciseQuery();
                        exerciseQueryObj.id = Convert.ToInt32(reader["id"]);
                        exerciseQueryObj.sceneName = reader["sceneName"].ToString();
                        exerciseQueryObj.questionTypeNumber = Convert.ToInt32(reader["questionTypeNumber"]);
                        exerciseQueryObj.content = reader["content"].ToString();
                        exerciseQueryObj.teacherName = reader["teacherName"].ToString();
                        exerciseQueryObj.ExpName = reader["expName"].ToString();
                        exerciseQueryList.Add(exerciseQueryObj);
                    }
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
            return exerciseQueryList;
        }
    }
}
