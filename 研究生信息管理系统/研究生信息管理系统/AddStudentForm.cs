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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            //初始控件数据
            comboBox1.SelectedIndex = 0;
            SQLConnet sqlconnet = new SQLConnet();
            SqlDataReader reader = sqlconnet.readrow("select TName from teacherinfo");
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["TName"]);
            }
            comboBox2.SelectedIndex = 0;
            reader.Close();
            reader = sqlconnet.readrow("select MName from majorinfo");
            while (reader.Read())
            {
                comboBox3.Items.Add(reader["MName"]);
            }
            comboBox3.SelectedIndex = 0;
            reader.Close();
            sqlconnet.close();


            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 )
            {
                try
                {
                    int sid = Convert.ToInt32(textBox1.Text);
                    SQLConnet sqlconnet = new SQLConnet();
                    string tid =sqlconnet.readone("select * from teacherinfo where TName = '" + comboBox2.Text + "'", "TID");
                    if (sqlconnet.checkit("select * from studentinfo where SID=" + sid) || sqlconnet.checkit("select * from studentinfo where SNum='" + textBox3.Text + "'"))
                    {
                        MessageBox.Show("学号或身份证已存在！");
                    }
                    else
                    {
                        ArrayList filed = new ArrayList();
                        filed.Add("SID");
                        filed.Add("SName");
                        filed.Add("SSex");
                        filed.Add("SNum");
                        filed.Add("TID");
                        filed.Add("SBirth");
                        filed.Add("MName");
                        filed.Add("SRemark");
                        ArrayList fdata = new ArrayList();
                        fdata.Add(Convert.ToInt32(sid));
                        fdata.Add(textBox2.Text);
                        fdata.Add(comboBox1.Text);
                        fdata.Add(textBox3.Text);
                        fdata.Add(Convert.ToInt32(tid));
                        fdata.Add(dateTimePicker1.Value);
                        fdata.Add(comboBox3.Text);
                        fdata.Add(textBox4.Text);
                        sqlconnet.addrow("select * from studentinfo", "studentinfo", filed, fdata);
                        MessageBox.Show("添加成功！");
                    }
                    sqlconnet.close();
                }
                catch (Exception)
                {

                    MessageBox.Show("请输入数字学号！");
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
