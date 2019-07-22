namespace 习题管理系统
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.userName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exerciseManagerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.添加习题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddChooseQuestionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCompletionQuestionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddShortAnswerQuestionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exerciseQueryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSysMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.教师管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTeacherMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TeacherInfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddChooseQuestionQuickMenu = new System.Windows.Forms.ToolStripLabel();
            this.AddCompletionQuestionQuickMenu = new System.Windows.Forms.ToolStripLabel();
            this.AddShortAnswerQuestionQuickMenu = new System.Windows.Forms.ToolStripLabel();
            this.exerciseQueryQuickMenu = new System.Windows.Forms.ToolStripLabel();
            this.ModifyPwdMenu = new System.Windows.Forms.ToolStripLabel();
            this.exitSystemQuickMenu = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.userName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(939, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(187, 17);
            this.toolStripStatusLabel1.Text = "版本号：v1.0   【当前登录用户：";
            // 
            // userName
            // 
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(35, 17);
            this.userName.Text = "***】";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciseManagerMenu,
            this.系统管理ToolStripMenuItem,
            this.教师管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exerciseManagerMenu
            // 
            this.exerciseManagerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加习题ToolStripMenuItem,
            this.exerciseQueryMenu});
            this.exerciseManagerMenu.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exerciseManagerMenu.Name = "exerciseManagerMenu";
            this.exerciseManagerMenu.Size = new System.Drawing.Size(68, 21);
            this.exerciseManagerMenu.Text = "习题管理";
            // 
            // 添加习题ToolStripMenuItem
            // 
            this.添加习题ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddChooseQuestionMenu,
            this.AddCompletionQuestionMenu,
            this.AddShortAnswerQuestionMenu});
            this.添加习题ToolStripMenuItem.Name = "添加习题ToolStripMenuItem";
            this.添加习题ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加习题ToolStripMenuItem.Text = "添加习题";
            // 
            // AddChooseQuestionMenu
            // 
            this.AddChooseQuestionMenu.Name = "AddChooseQuestionMenu";
            this.AddChooseQuestionMenu.Size = new System.Drawing.Size(112, 22);
            this.AddChooseQuestionMenu.Text = "单选题";
            this.AddChooseQuestionMenu.Click += new System.EventHandler(this.AddChooseQuestionMenu_Click);
            // 
            // AddCompletionQuestionMenu
            // 
            this.AddCompletionQuestionMenu.Name = "AddCompletionQuestionMenu";
            this.AddCompletionQuestionMenu.Size = new System.Drawing.Size(112, 22);
            this.AddCompletionQuestionMenu.Text = "填空题";
            this.AddCompletionQuestionMenu.Click += new System.EventHandler(this.AddCompletionQuestionMenu_Click);
            // 
            // AddShortAnswerQuestionMenu
            // 
            this.AddShortAnswerQuestionMenu.Name = "AddShortAnswerQuestionMenu";
            this.AddShortAnswerQuestionMenu.Size = new System.Drawing.Size(112, 22);
            this.AddShortAnswerQuestionMenu.Text = "简答题";
            this.AddShortAnswerQuestionMenu.Click += new System.EventHandler(this.AddShortAnswerQuestionMenu_Click);
            // 
            // exerciseQueryMenu
            // 
            this.exerciseQueryMenu.Name = "exerciseQueryMenu";
            this.exerciseQueryMenu.Size = new System.Drawing.Size(124, 22);
            this.exerciseQueryMenu.Text = "查询习题";
            this.exerciseQueryMenu.Click += new System.EventHandler(this.exerciseQueryMenu_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyPwd,
            this.exitSysMenu});
            this.系统管理ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // ModifyPwd
            // 
            this.ModifyPwd.Name = "ModifyPwd";
            this.ModifyPwd.Size = new System.Drawing.Size(124, 22);
            this.ModifyPwd.Text = "修改密码";
            this.ModifyPwd.Click += new System.EventHandler(this.ModifyPwd_Click);
            // 
            // exitSysMenu
            // 
            this.exitSysMenu.Name = "exitSysMenu";
            this.exitSysMenu.Size = new System.Drawing.Size(124, 22);
            this.exitSysMenu.Text = "退出系统";
            this.exitSysMenu.Click += new System.EventHandler(this.exitSysMenu_Click);
            // 
            // 教师管理ToolStripMenuItem
            // 
            this.教师管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTeacherMenu,
            this.TeacherInfoMenu});
            this.教师管理ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.教师管理ToolStripMenuItem.Name = "教师管理ToolStripMenuItem";
            this.教师管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.教师管理ToolStripMenuItem.Text = "教师管理";
            // 
            // AddTeacherMenu
            // 
            this.AddTeacherMenu.Name = "AddTeacherMenu";
            this.AddTeacherMenu.Size = new System.Drawing.Size(152, 22);
            this.AddTeacherMenu.Text = "新增教师";
            this.AddTeacherMenu.Click += new System.EventHandler(this.AddTeacherMenu_Click);
            // 
            // TeacherInfoMenu
            // 
            this.TeacherInfoMenu.Name = "TeacherInfoMenu";
            this.TeacherInfoMenu.Size = new System.Drawing.Size(152, 22);
            this.TeacherInfoMenu.Text = "查看教师信息";
            this.TeacherInfoMenu.Click += new System.EventHandler(this.TeacherInfoMenu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddChooseQuestionQuickMenu,
            this.AddCompletionQuestionQuickMenu,
            this.AddShortAnswerQuestionQuickMenu,
            this.exerciseQueryQuickMenu,
            this.ModifyPwdMenu,
            this.exitSystemQuickMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(939, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddChooseQuestionQuickMenu
            // 
            this.AddChooseQuestionQuickMenu.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.AddChooseQuestionQuickMenu.Name = "AddChooseQuestionQuickMenu";
            this.AddChooseQuestionQuickMenu.Size = new System.Drawing.Size(68, 22);
            this.AddChooseQuestionQuickMenu.Text = "添加单选题";
            this.AddChooseQuestionQuickMenu.Click += new System.EventHandler(this.AddChooseQuestionQuickMenu_Click);
            // 
            // AddCompletionQuestionQuickMenu
            // 
            this.AddCompletionQuestionQuickMenu.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.AddCompletionQuestionQuickMenu.Name = "AddCompletionQuestionQuickMenu";
            this.AddCompletionQuestionQuickMenu.Size = new System.Drawing.Size(68, 22);
            this.AddCompletionQuestionQuickMenu.Text = "添加填空题";
            this.AddCompletionQuestionQuickMenu.Click += new System.EventHandler(this.AddCompletionQuestionQuickMenu_Click);
            // 
            // AddShortAnswerQuestionQuickMenu
            // 
            this.AddShortAnswerQuestionQuickMenu.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.AddShortAnswerQuestionQuickMenu.Name = "AddShortAnswerQuestionQuickMenu";
            this.AddShortAnswerQuestionQuickMenu.Size = new System.Drawing.Size(68, 22);
            this.AddShortAnswerQuestionQuickMenu.Text = "添加简答题";
            this.AddShortAnswerQuestionQuickMenu.Click += new System.EventHandler(this.AddShortAnswerQuestionQuickMenu_Click);
            // 
            // exerciseQueryQuickMenu
            // 
            this.exerciseQueryQuickMenu.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.exerciseQueryQuickMenu.Name = "exerciseQueryQuickMenu";
            this.exerciseQueryQuickMenu.Size = new System.Drawing.Size(56, 22);
            this.exerciseQueryQuickMenu.Text = "习题查询";
            this.exerciseQueryQuickMenu.Click += new System.EventHandler(this.exerciseQueryQuickMenu_Click);
            // 
            // ModifyPwdMenu
            // 
            this.ModifyPwdMenu.AccessibleName = "";
            this.ModifyPwdMenu.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.ModifyPwdMenu.Name = "ModifyPwdMenu";
            this.ModifyPwdMenu.Size = new System.Drawing.Size(56, 22);
            this.ModifyPwdMenu.Text = "修改密码";
            this.ModifyPwdMenu.Click += new System.EventHandler(this.ModifyPwdMenu_Click);
            // 
            // exitSystemQuickMenu
            // 
            this.exitSystemQuickMenu.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.exitSystemQuickMenu.Name = "exitSystemQuickMenu";
            this.exitSystemQuickMenu.Size = new System.Drawing.Size(56, 22);
            this.exitSystemQuickMenu.Text = "退出系统";
            this.exitSystemQuickMenu.Click += new System.EventHandler(this.exitSystemQuickMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 419);
            this.panel1.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "【习题管理系统】";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel userName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exerciseManagerMenu;
        private System.Windows.Forms.ToolStripMenuItem 添加习题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddChooseQuestionMenu;
        private System.Windows.Forms.ToolStripMenuItem AddCompletionQuestionMenu;
        private System.Windows.Forms.ToolStripMenuItem AddShortAnswerQuestionMenu;
        private System.Windows.Forms.ToolStripMenuItem exerciseQueryMenu;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyPwd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel AddChooseQuestionQuickMenu;
        private System.Windows.Forms.ToolStripLabel AddCompletionQuestionQuickMenu;
        private System.Windows.Forms.ToolStripLabel AddShortAnswerQuestionQuickMenu;
        private System.Windows.Forms.ToolStripLabel exerciseQueryQuickMenu;
        private System.Windows.Forms.ToolStripLabel ModifyPwdMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel exitSystemQuickMenu;
        private System.Windows.Forms.ToolStripMenuItem exitSysMenu;
        private System.Windows.Forms.ToolStripMenuItem 教师管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTeacherMenu;
        private System.Windows.Forms.ToolStripMenuItem TeacherInfoMenu;
    }
}