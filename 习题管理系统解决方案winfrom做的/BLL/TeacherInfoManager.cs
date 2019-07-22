using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TeacherInfoManager
    {
         TeacherInfoService teacherInfoService= new TeacherInfoService();
        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <returns></returns>
        public int TestLink()
        {
            return new TeacherInfoService().TestLink();
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="teacherInfo"></param>
        /// <returns></returns>
        public TeacherInfo UserLogin(TeacherInfo teacherInfo)
        {
            try
            {
                return teacherInfoService.UserLogin(teacherInfo);
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        /// <summary>
        /// 修改登录密码
        /// </summary>
        /// <param name="teacherNumber">教师工号</param>
        /// <param name="pwd">新密码</param>
        /// <returns></returns>
        public int ModifyPwd(string teacherNumber, string pwd)
        {
            try
            {
                return teacherInfoService.ModifyPwd(teacherNumber, pwd);
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        /// <summary>
        /// 根据教师工号获取管理员登录的类型
        /// </summary>
        /// <param name="teacherNumber"></param>
        /// <returns></returns>
        public int GetAdminType(string teacherNumber)
        {
            try
            {
                return teacherInfoService.GetAdminType(teacherNumber);
            }
            catch (Exception)
            {
                
                throw;
            }
        }


         /// <summary>
        /// 添加老师
        /// </summary>
        /// <param name="teacherInfo">包含添加信息的实体类</param>
        /// <returns></returns>
        public int AddTeacher(TeacherInfo teacherInfo)
        {
            try
            {
                return teacherInfoService.AddTeacher(teacherInfo);
            }
            catch (Exception)
            {
                
                throw;
            }
        }


         /// <summary>
        /// 通过教师工号获取教师信息
        /// </summary>
        /// <param name="teacherNumber"></param>
        /// <returns></returns>
        public TeacherInfo GetTeacherInfoByTeacherNumber(string teacherNumber)
        {
            try
            {
                return teacherInfoService.GetTeacherInfoByTeacherNumber(teacherNumber);
            }
            catch (Exception)
            {

                throw;
            }
        }


         /// <summary>
        /// 获取教师信息
        /// </summary>
        /// <returns></returns>
        public List<TeacherInfo> GetTeacherInfo()
        {
            try
            {
                return teacherInfoService.GetTeacherInfo();
            }
            catch (Exception)
            {

                throw;
            }
        }


         /// <summary>
        /// 修改教师信息
        /// </summary>
        /// <param name="teacherInfo">含有教师信息的实体类</param>
        /// <returns></returns>
        public int ModifyTeacherInfo(TeacherInfo teacherInfo)
        {
            try
            {
                return teacherInfoService.ModifyTeacherInfo(teacherInfo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 根据教师工号删除教师信息
        /// </summary>
        /// <param name="teacherNumber">教师工号</param>
        /// <returns></returns>
        public int DeleteTeacherInfoByTeacherNumber(string teacherNumber)
        {
            try
            {
                return teacherInfoService.DeleteTeacherInfoByTeacherNumber(teacherNumber);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
