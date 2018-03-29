using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 研究生信息管理系统
{
    public partial class MainForm : Form
    {
        LoginForm loginform = null;
        string logininfo = null;
        string rolename = null;
        private bool relogin = false;
        public MainForm()//重载构造函数
        {

            InitializeComponent();
        }
        public MainForm(LoginForm form, string reader)//重载构造函数
        {
            this.loginform = form;
            this.logininfo = reader;
            InitializeComponent();
        }


        protected override void OnClosing(CancelEventArgs e)//关闭前操作：关闭登录窗体
        {

            if (!relogin)
            {
                loginform.Close();
            }
            
            
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            relogin = false;//重新登陆状态，用于在主窗体关闭窗口时判断是否关掉登录窗体（关闭整个程序）
            //数据库初始化

            //初始化菜单
            
            //状态栏初始化
            tssl_user.Text = logininfo;
            tssl_time.Text = DateTime.Now.ToLongDateString();

            //判断权限
            string sql = "select * from userinfo where UName= '" + logininfo + "'";
            SQLConnet sqlconnet = new SQLConnet();
            rolename = sqlconnet.readone(sql,"RoleName");
            sql = "select * from roles where RoleName= '" + rolename + "'";
            SqlDataReader role = sqlconnet.readrow(sql);
            role.Read();

            if (role["SystemManage"].ToString() == "False")
            {
                系统管理ToolStripMenuItem.Visible = false;
            }
            if (role["MajorManage"].ToString() == "False")
            {
                专业管理ToolStripMenuItem.Visible = false;
            }
            if (role["CourseManage"].ToString() == "False")
            {
                课程管理ToolStripMenuItem.Visible = false;
            }
            if (role["ScoreManage"].ToString() == "False")
            {
                成绩管理ToolStripMenuItem.Visible = false;
            }
            if (role["SystemManage"].ToString() == "False" && role["MajorManage"].ToString() == "False" && role["CourseManage"].ToString() == "False" && role["ScoreManage"].ToString() == "False")
            {
                研究生管理ToolStripMenuItem.Visible = false;
                tsb_viewstudent.Visible = false;
            }
            role.Close();
            sqlconnet.close();
        }
        public void renewtool()//重置工具栏状态
        {
            tsb_changepassword.Checked = false;
            tsb_viewcourse.Checked = false;
            tsb_viewmajob.Checked = false;
            tsb_viewscore.Checked = false;
            tsb_viewstudent.Checked = false;
        }


        private void 重新登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relogin = true;
            loginform.Show();
            this.Close();

        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            AddUserForm adduserform = new AddUserForm();
            adduserform.MdiParent = this;
            adduserform.WindowState = FormWindowState.Maximized;
            adduserform.Show();
        }

        private void 新建角色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            AddRolesForm addrolesform = new AddRolesForm();
            addrolesform.MdiParent = this;
            addrolesform.WindowState = FormWindowState.Maximized;
            addrolesform.Show();
        }

        private void 添加专业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            AddMajobForm addmajobform = new AddMajobForm();
            addmajobform.MdiParent = this;
            addmajobform.WindowState = FormWindowState.Maximized;
            addmajobform.Show();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            AddCourseForm addcourseform = new AddCourseForm();
            addcourseform.MdiParent = this;
            addcourseform.WindowState = FormWindowState.Maximized;
            addcourseform.Show();
        }

        private void 添加信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            AddStudentForm addstudentform = new AddStudentForm();
            addstudentform.MdiParent = this;
            addstudentform.WindowState = FormWindowState.Maximized;
            addstudentform.Show();
        }

        private void 添加成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            AddScoreForm addscoreform = new AddScoreForm();
            addscoreform.MdiParent = this;
            addscoreform.WindowState = FormWindowState.Maximized;
            addscoreform.Show();
        }
        //工具栏与菜单重复使用的函数
        private void viewmajob()//专业
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            tsb_viewmajob.Checked = true;
            ViewMajobForm viewmajobform = new ViewMajobForm(rolename);
            viewmajobform.MdiParent = this;
            viewmajobform.WindowState = FormWindowState.Maximized;
            viewmajobform.Show();
        }

        private void viewcourse()//课程
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            tsb_viewcourse.Checked = true;
            ViewCourseForm viewcourseform = new ViewCourseForm(rolename);
            viewcourseform.MdiParent = this;
            viewcourseform.WindowState = FormWindowState.Maximized;
            viewcourseform.Show();
        }
        private void viewstudent()//学生
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            tsb_viewstudent.Checked = true;
            ViewStudentForm viewstudentform = new ViewStudentForm(rolename);
            viewstudentform.MdiParent = this;
            viewstudentform.WindowState = FormWindowState.Maximized;
            viewstudentform.Show();
        }
        private void viewscore()//成绩
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            tsb_viewscore.Checked = true;
            ViewScoreForm viewscoreform = new ViewScoreForm(rolename);
            viewscoreform.MdiParent = this;
            viewscoreform.WindowState = FormWindowState.Maximized;
            viewscoreform.Show();
        }
        private void viewteacher()//教师
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            ViewTeacherForm viewteacherform = new ViewTeacherForm(rolename);
            viewteacherform.MdiParent = this;
            viewteacherform.WindowState = FormWindowState.Maximized;
            viewteacherform.Show();
        }
        private void viewuser()//用户
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            ViewUserForm viewuserform = new ViewUserForm(rolename);
            viewuserform.MdiParent = this;
            viewuserform.WindowState = FormWindowState.Maximized;
            viewuserform.Show();
        }
        private void changepassword()//改密码
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close(); //关闭当前窗体
            }
            renewtool();//关闭工具栏按下状态
            tsb_changepassword.Checked = true;
            ChangePasswordForm changepasswordform = new ChangePasswordForm(logininfo);
            changepasswordform.MdiParent = this;
            changepasswordform.WindowState = FormWindowState.Maximized;
            changepasswordform.Show();
        }

        //工具栏与菜单点击事件
        private void 浏览专业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewmajob();
        }

        private void 浏览课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewcourse();
        }

        private void 浏览信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewstudent();
        }

        private void 浏览成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewscore();
        }
        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepassword();
        }

        private void tsb_viewmajob_Click(object sender, EventArgs e)
        {
            viewmajob();
        }

        private void tsb_viewcourse_Click(object sender, EventArgs e)
        {
            viewcourse();
        }

        private void tsb_viewstudent_Click(object sender, EventArgs e)
        {
            viewstudent();
        }

        private void tsb_viewscore_Click(object sender, EventArgs e)
        {
            viewscore();
        }

        private void tsb_changepassword_Click(object sender, EventArgs e)
        {
            changepassword();
        }

        private void 教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewteacher();
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewuser();
        }
    }
}
