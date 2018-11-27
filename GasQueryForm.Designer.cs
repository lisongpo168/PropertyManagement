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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.计费年份Label = new System.Windows.Forms.Label();
            this.计费年份ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.计费月份ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.计费月份Label = new System.Windows.Forms.Label();
            this.费用类型Label = new System.Windows.Forms.Label();
            this.查询Button = new DevComponents.DotNetBar.ButtonX();
            this.费用状态Label = new System.Windows.Forms.Label();
            this.业主姓名ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.业主姓名Label = new System.Windows.Forms.Label();
            this.楼栋名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.楼栋名称Label = new System.Windows.Forms.Label();
            this.打印Button = new DevComponents.DotNetBar.ButtonX();
            this.水电气费DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.小区名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.费用状态ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.业主编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.计费年月 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物业费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.应收费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实收费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预收费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.水电气费DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 计费年份Label
            // 
            this.计费年份Label.AutoSize = true;
            this.计费年份Label.Location = new System.Drawing.Point(7, 14);
            this.计费年份Label.Name = "计费年份Label";
            this.计费年份Label.Size = new System.Drawing.Size(67, 13);
            this.计费年份Label.TabIndex = 0;
            this.计费年份Label.Text = "计费年份：";
            // 
            // 计费年份ComboBox
            // 
            this.计费年份ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.计费年份ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.计费年份ComboBox.FormattingEnabled = true;
            this.计费年份ComboBox.Location = new System.Drawing.Point(72, 9);
            this.计费年份ComboBox.Name = "计费年份ComboBox";
            this.计费年份ComboBox.Size = new System.Drawing.Size(50, 21);
            this.计费年份ComboBox.TabIndex = 1;
            // 
            // 计费月份ComboBox
            // 
            this.计费月份ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.计费月份ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.计费月份ComboBox.FormattingEnabled = true;
            this.计费月份ComboBox.Location = new System.Drawing.Point(192, 9);
            this.计费月份ComboBox.Name = "计费月份ComboBox";
            this.计费月份ComboBox.Size = new System.Drawing.Size(50, 21);
            this.计费月份ComboBox.TabIndex = 3;
            // 
            // 计费月份Label
            // 
            this.计费月份Label.AutoSize = true;
            this.计费月份Label.Location = new System.Drawing.Point(125, 14);
            this.计费月份Label.Name = "计费月份Label";
            this.计费月份Label.Size = new System.Drawing.Size(67, 13);
            this.计费月份Label.TabIndex = 2;
            this.计费月份Label.Text = "计费月份：";
            // 
            // 费用类型Label
            // 
            this.费用类型Label.AutoSize = true;
            this.费用类型Label.Location = new System.Drawing.Point(245, 14);
            this.费用类型Label.Name = "费用类型Label";
            this.费用类型Label.Size = new System.Drawing.Size(67, 13);
            this.费用类型Label.TabIndex = 4;
            this.费用类型Label.Text = "小区名称：";
            // 
            // 查询Button
            // 
            this.查询Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.查询Button.Image = ((System.Drawing.Image)(resources.GetObject("查询Button.Image")));
            this.查询Button.Location = new System.Drawing.Point(465, 7);
            this.查询Button.Name = "查询Button";
            this.查询Button.Size = new System.Drawing.Size(67, 25);
            this.查询Button.TabIndex = 26;
            this.查询Button.Text = "查询";
            this.查询Button.Click += new System.EventHandler(this.查询Button_Click);
            // 
            // 费用状态Label
            // 
            this.费用状态Label.AutoSize = true;
            this.费用状态Label.Location = new System.Drawing.Point(320, 39);
            this.费用状态Label.Name = "费用状态Label";
            this.费用状态Label.Size = new System.Drawing.Size(67, 13);
            this.费用状态Label.TabIndex = 31;
            this.费用状态Label.Text = "费用状态：";
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.业主姓名ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(239, 34);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(75, 21);
            this.业主姓名ComboBox.TabIndex = 30;
            // 
            // 业主姓名Label
            // 
            this.业主姓名Label.AutoSize = true;
            this.业主姓名Label.Location = new System.Drawing.Point(171, 39);
            this.业主姓名Label.Name = "业主姓名Label";
            this.业主姓名Label.Size = new System.Drawing.Size(67, 13);
            this.业主姓名Label.TabIndex = 29;
            this.业主姓名Label.Text = "业主姓名：";
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.楼栋名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(71, 34);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(94, 21);
            this.楼栋名称ComboBox.TabIndex = 28;
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 楼栋名称Label
            // 
            this.楼栋名称Label.AutoSize = true;
            this.楼栋名称Label.Location = new System.Drawing.Point(6, 39);
            this.楼栋名称Label.Name = "楼栋名称Label";
            this.楼栋名称Label.Size = new System.Drawing.Size(67, 13);
            this.楼栋名称Label.TabIndex = 27;
            this.楼栋名称Label.Text = "楼栋名称：";
            // 
            // 打印Button
            // 
            this.打印Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(465, 33);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(67, 25);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.水电气费DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.水电气费DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.业主编号,
            this.业主姓名,
            this.计费年月,
            this.电费,
            this.物业费,
            this.应收费,
            this.实收费,
            this.预收费,
            this.状态,
            this.电话,
            this.备注});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.水电气费DataGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.水电气费DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.水电气费DataGridView.Location = new System.Drawing.Point(8, 66);
            this.水电气费DataGridView.MultiSelect = false;
            this.水电气费DataGridView.Name = "水电气费DataGridView";
            this.水电气费DataGridView.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.水电气费DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.水电气费DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Green;
            this.水电气费DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.水电气费DataGridView.RowTemplate.Height = 23;
            this.水电气费DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.水电气费DataGridView.Size = new System.Drawing.Size(523, 374);
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
            // 小区名称ComboBox
            // 
            this.小区名称ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.小区名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.小区名称ComboBox.FormattingEnabled = true;
            this.小区名称ComboBox.Location = new System.Drawing.Point(316, 9);
            this.小区名称ComboBox.Name = "小区名称ComboBox";
            this.小区名称ComboBox.Size = new System.Drawing.Size(138, 21);
            this.小区名称ComboBox.TabIndex = 35;
            this.小区名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.小区名称ComboBox_SelectedIndexChanged);
            // 
            // 费用状态ComboBox
            // 
            this.费用状态ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.费用状态ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.费用状态ComboBox.FormattingEnabled = true;
            this.费用状态ComboBox.Location = new System.Drawing.Point(388, 34);
            this.费用状态ComboBox.Name = "费用状态ComboBox";
            this.费用状态ComboBox.Size = new System.Drawing.Size(66, 21);
            this.费用状态ComboBox.TabIndex = 36;
            // 
            // 业主编号
            // 
            this.业主编号.HeaderText = "业主编号";
            this.业主编号.Name = "业主编号";
            this.业主编号.ReadOnly = true;
            // 
            // 业主姓名
            // 
            this.业主姓名.HeaderText = "业主姓名";
            this.业主姓名.Name = "业主姓名";
            this.业主姓名.ReadOnly = true;
            this.业主姓名.Width = 80;
            // 
            // 计费年月
            // 
            this.计费年月.HeaderText = "计费年月";
            this.计费年月.Name = "计费年月";
            this.计费年月.ReadOnly = true;
            this.计费年月.Width = 80;
            // 
            // 电费
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.电费.DefaultCellStyle = dataGridViewCellStyle11;
            this.电费.HeaderText = "电费";
            this.电费.Name = "电费";
            this.电费.ReadOnly = true;
            this.电费.Width = 60;
            // 
            // 物业费
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.物业费.DefaultCellStyle = dataGridViewCellStyle12;
            this.物业费.HeaderText = "物业费";
            this.物业费.Name = "物业费";
            this.物业费.ReadOnly = true;
            this.物业费.Width = 60;
            // 
            // 应收费
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.应收费.DefaultCellStyle = dataGridViewCellStyle13;
            this.应收费.HeaderText = "应收费";
            this.应收费.Name = "应收费";
            this.应收费.ReadOnly = true;
            this.应收费.Width = 60;
            // 
            // 实收费
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.实收费.DefaultCellStyle = dataGridViewCellStyle14;
            this.实收费.HeaderText = "实收费";
            this.实收费.Name = "实收费";
            this.实收费.ReadOnly = true;
            this.实收费.Width = 60;
            // 
            // 预收费
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.预收费.DefaultCellStyle = dataGridViewCellStyle15;
            this.预收费.HeaderText = "预收费";
            this.预收费.Name = "预收费";
            this.预收费.ReadOnly = true;
            this.预收费.Width = 60;
            // 
            // 状态
            // 
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            this.状态.Width = 60;
            // 
            // 电话
            // 
            this.电话.HeaderText = "电话";
            this.电话.Name = "电话";
            this.电话.ReadOnly = true;
            this.电话.Width = 80;
            // 
            // 备注
            // 
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 145;
            // 
            // GasQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.费用状态ComboBox);
            this.Controls.Add(this.小区名称ComboBox);
            this.Controls.Add(this.水电气费DataGridView);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.费用状态Label);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(this.业主姓名Label);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.楼栋名称Label);
            this.Controls.Add(this.查询Button);
            this.Controls.Add(this.费用类型Label);
            this.Controls.Add(this.计费月份ComboBox);
            this.Controls.Add(this.计费月份Label);
            this.Controls.Add(this.计费年份ComboBox);
            this.Controls.Add(this.计费年份Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GasQueryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "费用管理[物业费用查询]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label 费用类型Label;
        private DevComponents.DotNetBar.ButtonX 查询Button;
        private System.Windows.Forms.Label 费用状态Label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 业主姓名ComboBox;
        private System.Windows.Forms.Label 业主姓名Label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 楼栋名称ComboBox;
        private System.Windows.Forms.Label 楼栋名称Label;
        private DevComponents.DotNetBar.ButtonX 打印Button;
        private DevComponents.DotNetBar.Controls.DataGridViewX 水电气费DataGridView;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 小区名称ComboBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 费用状态ComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 计费年月;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物业费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 应收费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实收费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预收费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}