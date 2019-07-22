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
    public class TeacherInfoService
    {
        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <returns></returns>
        public int TestLink() 
        {
            return SqlHelper.DataBaseLinkTest();
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="teacherInfo"></param>
        /// <returns></returns>
        public TeacherInfo UserLogin(TeacherInfo teacherInfo)
        {
            if(teacherInfo==null)
            {
                return null;
            }
            string sql = "select teacherNumber,teacherName,pwd,adminType from TeacherInfo where teacherNumber='{0}' and pwd='{1}'";
            sql = string.Format(sql, teacherInfo.teacherNumber, teacherInfo.pwd);
            MySqlDataReader reader=null;
            try
            {
                reader = SqlHelper.GetReader(sql);
                if (reader != null && reader.Read())
                {
                    teacherInfo.teacherName = reader["teacherName"].ToString();
                    teacherInfo.adminType = Convert.ToInt32(reader["adminType"].ToString());
                }
                else
                {
                    teacherInfo = null;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { 
                if(reader!=null){

                    reader.Close();
                }
            }
            return teacherInfo;
        }


        /// <summary>
        /// 修改登录密码
        /// </summary>
        /// <param name="teacherNumber">教师工号</param>
        /// <param name="pwd">新密码</param>
        /// <returns></returns>
        public int ModifyPwd(string teacherNumber, string pwd)
        {
            string sql = "update TeacherInfo set pwd='{0}' where teacherNumber='{1}'";
            sql = string.Format(sql,pwd,teacherNumber);
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
        /// 根据教师工号获取管理员登录的类型
        /// </summary>
        /// <param name="teacherNumber"></param>
        /// <returns></returns>
        public int GetAdminType(string teacherNumber)
        {
            string sql = "select adminType from TeacherInfo where teacherNumber='"+teacherNumber+"'";
            MySqlDataReader reader = null;
            try
            {
                reader = SqlHelper.GetReader(sql);
                if (reader != null && reader.Read())
                {
                    return Convert.ToInt32(reader["adminType"]);
                }
                else
                {
                    return 0;
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
            
        }



        /// <summary>
        /// 添加老师
        /// </summary>
        /// <param name="teacherInfo">包含添加信息的实体类</param>
        /// <returns></returns>
        public int AddTeacher(TeacherInfo teacherInfo)
        {
            string sql = "insert into teacherinfo(teacherNumber,teacherName,pwd,adminType) values('{0}','{1}','{2}',{3})";
            sql = string.Format(sql, teacherInfo.teacherNumber, teacherInfo.teacherName, teacherInfo.pwd, teacherInfo.adminType);
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
        /// 通过教师工号获取教师信息
        /// </summary>
        /// <param name="teacherNumber"></param>
        /// <returns></returns>
        public TeacherInfo GetTeacherInfoByTeacherNumber(string teacherNumber)
        {
            string sql = "select teacherNumber,teacherName,pwd,adminType from TeacherInfo where teacherNumber='" + teacherNumber + "'";
            MySqlDataReader reader = null;
            TeacherInfo teacherInfo = null;
            try
            {
                reader = SqlHelper.GetReader(sql);
                if (reader != null && reader.Read())
                {
                    teacherInfo = new TeacherInfo();
                    teacherInfo.teacherNumber = reader["teacherNumber"].ToString();
                    teacherInfo.teacherName = reader["teacherName"].ToString();
                    teacherInfo.adminType = Convert.ToInt32(reader["adminType"].ToString());
                    teacherInfo.pwd = reader["pwd"].ToString();
                }
                else
                {
                    teacherInfo = null;
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
            return teacherInfo;
        }


        /// <summary>
        /// 获取教师信息
        /// </summary>
        /// <returns></returns>
        public List<TeacherInfo> GetTeacherInfo()
        {
            string sql = "select teacherNumber,teacherName,pwd,adminType from TeacherInfo";
            MySqlDataReader reader = null;
            List<TeacherInfo> teacherInfoList =new List<TeacherInfo>();
            try
            {
                reader = SqlHelper.GetReader(sql);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        TeacherInfo teacherInfo = new TeacherInfo();
                        teacherInfo.teacherNumber = reader["teacherNumber"].ToString();
                        teacherInfo.teacherName = reader["teacherName"].ToString();
                        teacherInfo.adminType = Convert.ToInt32(reader["adminType"].ToString());
                        teacherInfo.pwd = reader["pwd"].ToString();

                        teacherInfoList.Add(teacherInfo);
                    }
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
            return teacherInfoList;
        }


        /// <summary>
        /// 修改教师信息
        /// </summary>
        /// <param name="teacherInfo">含有教师信息的实体类</param>
        /// <returns></returns>
        public int ModifyTeacherInfo(TeacherInfo teacherInfo)
        {
            string sql = "update TeacherInfo set teacherName='{0}',pwd='{1}' where teacherNumber='{2}'";
            sql = string.Format(sql,teacherInfo.teacherName,teacherInfo.pwd,teacherInfo.teacherNumber);
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
        /// 根据教师工号删除教师信息
        /// </summary>
        /// <param name="teacherNumber">教师工号</param>
        /// <returns></returns>
        public int DeleteTeacherInfoByTeacherNumber(string teacherNumber)
        {
            string sql = "delete from TeacherInfo where teacherNumber='"+teacherNumber+"'";
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
