namespace MyCommunity
{
    partial class GasPaymentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasPaymentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.收据编号Label = new System.Windows.Forms.Label();
            this.收据编号TextBox = new System.Windows.Forms.TextBox();
            this.收款日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.收款日期Label = new System.Windows.Forms.Label();
            this.交款人员TextBox = new System.Windows.Forms.TextBox();
            this.交款人员Label = new System.Windows.Forms.Label();
            this.收款金额TextBox = new System.Windows.Forms.TextBox();
            this.收款金额Label = new System.Windows.Forms.Label();
            this.收款形式TextBox = new System.Windows.Forms.TextBox();
            this.收款形式Label = new System.Windows.Forms.Label();
            this.收款人员TextBox = new System.Windows.Forms.TextBox();
            this.收款人员Label = new System.Windows.Forms.Label();
            this.收款事由TextBox = new System.Windows.Forms.TextBox();
            this.收款事由Label = new System.Windows.Forms.Label();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.补充说明Label = new System.Windows.Forms.Label();
            this.打印Button = new System.Windows.Forms.Button();
            this.新增Button = new System.Windows.Forms.Button();
            this.保存Button = new System.Windows.Forms.Button();
            this.楼栋名称Label = new System.Windows.Forms.Label();
            this.楼栋名称ComboBox = new System.Windows.Forms.ComboBox();
            this.楼栋信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.业主姓名Label = new System.Windows.Forms.Label();
            this.业主姓名ComboBox = new System.Windows.Forms.ComboBox();
            this.查询Button = new System.Windows.Forms.Button();
            this.未交DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.明细DataGridView = new System.Windows.Forms.DataGridView();
            this.添加Button = new System.Windows.Forms.Button();
            this.移除Button = new System.Windows.Forms.Button();
            this.楼栋信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter();
            this.业主信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.业主信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.业主信息TableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.未交DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.明细DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 收据编号Label
            // 
            this.收据编号Label.AutoSize = true;
            this.收据编号Label.Location = new System.Drawing.Point(9, 16);
            this.收据编号Label.Name = "收据编号Label";
            this.收据编号Label.Size = new System.Drawing.Size(67, 13);
            this.收据编号Label.TabIndex = 0;
            this.收据编号Label.Text = "收据编号：";
            // 
            // 收据编号TextBox
            // 
            this.收据编号TextBox.Enabled = false;
            this.收据编号TextBox.Location = new System.Drawing.Point(76, 11);
            this.收据编号TextBox.Name = "收据编号TextBox";
            this.收据编号TextBox.Size = new System.Drawing.Size(169, 20);
            this.收据编号TextBox.TabIndex = 1;
            // 
            // 收款日期DateTimePicker
            // 
            this.收款日期DateTimePicker.Location = new System.Drawing.Point(323, 11);
            this.收款日期DateTimePicker.Name = "收款日期DateTimePicker";
            this.收款日期DateTimePicker.Size = new System.Drawing.Size(87, 20);
            this.收款日期DateTimePicker.TabIndex = 3;
            // 
            // 收款日期Label
            // 
            this.收款日期Label.AutoSize = true;
            this.收款日期Label.Location = new System.Drawing.Point(255, 15);
            this.收款日期Label.Name = "收款日期Label";
            this.收款日期Label.Size = new System.Drawing.Size(67, 13);
            this.收款日期Label.TabIndex = 2;
            this.收款日期Label.Text = "收款日期：";
            // 
            // 交款人员TextBox
            // 
            this.交款人员TextBox.Location = new System.Drawing.Point(482, 11);
            this.交款人员TextBox.Name = "交款人员TextBox";
            this.交款人员TextBox.Size = new System.Drawing.Size(51, 20);
            this.交款人员TextBox.TabIndex = 5;
            // 
            // 交款人员Label
            // 
            this.交款人员Label.AutoSize = true;
            this.交款人员Label.Location = new System.Drawing.Point(416, 15);
            this.交款人员Label.Name = "交款人员Label";
            this.交款人员Label.Size = new System.Drawing.Size(67, 13);
            this.交款人员Label.TabIndex = 4;
            this.交款人员Label.Text = "交款人员：";
            // 
            // 收款金额TextBox
            // 
            this.收款金额TextBox.Location = new System.Drawing.Point(76, 37);
            this.收款金额TextBox.Name = "收款金额TextBox";
            this.收款金额TextBox.ReadOnly = true;
            this.收款金额TextBox.Size = new System.Drawing.Size(57, 20);
            this.收款金额TextBox.TabIndex = 7;
            // 
            // 收款金额Label
            // 
            this.收款金额Label.AutoSize = true;
            this.收款金额Label.Location = new System.Drawing.Point(9, 43);
            this.收款金额Label.Name = "收款金额Label";
            this.收款金额Label.Size = new System.Drawing.Size(67, 13);
            this.收款金额Label.TabIndex = 6;
            this.收款金额Label.Text = "收款金额：";
            // 
            // 收款形式TextBox
            // 
            this.收款形式TextBox.Location = new System.Drawing.Point(205, 37);
            this.收款形式TextBox.Name = "收款形式TextBox";
            this.收款形式TextBox.Size = new System.Drawing.Size(57, 20);
            this.收款形式TextBox.TabIndex = 9;
            this.收款形式TextBox.Text = "现金";
            // 
            // 收款形式Label
            // 
            this.收款形式Label.AutoSize = true;
            this.收款形式Label.Location = new System.Drawing.Point(138, 42);
            this.收款形式Label.Name = "收款形式Label";
            this.收款形式Label.Size = new System.Drawing.Size(67, 13);
            this.收款形式Label.TabIndex = 8;
            this.收款形式Label.Text = "收款形式：";
            // 
            // 收款人员TextBox
            // 
            this.收款人员TextBox.Location = new System.Drawing.Point(332, 37);
            this.收款人员TextBox.Name = "收款人员TextBox";
            this.收款人员TextBox.Size = new System.Drawing.Size(57, 20);
            this.收款人员TextBox.TabIndex = 11;
            // 
            // 收款人员Label
            // 
            this.收款人员Label.AutoSize = true;
            this.收款人员Label.Location = new System.Drawing.Point(268, 43);
            this.收款人员Label.Name = "收款人员Label";
            this.收款人员Label.Size = new System.Drawing.Size(67, 13);
            this.收款人员Label.TabIndex = 10;
            this.收款人员Label.Text = "收款人员：";
            // 
            // 收款事由TextBox
            // 
            this.收款事由TextBox.Location = new System.Drawing.Point(460, 37);
            this.收款事由TextBox.Name = "收款事由TextBox";
            this.收款事由TextBox.Size = new System.Drawing.Size(73, 20);
            this.收款事由TextBox.TabIndex = 13;
            this.收款事由TextBox.Text = "交水电气费";
            // 
            // 收款事由Label
            // 
            this.收款事由Label.AutoSize = true;
            this.收款事由Label.Location = new System.Drawing.Point(393, 43);
            this.收款事由Label.Name = "收款事由Label";
            this.收款事由Label.Size = new System.Drawing.Size(67, 13);
            this.收款事由Label.TabIndex = 12;
            this.收款事由Label.Text = "收款事由：";
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Location = new System.Drawing.Point(76, 63);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(203, 20);
            this.补充说明TextBox.TabIndex = 15;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 补充说明Label
            // 
            this.补充说明Label.AutoSize = true;
            this.补充说明Label.Location = new System.Drawing.Point(9, 70);
            this.补充说明Label.Name = "补充说明Label";
            this.补充说明Label.Size = new System.Drawing.Size(67, 13);
            this.补充说明Label.TabIndex = 14;
            this.补充说明Label.Text = "补充说明：";
            // 
            // 打印Button
            // 
            this.打印Button.Image = ((System.Drawing.Image)(resources.GetObject("打印Button.Image")));
            this.打印Button.Location = new System.Drawing.Point(369, 62);
            this.打印Button.Name = "打印Button";
            this.打印Button.Size = new System.Drawing.Size(80, 25);
            this.打印Button.TabIndex = 35;
            this.打印Button.Text = "打印";
            this.打印Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.打印Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.打印Button.UseVisualStyleBackColor = true;
            this.打印Button.Click += new System.EventHandler(this.打印Button_Click);
            // 
            // 新增Button
            // 
            this.新增Button.Image = ((System.Drawing.Image)(resources.GetObject("新增Button.Image")));
            this.新增Button.Location = new System.Drawing.Point(285, 62);
            this.新增Button.Name = "新增Button";
            this.新增Button.Size = new System.Drawing.Size(80, 25);
            this.新增Button.TabIndex = 34;
            this.新增Button.Text = "新增";
            this.新增Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.新增Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.新增Button.UseVisualStyleBackColor = true;
            this.新增Button.Click += new System.EventHandler(this.新增Button_Click);
            // 
            // 保存Button
            // 
            this.保存Button.Image = ((System.Drawing.Image)(resources.GetObject("保存Button.Image")));
            this.保存Button.Location = new System.Drawing.Point(453, 62);
            this.保存Button.Name = "保存Button";
            this.保存Button.Size = new System.Drawing.Size(80, 25);
            this.保存Button.TabIndex = 36;
            this.保存Button.Text = "保存";
            this.保存Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.保存Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.保存Button.UseVisualStyleBackColor = true;
            this.保存Button.Click += new System.EventHandler(this.保存Button_Click);
            // 
            // 楼栋名称Label
            // 
            this.楼栋名称Label.AutoSize = true;
            this.楼栋名称Label.Location = new System.Drawing.Point(8, 94);
            this.楼栋名称Label.Name = "楼栋名称Label";
            this.楼栋名称Label.Size = new System.Drawing.Size(199, 13);
            this.楼栋名称Label.TabIndex = 37;
            this.楼栋名称Label.Text = "请选择未交费业主所在的楼栋名称：";
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(205, 90);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(95, 21);
            this.楼栋名称ComboBox.TabIndex = 38;
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 楼栋信息BindingSource
            // 
            this.楼栋信息BindingSource.DataMember = "楼栋信息";
            this.楼栋信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 业主姓名Label
            // 
            this.业主姓名Label.AutoSize = true;
            this.业主姓名Label.Location = new System.Drawing.Point(306, 94);
            this.业主姓名Label.Name = "业主姓名Label";
            this.业主姓名Label.Size = new System.Drawing.Size(67, 13);
            this.业主姓名Label.TabIndex = 39;
            this.业主姓名Label.Text = "业主姓名：";
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(370, 90);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(79, 21);
            this.业主姓名ComboBox.TabIndex = 40;
            // 
            // 查询Button
            // 
            this.查询Button.Image = ((System.Drawing.Image)(resources.GetObject("查询Button.Image")));
            this.查询Button.Location = new System.Drawing.Point(453, 88);
            this.查询Button.Name = "查询Button";
            this.查询Button.Size = new System.Drawing.Size(80, 25);
            this.查询Button.TabIndex = 41;
            this.查询Button.Text = "查询";
            this.查询Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.查询Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.查询Button.UseVisualStyleBackColor = true;
            this.查询Button.Click += new System.EventHandler(this.查询Button_Click);
            // 
            // 未交DataGridView
            // 
            this.未交DataGridView.AllowUserToAddRows = false;
            this.未交DataGridView.AllowUserToDeleteRows = false;
            this.未交DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.未交DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.未交DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.未交DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.未交DataGridView.Location = new System.Drawing.Point(8, 117);
            this.未交DataGridView.MultiSelect = false;
            this.未交DataGridView.Name = "未交DataGridView";
            this.未交DataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.未交DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.未交DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Green;
            this.未交DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.未交DataGridView.RowTemplate.Height = 23;
            this.未交DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.未交DataGridView.Size = new System.Drawing.Size(523, 151);
            this.未交DataGridView.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "未交费业主即将交纳的水电气费明细：";
            // 
            // 明细DataGridView
            // 
            this.明细DataGridView.AllowUserToAddRows = false;
            this.明细DataGridView.AllowUserToDeleteRows = false;
            this.明细DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.明细DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.明细DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.明细DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.明细DataGridView.Location = new System.Drawing.Point(8, 304);
            this.明细DataGridView.MultiSelect = false;
            this.明细DataGridView.Name = "明细DataGridView";
            this.明细DataGridView.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.明细DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.明细DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Green;
            this.明细DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.明细DataGridView.RowTemplate.Height = 23;
            this.明细DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.明细DataGridView.Size = new System.Drawing.Size(523, 137);
            this.明细DataGridView.TabIndex = 44;
            // 
            // 添加Button
            // 
            this.添加Button.Image = ((System.Drawing.Image)(resources.GetObject("添加Button.Image")));
            this.添加Button.Location = new System.Drawing.Point(365, 273);
            this.添加Button.Name = "添加Button";
            this.添加Button.Size = new System.Drawing.Size(80, 25);
            this.添加Button.TabIndex = 45;
            this.添加Button.Text = "添加";
            this.添加Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.添加Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.添加Button.UseVisualStyleBackColor = true;
            this.添加Button.Click += new System.EventHandler(this.添加Button_Click);
            // 
            // 移除Button
            // 
            this.移除Button.Image = ((System.Drawing.Image)(resources.GetObject("移除Button.Image")));
            this.移除Button.Location = new System.Drawing.Point(451, 273);
            this.移除Button.Name = "移除Button";
            this.移除Button.Size = new System.Drawing.Size(80, 25);
            this.移除Button.TabIndex = 46;
            this.移除Button.Text = "移除";
            this.移除Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.移除Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.移除Button.UseVisualStyleBackColor = true;
            this.移除Button.Click += new System.EventHandler(this.移除Button_Click);
            // 
            // 楼栋信息TableAdapter
            // 
            this.楼栋信息TableAdapter.ClearBeforeFill = true;
            // 
            // 业主信息BindingSource
            // 
            this.业主信息BindingSource.DataMember = "业主信息";
            this.业主信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 业主信息TableAdapter
            // 
            this.业主信息TableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // GasPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.移除Button);
            this.Controls.Add(this.添加Button);
            this.Controls.Add(this.明细DataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.未交DataGridView);
            this.Controls.Add(this.查询Button);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(this.业主姓名Label);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.楼栋名称Label);
            this.Controls.Add(this.保存Button);
            this.Controls.Add(this.打印Button);
            this.Controls.Add(this.新增Button);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.补充说明Label);
            this.Controls.Add(this.收款事由TextBox);
            this.Controls.Add(this.收款事由Label);
            this.Controls.Add(this.收款人员TextBox);
            this.Controls.Add(this.收款人员Label);
            this.Controls.Add(this.收款形式TextBox);
            this.Controls.Add(this.收款形式Label);
            this.Controls.Add(this.收款金额TextBox);
            this.Controls.Add(this.收款金额Label);
            this.Controls.Add(this.交款人员TextBox);
            this.Controls.Add(this.交款人员Label);
            this.Controls.Add(this.收款日期DateTimePicker);
            this.Controls.Add(this.收款日期Label);
            this.Controls.Add(this.收据编号TextBox);
            this.Controls.Add(this.收据编号Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GasPaymentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "费用管理[水电气费交纳]";
            this.Load += new System.EventHandler(this.GasPaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.未交DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.明细DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 收据编号Label;
        private System.Windows.Forms.TextBox 收据编号TextBox;
        private System.Windows.Forms.DateTimePicker 收款日期DateTimePicker;
        private System.Windows.Forms.Label 收款日期Label;
        private System.Windows.Forms.TextBox 交款人员TextBox;
        private System.Windows.Forms.Label 交款人员Label;
        private System.Windows.Forms.TextBox 收款金额TextBox;
        private System.Windows.Forms.Label 收款金额Label;
        private System.Windows.Forms.TextBox 收款形式TextBox;
        private System.Windows.Forms.Label 收款形式Label;
        private System.Windows.Forms.TextBox 收款人员TextBox;
        private System.Windows.Forms.Label 收款人员Label;
        private System.Windows.Forms.TextBox 收款事由TextBox;
        private System.Windows.Forms.Label 收款事由Label;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.Label 补充说明Label;
        private System.Windows.Forms.Button 打印Button;
        private System.Windows.Forms.Button 新增Button;
        private System.Windows.Forms.Button 保存Button;
        private System.Windows.Forms.Label 楼栋名称Label;
        private System.Windows.Forms.ComboBox 楼栋名称ComboBox;
        private System.Windows.Forms.Label 业主姓名Label;
        private System.Windows.Forms.ComboBox 业主姓名ComboBox;
        private System.Windows.Forms.Button 查询Button;
        private System.Windows.Forms.DataGridView 未交DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView 明细DataGridView;
        private System.Windows.Forms.Button 添加Button;
        private System.Windows.Forms.Button 移除Button;
        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 楼栋信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter 楼栋信息TableAdapter;
        private System.Windows.Forms.BindingSource 业主信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.业主信息TableAdapter 业主信息TableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}