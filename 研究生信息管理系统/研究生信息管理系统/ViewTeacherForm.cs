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
    public partial class ViewTeacherForm : Form
    {
        string rolename = null;
        public ViewTeacherForm(string reader)
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
            if (!(role["SystemManage"].ToString() == "False"))
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
        private void setdatagirdview()
        {
            SQLConnet sqlconnet = new SQLConnet();
            DataTable sqltable = sqlconnet.getdatatable("select * from teacherinfo", "teacherinfo");
            label3.Text = "共有" + sqltable.Rows.Count + "条记录";
            dataGridView1.DataSource = sqltable;
            sqlconnet.close();

        }
        private void ViewTeacherForm_Load(object sender, EventArgs e)
        {
            //权限
            SQLConnet sqlconnet = new SQLConnet();
            string sql = "select * from roles where RoleName= '" + rolename + "'";
            SqlDataReader role = sqlconnet.readrow(sql);
            role.Read();
            if (role["SystemManage"].ToString() == "False")
            {
                button1.Visible = false;
                button3.Visible = false;
                dataGridView1.ReadOnly = true;
            }
            role.Close();
            sqlconnet.close();

            setdatagirdview();
        }
        private void updata()
        {
            SQLConnet sqlconnet = new SQLConnet();
            sqlconnet.setdatatable(dataGridView1.DataSource as DataTable, "select * from teacherinfo", "teacherinfo");
            
            string xh = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            if (xh.Length<1)
            {
                xh = (sqlconnet.readone("SELECT   IDENT_CURRENT('teacherinfo') AS Expr", "Expr"));//查询自增序号
            }
            if (!sqlconnet.checkit("select * from userinfo where UName='t" + xh + "'"))//新增学生添加账号
            {
                ArrayList filed = new ArrayList();
                filed.Add("UName");
                filed.Add("PWD");
                filed.Add("RoleName");
                ArrayList fdata = new ArrayList();
                fdata.Add("t"+xh);//新增学号
                fdata.Add("1");
                fdata.Add("教师");
                sqlconnet.addrow("select * from userinfo", "userinfo", filed, fdata);
            }
            sqlconnet.close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除选中行？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string xh = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                SQLConnet sqlconnet = new SQLConnet();
                sqlconnet.runsql("delete from userinfo where UName='t" + xh + "'");
                sqlconnet.close();
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                updata();
                setdatagirdview();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否保存修改操作？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                updata();
                setdatagirdview();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
