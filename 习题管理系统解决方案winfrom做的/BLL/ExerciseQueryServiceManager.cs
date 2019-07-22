using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
namespace BLL
{
    public class ExerciseQueryServiceManager
    {
        /// <summary>
        /// 根据实验场景查询相应的习题信息
        /// </summary>
        /// <param name="exerciseQuery">包含场景名称信息的实体类</param>
        /// <returns></returns>
        public List<ExerciseQuery> GetExerciseQueryInfoBySceneName(ExerciseQuery exerciseQuery)
        {
            List<ExerciseQuery> exerciseQueryList = null;
            exerciseQueryList = new ExerciseQueryService().GetExerciseQueryInfoBySceneName(exerciseQuery);
            if(exerciseQueryList!=null&&exerciseQueryList.Count>0)
            {
               
                foreach (var exerciseQueryItem in exerciseQueryList)
                {

                    //根据题目类型号补充相应的中文名称
                    int questionTypeNumber = exerciseQueryItem.questionTypeNumber;
                    if(questionTypeNumber==1)
                    {
                        exerciseQueryItem.questonTypeName = "单选题";
                      
                    }

                    else if (questionTypeNumber == 2)
                    {
                        exerciseQueryItem.questonTypeName = "填空题";
                       
                    }
                    else if (questionTypeNumber ==3)
                    {
                        exerciseQueryItem.questonTypeName = "简答题";
                       
                    }


                    //截取相应content，用来显示题目描述,截取12个字符
                    exerciseQueryItem.Describe = exerciseQueryItem.content.Length < 13 ? exerciseQueryItem.content : exerciseQueryItem.content.Substring(0, 13) + "...";

                }
            }

            return exerciseQueryList;
        }
    }
}
