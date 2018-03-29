using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 研究生信息管理系统
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            SQLConnet sqlconnet = new SQLConnet();
            SqlDataReader reader = sqlconnet.readrow("select RoleName from roles");
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["RoleName"]);
            }
            comboBox1.SelectedIndex = 0;
            reader.Close();
            sqlconnet.close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 )
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SQLConnet sqlconnet = new SQLConnet();
                    if (sqlconnet.checkit("select * from userinfo where UName='" + textBox1.Text + "'"))
                    {
                        MessageBox.Show("用户已存在！");
                    }
                    else
                    {
                        ArrayList filed = new ArrayList();
                        filed.Add("UName");
                        filed.Add("PWD");
                        filed.Add("RoleName");
                        ArrayList fdata = new ArrayList();
                        fdata.Add(textBox1.Text);
                        fdata.Add(textBox2.Text);
                        fdata.Add(comboBox1.Text);
                        sqlconnet.addrow("select * from userinfo", "userinfo", filed, fdata);
                        MessageBox.Show("添加成功！");
                    }
                    sqlconnet.close();
                }
                else
                {
                    MessageBox.Show("两次输入密码不一致！");
                }
            }
            else
            {
                MessageBox.Show("请输入完整信息！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
