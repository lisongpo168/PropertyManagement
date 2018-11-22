namespace MyCommunity
{
    partial class CommonPropertyForm
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
            System.Windows.Forms.Label 财产编号Label;
            System.Windows.Forms.Label 财产名称Label;
            System.Windows.Forms.Label 规格型号Label;
            System.Windows.Forms.Label 所属类别Label;
            System.Windows.Forms.Label 财产原值Label;
            System.Windows.Forms.Label 启用日期Label;
            System.Windows.Forms.Label 存放位置Label;
            System.Windows.Forms.Label 当前状态Label;
            System.Windows.Forms.Label 保管人员Label;
            System.Windows.Forms.Label 补充说明Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonPropertyForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.公共财产BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.公共财产BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.财产编号TextBox = new System.Windows.Forms.TextBox();
            this.财产名称TextBox = new System.Windows.Forms.TextBox();
            this.规格型号TextBox = new System.Windows.Forms.TextBox();
            this.所属类别ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.财产原值TextBox = new System.Windows.Forms.TextBox();
            this.启用日期DateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.存放位置TextBox = new System.Windows.Forms.TextBox();
            this.当前状态ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.保管人员TextBox = new System.Windows.Forms.TextBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.公共财产DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            财产编号Label = new System.Windows.Forms.Label();
            财产名称Label = new System.Windows.Forms.Label();
            规格型号Label = new System.Windows.Forms.Label();
            所属类别Label = new System.Windows.Forms.Label();
            财产原值Label = new System.Windows.Forms.Label();
            启用日期Label = new System.Windows.Forms.Label();
            存放位置Label = new System.Windows.Forms.Label();
            当前状态Label = new System.Windows.Forms.Label();
            保管人员Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产BindingNavigator)).BeginInit();
            this.公共财产BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.启用日期DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 财产编号Label
            // 
            财产编号Label.AutoSize = true;
            财产编号Label.Location = new System.Drawing.Point(7, 39);
            财产编号Label.Name = "财产编号Label";
            财产编号Label.Size = new System.Drawing.Size(58, 13);
            财产编号Label.TabIndex = 2;
            财产编号Label.Text = "财产编号:";
            // 
            // 财产名称Label
            // 
            财产名称Label.AutoSize = true;
            财产名称Label.Location = new System.Drawing.Point(165, 39);
            财产名称Label.Name = "财产名称Label";
            财产名称Label.Size = new System.Drawing.Size(58, 13);
            财产名称Label.TabIndex = 4;
            财产名称Label.Text = "财产名称:";
            // 
            // 规格型号Label
            // 
            规格型号Label.AutoSize = true;
            规格型号Label.Location = new System.Drawing.Point(361, 39);
            规格型号Label.Name = "规格型号Label";
            规格型号Label.Size = new System.Drawing.Size(58, 13);
            规格型号Label.TabIndex = 6;
            规格型号Label.Text = "规格型号:";
            // 
            // 所属类别Label
            // 
            所属类别Label.AutoSize = true;
            所属类别Label.Location = new System.Drawing.Point(6, 64);
            所属类别Label.Name = "所属类别Label";
            所属类别Label.Size = new System.Drawing.Size(58, 13);
            所属类别Label.TabIndex = 8;
            所属类别Label.Text = "所属类别:";
            // 
            // 财产原值Label
            // 
            财产原值Label.AutoSize = true;
            财产原值Label.Location = new System.Drawing.Point(165, 65);
            财产原值Label.Name = "财产原值Label";
            财产原值Label.Size = new System.Drawing.Size(76, 13);
            财产原值Label.TabIndex = 10;
            财产原值Label.Text = "财产原值(元):";
            // 
            // 启用日期Label
            // 
            启用日期Label.AutoSize = true;
            启用日期Label.Location = new System.Drawing.Point(361, 65);
            启用日期Label.Name = "启用日期Label";
            启用日期Label.Size = new System.Drawing.Size(58, 13);
            启用日期Label.TabIndex = 12;
            启用日期Label.Text = "启用日期:";
            // 
            // 存放位置Label
            // 
            存放位置Label.AutoSize = true;
            存放位置Label.Location = new System.Drawing.Point(5, 89);
            存放位置Label.Name = "存放位置Label";
            存放位置Label.Size = new System.Drawing.Size(58, 13);
            存放位置Label.TabIndex = 14;
            存放位置Label.Text = "存放位置:";
            // 
            // 当前状态Label
            // 
            当前状态Label.AutoSize = true;
            当前状态Label.Location = new System.Drawing.Point(185, 89);
            当前状态Label.Name = "当前状态Label";
            当前状态Label.Size = new System.Drawing.Size(58, 13);
            当前状态Label.TabIndex = 16;
            当前状态Label.Text = "当前状态:";
            // 
            // 保管人员Label
            // 
            保管人员Label.AutoSize = true;
            保管人员Label.Location = new System.Drawing.Point(361, 89);
            保管人员Label.Name = "保管人员Label";
            保管人员Label.Size = new System.Drawing.Size(58, 13);
            保管人员Label.TabIndex = 18;
            保管人员Label.Text = "保管人员:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(5, 114);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(58, 13);
            补充说明Label.TabIndex = 20;
            补充说明Label.Text = "补充说明:";
            // 
            // 公共财产BindingNavigator
            // 
            this.公共财产BindingNavigator.AddNewItem = null;
            this.公共财产BindingNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("公共财产BindingNavigator.BackgroundImage")));
            this.公共财产BindingNavigator.CountItem = null;
            this.公共财产BindingNavigator.DeleteItem = null;
            this.公共财产BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.公共财产BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.公共财产BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.公共财产BindingNavigator.MoveFirstItem = null;
            this.公共财产BindingNavigator.MoveLastItem = null;
            this.公共财产BindingNavigator.MoveNextItem = null;
            this.公共财产BindingNavigator.MovePreviousItem = null;
            this.公共财产BindingNavigator.Name = "公共财产BindingNavigator";
            this.公共财产BindingNavigator.PositionItem = null;
            this.公共财产BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.公共财产BindingNavigator.TabIndex = 0;
            this.公共财产BindingNavigator.Text = "bindingNavigator1";
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
            // 公共财产BindingNavigatorSaveItem
            // 
            this.公共财产BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("公共财产BindingNavigatorSaveItem.Image")));
            this.公共财产BindingNavigatorSaveItem.Name = "公共财产BindingNavigatorSaveItem";
            this.公共财产BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.公共财产BindingNavigatorSaveItem.Text = "保存";
            this.公共财产BindingNavigatorSaveItem.Click += new System.EventHandler(this.公共财产BindingNavigatorSaveItem_Click);
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
            // 财产编号TextBox
            // 
            this.财产编号TextBox.Enabled = false;
            this.财产编号TextBox.Location = new System.Drawing.Point(69, 33);
            this.财产编号TextBox.Name = "财产编号TextBox";
            this.财产编号TextBox.ReadOnly = true;
            this.财产编号TextBox.Size = new System.Drawing.Size(87, 20);
            this.财产编号TextBox.TabIndex = 3;
            // 
            // 财产名称TextBox
            // 
            this.财产名称TextBox.Location = new System.Drawing.Point(230, 33);
            this.财产名称TextBox.Name = "财产名称TextBox";
            this.财产名称TextBox.Size = new System.Drawing.Size(125, 20);
            this.财产名称TextBox.TabIndex = 5;
            // 
            // 规格型号TextBox
            // 
            this.规格型号TextBox.Location = new System.Drawing.Point(423, 33);
            this.规格型号TextBox.Name = "规格型号TextBox";
            this.规格型号TextBox.Size = new System.Drawing.Size(107, 20);
            this.规格型号TextBox.TabIndex = 7;
            // 
            // 所属类别ComboBox
            // 
            this.所属类别ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.所属类别ComboBox.Items.AddRange(new object[] {
            "公共设施",
            "物业办公",
            "其它"});
            this.所属类别ComboBox.Location = new System.Drawing.Point(69, 59);
            this.所属类别ComboBox.Name = "所属类别ComboBox";
            this.所属类别ComboBox.Size = new System.Drawing.Size(87, 21);
            this.所属类别ComboBox.TabIndex = 9;
            // 
            // 财产原值TextBox
            // 
            this.财产原值TextBox.Location = new System.Drawing.Point(248, 59);
            this.财产原值TextBox.Name = "财产原值TextBox";
            this.财产原值TextBox.Size = new System.Drawing.Size(107, 20);
            this.财产原值TextBox.TabIndex = 11;
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
            this.启用日期DateTimePicker.Location = new System.Drawing.Point(423, 59);
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
            this.启用日期DateTimePicker.Size = new System.Drawing.Size(107, 20);
            this.启用日期DateTimePicker.TabIndex = 13;
            this.启用日期DateTimePicker.Value = new System.DateTime(2018, 11, 20, 23, 30, 53, 0);
            // 
            // 存放位置TextBox
            // 
            this.存放位置TextBox.Location = new System.Drawing.Point(69, 85);
            this.存放位置TextBox.Name = "存放位置TextBox";
            this.存放位置TextBox.Size = new System.Drawing.Size(112, 20);
            this.存放位置TextBox.TabIndex = 15;
            // 
            // 当前状态ComboBox
            // 
            this.当前状态ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.当前状态ComboBox.Items.AddRange(new object[] {
            "在使用",
            "未使用",
            "其它"});
            this.当前状态ComboBox.Location = new System.Drawing.Point(248, 85);
            this.当前状态ComboBox.Name = "当前状态ComboBox";
            this.当前状态ComboBox.Size = new System.Drawing.Size(107, 21);
            this.当前状态ComboBox.TabIndex = 17;
            // 
            // 保管人员TextBox
            // 
            this.保管人员TextBox.Location = new System.Drawing.Point(423, 85);
            this.保管人员TextBox.Name = "保管人员TextBox";
            this.保管人员TextBox.Size = new System.Drawing.Size(107, 20);
            this.保管人员TextBox.TabIndex = 19;
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Location = new System.Drawing.Point(70, 112);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(460, 20);
            this.补充说明TextBox.TabIndex = 21;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 公共财产DataGridView
            // 
            this.公共财产DataGridView.AllowUserToAddRows = false;
            this.公共财产DataGridView.AllowUserToDeleteRows = false;
            this.公共财产DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.公共财产DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.公共财产DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共财产DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.公共财产DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.公共财产DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.公共财产DataGridView.Location = new System.Drawing.Point(9, 141);
            this.公共财产DataGridView.MultiSelect = false;
            this.公共财产DataGridView.Name = "公共财产DataGridView";
            this.公共财产DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.公共财产DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.公共财产DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.公共财产DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.公共财产DataGridView.RowTemplate.Height = 23;
            this.公共财产DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.公共财产DataGridView.Size = new System.Drawing.Size(523, 299);
            this.公共财产DataGridView.TabIndex = 25;
            this.公共财产DataGridView.SelectionChanged += new System.EventHandler(this.公共财产DataGridView_SelectionChanged);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // CommonPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.公共财产DataGridView);
            this.Controls.Add(财产编号Label);
            this.Controls.Add(this.财产编号TextBox);
            this.Controls.Add(财产名称Label);
            this.Controls.Add(this.财产名称TextBox);
            this.Controls.Add(规格型号Label);
            this.Controls.Add(this.规格型号TextBox);
            this.Controls.Add(所属类别Label);
            this.Controls.Add(this.所属类别ComboBox);
            this.Controls.Add(财产原值Label);
            this.Controls.Add(this.财产原值TextBox);
            this.Controls.Add(启用日期Label);
            this.Controls.Add(this.启用日期DateTimePicker);
            this.Controls.Add(存放位置Label);
            this.Controls.Add(this.存放位置TextBox);
            this.Controls.Add(当前状态Label);
            this.Controls.Add(this.当前状态ComboBox);
            this.Controls.Add(保管人员Label);
            this.Controls.Add(this.保管人员TextBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.公共财产BindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CommonPropertyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "基本管理[公共财产管理]";
            this.Load += new System.EventHandler(this.CommonPropertyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.公共财产BindingNavigator)).EndInit();
            this.公共财产BindingNavigator.ResumeLayout(false);
            this.公共财产BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.启用日期DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公共财产DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator 公共财产BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton 公共财产BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 财产编号TextBox;
        private System.Windows.Forms.TextBox 财产名称TextBox;
        private System.Windows.Forms.TextBox 规格型号TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 所属类别ComboBox;
        private System.Windows.Forms.TextBox 财产原值TextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput 启用日期DateTimePicker;
        private System.Windows.Forms.TextBox 存放位置TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 当前状态ComboBox;
        private System.Windows.Forms.TextBox 保管人员TextBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX 公共财产DataGridView;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;


    }
}