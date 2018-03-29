using System;
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
    public partial class ViewScoreForm : Form
    {
        string rolename = null;
        public ViewScoreForm(string reader)
        {
            this.rolename = reader;
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)//关闭前操作
        {
            SQLConnet sqlconnet = new SQLConnet();
            string sql = "select * from roles where RoleName= '" + rolename + "'";
            SqlDataReader role = sqlconnet.readrow(sql);
            role.Read();
            if (!(role["ScoreManage"].ToString() == "False"))
            {
                if (MessageBox.Show("关闭前是否保存修改操作？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    updata();
                }
            }
            role.Close();
            sqlconnet.close();
            //重置工具栏状态
            MainForm mainform = new MainForm();
            mainform = (MainForm)this.MdiParent;
            mainform.renewtool();
        }



        private void ViewScoreForm_Load(object sender, EventArgs e)
        {
            //权限
            SQLConnet sqlconnet = new SQLConnet();
            string sql = "select * from roles where RoleName= '" + rolename + "'";
            SqlDataReader role = sqlconnet.readrow(sql);
            role.Read();
            if (role["ScoreManage"].ToString() == "False")
            {
                button1.Visible = false;
                button3.Visible = false;
                dataGridView1.ReadOnly = true;
            }
            role.Close();

            treeView1.Nodes.Clear();//清空树状图
            //专业、课程 树状
            SqlDataReader majob = sqlconnet.readrow("select MName from majorinfo");
            int i = 0;
            while (majob.Read())
            {
                treeView1.Nodes.Add(majob["MName"].ToString());
                i++;
            }
            majob.Close();

            SqlDataReader course;
            for (int k = 0; k < i; k++)
            {
                course = sqlconnet.readrow("select CName from courseinfo where MName='" + treeView1.Nodes[k].Text + "'");
                while (course.Read())
                {
                    treeView1.Nodes[k].Nodes.Add(course["CName"].ToString());
                }
                course.Close();
            }

            //姓名数据
            DataTable dtstudent = new DataTable();
            dtstudent.Columns.Add("Value");
            dtstudent.Columns.Add("Name");
            dtstudent.Columns[0].DataType = Type.GetType("System.Int32");
            DataRow drstudent;
            SqlDataReader student = sqlconnet.readrow("select * from studentinfo");
            while (student.Read())
            {
                drstudent = dtstudent.NewRow();
                drstudent[0] = student["SID"];
                drstudent[1] = student["SName"];
                dtstudent.Rows.Add(drstudent);
            }
            student.Close();
            姓名.ValueMember = "Value";
            姓名.DisplayMember = "Name";
            姓名.DataSource = dtstudent;




            sqlconnet.close();
            //默认tree
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
        }
        private void updata()
        {
            SQLConnet sqlconnet = new SQLConnet();
            sqlconnet.setdatatable(dataGridView1.DataSource as DataTable, "select * from scoreinfo", "scoreinfo");
            sqlconnet.close();
        }

        private void renewtree()
        {
            label3.Text = treeView1.SelectedNode.Parent.Text + "专业　　" + treeView1.SelectedNode.Text + "课程成绩";
            SQLConnet sqlconnet = new SQLConnet();
            //课程数据
            DataTable dtcourse = new DataTable();
            dtcourse.Columns.Add("Value");
            dtcourse.Columns.Add("Name");
            SqlDataReader course = sqlconnet.readrow("select CName from courseinfo where MName='" + treeView1.SelectedNode.Parent.Text + "'");
            DataRow drcourse;
            while (course.Read())
            {
                drcourse = dtcourse.NewRow();
                drcourse[0] = course["CName"];
                drcourse[1] = course["CName"];
                dtcourse.Rows.Add(drcourse);
            }
            course.Close();
            课程名称.ValueMember = "Value";
            课程名称.DisplayMember = "Name";
            课程名称.DataSource = dtcourse;
            dataGridView1.DataSource = sqlconnet.getdatatable("select * from scoreinfo where CName='" + treeView1.SelectedNode.Text + "'", "scoreinfo");
            sqlconnet.close();
            treeView1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否保存修改操作？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                updata();
                renewtree();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除选中行？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                updata();
                renewtree();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Level == 0)
            {
                treeView1.SelectedNode = treeView1.SelectedNode.Nodes[0];
            }
            renewtree();

        }
    }
}
