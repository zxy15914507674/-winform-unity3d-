using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 习题管理系统.FrmTeacherManager
{
    public partial class FrmAddTeacher : Form
    {
        public FrmAddTeacher()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取消按钮点击事件，关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 确定按钮点击事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 数据验证
            if (this.txtTeacherName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入教师姓名","添加提示");
                this.txtTeacherName.Focus();
                return;
            }

            if (this.txtTeacherNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入教师工号", "添加提示");
                this.txtTeacherName.Focus();
                return;
            }


            if (this.txtPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码", "添加提示");
                this.txtPwd.Focus();
                return;
            }


            try
            {
                if (new TeacherInfoManager().GetTeacherInfoByTeacherNumber(this.txtTeacherNumber.Text.Trim()) != null)
                {
                    MessageBox.Show("该老师工号已经被使用了，请使用另外一个工号进行添加","添加提示");
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("添加失败,请检查网络是否畅通","添加提示");
                return;
            }

            #endregion

            #region 对象封装
            TeacherInfo teacherInfo = new TeacherInfo();
            teacherInfo.teacherName = this.txtTeacherName.Text.Trim();
            teacherInfo.teacherNumber = this.txtTeacherNumber.Text.Trim();
            teacherInfo.pwd = this.txtPwd.Text.Trim();
            teacherInfo.adminType = 2;
            #endregion

            #region 进行添加
            int addResult = 0;                         //记录添加结果
            try
            {
                addResult = new TeacherInfoManager().AddTeacher(teacherInfo);
            }
            catch (Exception)
            {

                MessageBox.Show("添加失败，请检查网络是否畅通","添加提示");
                return;
            }
            if (addResult > 0)
            {
               DialogResult dialogResult=MessageBox.Show("添加成功,继续添加吗?", "添加提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
               if (dialogResult == DialogResult.Yes)               //继续添加，清空文本框里面的内容
               {
                   foreach (var control in Controls)
                   {
                       if (control is TextBox)
                       {
                           (control as TextBox).Text = "";
                       }
                   }
               }
               else             //不继续添加，关闭窗体
               {
                   this.Close();
               }
            }
            else 
            {
                MessageBox.Show("添加失败,请检查网络是否畅通","添加提示");
                return;
            }
            #endregion
        }
        #endregion
    }
}
