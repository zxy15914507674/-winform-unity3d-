namespace 习题管理系统
{
    partial class FrmModifyPwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPwdConform = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(94, 33);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(136, 21);
            this.txtOldPwd.TabIndex = 1;
            this.txtOldPwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码：";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(94, 76);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(133, 21);
            this.txtNewPwd.TabIndex = 3;
            this.txtNewPwd.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码确认：";
            // 
            // txtNewPwdConform
            // 
            this.txtNewPwdConform.Location = new System.Drawing.Point(94, 113);
            this.txtNewPwdConform.Name = "txtNewPwdConform";
            this.txtNewPwdConform.Size = new System.Drawing.Size(133, 21);
            this.txtNewPwdConform.TabIndex = 5;
            this.txtNewPwdConform.UseSystemPasswordChar = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(61, 183);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(56, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "确认";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(149, 183);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(60, 23);
            this.btnCanel.TabIndex = 7;
            this.btnCanel.Text = "取消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // FrmModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 261);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtNewPwdConform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmModifyPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPwdConform;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCanel;
    }
}