namespace MyCommunity
{
    partial class ReportCommonRepairForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCommonRepairForm));
            this.故障现象TextBox = new System.Windows.Forms.TextBox();
            this.开始日期DateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.结束日期DateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.公共维修报表DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.打印Button = new DevComponents.DotNetBar.ButtonX();
            this.故障现象Label = new System.Windows.Forms.Label();
            this.开始日期Label = new System.Windows.Forms.Label();
            this.查询Button = new DevComponents.DotNetBar.ButtonX();
            this.结束日期Label = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.开始日期DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.结束日期DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共维修报表DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 故障现象TextBox
            // 
            this.故障现象TextBox.Location = new System.Drawing.Point(74, 36);
            this.故障现象TextBox.Name = "故障现象TextBox";
            this.故障现象TextBox.Size = new System.Drawing.Size(458, 21);
            this.故障现象TextBox.TabIndex = 85;
            // 
            // 开始日期DateTimePicker
            // 
            // 
            // 
            // 
            this.开始日期DateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.开始日期DateTimePicker.ButtonDropDown.Visible = true;
            this.开始日期DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.开始日期DateTimePicker.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.开始日期DateTimePicker.IsPopupCalendarOpen = false;
            this.开始日期DateTimePicker.Location = new System.Drawing.Point(71, 9);
            // 
            // 
            // 
            // 
            // 
            // 
            this.开始日期DateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.开始日期DateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.开始日期DateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.开始日期DateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.开始日期DateTimePicker.Name = "开始日期DateTimePicker";
            this.开始日期DateTimePicker.Size = new System.Drawing.Size(103, 21);
            this.开始日期DateTimePicker.TabIndex = 84;
            this.开始日期DateTimePicker.Value = new System.DateTime(2018, 11, 20, 23, 45, 0, 0);
            // 
            // 结束日期DateTimePicker
            // 
            // 
            // 
            // 
            this.结束日期DateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.结束日期DateTimePicker.ButtonDropDown.Visible = true;
            this.结束日期DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.结束日期DateTimePicker.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.结束日期DateTimePicker.IsPopupCalendarOpen = false;
            this.结束日期DateTimePicker.Location = new System.Drawing.Point(243, 9);
            // 
            // 
            // 
            // 
            // 
            // 
            this.结束日期DateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.结束日期DateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.结束日期DateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.结束日期DateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.结束日期DateTimePicker.Name = "结束日期DateTimePicker";
            this.结束日期DateTimePicker.Size = new System.Drawing.Size(114, 21);
            this.结束日期DateTimePicker.TabIndex = 83;
            this.结束日期DateTimePicker.Value = new System.DateTime(2018, 11, 20, 23, 45, 46, 0);
            // 
            // 公共维修报表DataGridView
            // 
            this.公共维修报表DataGridView.AllowUserToAddRows = false;
            this.公共维修报表DataGridView.AllowUserToDeleteRows = false;
            this.公共维修报表DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.公共维修报表DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.公共维修报表DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共维修报表DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.公共维修报表DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.公共维修报表DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.公共维修报表DataGridView.Location = new System.Drawing.Point(9, 63);
            this.公共维修报表DataGridView.MultiSelect = false;
            this.公共维修报表DataGridView.Name = "公共维修报表DataGridView";
            this.公共维修报表DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共维修报表DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.公共维修报表DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.公共维修报表DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.公共维修报表DataGridView.RowTemplate.Height = 23;
            this.公共维修报表DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.公共维修报表DataGridView.Size = new System.Drawing.Size(523, 345);
            this.公共维修报表DataGridView.TabIndex = 82;
            // 
            // 打印Button
            // 
            this.打印Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(449, 7);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(80, 23);
            this.打印Button.TabIndex = 81;
            this.打印Button.Text = "打印";
            this.打印Button.Click += new System.EventHandler(this.打印Button_Click);
            // 
            // 故障现象Label
            // 
            this.故障现象Label.AutoSize = true;
            this.故障现象Label.Location = new System.Drawing.Point(8, 41);
            this.故障现象Label.Name = "故障现象Label";
            this.故障现象Label.Size = new System.Drawing.Size(65, 12);
            this.故障现象Label.TabIndex = 80;
            this.故障现象Label.Text = "故障现象：";
            // 
            // 开始日期Label
            // 
            this.开始日期Label.AutoSize = true;
            this.开始日期Label.Location = new System.Drawing.Point(7, 15);
            this.开始日期Label.Name = "开始日期Label";
            this.开始日期Label.Size = new System.Drawing.Size(65, 12);
            this.开始日期Label.TabIndex = 79;
            this.开始日期Label.Text = "开始日期：";
            // 
            // 查询Button
            // 
            this.查询Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.查询Button.Image = ((System.Drawing.Image)(resources.GetObject("查询Button.Image")));
            this.查询Button.Location = new System.Drawing.Point(363, 7);
            this.查询Button.Name = "查询Button";
            this.查询Button.Size = new System.Drawing.Size(80, 23);
            this.查询Button.TabIndex = 78;
            this.查询Button.Text = "查询";
            this.查询Button.Click += new System.EventHandler(this.查询Button_Click);
            // 
            // 结束日期Label
            // 
            this.结束日期Label.AutoSize = true;
            this.结束日期Label.Location = new System.Drawing.Point(180, 15);
            this.结束日期Label.Name = "结束日期Label";
            this.结束日期Label.Size = new System.Drawing.Size(65, 12);
            this.结束日期Label.TabIndex = 77;
            this.结束日期Label.Text = "结束日期：";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // ReportCommonRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(542, 416);
            this.Controls.Add(this.故障现象TextBox);
            this.Controls.Add(this.开始日期DateTimePicker);
            this.Controls.Add(this.结束日期DateTimePicker);
            this.Controls.Add(this.公共维修报表DataGridView);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.故障现象Label);
            this.Controls.Add(this.开始日期Label);
            this.Controls.Add(this.查询Button);
            this.Controls.Add(this.结束日期Label);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportCommonRepairForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报表管理[公共维修报表]";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            ((System.ComponentModel.ISupportInitialize)(this.开始日期DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.结束日期DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共维修报表DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 故障现象TextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput 开始日期DateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput 结束日期DateTimePicker;
        private DevComponents.DotNetBar.Controls.DataGridViewX 公共维修报表DataGridView;
        private DevComponents.DotNetBar.ButtonX 打印Button;
        private System.Windows.Forms.Label 故障现象Label;
        private System.Windows.Forms.Label 开始日期Label;
        private DevComponents.DotNetBar.ButtonX 查询Button;
        private System.Windows.Forms.Label 结束日期Label;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}