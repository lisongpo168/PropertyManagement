namespace MyCommunity
{
    partial class BuildingForm
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
            System.Windows.Forms.Label 楼栋名称Label;
            System.Windows.Forms.Label 所处位置Label;
            System.Windows.Forms.Label 单元信息Label;
            System.Windows.Forms.Label 楼层信息Label;
            System.Windows.Forms.Label 总人口数Label;
            System.Windows.Forms.Label 总户数Label;
            System.Windows.Forms.Label 入住户数Label;
            System.Windows.Forms.Label 住宅户数Label;
            System.Windows.Forms.Label 管理楼长Label;
            System.Windows.Forms.Label 联系电话Label;
            System.Windows.Forms.Label 补充说明Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildingForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.楼栋信息BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.楼栋信息BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.楼栋信息BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.楼栋名称TextBox = new System.Windows.Forms.TextBox();
            this.所处位置TextBox = new System.Windows.Forms.TextBox();
            this.单元信息TextBox = new System.Windows.Forms.TextBox();
            this.楼层信息TextBox = new System.Windows.Forms.TextBox();
            this.总人口数TextBox = new System.Windows.Forms.TextBox();
            this.总户数TextBox = new System.Windows.Forms.TextBox();
            this.入住户数TextBox = new System.Windows.Forms.TextBox();
            this.住宅户数TextBox = new System.Windows.Forms.TextBox();
            this.管理楼长TextBox = new System.Windows.Forms.TextBox();
            this.联系电话TextBox = new System.Windows.Forms.TextBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.楼栋信息DataGridView = new System.Windows.Forms.DataGridView();
            this.楼栋名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所处位置DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单元信息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼层信息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总人口数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总户数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入住户数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住宅户数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.管理楼长DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.补充说明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼栋信息TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter();
            楼栋名称Label = new System.Windows.Forms.Label();
            所处位置Label = new System.Windows.Forms.Label();
            单元信息Label = new System.Windows.Forms.Label();
            楼层信息Label = new System.Windows.Forms.Label();
            总人口数Label = new System.Windows.Forms.Label();
            总户数Label = new System.Windows.Forms.Label();
            入住户数Label = new System.Windows.Forms.Label();
            住宅户数Label = new System.Windows.Forms.Label();
            管理楼长Label = new System.Windows.Forms.Label();
            联系电话Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingNavigator)).BeginInit();
            this.楼栋信息BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 楼栋名称Label
            // 
            楼栋名称Label.AutoSize = true;
            楼栋名称Label.Location = new System.Drawing.Point(9, 35);
            楼栋名称Label.Name = "楼栋名称Label";
            楼栋名称Label.Size = new System.Drawing.Size(58, 13);
            楼栋名称Label.TabIndex = 2;
            楼栋名称Label.Text = "楼栋名称:";
            // 
            // 所处位置Label
            // 
            所处位置Label.AutoSize = true;
            所处位置Label.Location = new System.Drawing.Point(182, 35);
            所处位置Label.Name = "所处位置Label";
            所处位置Label.Size = new System.Drawing.Size(58, 13);
            所处位置Label.TabIndex = 4;
            所处位置Label.Text = "所处位置:";
            // 
            // 单元信息Label
            // 
            单元信息Label.AutoSize = true;
            单元信息Label.Location = new System.Drawing.Point(342, 35);
            单元信息Label.Name = "单元信息Label";
            单元信息Label.Size = new System.Drawing.Size(58, 13);
            单元信息Label.TabIndex = 6;
            单元信息Label.Text = "单元信息:";
            // 
            // 楼层信息Label
            // 
            楼层信息Label.AutoSize = true;
            楼层信息Label.Location = new System.Drawing.Point(8, 61);
            楼层信息Label.Name = "楼层信息Label";
            楼层信息Label.Size = new System.Drawing.Size(58, 13);
            楼层信息Label.TabIndex = 8;
            楼层信息Label.Text = "楼层信息:";
            // 
            // 总人口数Label
            // 
            总人口数Label.AutoSize = true;
            总人口数Label.Location = new System.Drawing.Point(124, 61);
            总人口数Label.Name = "总人口数Label";
            总人口数Label.Size = new System.Drawing.Size(58, 13);
            总人口数Label.TabIndex = 10;
            总人口数Label.Text = "总人口数:";
            // 
            // 总户数Label
            // 
            总户数Label.AutoSize = true;
            总户数Label.Location = new System.Drawing.Point(226, 61);
            总户数Label.Name = "总户数Label";
            总户数Label.Size = new System.Drawing.Size(46, 13);
            总户数Label.TabIndex = 12;
            总户数Label.Text = "总户数:";
            // 
            // 入住户数Label
            // 
            入住户数Label.AutoSize = true;
            入住户数Label.Location = new System.Drawing.Point(327, 61);
            入住户数Label.Name = "入住户数Label";
            入住户数Label.Size = new System.Drawing.Size(58, 13);
            入住户数Label.TabIndex = 14;
            入住户数Label.Text = "入住户数:";
            // 
            // 住宅户数Label
            // 
            住宅户数Label.AutoSize = true;
            住宅户数Label.Location = new System.Drawing.Point(431, 61);
            住宅户数Label.Name = "住宅户数Label";
            住宅户数Label.Size = new System.Drawing.Size(58, 13);
            住宅户数Label.TabIndex = 16;
            住宅户数Label.Text = "住宅户数:";
            // 
            // 管理楼长Label
            // 
            管理楼长Label.AutoSize = true;
            管理楼长Label.Location = new System.Drawing.Point(7, 87);
            管理楼长Label.Name = "管理楼长Label";
            管理楼长Label.Size = new System.Drawing.Size(58, 13);
            管理楼长Label.TabIndex = 18;
            管理楼长Label.Text = "管理楼长:";
            // 
            // 联系电话Label
            // 
            联系电话Label.AutoSize = true;
            联系电话Label.Location = new System.Drawing.Point(149, 87);
            联系电话Label.Name = "联系电话Label";
            联系电话Label.Size = new System.Drawing.Size(58, 13);
            联系电话Label.TabIndex = 20;
            联系电话Label.Text = "联系电话:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(305, 87);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(58, 13);
            补充说明Label.TabIndex = 22;
            补充说明Label.Text = "补充说明:";
            // 
            // 楼栋信息BindingNavigator
            // 
            this.楼栋信息BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.楼栋信息BindingNavigator.BindingSource = this.楼栋信息BindingSource;
            this.楼栋信息BindingNavigator.CountItem = null;
            this.楼栋信息BindingNavigator.DeleteItem = null;
            this.楼栋信息BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.楼栋信息BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.楼栋信息BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.楼栋信息BindingNavigator.MoveFirstItem = null;
            this.楼栋信息BindingNavigator.MoveLastItem = null;
            this.楼栋信息BindingNavigator.MoveNextItem = null;
            this.楼栋信息BindingNavigator.MovePreviousItem = null;
            this.楼栋信息BindingNavigator.Name = "楼栋信息BindingNavigator";
            this.楼栋信息BindingNavigator.PositionItem = null;
            this.楼栋信息BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.楼栋信息BindingNavigator.TabIndex = 0;
            this.楼栋信息BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorAddNewItem.Text = "新增";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // 楼栋信息BindingNavigatorSaveItem
            // 
            this.楼栋信息BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("楼栋信息BindingNavigatorSaveItem.Image")));
            this.楼栋信息BindingNavigatorSaveItem.Name = "楼栋信息BindingNavigatorSaveItem";
            this.楼栋信息BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.楼栋信息BindingNavigatorSaveItem.Text = "保存";
            this.楼栋信息BindingNavigatorSaveItem.Click += new System.EventHandler(this.楼栋信息BindingNavigatorSaveItem_Click);
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
            // 楼栋名称TextBox
            // 
            this.楼栋名称TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "楼栋名称", true));
            this.楼栋名称TextBox.Location = new System.Drawing.Point(69, 29);
            this.楼栋名称TextBox.Name = "楼栋名称TextBox";
            this.楼栋名称TextBox.Size = new System.Drawing.Size(108, 20);
            this.楼栋名称TextBox.TabIndex = 3;
            // 
            // 所处位置TextBox
            // 
            this.所处位置TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "所处位置", true));
            this.所处位置TextBox.Location = new System.Drawing.Point(243, 29);
            this.所处位置TextBox.Name = "所处位置TextBox";
            this.所处位置TextBox.Size = new System.Drawing.Size(93, 20);
            this.所处位置TextBox.TabIndex = 5;
            // 
            // 单元信息TextBox
            // 
            this.单元信息TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.单元信息TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "单元信息", true));
            this.单元信息TextBox.Location = new System.Drawing.Point(401, 29);
            this.单元信息TextBox.Name = "单元信息TextBox";
            this.单元信息TextBox.Size = new System.Drawing.Size(129, 20);
            this.单元信息TextBox.TabIndex = 7;
            // 
            // 楼层信息TextBox
            // 
            this.楼层信息TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "楼层信息", true));
            this.楼层信息TextBox.Location = new System.Drawing.Point(69, 55);
            this.楼层信息TextBox.Name = "楼层信息TextBox";
            this.楼层信息TextBox.Size = new System.Drawing.Size(54, 20);
            this.楼层信息TextBox.TabIndex = 9;
            // 
            // 总人口数TextBox
            // 
            this.总人口数TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "总人口数", true));
            this.总人口数TextBox.Location = new System.Drawing.Point(184, 55);
            this.总人口数TextBox.Name = "总人口数TextBox";
            this.总人口数TextBox.Size = new System.Drawing.Size(42, 20);
            this.总人口数TextBox.TabIndex = 11;
            // 
            // 总户数TextBox
            // 
            this.总户数TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "总户数", true));
            this.总户数TextBox.Location = new System.Drawing.Point(273, 55);
            this.总户数TextBox.Name = "总户数TextBox";
            this.总户数TextBox.Size = new System.Drawing.Size(49, 20);
            this.总户数TextBox.TabIndex = 13;
            // 
            // 入住户数TextBox
            // 
            this.入住户数TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "入住户数", true));
            this.入住户数TextBox.Location = new System.Drawing.Point(389, 55);
            this.入住户数TextBox.Name = "入住户数TextBox";
            this.入住户数TextBox.Size = new System.Drawing.Size(40, 20);
            this.入住户数TextBox.TabIndex = 15;
            // 
            // 住宅户数TextBox
            // 
            this.住宅户数TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.住宅户数TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "住宅户数", true));
            this.住宅户数TextBox.Location = new System.Drawing.Point(492, 55);
            this.住宅户数TextBox.Name = "住宅户数TextBox";
            this.住宅户数TextBox.Size = new System.Drawing.Size(39, 20);
            this.住宅户数TextBox.TabIndex = 17;
            // 
            // 管理楼长TextBox
            // 
            this.管理楼长TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "管理楼长", true));
            this.管理楼长TextBox.Location = new System.Drawing.Point(68, 82);
            this.管理楼长TextBox.Name = "管理楼长TextBox";
            this.管理楼长TextBox.Size = new System.Drawing.Size(75, 20);
            this.管理楼长TextBox.TabIndex = 19;
            // 
            // 联系电话TextBox
            // 
            this.联系电话TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "联系电话", true));
            this.联系电话TextBox.Location = new System.Drawing.Point(214, 82);
            this.联系电话TextBox.Name = "联系电话TextBox";
            this.联系电话TextBox.Size = new System.Drawing.Size(85, 20);
            this.联系电话TextBox.TabIndex = 21;
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.补充说明TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.楼栋信息BindingSource, "补充说明", true));
            this.补充说明TextBox.Location = new System.Drawing.Point(370, 82);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(161, 20);
            this.补充说明TextBox.TabIndex = 23;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 楼栋信息DataGridView
            // 
            this.楼栋信息DataGridView.AllowUserToAddRows = false;
            this.楼栋信息DataGridView.AllowUserToDeleteRows = false;
            this.楼栋信息DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.楼栋信息DataGridView.AutoGenerateColumns = false;
            this.楼栋信息DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.楼栋信息DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.楼栋信息DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.楼栋信息DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.楼栋名称DataGridViewTextBoxColumn,
            this.所处位置DataGridViewTextBoxColumn,
            this.单元信息DataGridViewTextBoxColumn,
            this.楼层信息DataGridViewTextBoxColumn,
            this.总人口数DataGridViewTextBoxColumn,
            this.总户数DataGridViewTextBoxColumn,
            this.入住户数DataGridViewTextBoxColumn,
            this.住宅户数DataGridViewTextBoxColumn,
            this.管理楼长DataGridViewTextBoxColumn,
            this.联系电话DataGridViewTextBoxColumn,
            this.补充说明DataGridViewTextBoxColumn});
            this.楼栋信息DataGridView.DataSource = this.楼栋信息BindingSource;
            this.楼栋信息DataGridView.Location = new System.Drawing.Point(9, 114);
            this.楼栋信息DataGridView.MultiSelect = false;
            this.楼栋信息DataGridView.Name = "楼栋信息DataGridView";
            this.楼栋信息DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.楼栋信息DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.楼栋信息DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.楼栋信息DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.楼栋信息DataGridView.RowTemplate.Height = 23;
            this.楼栋信息DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.楼栋信息DataGridView.Size = new System.Drawing.Size(523, 326);
            this.楼栋信息DataGridView.TabIndex = 24;
            this.楼栋信息DataGridView.SelectionChanged += new System.EventHandler(this.楼栋信息DataGridView_SelectionChanged);
            // 
            // 楼栋名称DataGridViewTextBoxColumn
            // 
            this.楼栋名称DataGridViewTextBoxColumn.DataPropertyName = "楼栋名称";
            this.楼栋名称DataGridViewTextBoxColumn.HeaderText = "楼栋名称";
            this.楼栋名称DataGridViewTextBoxColumn.Name = "楼栋名称DataGridViewTextBoxColumn";
            this.楼栋名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 所处位置DataGridViewTextBoxColumn
            // 
            this.所处位置DataGridViewTextBoxColumn.DataPropertyName = "所处位置";
            this.所处位置DataGridViewTextBoxColumn.HeaderText = "所处位置";
            this.所处位置DataGridViewTextBoxColumn.Name = "所处位置DataGridViewTextBoxColumn";
            this.所处位置DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 单元信息DataGridViewTextBoxColumn
            // 
            this.单元信息DataGridViewTextBoxColumn.DataPropertyName = "单元信息";
            this.单元信息DataGridViewTextBoxColumn.HeaderText = "单元信息";
            this.单元信息DataGridViewTextBoxColumn.Name = "单元信息DataGridViewTextBoxColumn";
            this.单元信息DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 楼层信息DataGridViewTextBoxColumn
            // 
            this.楼层信息DataGridViewTextBoxColumn.DataPropertyName = "楼层信息";
            this.楼层信息DataGridViewTextBoxColumn.HeaderText = "楼层信息";
            this.楼层信息DataGridViewTextBoxColumn.Name = "楼层信息DataGridViewTextBoxColumn";
            this.楼层信息DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 总人口数DataGridViewTextBoxColumn
            // 
            this.总人口数DataGridViewTextBoxColumn.DataPropertyName = "总人口数";
            this.总人口数DataGridViewTextBoxColumn.HeaderText = "总人口数";
            this.总人口数DataGridViewTextBoxColumn.Name = "总人口数DataGridViewTextBoxColumn";
            this.总人口数DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 总户数DataGridViewTextBoxColumn
            // 
            this.总户数DataGridViewTextBoxColumn.DataPropertyName = "总户数";
            this.总户数DataGridViewTextBoxColumn.HeaderText = "总户数";
            this.总户数DataGridViewTextBoxColumn.Name = "总户数DataGridViewTextBoxColumn";
            this.总户数DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 入住户数DataGridViewTextBoxColumn
            // 
            this.入住户数DataGridViewTextBoxColumn.DataPropertyName = "入住户数";
            this.入住户数DataGridViewTextBoxColumn.HeaderText = "入住户数";
            this.入住户数DataGridViewTextBoxColumn.Name = "入住户数DataGridViewTextBoxColumn";
            this.入住户数DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 住宅户数DataGridViewTextBoxColumn
            // 
            this.住宅户数DataGridViewTextBoxColumn.DataPropertyName = "住宅户数";
            this.住宅户数DataGridViewTextBoxColumn.HeaderText = "住宅户数";
            this.住宅户数DataGridViewTextBoxColumn.Name = "住宅户数DataGridViewTextBoxColumn";
            this.住宅户数DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 管理楼长DataGridViewTextBoxColumn
            // 
            this.管理楼长DataGridViewTextBoxColumn.DataPropertyName = "管理楼长";
            this.管理楼长DataGridViewTextBoxColumn.HeaderText = "管理楼长";
            this.管理楼长DataGridViewTextBoxColumn.Name = "管理楼长DataGridViewTextBoxColumn";
            this.管理楼长DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 联系电话DataGridViewTextBoxColumn
            // 
            this.联系电话DataGridViewTextBoxColumn.DataPropertyName = "联系电话";
            this.联系电话DataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.联系电话DataGridViewTextBoxColumn.Name = "联系电话DataGridViewTextBoxColumn";
            this.联系电话DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 补充说明DataGridViewTextBoxColumn
            // 
            this.补充说明DataGridViewTextBoxColumn.DataPropertyName = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.HeaderText = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.Name = "补充说明DataGridViewTextBoxColumn";
            this.补充说明DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 楼栋信息TableAdapter
            // 
            this.楼栋信息TableAdapter.ClearBeforeFill = true;
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.楼栋信息DataGridView);
            this.Controls.Add(楼栋名称Label);
            this.Controls.Add(this.楼栋名称TextBox);
            this.Controls.Add(所处位置Label);
            this.Controls.Add(this.所处位置TextBox);
            this.Controls.Add(单元信息Label);
            this.Controls.Add(this.单元信息TextBox);
            this.Controls.Add(楼层信息Label);
            this.Controls.Add(this.楼层信息TextBox);
            this.Controls.Add(总人口数Label);
            this.Controls.Add(this.总人口数TextBox);
            this.Controls.Add(总户数Label);
            this.Controls.Add(this.总户数TextBox);
            this.Controls.Add(入住户数Label);
            this.Controls.Add(this.入住户数TextBox);
            this.Controls.Add(住宅户数Label);
            this.Controls.Add(this.住宅户数TextBox);
            this.Controls.Add(管理楼长Label);
            this.Controls.Add(this.管理楼长TextBox);
            this.Controls.Add(联系电话Label);
            this.Controls.Add(this.联系电话TextBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.楼栋信息BindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuildingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "基本管理[楼栋信息管理]";
            this.Load += new System.EventHandler(this.BuildingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingNavigator)).EndInit();
            this.楼栋信息BindingNavigator.ResumeLayout(false);
            this.楼栋信息BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 楼栋信息BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.楼栋信息TableAdapter 楼栋信息TableAdapter;
        private System.Windows.Forms.BindingNavigator 楼栋信息BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton 楼栋信息BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 楼栋名称TextBox;
        private System.Windows.Forms.TextBox 所处位置TextBox;
        private System.Windows.Forms.TextBox 单元信息TextBox;
        private System.Windows.Forms.TextBox 楼层信息TextBox;
        private System.Windows.Forms.TextBox 总人口数TextBox;
        private System.Windows.Forms.TextBox 总户数TextBox;
        private System.Windows.Forms.TextBox 入住户数TextBox;
        private System.Windows.Forms.TextBox 住宅户数TextBox;
        private System.Windows.Forms.TextBox 管理楼长TextBox;
        private System.Windows.Forms.TextBox 联系电话TextBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.DataGridView 楼栋信息DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼栋名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所处位置DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单元信息DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼层信息DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总人口数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总户数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入住户数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住宅户数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 管理楼长DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 补充说明DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;



    }
}