namespace 研究生信息管理系统
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建角色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专业管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加专业ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览专业ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.研究生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.教师信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_viewmajob = new System.Windows.Forms.ToolStripButton();
            this.tsb_viewcourse = new System.Windows.Forms.ToolStripButton();
            this.tsb_viewstudent = new System.Windows.Forms.ToolStripButton();
            this.tsb_viewscore = new System.Windows.Forms.ToolStripButton();
            this.tsb_changepassword = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_user,
            this.tssl_time,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "状态栏";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 21);
            this.toolStripStatusLabel1.Text = "当前登录用户：";
            // 
            // tssl_user
            // 
            this.tssl_user.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssl_user.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tssl_user.Name = "tssl_user";
            this.tssl_user.Size = new System.Drawing.Size(36, 21);
            this.tssl_user.Text = "未知";
            // 
            // tssl_time
            // 
            this.tssl_time.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssl_time.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tssl_time.Name = "tssl_time";
            this.tssl_time.Size = new System.Drawing.Size(36, 21);
            this.tssl_time.Text = "时间";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(72, 21);
            this.toolStripStatusLabel4.Text = "作者：林宏";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(120, 21);
            this.toolStripStatusLabel5.Text = "研究生信息管理系统";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.专业管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.研究生管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem,
            this.新建角色ToolStripMenuItem,
            this.教师信息ToolStripMenuItem,
            this.用户信息ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 新建角色ToolStripMenuItem
            // 
            this.新建角色ToolStripMenuItem.Name = "新建角色ToolStripMenuItem";
            this.新建角色ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新建角色ToolStripMenuItem.Text = "新建角色";
            this.新建角色ToolStripMenuItem.Click += new System.EventHandler(this.新建角色ToolStripMenuItem_Click);
            // 
            // 专业管理ToolStripMenuItem
            // 
            this.专业管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加专业ToolStripMenuItem,
            this.浏览专业ToolStripMenuItem});
            this.专业管理ToolStripMenuItem.Name = "专业管理ToolStripMenuItem";
            this.专业管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.专业管理ToolStripMenuItem.Text = "专业管理";
            // 
            // 添加专业ToolStripMenuItem
            // 
            this.添加专业ToolStripMenuItem.Name = "添加专业ToolStripMenuItem";
            this.添加专业ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加专业ToolStripMenuItem.Text = "添加专业";
            this.添加专业ToolStripMenuItem.Click += new System.EventHandler(this.添加专业ToolStripMenuItem_Click);
            // 
            // 浏览专业ToolStripMenuItem
            // 
            this.浏览专业ToolStripMenuItem.Name = "浏览专业ToolStripMenuItem";
            this.浏览专业ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.浏览专业ToolStripMenuItem.Text = "浏览专业";
            this.浏览专业ToolStripMenuItem.Click += new System.EventHandler(this.浏览专业ToolStripMenuItem_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加课程ToolStripMenuItem,
            this.浏览课程ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            // 
            // 添加课程ToolStripMenuItem
            // 
            this.添加课程ToolStripMenuItem.Name = "添加课程ToolStripMenuItem";
            this.添加课程ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加课程ToolStripMenuItem.Text = "添加课程";
            this.添加课程ToolStripMenuItem.Click += new System.EventHandler(this.添加课程ToolStripMenuItem_Click);
            // 
            // 浏览课程ToolStripMenuItem
            // 
            this.浏览课程ToolStripMenuItem.Name = "浏览课程ToolStripMenuItem";
            this.浏览课程ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.浏览课程ToolStripMenuItem.Text = "浏览课程";
            this.浏览课程ToolStripMenuItem.Click += new System.EventHandler(this.浏览课程ToolStripMenuItem_Click);
            // 
            // 研究生管理ToolStripMenuItem
            // 
            this.研究生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加信息ToolStripMenuItem,
            this.浏览信息ToolStripMenuItem});
            this.研究生管理ToolStripMenuItem.Name = "研究生管理ToolStripMenuItem";
            this.研究生管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.研究生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 添加信息ToolStripMenuItem
            // 
            this.添加信息ToolStripMenuItem.Name = "添加信息ToolStripMenuItem";
            this.添加信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加信息ToolStripMenuItem.Text = "添加信息";
            this.添加信息ToolStripMenuItem.Click += new System.EventHandler(this.添加信息ToolStripMenuItem_Click);
            // 
            // 浏览信息ToolStripMenuItem
            // 
            this.浏览信息ToolStripMenuItem.Name = "浏览信息ToolStripMenuItem";
            this.浏览信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.浏览信息ToolStripMenuItem.Text = "浏览信息";
            this.浏览信息ToolStripMenuItem.Click += new System.EventHandler(this.浏览信息ToolStripMenuItem_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加成绩ToolStripMenuItem,
            this.浏览成绩ToolStripMenuItem});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            // 
            // 添加成绩ToolStripMenuItem
            // 
            this.添加成绩ToolStripMenuItem.Name = "添加成绩ToolStripMenuItem";
            this.添加成绩ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加成绩ToolStripMenuItem.Text = "添加成绩";
            this.添加成绩ToolStripMenuItem.Click += new System.EventHandler(this.添加成绩ToolStripMenuItem_Click);
            // 
            // 浏览成绩ToolStripMenuItem
            // 
            this.浏览成绩ToolStripMenuItem.Name = "浏览成绩ToolStripMenuItem";
            this.浏览成绩ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.浏览成绩ToolStripMenuItem.Text = "浏览成绩";
            this.浏览成绩ToolStripMenuItem.Click += new System.EventHandler(this.浏览成绩ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改密码ToolStripMenuItem,
            this.重新登陆ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 更改密码ToolStripMenuItem
            // 
            this.更改密码ToolStripMenuItem.Name = "更改密码ToolStripMenuItem";
            this.更改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.更改密码ToolStripMenuItem.Text = "更改密码";
            this.更改密码ToolStripMenuItem.Click += new System.EventHandler(this.更改密码ToolStripMenuItem_Click);
            // 
            // 重新登陆ToolStripMenuItem
            // 
            this.重新登陆ToolStripMenuItem.Name = "重新登陆ToolStripMenuItem";
            this.重新登陆ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重新登陆ToolStripMenuItem.Text = "重新登陆";
            this.重新登陆ToolStripMenuItem.Click += new System.EventHandler(this.重新登陆ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_viewmajob,
            this.tsb_viewcourse,
            this.tsb_viewstudent,
            this.tsb_viewscore,
            this.tsb_changepassword});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 59);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 教师信息ToolStripMenuItem
            // 
            this.教师信息ToolStripMenuItem.Name = "教师信息ToolStripMenuItem";
            this.教师信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.教师信息ToolStripMenuItem.Text = "教师信息";
            this.教师信息ToolStripMenuItem.Click += new System.EventHandler(this.教师信息ToolStripMenuItem_Click);
            // 
            // 用户信息ToolStripMenuItem
            // 
            this.用户信息ToolStripMenuItem.Name = "用户信息ToolStripMenuItem";
            this.用户信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.用户信息ToolStripMenuItem.Text = "用户信息";
            this.用户信息ToolStripMenuItem.Click += new System.EventHandler(this.用户信息ToolStripMenuItem_Click);
            // 
            // tsb_viewmajob
            // 
            this.tsb_viewmajob.Image = global::研究生信息管理系统.Properties.Resources.专业1;
            this.tsb_viewmajob.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_viewmajob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_viewmajob.Name = "tsb_viewmajob";
            this.tsb_viewmajob.Size = new System.Drawing.Size(60, 56);
            this.tsb_viewmajob.Text = "专业浏览";
            this.tsb_viewmajob.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsb_viewmajob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_viewmajob.Click += new System.EventHandler(this.tsb_viewmajob_Click);
            // 
            // tsb_viewcourse
            // 
            this.tsb_viewcourse.Image = global::研究生信息管理系统.Properties.Resources.课程;
            this.tsb_viewcourse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_viewcourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_viewcourse.Name = "tsb_viewcourse";
            this.tsb_viewcourse.Size = new System.Drawing.Size(60, 56);
            this.tsb_viewcourse.Text = "课程浏览";
            this.tsb_viewcourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsb_viewcourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_viewcourse.Click += new System.EventHandler(this.tsb_viewcourse_Click);
            // 
            // tsb_viewstudent
            // 
            this.tsb_viewstudent.Image = global::研究生信息管理系统.Properties.Resources.学生;
            this.tsb_viewstudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_viewstudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_viewstudent.Name = "tsb_viewstudent";
            this.tsb_viewstudent.Size = new System.Drawing.Size(60, 56);
            this.tsb_viewstudent.Text = "学生浏览";
            this.tsb_viewstudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsb_viewstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_viewstudent.Click += new System.EventHandler(this.tsb_viewstudent_Click);
            // 
            // tsb_viewscore
            // 
            this.tsb_viewscore.Image = global::研究生信息管理系统.Properties.Resources.成绩;
            this.tsb_viewscore.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_viewscore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_viewscore.Name = "tsb_viewscore";
            this.tsb_viewscore.Size = new System.Drawing.Size(60, 56);
            this.tsb_viewscore.Text = "成绩浏览";
            this.tsb_viewscore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsb_viewscore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_viewscore.Click += new System.EventHandler(this.tsb_viewscore_Click);
            // 
            // tsb_changepassword
            // 
            this.tsb_changepassword.Image = global::研究生信息管理系统.Properties.Resources.系统;
            this.tsb_changepassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_changepassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_changepassword.Name = "tsb_changepassword";
            this.tsb_changepassword.Size = new System.Drawing.Size(60, 56);
            this.tsb_changepassword.Text = "修改密码";
            this.tsb_changepassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsb_changepassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_changepassword.Click += new System.EventHandler(this.tsb_changepassword_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "研究生信息管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ToolStripStatusLabel tssl_user;
        private System.Windows.Forms.ToolStripStatusLabel tssl_time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建角色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 专业管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加专业ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览专业ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 研究生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登陆ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_viewmajob;
        private System.Windows.Forms.ToolStripButton tsb_viewcourse;
        private System.Windows.Forms.ToolStripButton tsb_viewstudent;
        private System.Windows.Forms.ToolStripButton tsb_viewscore;
        public System.Windows.Forms.ToolStripButton tsb_changepassword;
        private System.Windows.Forms.ToolStripMenuItem 教师信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息ToolStripMenuItem;
    }
}



