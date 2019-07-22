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
    public partial class FrmShortAnswerQuestionInfo : Form
    {
        public FrmShortAnswerQuestionInfo()
        {
            InitializeComponent();
        }

        public FrmShortAnswerQuestionInfo(ShortAnswerQuestion shortAnswerQuestion):this()
        {
            if (shortAnswerQuestion != null)
            {
                this.txtExpName.Text = shortAnswerQuestion.expName;
                this.txtContent.Text = shortAnswerQuestion.content;
                this.txtAnswer.Text = shortAnswerQuestion.answer;
                this.txtScore.Text = shortAnswerQuestion.score;
                this.txtTeacherName.Text = shortAnswerQuestion.teacherName;
                this.txtKeyword.Text = shortAnswerQuestion.keyword;

                if (shortAnswerQuestion.picture.Trim().Length > 0)
                {
                    try
                    {
                        this.pcPicture.Image = (new SerializeObjectToString().DeserializeObject(shortAnswerQuestion.picture)) as Image;
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
    }
}
