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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            SQLConnet sqlconnet = new SQLConnet();
            SqlDataReader reader = sqlconnet.readrow("select SName from studentinfo");
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["SName"]);
            }
            comboBox1.SelectedIndex = 0;
            reader.Close();
            reader = sqlconnet.readrow("select CName from courseinfo");
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["CName"]);
            }
            comboBox2.SelectedIndex = 0;
            reader.Close();
            sqlconnet.close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                SQLConnet sqlconnet = new SQLConnet();
                string sid = sqlconnet.readone("select * from studentinfo where SName = '" + comboBox1.Text + "'", "SID");
                if (sqlconnet.checkit("select * from scoreinfo where SID=" + sid + "and CName = '" + comboBox2.Text + "'"))
                {
                    MessageBox.Show("成绩已存在！");
                }
                else
                {
                    ArrayList filed = new ArrayList();
                    filed.Add("SID");
                    filed.Add("CName");
                    filed.Add("Score");
                    ArrayList fdata = new ArrayList();
                    fdata.Add(Convert.ToInt32(sid));
                    fdata.Add(comboBox2.Text);
                    fdata.Add(textBox1.Text);
                    sqlconnet.addrow("select * from scoreinfo", "scoreinfo", filed, fdata);
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
