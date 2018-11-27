namespace MyCommunity
{
    partial class MoveForm
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
            System.Windows.Forms.Label 迁出日期Label;
            System.Windows.Forms.Label 迁出原因Label;
            System.Windows.Forms.Label 补充说明Label;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.迁出信息BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.业主编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.业主编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.迁出信息BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.业主编号TextBox = new System.Windows.Forms.TextBox();
            this.业主姓名ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.迁出日期DateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.迁出原因TextBox = new System.Windows.Forms.TextBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.楼栋名称Label = new System.Windows.Forms.Label();
            this.楼栋名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.迁出信息DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.小区名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            业主编号Label = new System.Windows.Forms.Label();
            业主姓名Label = new System.Windows.Forms.Label();
            迁出日期Label = new System.Windows.Forms.Label();
            迁出原因Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.迁出信息BindingNavigator)).BeginInit();
            this.迁出信息BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.迁出日期DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.迁出信息DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 业主编号Label
            // 
            业主编号Label.AutoSize = true;
            业主编号Label.Location = new System.Drawing.Point(496, 34);
            业主编号Label.Name = "业主编号Label";
            业主编号Label.Size = new System.Drawing.Size(58, 13);
            业主编号Label.TabIndex = 2;
            业主编号Label.Text = "业主编号:";
            // 
            // 业主姓名Label
            // 
            业主姓名Label.AutoSize = true;
            业主姓名Label.Location = new System.Drawing.Point(366, 34);
            业主姓名Label.Name = "业主姓名Label";
            业主姓名Label.Size = new System.Drawing.Size(58, 13);
            业主姓名Label.TabIndex = 4;
            业主姓名Label.Text = "业主姓名:";
            // 
            // 迁出日期Label
            // 
            迁出日期Label.AutoSize = true;
            迁出日期Label.Location = new System.Drawing.Point(7, 62);
            迁出日期Label.Name = "迁出日期Label";
            迁出日期Label.Size = new System.Drawing.Size(58, 13);
            迁出日期Label.TabIndex = 6;
            迁出日期Label.Text = "迁出日期:";
            // 
            // 迁出原因Label
            // 
            迁出原因Label.AutoSize = true;
            迁出原因Label.Location = new System.Drawing.Point(191, 62);
            迁出原因Label.Name = "迁出原因Label";
            迁出原因Label.Size = new System.Drawing.Size(58, 13);
            迁出原因Label.TabIndex = 8;
            迁出原因Label.Text = "迁出原因:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(7, 90);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(58, 13);
            补充说明Label.TabIndex = 10;
            补充说明Label.Text = "补充说明:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 6;
            label1.Text = "小区名称:";
            // 
            // 迁出信息BindingNavigator
            // 
            this.迁出信息BindingNavigator.AddNewItem = null;
            this.迁出信息BindingNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("迁出信息BindingNavigator.BackgroundImage")));
            this.迁出信息BindingNavigator.CountItem = null;
            this.迁出信息BindingNavigator.DeleteItem = null;
            this.迁出信息BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.业主编号ToolStripLabel,
            this.业主编号ToolStripTextBox,
            this.查询ToolStripButton,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.迁出信息BindingNavigatorSaveItem});
            this.迁出信息BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.迁出信息BindingNavigator.MoveFirstItem = null;
            this.迁出信息BindingNavigator.MoveLastItem = null;
            this.迁出信息BindingNavigator.MoveNextItem = null;
            this.迁出信息BindingNavigator.MovePreviousItem = null;
            this.迁出信息BindingNavigator.Name = "迁出信息BindingNavigator";
            this.迁出信息BindingNavigator.PositionItem = null;
            this.迁出信息BindingNavigator.Size = new System.Drawing.Size(638, 25);
            this.迁出信息BindingNavigator.TabIndex = 0;
            this.迁出信息BindingNavigator.Text = "bindingNavigator1";
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
            // 迁出信息BindingNavigatorSaveItem
            // 
            this.迁出信息BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("迁出信息BindingNavigatorSaveItem.Image")));
            this.迁出信息BindingNavigatorSaveItem.Name = "迁出信息BindingNavigatorSaveItem";
            this.迁出信息BindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.迁出信息BindingNavigatorSaveItem.Text = "保存";
            this.迁出信息BindingNavigatorSaveItem.Click += new System.EventHandler(this.迁出信息BindingNavigatorSaveItem_Click);
            // 
            // 业主编号TextBox
            // 
            this.业主编号TextBox.Location = new System.Drawing.Point(557, 29);
            this.业主编号TextBox.Name = "业主编号TextBox";
            this.业主编号TextBox.ReadOnly = true;
            this.业主编号TextBox.Size = new System.Drawing.Size(72, 20);
            this.业主编号TextBox.TabIndex = 3;
            // 
            // 业主姓名ComboBox
            // 
            this.业主姓名ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.业主姓名ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.业主姓名ComboBox.FormattingEnabled = true;
            this.业主姓名ComboBox.Location = new System.Drawing.Point(428, 30);
            this.业主姓名ComboBox.Name = "业主姓名ComboBox";
            this.业主姓名ComboBox.Size = new System.Drawing.Size(68, 21);
            this.业主姓名ComboBox.TabIndex = 5;
            this.业主姓名ComboBox.SelectedIndexChanged += new System.EventHandler(this.业主姓名ComboBox_SelectedIndexChanged);
            // 
            // 迁出日期DateTimePicker
            // 
            // 
            // 
            // 
            this.迁出日期DateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.迁出日期DateTimePicker.ButtonDropDown.Visible = true;
            this.迁出日期DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.迁出日期DateTimePicker.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.迁出日期DateTimePicker.IsPopupCalendarOpen = false;
            this.迁出日期DateTimePicker.Location = new System.Drawing.Point(70, 57);
            // 
            // 
            // 
            // 
            // 
            // 
            this.迁出日期DateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.迁出日期DateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.迁出日期DateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.迁出日期DateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.迁出日期DateTimePicker.Name = "迁出日期DateTimePicker";
            this.迁出日期DateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.迁出日期DateTimePicker.TabIndex = 7;
            this.迁出日期DateTimePicker.Value = new System.DateTime(2018, 11, 19, 21, 48, 3, 0);
            // 
            // 迁出原因TextBox
            // 
            this.迁出原因TextBox.Location = new System.Drawing.Point(254, 57);
            this.迁出原因TextBox.Name = "迁出原因TextBox";
            this.迁出原因TextBox.Size = new System.Drawing.Size(375, 20);
            this.迁出原因TextBox.TabIndex = 9;
            this.迁出原因TextBox.Text = "售房";
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Location = new System.Drawing.Point(70, 86);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(559, 20);
            this.补充说明TextBox.TabIndex = 11;
            this.补充说明TextBox.Text = "暂无";
            // 
            // 楼栋名称Label
            // 
            this.楼栋名称Label.AutoSize = true;
            this.楼栋名称Label.Location = new System.Drawing.Point(191, 34);
            this.楼栋名称Label.Name = "楼栋名称Label";
            this.楼栋名称Label.Size = new System.Drawing.Size(58, 13);
            this.楼栋名称Label.TabIndex = 12;
            this.楼栋名称Label.Text = "楼栋名称:";
            // 
            // 楼栋名称ComboBox
            // 
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.楼栋名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.楼栋名称ComboBox.FormattingEnabled = true;
            this.楼栋名称ComboBox.Location = new System.Drawing.Point(252, 30);
            this.楼栋名称ComboBox.Name = "楼栋名称ComboBox";
            this.楼栋名称ComboBox.Size = new System.Drawing.Size(112, 21);
            this.楼栋名称ComboBox.TabIndex = 13;
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
            this.楼栋名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.楼栋名称ComboBox_SelectedIndexChanged);
            // 
            // 迁出信息DataGridView
            // 
            this.迁出信息DataGridView.AllowUserToAddRows = false;
            this.迁出信息DataGridView.AllowUserToDeleteRows = false;
            this.迁出信息DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.迁出信息DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.迁出信息DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.迁出信息DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.迁出信息DataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.迁出信息DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.迁出信息DataGridView.Location = new System.Drawing.Point(10, 117);
            this.迁出信息DataGridView.MultiSelect = false;
            this.迁出信息DataGridView.Name = "迁出信息DataGridView";
            this.迁出信息DataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.迁出信息DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.迁出信息DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Green;
            this.迁出信息DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.迁出信息DataGridView.RowTemplate.Height = 23;
            this.迁出信息DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.迁出信息DataGridView.Size = new System.Drawing.Size(619, 323);
            this.迁出信息DataGridView.TabIndex = 33;
            this.迁出信息DataGridView.SelectionChanged += new System.EventHandler(this.迁出信息DataGridView_SelectionChanged);
            // 
            // 小区名称ComboBox
            // 
            this.小区名称ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.小区名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.小区名称ComboBox.FormattingEnabled = true;
            this.小区名称ComboBox.Location = new System.Drawing.Point(70, 30);
            this.小区名称ComboBox.Name = "小区名称ComboBox";
            this.小区名称ComboBox.Size = new System.Drawing.Size(119, 21);
            this.小区名称ComboBox.TabIndex = 34;
            this.小区名称ComboBox.SelectedIndexChanged += new System.EventHandler(this.小区名称ComboBox_SelectedIndexChanged);
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(638, 451);
            this.Controls.Add(this.小区名称ComboBox);
            this.Controls.Add(this.迁出信息DataGridView);
            this.Controls.Add(this.楼栋名称ComboBox);
            this.Controls.Add(this.楼栋名称Label);
            this.Controls.Add(业主编号Label);
            this.Controls.Add(this.业主编号TextBox);
            this.Controls.Add(业主姓名Label);
            this.Controls.Add(this.业主姓名ComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(迁出日期Label);
            this.Controls.Add(this.迁出日期DateTimePicker);
            this.Controls.Add(迁出原因Label);
            this.Controls.Add(this.迁出原因TextBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.迁出信息BindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoveForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "基本管理[业主迁出管理]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MoveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.迁出信息BindingNavigator)).EndInit();
            this.迁出信息BindingNavigator.ResumeLayout(false);
            this.迁出信息BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.迁出日期DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.迁出信息DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator 迁出信息BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton 迁出信息BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 业主编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 业主编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.TextBox 业主编号TextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 业主姓名ComboBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput 迁出日期DateTimePicker;
        private System.Windows.Forms.TextBox 迁出原因TextBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private System.Windows.Forms.Label 楼栋名称Label;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 楼栋名称ComboBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX 迁出信息DataGridView;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 小区名称ComboBox;
    }
}