using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace 习题管理系统
{
    public partial class FrmLogin : Form
    {
        TeacherInfoManager teacherInfoManager = new TeacherInfoManager();
        public FrmLogin()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 用户登录按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.txtLoginNumber.Text.Trim().Length==0||this.txtLoginPwd.Text.Trim().Length==0)
            {
                return;
            }

            string loginNumber = this.txtLoginNumber.Text.Trim();           //教师工号
            string loginPwd = this.txtLoginPwd.Text.Trim();                 //登录密码

            TeacherInfo teacherInfo = new TeacherInfo()                     //封装对象
            { 
                     teacherNumber=loginNumber,
                     pwd=loginPwd
            };
            try
            {
                teacherInfo=teacherInfoManager.UserLogin(teacherInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("登录失败，请检查网络是否畅通");
                throw;
            }

            if (teacherInfo != null)
            {
                Program.teacherInfo = teacherInfo;              //保存登录信息


                this.DialogResult = DialogResult.OK;            //登录成功，进行页面跳转,只需要设置该登录的窗体的DialogResult为OK,再在Program类中进行跳转
            }
            else {
                MessageBox.Show("登录失败(用户名或者密码错误)");
            }
        }
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
