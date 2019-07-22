using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ExerciseQuery
    {

        /// <summary>
        /// 实验名称
        /// </summary>
        public string ExpName { set; get; }

        

        /// <summary>
        /// 题目描述
        /// </summary>
        public string Describe { set; get; }


        /// <summary>
        /// 习题问题内容
        /// </summary>
        public string content { set; get; }


        /// <summary>
        /// 习题类型(1:选择题 2：填空题  3:简答题)
        /// </summary>
        public int questionTypeNumber { set; get; }


        /// <summary>
        /// 习题类型的中文名称
        /// </summary>
        public string questonTypeName { set; get; }

        /// <summary>
        /// 添加老师名称
        /// </summary>
        public string teacherName { set; get; }

        /// <summary>
        /// 题目本来的id号
        /// </summary>
        public int id { set; get; }


        /// <summary>
        /// 场景名称
        /// </summary>
        public string sceneName { set; get; }

    }
}
