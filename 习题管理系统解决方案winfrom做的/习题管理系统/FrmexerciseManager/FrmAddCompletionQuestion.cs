using BLL;
using FVCCommon;
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

namespace 习题管理系统.FrmexerciseManager
{
    public partial class FrmAddCompletionQuestion : Form
    {
        ExpsTableManager expsManager = new ExpsTableManager();
        public FrmAddCompletionQuestion()
        {
            InitializeComponent();

            //实验室下拉框初始化
            List<string> labRoomList = new List<string>();
            try
            {
                labRoomList = expsManager.GetLabRoomName();
            }
            catch (Exception)
            {

                MessageBox.Show("操作失败,请检查您的网络是否畅通");
                return;
            }

            if (labRoomList != null && labRoomList.Count > 0)
            {
                this.cbLabRoom.DataSource = labRoomList;
                this.cbLabRoom.SelectedIndex = -1;
                this.cbLabRoom.SelectedIndexChanged += new System.EventHandler(this.cbLabRoom_SelectedIndexChanged);         //动态注册下拉框下标改变事件
            }



        }


        private void cbLabRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cbLabRoom.Text == null || this.cbLabRoom.Text.Trim().Length == 0)      //安全验证，实验室名称下拉框验证是否为空
            {
                return;
            }
            if (this.cbLabRoom.SelectedIndex == -1)
            {
                return;
            }
            string labRoom = this.cbLabRoom.Text.Trim();                            //实验室的名称
            if (labRoom.Trim().Length == 0)
            {
                return;
            }
            List<ExpsTable> expsList = new List<ExpsTable>();                       //存储实验信息的集合

            try
            {
                expsList = expsManager.GetExpsInfoByLabRoom(labRoom);
                if (expsList != null && expsList.Count > 0)
                {

                    this.cbChooseExperiment.DataSource = null;              //实验名称下拉框清空
                    this.cbChooseExperiment.DataSource = expsList;          //绑定数据
                    this.cbChooseExperiment.DisplayMember = "ExpName";
                    this.cbChooseExperiment.ValueMember = "SceneName";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("请检查您的网络是否畅通");
                return;
            }
        }

        /// <summary>
        /// 添加图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png图片文件|*.png|jpg图片|*.jpg";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            DialogResult chooseResult = openFileDialog.ShowDialog();
            if (chooseResult == DialogResult.OK)
            {
                this.pcAddPicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        #region 关闭窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 添加按钮点击事件
        private void btnAdd_Click(object sender, EventArgs e)
        {

            #region 数据安全校验
            if (this.cbLabRoom.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择实验室", "添加提示");
                this.cbLabRoom.Focus();
                return;
            }

            if (this.cbChooseExperiment.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择实验名称", "添加提示");
                this.cbChooseExperiment.Focus();
                return;
            }

            if (this.txtContent.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写问题", "添加提示");
                this.txtContent.Focus();
                return;
            }
                      

            if (this.txtScore.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写分值", "添加提示");
                this.txtScore.Focus();
                return;
            }

            if (this.txtAnswer.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写参考答案", "添加提示");
                this.txtAnswer.Focus();
                return;
            }

            if (!DataValidate.IsNumber(this.txtScore.Text.Trim()))
            {
                MessageBox.Show("输入的分数必须是数字");
                this.txtScore.Focus();
                return;
            }

            if (Program.teacherInfo.teacherName == null || Program.teacherInfo.teacherName.Trim().Length == 0)
            {
                MessageBox.Show("您进行了非法操作，请重启系统重试");
                return;
            }
            #endregion


            #region 对象封装
            string sceneName = this.cbChooseExperiment.SelectedValue.ToString();        //场景名称
            string content = this.txtContent.Text.Trim();                               //问题内容
            string picture = "";
            string expName = this.cbChooseExperiment.Text.Trim();                       //实验名称
            try
            {
                picture = this.pcAddPicture.Image == null ? "" : new SerializeObjectToString().SerializeObject(this.pcAddPicture.Image);
            }
            catch (Exception)
            {
                MessageBox.Show("添加图片失败");
                return;
            }
           
            string score = this.txtScore.Text.Trim();                       //分值
            string answer = this.txtAnswer.Text.Trim();                     //参考答案

            CompletionQuestion completionQuestion = new CompletionQuestion()
            {
                expName = expName,
                sceneName = sceneName,
                content = content,
                picture = picture,
                score =score,
                answer = answer,
                questionTypeNumber = 2,
                teacherName = Program.teacherInfo.teacherName

            };
            #endregion
            #region 调用后台进行添加数据
            int addResult = 0;                  //添加结果
            try
            {
                addResult = new CompletionQuestionManager().AddCompletionQuestion(completionQuestion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败:"+ex.Message);
                return;
                
            }
            if (addResult > 0)
            {
               DialogResult dialogResult=MessageBox.Show("添加成功,继续添加吗?", "添加提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
               if (dialogResult == DialogResult.Yes)                //继续添加，则把里面的文本框和下拉框清空或者还原
               {
                   foreach (var control in this.Controls)
                   {
                       if (control is TextBox)
                       {
                           (control as TextBox).Text = "";
                       }
                       else if (control is ComboBox)
                       {
                           (control as ComboBox).SelectedIndex = -1;
                       }
                       else if (control is PictureBox)
                       {
                           (control as PictureBox).Image = null;
                       }
                   }
               }
               else
               {
                   this.Close();                                    //不继续添加，则把窗体关掉
               }
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            #endregion
        }
        #endregion

        #region 置空按钮点击事件
        private void btnSetNull_Click(object sender, EventArgs e)
        {
            this.pcAddPicture.Image = null;
        }
        #endregion
    }
}
