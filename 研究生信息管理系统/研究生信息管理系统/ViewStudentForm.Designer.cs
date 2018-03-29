namespace 研究生信息管理系统
{
    partial class ViewStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.身份证号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业名称 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.出生日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.导师姓名 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(419, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "专业课程表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(136, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "学生信息列表";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "专业";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号,
            this.姓名,
            this.性别,
            this.身份证号,
            this.专业名称,
            this.出生日期,
            this.导师姓名,
            this.备注});
            this.dataGridView1.Location = new System.Drawing.Point(140, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(632, 464);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            // 
            // 学号
            // 
            this.学号.DataPropertyName = "SID";
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "SName";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "SSex";
            this.性别.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            // 
            // 身份证号
            // 
            this.身份证号.DataPropertyName = "SNum";
            this.身份证号.HeaderText = "身份证号";
            this.身份证号.Name = "身份证号";
            this.身份证号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.身份证号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 专业名称
            // 
            this.专业名称.DataPropertyName = "MName";
            this.专业名称.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.专业名称.HeaderText = "专业名称";
            this.专业名称.Name = "专业名称";
            // 
            // 出生日期
            // 
            this.出生日期.DataPropertyName = "SBirth";
            this.出生日期.HeaderText = "出生日期";
            this.出生日期.Name = "出生日期";
            this.出生日期.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 导师姓名
            // 
            this.导师姓名.DataPropertyName = "TID";
            this.导师姓名.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.导师姓名.HeaderText = "导师姓名";
            this.导师姓名.Name = "导师姓名";
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "SRemark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 40);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 510);
            this.treeView1.TabIndex = 8;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // ViewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Name = "ViewStudentForm";
            this.Text = "学生信息";
            this.Load += new System.EventHandler(this.ViewStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewComboBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号;
        private System.Windows.Forms.DataGridViewComboBoxColumn 专业名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生日期;
        private System.Windows.Forms.DataGridViewComboBoxColumn 导师姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}