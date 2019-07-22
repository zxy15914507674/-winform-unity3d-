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

using FVCCommon;
namespace 习题管理系统.FrmexerciseManager
{
    public partial class FrmModifyCompletionQuestion : Form
    {
        ExpsTableManager expsManager = new ExpsTableManager();
        CompletionQuestion completionQuestionObj = null;
        public FrmModifyCompletionQuestion()
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

        public FrmModifyCompletionQuestion(CompletionQuestion completionQuestionObj): this()
        {
            if (completionQuestionObj != null)
            {
                this.cbLabRoom.Text = completionQuestionObj.labRoom;
                this.cbChooseExperiment.Text = completionQuestionObj.expName;
                this.txtContent.Text = completionQuestionObj.content;
                this.txtScore.Text = completionQuestionObj.score.ToString();
                this.txtAnswer.Text = completionQuestionObj.answer;
                this.txtTeacherName.Text = completionQuestionObj.teacherName;

                if (completionQuestionObj.picture != null && completionQuestionObj.picture.Trim().Length > 0)
                {
                    try
                    {
                        this.pcAddPicture.Image = (new SerializeObjectToString().DeserializeObject(completionQuestionObj.picture)) as Image;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("图片加载失败!", "提示信息");

                    }
                }
                this.completionQuestionObj = completionQuestionObj;
                this.cbLabRoom.Enabled = false;
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

        #region 添加图片
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
        #endregion

        #region 修改按钮点击事件
        private void btnModify_Click(object sender, EventArgs e)
        {
            #region 数据安全校验
            if (this.cbLabRoom.Text.Trim().Length == 0)
            {
                MessageBox.Show("网络出现异常，请关闭后重试!", "添加提示");
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
                MessageBox.Show("请填写题目", "添加提示");
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
            if (this.txtTeacherName.Text.Trim().Length == 0)
            {
                MessageBox.Show("填加人不能为空");
                this.txtTeacherName.Focus();
                return;
            }
            if (Program.teacherInfo.teacherName == null || Program.teacherInfo.teacherName.Trim().Length == 0)
            {
                MessageBox.Show("您进行了非法操作，请重启系统重试");
                return;
            }

            
            #endregion


            #region 封装对象
            CompletionQuestion completionQuestion = new CompletionQuestion();
            if (this.completionQuestionObj==null||this.completionQuestionObj.id == 0)
            {
                MessageBox.Show("修改失败，网络异常，请关闭后重试", "添加提示");
                return;
            }

            completionQuestion.id = this.completionQuestionObj.id;
            completionQuestion.sceneName = this.cbChooseExperiment.SelectedValue.ToString();
            completionQuestion.expName = this.cbChooseExperiment.Text.Trim();
            completionQuestion.content = this.txtContent.Text.Trim();
            completionQuestion.score = this.txtScore.Text.Trim();
            completionQuestion.teacherName = this.txtTeacherName.Text.Trim();
            completionQuestion.answer = this.txtAnswer.Text.Trim();

            completionQuestion.picture = this.pcAddPicture.Image == null ? "" : new SerializeObjectToString().SerializeObject(this.pcAddPicture.Image);

            #endregion


            #region 调用后台进行修改数据
            int modifyResult = 0;           //保存修改结果
            try
            {
                modifyResult = new CompletionQuestionManager().ModifyCompletionQuestion(completionQuestion);
            }
            catch (Exception)
            {

                MessageBox.Show("修改失败，网络异常，请重试", "修改提示");
                return;
            }
            if (modifyResult > 0)
            {
                MessageBox.Show("修改成功", "修改提示");
                this.DialogResult = DialogResult.OK;           //用来刷新修改后的数据
            }
            else
            {
                MessageBox.Show("修改失败", "修改提示");
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

        #region 取消按钮，关闭窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
