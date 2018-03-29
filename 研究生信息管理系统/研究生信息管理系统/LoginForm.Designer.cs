namespace 研究生信息管理系统
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_login_user = new System.Windows.Forms.TextBox();
            this.tb_login_password = new System.Windows.Forms.TextBox();
            this.bt_login_ok = new System.Windows.Forms.Button();
            this.bt_login_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密　码：";
            // 
            // tb_login_user
            // 
            this.tb_login_user.Location = new System.Drawing.Point(94, 18);
            this.tb_login_user.Name = "tb_login_user";
            this.tb_login_user.Size = new System.Drawing.Size(117, 21);
            this.tb_login_user.TabIndex = 2;
            // 
            // tb_login_password
            // 
            this.tb_login_password.Location = new System.Drawing.Point(94, 60);
            this.tb_login_password.Name = "tb_login_password";
            this.tb_login_password.PasswordChar = '*';
            this.tb_login_password.Size = new System.Drawing.Size(117, 21);
            this.tb_login_password.TabIndex = 3;
            // 
            // bt_login_ok
            // 
            this.bt_login_ok.Location = new System.Drawing.Point(37, 104);
            this.bt_login_ok.Name = "bt_login_ok";
            this.bt_login_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_login_ok.TabIndex = 4;
            this.bt_login_ok.Text = "登录";
            this.bt_login_ok.UseVisualStyleBackColor = true;
            this.bt_login_ok.Click += new System.EventHandler(this.bt_login_ok_Click);
            // 
            // bt_login_cancel
            // 
            this.bt_login_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_login_cancel.Location = new System.Drawing.Point(136, 104);
            this.bt_login_cancel.Name = "bt_login_cancel";
            this.bt_login_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_login_cancel.TabIndex = 5;
            this.bt_login_cancel.Text = "退出";
            this.bt_login_cancel.UseVisualStyleBackColor = true;
            this.bt_login_cancel.Click += new System.EventHandler(this.bt_login_cancel_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.bt_login_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 146);
            this.Controls.Add(this.bt_login_cancel);
            this.Controls.Add(this.bt_login_ok);
            this.Controls.Add(this.tb_login_password);
            this.Controls.Add(this.tb_login_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_login_user;
        private System.Windows.Forms.TextBox tb_login_password;
        private System.Windows.Forms.Button bt_login_ok;
        private System.Windows.Forms.Button bt_login_cancel;
    }
}