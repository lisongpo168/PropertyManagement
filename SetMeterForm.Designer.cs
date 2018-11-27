namespace MyCommunity
{
    partial class SetMeterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetMeterForm));
            this.返回系统Button = new DevComponents.DotNetBar.ButtonX();
            this.修改电表Button = new DevComponents.DotNetBar.ButtonX();
            this.电表信息DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.电表序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电表编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.电表信息DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 返回系统Button
            // 
            this.返回系统Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.返回系统Button.Image = ((System.Drawing.Image)(resources.GetObject("返回系统Button.Image")));
            this.返回系统Button.Location = new System.Drawing.Point(145, 135);
            this.返回系统Button.Name = "返回系统Button";
            this.返回系统Button.Size = new System.Drawing.Size(90, 27);
            this.返回系统Button.TabIndex = 17;
            this.返回系统Button.Text = "返回系统";
            this.返回系统Button.Click += new System.EventHandler(this.返回系统Button_Click);
            // 
            // 修改电表Button
            // 
            this.修改电表Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.修改电表Button.Image = ((System.Drawing.Image)(resources.GetObject("修改电表Button.Image")));
            this.修改电表Button.Location = new System.Drawing.Point(45, 135);
            this.修改电表Button.Name = "修改密码Button";
            this.修改电表Button.Size = new System.Drawing.Size(90, 27);
            this.修改电表Button.TabIndex = 16;
            this.修改电表Button.Text = "修改电表";
            this.修改电表Button.Click += new System.EventHandler(this.修改电表Button_Click);
            // 
            // 电表信息DataGridView
            // 
            this.电表信息DataGridView.AllowUserToResizeColumns = false;
            this.电表信息DataGridView.AllowUserToResizeRows = false;
            this.电表信息DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.电表信息DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.电表序号,
            this.电表编号});
            this.电表信息DataGridView.Location = new System.Drawing.Point(-4, 1);
            this.电表信息DataGridView.Name = "电表信息DataGridView";
            this.电表信息DataGridView.RowHeadersWidth = 20;
            this.电表信息DataGridView.RowTemplate.Height = 23;
            this.电表信息DataGridView.Size = new System.Drawing.Size(268, 127);
            this.电表信息DataGridView.TabIndex = 18;
            // 
            // 电表序号
            // 
            this.电表序号.HeaderText = "电表序号";
            this.电表序号.Name = "电表序号";
            // 
            // 电表编号
            // 
            this.电表编号.HeaderText = "电表编号";
            this.电表编号.Name = "电表编号";
            // 
            // SetMeterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(260, 164);
            this.ControlBox = false;
            this.Controls.Add(this.电表信息DataGridView);
            this.Controls.Add(this.返回系统Button);
            this.Controls.Add(this.修改电表Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetMeterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统管理[电表序列管理]";
            ((System.ComponentModel.ISupportInitialize)(this.电表信息DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX 返回系统Button;
        private DevComponents.DotNetBar.ButtonX 修改电表Button;
        private DevComponents.DotNetBar.Controls.DataGridViewX 电表信息DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电表序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电表编号;
    }
}