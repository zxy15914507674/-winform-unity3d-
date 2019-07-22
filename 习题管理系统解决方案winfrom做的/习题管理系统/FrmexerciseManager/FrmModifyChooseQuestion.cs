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
    public partial class FrmModifyChooseQuestion : Form
    {
        ExpsTableManager expsManager = new ExpsTableManager();

        ChoiceQuestion choiceQuestionObj;                           //用来保存通过构造方法传入的习题信息
        public FrmModifyChooseQuestion()
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

        public FrmModifyChooseQuestion(ChoiceQuestion choiceQuestionObj):this()
        {


            if (choiceQuestionObj != null)
            {
                this.cbLabRoom.Text = choiceQuestionObj.labRoom;
                this.cbChooseExperiment.Text = choiceQuestionObj.expName;
                this.txtContent.Text = choiceQuestionObj.content;
                this.txtOptionA.Text = choiceQuestionObj.optionA;
                this.txtOptionB.Text = choiceQuestionObj.optionB;
                this.txtOptionC.Text = choiceQuestionObj.optionC;
                this.txtOptionD.Text = choiceQuestionObj.optionD;
                this.txtScore.Text = choiceQuestionObj.score;
                this.txtAnswer.Text = choiceQuestionObj.answer;
                this.txtTeacherName.Text = choiceQuestionObj.teacherName;

                if (choiceQuestionObj.picture != null && choiceQuestionObj.picture.Trim().Length > 0)
                {
                    try
                    {
                        this.pcAddPicture.Image = (new SerializeObjectToString().DeserializeObject(choiceQuestionObj.picture)) as Image;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("图片加载失败!","提示信息");

                    }
                }
                this.choiceQuestionObj = choiceQuestionObj;
            }

            this.cbLabRoom.Enabled = false;
        }

        /// <summary>
        /// 选择图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
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


        private void cbLabRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cbLabRoom.Text == null || this.cbLabRoom.Text.Trim().Length == 0)      //安全验证，实验室名称下拉框验证是否为空
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
                MessageBox.Show("请填写问题", "添加提示");
                this.txtContent.Focus();
                return;
            }

            if (this.txtOptionA.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写选项A的内容", "添加提示");
                this.txtOptionA.Focus();
                return;
            }

            if (this.txtOptionB.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写选项B的内容", "添加提示");
                this.txtOptionB.Focus();
                return;
            }

            if (this.txtOptionC.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写选项C的内容", "添加提示");
                this.txtOptionC.Focus();
                return;
            }

            if (this.txtOptionD.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写选项D的内容", "添加提示");
                this.txtOptionD.Focus();
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

            if (!(this.txtAnswer.Text == "A" || this.txtAnswer.Text == "B" || this.txtAnswer.Text == "C" || this.txtAnswer.Text == "D"))
            {
                MessageBox.Show("参考答案必须是大写的  A、B、C、D,并且只能有一个");
                return;
            }
            #endregion


            #region 封装对象
            ChoiceQuestion choiceQuestion = new ChoiceQuestion();
            if (this.choiceQuestionObj.id == 0)
            {
                MessageBox.Show("修改失败，网络异常，请关闭后重试","添加提示");
                return;
            }

            choiceQuestion.id = this.choiceQuestionObj.id;
            choiceQuestion.sceneName = this.cbChooseExperiment.SelectedValue.ToString();
            choiceQuestion.expName = this.cbChooseExperiment.Text.Trim();
            choiceQuestion.content = this.txtContent.Text.Trim();
            choiceQuestion.optionA = this.txtOptionA.Text.Trim();
            choiceQuestion.optionB = this.txtOptionB.Text.Trim();
            choiceQuestion.optionC = this.txtOptionC.Text.Trim();
            choiceQuestion.optionD = this.txtOptionD.Text.Trim();
            choiceQuestion.score = this.txtScore.Text.Trim();
            choiceQuestion.teacherName = this.txtTeacherName.Text.Trim();
            choiceQuestion.answer = this.txtAnswer.Text.Trim();

            choiceQuestion.picture = this.pcAddPicture.Image == null ? "" : new SerializeObjectToString().SerializeObject(this.pcAddPicture.Image);

            #endregion


            #region 调用后台进行修改数据
            int modifyResult = 0;           //保存修改结果
            try
            {
                modifyResult = new ChoiceQuestionManager().ModifyChoiceQueston(choiceQuestion);
            }
            catch (Exception)
            {

                MessageBox.Show("修改失败，网络异常，请重试","修改提示");
                return;
            }
            if (modifyResult > 0)
            {
                MessageBox.Show("修改成功", "修改提示");
                this.DialogResult = DialogResult.OK;           //用来刷新修改后的数据
            }
            else {
                MessageBox.Show("修改失败","修改提示");
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
