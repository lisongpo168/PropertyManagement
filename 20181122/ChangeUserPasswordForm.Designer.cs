﻿namespace MyCommunity
{
    partial class ChangeUserPasswordForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserPasswordForm));
            this.用户名称TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.返回系统Button = new DevComponents.DotNetBar.ButtonX();
            this.修改密码Button = new DevComponents.DotNetBar.ButtonX();
            this.再输一次新密码TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.新密码TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.旧密码TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 用户名称TextBox
            // 
            this.用户名称TextBox.Location = new System.Drawing.Point(122, 107);
            this.用户名称TextBox.Name = "用户名称TextBox";
            this.用户名称TextBox.ReadOnly = true;
            this.用户名称TextBox.Size = new System.Drawing.Size(173, 20);
            this.用户名称TextBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "用户名称：";
            // 
            // 返回系统Button
            // 
            this.返回系统Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.返回系统Button.Image = ((System.Drawing.Image)(resources.GetObject("返回系统Button.Image")));
            this.返回系统Button.Location = new System.Drawing.Point(196, 137);
            this.返回系统Button.Name = "返回系统Button";
            this.返回系统Button.Size = new System.Drawing.Size(100, 27);
            this.返回系统Button.TabIndex = 17;
            this.返回系统Button.Text = "返回系统";
            this.返回系统Button.Click += new System.EventHandler(this.返回系统Button_Click);
            // 
            // 修改密码Button
            // 
            this.修改密码Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.修改密码Button.Image = ((System.Drawing.Image)(resources.GetObject("修改密码Button.Image")));
            this.修改密码Button.Location = new System.Drawing.Point(86, 137);
            this.修改密码Button.Name = "修改密码Button";
            this.修改密码Button.Size = new System.Drawing.Size(100, 27);
            this.修改密码Button.TabIndex = 16;
            this.修改密码Button.Text = "修改密码";
            this.修改密码Button.Click += new System.EventHandler(this.修改密码Button_Click);
            // 
            // 再输一次新密码TextBox
            // 
            this.再输一次新密码TextBox.Location = new System.Drawing.Point(149, 78);
            this.再输一次新密码TextBox.Name = "再输一次新密码TextBox";
            this.再输一次新密码TextBox.PasswordChar = '*';
            this.再输一次新密码TextBox.Size = new System.Drawing.Size(146, 20);
            this.再输一次新密码TextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "再输一次新密码：";
            // 
            // 新密码TextBox
            // 
            this.新密码TextBox.Location = new System.Drawing.Point(110, 49);
            this.新密码TextBox.Name = "新密码TextBox";
            this.新密码TextBox.PasswordChar = '*';
            this.新密码TextBox.Size = new System.Drawing.Size(185, 20);
            this.新密码TextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "新密码：";
            // 
            // 旧密码TextBox
            // 
            this.旧密码TextBox.Location = new System.Drawing.Point(110, 20);
            this.旧密码TextBox.Name = "旧密码TextBox";
            this.旧密码TextBox.PasswordChar = '*';
            this.旧密码TextBox.Size = new System.Drawing.Size(185, 20);
            this.旧密码TextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "旧密码：";
            // 
            // ChangeUserPasswordForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(340, 191);
            this.ControlBox = false;
            this.Controls.Add(this.用户名称TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.返回系统Button);
            this.Controls.Add(this.修改密码Button);
            this.Controls.Add(this.再输一次新密码TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.新密码TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.旧密码TextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeUserPasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统管理[修改用户密码]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox 用户名称TextBox;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonX 返回系统Button;
        private DevComponents.DotNetBar.ButtonX 修改密码Button;
        private System.Windows.Forms.TextBox 再输一次新密码TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 新密码TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 旧密码TextBox;
        private System.Windows.Forms.Label label1;
    }
}