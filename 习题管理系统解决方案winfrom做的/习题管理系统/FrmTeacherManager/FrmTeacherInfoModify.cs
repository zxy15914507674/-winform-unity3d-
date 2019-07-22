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

namespace 习题管理系统.FrmTeacherManager
{
    public partial class FrmTeacherInfoModify : Form
    {
        public FrmTeacherInfoModify()
        {
            InitializeComponent();
        }


        public FrmTeacherInfoModify(TeacherInfo teacherInfo): this()
        {
            this.txtTeacherName.Text = teacherInfo.teacherName;
            this.txtTeacherNumber.Text = teacherInfo.teacherNumber;
            this.txtPwd.Text = teacherInfo.pwd;

            this.txtTeacherNumber.Enabled = false;              //教师工号不允许修改
        }

        /// <summary>
        /// 取消按钮点击事件,关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 修改按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            #region 数据验证
            if (this.txtTeacherName.Text.Trim().Length == 0)
            {
                MessageBox.Show("教师姓名不能为空","修改提示");
                this.txtTeacherName.Focus();
                return;
            }

            if (this.txtPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("密码不能为空", "修改提示");
                this.txtPwd.Focus();
                return;
            }


            
            #endregion


            #region 数据封装
            TeacherInfo teacherInfo = new TeacherInfo();
            teacherInfo.teacherName = this.txtTeacherName.Text.Trim();
            teacherInfo.teacherNumber = this.txtTeacherNumber.Text.Trim();
            teacherInfo.pwd = this.txtPwd.Text.Trim();
            #endregion


            #region 调用后台进行修改
            int modifyResult = 0;                       //保存修改结果
            try
            {
                modifyResult = new TeacherInfoManager().ModifyTeacherInfo(teacherInfo);
            }
            catch (Exception)
            {

                MessageBox.Show("请检查网络是否畅通","修改提示");
                return;
            }

            if (modifyResult > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("修改失败","修改提示");
                return;
            }
            #endregion
        }
    }
}
