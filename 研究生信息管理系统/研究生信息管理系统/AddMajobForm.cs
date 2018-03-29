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
    public partial class AddMajobForm : Form
    {
        public AddMajobForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//确定
        {
            if (textBox1.Text.Length > 0)
            {
                SQLConnet sqlconnet = new SQLConnet();
                if (sqlconnet.checkit("select MName from majorinfo where MName = '"+ textBox1.Text + "'"))
                {
                    MessageBox.Show("专业已存在！");
                }
                else
                {
                    ArrayList filed = new ArrayList();
                    filed.Add("MName");
                    filed.Add("MRemark");
                    ArrayList fdata = new ArrayList();
                    fdata.Add(textBox1.Text);
                    fdata.Add(textBox2.Text);
                    sqlconnet.addrow("select * from majorinfo", "majorinfo", filed, fdata);
                    MessageBox.Show("添加成功！");
                }
                sqlconnet.close();
            }
            else
            {
                MessageBox.Show("请输入完整信息！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
