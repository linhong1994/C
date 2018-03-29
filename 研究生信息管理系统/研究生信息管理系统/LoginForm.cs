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
    public partial class LoginForm : Form
    {
        string connectString = "Data Source=.;Initial Catalog=150603047;Integrated Security=True";//连接字符串
        SqlConnection sqlCnt;//命名SqlConnection对象
        protected override void OnClosing(CancelEventArgs e)//关闭前操作：关闭登录窗体
        {
            sqlCnt.Close();             // 关闭数据库连接
            sqlCnt.Dispose();           // 释放数据库连接对象
        }
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            sqlCnt = new SqlConnection(connectString);//实例化SqlConnection对象
            sqlCnt.Open();//打开连接

        }
        private void bt_login_ok_Click(object sender, EventArgs e)
        {
            if ((tb_login_user.Text.Length > 0) && (tb_login_password.Text.Length > 0))
            {
                SqlCommand cmd = sqlCnt.CreateCommand();              //创建SqlCommand对象
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from userinfo where UName= '" + tb_login_user.Text.Trim() + "'";   //sql语句
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["PWD"].ToString() == tb_login_password.Text.Trim())
                    {

                        MainForm mainform = new MainForm(this, reader["UName"].ToString());   //调用带参的构造函数
                        mainform.Show();

                        cmd.Dispose();//释放
                        reader.Close();//关闭

                        this.Hide();

                    }
                    else
                    {
                        cmd.Dispose();//释放
                        reader.Close();//关闭
                        MessageBox.Show("密码错误！请重试！");
                    }

                }
                else
                {
                    cmd.Dispose();//释放
                    reader.Close();//关闭
                    MessageBox.Show("账号不存在！请重试！");
                }
            }
            else
            {
                MessageBox.Show("请输入完整信息！");
            }


        }

        private void bt_login_cancel_Click(object sender, EventArgs e)
        {
            sqlCnt.Close();             // 关闭数据库连接
            sqlCnt.Dispose();           // 释放数据库连接对象
            System.Environment.Exit(0); //退出
        }

    }
}
