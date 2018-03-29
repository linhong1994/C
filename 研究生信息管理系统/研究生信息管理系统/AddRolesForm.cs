using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 研究生信息管理系统
{
    public partial class AddRolesForm : Form
    {
        public AddRolesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                SQLConnet sqlconnet = new SQLConnet();
                if (sqlconnet.checkit("select RoleName from roles where RoleName = '" + textBox1.Text + "'"))
                {
                    MessageBox.Show("角色已存在！");
                }
                else
                {
                    ArrayList filed = new ArrayList();
                    filed.Add("RoleName");
                    filed.Add("SystemManage");
                    filed.Add("MajorManage");
                    filed.Add("CourseManage");
                    filed.Add("ScoreManage");
                    ArrayList fdata = new ArrayList();
                    fdata.Add(textBox1.Text);
                    fdata.Add(checkBox1.Checked);
                    fdata.Add(checkBox2.Checked);
                    fdata.Add(checkBox3.Checked);
                    fdata.Add(checkBox4.Checked);
                    sqlconnet.addrow("select * from roles", "roles", filed, fdata);
                    MessageBox.Show("添加成功！");
                }
                sqlconnet.close();
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
