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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.车位使用BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.车位使用TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.车位使用TableAdapter();
            this.车位使用BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.车位编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.车位编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.车位使用BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.自动编号TextBox = new System.Windows.Forms.TextBox();
            this.车位编号TextBox = new System.Windows.Forms.TextBox();
            this.车位面积TextBox = new System.Windows.Forms.TextBox();
            this.楼栋名称ComboBox = new System.Windows.Forms.ComboBox();
            this.楼栋信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.业主编号TextBox = new System.Windows.Forms.TextBox();
            this.业主姓名ComboBox = new System.Windows.Forms.ComboBox();
            this.业主信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.启用日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.停用日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.费用金额TextBox = new System.Windows.Forms.TextBox();
            this.管理人员TextBox = new System.Windows.Forms.TextBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.楼栋信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter();
            this.业主信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.业主信息TableAdapter();
            this.车位使用DataGridView = new System.Windows.Forms.DataGridView();
            this.自动编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车位编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车位面积DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼栋名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.启用日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.停用日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.费用金额DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.管理人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.补充说明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.车位使用BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.车位使用BindingNavigator)).BeginInit();
            this.车位使用BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingSource)).BeginInit();
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
            车位面积Label.Location = new System.Drawing.Point(263, 35);
            车位面积Label.Name = "车位面积Label";
            车位面积Label.Size = new System.Drawing.Size(78, 13);
            车位面积Label.TabIndex = 6;
            车位面积Label.Text = "车位面积(m2):";
            // 
            // 楼栋名称Label
            // 
            楼栋名称Label.AutoSize = true;
            楼栋名称Label.Location = new System.Drawing.Point(400, 35);
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
            费用金额Label.Size = new System.Drawing.Size(76, 13);
            费用金额Label.TabIndex = 18;
            费用金额Label.Text = "费用金额(元):";
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
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 车位使用BindingSource
            // 
            this.车位使用BindingSource.DataMember = "车位使用";
            this.车位使用BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 车位使用TableAdapter
            // 
            this.车位使用TableAdapter.ClearBeforeFill = true;
            // 
            // 车位使用BindingNavigator
            // 
            this.车位使用BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.车位使用BindingNavigator.BindingSource = this.车位使用BindingSource;
            this.车位使用BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.车位使用BindingNavigator.DeleteItem = null;
            this.车位使用BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车位编号ToolStripLabel,
            this.车位编号ToolStripTextBox,
            this.查询ToolStripButton,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.车位使用BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.车位使用BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.车位使用BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.车位使用BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.车位使用BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.车位使用BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.车位使用BindingNavigator.Name = "车位使用BindingNavigator";
            this.车位使用BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.车位使用BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.车位使用BindingNavigator.TabIndex = 0;
            this.车位使用BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorAddNewItem.Text = "新增";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(20, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.自动编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.车位使用BindingSource, "自动编号", true));
            this.自动编号TextBox.Location = new System.Drawing.Point(66, 30);
            this.自动编号TextBox.Name = "自动编号TextBox";
            this.自动编号TextBox.ReadOnly = true;
            this.自动编号TextBox.Size = new System.Drawing.Size(41, 20);
            this.自动编号TextBox.TabIndex = 3;
            // 
            // 车位编号TextBox
            // 
            this.车位编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.车位使用BindingSource, "车位编号", true));
            this.车位编号TextBox.Location = new System.Drawing.Point(173, 30);
            this.车位编号TextBox.Name = "车位编号TextBox";
            this.车位编号TextBox.Size = new System.Drawing.Size(88, 20);
            this.车位编号TextBox.TabIndex = 5;
            // 
            // 车位面积TextBox
            // 
            this.车位面积TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.车位使用BindingSource, "车位面积", true));
            this.车位面积TextBox.Location = new System.Drawing.Point(347, 30);
            this.车位面积TextBox.Name = "车位面积TextBox";
            this.车位面积TextBox.Size = new System.Drawing.Size(50, 20);
            this.车位面积TextBox.TabIndex = 7;
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.车位使用BindingSource, "楼栋名称", true));
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(460, 31);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(74, 21);
            this.楼栋名称ComboBox.TabIndex = 9;
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 楼栋信息BindingSource
            // 
            this.楼栋信息BindingSource.DataMember = "楼栋信息";
            this.楼栋信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 业主编号TextBox
            // 
            this.业主编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.车位使用BindingSource, "业主编号", true));
            this.业主编号TextBox.Location = new System.Drawing.Point(66, 56);
            this.业主编号TextBox.Name = "业主编号TextBox";
            this.业主编号TextBox.ReadOnly = true;
            this.业主编号TextBox.Size = new System.Drawing.Size(105, 20);
            this.业主编号TextBox.TabIndex = 11;
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.车位使用BindingSource, "业主姓名", true));
            this.业主姓名ComboBox.DataSource = this.业主信息BindingSource;
            this.业主姓名ComboBox.DisplayMember = "业主姓名";
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(242, 57);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(85, 21);
            this.业主姓名ComboBox.TabIndex = 13;
            this.业主姓名ComboBox.ValueMember = "业主编号";
            this.业主姓名ComboBox.SelectedIndexChanged += new System.EventHandler(this.业主姓名ComboBox_SelectedIndexChanged);
            // 
            // 业主信息BindingSource
            // 
            this.业主信息BindingSource.DataMember = "业主信息";
            this.业主信息BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 启用日期DateTimePicker
            // 
            this.启用日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.车位使用BindingSource, "启用日期", true));
            this.启用日期DateTimePicker.Location = new System.Drawing.Point(398, 56);
            this.启用日期DateTimePicker.Name = "启用日期DateTimePicker";
            this.启用日期DateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.启用日期DateTimePicker.TabIndex = 15;
            // 
            // 停用日期DateTimePicker
            // 
            this.停用日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.车位使用BindingSource, "停用日期", true));
            this.停用日期DateTimePicker.Location = new System.Drawing.Point(67, 83);
            this.停用日期DateTimePicker.Name = "停用日期DateTimePicker";
            this.停用日期DateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.停用日期DateTimePicker.TabIndex = 17;
            // 
            // 费用金额TextBox
            // 
            this.费用金额TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.车位使用BindingSource, "费用金额", true));
            this.费用金额TextBox.Location = new System.Drawing.Point(304, 83);
            this.费用金额TextBox.Name = "费用金额TextBox";
            this.费用金额TextBox.Size = new System.Drawing.Size(74, 20);
            this.费用金额TextBox.TabIndex = 19;
            // 
            // 管理人员TextBox
            // 
            this.管理人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.车位使用BindingSource, "管理人员", true));
            this.管理人员TextBox.Location = new System.Drawing.Point(448, 83);
            this.管理人员TextBox.Name = "管理人员TextBox";
            this.管理人员TextBox.Size = new System.Drawing.Size(86, 20);
            this.管理人员TextBox.TabIndex = 21;
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.车位使用BindingSource, "补充说明", true));
            this.补充说明TextBox.Location = new System.Drawing.Point(67, 111);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(467, 20);
            this.补充说明TextBox.TabIndex = 23;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 楼栋信息TableAdapter
            // 
            this.楼栋信息TableAdapter.ClearBeforeFill = true;
            // 
            // 业主信息TableAdapter
            // 
            this.业主信息TableAdapter.ClearBeforeFill = true;
            // 
            // 车位使用DataGridView
            // 
            this.车位使用DataGridView.AllowUserToAddRows = false;
            this.车位使用DataGridView.AllowUserToDeleteRows = false;
            this.车位使用DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.车位使用DataGridView.AutoGenerateColumns = false;
            this.车位使用DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.车位使用DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.车位使用DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.车位使用DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.自动编号DataGridViewTextBoxColumn,
            this.车位编号DataGridViewTextBoxColumn,
            this.车位面积DataGridViewTextBoxColumn,
            this.楼栋名称DataGridViewTextBoxColumn,
            this.业主编号DataGridViewTextBoxColumn,
            this.业主姓名DataGridViewTextBoxColumn,
            this.启用日期DataGridViewTextBoxColumn,
            this.停用日期DataGridViewTextBoxColumn,
            this.费用金额DataGridViewTextBoxColumn,
            this.管理人员DataGridViewTextBoxColumn,
            this.补充说明DataGridViewTextBoxColumn});
            this.车位使用DataGridView.DataSource = this.车位使用BindingSource;
            this.车位使用DataGridView.Location = new System.Drawing.Point(9, 142);
            this.车位使用DataGridView.MultiSelect = false;
            this.车位使用DataGridView.Name = "车位使用DataGridView";
            this.车位使用DataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.车位使用DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.车位使用DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Green;
            this.车位使用DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.车位使用DataGridView.RowTemplate.Height = 23;
            this.车位使用DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.车位使用DataGridView.Size = new System.Drawing.Size(523, 298);
            this.车位使用DataGridView.TabIndex = 34;
            this.车位使用DataGridView.SelectionChanged += new System.EventHandler(this.车位使用DataGridView_SelectionChanged);
            // 
            // 自动编号DataGridViewTextBoxColumn
            // 
            this.自动编号DataGridViewTextBoxColumn.DataPropertyName = "自动编号";
            this.自动编号DataGridViewTextBoxColumn.HeaderText = "自动编号";
            this.自动编号DataGridViewTextBoxColumn.Name = "自动编号DataGridViewTextBoxColumn";
            this.自动编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 车位编号DataGridViewTextBoxColumn
            // 
            this.车位编号DataGridViewTextBoxColumn.DataPropertyName = "车位编号";
            this.车位编号DataGridViewTextBoxColumn.HeaderText = "车位编号";
            this.车位编号DataGridViewTextBoxColumn.Name = "车位编号DataGridViewTextBoxColumn";
            this.车位编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 车位面积DataGridViewTextBoxColumn
            // 
            this.车位面积DataGridViewTextBoxColumn.DataPropertyName = "车位面积";
            this.车位面积DataGridViewTextBoxColumn.HeaderText = "车位面积";
            this.车位面积DataGridViewTextBoxColumn.Name = "车位面积DataGridViewTextBoxColumn";
            this.车位面积DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 楼栋名称DataGridViewTextBoxColumn
            // 
            this.楼栋名称DataGridViewTextBoxColumn.DataPropertyName = "楼栋名称";
            this.楼栋名称DataGridViewTextBoxColumn.HeaderText = "楼栋名称";
            this.楼栋名称DataGridViewTextBoxColumn.Name = "楼栋名称DataGridViewTextBoxColumn";
            this.楼栋名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 业主编号DataGridViewTextBoxColumn
            // 
            this.业主编号DataGridViewTextBoxColumn.DataPropertyName = "业主编号";
            this.业主编号DataGridViewTextBoxColumn.HeaderText = "业主编号";
            this.业主编号DataGridViewTextBoxColumn.Name = "业主编号DataGridViewTextBoxColumn";
            this.业主编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 业主姓名DataGridViewTextBoxColumn
            // 
            this.业主姓名DataGridViewTextBoxColumn.DataPropertyName = "业主姓名";
            this.业主姓名DataGridViewTextBoxColumn.HeaderText = "业主姓名";
            this.业主姓名DataGridViewTextBoxColumn.Name = "业主姓名DataGridViewTextBoxColumn";
            this.业主姓名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 启用日期DataGridViewTextBoxColumn
            // 
            this.启用日期DataGridViewTextBoxColumn.DataPropertyName = "启用日期";
            this.启用日期DataGridViewTextBoxColumn.HeaderText = "启用日期";
            this.启用日期DataGridViewTextBoxColumn.Name = "启用日期DataGridViewTextBoxColumn";
            this.启用日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 停用日期DataGridViewTextBoxColumn
            // 
            this.停用日期DataGridViewTextBoxColumn.DataPropertyName = "停用日期";
            this.停用日期DataGridViewTextBoxColumn.HeaderText = "停用日期";
            this.停用日期DataGridViewTextBoxColumn.Name = "停用日期DataGridViewTextBoxColumn";
            this.停用日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 费用金额DataGridViewTextBoxColumn
            // 
            this.费用金额DataGridViewTextBoxColumn.DataPropertyName = "费用金额";
            this.费用金额DataGridViewTextBoxColumn.HeaderText = "费用金额";
            this.费用金额DataGridViewTextBoxColumn.Name = "费用金额DataGridViewTextBoxColumn";
            this.费用金额DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 管理人员DataGridViewTextBoxColumn
            // 
            this.管理人员DataGridViewTextBoxColumn.DataPropertyName = "管理人员";
            this.管理人员DataGridViewTextBoxColumn.HeaderText = "管理人员";
            this.管理人员DataGridViewTextBoxColumn.Name = "管理人员DataGridViewTextBoxColumn";
            this.管理人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 补充说明DataGridViewTextBoxColumn
            // 
            this.补充说明DataGridViewTextBoxColumn.DataPropertyName = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.HeaderText = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.Name = "补充说明DataGridViewTextBoxColumn";
            this.补充说明DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.车位使用BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.车位使用BindingNavigator)).EndInit();
            this.车位使用BindingNavigator.ResumeLayout(false);
            this.车位使用BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.车位使用DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 车位使用BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.车位使用TableAdapter 车位使用TableAdapter;
        private System.Windows.Forms.BindingNavigator 车位使用BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 车位使用BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 车位编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 车位编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
        private System.Windows.Forms.TextBox 自动编号TextBox;
        private System.Windows.Forms.TextBox 车位编号TextBox;
        private System.Windows.Forms.TextBox 车位面积TextBox;
        private System.Windows.Forms.ComboBox 楼栋名称ComboBox;
        private System.Windows.Forms.TextBox 业主编号TextBox;
        private System.Windows.Forms.ComboBox 业主姓名ComboBox;
        private System.Windows.Forms.DateTimePicker 启用日期DateTimePicker;
        private System.Windows.Forms.DateTimePicker 停用日期DateTimePicker;
        private System.Windows.Forms.TextBox 费用金额TextBox;
        private System.Windows.Forms.TextBox 管理人员TextBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.BindingSource 楼栋信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter 楼栋信息TableAdapter;
        private System.Windows.Forms.BindingSource 业主信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.业主信息TableAdapter 业主信息TableAdapter;
        private System.Windows.Forms.DataGridView 车位使用DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 自动编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车位编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车位面积DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼栋名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 启用日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 停用日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 费用金额DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 管理人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 补充说明DataGridViewTextBoxColumn;
    }
}