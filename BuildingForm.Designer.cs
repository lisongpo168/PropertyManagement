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
            System.Windows.Forms.Label 单元信息Label;
            System.Windows.Forms.Label 楼层信息Label;
            System.Windows.Forms.Label 总户数Label;
            System.Windows.Forms.Label 入住户数Label;
            System.Windows.Forms.Label 补充说明Label;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildingForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.楼栋信息BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.楼栋信息BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.打印ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.楼栋名称TextBox = new System.Windows.Forms.TextBox();
            this.单元信息TextBox = new System.Windows.Forms.TextBox();
            this.楼层信息TextBox = new System.Windows.Forms.TextBox();
            this.总户数TextBox = new System.Windows.Forms.TextBox();
            this.入住户数TextBox = new System.Windows.Forms.TextBox();
            this.补充说明TextBox = new System.Windows.Forms.TextBox();
            this.楼栋信息DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.小区名称ComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            楼栋名称Label = new System.Windows.Forms.Label();
            单元信息Label = new System.Windows.Forms.Label();
            楼层信息Label = new System.Windows.Forms.Label();
            总户数Label = new System.Windows.Forms.Label();
            入住户数Label = new System.Windows.Forms.Label();
            补充说明Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingNavigator)).BeginInit();
            this.楼栋信息BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 楼栋名称Label
            // 
            楼栋名称Label.AutoSize = true;
            楼栋名称Label.Location = new System.Drawing.Point(225, 38);
            楼栋名称Label.Name = "楼栋名称Label";
            楼栋名称Label.Size = new System.Drawing.Size(58, 13);
            楼栋名称Label.TabIndex = 2;
            楼栋名称Label.Text = "楼栋名称:";
            // 
            // 单元信息Label
            // 
            单元信息Label.AutoSize = true;
            单元信息Label.Location = new System.Drawing.Point(158, 68);
            单元信息Label.Name = "单元信息Label";
            单元信息Label.Size = new System.Drawing.Size(58, 13);
            单元信息Label.TabIndex = 6;
            单元信息Label.Text = "单元信息:";
            // 
            // 楼层信息Label
            // 
            楼层信息Label.AutoSize = true;
            楼层信息Label.Location = new System.Drawing.Point(8, 68);
            楼层信息Label.Name = "楼层信息Label";
            楼层信息Label.Size = new System.Drawing.Size(58, 13);
            楼层信息Label.TabIndex = 8;
            楼层信息Label.Text = "楼层信息:";
            // 
            // 总户数Label
            // 
            总户数Label.AutoSize = true;
            总户数Label.Location = new System.Drawing.Point(328, 68);
            总户数Label.Name = "总户数Label";
            总户数Label.Size = new System.Drawing.Size(46, 13);
            总户数Label.TabIndex = 12;
            总户数Label.Text = "总户数:";
            // 
            // 入住户数Label
            // 
            入住户数Label.AutoSize = true;
            入住户数Label.Location = new System.Drawing.Point(429, 68);
            入住户数Label.Name = "入住户数Label";
            入住户数Label.Size = new System.Drawing.Size(58, 13);
            入住户数Label.TabIndex = 14;
            入住户数Label.Text = "入住户数:";
            // 
            // 补充说明Label
            // 
            补充说明Label.AutoSize = true;
            补充说明Label.Location = new System.Drawing.Point(8, 98);
            补充说明Label.Name = "补充说明Label";
            补充说明Label.Size = new System.Drawing.Size(58, 13);
            补充说明Label.TabIndex = 22;
            补充说明Label.Text = "补充说明:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 8;
            label1.Text = "小区名称:";
            // 
            // 楼栋信息BindingNavigator
            // 
            this.楼栋信息BindingNavigator.AddNewItem = null;
            this.楼栋信息BindingNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("楼栋信息BindingNavigator.BackgroundImage")));
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
            this.楼栋名称TextBox.Location = new System.Drawing.Point(285, 33);
            this.楼栋名称TextBox.Name = "楼栋名称TextBox";
            this.楼栋名称TextBox.Size = new System.Drawing.Size(247, 20);
            this.楼栋名称TextBox.TabIndex = 3;
            // 
            // 单元信息TextBox
            // 
            this.单元信息TextBox.Location = new System.Drawing.Point(220, 63);
            this.单元信息TextBox.Name = "单元信息TextBox";
            this.单元信息TextBox.Size = new System.Drawing.Size(97, 20);
            this.单元信息TextBox.TabIndex = 7;
            // 
            // 楼层信息TextBox
            // 
            this.楼层信息TextBox.Location = new System.Drawing.Point(69, 63);
            this.楼层信息TextBox.Name = "楼层信息TextBox";
            this.楼层信息TextBox.Size = new System.Drawing.Size(83, 20);
            this.楼层信息TextBox.TabIndex = 9;
            // 
            // 总户数TextBox
            // 
            this.总户数TextBox.Location = new System.Drawing.Point(377, 63);
            this.总户数TextBox.Name = "总户数TextBox";
            this.总户数TextBox.Size = new System.Drawing.Size(45, 20);
            this.总户数TextBox.TabIndex = 13;
            // 
            // 入住户数TextBox
            // 
            this.入住户数TextBox.Location = new System.Drawing.Point(491, 63);
            this.入住户数TextBox.Name = "入住户数TextBox";
            this.入住户数TextBox.Size = new System.Drawing.Size(40, 20);
            this.入住户数TextBox.TabIndex = 15;
            // 
            // 补充说明TextBox
            // 
            this.补充说明TextBox.Location = new System.Drawing.Point(69, 93);
            this.补充说明TextBox.Name = "补充说明TextBox";
            this.补充说明TextBox.Size = new System.Drawing.Size(461, 20);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.楼栋信息DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.楼栋信息DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.楼栋信息DataGridView.Location = new System.Drawing.Point(9, 127);
            this.楼栋信息DataGridView.MultiSelect = false;
            this.楼栋信息DataGridView.Name = "楼栋信息DataGridView";
            this.楼栋信息DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.楼栋信息DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.楼栋信息DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.楼栋信息DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.楼栋信息DataGridView.RowTemplate.Height = 23;
            this.楼栋信息DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.楼栋信息DataGridView.Size = new System.Drawing.Size(523, 313);
            this.楼栋信息DataGridView.TabIndex = 24;
            this.楼栋信息DataGridView.SelectionChanged += new System.EventHandler(this.楼栋信息DataGridView_SelectionChanged);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // 小区名称ComboBox
            // 
            this.小区名称ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.小区名称ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.小区名称ComboBox.FormattingEnabled = true;
            this.小区名称ComboBox.Location = new System.Drawing.Point(69, 33);
            this.小区名称ComboBox.Name = "小区名称ComboBox";
            this.小区名称ComboBox.Size = new System.Drawing.Size(148, 21);
            this.小区名称ComboBox.TabIndex = 25;
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.小区名称ComboBox);
            this.Controls.Add(this.楼栋信息DataGridView);
            this.Controls.Add(楼栋名称Label);
            this.Controls.Add(this.楼栋名称TextBox);
            this.Controls.Add(单元信息Label);
            this.Controls.Add(this.单元信息TextBox);
            this.Controls.Add(label1);
            this.Controls.Add(楼层信息Label);
            this.Controls.Add(this.楼层信息TextBox);
            this.Controls.Add(总户数Label);
            this.Controls.Add(this.总户数TextBox);
            this.Controls.Add(入住户数Label);
            this.Controls.Add(this.入住户数TextBox);
            this.Controls.Add(补充说明Label);
            this.Controls.Add(this.补充说明TextBox);
            this.Controls.Add(this.楼栋信息BindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuildingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "基本管理[楼栋信息管理]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BuildingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息BindingNavigator)).EndInit();
            this.楼栋信息BindingNavigator.ResumeLayout(false);
            this.楼栋信息BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.楼栋信息DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator 楼栋信息BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton 楼栋信息BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 楼栋名称TextBox;
        private System.Windows.Forms.TextBox 单元信息TextBox;
        private System.Windows.Forms.TextBox 楼层信息TextBox;
        private System.Windows.Forms.TextBox 总户数TextBox;
        private System.Windows.Forms.TextBox 入住户数TextBox;
        private System.Windows.Forms.TextBox 补充说明TextBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX 楼栋信息DataGridView;
        private System.Windows.Forms.ToolStripButton 打印ToolStripButton;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private DevComponents.DotNetBar.Controls.ComboBoxEx 小区名称ComboBox;



    }
}