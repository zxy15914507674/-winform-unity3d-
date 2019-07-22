namespace 习题管理系统.FrmexerciseManager
{
    partial class FrmCompletionQuestionInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pcPicture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(616, 256);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(125, 21);
            this.txtScore.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "分值：";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(118, 259);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer.Size = new System.Drawing.Size(362, 72);
            this.txtAnswer.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 46;
            this.label4.Text = "参考答案：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 44;
            this.label9.Text = "实验名称：";
            // 
            // pcPicture
            // 
            this.pcPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcPicture.Location = new System.Drawing.Point(616, 82);
            this.pcPicture.Name = "pcPicture";
            this.pcPicture.Size = new System.Drawing.Size(316, 155);
            this.pcPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPicture.TabIndex = 41;
            this.pcPicture.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "习题图片：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(118, 82);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(363, 155);
            this.txtContent.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "题目：";
            // 
            // txtExpName
            // 
            this.txtExpName.Location = new System.Drawing.Point(118, 37);
            this.txtExpName.Name = "txtExpName";
            this.txtExpName.ReadOnly = true;
            this.txtExpName.Size = new System.Drawing.Size(362, 21);
            this.txtExpName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = "添加人：";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(616, 304);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.Size = new System.Drawing.Size(125, 21);
            this.txtTeacherName.TabIndex = 54;
            // 
            // FrmCompletionQuestionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 416);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpName);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pcPicture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCompletionQuestionInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "填空题详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.pcPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pcPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeacherName;
    }
}