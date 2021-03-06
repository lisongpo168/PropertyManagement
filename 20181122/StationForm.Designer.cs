﻿namespace MyCommunity
{
    partial class StationForm
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
            System.Windows.Forms.Label 自动编号Label;
            System.Windows.Forms.Label 车位编号Label;
            System.Windows.Forms.Label 车位面积Label;
            System.Windows.Forms.Label 楼栋名称Label;
            System.Windows.Forms.Label 业主编号Label;
            System.Windows.Forms.Label 业主姓名Label;
            System.Windows.Forms.Label 启用日期Label;
            System.Windows.Forms.Label 停用日期Label;
            System.Windows.Forms.Label 费用金额Label;
            System.Windows.Forms.Label 管理人员Label;
            System.Windows.Forms.Label 补充说明Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.车位使用BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.车位编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.车位编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.车位使用BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.自动编号TextBox = new System.Windows.Forms.TextBox();
            this.车位编号TextBox = new System.Windows.Forms.TextBox();
            this.车位面积TextBox = new System.Windows.Forms.TextBox();
            this.楼栋名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.业主编号TextBox = new System.Windows.Forms.TextBox();
            this.业主姓名ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.启用日期DateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.停用日期DateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.费用金额TextBox = new System.Windows.Forms.TextBox();
            this.管理人员TextBox = new System.Windows.Forms.TextBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.车位使用DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            自动编号Label = new System.Windows.Forms.Label();
            车位编号Label = new System.Windows.Forms.Label();
            车位面积Label = new System.Windows.Forms.Label();
            楼栋名称Label = new System.Windows.Forms.Label();
            业主编号Label = new System.Windows.Forms.Label();
            业主姓名Label = new System.Windows.Forms.Label();
            启用日期Label = new System.Windows.Forms.Label();
            停用日期Label = new System.Windows.Forms.Label();
            费用金额Label = new System.Windows.Forms.Label();
            管理人员Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.车位使用BindingNavigator)).BeginInit();
            this.车位使用BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.启用日期DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.停用日期DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.车位使用DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 自动编号Label
            // 
            自动编号Label.AutoSize = true;
            自动编号Label.Location = new System.Drawing.Point(6, 35);
            自动编号Label.Name = "自动编号Label";
            自动编号Label.Size = new System.Drawing.Size(58, 13);
            自动编号Label.TabIndex = 2;
            自动编号Label.Text = "自动编号:";
            // 
            // 车位编号Label
            // 
            车位编号Label.AutoSize = true;
            车位编号Label.Location = new System.Drawing.Point(110, 35);
            车位编号Label.Name = "车位编号Label";
            车位编号Label.Size = new System.Drawing.Size(58, 13);
            车位编号Label.TabIndex = 4;
            车位编号Label.Text = "车位编号:";
            // 
            // 车位面积Label
            // 
            车位面积Label.AutoSize = true;
            车位面积Label.Location = new System.Drawing.Point(242, 35);
            车位面积Label.Name = "车位面积Label";
            车位面积Label.Size = new System.Drawing.Size(78, 13);
            车位面积Label.TabIndex = 6;
            车位面积Label.Text = "车位面积(m2):";
            // 
            // 楼栋名称Label
            // 
            楼栋名称Label.AutoSize = true;
            楼栋名称Label.Location = new System.Drawing.Point(365, 35);
            楼栋名称Label.Name = "楼栋名称Label";
            楼栋名称Label.Size = new System.Drawing.Size(58, 13);
            楼栋名称Label.TabIndex = 8;
            楼栋名称Label.Text = "楼栋名称:";
            // 
            // 业主编号Label
            // 
            业主编号Label.AutoSize = true;
            业主编号Label.Location = new System.Drawing.Point(7, 61);
            业主编号Label.Name = "业主编号Label";
            业主编号Label.Size = new System.Drawing.Size(58, 13);
            业主编号Label.TabIndex = 10;
            业主编号Label.Text = "业主编号:";
            // 
            // 业主姓名Label
            // 
            业主姓名Label.AutoSize = true;
            业主姓名Label.Location = new System.Drawing.Point(177, 61);
            业主姓名Label.Name = "业主姓名Label";
            业主姓名Label.Size = new System.Drawing.Size(58, 13);
            业主姓名Label.TabIndex = 12;
            业主姓名Label.Text = "业主姓名:";
            // 
            // 启用日期Label
            // 
            启用日期Label.AutoSize = true;
            启用日期Label.Location = new System.Drawing.Point(333, 61);
            启用日期Label.Name = "启用日期Label";
            启用日期Label.Size = new System.Drawing.Size(58, 13);
            启用日期Label.TabIndex = 14;
            启用日期Label.Text = "启用日期:";
            // 
            // 停用日期Label
            // 
            停用日期Label.AutoSize = true;
            停用日期Label.Location = new System.Drawing.Point(6, 88);
            停用日期Label.Name = "停用日期Label";
            停用日期Label.Size = new System.Drawing.Size(58, 13);
            停用日期Label.TabIndex = 16;
            停用日期Label.Text = "停用日期:";
            // 
            // 费用金额Label
            // 
            费用金额Label.AutoSize = true;
            费用金额Label.Location = new System.Drawing.Point(215, 88);
            费用金额Label.Name = "费用金额Label";
            费用金额Label.Size = new System.Drawing.Size(93, 13);
            费用金额Label.TabIndex = 18;
            费用金额Label.Text = "费用金额(元/月):";
            // 
            // 管理人员Label
            // 
            管理人员Label.AutoSize = true;
            管理人员Label.Location = new System.Drawing.Point(383, 88);
            管理人员Label.Name = "管理人员Label";
            管理人员Label.Size = new System.Drawing.Size(58, 13);
            管理人员Label.TabIndex = 20;
            管理人员Label.Text = "管理人员:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(5, 114);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(58, 13);
            补充说明Label.TabIndex = 22;
            补充说明Label.Text = "补充说明:";
            // 
            // 车位使用BindingNavigator
            // 
            this.车位使用BindingNavigator.AddNewItem = null;
            this.车位使用BindingNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("车位使用BindingNavigator.BackgroundImage")));
            this.车位使用BindingNavigator.CountItem = null;
            this.车位使用BindingNavigator.DeleteItem = null;
            this.车位使用BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车位编号ToolStripLabel,
            this.车位编号ToolStripTextBox,
            this.查询ToolStripButton,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.车位使用BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.车位使用BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.车位使用BindingNavigator.MoveFirstItem = null;
            this.车位使用BindingNavigator.MoveLastItem = null;
            this.车位使用BindingNavigator.MoveNextItem = null;
            this.车位使用BindingNavigator.MovePreviousItem = null;
            this.车位使用BindingNavigator.Name = "车位使用BindingNavigator";
            this.车位使用BindingNavigator.PositionItem = null;
            this.车位使用BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.车位使用BindingNavigator.TabIndex = 0;
            this.车位使用BindingNavigator.Text = "bindingNavigator1";
            // 
            // 车位编号ToolStripLabel
            // 
            this.车位编号ToolStripLabel.Name = "车位编号ToolStripLabel";
            this.车位编号ToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.车位编号ToolStripLabel.Text = "车位编号:";
            // 
            // 车位编号ToolStripTextBox
            // 
            this.车位编号ToolStripTextBox.Name = "车位编号ToolStripTextBox";
            this.车位编号ToolStripTextBox.Size = new System.Drawing.Size(50, 25);
            // 
            // 查询ToolStripButton
            // 
            this.查询ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("查询ToolStripButton.Image")));
            this.查询ToolStripButton.Name = "查询ToolStripButton";
            this.查询ToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.查询ToolStripButton.Text = "查询";
            this.查询ToolStripButton.Click += new System.EventHandler(this.查询ToolStripButton_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorAddNewItem.Text = "新增";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // 车位使用BindingNavigatorSaveItem
            // 
            this.车位使用BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("车位使用BindingNavigatorSaveItem.Image")));
            this.车位使用BindingNavigatorSaveItem.Name = "车位使用BindingNavigatorSaveItem";
            this.车位使用BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.车位使用BindingNavigatorSaveItem.Text = "保存";
            this.车位使用BindingNavigatorSaveItem.Click += new System.EventHandler(this.车位使用BindingNavigatorSaveItem_Click);
            // 
            // 打印ToolStripButton
            // 
            this.打印ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打印ToolStripButton.Image")));
            this.打印ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印ToolStripButton.Name = "打印ToolStripButton";
            this.打印ToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.打印ToolStripButton.Text = "打印";
            this.打印ToolStripButton.Click += new System.EventHandler(this.打印ToolStripButton_Click);
            // 
            // 自动编号TextBox
            // 
            this.自动编号TextBox.Location = new System.Drawing.Point(66, 30);
            this.自动编号TextBox.Name = "自动编号TextBox";
            this.自动编号TextBox.ReadOnly = true;
            this.自动编号TextBox.Size = new System.Drawing.Size(41, 20);
            this.自动编号TextBox.TabIndex = 3;
            // 
            // 车位编号TextBox
            // 
            this.车位编号TextBox.Location = new System.Drawing.Point(173, 30);
            this.车位编号TextBox.Name = "车位编号TextBox";
            this.车位编号TextBox.Size = new System.Drawing.Size(62, 20);
            this.车位编号TextBox.TabIndex = 5;
            // 
            // 车位面积TextBox
            // 
            this.车位面积TextBox.Location = new System.Drawing.Point(323, 30);
            this.车位面积TextBox.Name = "车位面积TextBox";
            this.车位面积TextBox.Size = new System.Drawing.Size(35, 20);
            this.车位面积TextBox.TabIndex = 7;
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(430, 30);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(105, 21);
            this.楼栋名称ComboBox.TabIndex = 9;
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 业主编号TextBox
            // 
            this.业主编号TextBox.Location = new System.Drawing.Point(66, 56);
            this.业主编号TextBox.Name = "业主编号TextBox";
            this.业主编号TextBox.ReadOnly = true;
            this.业主编号TextBox.Size = new System.Drawing.Size(105, 20);
            this.业主编号TextBox.TabIndex = 11;
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.DisplayMember = "业主编号";
            this.业主姓名ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(242, 57);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(85, 21);
            this.业主姓名ComboBox.TabIndex = 13;
            this.业主姓名ComboBox.ValueMember = "业主编号";
            this.业主姓名ComboBox.SelectedIndexChanged += new System.EventHandler(this.业主姓名ComboBox_SelectedIndexChanged);
            // 
            // 启用日期DateTimePicker
            // 
            // 
            // 
            // 
            this.启用日期DateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.启用日期DateTimePicker.ButtonDropDown.Visible = true;
            this.启用日期DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.启用日期DateTimePicker.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.启用日期DateTimePicker.IsPopupCalendarOpen = false;
            this.启用日期DateTimePicker.Location = new System.Drawing.Point(398, 56);
            // 
            // 
            // 
            // 
            // 
            // 
            this.启用日期DateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.启用日期DateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.启用日期DateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.启用日期DateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.启用日期DateTimePicker.Name = "启用日期DateTimePicker";
            this.启用日期DateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.启用日期DateTimePicker.TabIndex = 15;
            this.启用日期DateTimePicker.Value = new System.DateTime(2018, 11, 19, 22, 50, 52, 0);
            // 
            // 停用日期DateTimePicker
            // 
            // 
            // 
            // 
            this.停用日期DateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.停用日期DateTimePicker.ButtonDropDown.Visible = true;
            this.停用日期DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.停用日期DateTimePicker.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.停用日期DateTimePicker.IsPopupCalendarOpen = false;
            this.停用日期DateTimePicker.Location = new System.Drawing.Point(67, 83);
            // 
            // 
            // 
            // 
            // 
            // 
            this.停用日期DateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.停用日期DateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.停用日期DateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.停用日期DateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.停用日期DateTimePicker.Name = "停用日期DateTimePicker";
            this.停用日期DateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.停用日期DateTimePicker.TabIndex = 17;
            this.停用日期DateTimePicker.Value = new System.DateTime(2018, 11, 19, 22, 50, 18, 0);
            // 
            // 费用金额TextBox
            // 
            this.费用金额TextBox.Location = new System.Drawing.Point(320, 83);
            this.费用金额TextBox.Name = "费用金额TextBox";
            this.费用金额TextBox.Size = new System.Drawing.Size(57, 20);
            this.费用金额TextBox.TabIndex = 19;
            // 
            // 管理人员TextBox
            // 
            this.管理人员TextBox.Location = new System.Drawing.Point(448, 83);
            this.管理人员TextBox.Name = "管理人员TextBox";
            this.管理人员TextBox.Size = new System.Drawing.Size(86, 20);
            this.管理人员TextBox.TabIndex = 21;
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Location = new System.Drawing.Point(67, 111);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(467, 20);
            this.补充说明TextBox.TabIndex = 23;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 车位使用DataGridView
            // 
            this.车位使用DataGridView.AllowUserToAddRows = false;
            this.车位使用DataGridView.AllowUserToDeleteRows = false;
            this.车位使用DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.车位使用DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.车位使用DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.车位使用DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.车位使用DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.车位使用DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.车位使用DataGridView.Location = new System.Drawing.Point(9, 142);
            this.车位使用DataGridView.MultiSelect = false;
            this.车位使用DataGridView.Name = "车位使用DataGridView";
            this.车位使用DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.车位使用DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.车位使用DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.车位使用DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.车位使用DataGridView.RowTemplate.Height = 23;
            this.车位使用DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.车位使用DataGridView.Size = new System.Drawing.Size(523, 298);
            this.车位使用DataGridView.TabIndex = 34;
            this.车位使用DataGridView.SelectionChanged += new System.EventHandler(this.车位使用DataGridView_SelectionChanged);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // StationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.车位使用DataGridView);
            this.Controls.Add(自动编号Label);
            this.Controls.Add(this.自动编号TextBox);
            this.Controls.Add(车位编号Label);
            this.Controls.Add(this.车位编号TextBox);
            this.Controls.Add(车位面积Label);
            this.Controls.Add(this.车位面积TextBox);
            this.Controls.Add(楼栋名称Label);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(业主编号Label);
            this.Controls.Add(this.业主编号TextBox);
            this.Controls.Add(业主姓名Label);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(启用日期Label);
            this.Controls.Add(this.启用日期DateTimePicker);
            this.Controls.Add(停用日期Label);
            this.Controls.Add(this.停用日期DateTimePicker);
            this.Controls.Add(费用金额Label);
            this.Controls.Add(this.费用金额TextBox);
            this.Controls.Add(管理人员Label);
            this.Controls.Add(this.管理人员TextBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.车位使用BindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "物业管理[车位使用管理]";
            this.Load += new System.EventHandler(this.StationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.车位使用BindingNavigator)).EndInit();
            this.车位使用BindingNavigator.ResumeLayout(false);
            this.车位使用BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.启用日期DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.停用日期DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.车位使用DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator 车位使用BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton 车位使用BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 车位编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 车位编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
        private System.Windows.Forms.TextBox 自动编号TextBox;
        private System.Windows.Forms.TextBox 车位编号TextBox;
        private System.Windows.Forms.TextBox 车位面积TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 楼栋名称ComboBox;
        private System.Windows.Forms.TextBox 业主编号TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 业主姓名ComboBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput 启用日期DateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput 停用日期DateTimePicker;
        private System.Windows.Forms.TextBox 费用金额TextBox;
        private System.Windows.Forms.TextBox 管理人员TextBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX 车位使用DataGridView;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}