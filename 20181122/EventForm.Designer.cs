namespace MyCommunity
{
    partial class EventForm
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
            System.Windows.Forms.Label 事件编号Label;
            System.Windows.Forms.Label 发生日期Label;
            System.Windows.Forms.Label 处理人员Label;
            System.Windows.Forms.Label 事件主题Label;
            System.Windows.Forms.Label 事件内容Label;
            System.Windows.Forms.Label 处理结果Label;
            System.Windows.Forms.Label 补充说明Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.突发事件BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.事件编号ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.事件编号ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.突发事件BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.事件编号TextBox = new System.Windows.Forms.TextBox();
            this.发生日期DateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.处理人员TextBox = new System.Windows.Forms.TextBox();
            this.事件主题TextBox = new System.Windows.Forms.TextBox();
            this.事件内容TextBox = new System.Windows.Forms.TextBox();
            this.处理结果TextBox = new System.Windows.Forms.TextBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.突发事件DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            事件编号Label = new System.Windows.Forms.Label();
            发生日期Label = new System.Windows.Forms.Label();
            处理人员Label = new System.Windows.Forms.Label();
            事件主题Label = new System.Windows.Forms.Label();
            事件内容Label = new System.Windows.Forms.Label();
            处理结果Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.突发事件BindingNavigator)).BeginInit();
            this.突发事件BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.发生日期DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.突发事件DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 事件编号Label
            // 
            事件编号Label.AutoSize = true;
            事件编号Label.Location = new System.Drawing.Point(7, 32);
            事件编号Label.Name = "事件编号Label";
            事件编号Label.Size = new System.Drawing.Size(59, 12);
            事件编号Label.TabIndex = 2;
            事件编号Label.Text = "事件编号:";
            // 
            // 发生日期Label
            // 
            发生日期Label.AutoSize = true;
            发生日期Label.Location = new System.Drawing.Point(203, 32);
            发生日期Label.Name = "发生日期Label";
            发生日期Label.Size = new System.Drawing.Size(59, 12);
            发生日期Label.TabIndex = 4;
            发生日期Label.Text = "发生日期:";
            // 
            // 处理人员Label
            // 
            处理人员Label.AutoSize = true;
            处理人员Label.Location = new System.Drawing.Point(395, 32);
            处理人员Label.Name = "处理人员Label";
            处理人员Label.Size = new System.Drawing.Size(59, 12);
            处理人员Label.TabIndex = 6;
            处理人员Label.Text = "处理人员:";
            // 
            // 事件主题Label
            // 
            事件主题Label.AutoSize = true;
            事件主题Label.Location = new System.Drawing.Point(7, 57);
            事件主题Label.Name = "事件主题Label";
            事件主题Label.Size = new System.Drawing.Size(59, 12);
            事件主题Label.TabIndex = 8;
            事件主题Label.Text = "事件主题:";
            // 
            // 事件内容Label
            // 
            事件内容Label.AutoSize = true;
            事件内容Label.Location = new System.Drawing.Point(7, 82);
            事件内容Label.Name = "事件内容Label";
            事件内容Label.Size = new System.Drawing.Size(59, 12);
            事件内容Label.TabIndex = 10;
            事件内容Label.Text = "事件内容:";
            // 
            // 处理结果Label
            // 
            处理结果Label.AutoSize = true;
            处理结果Label.Location = new System.Drawing.Point(7, 107);
            处理结果Label.Name = "处理结果Label";
            处理结果Label.Size = new System.Drawing.Size(59, 12);
            处理结果Label.TabIndex = 12;
            处理结果Label.Text = "处理结果:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(7, 132);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(59, 12);
            补充说明Label.TabIndex = 14;
            补充说明Label.Text = "补充说明:";
            // 
            // 突发事件BindingNavigator
            // 
            this.突发事件BindingNavigator.AddNewItem = null;
            this.突发事件BindingNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("突发事件BindingNavigator.BackgroundImage")));
            this.突发事件BindingNavigator.CountItem = null;
            this.突发事件BindingNavigator.DeleteItem = null;
            this.突发事件BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.事件编号ToolStripLabel,
            this.事件编号ToolStripTextBox,
            this.查询ToolStripButton,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.突发事件BindingNavigatorSaveItem,
            this.打印ToolStripButton});
            this.突发事件BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.突发事件BindingNavigator.MoveFirstItem = null;
            this.突发事件BindingNavigator.MoveLastItem = null;
            this.突发事件BindingNavigator.MoveNextItem = null;
            this.突发事件BindingNavigator.MovePreviousItem = null;
            this.突发事件BindingNavigator.Name = "突发事件BindingNavigator";
            this.突发事件BindingNavigator.PositionItem = null;
            this.突发事件BindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.突发事件BindingNavigator.TabIndex = 0;
            this.突发事件BindingNavigator.Text = "bindingNavigator1";
            // 
            // 事件编号ToolStripLabel
            // 
            this.事件编号ToolStripLabel.Name = "事件编号ToolStripLabel";
            this.事件编号ToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.事件编号ToolStripLabel.Text = "事件编号:";
            // 
            // 事件编号ToolStripTextBox
            // 
            this.事件编号ToolStripTextBox.Name = "事件编号ToolStripTextBox";
            this.事件编号ToolStripTextBox.Size = new System.Drawing.Size(50, 25);
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
            // 突发事件BindingNavigatorSaveItem
            // 
            this.突发事件BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("突发事件BindingNavigatorSaveItem.Image")));
            this.突发事件BindingNavigatorSaveItem.Name = "突发事件BindingNavigatorSaveItem";
            this.突发事件BindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 22);
            this.突发事件BindingNavigatorSaveItem.Text = "保存";
            this.突发事件BindingNavigatorSaveItem.Click += new System.EventHandler(this.突发事件BindingNavigatorSaveItem_Click);
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
            // 事件编号TextBox
            // 
            this.事件编号TextBox.Enabled = false;
            this.事件编号TextBox.Location = new System.Drawing.Point(67, 28);
            this.事件编号TextBox.Name = "事件编号TextBox";
            this.事件编号TextBox.ReadOnly = true;
            this.事件编号TextBox.Size = new System.Drawing.Size(133, 21);
            this.事件编号TextBox.TabIndex = 3;
            // 
            // 发生日期DateTimePicker
            // 
            // 
            // 
            // 
            this.发生日期DateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.发生日期DateTimePicker.ButtonDropDown.Visible = true;
            this.发生日期DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.发生日期DateTimePicker.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.发生日期DateTimePicker.IsPopupCalendarOpen = false;
            this.发生日期DateTimePicker.Location = new System.Drawing.Point(262, 28);
            // 
            // 
            // 
            // 
            // 
            // 
            this.发生日期DateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.发生日期DateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.发生日期DateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.发生日期DateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.发生日期DateTimePicker.Name = "发生日期DateTimePicker";
            this.发生日期DateTimePicker.Size = new System.Drawing.Size(129, 21);
            this.发生日期DateTimePicker.TabIndex = 5;
            this.发生日期DateTimePicker.Value = new System.DateTime(2018, 11, 20, 23, 35, 6, 0);
            // 
            // 处理人员TextBox
            // 
            this.处理人员TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.处理人员TextBox.Location = new System.Drawing.Point(455, 28);
            this.处理人员TextBox.Name = "处理人员TextBox";
            this.处理人员TextBox.Size = new System.Drawing.Size(78, 21);
            this.处理人员TextBox.TabIndex = 7;
            // 
            // 事件主题TextBox
            // 
            this.事件主题TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.事件主题TextBox.Location = new System.Drawing.Point(67, 53);
            this.事件主题TextBox.Name = "事件主题TextBox";
            this.事件主题TextBox.Size = new System.Drawing.Size(466, 21);
            this.事件主题TextBox.TabIndex = 9;
            // 
            // 事件内容TextBox
            // 
            this.事件内容TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.事件内容TextBox.Location = new System.Drawing.Point(67, 77);
            this.事件内容TextBox.Name = "事件内容TextBox";
            this.事件内容TextBox.Size = new System.Drawing.Size(466, 21);
            this.事件内容TextBox.TabIndex = 11;
            // 
            // 处理结果TextBox
            // 
            this.处理结果TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.处理结果TextBox.Location = new System.Drawing.Point(67, 101);
            this.处理结果TextBox.Name = "处理结果TextBox";
            this.处理结果TextBox.Size = new System.Drawing.Size(466, 21);
            this.处理结果TextBox.TabIndex = 13;
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.补充说明TextBox.Location = new System.Drawing.Point(67, 126);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(466, 21);
            this.补充说明TextBox.TabIndex = 15;
            // 
            // 突发事件DataGridView
            // 
            this.突发事件DataGridView.AllowUserToAddRows = false;
            this.突发事件DataGridView.AllowUserToDeleteRows = false;
            this.突发事件DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.突发事件DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.突发事件DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.突发事件DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.突发事件DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.突发事件DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.突发事件DataGridView.Location = new System.Drawing.Point(8, 156);
            this.突发事件DataGridView.MultiSelect = false;
            this.突发事件DataGridView.Name = "突发事件DataGridView";
            this.突发事件DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.突发事件DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.突发事件DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.突发事件DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.突发事件DataGridView.RowTemplate.Height = 23;
            this.突发事件DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.突发事件DataGridView.Size = new System.Drawing.Size(526, 251);
            this.突发事件DataGridView.TabIndex = 37;
            this.突发事件DataGridView.SelectionChanged += new System.EventHandler(this.突发事件DataGridView_SelectionChanged);
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
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(542, 416);
            this.Controls.Add(this.突发事件DataGridView);
            this.Controls.Add(事件编号Label);
            this.Controls.Add(this.事件编号TextBox);
            this.Controls.Add(发生日期Label);
            this.Controls.Add(this.发生日期DateTimePicker);
            this.Controls.Add(处理人员Label);
            this.Controls.Add(this.处理人员TextBox);
            this.Controls.Add(事件主题Label);
            this.Controls.Add(this.事件主题TextBox);
            this.Controls.Add(事件内容Label);
            this.Controls.Add(this.事件内容TextBox);
            this.Controls.Add(处理结果Label);
            this.Controls.Add(this.处理结果TextBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.突发事件BindingNavigator);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "物业管理[突发事件管理]";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.突发事件BindingNavigator)).EndInit();
            this.突发事件BindingNavigator.ResumeLayout(false);
            this.突发事件BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.发生日期DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.突发事件DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator 突发事件BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton 突发事件BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel 事件编号ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 事件编号ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 查询ToolStripButton;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
        private System.Windows.Forms.TextBox 事件编号TextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput 发生日期DateTimePicker;
        private System.Windows.Forms.TextBox 处理人员TextBox;
        private System.Windows.Forms.TextBox 事件主题TextBox;
        private System.Windows.Forms.TextBox 事件内容TextBox;
        private System.Windows.Forms.TextBox 处理结果TextBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX 突发事件DataGridView;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}