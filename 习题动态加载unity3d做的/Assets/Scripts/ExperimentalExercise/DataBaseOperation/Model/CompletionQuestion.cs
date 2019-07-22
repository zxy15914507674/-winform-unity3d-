using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fvc.exp.model
{
    /// <summary>
    /// 填空题实体类
    /// </summary>
    public class CompletionQuestion
    {
        /****
         * 
            id int primary key auto_increment,
            expName varchar(20) not null,
            sceneName varchar(50) not null,
            questionTypeNumber tinyint not null,
            content mediumtext not null,
            picture mediumtext,
            answer text not null,
            score tinyint not null,
            teacherName varchar(10) not null 
         */
        public int id { set; get; }
        public string expName { set; get; }
        public string sceneName { set; get; }
        public int questionTypeNumber { set; get; }
        public string content { set; get; }
        public string picture { set; get; }
        public string answer { set; get; }
        public string score { set; get; }
 


        /// <summary>
        /// 保存用户的答案   键为题号，值为对应的答案
        /// </summary>
        public Dictionary<int, string> userAnswerDic = new Dictionary<int, string>();
    }
}
