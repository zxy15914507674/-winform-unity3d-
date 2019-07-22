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
    public partial class FrmCompletionQuestionInfo : Form
    {
        public FrmCompletionQuestionInfo()
        {
            InitializeComponent();
        }

        public FrmCompletionQuestionInfo(CompletionQuestion completionQuestionObj):this()
        {
            if (completionQuestionObj != null)
            {
                this.txtExpName.Text = completionQuestionObj.expName;
                this.txtContent.Text = completionQuestionObj.content;
                this.txtAnswer.Text = completionQuestionObj.answer;
                this.txtScore.Text = completionQuestionObj.score.ToString();
                this.txtTeacherName.Text = completionQuestionObj.teacherName;

                if (completionQuestionObj.picture.Trim().Length > 0)
                {
                    try
                    {
                        this.pcPicture.Image = (new SerializeObjectToString().DeserializeObject(completionQuestionObj.picture)) as Image;
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
