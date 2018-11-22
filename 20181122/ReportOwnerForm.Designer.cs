namespace MyCommunity
{
    partial class ReportOwnerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOwnerForm));
            this.业主报表DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.打印Button = new DevComponents.DotNetBar.ButtonX();
            this.当前状态ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.当前状态Label = new System.Windows.Forms.Label();
            this.常住人员Label = new System.Windows.Forms.Label();
            this.房屋类型Label = new System.Windows.Forms.Label();
            this.查询Button = new DevComponents.DotNetBar.ButtonX();
            this.房屋性质ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.费用类型Label = new System.Windows.Forms.Label();
            this.单元名称Label = new System.Windows.Forms.Label();
            this.楼栋名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.楼栋名称Label = new System.Windows.Forms.Label();
            this.单元名称TextBox = new System.Windows.Forms.TextBox();
            this.房屋类型ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.常住人员TextBox = new System.Windows.Forms.TextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.业主报表DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 业主报表DataGridView
            // 
            this.业主报表DataGridView.AllowUserToAddRows = false;
            this.业主报表DataGridView.AllowUserToDeleteRows = false;
            this.业主报表DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.业主报表DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.业主报表DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.业主报表DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.业主报表DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.业主报表DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.业主报表DataGridView.Location = new System.Drawing.Point(10, 68);
            this.业主报表DataGridView.MultiSelect = false;
            this.业主报表DataGridView.Name = "业主报表DataGridView";
            this.业主报表DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.业主报表DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.业主报表DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.业主报表DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.业主报表DataGridView.RowTemplate.Height = 23;
            this.业主报表DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.业主报表DataGridView.Size = new System.Drawing.Size(523, 374);
            this.业主报表DataGridView.TabIndex = 49;
            // 
            // 打印Button
            // 
            this.打印Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(467, 37);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(67, 25);
            this.打印Button.TabIndex = 48;
            this.打印Button.Text = "打印";
            this.打印Button.Click += new System.EventHandler(this.打印Button_Click);
            // 
            // 当前状态ComboBox
            // 
            this.当前状态ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.当前状态ComboBox.FormattingEnabled = true;
            this.当前状态ComboBox.Location = new System.Drawing.Point(395, 40);
            this.当前状态ComboBox.Name = "当前状态ComboBox";
            this.当前状态ComboBox.Size = new System.Drawing.Size(65, 21);
            this.当前状态ComboBox.TabIndex = 47;
            this.当前状态ComboBox.Text = "全部";
            // 
            // 当前状态Label
            // 
            this.当前状态Label.AutoSize = true;
            this.当前状态Label.Location = new System.Drawing.Point(323, 43);
            this.当前状态Label.Name = "当前状态Label";
            this.当前状态Label.Size = new System.Drawing.Size(67, 13);
            this.当前状态Label.TabIndex = 46;
            this.当前状态Label.Text = "当前状态：";
            // 
            // 常住人员Label
            // 
            this.常住人员Label.AutoSize = true;
            this.常住人员Label.Location = new System.Drawing.Point(182, 43);
            this.常住人员Label.Name = "常住人员Label";
            this.常住人员Label.Size = new System.Drawing.Size(67, 13);
            this.常住人员Label.TabIndex = 44;
            this.常住人员Label.Text = "常住人员：";
            // 
            // 房屋类型Label
            // 
            this.房屋类型Label.AutoSize = true;
            this.房屋类型Label.Location = new System.Drawing.Point(8, 43);
            this.房屋类型Label.Name = "房屋类型Label";
            this.房屋类型Label.Size = new System.Drawing.Size(67, 13);
            this.房屋类型Label.TabIndex = 42;
            this.房屋类型Label.Text = "房屋类型：";
            // 
            // 查询Button
            // 
            this.查询Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.查询Button.Image = ((System.Drawing.Image)(resources.GetObject("查询Button.Image")));
            this.查询Button.Location = new System.Drawing.Point(467, 9);
            this.查询Button.Name = "查询Button";
            this.查询Button.Size = new System.Drawing.Size(67, 25);
            this.查询Button.TabIndex = 41;
            this.查询Button.Text = "查询";
            this.查询Button.Click += new System.EventHandler(this.查询Button_Click);
            // 
            // 房屋性质ComboBox
            // 
            this.房屋性质ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.房屋性质ComboBox.FormattingEnabled = true;
            this.房屋性质ComboBox.Location = new System.Drawing.Point(395, 11);
            this.房屋性质ComboBox.Name = "房屋性质ComboBox";
            this.房屋性质ComboBox.Size = new System.Drawing.Size(65, 21);
            this.房屋性质ComboBox.TabIndex = 40;
            this.房屋性质ComboBox.Text = "全部";
            // 
            // 费用类型Label
            // 
            this.费用类型Label.AutoSize = true;
            this.费用类型Label.Location = new System.Drawing.Point(324, 16);
            this.费用类型Label.Name = "费用类型Label";
            this.费用类型Label.Size = new System.Drawing.Size(67, 13);
            this.费用类型Label.TabIndex = 39;
            this.费用类型Label.Text = "房屋性质：";
            // 
            // 单元名称Label
            // 
            this.单元名称Label.AutoSize = true;
            this.单元名称Label.Location = new System.Drawing.Point(183, 16);
            this.单元名称Label.Name = "单元名称Label";
            this.单元名称Label.Size = new System.Drawing.Size(67, 13);
            this.单元名称Label.TabIndex = 37;
            this.单元名称Label.Text = "单元名称：";
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(74, 11);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(100, 21);
            this.楼栋名称ComboBox.TabIndex = 36;
            this.楼栋名称ComboBox.Text = "全部";
            // 
            // 楼栋名称Label
            // 
            this.楼栋名称Label.AutoSize = true;
            this.楼栋名称Label.Location = new System.Drawing.Point(9, 16);
            this.楼栋名称Label.Name = "楼栋名称Label";
            this.楼栋名称Label.Size = new System.Drawing.Size(67, 13);
            this.楼栋名称Label.TabIndex = 35;
            this.楼栋名称Label.Text = "楼栋名称：";
            // 
            // 单元名称TextBox
            // 
            this.单元名称TextBox.Location = new System.Drawing.Point(256, 10);
            this.单元名称TextBox.Name = "单元名称TextBox";
            this.单元名称TextBox.Size = new System.Drawing.Size(59, 20);
            this.单元名称TextBox.TabIndex = 50;
            // 
            // 房屋类型TextBox
            // 
            this.房屋类型ComboBox.Location = new System.Drawing.Point(74, 39);
            this.房屋类型ComboBox.Name = "房屋类型TextBox";
            this.房屋类型ComboBox.Size = new System.Drawing.Size(100, 20);
            this.房屋类型ComboBox.TabIndex = 51;
            // 
            // 常住人员TextBox
            // 
            this.常住人员TextBox.Location = new System.Drawing.Point(256, 39);
            this.常住人员TextBox.Name = "常住人员TextBox";
            this.常住人员TextBox.Size = new System.Drawing.Size(59, 20);
            this.常住人员TextBox.TabIndex = 52;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // ReportOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.常住人员TextBox);
            this.Controls.Add(this.房屋类型ComboBox);
            this.Controls.Add(this.单元名称TextBox);
            this.Controls.Add(this.业主报表DataGridView);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.当前状态ComboBox);
            this.Controls.Add(this.当前状态Label);
            this.Controls.Add(this.常住人员Label);
            this.Controls.Add(this.房屋类型Label);
            this.Controls.Add(this.查询Button);
            this.Controls.Add(this.房屋性质ComboBox);
            this.Controls.Add(this.费用类型Label);
            this.Controls.Add(this.单元名称Label);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.楼栋名称Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportOwnerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报表管理[业主统计报表]";
            this.Load += new System.EventHandler(this.ReportOwnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.业主报表DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX 业主报表DataGridView;
        private DevComponents.DotNetBar.ButtonX 打印Button;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 当前状态ComboBox;
        private System.Windows.Forms.Label 当前状态Label;
        private System.Windows.Forms.Label 常住人员Label;
        private System.Windows.Forms.Label 房屋类型Label;
        private DevComponents.DotNetBar.ButtonX 查询Button;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 房屋性质ComboBox;
        private System.Windows.Forms.Label 费用类型Label;
        private System.Windows.Forms.Label 单元名称Label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 楼栋名称ComboBox;
        private System.Windows.Forms.Label 楼栋名称Label;
        private System.Windows.Forms.TextBox 单元名称TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 房屋类型ComboBox;
        private System.Windows.Forms.TextBox 常住人员TextBox;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}