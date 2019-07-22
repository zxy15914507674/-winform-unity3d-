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
using Model;
using FVCCommon;

namespace 习题管理系统.FrmexerciseManager
{
    public partial class FrmAddChooseQuestion : Form
    {
        ExpsTableManager expsManager = new ExpsTableManager();

        ChoiceQuestionManager choiceQuestonManager = new ChoiceQuestionManager();
        public FrmAddChooseQuestion()
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

            if(labRoomList!=null&&labRoomList.Count>0)
            {
                this.cbLabRoom.DataSource = labRoomList;
                this.cbLabRoom.SelectedIndex = -1;
                this.cbLabRoom.SelectedIndexChanged += new System.EventHandler(this.cbLabRoom_SelectedIndexChanged);         //动态注册下拉框下标改变事件
            }
        }

        #region 选择图片
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png图片文件|*.png|jpg图片|*.jpg";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            DialogResult chooseResult = openFileDialog.ShowDialog();
            if(chooseResult==DialogResult.OK)
            {
                this.pcAddPicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        #endregion

        private void cbLabRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cbLabRoom.Text == null || this.cbLabRoom.Text.Trim().Length == 0)      //安全验证，实验室名称下拉框验证是否为空
            {      
                return;
            }
            if(this.cbLabRoom.SelectedIndex==-1){
                return;
            }
            string labRoom = this.cbLabRoom.Text.Trim();                            //实验室的名称
            if(labRoom.Trim().Length==0){
                return;
            }
            List<ExpsTable> expsList = new List<ExpsTable>();                       //存储实验信息的集合

            try
            {
                expsList = expsManager.GetExpsInfoByLabRoom(labRoom);
                if(expsList!=null&&expsList.Count>0){

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
        /// 添加习题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click_1(object sender, EventArgs e)
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

            if (Program.teacherInfo.teacherName == null || Program.teacherInfo.teacherName.Trim().Length==0)
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
            string optionA = this.txtOptionA.Text.Trim();                   //选项A
            string optionB = this.txtOptionB.Text.Trim();                   //选项B
            string optionC = this.txtOptionC.Text.Trim();                   //选项C
            string optionD = this.txtOptionD.Text.Trim();                   //选项D

            string score = this.txtScore.Text.Trim();                       //分值
            string answer = this.txtAnswer.Text.Trim();                     //参考答案

            ChoiceQuestion choiceQuestion = new ChoiceQuestion() { 
                 expName=expName,
                 sceneName=sceneName,
                 content=content,
                 picture=picture,
                 optionA=optionA,
                 optionB=optionB,
                 optionC=optionC,
                 optionD=optionD,
                 score=score,
                 answer=answer,
                 questionTypeNumber="1",
                 teacherName=Program.teacherInfo.teacherName

            };
            #endregion


            #region 进行添加
            int addResult = 0;                      //添加的结果
            try
            {
                  addResult=choiceQuestonManager.AddChoiceQuestion(choiceQuestion);
            }
            catch (Exception ex)
            {

                MessageBox.Show("添加失败"+ex.Message,"添加提示");
                return;
            }

            if (addResult > 0)
            {
                DialogResult continueAddResult = MessageBox.Show("添加成功,继续添加吗?", "添加提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (continueAddResult == DialogResult.Yes)
                {
                    //继续添加

                    foreach (var control in this.Controls)
                    {
                      
                        if(control is ComboBox)
                        {
                            (control as ComboBox).SelectedIndex = -1;           //是下拉框就恢复没选的状态
                        }
                        
                        if(control is TextBox)
                        {
                            (control as TextBox).Text = "";                     //是文本框就清空

                        }

                        if(control is PictureBox)
                        {
                            (control as PictureBox).Image = null;               //是图片控件，就把图片清空
                        }

                        this.cbLabRoom.Focus();                                 //实验室下拉框聚焦

                    }
                }
                else
                {
                    this.Close();                           //不继续添加，关闭窗口   
                }
            }
            else {
                MessageBox.Show("添加失败","添加提示");
            }
            #endregion




        }

        /// <summary>
        /// 取消按钮点击事件(关闭窗口)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 置空按钮点击事件
        private void btnSetNull_Click(object sender, EventArgs e)
        {
            this.pcAddPicture.Image = null;

        }
        #endregion
    }

}

