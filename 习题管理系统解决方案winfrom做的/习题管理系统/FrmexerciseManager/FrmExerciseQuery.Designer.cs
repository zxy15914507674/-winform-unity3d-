namespace 习题管理系统.FrmexerciseManager
{
    partial class FrmExerciseQuery
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
            this.cbLabRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChooseExperiment = new System.Windows.Forms.ComboBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questonTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLabRoom
            // 
            this.cbLabRoom.FormattingEnabled = true;
            this.cbLabRoom.Location = new System.Drawing.Point(142, 31);
            this.cbLabRoom.Name = "cbLabRoom";
            this.cbLabRoom.Size = new System.Drawing.Size(174, 20);
            this.cbLabRoom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择实验室名称：";
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToResizeColumns = false;
            this.dgvInfo.AllowUserToResizeRows = false;
            this.dgvInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ExpName,
            this.Describe,
            this.questonTypeName,
            this.teacherName});
            this.dgvInfo.Location = new System.Drawing.Point(37, 81);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(765, 362);
            this.dgvInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "选择实验名称：";
            // 
            // cbChooseExperiment
            // 
            this.cbChooseExperiment.FormattingEnabled = true;
            this.cbChooseExperiment.Location = new System.Drawing.Point(441, 31);
            this.cbChooseExperiment.Name = "cbChooseExperiment";
            this.cbChooseExperiment.Size = new System.Drawing.Size(257, 20);
            this.cbChooseExperiment.TabIndex = 4;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(829, 162);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 5;
            this.btnDetail.Text = "详细信息";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(829, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(829, 223);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(829, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(727, 31);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "题目编号";
            this.id.Name = "id";
            this.id.Width = 80;
            // 
            // ExpName
            // 
            this.ExpName.DataPropertyName = "expName";
            this.ExpName.HeaderText = "实验名称";
            this.ExpName.Name = "ExpName";
            this.ExpName.Width = 250;
            // 
            // Describe
            // 
            this.Describe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Describe.DataPropertyName = "Describe";
            this.Describe.HeaderText = "题目描述";
            this.Describe.Name = "Describe";
            // 
            // questonTypeName
            // 
            this.questonTypeName.DataPropertyName = "questonTypeName";
            this.questonTypeName.HeaderText = "题目类型";
            this.questonTypeName.Name = "questonTypeName";
            // 
            // teacherName
            // 
            this.teacherName.DataPropertyName = "teacherName";
            this.teacherName.HeaderText = "添加人";
            this.teacherName.Name = "teacherName";
            // 
            // FrmExerciseQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 515);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.cbChooseExperiment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLabRoom);
            this.Name = "FrmExerciseQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "习题查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLabRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChooseExperiment;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describe;
        private System.Windows.Forms.DataGridViewTextBoxColumn questonTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherName;
    }
}