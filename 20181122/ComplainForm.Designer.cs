namespace MyCommunity
{
    partial class ComplainForm
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
            System.Windows.Forms.Label 投诉编号Label;
            System.Windows.Forms.Label 楼栋名称Label;
            System.Windows.Forms.Label 业主编号Label;
            System.Windows.Forms.Label 业主姓名Label;
            System.Windows.Forms.Label 投诉日期Label;
            System.Windows.Forms.Label 接待人员Label;
            System.Windows.Forms.Label 投诉主题Label;
            System.Windows.Forms.Label 投诉内容Label;
            System.Windows.Forms.Label 处理日期Label;
            System.Windows.Forms.Label 处理人员Label;
            System.Windows.Forms.Label 处理意见Label;
            System.Windows.Forms.Label 处理结果Label;
            System.Windows.Forms.Label 业主反馈Label;
            System.Windows.Forms.Label 补充说明Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.服务投诉BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.投诉编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.投诉编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.服务投诉BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.投诉编号TextBox = new System.Windows.Forms.TextBox();
            this.楼栋名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.业主编号TextBox = new System.Windows.Forms.TextBox();
            this.业主姓名ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.投诉日期DateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.接待人员TextBox = new System.Windows.Forms.TextBox();
            this.投诉主题TextBox = new System.Windows.Forms.TextBox();
            this.投诉内容TextBox = new System.Windows.Forms.TextBox();
            this.处理日期DateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.处理人员TextBox = new System.Windows.Forms.TextBox();
            this.处理意见TextBox = new System.Windows.Forms.TextBox();
            this.处理结果TextBox = new System.Windows.Forms.TextBox();
            this.业主反馈TextBox = new System.Windows.Forms.TextBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.服务投诉DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            投诉编号Label = new System.Windows.Forms.Label();
            楼栋名称Label = new System.Windows.Forms.Label();
            业主编号Label = new System.Windows.Forms.Label();
            业主姓名Label = new System.Windows.Forms.Label();
            投诉日期Label = new System.Windows.Forms.Label();
            接待人员Label = new System.Windows.Forms.Label();
            投诉主题Label = new System.Windows.Forms.Label();
            投诉内容Label = new System.Windows.Forms.Label();
            处理日期Label = new System.Windows.Forms.Label();
            处理人员Label = new System.Windows.Forms.Label();
            处理意见Label = new System.Windows.Forms.Label();
            处理结果Label = new System.Windows.Forms.Label();
            业主反馈Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.服务投诉BindingNavigator)).BeginInit();
            this.服务投诉BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.投诉日期DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.处理日期DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务投诉DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 投诉编号Label
            // 
            投诉编号Label.AutoSize = true;
            投诉编号Label.Location = new System.Drawing.Point(8, 32);
            投诉编号Label.Name = "投诉编号Label";
            投诉编号Label.Size = new System.Drawing.Size(59, 12);
            投诉编号Label.TabIndex = 2;
            投诉编号Label.Text = "投诉编号:";
            // 
            // 楼栋名称Label
            // 
            楼栋名称Label.AutoSize = true;
            楼栋名称Label.Location = new System.Drawing.Point(137, 32);
            楼栋名称Label.Name = "楼栋名称Label";
            楼栋名称Label.Size = new System.Drawing.Size(59, 12);
            楼栋名称Label.TabIndex = 4;
            楼栋名称Label.Text = "楼栋名称:";
            // 
            // 业主编号Label
            // 
            业主编号Label.AutoSize = true;
            业主编号Label.Location = new System.Drawing.Point(297, 32);
            业主编号Label.Name = "业主编号Label";
            业主编号Label.Size = new System.Drawing.Size(59, 12);
            业主编号Label.TabIndex = 6;
            业主编号Label.Text = "业主编号:";
            // 
            // 业主姓名Label
            // 
            业主姓名Label.AutoSize = true;
            业主姓名Label.Location = new System.Drawing.Point(405, 32);
            业主姓名Label.Name = "业主姓名Label";
            业主姓名Label.Size = new System.Drawing.Size(59, 12);
            业主姓名Label.TabIndex = 8;
            业主姓名Label.Text = "业主姓名:";
            // 
            // 投诉日期Label
            // 
            投诉日期Label.AutoSize = true;
            投诉日期Label.Location = new System.Drawing.Point(9, 57);
            投诉日期Label.Name = "投诉日期Label";
            投诉日期Label.Size = new System.Drawing.Size(59, 12);
            投诉日期Label.TabIndex = 10;
            投诉日期Label.Text = "投诉日期:";
            // 
            // 接待人员Label
            // 
            接待人员Label.AutoSize = true;
            接待人员Label.Location = new System.Drawing.Point(184, 57);
            接待人员Label.Name = "接待人员Label";
            接待人员Label.Size = new System.Drawing.Size(59, 12);
            接待人员Label.TabIndex = 12;
            接待人员Label.Text = "接待人员:";
            // 
            // 投诉主题Label
            // 
            投诉主题Label.AutoSize = true;
            投诉主题Label.Location = new System.Drawing.Point(307, 57);
            投诉主题Label.Name = "投诉主题Label";
            投诉主题Label.Size = new System.Drawing.Size(59, 12);
            投诉主题Label.TabIndex = 14;
            投诉主题Label.Text = "投诉主题:";
            // 
            // 投诉内容Label
            // 
            投诉内容Label.AutoSize = true;
            投诉内容Label.Location = new System.Drawing.Point(9, 80);
            投诉内容Label.Name = "投诉内容Label";
            投诉内容Label.Size = new System.Drawing.Size(59, 12);
            投诉内容Label.TabIndex = 16;
            投诉内容Label.Text = "投诉内容:";
            // 
            // 处理日期Label
            // 
            处理日期Label.AutoSize = true;
            处理日期Label.Location = new System.Drawing.Point(9, 105);
            处理日期Label.Name = "处理日期Label";
            处理日期Label.Size = new System.Drawing.Size(59, 12);
            处理日期Label.TabIndex = 18;
            处理日期Label.Text = "处理日期:";
            // 
            // 处理人员Label
            // 
            处理人员Label.AutoSize = true;
            处理人员Label.Location = new System.Drawing.Point(184, 101);
            处理人员Label.Name = "处理人员Label";
            处理人员Label.Size = new System.Drawing.Size(59, 12);
            处理人员Label.TabIndex = 20;
            处理人员Label.Text = "处理人员:";
            // 
            // 处理意见Label
            // 
            处理意见Label.AutoSize = true;
            处理意见Label.Location = new System.Drawing.Point(9, 129);
            处理意见Label.Name = "处理意见Label";
            处理意见Label.Size = new System.Drawing.Size(59, 12);
            处理意见Label.TabIndex = 22;
            处理意见Label.Text = "处理意见:";
            // 
            // 处理结果Label
            // 
            处理结果Label.AutoSize = true;
            处理结果Label.Location = new System.Drawing.Point(8, 153);
            处理结果Label.Name = "处理结果Label";
            处理结果Label.Size = new System.Drawing.Size(59, 12);
            处理结果Label.TabIndex = 24;
            处理结果Label.Text = "处理结果:";
            // 
            // 业主反馈Label
            // 
            业主反馈Label.AutoSize = true;
            业主反馈Label.Location = new System.Drawing.Point(8, 178);
            业主反馈Label.Name = "业主反馈Label";
            业主反馈Label.Size = new System.Drawing.Size(59, 12);
            业主反馈Label.TabIndex = 26;
            业主反馈Label.Text = "业主反馈:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(8, 203);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(59, 12);
            补充说明Label.TabIndex = 28;
            补充说明Label.Text = "补充说明:";
            // 
            // 服务投诉BindingNavigator
            // 
            this.服务投诉BindingNavigator.AddNewItem = null;
            this.服务投诉BindingNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("服务投诉BindingNavigator.BackgroundImage")));
            this.服务投诉BindingNavigator.CountItem = null;
            this.服务投诉BindingNavigator.DeleteItem = null;
            this.服务投诉BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.投诉编号ToolStripLabel,
            this.投诉编号ToolStripTextBox,
            this.查询ToolStripButton,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.服务投诉BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.服务投诉BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.服务投诉BindingNavigator.MoveFirstItem = null;
            this.服务投诉BindingNavigator.MoveLastItem = null;
            this.服务投诉BindingNavigator.MoveNextItem = null;
            this.服务投诉BindingNavigator.MovePreviousItem = null;
            this.服务投诉BindingNavigator.Name = "服务投诉BindingNavigator";
            this.服务投诉BindingNavigator.PositionItem = null;
            this.服务投诉BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.服务投诉BindingNavigator.TabIndex = 0;
            this.服务投诉BindingNavigator.Text = "bindingNavigator1";
            // 
            // 投诉编号ToolStripLabel
            // 
            this.投诉编号ToolStripLabel.Name = "投诉编号ToolStripLabel";
            this.投诉编号ToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.投诉编号ToolStripLabel.Text = "投诉编号:";
            // 
            // 投诉编号ToolStripTextBox
            // 
            this.投诉编号ToolStripTextBox.Name = "投诉编号ToolStripTextBox";
            this.投诉编号ToolStripTextBox.Size = new System.Drawing.Size(50, 25);
            // 
            // 查询ToolStripButton
            // 
            this.查询ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("查询ToolStripButton.Image")));
            this.查询ToolStripButton.Name = "查询ToolStripButton";
            this.查询ToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.查询ToolStripButton.Text = "查询";
            this.查询ToolStripButton.Click += new System.EventHandler(this.查询ToolStripButton_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 22);
            this.bindingNavigatorAddNewItem.Text = "新增";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // 服务投诉BindingNavigatorSaveItem
            // 
            this.服务投诉BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("服务投诉BindingNavigatorSaveItem.Image")));
            this.服务投诉BindingNavigatorSaveItem.Name = "服务投诉BindingNavigatorSaveItem";
            this.服务投诉BindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 22);
            this.服务投诉BindingNavigatorSaveItem.Text = "保存";
            this.服务投诉BindingNavigatorSaveItem.Click += new System.EventHandler(this.服务投诉BindingNavigatorSaveItem_Click);
            // 
            // 打印ToolStripButton
            // 
            this.打印ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打印ToolStripButton.Image")));
            this.打印ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印ToolStripButton.Name = "打印ToolStripButton";
            this.打印ToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.打印ToolStripButton.Text = "打印";
            this.打印ToolStripButton.Click += new System.EventHandler(this.打印ToolStripButton_Click);
            // 
            // 投诉编号TextBox
            // 
            this.投诉编号TextBox.Enabled = false;
            this.投诉编号TextBox.Location = new System.Drawing.Point(69, 27);
            this.投诉编号TextBox.Name = "投诉编号TextBox";
            this.投诉编号TextBox.ReadOnly = true;
            this.投诉编号TextBox.Size = new System.Drawing.Size(65, 21);
            this.投诉编号TextBox.TabIndex = 3;
            this.投诉编号TextBox.Text = "自动生成";
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(200, 28);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(90, 20);
            this.楼栋名称ComboBox.TabIndex = 5;
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 业主编号TextBox
            // 
            this.业主编号TextBox.Location = new System.Drawing.Point(356, 27);
            this.业主编号TextBox.Name = "业主编号TextBox";
            this.业主编号TextBox.ReadOnly = true;
            this.业主编号TextBox.Size = new System.Drawing.Size(45, 21);
            this.业主编号TextBox.TabIndex = 7;
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.业主姓名ComboBox.DisplayMember = "业主编号";
            this.业主姓名ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(464, 28);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(71, 20);
            this.业主姓名ComboBox.TabIndex = 9;
            this.业主姓名ComboBox.ValueMember = "业主编号";
            this.业主姓名ComboBox.SelectedIndexChanged += new System.EventHandler(this.业主姓名ComboBox_SelectedIndexChanged);
            // 
            // 投诉日期DateTimePicker
            // 
            // 
            // 
            // 
            this.投诉日期DateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.投诉日期DateTimePicker.ButtonDropDown.Visible = true;
            this.投诉日期DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.投诉日期DateTimePicker.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.投诉日期DateTimePicker.IsPopupCalendarOpen = false;
            this.投诉日期DateTimePicker.Location = new System.Drawing.Point(69, 52);
            // 
            // 
            // 
            // 
            // 
            // 
            this.投诉日期DateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.投诉日期DateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.投诉日期DateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.投诉日期DateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.投诉日期DateTimePicker.Name = "投诉日期DateTimePicker";
            this.投诉日期DateTimePicker.Size = new System.Drawing.Size(112, 21);
            this.投诉日期DateTimePicker.TabIndex = 11;
            this.投诉日期DateTimePicker.Value = new System.DateTime(2018, 11, 19, 22, 39, 44, 0);
            // 
            // 接待人员TextBox
            // 
            this.接待人员TextBox.Location = new System.Drawing.Point(243, 52);
            this.接待人员TextBox.Name = "接待人员TextBox";
            this.接待人员TextBox.Size = new System.Drawing.Size(59, 21);
            this.接待人员TextBox.TabIndex = 13;
            // 
            // 投诉主题TextBox
            // 
            this.投诉主题TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.投诉主题TextBox.Location = new System.Drawing.Point(369, 52);
            this.投诉主题TextBox.Name = "投诉主题TextBox";
            this.投诉主题TextBox.Size = new System.Drawing.Size(166, 21);
            this.投诉主题TextBox.TabIndex = 15;
            // 
            // 投诉内容TextBox
            // 
            this.投诉内容TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.投诉内容TextBox.Location = new System.Drawing.Point(69, 76);
            this.投诉内容TextBox.Name = "投诉内容TextBox";
            this.投诉内容TextBox.Size = new System.Drawing.Size(466, 21);
            this.投诉内容TextBox.TabIndex = 17;
            // 
            // 处理日期DateTimePicker
            // 
            // 
            // 
            // 
            this.处理日期DateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.处理日期DateTimePicker.ButtonDropDown.Visible = true;
            this.处理日期DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.处理日期DateTimePicker.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.处理日期DateTimePicker.IsPopupCalendarOpen = false;
            this.处理日期DateTimePicker.Location = new System.Drawing.Point(69, 101);
            // 
            // 
            // 
            // 
            // 
            // 
            this.处理日期DateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.处理日期DateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.处理日期DateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.处理日期DateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.处理日期DateTimePicker.Name = "处理日期DateTimePicker";
            this.处理日期DateTimePicker.Size = new System.Drawing.Size(112, 21);
            this.处理日期DateTimePicker.TabIndex = 19;
            this.处理日期DateTimePicker.Value = new System.DateTime(2018, 11, 19, 22, 38, 56, 0);
            // 
            // 处理人员TextBox
            // 
            this.处理人员TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.处理人员TextBox.Location = new System.Drawing.Point(243, 101);
            this.处理人员TextBox.Name = "处理人员TextBox";
            this.处理人员TextBox.Size = new System.Drawing.Size(292, 21);
            this.处理人员TextBox.TabIndex = 21;
            // 
            // 处理意见TextBox
            // 
            this.处理意见TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.处理意见TextBox.Location = new System.Drawing.Point(69, 125);
            this.处理意见TextBox.Name = "处理意见TextBox";
            this.处理意见TextBox.Size = new System.Drawing.Size(466, 21);
            this.处理意见TextBox.TabIndex = 23;
            // 
            // 处理结果TextBox
            // 
            this.处理结果TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.处理结果TextBox.Location = new System.Drawing.Point(69, 150);
            this.处理结果TextBox.Name = "处理结果TextBox";
            this.处理结果TextBox.Size = new System.Drawing.Size(466, 21);
            this.处理结果TextBox.TabIndex = 25;
            // 
            // 业主反馈TextBox
            // 
            this.业主反馈TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.业主反馈TextBox.Location = new System.Drawing.Point(69, 175);
            this.业主反馈TextBox.Name = "业主反馈TextBox";
            this.业主反馈TextBox.Size = new System.Drawing.Size(466, 21);
            this.业主反馈TextBox.TabIndex = 27;
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.补充说明TextBox.Location = new System.Drawing.Point(69, 200);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(466, 21);
            this.补充说明TextBox.TabIndex = 29;
            // 
            // 服务投诉DataGridView
            // 
            this.服务投诉DataGridView.AllowUserToAddRows = false;
            this.服务投诉DataGridView.AllowUserToDeleteRows = false;
            this.服务投诉DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.服务投诉DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.服务投诉DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.服务投诉DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.服务投诉DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.服务投诉DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.服务投诉DataGridView.Location = new System.Drawing.Point(8, 230);
            this.服务投诉DataGridView.MultiSelect = false;
            this.服务投诉DataGridView.Name = "服务投诉DataGridView";
            this.服务投诉DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.服务投诉DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.服务投诉DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.服务投诉DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.服务投诉DataGridView.RowTemplate.Height = 23;
            this.服务投诉DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.服务投诉DataGridView.Size = new System.Drawing.Size(526, 177);
            this.服务投诉DataGridView.TabIndex = 36;
            this.服务投诉DataGridView.SelectionChanged += new System.EventHandler(this.服务投诉DataGridView_SelectionChanged);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ComplainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(542, 416);
            this.Controls.Add(this.服务投诉DataGridView);
            this.Controls.Add(投诉编号Label);
            this.Controls.Add(this.投诉编号TextBox);
            this.Controls.Add(楼栋名称Label);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(业主编号Label);
            this.Controls.Add(this.业主编号TextBox);
            this.Controls.Add(业主姓名Label);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(投诉日期Label);
            this.Controls.Add(this.投诉日期DateTimePicker);
            this.Controls.Add(接待人员Label);
            this.Controls.Add(this.接待人员TextBox);
            this.Controls.Add(投诉主题Label);
            this.Controls.Add(this.投诉主题TextBox);
            this.Controls.Add(投诉内容Label);
            this.Controls.Add(this.投诉内容TextBox);
            this.Controls.Add(处理日期Label);
            this.Controls.Add(this.处理日期DateTimePicker);
            this.Controls.Add(处理人员Label);
            this.Controls.Add(this.处理人员TextBox);
            this.Controls.Add(处理意见Label);
            this.Controls.Add(this.处理意见TextBox);
            this.Controls.Add(处理结果Label);
            this.Controls.Add(this.处理结果TextBox);
            this.Controls.Add(业主反馈Label);
            this.Controls.Add(this.业主反馈TextBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.服务投诉BindingNavigator);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComplainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "物业管理[服务投诉管理]";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.ComplainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.服务投诉BindingNavigator)).EndInit();
            this.服务投诉BindingNavigator.ResumeLayout(false);
            this.服务投诉BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.投诉日期DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.处理日期DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.服务投诉DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator 服务投诉BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton 服务投诉BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 投诉编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 投诉编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
        private System.Windows.Forms.TextBox 投诉编号TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 楼栋名称ComboBox;
        private System.Windows.Forms.TextBox 业主编号TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 业主姓名ComboBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput 投诉日期DateTimePicker;
        private System.Windows.Forms.TextBox 接待人员TextBox;
        private System.Windows.Forms.TextBox 投诉主题TextBox;
        private System.Windows.Forms.TextBox 投诉内容TextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput 处理日期DateTimePicker;
        private System.Windows.Forms.TextBox 处理人员TextBox;
        private System.Windows.Forms.TextBox 处理意见TextBox;
        private System.Windows.Forms.TextBox 处理结果TextBox;
        private System.Windows.Forms.TextBox 业主反馈TextBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX 服务投诉DataGridView;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}