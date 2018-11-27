namespace MyCommunity
{
    partial class OwnerForm
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
            System.Windows.Forms.Label 业主编号Label;
            System.Windows.Forms.Label 业主姓名Label;
            System.Windows.Forms.Label 身份证号码Label;
            System.Windows.Forms.Label 楼栋名称Label;
            System.Windows.Forms.Label 单元名称Label;
            System.Windows.Forms.Label 房号名称Label;
            System.Windows.Forms.Label 建筑面积Label;
            System.Windows.Forms.Label 联系电话Label;
            System.Windows.Forms.Label 入住日期Label;
            System.Windows.Forms.Label 当前状态Label;
            System.Windows.Forms.Label 补充说明Label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerForm));
            this.业主编号TextBox = new System.Windows.Forms.TextBox();
            this.业主姓名TextBox = new System.Windows.Forms.TextBox();
            this.楼栋名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.单元名称TextBox = new System.Windows.Forms.TextBox();
            this.房号名称TextBox = new System.Windows.Forms.TextBox();
            this.物业费用TextBox = new System.Windows.Forms.TextBox();
            this.联系电话TextBox = new System.Windows.Forms.TextBox();
            this.入住日期DateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.当前状态ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.业主信息DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.业主编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼栋名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单元名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房号名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物业费用 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预存金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入住日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.当前状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.补充说明 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小区名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.业主编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.业主信息BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.业主信息BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.小区名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.电表序列TextBox = new System.Windows.Forms.TextBox();
            this.电表序列Button = new DevComponents.DotNetBar.ButtonX();
            this.预存金额TextBox = new System.Windows.Forms.TextBox();
            业主编号Label = new System.Windows.Forms.Label();
            业主姓名Label = new System.Windows.Forms.Label();
            身份证号码Label = new System.Windows.Forms.Label();
            楼栋名称Label = new System.Windows.Forms.Label();
            单元名称Label = new System.Windows.Forms.Label();
            房号名称Label = new System.Windows.Forms.Label();
            建筑面积Label = new System.Windows.Forms.Label();
            联系电话Label = new System.Windows.Forms.Label();
            入住日期Label = new System.Windows.Forms.Label();
            当前状态Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.入住日期DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingNavigator)).BeginInit();
            this.业主信息BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // 业主编号Label
            // 
            业主编号Label.AutoSize = true;
            业主编号Label.Location = new System.Drawing.Point(9, 42);
            业主编号Label.Name = "业主编号Label";
            业主编号Label.Size = new System.Drawing.Size(58, 13);
            业主编号Label.TabIndex = 2;
            业主编号Label.Text = "业主编号:";
            // 
            // 业主姓名Label
            // 
            业主姓名Label.AutoSize = true;
            业主姓名Label.Location = new System.Drawing.Point(206, 41);
            业主姓名Label.Name = "业主姓名Label";
            业主姓名Label.Size = new System.Drawing.Size(58, 13);
            业主姓名Label.TabIndex = 4;
            业主姓名Label.Text = "业主姓名:";
            // 
            // 身份证号码Label
            // 
            身份证号码Label.AutoSize = true;
            身份证号码Label.Location = new System.Drawing.Point(333, 41);
            身份证号码Label.Name = "身份证号码Label";
            身份证号码Label.Size = new System.Drawing.Size(58, 13);
            身份证号码Label.TabIndex = 6;
            身份证号码Label.Text = "小区名称:";
            // 
            // 楼栋名称Label
            // 
            楼栋名称Label.AutoSize = true;
            楼栋名称Label.Location = new System.Drawing.Point(9, 75);
            楼栋名称Label.Name = "楼栋名称Label";
            楼栋名称Label.Size = new System.Drawing.Size(58, 13);
            楼栋名称Label.TabIndex = 8;
            楼栋名称Label.Text = "楼栋名称:";
            // 
            // 单元名称Label
            // 
            单元名称Label.AutoSize = true;
            单元名称Label.Location = new System.Drawing.Point(206, 75);
            单元名称Label.Name = "单元名称Label";
            单元名称Label.Size = new System.Drawing.Size(58, 13);
            单元名称Label.TabIndex = 10;
            单元名称Label.Text = "单元名称:";
            // 
            // 房号名称Label
            // 
            房号名称Label.AutoSize = true;
            房号名称Label.Location = new System.Drawing.Point(386, 75);
            房号名称Label.Name = "房号名称Label";
            房号名称Label.Size = new System.Drawing.Size(58, 13);
            房号名称Label.TabIndex = 12;
            房号名称Label.Text = "房号名称:";
            // 
            // 建筑面积Label
            // 
            建筑面积Label.AutoSize = true;
            建筑面积Label.Location = new System.Drawing.Point(304, 138);
            建筑面积Label.Name = "建筑面积Label";
            建筑面积Label.Size = new System.Drawing.Size(81, 13);
            建筑面积Label.TabIndex = 18;
            建筑面积Label.Text = "物业费(元/月):";
            // 
            // 联系电话Label
            // 
            联系电话Label.AutoSize = true;
            联系电话Label.Location = new System.Drawing.Point(9, 107);
            联系电话Label.Name = "联系电话Label";
            联系电话Label.Size = new System.Drawing.Size(58, 13);
            联系电话Label.TabIndex = 24;
            联系电话Label.Text = "联系电话:";
            // 
            // 入住日期Label
            // 
            入住日期Label.AutoSize = true;
            入住日期Label.Location = new System.Drawing.Point(206, 107);
            入住日期Label.Name = "入住日期Label";
            入住日期Label.Size = new System.Drawing.Size(58, 13);
            入住日期Label.TabIndex = 26;
            入住日期Label.Text = "入住日期:";
            // 
            // 当前状态Label
            // 
            当前状态Label.AutoSize = true;
            当前状态Label.Location = new System.Drawing.Point(386, 107);
            当前状态Label.Name = "当前状态Label";
            当前状态Label.Size = new System.Drawing.Size(58, 13);
            当前状态Label.TabIndex = 28;
            当前状态Label.Text = "当前状态:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(8, 170);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(58, 13);
            补充说明Label.TabIndex = 30;
            补充说明Label.Text = "补充说明:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 138);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 30;
            label1.Text = "电表序列:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(425, 136);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 13);
            label2.TabIndex = 12;
            label2.Text = "预存金额:";
            // 
            // 业主编号TextBox
            // 
            this.业主编号TextBox.Location = new System.Drawing.Point(69, 36);
            this.业主编号TextBox.Name = "业主编号TextBox";
            this.业主编号TextBox.Size = new System.Drawing.Size(132, 20);
            this.业主编号TextBox.TabIndex = 3;
            // 
            // 业主姓名TextBox
            // 
            this.业主姓名TextBox.Location = new System.Drawing.Point(270, 36);
            this.业主姓名TextBox.Name = "业主姓名TextBox";
            this.业主姓名TextBox.Size = new System.Drawing.Size(60, 20);
            this.业主姓名TextBox.TabIndex = 5;
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.楼栋名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(69, 68);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(130, 21);
            this.楼栋名称ComboBox.TabIndex = 9;
            // 
            // 单元名称TextBox
            // 
            this.单元名称TextBox.Location = new System.Drawing.Point(270, 68);
            this.单元名称TextBox.Name = "单元名称TextBox";
            this.单元名称TextBox.Size = new System.Drawing.Size(110, 20);
            this.单元名称TextBox.TabIndex = 11;
            // 
            // 房号名称TextBox
            // 
            this.房号名称TextBox.Location = new System.Drawing.Point(450, 68);
            this.房号名称TextBox.Name = "房号名称TextBox";
            this.房号名称TextBox.Size = new System.Drawing.Size(80, 20);
            this.房号名称TextBox.TabIndex = 13;
            // 
            // 物业费用TextBox
            // 
            this.物业费用TextBox.Location = new System.Drawing.Point(390, 133);
            this.物业费用TextBox.Name = "物业费用TextBox";
            this.物业费用TextBox.Size = new System.Drawing.Size(30, 20);
            this.物业费用TextBox.TabIndex = 19;
            // 
            // 联系电话TextBox
            // 
            this.联系电话TextBox.Location = new System.Drawing.Point(70, 102);
            this.联系电话TextBox.Name = "联系电话TextBox";
            this.联系电话TextBox.Size = new System.Drawing.Size(131, 20);
            this.联系电话TextBox.TabIndex = 25;
            // 
            // 入住日期DateTimePicker
            // 
            // 
            // 
            // 
            this.入住日期DateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.入住日期DateTimePicker.ButtonDropDown.Visible = true;
            this.入住日期DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.入住日期DateTimePicker.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.入住日期DateTimePicker.IsPopupCalendarOpen = false;
            this.入住日期DateTimePicker.Location = new System.Drawing.Point(270, 102);
            // 
            // 
            // 
            // 
            // 
            // 
            this.入住日期DateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.入住日期DateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.入住日期DateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.入住日期DateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.入住日期DateTimePicker.Name = "入住日期DateTimePicker";
            this.入住日期DateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.入住日期DateTimePicker.TabIndex = 27;
            this.入住日期DateTimePicker.Value = new System.DateTime(2018, 11, 19, 21, 12, 37, 0);
            // 
            // 当前状态ComboBox
            // 
            this.当前状态ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.当前状态ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.当前状态ComboBox.FormattingEnabled = true;
            this.当前状态ComboBox.Items.AddRange(new object[] {
            "已入住",
            "未入住",
            "迁出",
            "其它"});
            this.当前状态ComboBox.Location = new System.Drawing.Point(450, 102);
            this.当前状态ComboBox.Name = "当前状态ComboBox";
            this.当前状态ComboBox.Size = new System.Drawing.Size(79, 21);
            this.当前状态ComboBox.TabIndex = 29;
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Location = new System.Drawing.Point(69, 165);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(461, 20);
            this.补充说明TextBox.TabIndex = 31;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 业主信息DataGridView
            // 
            this.业主信息DataGridView.AllowUserToAddRows = false;
            this.业主信息DataGridView.AllowUserToDeleteRows = false;
            this.业主信息DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.业主信息DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.业主信息DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.业主信息DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.业主信息DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.业主编号,
            this.业主姓名,
            this.楼栋名称,
            this.单元名称,
            this.房号名称,
            this.物业费用,
            this.预存金额,
            this.联系电话,
            this.入住日期,
            this.当前状态,
            this.补充说明,
            this.小区名称});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.业主信息DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.业主信息DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.业主信息DataGridView.Location = new System.Drawing.Point(9, 191);
            this.业主信息DataGridView.MultiSelect = false;
            this.业主信息DataGridView.Name = "业主信息DataGridView";
            this.业主信息DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.业主信息DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.业主信息DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.业主信息DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.业主信息DataGridView.RowTemplate.Height = 23;
            this.业主信息DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.业主信息DataGridView.Size = new System.Drawing.Size(523, 249);
            this.业主信息DataGridView.TabIndex = 32;
            this.业主信息DataGridView.SelectionChanged += new System.EventHandler(this.业主信息DataGridView_SelectionChanged);
            // 
            // 业主编号
            // 
            this.业主编号.DataPropertyName = "业主编号";
            this.业主编号.HeaderText = "业主编号";
            this.业主编号.Name = "业主编号";
            this.业主编号.ReadOnly = true;
            // 
            // 业主姓名
            // 
            this.业主姓名.DataPropertyName = "业主姓名";
            this.业主姓名.HeaderText = "业主姓名";
            this.业主姓名.Name = "业主姓名";
            this.业主姓名.ReadOnly = true;
            // 
            // 楼栋名称
            // 
            this.楼栋名称.DataPropertyName = "楼栋名称";
            this.楼栋名称.HeaderText = "楼栋名称";
            this.楼栋名称.Name = "楼栋名称";
            this.楼栋名称.ReadOnly = true;
            // 
            // 单元名称
            // 
            this.单元名称.DataPropertyName = "单元名称";
            this.单元名称.HeaderText = "单元名称";
            this.单元名称.Name = "单元名称";
            this.单元名称.ReadOnly = true;
            // 
            // 房号名称
            // 
            this.房号名称.DataPropertyName = "房号名称";
            this.房号名称.HeaderText = "房号名称";
            this.房号名称.Name = "房号名称";
            this.房号名称.ReadOnly = true;
            // 
            // 物业费用
            // 
            this.物业费用.DataPropertyName = "物业费用";
            this.物业费用.HeaderText = "物业费用";
            this.物业费用.Name = "物业费用";
            this.物业费用.ReadOnly = true;
            // 
            // 预存金额
            // 
            this.预存金额.HeaderText = "预存金额";
            this.预存金额.Name = "预存金额";
            this.预存金额.ReadOnly = true;
            // 
            // 联系电话
            // 
            this.联系电话.DataPropertyName = "联系电话";
            this.联系电话.HeaderText = "联系电话";
            this.联系电话.Name = "联系电话";
            this.联系电话.ReadOnly = true;
            // 
            // 入住日期
            // 
            this.入住日期.DataPropertyName = "入住日期";
            this.入住日期.HeaderText = "入住日期";
            this.入住日期.Name = "入住日期";
            this.入住日期.ReadOnly = true;
            // 
            // 当前状态
            // 
            this.当前状态.DataPropertyName = "当前状态";
            this.当前状态.HeaderText = "当前状态";
            this.当前状态.Name = "当前状态";
            this.当前状态.ReadOnly = true;
            // 
            // 补充说明
            // 
            this.补充说明.DataPropertyName = "补充说明";
            this.补充说明.HeaderText = "补充说明";
            this.补充说明.Name = "补充说明";
            this.补充说明.ReadOnly = true;
            // 
            // 小区名称
            // 
            this.小区名称.HeaderText = "小区名称";
            this.小区名称.Name = "小区名称";
            this.小区名称.ReadOnly = true;
            // 
            // 业主编号ToolStripLabel
            // 
            this.业主编号ToolStripLabel.Name = "业主编号ToolStripLabel";
            this.业主编号ToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.业主编号ToolStripLabel.Text = "业主编号:";
            // 
            // 业主编号ToolStripTextBox
            // 
            this.业主编号ToolStripTextBox.Name = "业主编号ToolStripTextBox";
            this.业主编号ToolStripTextBox.Size = new System.Drawing.Size(60, 25);
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
            // 业主信息BindingNavigatorSaveItem
            // 
            this.业主信息BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("业主信息BindingNavigatorSaveItem.Image")));
            this.业主信息BindingNavigatorSaveItem.Name = "业主信息BindingNavigatorSaveItem";
            this.业主信息BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.业主信息BindingNavigatorSaveItem.Text = "保存";
            this.业主信息BindingNavigatorSaveItem.Click += new System.EventHandler(this.业主信息BindingNavigatorSaveItem_Click);
            // 
            // 业主信息BindingNavigator
            // 
            this.业主信息BindingNavigator.AddNewItem = null;
            this.业主信息BindingNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("业主信息BindingNavigator.BackgroundImage")));
            this.业主信息BindingNavigator.CountItem = null;
            this.业主信息BindingNavigator.DeleteItem = null;
            this.业主信息BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.业主编号ToolStripLabel,
            this.业主编号ToolStripTextBox,
            this.查询ToolStripButton,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.业主信息BindingNavigatorSaveItem});
            this.业主信息BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.业主信息BindingNavigator.MoveFirstItem = null;
            this.业主信息BindingNavigator.MoveLastItem = null;
            this.业主信息BindingNavigator.MoveNextItem = null;
            this.业主信息BindingNavigator.MovePreviousItem = null;
            this.业主信息BindingNavigator.Name = "业主信息BindingNavigator";
            this.业主信息BindingNavigator.PositionItem = null;
            this.业主信息BindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.业主信息BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.业主信息BindingNavigator.TabIndex = 0;
            this.业主信息BindingNavigator.Text = "bindingNavigator1";
            // 
            // 小区名称ComboBox
            // 
            this.小区名称ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.小区名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.小区名称ComboBox.FormattingEnabled = true;
            this.小区名称ComboBox.Location = new System.Drawing.Point(394, 36);
            this.小区名称ComboBox.Name = "小区名称ComboBox";
            this.小区名称ComboBox.Size = new System.Drawing.Size(137, 21);
            this.小区名称ComboBox.TabIndex = 33;
            this.小区名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.小区名称ComboBox_SelectedIndexChanged);
            // 
            // 电表序列TextBox
            // 
            this.电表序列TextBox.Enabled = false;
            this.电表序列TextBox.Location = new System.Drawing.Point(70, 133);
            this.电表序列TextBox.Name = "电表序列TextBox";
            this.电表序列TextBox.Size = new System.Drawing.Size(185, 20);
            this.电表序列TextBox.TabIndex = 34;
            // 
            // 电表序列Button
            // 
            this.电表序列Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.电表序列Button.Location = new System.Drawing.Point(260, 132);
            this.电表序列Button.Name = "电表序列Button";
            this.电表序列Button.Size = new System.Drawing.Size(38, 25);
            this.电表序列Button.TabIndex = 35;
            this.电表序列Button.Text = "设置";
            this.电表序列Button.Click += new System.EventHandler(this.电表序列Button_Click);
            // 
            // 预存金额TextBox
            // 
            this.预存金额TextBox.Location = new System.Drawing.Point(489, 133);
            this.预存金额TextBox.Name = "预存金额TextBox";
            this.预存金额TextBox.Size = new System.Drawing.Size(41, 20);
            this.预存金额TextBox.TabIndex = 5;
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.电表序列Button);
            this.Controls.Add(this.电表序列TextBox);
            this.Controls.Add(this.小区名称ComboBox);
            this.Controls.Add(this.业主信息DataGridView);
            this.Controls.Add(业主编号Label);
            this.Controls.Add(this.业主编号TextBox);
            this.Controls.Add(业主姓名Label);
            this.Controls.Add(this.预存金额TextBox);
            this.Controls.Add(this.业主姓名TextBox);
            this.Controls.Add(身份证号码Label);
            this.Controls.Add(楼栋名称Label);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(单元名称Label);
            this.Controls.Add(this.单元名称TextBox);
            this.Controls.Add(label2);
            this.Controls.Add(房号名称Label);
            this.Controls.Add(this.房号名称TextBox);
            this.Controls.Add(建筑面积Label);
            this.Controls.Add(this.物业费用TextBox);
            this.Controls.Add(联系电话Label);
            this.Controls.Add(this.联系电话TextBox);
            this.Controls.Add(入住日期Label);
            this.Controls.Add(this.入住日期DateTimePicker);
            this.Controls.Add(当前状态Label);
            this.Controls.Add(this.当前状态ComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.业主信息BindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OwnerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "基本管理[业主登记管理]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OwnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.入住日期DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.业主信息BindingNavigator)).EndInit();
            this.业主信息BindingNavigator.ResumeLayout(false);
            this.业主信息BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 业主编号TextBox;
        private System.Windows.Forms.TextBox 业主姓名TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 楼栋名称ComboBox;
        private System.Windows.Forms.TextBox 单元名称TextBox;
        private System.Windows.Forms.TextBox 房号名称TextBox;
        private System.Windows.Forms.TextBox 物业费用TextBox;
        private System.Windows.Forms.TextBox 联系电话TextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput 入住日期DateTimePicker;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 当前状态ComboBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX 业主信息DataGridView;
        private System.Windows.Forms.ToolStripLabel 业主编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 业主编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton 业主信息BindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator 业主信息BindingNavigator;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 小区名称ComboBox;
        private System.Windows.Forms.TextBox 电表序列TextBox;
        private DevComponents.DotNetBar.ButtonX 电表序列Button;
        private System.Windows.Forms.TextBox 预存金额TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业主姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼栋名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单元名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房号名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物业费用;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预存金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入住日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 当前状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 补充说明;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小区名称;

    }
}