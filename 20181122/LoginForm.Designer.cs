namespace MyCommunity
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.退出系统Button = new DevComponents.DotNetBar.ButtonX();
            this.登录系统Button = new DevComponents.DotNetBar.ButtonX();
            this.用户密码TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.用户名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 退出系统Button
            // 
            this.退出系统Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.退出系统Button.Image = ((System.Drawing.Image)(resources.GetObject("退出系统Button.Image")));
            this.退出系统Button.Location = new System.Drawing.Point(178, 108);
            this.退出系统Button.Name = "退出系统Button";
            this.退出系统Button.Size = new System.Drawing.Size(100, 27);
            this.退出系统Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.退出系统Button.TabIndex = 11;
            this.退出系统Button.Text = "退出系统";
            this.退出系统Button.Click += new System.EventHandler(this.退出系统Button_Click);
            // 
            // 登录系统Button
            // 
            this.登录系统Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.登录系统Button.Image = ((System.Drawing.Image)(resources.GetObject("登录系统Button.Image")));
            this.登录系统Button.Location = new System.Drawing.Point(72, 108);
            this.登录系统Button.Name = "登录系统Button";
            this.登录系统Button.Size = new System.Drawing.Size(100, 27);
            this.登录系统Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.登录系统Button.TabIndex = 10;
            this.登录系统Button.Text = "登录系统";
            this.登录系统Button.Click += new System.EventHandler(this.登录系统Button_Click);
            // 
            // 用户密码TextBox
            // 
            this.用户密码TextBox.Location = new System.Drawing.Point(120, 74);
            this.用户密码TextBox.Name = "用户密码TextBox";
            this.用户密码TextBox.PasswordChar = '*';
            this.用户密码TextBox.Size = new System.Drawing.Size(174, 20);
            this.用户密码TextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "用户密码：";
            // 
            // 用户名称ComboBox
            // 
            this.用户名称ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.用户名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.用户名称ComboBox.Location = new System.Drawing.Point(120, 40);
            this.用户名称ComboBox.Name = "用户名称ComboBox";
            this.用户名称ComboBox.Size = new System.Drawing.Size(174, 21);
            this.用户名称ComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.用户名称ComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户名称：";
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(320, 144);
            this.ControlBox = false;
            this.Controls.Add(this.退出系统Button);
            this.Controls.Add(this.登录系统Button);
            this.Controls.Add(this.用户密码TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.用户名称ComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录小区物业管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX 退出系统Button;
        private DevComponents.DotNetBar.ButtonX 登录系统Button;
        private System.Windows.Forms.TextBox 用户密码TextBox;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 用户名称ComboBox;
        private System.Windows.Forms.Label label1;
    }
}