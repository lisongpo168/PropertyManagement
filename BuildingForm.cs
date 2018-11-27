//文件名：BuildingForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MyCommunity.Common;
using System.Drawing.Printing;
namespace MyCommunity
{
    public partial class BuildingForm : DevComponents.DotNetBar.Office2007Form
    {
        private System.Data.DataTable dtData = null;
        private DataGridViewPrinter print = null;
        private string MyCommunity;
        private string MyPrintIcon;
        public BuildingForm(string myCommunity, string myPrintIcon)
        {
            this.MyCommunity = myCommunity;
            this.MyPrintIcon = myPrintIcon;
            InitializeComponent();
            InitCmbCommunity();
        }
        private void 楼栋信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (string.IsNullOrEmpty(this.楼栋名称TextBox.Text))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            try
            {
                string v_小区名称 = Helper.GetComBoxCtrlValue(this.Controls, "小区名称");
                string v_楼栋名称 = Helper.GetTextBoxCtrlValue(this.Controls, "楼栋名称");
                string v_单元信息 = Helper.GetTextBoxCtrlValue(this.Controls, "单元信息");
                string v_楼层信息 = Helper.GetTextBoxCtrlValue(this.Controls, "楼层信息");
                string totalHuStr = this.总户数TextBox.Text;
                string ruzhuHuStr = this.入住户数TextBox.Text;
                string memo = this.补充说明TextBox.Text;
                short totalHu = 0, ruzhuHu = 0;
                int kongHu = 0;
                Int16.TryParse(totalHuStr, out totalHu);
                Int16.TryParse(ruzhuHuStr, out ruzhuHu);
                if (ruzhuHu > totalHu)
                {
                    new MsgBoxForm("提示", "入住户数不能大于总户数！").ShowDialog();
                }
                kongHu = totalHu - ruzhuHu;
                string query = string.Empty;
                if (IsNewAdded(v_楼栋名称))
                {
                    query = string.Format("insert into 楼栋信息(`楼栋名称`, `小区名称`, `单元信息`, `楼层信息`, `总户数`, `入住户数`, `空置户数`, `补充说明`)values('{0}','{1}','{2}','{3}',{4},{5},{6},'{7}')", v_楼栋名称, v_小区名称, v_单元信息, v_楼层信息,
                    totalHu, ruzhuHu, kongHu, memo);
                }
                else
                {
                    query = string.Format("update 楼栋信息 set 小区名称='{0}',单元信息='{1}',楼层信息='{2}',总户数={3},入住户数={4},空置户数={5},补充说明='{6}' where 楼栋名称='{7}'", v_小区名称, v_单元信息, v_楼层信息,
                    totalHu, ruzhuHu, kongHu, memo, v_楼栋名称);
                }
                SaveNewBuilding(query);
                SynBuilding();
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {
                new MsgBoxForm("提示", "保存失败，请检查所填数据类型！").ShowDialog();
                LogHelper.LogError(ex);
            }
        }

        private void SaveNewBuilding(string query)
        {
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private bool IsNewAdded(string buildName)
        {
            string query = string.Format("select * from 楼栋信息 where 楼栋名称='{0}'", buildName);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void SynBuilding()
        {
            string query = "select * from 楼栋信息";
            dtData = DataHelper.GetDataTable(query);
            this.楼栋信息DataGridView.DataSource = dtData;
        }

        private void InitCmbCommunity()
        {
            string query = "select * from 小区信息";
            DataTable dt = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in dt.Rows)
            {
                this.小区名称ComboBox.Items.Add(dRow["小区名称"].ToString());
            }
            if (dt.Rows.Count > 0)
                this.小区名称ComboBox.SelectedIndex = 0;
        }

        private void BuildingForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中   
            SynBuilding();
        }
        private void 打印ToolStripButton_Click(object sender, EventArgs e)
        {//打印楼栋信息
            string title = this.小区名称ComboBox.Text + "楼栋信息表";
            //if (printDialog.ShowDialog() != DialogResult.OK)
            //    return;
            printDocument.DocumentName = title;
            printDocument.PrinterSettings = printDialog.PrinterSettings;
            printDocument.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
            printDocument.DefaultPageSettings.Margins = new Margins(10, 10, 20, 20);
            print = new DataGridViewPrinter(this.楼栋信息DataGridView, printDocument, title);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            printPreviewDialog.Icon = new Icon(this.MyPrintIcon);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void 楼栋信息DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<string> comboxColumns = new List<string>() { "小区名称" };
            DataGridViewRow currRow = this.楼栋信息DataGridView.CurrentRow;
            for (int i = 0; i < this.楼栋信息DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.楼栋信息DataGridView.Columns[i].DataPropertyName;
                string columnName = this.楼栋信息DataGridView.Columns[i].Name;
                string value = Helper.GetCellValue(currRow, columnName);
                if (!comboxColumns.Contains(ctrlName))
                    Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, value);
                else
                    Helper.SetComBoxCtrlValue(this.Controls, ctrlName, value);
            }
            if (currRow != null)
                this.bindingNavigatorDeleteItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string v_小区名称 = this.小区名称ComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称TextBox.Text.Trim();
            if (string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            } 

            if (new MsgBoxForm("警告", "确定要删除该楼幢信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 楼栋信息 where 楼栋名称='{0}' and 小区名称='{1}'", v_楼栋名称, v_小区名称);
                SaveNewBuilding(query);
                SynBuilding();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                bool more = print.DrawDataGridView(e.Graphics);
                if (more == true)
                    e.HasMorePages = true;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            List<string> comboxColumns = new List<string>() { "小区名称" };
            for (int i = 0; i < this.楼栋信息DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.楼栋信息DataGridView.Columns[i].DataPropertyName;
                string value = string.Empty;
                if (!comboxColumns.Contains(ctrlName))
                    Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, value);
                else
                    Helper.SetComBoxCtrlValue(this.Controls, ctrlName, value);
            }
            this.补充说明TextBox.Text = "暂无";
        }     
    }
}