namespace 习题管理系统.FrmexerciseManager
{
    partial class FrmModifyChooseQuestion
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
            this.btnModify = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLabRoom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pcAddPicture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChooseExperiment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.btnSetNull = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcAddPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(348, 415);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 46;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(109, 366);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 21);
            this.txtScore.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 44;
            this.label10.Text = "分     值：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 43;
            this.label9.Text = "实验名称：";
            // 
            // cbLabRoom
            // 
            this.cbLabRoom.FormattingEnabled = true;
            this.cbLabRoom.Location = new System.Drawing.Point(109, 38);
            this.cbLabRoom.Name = "cbLabRoom";
            this.cbLabRoom.Size = new System.Drawing.Size(362, 20);
            this.cbLabRoom.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 39);
            this.button1.TabIndex = 41;
            this.button1.Text = "习题图片(有就添加)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(543, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(600, 363);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 21);
            this.txtAnswer.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "参考答案：";
            // 
            // pcAddPicture
            // 
            this.pcAddPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcAddPicture.Location = new System.Drawing.Point(600, 77);
            this.pcAddPicture.Name = "pcAddPicture";
            this.pcAddPicture.Size = new System.Drawing.Size(316, 155);
            this.pcAddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAddPicture.TabIndex = 37;
            this.pcAddPicture.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "习题图片：";
            // 
            // txtOptionD
            // 
            this.txtOptionD.Location = new System.Drawing.Point(600, 295);
            this.txtOptionD.Multiline = true;
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOptionD.Size = new System.Drawing.Size(316, 51);
            this.txtOptionD.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "选项D内容：";
            // 
            // txtOptionC
            // 
            this.txtOptionC.Location = new System.Drawing.Point(108, 295);
            this.txtOptionC.Multiline = true;
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOptionC.Size = new System.Drawing.Size(363, 51);
            this.txtOptionC.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "选项C内容：";
            // 
            // txtOptionB
            // 
            this.txtOptionB.Location = new System.Drawing.Point(600, 238);
            this.txtOptionB.Multiline = true;
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOptionB.Size = new System.Drawing.Size(316, 51);
            this.txtOptionB.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "选项B内容：";
            // 
            // txtOptionA
            // 
            this.txtOptionA.Location = new System.Drawing.Point(108, 238);
            this.txtOptionA.Multiline = true;
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOptionA.Size = new System.Drawing.Size(363, 51);
            this.txtOptionA.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "选项A内容：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(108, 77);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(363, 155);
            this.txtContent.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "问题：";
            // 
            // cbChooseExperiment
            // 
            this.cbChooseExperiment.FormattingEnabled = true;
            this.cbChooseExperiment.Location = new System.Drawing.Point(600, 41);
            this.cbChooseExperiment.Name = "cbChooseExperiment";
            this.cbChooseExperiment.Size = new System.Drawing.Size(316, 20);
            this.cbChooseExperiment.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "实验室名称：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(757, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 47;
            this.label11.Text = "添加人：";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(816, 363);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(100, 21);
            this.txtTeacherName.TabIndex = 48;
            // 
            // btnSetNull
            // 
            this.btnSetNull.Location = new System.Drawing.Point(771, 193);
            this.btnSetNull.Name = "btnSetNull";
            this.btnSetNull.Size = new System.Drawing.Size(65, 39);
            this.btnSetNull.TabIndex = 79;
            this.btnSetNull.Text = "置空";
            this.btnSetNull.UseVisualStyleBackColor = true;
            this.btnSetNull.Click += new System.EventHandler(this.btnSetNull_Click);
            // 
            // FrmModifyChooseQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 458);
            this.Controls.Add(this.btnSetNull);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbLabRoom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pcAddPicture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOptionD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOptionC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOptionB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOptionA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChooseExperiment);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmModifyChooseQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改习题";
            ((System.ComponentModel.ISupportInitialize)(this.pcAddPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLabRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pcAddPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChooseExperiment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Button btnSetNull;
    }
}