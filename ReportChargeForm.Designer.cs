namespace MyCommunity
{
    partial class ReportChargeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportChargeForm));
            this.收款事由TextBox = new System.Windows.Forms.TextBox();
            this.开始日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.结束日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.收入统计报表DataGridView = new System.Windows.Forms.DataGridView();
            this.打印Button = new System.Windows.Forms.Button();
            this.收款事由Label = new System.Windows.Forms.Label();
            this.开始日期Label = new System.Windows.Forms.Label();
            this.查询Button = new System.Windows.Forms.Button();
            this.结束日期Label = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.收入统计报表DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 收款事由TextBox
            // 
            this.收款事由TextBox.Location = new System.Drawing.Point(74, 38);
            this.收款事由TextBox.Name = "收款事由TextBox";
            this.收款事由TextBox.Size = new System.Drawing.Size(458, 20);
            this.收款事由TextBox.TabIndex = 94;
            // 
            // 开始日期TextBox
            // 
            this.开始日期DateTimePicker.Location = new System.Drawing.Point(71, 9);
            this.开始日期DateTimePicker.Name = "开始日期TextBox";
            this.开始日期DateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.开始日期DateTimePicker.TabIndex = 93;
            // 
            // 结束日期TextBox
            // 
            this.结束日期DateTimePicker.Location = new System.Drawing.Point(243, 9);
            this.结束日期DateTimePicker.Name = "结束日期TextBox";
            this.结束日期DateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.结束日期DateTimePicker.TabIndex = 92;
            // 
            // 收入统计报表DataGridView
            // 
            this.收入统计报表DataGridView.AllowUserToAddRows = false;
            this.收入统计报表DataGridView.AllowUserToDeleteRows = false;
            this.收入统计报表DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.收入统计报表DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.收入统计报表DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.收入统计报表DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.收入统计报表DataGridView.Location = new System.Drawing.Point(9, 67);
            this.收入统计报表DataGridView.MultiSelect = false;
            this.收入统计报表DataGridView.Name = "收入统计报表DataGridView";
            this.收入统计报表DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.收入统计报表DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.收入统计报表DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.收入统计报表DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.收入统计报表DataGridView.RowTemplate.Height = 23;
            this.收入统计报表DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.收入统计报表DataGridView.Size = new System.Drawing.Size(523, 374);
            this.收入统计报表DataGridView.TabIndex = 91;
            // 
            // 打印Button
            // 
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(449, 7);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(80, 25);
            this.打印Button.TabIndex = 90;
            this.打印Button.Text = "打印";
            this.打印Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.打印Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.打印Button.UseVisualStyleBackColor = true;
            this.打印Button.Click += new System.EventHandler(this.打印Button_Click);
            // 
            // 收款事由Label
            // 
            this.收款事由Label.AutoSize = true;
            this.收款事由Label.Location = new System.Drawing.Point(8, 43);
            this.收款事由Label.Name = "收款事由Label";
            this.收款事由Label.Size = new System.Drawing.Size(67, 13);
            this.收款事由Label.TabIndex = 89;
            this.收款事由Label.Text = "收款事由：";
            // 
            // 开始日期Label
            // 
            this.开始日期Label.AutoSize = true;
            this.开始日期Label.Location = new System.Drawing.Point(7, 15);
            this.开始日期Label.Name = "开始日期Label";
            this.开始日期Label.Size = new System.Drawing.Size(67, 13);
            this.开始日期Label.TabIndex = 88;
            this.开始日期Label.Text = "开始日期：";
            // 
            // 查询Button
            // 
            this.查询Button.Image = ((System.Drawing.Image)(resources.GetObject("查询Button.Image")));
            this.查询Button.Location = new System.Drawing.Point(363, 7);
            this.查询Button.Name = "查询Button";
            this.查询Button.Size = new System.Drawing.Size(80, 25);
            this.查询Button.TabIndex = 87;
            this.查询Button.Text = "查询";
            this.查询Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.查询Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.查询Button.UseVisualStyleBackColor = true;
            this.查询Button.Click += new System.EventHandler(this.查询Button_Click);
            // 
            // 结束日期Label
            // 
            this.结束日期Label.AutoSize = true;
            this.结束日期Label.Location = new System.Drawing.Point(180, 15);
            this.结束日期Label.Name = "结束日期Label";
            this.结束日期Label.Size = new System.Drawing.Size(67, 13);
            this.结束日期Label.TabIndex = 86;
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
            // ReportChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.收款事由TextBox);
            this.Controls.Add(this.开始日期DateTimePicker);
            this.Controls.Add(this.结束日期DateTimePicker);
            this.Controls.Add(this.收入统计报表DataGridView);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.收款事由Label);
            this.Controls.Add(this.开始日期Label);
            this.Controls.Add(this.查询Button);
            this.Controls.Add(this.结束日期Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportChargeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报表管理[收入统计报表]";
            ((System.ComponentModel.ISupportInitialize)(this.收入统计报表DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 收款事由TextBox;
        private System.Windows.Forms.DateTimePicker 开始日期DateTimePicker;
        private System.Windows.Forms.DateTimePicker 结束日期DateTimePicker;
        private System.Windows.Forms.DataGridView 收入统计报表DataGridView;
        private System.Windows.Forms.Button 打印Button;
        private System.Windows.Forms.Label 收款事由Label;
        private System.Windows.Forms.Label 开始日期Label;
        private System.Windows.Forms.Button 查询Button;
        private System.Windows.Forms.Label 结束日期Label;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}