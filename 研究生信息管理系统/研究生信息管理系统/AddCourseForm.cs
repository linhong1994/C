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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            SQLConnet sqlconnet = new SQLConnet();
            SqlDataReader majob = sqlconnet.readrow("select MName from majorinfo");
            while (majob.Read())
            {
                comboBox1.Items.Add(majob["MName"]);
            }
            comboBox1.SelectedIndex = 0;
            majob.Close();
            sqlconnet.close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                SQLConnet sqlconnet = new SQLConnet();
                if (sqlconnet.checkit("select * from courseinfo where MName = '" + comboBox1.Text + "' and CName='"+ textBox1.Text +"'"))
                {
                    MessageBox.Show("课程已存在！");
                }
                else
                {
                    ArrayList filed = new ArrayList();
                    filed.Add("MName");
                    filed.Add("CName");
                    filed.Add("CDate");
                    filed.Add("CNum");
                    filed.Add("CRemark");
                    ArrayList fdata = new ArrayList();
                    fdata.Add(comboBox1.Text);
                    fdata.Add(textBox1.Text);
                    fdata.Add(textBox2.Text);
                    fdata.Add(textBox3.Text);
                    fdata.Add(textBox4.Text);
                    sqlconnet.addrow("select * from courseinfo", "courseinfo", filed, fdata);
                    MessageBox.Show("添加成功！");
                }
                sqlconnet.close();
            }
            else
            {
                MessageBox.Show("请输入完整信息！");
            }
        }
    }
}
