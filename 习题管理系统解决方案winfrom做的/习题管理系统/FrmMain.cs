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
using 习题管理系统.FrmexerciseManager;
using 习题管理系统.FrmTeacherManager;

namespace 习题管理系统
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            
            if(Program.teacherInfo!=null)
            {
                this.userName.Text = Program.teacherInfo.teacherName + "】";       //显示登录的用户名
            }
        }

        #region 退出系统

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult closeResult=MessageBox.Show("确定退出吗?", "退出询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           if(closeResult==DialogResult.Cancel)
           {
               e.Cancel = true;
           }
        }

        /// <summary>
        /// 快捷菜单的方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitSystemQuickMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 菜单栏方式退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitSysMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #endregion

        #region 弹出添加选择题窗体

        /// <summary>
        /// 快捷菜单方式进行添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChooseQuestionQuickMenu_Click(object sender, EventArgs e)
        {
           FrmAddChooseQuestion frmAddChooseQuestion= new  FrmAddChooseQuestion();
          
           frmAddChooseQuestion.ShowDialog();

            
        }

        /// <summary>
        /// 菜单栏方式添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChooseQuestionMenu_Click(object sender, EventArgs e)
        {
            AddChooseQuestionQuickMenu_Click(null,null);
        }
        #endregion

        #region 弹出习题查询窗体

        /// <summary>
        /// 快捷菜单方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exerciseQueryQuickMenu_Click(object sender, EventArgs e)
        {
            FrmExerciseQuery exerciseQuery = new FrmExerciseQuery();
            exerciseQuery.ShowDialog();
        }

        /// <summary>
        /// 菜单栏方式进行查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exerciseQueryMenu_Click(object sender, EventArgs e)
        {
            exerciseQueryQuickMenu_Click(null,null);
        }
        #endregion

        #region 弹出添加填空题窗体
        /// <summary>
        /// 快捷菜单方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCompletionQuestionQuickMenu_Click(object sender, EventArgs e)
        {
            FrmAddCompletionQuestion completionQuestion = new FrmAddCompletionQuestion();
            completionQuestion.ShowDialog();
        }

        /// <summary>
        /// 菜单方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCompletionQuestionMenu_Click(object sender, EventArgs e)
        {
            FrmAddCompletionQuestion completionQuestion = new FrmAddCompletionQuestion();
            completionQuestion.ShowDialog();
        }
        #endregion

        #region 弹出添加简答题窗体
        
        /// <summary>
        /// 快捷菜单方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddShortAnswerQuestionQuickMenu_Click(object sender, EventArgs e)
        {
            FrmAddShortAnswerQuestion shortAnswerQuestionObj = new FrmAddShortAnswerQuestion();
            shortAnswerQuestionObj.ShowDialog();
        }

        /// <summary>
        /// 菜单栏方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddShortAnswerQuestionMenu_Click(object sender, EventArgs e)
        {
            FrmAddShortAnswerQuestion shortAnswerQuestionObj = new FrmAddShortAnswerQuestion();
            shortAnswerQuestionObj.ShowDialog();
        }
        #endregion

        #region 弹出密码修改窗体
        
        /// <summary>
        /// 快捷菜单的方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyPwdMenu_Click(object sender, EventArgs e)
        {
            FrmModifyPwd modifyPwd = new FrmModifyPwd();
            modifyPwd.ShowDialog();
        }

        /// <summary>
        /// 菜单栏的方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd modifyPwd = new FrmModifyPwd();
            modifyPwd.ShowDialog();
        }
        #endregion

        #region 打开新增教师窗口

        private void AddTeacherMenu_Click(object sender, EventArgs e)
        {
            #region 数据验证
            int adminType = 0;                  //管理员的类型
            if (Program.teacherInfo == null)
            {
                MessageBox.Show("您进行了非法操作，请退出系统后再操作","添加提示");
                return;
            }
            try
            {
                adminType = new TeacherInfoManager().GetAdminType(Program.teacherInfo.teacherNumber);
               
            }
            catch (Exception)
            {

                MessageBox.Show("操作失败，请检查网络","添加提示");
                return;
            }

            if (adminType != 1)
            {
                MessageBox.Show("您不是管理员，无法进行添加操作，如需操作，请联系管理员", "添加提示");
                return;
            }
            #endregion

            #region 打开新增教师窗口
            FrmAddTeacher addTeacher = new FrmAddTeacher();
            addTeacher.ShowDialog();
            #endregion
        }
        #endregion

        #region 打开查询教师信息窗口
        private void TeacherInfoMenu_Click(object sender, EventArgs e)
        {
            #region 数据验证
            int adminType = 0;                  //管理员的类型
            if (Program.teacherInfo == null)
            {
                MessageBox.Show("您进行了非法操作，请退出系统后再操作", "添加提示");
                return;
            }
            try
            {
                adminType = new TeacherInfoManager().GetAdminType(Program.teacherInfo.teacherNumber);

            }
            catch (Exception)
            {

                MessageBox.Show("操作失败，请检查网络", "添加提示");
                return;
            }

            if (adminType != 1)
            {
                MessageBox.Show("您不是管理员，无法进行添加操作，如需操作，请联系管理员", "添加提示");
                return;
            }
            #endregion

            FrmTeacherInfo teacherInfo = new FrmTeacherInfo();
            teacherInfo.ShowDialog();
        }
        #endregion


















    }
}
