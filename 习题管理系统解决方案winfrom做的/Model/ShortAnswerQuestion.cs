using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 简答题实体类
    /// </summary>
    public class ShortAnswerQuestion
    {
        /***** 
         * (id int  primary key auto_increment ,
            expName varchar(20) not null,
            sceneName varchar(50) not null,
            questionTypeNumber tinyint not null,
            content mediumtext not null,
            picture mediumtext,
            answer text not null,
            keyword text not null,
            score varchar(10) not null,
            teacherName varchar(10) not null)
         */

        /// <summary>
        /// 习题编号
        /// </summary>
        public int id { set; get; }


        /// <summary>
        /// 场景名称
        /// </summary>
        public string sceneName { set; get; }


        /// <summary>
        /// 实验名称
        /// </summary>
        public string expName { set; get; }


        /// <summary>
        /// 习题类型
        /// </summary>
        public int questionTypeNumber { set; get; }


        /// <summary>
        /// 习题问题
        /// </summary>
        public string content { set; get; }


        /// <summary>
        /// 习题图片
        /// </summary>
        public string picture { set; get; }


        /// <summary>
        /// 习题参考答案
        /// </summary>
        public string answer { set; get; }


        /// <summary>
        /// 习题得分关键词
        /// </summary>
        public string keyword { set; get; }

        /// <summary>
        /// 习题得分
        /// </summary>
        public string score { set; get; }

        /// <summary>
        /// 添加人名称
        /// </summary>
        public string teacherName { set; get; }




        /// <summary>
        /// 所属实验室名称
        /// </summary>
        public string labRoom { set; get; }

    }
}
