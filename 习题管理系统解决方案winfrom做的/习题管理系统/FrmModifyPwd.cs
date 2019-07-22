using FVCCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using BLL;
namespace 习题管理系统
{
    public partial class FrmModifyPwd : Form
    {
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        #region 取消按钮，关闭窗体
        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 确认按钮点击事件
        private void btnModify_Click(object sender, EventArgs e)
        {
            #region 数据安全校验
            if (Program.teacherInfo == null)
            {
                MessageBox.Show("您进行了非法操作，请重新登录再进行操作","修改提示");
                return;
            }


            if (this.txtOldPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入原密码","修改提示");
                this.txtOldPwd.Focus();
                return;
            }

            if (this.txtNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入新密码", "修改提示");
                this.txtNewPwd.Focus();
                return;
            }

            if (this.txtNewPwdConform.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入确认密码", "修改提示");
                this.txtNewPwdConform.Focus();
                return;
            }

            if (this.txtNewPwd.Text.Trim() != this.txtNewPwdConform.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致", "修改提示");
                this.txtNewPwdConform.Focus();
                return;
            }

            if (this.txtOldPwd.Text.Trim() != Program.teacherInfo.pwd)
            {
                MessageBox.Show("原密码不正确", "修改提示");
                this.txtOldPwd.Focus();
                return;
            }

            if (this.txtOldPwd.Text.Trim() == this.txtNewPwd.Text.Trim())
            {
                MessageBox.Show("新密码不能与原密码相同", "修改提示");
                this.txtNewPwd.Focus();
                return;
            }

            
            #endregion

            #region 进行修改
            int modifyResult = 0;                   //保存修改结果
            try
            {
                modifyResult = new TeacherInfoManager().ModifyPwd(Program.teacherInfo.teacherNumber, this.txtNewPwd.Text.Trim());
            }
            catch (Exception)
            {

                MessageBox.Show("网络异常，请检查您的网络");
            }
            if (modifyResult > 0)
            {
                MessageBox.Show("修改成功", "修改提示");

                Program.teacherInfo.pwd = this.txtNewPwd.Text.Trim();     //把修改成功的密码保存在当前系统

                this.Close();                                             //关闭当前窗口
                return;
            }
            else
            {
                MessageBox.Show("修改失败，请检查您的网络","修改提示");
            }
            #endregion
        }
        #endregion
    }
}
