namespace 习题管理系统.FrmexerciseManager
{
    partial class FrmModifyCompletionQuestion
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLabRoom = new System.Windows.Forms.ComboBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.pcAddPicture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChooseExperiment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetNull = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcAddPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(395, 350);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 54;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(580, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(622, 237);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(125, 21);
            this.txtScore.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 51;
            this.label6.Text = "分值：";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(124, 240);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer.Size = new System.Drawing.Size(362, 72);
            this.txtAnswer.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 48;
            this.label4.Text = "参考答案：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 46;
            this.label9.Text = "实验名称：";
            // 
            // cbLabRoom
            // 
            this.cbLabRoom.FormattingEnabled = true;
            this.cbLabRoom.Location = new System.Drawing.Point(124, 24);
            this.cbLabRoom.Name = "cbLabRoom";
            this.cbLabRoom.Size = new System.Drawing.Size(362, 20);
            this.cbLabRoom.TabIndex = 45;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(862, 179);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(76, 39);
            this.btnAddPicture.TabIndex = 44;
            this.btnAddPicture.Text = "习题图片(有就添加)";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // pcAddPicture
            // 
            this.pcAddPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcAddPicture.Location = new System.Drawing.Point(622, 63);
            this.pcAddPicture.Name = "pcAddPicture";
            this.pcAddPicture.Size = new System.Drawing.Size(316, 155);
            this.pcAddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcAddPicture.TabIndex = 43;
            this.pcAddPicture.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 42;
            this.label7.Text = "习题图片：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(124, 63);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(363, 155);
            this.txtContent.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "题目：";
            // 
            // cbChooseExperiment
            // 
            this.cbChooseExperiment.FormattingEnabled = true;
            this.cbChooseExperiment.Location = new System.Drawing.Point(622, 27);
            this.cbChooseExperiment.Name = "cbChooseExperiment";
            this.cbChooseExperiment.Size = new System.Drawing.Size(316, 20);
            this.cbChooseExperiment.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "实验室名称：";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(622, 291);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(125, 21);
            this.txtTeacherName.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 55;
            this.label3.Text = "添加人：";
            // 
            // btnSetNull
            // 
            this.btnSetNull.Location = new System.Drawing.Point(791, 179);
            this.btnSetNull.Name = "btnSetNull";
            this.btnSetNull.Size = new System.Drawing.Size(65, 39);
            this.btnSetNull.TabIndex = 78;
            this.btnSetNull.Text = "置空";
            this.btnSetNull.UseVisualStyleBackColor = true;
            this.btnSetNull.Click += new System.EventHandler(this.btnSetNull_Click);
            // 
            // FrmModifyCompletionQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 466);
            this.Controls.Add(this.btnSetNull);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbLabRoom);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.pcAddPicture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChooseExperiment);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmModifyCompletionQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改习题";
            ((System.ComponentModel.ISupportInitialize)(this.pcAddPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLabRoom;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.PictureBox pcAddPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChooseExperiment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetNull;
    }
}