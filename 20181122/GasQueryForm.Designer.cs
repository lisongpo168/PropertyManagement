namespace MyCommunity
{
    partial class GasQueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasQueryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.计费年份Label = new System.Windows.Forms.Label();
            this.计费年份ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.计费月份ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.计费月份Label = new System.Windows.Forms.Label();
            this.费用类型ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.费用类型Label = new System.Windows.Forms.Label();
            this.查询Button = new DevComponents.DotNetBar.ButtonX();
            this.费用状态ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.费用状态Label = new System.Windows.Forms.Label();
            this.业主姓名ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.业主姓名Label = new System.Windows.Forms.Label();
            this.楼栋名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.楼栋名称Label = new System.Windows.Forms.Label();
            this.打印Button = new DevComponents.DotNetBar.ButtonX();
            this.水电气费DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.水电气费DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 计费年份Label
            // 
            this.计费年份Label.AutoSize = true;
            this.计费年份Label.Location = new System.Drawing.Point(7, 13);
            this.计费年份Label.Name = "计费年份Label";
            this.计费年份Label.Size = new System.Drawing.Size(65, 12);
            this.计费年份Label.TabIndex = 0;
            this.计费年份Label.Text = "计费年份：";
            // 
            // 计费年份ComboBox
            // 
            this.计费年份ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.计费年份ComboBox.FormattingEnabled = true;
            this.计费年份ComboBox.Location = new System.Drawing.Point(72, 8);
            this.计费年份ComboBox.Name = "计费年份ComboBox";
            this.计费年份ComboBox.Size = new System.Drawing.Size(94, 20);
            this.计费年份ComboBox.TabIndex = 1;
            // 
            // 计费月份ComboBox
            // 
            this.计费月份ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.计费月份ComboBox.FormattingEnabled = true;
            this.计费月份ComboBox.Location = new System.Drawing.Point(239, 8);
            this.计费月份ComboBox.Name = "计费月份ComboBox";
            this.计费月份ComboBox.Size = new System.Drawing.Size(75, 20);
            this.计费月份ComboBox.TabIndex = 3;
            this.计费月份ComboBox.Text = "全年";
            // 
            // 计费月份Label
            // 
            this.计费月份Label.AutoSize = true;
            this.计费月份Label.Location = new System.Drawing.Point(172, 13);
            this.计费月份Label.Name = "计费月份Label";
            this.计费月份Label.Size = new System.Drawing.Size(65, 12);
            this.计费月份Label.TabIndex = 2;
            this.计费月份Label.Text = "计费月份：";
            // 
            // 费用类型ComboBox
            // 
            this.费用类型ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.费用类型ComboBox.FormattingEnabled = true;
            this.费用类型ComboBox.Location = new System.Drawing.Point(389, 8);
            this.费用类型ComboBox.Name = "费用类型ComboBox";
            this.费用类型ComboBox.Size = new System.Drawing.Size(70, 20);
            this.费用类型ComboBox.TabIndex = 5;
            this.费用类型ComboBox.Text = "全部";
            // 
            // 费用类型Label
            // 
            this.费用类型Label.AutoSize = true;
            this.费用类型Label.Location = new System.Drawing.Point(321, 13);
            this.费用类型Label.Name = "费用类型Label";
            this.费用类型Label.Size = new System.Drawing.Size(65, 12);
            this.费用类型Label.TabIndex = 4;
            this.费用类型Label.Text = "费用类型：";
            // 
            // 查询Button
            // 
            this.查询Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.查询Button.Image = ((System.Drawing.Image)(resources.GetObject("查询Button.Image")));
            this.查询Button.Location = new System.Drawing.Point(465, 6);
            this.查询Button.Name = "查询Button";
            this.查询Button.Size = new System.Drawing.Size(67, 23);
            this.查询Button.TabIndex = 26;
            this.查询Button.Text = "查询";
            this.查询Button.Click += new System.EventHandler(this.查询Button_Click);
            // 
            // 费用状态ComboBox
            // 
            this.费用状态ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.费用状态ComboBox.FormattingEnabled = true;
            this.费用状态ComboBox.Location = new System.Drawing.Point(389, 31);
            this.费用状态ComboBox.Name = "费用状态ComboBox";
            this.费用状态ComboBox.Size = new System.Drawing.Size(70, 20);
            this.费用状态ComboBox.TabIndex = 32;
            this.费用状态ComboBox.Text = "全部";
            // 
            // 费用状态Label
            // 
            this.费用状态Label.AutoSize = true;
            this.费用状态Label.Location = new System.Drawing.Point(320, 36);
            this.费用状态Label.Name = "费用状态Label";
            this.费用状态Label.Size = new System.Drawing.Size(65, 12);
            this.费用状态Label.TabIndex = 31;
            this.费用状态Label.Text = "费用状态：";
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(239, 31);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(75, 20);
            this.业主姓名ComboBox.TabIndex = 30;
            this.业主姓名ComboBox.Text = "全部";
            // 
            // 业主姓名Label
            // 
            this.业主姓名Label.AutoSize = true;
            this.业主姓名Label.Location = new System.Drawing.Point(171, 36);
            this.业主姓名Label.Name = "业主姓名Label";
            this.业主姓名Label.Size = new System.Drawing.Size(65, 12);
            this.业主姓名Label.TabIndex = 29;
            this.业主姓名Label.Text = "业主姓名：";
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(71, 31);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(94, 20);
            this.楼栋名称ComboBox.TabIndex = 28;
            this.楼栋名称ComboBox.Text = "全部";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 楼栋名称Label
            // 
            this.楼栋名称Label.AutoSize = true;
            this.楼栋名称Label.Location = new System.Drawing.Point(6, 36);
            this.楼栋名称Label.Name = "楼栋名称Label";
            this.楼栋名称Label.Size = new System.Drawing.Size(65, 12);
            this.楼栋名称Label.TabIndex = 27;
            this.楼栋名称Label.Text = "楼栋名称：";
            // 
            // 打印Button
            // 
            this.打印Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(465, 30);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(67, 23);
            this.打印Button.TabIndex = 33;
            this.打印Button.Text = "打印";
            this.打印Button.Click += new System.EventHandler(this.打印Button_Click);
            // 
            // 水电气费DataGridView
            // 
            this.水电气费DataGridView.AllowUserToAddRows = false;
            this.水电气费DataGridView.AllowUserToDeleteRows = false;
            this.水电气费DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.水电气费DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.水电气费DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.水电气费DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.水电气费DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.水电气费DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.水电气费DataGridView.Location = new System.Drawing.Point(8, 61);
            this.水电气费DataGridView.MultiSelect = false;
            this.水电气费DataGridView.Name = "水电气费DataGridView";
            this.水电气费DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.水电气费DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.水电气费DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.水电气费DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.水电气费DataGridView.RowTemplate.Height = 23;
            this.水电气费DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.水电气费DataGridView.Size = new System.Drawing.Size(523, 345);
            this.水电气费DataGridView.TabIndex = 34;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // GasQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(542, 416);
            this.Controls.Add(this.水电气费DataGridView);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.费用状态ComboBox);
            this.Controls.Add(this.费用状态Label);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(this.业主姓名Label);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.楼栋名称Label);
            this.Controls.Add(this.查询Button);
            this.Controls.Add(this.费用类型ComboBox);
            this.Controls.Add(this.费用类型Label);
            this.Controls.Add(this.计费月份ComboBox);
            this.Controls.Add(this.计费月份Label);
            this.Controls.Add(this.计费年份ComboBox);
            this.Controls.Add(this.计费年份Label);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GasQueryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "费用管理[水电气费查询]";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.GasQueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.水电气费DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 计费年份Label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 计费年份ComboBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 计费月份ComboBox;
        private System.Windows.Forms.Label 计费月份Label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 费用类型ComboBox;
        private System.Windows.Forms.Label 费用类型Label;
        private DevComponents.DotNetBar.ButtonX 查询Button;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 费用状态ComboBox;
        private System.Windows.Forms.Label 费用状态Label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 业主姓名ComboBox;
        private System.Windows.Forms.Label 业主姓名Label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 楼栋名称ComboBox;
        private System.Windows.Forms.Label 楼栋名称Label;
        private DevComponents.DotNetBar.ButtonX 打印Button;
        private DevComponents.DotNetBar.Controls.DataGridViewX 水电气费DataGridView;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}