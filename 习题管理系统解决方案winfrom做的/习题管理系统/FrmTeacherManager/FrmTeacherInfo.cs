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
using BLL;

namespace 习题管理系统.FrmTeacherManager
{
    public partial class FrmTeacherInfo : Form
    {
        public FrmTeacherInfo()
        {
            InitializeComponent();

            dgvTeacherInfo.AutoGenerateColumns = false;
            ShowTeacherInfo();
        }


        /// <summary>
        /// 展示教师的信息
        /// </summary>
        private void ShowTeacherInfo() {
            List<TeacherInfo> teacherInfoList = null;

            try
            {
                teacherInfoList = new TeacherInfoManager().GetTeacherInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("请检查网络是否畅通", "提示信息");
                return;
            }

            
            if (teacherInfoList != null && teacherInfoList.Count > 0)               //把查询出来的数据显示到datagridView控件上
            {
                dgvTeacherInfo.DataSource = teacherInfoList;
            }
        }

        /// <summary>
        /// 修改按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
          
            if (this.dgvTeacherInfo.CurrentRow == null)
            {
                MessageBox.Show("请选择需要修改的老师", "提示信息");          //安全校验
                return;
            }

            string teacherNumber = this.dgvTeacherInfo.CurrentRow.Cells["teacherNumber"].Value.ToString();      //获取当前行选择的教师工号

            if (teacherNumber == null || teacherNumber.Length == 0)
            {
                MessageBox.Show("修改失败，请检查网络","修改提示");
                return;
            }
            TeacherInfo teacherInfo = null;
            try
            {
                teacherInfo = new TeacherInfoManager().GetTeacherInfoByTeacherNumber(teacherNumber);
            }
            catch (Exception)
            {

                MessageBox.Show("请检查网络是否畅通","提示信息");
                return;
            }

            if (teacherInfo != null)
            { 
                //打开修改老师信息的窗口
                FrmTeacherInfoModify teacherInfoModify = new FrmTeacherInfoModify(teacherInfo);
                DialogResult modifyResult=teacherInfoModify.ShowDialog();
                if (modifyResult == DialogResult.OK)
                {
                    //修改成功，刷新页面
                    ShowTeacherInfo();
                }
               
            }
        }


        /// <summary>
        /// 删除按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvTeacherInfo.CurrentRow == null)
            {
                MessageBox.Show("请选择需要删除的老师", "提示信息");          //安全校验
                return;
            }

            string teacherNumber = this.dgvTeacherInfo.CurrentRow.Cells["teacherNumber"].Value.ToString();      //获取当前行选择的教师工号

            if (teacherNumber == null || teacherNumber.Length == 0)
            {
                MessageBox.Show("修改失败，请检查网络", "修改提示");
                return;
            }

            #region 调用后台进行删除
            int deleteResult = 0;                   //保存修改的结果
            try
            {
                deleteResult = new TeacherInfoManager().DeleteTeacherInfoByTeacherNumber(teacherNumber);
            }
            catch (Exception)
            {

                MessageBox.Show("删除失败，请检查网络","删除提示");
                return;
            }

            if (deleteResult > 0)
            {

                ShowTeacherInfo();      //删除成功，刷新页面
            }
            #endregion
        }
    }
}
