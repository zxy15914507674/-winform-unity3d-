namespace 习题管理系统.FrmTeacherManager
{
    partial class FrmTeacherInfo
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
            this.dgvTeacherInfo = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.teacherNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "教师信息：";
            // 
            // dgvTeacherInfo
            // 
            this.dgvTeacherInfo.AllowUserToAddRows = false;
            this.dgvTeacherInfo.AllowUserToDeleteRows = false;
            this.dgvTeacherInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherNumber,
            this.teacherName});
            this.dgvTeacherInfo.Location = new System.Drawing.Point(25, 47);
            this.dgvTeacherInfo.Name = "dgvTeacherInfo";
            this.dgvTeacherInfo.RowTemplate.Height = 23;
            this.dgvTeacherInfo.Size = new System.Drawing.Size(428, 302);
            this.dgvTeacherInfo.TabIndex = 1;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(285, 15);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // teacherNumber
            // 
            this.teacherNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacherNumber.DataPropertyName = "teacherNumber";
            this.teacherNumber.HeaderText = "教师工号";
            this.teacherNumber.Name = "teacherNumber";
            // 
            // teacherName
            // 
            this.teacherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacherName.DataPropertyName = "teacherName";
            this.teacherName.HeaderText = "教师姓名";
            this.teacherName.Name = "teacherName";
            // 
            // FrmTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 363);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dgvTeacherInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmTeacherInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "老师信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTeacherInfo;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherName;
    }
}