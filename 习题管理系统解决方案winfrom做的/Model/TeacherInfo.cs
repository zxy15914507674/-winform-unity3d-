using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 教师信息实体类
    /// </summary>

    public class TeacherInfo
    {
        public string teacherNumber { set;get;}

        public string teacherName { set; get; }

        public string pwd { set; get; }

        public int adminType { set; get; }
    }
}
