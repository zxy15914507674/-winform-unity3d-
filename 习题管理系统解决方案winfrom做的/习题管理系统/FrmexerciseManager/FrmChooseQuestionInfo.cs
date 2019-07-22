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
using FVCCommon;

namespace 习题管理系统.FrmexerciseManager
{
    public partial class FrmChooseQuestionInfo : Form
    {
        public FrmChooseQuestionInfo()
        {
            InitializeComponent();
        }

        public FrmChooseQuestionInfo(ChoiceQuestion choiceQuestionObj)
        {
            InitializeComponent();
            if (choiceQuestionObj != null)
            {
                this.txtExpName.Text = choiceQuestionObj.expName;
                this.txtContent.Text = choiceQuestionObj.content;
                this.txtOptionA.Text = choiceQuestionObj.optionA;
                this.txtOptionB.Text = choiceQuestionObj.optionB;
                this.txtOptionC.Text = choiceQuestionObj.optionC;
                this.txtOptionD.Text = choiceQuestionObj.optionD;
                this.txtAnswer.Text = choiceQuestionObj.answer;
                this.txtScore.Text = choiceQuestionObj.score;
                this.txtTeacherName.Text = choiceQuestionObj.teacherName;

                if (choiceQuestionObj.picture.Trim().Length > 0)
                {
                    try
                    {
                        this.pcPicture.Image = (new SerializeObjectToString().DeserializeObject(choiceQuestionObj.picture)) as Image;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("无法查看习题图片");
                        return;
                    }
                }
                this.txtContent.SelectionStart = 0;
                this.txtContent.SelectionLength = 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
