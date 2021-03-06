﻿using System;
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
    public partial class ViewCourseForm : Form
    {
        string rolename;
        public ViewCourseForm(string reader)
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
            if (!(role["CourseManage"].ToString() == "False"))
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

        private void ViewCourseForm_Load(object sender, EventArgs e)
        {
            SQLConnet sqlconnet = new SQLConnet();
            string sql = "select * from roles where RoleName= '" + rolename + "'";
            SqlDataReader role = sqlconnet.readrow(sql);
            role.Read();
            if (role["SystemManage"].ToString() == "False" && role["MajorManage"].ToString() == "False" && role["CourseManage"].ToString() == "False" && role["ScoreManage"].ToString() == "False")
            {
                button1.Visible = false;
                button3.Visible = false;
                dataGridView1.ReadOnly = true;
            }
            role.Close();
            //专业  数据和树状
            DataTable dtmajob = new DataTable();
            dtmajob.Columns.Add("Value");
            dtmajob.Columns.Add("Name");
            SqlDataReader majob = sqlconnet.readrow("select MName from majorinfo");
            DataRow drmajob;
            treeView1.Nodes.Clear();//清空树状图
            while (majob.Read())
            {
                treeView1.Nodes.Add(majob["MName"].ToString());

                drmajob = dtmajob.NewRow();
                drmajob[0] = majob["MName"];
                drmajob[1] = majob["MName"];
                dtmajob.Rows.Add(drmajob);
            }
            majob.Close();
            专业名称.ValueMember = "Value";
            专业名称.DisplayMember = "Name";
            专业名称.DataSource = dtmajob;
            sqlconnet.close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label3.Text = e.Node.Text + "专业课程表";
            SQLConnet sqlconnet = new SQLConnet();
            dataGridView1.DataSource = sqlconnet.getdatatable("select * from courseinfo where MName='" + e.Node.Text + "'", "courseinfo");
            sqlconnet.close();
        }
        private void updata()
        {
            SQLConnet sqlconnet = new SQLConnet();
            sqlconnet.setdatatable(dataGridView1.DataSource as DataTable, "select * from courseinfo", "courseinfo");
            sqlconnet.close();
        }
        private void renewtree()
        {
            SQLConnet sqlconnet = new SQLConnet();
            dataGridView1.DataSource = sqlconnet.getdatatable("select * from courseinfo where MName='" + treeView1.SelectedNode.Text + "'", "courseinfo");

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


    }
}
