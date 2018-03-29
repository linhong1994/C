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
    public partial class ViewStudentForm : Form
    {
        DateTimePicker dtp = new DateTimePicker();  //实例化一个DateTimePicker控件
        Rectangle _Rectangle;
        string rolename = null;
        public ViewStudentForm(string reader)
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
            if (! (role["SystemManage"].ToString() == "False" && role["MajorManage"].ToString() == "False" && role["CourseManage"].ToString() == "False" && role["ScoreManage"].ToString() == "False"))
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
        //时间控件选择时间时
        private void dtp_TextChange(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dtp.Text.ToString();  //时间控件选择时间时，就把时间赋给所在的单元格  
        }

        //单元格被单击，判断是否是放时间控件的那一列
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4 && (!dataGridView1.ReadOnly))
            {
                _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //得到所在单元格位置和大小  
                dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //把单元格大小赋给时间控件  
                dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //把单元格位置赋给时间控件
                if (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Length > 0)
                {
                    dtp.Value = Convert.ToDateTime(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                else
                {
                    dtp.Value = DateTime.Now;
                }
                dtp.Visible = true;  //可以显示控件了  
            }
            else
                dtp.Visible = false;
        }
        //当列的宽度变化时，时间控件先隐藏起来，不然单元格变大时间控件无法跟着变大
        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;

        }

        //滚动条滚动时，单元格位置发生变化，也得隐藏时间控件，不然时间控件位置不动就乱了
        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }
        private void ViewStudentForm_Load(object sender, EventArgs e)
        {
            //权限
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
            //性别
            DataTable dtSex = new DataTable();
            dtSex.Columns.Add("Value");
            dtSex.Columns.Add("Name");
            DataRow drSex;
            drSex = dtSex.NewRow();
            drSex[0] = "男";
            drSex[1] = "男";
            dtSex.Rows.Add(drSex);
            drSex = dtSex.NewRow();
            drSex[0] = "女";
            drSex[1] = "女";
            dtSex.Rows.Add(drSex);
            性别.ValueMember = "Value";
            性别.DisplayMember = "Name";
            性别.DataSource = dtSex;


            //导师
            DataTable dtteacher = new DataTable();
            dtteacher.Columns.Add("Value");
            dtteacher.Columns.Add("Name");
            dtteacher.Columns[0].DataType = Type.GetType("System.Int32");
            DataRow drteacher;
            SqlDataReader teacher = sqlconnet.readrow("select * from teacherinfo");
            while (teacher.Read())
            {
                drteacher = dtteacher.NewRow();
                drteacher[0] = teacher["TID"];
                drteacher[1] = teacher["TName"];
                dtteacher.Rows.Add(drteacher);
            }
            teacher.Close();
            导师姓名.ValueMember = "Value";
            导师姓名.DisplayMember = "Name";
            导师姓名.DataSource = dtteacher;
            //日期
            dataGridView1.Controls.Add(dtp);  //把时间控件加入DataGridView  
            dtp.Visible = false;  //先不让它显示  
            dtp.Format = DateTimePickerFormat.Custom;  //设置日期格式为2010-08-05 
            dtp.CustomFormat = "yyyy-MM-dd";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";
            dtp.TextChanged += new EventHandler(dtp_TextChange); //为时间控件加入事件dtp_TextChange


            sqlconnet.close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void updata()
        {
            SQLConnet sqlconnet = new SQLConnet();
            sqlconnet.setdatatable(dataGridView1.DataSource as DataTable, "select * from studentinfo", "studentinfo");
            string xh = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            if (!sqlconnet.checkit("select * from userinfo where UName='s"+xh+"'"))//新增学生添加账号
            {
                ArrayList filed = new ArrayList();
                filed.Add("UName");
                filed.Add("PWD");
                filed.Add("RoleName");
                ArrayList fdata = new ArrayList();
                fdata.Add("s"+xh);//新增学号
                fdata.Add("1");
                fdata.Add("学生");
                sqlconnet.addrow("select * from userinfo", "userinfo", filed, fdata);
            }
            sqlconnet.close();
        }

        private void renewtree()
        {
            SQLConnet sqlconnet = new SQLConnet();
            dataGridView1.DataSource = sqlconnet.getdatatable("select * from studentinfo where MName='" + treeView1.SelectedNode.Text + "'", "studentinfo");
            
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label3.Text = e.Node.Text + "专业学生表";
            SQLConnet sqlconnet = new SQLConnet();
            dataGridView1.DataSource = sqlconnet.getdatatable("select * from studentinfo where MName='" + e.Node.Text + "'", "studentinfo");
            sqlconnet.close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除选中行？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string xh = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                SQLConnet sqlconnet = new SQLConnet();
                sqlconnet.runsql("delete from userinfo where UName='s" + xh + "'");
                sqlconnet.close();
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                updata();
                renewtree();
            }
        }
    }
}
