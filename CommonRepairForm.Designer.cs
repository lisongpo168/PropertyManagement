namespace MyCommunity
{
    partial class CommonRepairForm
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
            System.Windows.Forms.Label 维修编号Label;
            System.Windows.Forms.Label 财产编号Label;
            System.Windows.Forms.Label 财产名称Label;
            System.Windows.Forms.Label 报修日期Label;
            System.Windows.Forms.Label 报修人员Label;
            System.Windows.Forms.Label 故障现象Label;
            System.Windows.Forms.Label 受理人员Label;
            System.Windows.Forms.Label 处理意见Label;
            System.Windows.Forms.Label 修理日期Label;
            System.Windows.Forms.Label 修理人员Label;
            System.Windows.Forms.Label 修理费用Label;
            System.Windows.Forms.Label 材料费用Label;
            System.Windows.Forms.Label 修理结果Label;
            System.Windows.Forms.Label 补充说明Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonRepairForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.公共维修BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.公共维修BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCommunityDataSet = new MyCommunity.Data.DBCommunityDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.维修编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.维修编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
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
            this.公共维修BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.维修编号TextBox = new System.Windows.Forms.TextBox();
            this.财产编号TextBox = new System.Windows.Forms.TextBox();
            this.财产名称ComboBox = new System.Windows.Forms.ComboBox();
            this.公共财产BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.报修日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.报修人员TextBox = new System.Windows.Forms.TextBox();
            this.故障现象TextBox = new System.Windows.Forms.TextBox();
            this.受理人员TextBox = new System.Windows.Forms.TextBox();
            this.处理意见TextBox = new System.Windows.Forms.TextBox();
            this.修理日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.修理人员TextBox = new System.Windows.Forms.TextBox();
            this.修理费用TextBox = new System.Windows.Forms.TextBox();
            this.材料费用TextBox = new System.Windows.Forms.TextBox();
            this.修理结果TextBox = new System.Windows.Forms.TextBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.公共维修TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.公共维修TableAdapter();
            this.公共维修DataGridView = new System.Windows.Forms.DataGridView();
            this.维修编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.财产编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.财产名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报修日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报修人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.故障现象DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.受理人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处理意见DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修理日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修理人员DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修理费用DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材料费用DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修理结果DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.补充说明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公共财产TableAdapter = new MyCommunity.Data.DBCommunityDataSetTableAdapters.公共财产TableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            维修编号Label = new System.Windows.Forms.Label();
            财产编号Label = new System.Windows.Forms.Label();
            财产名称Label = new System.Windows.Forms.Label();
            报修日期Label = new System.Windows.Forms.Label();
            报修人员Label = new System.Windows.Forms.Label();
            故障现象Label = new System.Windows.Forms.Label();
            受理人员Label = new System.Windows.Forms.Label();
            处理意见Label = new System.Windows.Forms.Label();
            修理日期Label = new System.Windows.Forms.Label();
            修理人员Label = new System.Windows.Forms.Label();
            修理费用Label = new System.Windows.Forms.Label();
            材料费用Label = new System.Windows.Forms.Label();
            修理结果Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.公共维修BindingNavigator)).BeginInit();
            this.公共维修BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.公共维修BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共维修DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 维修编号Label
            // 
            维修编号Label.AutoSize = true;
            维修编号Label.Location = new System.Drawing.Point(8, 35);
            维修编号Label.Name = "维修编号Label";
            维修编号Label.Size = new System.Drawing.Size(58, 13);
            维修编号Label.TabIndex = 2;
            维修编号Label.Text = "维修编号:";
            // 
            // 财产编号Label
            // 
            财产编号Label.AutoSize = true;
            财产编号Label.Location = new System.Drawing.Point(188, 36);
            财产编号Label.Name = "财产编号Label";
            财产编号Label.Size = new System.Drawing.Size(58, 13);
            财产编号Label.TabIndex = 4;
            财产编号Label.Text = "财产编号:";
            // 
            // 财产名称Label
            // 
            财产名称Label.AutoSize = true;
            财产名称Label.Location = new System.Drawing.Point(351, 36);
            财产名称Label.Name = "财产名称Label";
            财产名称Label.Size = new System.Drawing.Size(58, 13);
            财产名称Label.TabIndex = 6;
            财产名称Label.Text = "财产名称:";
            // 
            // 报修日期Label
            // 
            报修日期Label.AutoSize = true;
            报修日期Label.Location = new System.Drawing.Point(8, 62);
            报修日期Label.Name = "报修日期Label";
            报修日期Label.Size = new System.Drawing.Size(58, 13);
            报修日期Label.TabIndex = 8;
            报修日期Label.Text = "报修日期:";
            // 
            // 报修人员Label
            // 
            报修人员Label.AutoSize = true;
            报修人员Label.Location = new System.Drawing.Point(215, 62);
            报修人员Label.Name = "报修人员Label";
            报修人员Label.Size = new System.Drawing.Size(58, 13);
            报修人员Label.TabIndex = 10;
            报修人员Label.Text = "报修人员:";
            // 
            // 故障现象Label
            // 
            故障现象Label.AutoSize = true;
            故障现象Label.Location = new System.Drawing.Point(8, 89);
            故障现象Label.Name = "故障现象Label";
            故障现象Label.Size = new System.Drawing.Size(58, 13);
            故障现象Label.TabIndex = 12;
            故障现象Label.Text = "故障现象:";
            // 
            // 受理人员Label
            // 
            受理人员Label.AutoSize = true;
            受理人员Label.Location = new System.Drawing.Point(369, 62);
            受理人员Label.Name = "受理人员Label";
            受理人员Label.Size = new System.Drawing.Size(58, 13);
            受理人员Label.TabIndex = 14;
            受理人员Label.Text = "受理人员:";
            // 
            // 处理意见Label
            // 
            处理意见Label.AutoSize = true;
            处理意见Label.Location = new System.Drawing.Point(8, 115);
            处理意见Label.Name = "处理意见Label";
            处理意见Label.Size = new System.Drawing.Size(58, 13);
            处理意见Label.TabIndex = 16;
            处理意见Label.Text = "处理意见:";
            // 
            // 修理日期Label
            // 
            修理日期Label.AutoSize = true;
            修理日期Label.Location = new System.Drawing.Point(8, 143);
            修理日期Label.Name = "修理日期Label";
            修理日期Label.Size = new System.Drawing.Size(58, 13);
            修理日期Label.TabIndex = 18;
            修理日期Label.Text = "修理日期:";
            // 
            // 修理人员Label
            // 
            修理人员Label.AutoSize = true;
            修理人员Label.Location = new System.Drawing.Point(188, 143);
            修理人员Label.Name = "修理人员Label";
            修理人员Label.Size = new System.Drawing.Size(58, 13);
            修理人员Label.TabIndex = 20;
            修理人员Label.Text = "修理人员:";
            // 
            // 修理费用Label
            // 
            修理费用Label.AutoSize = true;
            修理费用Label.Location = new System.Drawing.Point(318, 143);
            修理费用Label.Name = "修理费用Label";
            修理费用Label.Size = new System.Drawing.Size(58, 13);
            修理费用Label.TabIndex = 22;
            修理费用Label.Text = "修理费用:";
            // 
            // 材料费用Label
            // 
            材料费用Label.AutoSize = true;
            材料费用Label.Location = new System.Drawing.Point(429, 143);
            材料费用Label.Name = "材料费用Label";
            材料费用Label.Size = new System.Drawing.Size(58, 13);
            材料费用Label.TabIndex = 24;
            材料费用Label.Text = "材料费用:";
            // 
            // 修理结果Label
            // 
            修理结果Label.AutoSize = true;
            修理结果Label.Location = new System.Drawing.Point(8, 169);
            修理结果Label.Name = "修理结果Label";
            修理结果Label.Size = new System.Drawing.Size(58, 13);
            修理结果Label.TabIndex = 28;
            修理结果Label.Text = "修理结果:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(8, 195);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(58, 13);
            补充说明Label.TabIndex = 30;
            补充说明Label.Text = "补充说明:";
            // 
            // 公共维修BindingNavigator
            // 
            this.公共维修BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.公共维修BindingNavigator.BindingSource = this.公共维修BindingSource;
            this.公共维修BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.公共维修BindingNavigator.DeleteItem = null;
            this.公共维修BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.维修编号ToolStripLabel,
            this.维修编号ToolStripTextBox,
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
            this.公共维修BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.公共维修BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.公共维修BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.公共维修BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.公共维修BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.公共维修BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.公共维修BindingNavigator.Name = "公共维修BindingNavigator";
            this.公共维修BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.公共维修BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.公共维修BindingNavigator.TabIndex = 0;
            this.公共维修BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorAddNewItem.Text = "新增";
            // 
            // 公共维修BindingSource
            // 
            this.公共维修BindingSource.DataMember = "公共维修";
            this.公共维修BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // dBCommunityDataSet
            // 
            this.dBCommunityDataSet.DataSetName = "DBCommunityDataSet";
            this.dBCommunityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // 维修编号ToolStripLabel
            // 
            this.维修编号ToolStripLabel.Name = "维修编号ToolStripLabel";
            this.维修编号ToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.维修编号ToolStripLabel.Text = "维修编号:";
            // 
            // 维修编号ToolStripTextBox
            // 
            this.维修编号ToolStripTextBox.Name = "维修编号ToolStripTextBox";
            this.维修编号ToolStripTextBox.Size = new System.Drawing.Size(50, 25);
            this.维修编号ToolStripTextBox.Text = "%%";
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
            // 公共维修BindingNavigatorSaveItem
            // 
            this.公共维修BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("公共维修BindingNavigatorSaveItem.Image")));
            this.公共维修BindingNavigatorSaveItem.Name = "公共维修BindingNavigatorSaveItem";
            this.公共维修BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.公共维修BindingNavigatorSaveItem.Text = "保存";
            this.公共维修BindingNavigatorSaveItem.Click += new System.EventHandler(this.公共维修BindingNavigatorSaveItem_Click);
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
            // 维修编号TextBox
            // 
            this.维修编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "维修编号", true));
            this.维修编号TextBox.Enabled = false;
            this.维修编号TextBox.Location = new System.Drawing.Point(70, 29);
            this.维修编号TextBox.Name = "维修编号TextBox";
            this.维修编号TextBox.Size = new System.Drawing.Size(113, 20);
            this.维修编号TextBox.TabIndex = 3;
            // 
            // 财产编号TextBox
            // 
            this.财产编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "财产编号", true));
            this.财产编号TextBox.Location = new System.Drawing.Point(249, 29);
            this.财产编号TextBox.Name = "财产编号TextBox";
            this.财产编号TextBox.ReadOnly = true;
            this.财产编号TextBox.Size = new System.Drawing.Size(99, 20);
            this.财产编号TextBox.TabIndex = 5;
            // 
            // 财产名称ComboBox
            // 
            this.财产名称ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "财产名称", true));
            this.财产名称ComboBox.DisplayMember = "财产名称";
            this.财产名称ComboBox.FormattingEnabled = true;
            this.财产名称ComboBox.Location = new System.Drawing.Point(410, 30);
            this.财产名称ComboBox.Name = "财产名称ComboBox";
            this.财产名称ComboBox.Size = new System.Drawing.Size(124, 21);
            this.财产名称ComboBox.TabIndex = 7;
            this.财产名称ComboBox.ValueMember = "财产编号";
            this.财产名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.财产名称ComboBox_SelectedIndexChanged);
            // 
            // 公共财产BindingSource
            // 
            this.公共财产BindingSource.DataMember = "公共财产";
            this.公共财产BindingSource.DataSource = this.dBCommunityDataSet;
            // 
            // 报修日期DateTimePicker
            // 
            this.报修日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.公共维修BindingSource, "报修日期", true));
            this.报修日期DateTimePicker.Location = new System.Drawing.Point(70, 56);
            this.报修日期DateTimePicker.Name = "报修日期DateTimePicker";
            this.报修日期DateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.报修日期DateTimePicker.TabIndex = 9;
            // 
            // 报修人员TextBox
            // 
            this.报修人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "报修人员", true));
            this.报修人员TextBox.Location = new System.Drawing.Point(276, 56);
            this.报修人员TextBox.Name = "报修人员TextBox";
            this.报修人员TextBox.Size = new System.Drawing.Size(87, 20);
            this.报修人员TextBox.TabIndex = 11;
            // 
            // 故障现象TextBox
            // 
            this.故障现象TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "故障现象", true));
            this.故障现象TextBox.Location = new System.Drawing.Point(70, 83);
            this.故障现象TextBox.Name = "故障现象TextBox";
            this.故障现象TextBox.Size = new System.Drawing.Size(464, 20);
            this.故障现象TextBox.TabIndex = 13;
            // 
            // 受理人员TextBox
            // 
            this.受理人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "受理人员", true));
            this.受理人员TextBox.Location = new System.Drawing.Point(434, 56);
            this.受理人员TextBox.Name = "受理人员TextBox";
            this.受理人员TextBox.Size = new System.Drawing.Size(100, 20);
            this.受理人员TextBox.TabIndex = 15;
            // 
            // 处理意见TextBox
            // 
            this.处理意见TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "处理意见", true));
            this.处理意见TextBox.Location = new System.Drawing.Point(70, 111);
            this.处理意见TextBox.Name = "处理意见TextBox";
            this.处理意见TextBox.Size = new System.Drawing.Size(464, 20);
            this.处理意见TextBox.TabIndex = 17;
            // 
            // 修理日期DateTimePicker
            // 
            this.修理日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.公共维修BindingSource, "修理日期", true));
            this.修理日期DateTimePicker.Location = new System.Drawing.Point(70, 138);
            this.修理日期DateTimePicker.Name = "修理日期DateTimePicker";
            this.修理日期DateTimePicker.Size = new System.Drawing.Size(113, 20);
            this.修理日期DateTimePicker.TabIndex = 19;
            // 
            // 修理人员TextBox
            // 
            this.修理人员TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "修理人员", true));
            this.修理人员TextBox.Location = new System.Drawing.Point(247, 138);
            this.修理人员TextBox.Name = "修理人员TextBox";
            this.修理人员TextBox.Size = new System.Drawing.Size(67, 20);
            this.修理人员TextBox.TabIndex = 21;
            // 
            // 修理费用TextBox
            // 
            this.修理费用TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "修理费用", true));
            this.修理费用TextBox.Location = new System.Drawing.Point(377, 138);
            this.修理费用TextBox.Name = "修理费用TextBox";
            this.修理费用TextBox.Size = new System.Drawing.Size(47, 20);
            this.修理费用TextBox.TabIndex = 23;
            // 
            // 材料费用TextBox
            // 
            this.材料费用TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "材料费用", true));
            this.材料费用TextBox.Location = new System.Drawing.Point(489, 138);
            this.材料费用TextBox.Name = "材料费用TextBox";
            this.材料费用TextBox.Size = new System.Drawing.Size(45, 20);
            this.材料费用TextBox.TabIndex = 25;
            // 
            // 修理结果TextBox
            // 
            this.修理结果TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "修理结果", true));
            this.修理结果TextBox.Location = new System.Drawing.Point(70, 165);
            this.修理结果TextBox.Name = "修理结果TextBox";
            this.修理结果TextBox.Size = new System.Drawing.Size(464, 20);
            this.修理结果TextBox.TabIndex = 29;
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.公共维修BindingSource, "补充说明", true));
            this.补充说明TextBox.Location = new System.Drawing.Point(70, 191);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(464, 20);
            this.补充说明TextBox.TabIndex = 31;
            // 
            // 公共维修TableAdapter
            // 
            this.公共维修TableAdapter.ClearBeforeFill = true;
            // 
            // 公共维修DataGridView
            // 
            this.公共维修DataGridView.AllowUserToAddRows = false;
            this.公共维修DataGridView.AllowUserToDeleteRows = false;
            this.公共维修DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.公共维修DataGridView.AutoGenerateColumns = false;
            this.公共维修DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.公共维修DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共维修DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.公共维修DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.维修编号DataGridViewTextBoxColumn,
            this.财产编号DataGridViewTextBoxColumn,
            this.财产名称DataGridViewTextBoxColumn,
            this.报修日期DataGridViewTextBoxColumn,
            this.报修人员DataGridViewTextBoxColumn,
            this.故障现象DataGridViewTextBoxColumn,
            this.受理人员DataGridViewTextBoxColumn,
            this.处理意见DataGridViewTextBoxColumn,
            this.修理日期DataGridViewTextBoxColumn,
            this.修理人员DataGridViewTextBoxColumn,
            this.修理费用DataGridViewTextBoxColumn,
            this.材料费用DataGridViewTextBoxColumn,
            this.修理结果DataGridViewTextBoxColumn,
            this.补充说明DataGridViewTextBoxColumn});
            this.公共维修DataGridView.DataSource = this.公共维修BindingSource;
            this.公共维修DataGridView.Location = new System.Drawing.Point(10, 223);
            this.公共维修DataGridView.MultiSelect = false;
            this.公共维修DataGridView.Name = "公共维修DataGridView";
            this.公共维修DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共维修DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.公共维修DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.公共维修DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.公共维修DataGridView.RowTemplate.Height = 23;
            this.公共维修DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.公共维修DataGridView.Size = new System.Drawing.Size(523, 218);
            this.公共维修DataGridView.TabIndex = 34;
            this.公共维修DataGridView.SelectionChanged += new System.EventHandler(this.公共维修DataGridView_SelectionChanged);
            // 
            // 维修编号DataGridViewTextBoxColumn
            // 
            this.维修编号DataGridViewTextBoxColumn.DataPropertyName = "维修编号";
            this.维修编号DataGridViewTextBoxColumn.HeaderText = "维修编号";
            this.维修编号DataGridViewTextBoxColumn.Name = "维修编号DataGridViewTextBoxColumn";
            this.维修编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 财产编号DataGridViewTextBoxColumn
            // 
            this.财产编号DataGridViewTextBoxColumn.DataPropertyName = "财产编号";
            this.财产编号DataGridViewTextBoxColumn.HeaderText = "财产编号";
            this.财产编号DataGridViewTextBoxColumn.Name = "财产编号DataGridViewTextBoxColumn";
            this.财产编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 财产名称DataGridViewTextBoxColumn
            // 
            this.财产名称DataGridViewTextBoxColumn.DataPropertyName = "财产名称";
            this.财产名称DataGridViewTextBoxColumn.HeaderText = "财产名称";
            this.财产名称DataGridViewTextBoxColumn.Name = "财产名称DataGridViewTextBoxColumn";
            this.财产名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 报修日期DataGridViewTextBoxColumn
            // 
            this.报修日期DataGridViewTextBoxColumn.DataPropertyName = "报修日期";
            this.报修日期DataGridViewTextBoxColumn.HeaderText = "报修日期";
            this.报修日期DataGridViewTextBoxColumn.Name = "报修日期DataGridViewTextBoxColumn";
            this.报修日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 报修人员DataGridViewTextBoxColumn
            // 
            this.报修人员DataGridViewTextBoxColumn.DataPropertyName = "报修人员";
            this.报修人员DataGridViewTextBoxColumn.HeaderText = "报修人员";
            this.报修人员DataGridViewTextBoxColumn.Name = "报修人员DataGridViewTextBoxColumn";
            this.报修人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 故障现象DataGridViewTextBoxColumn
            // 
            this.故障现象DataGridViewTextBoxColumn.DataPropertyName = "故障现象";
            this.故障现象DataGridViewTextBoxColumn.HeaderText = "故障现象";
            this.故障现象DataGridViewTextBoxColumn.Name = "故障现象DataGridViewTextBoxColumn";
            this.故障现象DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 受理人员DataGridViewTextBoxColumn
            // 
            this.受理人员DataGridViewTextBoxColumn.DataPropertyName = "受理人员";
            this.受理人员DataGridViewTextBoxColumn.HeaderText = "受理人员";
            this.受理人员DataGridViewTextBoxColumn.Name = "受理人员DataGridViewTextBoxColumn";
            this.受理人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 处理意见DataGridViewTextBoxColumn
            // 
            this.处理意见DataGridViewTextBoxColumn.DataPropertyName = "处理意见";
            this.处理意见DataGridViewTextBoxColumn.HeaderText = "处理意见";
            this.处理意见DataGridViewTextBoxColumn.Name = "处理意见DataGridViewTextBoxColumn";
            this.处理意见DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 修理日期DataGridViewTextBoxColumn
            // 
            this.修理日期DataGridViewTextBoxColumn.DataPropertyName = "修理日期";
            this.修理日期DataGridViewTextBoxColumn.HeaderText = "修理日期";
            this.修理日期DataGridViewTextBoxColumn.Name = "修理日期DataGridViewTextBoxColumn";
            this.修理日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 修理人员DataGridViewTextBoxColumn
            // 
            this.修理人员DataGridViewTextBoxColumn.DataPropertyName = "修理人员";
            this.修理人员DataGridViewTextBoxColumn.HeaderText = "修理人员";
            this.修理人员DataGridViewTextBoxColumn.Name = "修理人员DataGridViewTextBoxColumn";
            this.修理人员DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 修理费用DataGridViewTextBoxColumn
            // 
            this.修理费用DataGridViewTextBoxColumn.DataPropertyName = "修理费用";
            this.修理费用DataGridViewTextBoxColumn.HeaderText = "修理费用";
            this.修理费用DataGridViewTextBoxColumn.Name = "修理费用DataGridViewTextBoxColumn";
            this.修理费用DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 材料费用DataGridViewTextBoxColumn
            // 
            this.材料费用DataGridViewTextBoxColumn.DataPropertyName = "材料费用";
            this.材料费用DataGridViewTextBoxColumn.HeaderText = "材料费用";
            this.材料费用DataGridViewTextBoxColumn.Name = "材料费用DataGridViewTextBoxColumn";
            this.材料费用DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 修理结果DataGridViewTextBoxColumn
            // 
            this.修理结果DataGridViewTextBoxColumn.DataPropertyName = "修理结果";
            this.修理结果DataGridViewTextBoxColumn.HeaderText = "修理结果";
            this.修理结果DataGridViewTextBoxColumn.Name = "修理结果DataGridViewTextBoxColumn";
            this.修理结果DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 补充说明DataGridViewTextBoxColumn
            // 
            this.补充说明DataGridViewTextBoxColumn.DataPropertyName = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.HeaderText = "补充说明";
            this.补充说明DataGridViewTextBoxColumn.Name = "补充说明DataGridViewTextBoxColumn";
            this.补充说明DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 公共财产TableAdapter
            // 
            this.公共财产TableAdapter.ClearBeforeFill = true;
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
            // CommonRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.公共维修DataGridView);
            this.Controls.Add(维修编号Label);
            this.Controls.Add(this.维修编号TextBox);
            this.Controls.Add(财产编号Label);
            this.Controls.Add(this.财产编号TextBox);
            this.Controls.Add(财产名称Label);
            this.Controls.Add(this.财产名称ComboBox);
            this.Controls.Add(报修日期Label);
            this.Controls.Add(this.报修日期DateTimePicker);
            this.Controls.Add(报修人员Label);
            this.Controls.Add(this.报修人员TextBox);
            this.Controls.Add(故障现象Label);
            this.Controls.Add(this.故障现象TextBox);
            this.Controls.Add(受理人员Label);
            this.Controls.Add(this.受理人员TextBox);
            this.Controls.Add(处理意见Label);
            this.Controls.Add(this.处理意见TextBox);
            this.Controls.Add(修理日期Label);
            this.Controls.Add(this.修理日期DateTimePicker);
            this.Controls.Add(修理人员Label);
            this.Controls.Add(this.修理人员TextBox);
            this.Controls.Add(修理费用Label);
            this.Controls.Add(this.修理费用TextBox);
            this.Controls.Add(材料费用Label);
            this.Controls.Add(this.材料费用TextBox);
            this.Controls.Add(修理结果Label);
            this.Controls.Add(this.修理结果TextBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.公共维修BindingNavigator);
            this.Name = "CommonRepairForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "物业管理[公共维修管理]";
            this.Load += new System.EventHandler(this.CommonRepairForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.公共维修BindingNavigator)).EndInit();
            this.公共维修BindingNavigator.ResumeLayout(false);
            this.公共维修BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.公共维修BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCommunityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共维修DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCommunity.Data.DBCommunityDataSet dBCommunityDataSet;
        private System.Windows.Forms.BindingSource 公共维修BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.公共维修TableAdapter 公共维修TableAdapter;
        private System.Windows.Forms.BindingNavigator 公共维修BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton 公共维修BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 维修编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 维修编号ToolStripTextBox;
       // private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
        private System.Windows.Forms.TextBox 维修编号TextBox;
        private System.Windows.Forms.TextBox 财产编号TextBox;
        private System.Windows.Forms.ComboBox 财产名称ComboBox;
        private System.Windows.Forms.DateTimePicker 报修日期DateTimePicker;
        private System.Windows.Forms.TextBox 报修人员TextBox;
        private System.Windows.Forms.TextBox 故障现象TextBox;
        private System.Windows.Forms.TextBox 受理人员TextBox;
        private System.Windows.Forms.TextBox 处理意见TextBox;
        private System.Windows.Forms.DateTimePicker 修理日期DateTimePicker;
        private System.Windows.Forms.TextBox 修理人员TextBox;
        private System.Windows.Forms.TextBox 修理费用TextBox;
        private System.Windows.Forms.TextBox 材料费用TextBox;
        private System.Windows.Forms.TextBox 修理结果TextBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.DataGridView 公共维修DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 维修编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 财产编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 财产名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报修日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报修人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 故障现象DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 受理人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处理意见DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修理日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修理人员DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修理费用DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料费用DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修理结果DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 补充说明DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 公共财产BindingSource;
        private MyCommunity.Data.DBCommunityDataSetTableAdapters.公共财产TableAdapter 公共财产TableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}