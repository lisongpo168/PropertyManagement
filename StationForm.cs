//文件名：StationForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using Microsoft.Office.Interop.Excel;
using System.Reflection;
using Microsoft.Office.Core;
using MyCommunity.Common;
using System.Drawing.Printing;
namespace MyCommunity
{
    public partial class StationForm : Form
    {
        private System.Data.DataTable dtData = null;
        private DataGridViewPrinter print = null;
        public StationForm()
        {
            InitializeComponent();
            InitCmbBuilding();
        }
        public string MyCommunity;
        private void StationForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
            SynStation();
            
        }
        private void 车位使用BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (string.IsNullOrEmpty(this.车位编号TextBox.Text))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            try
            {
                string v_车位编号 = Helper.GetTextBoxCtrlValue(this.Controls, "车位编号");
                string v_车位面积 = Helper.GetTextBoxCtrlValue(this.Controls, "车位面积");
                string v_楼栋名称 = Helper.GetComBoxCtrlValue(this.Controls, "楼栋名称");
                string v_业主编号 = Helper.GetTextBoxCtrlValue(this.Controls, "业主编号");
                string v_业主姓名 = Helper.GetComBoxCtrlValue(this.Controls, "业主姓名");
                string v_启用日期 = Helper.GetDateCtrlValue(this.Controls, "启用日期");
                string v_停用日期 = Helper.GetDateCtrlValue(this.Controls, "停用日期");
                string v_费用金额 = Helper.GetTextBoxCtrlValue(this.Controls, "费用金额");
                string v_管理人员 = Helper.GetTextBoxCtrlValue(this.Controls, "管理人员");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");
                string query = string.Empty;
                if (IsNewAdded(v_车位编号))
                {
                    query = string.Format("insert into 车位使用(`车位编号`, `车位面积`,`楼栋名称`, `业主编号`, `业主姓名`, `启用日期`, `停用日期`, `费用金额`, `管理人员`,`补充说明`)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                        v_车位编号, v_车位面积, v_楼栋名称, v_业主编号, v_业主姓名, v_启用日期, v_停用日期, v_费用金额, v_管理人员, v_补充说明);
                }
                else
                {
                    query = string.Format("update 车位使用 set 车位面积='{0}',楼栋名称='{1}',业主编号='{2}',业主姓名='{3}',启用日期='{4}',停用日期='{5}',费用金额='{6}',管理人员='{7}',补充说明='{8}' where 车位编号='{9}'",
                        v_车位面积, v_楼栋名称, v_业主编号, v_业主姓名, v_启用日期, v_停用日期, v_费用金额, v_管理人员, v_补充说明, v_车位编号);
                }
                SaveNewStation(query);
                SynStation();
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }     
        private void 查询ToolStripButton_Click(object sender, EventArgs e)
        {
            SynStation();
        }

        private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {//获取指定楼栋的业主姓名
            string buildName = this.楼栋名称ComboBox.Text;
            if (!string.IsNullOrEmpty(buildName))
            {
                string query = string.Format("SELECT * FROM 业主信息 WHERE (业主编号 NOT IN (SELECT 业主编号 FROM 迁出信息)) AND (楼栋名称='{0}')", buildName);
                System.Data.DataTable dt = DataHelper.GetDataTable(query);
                this.业主姓名ComboBox.DataSource = dt;
                this.业主姓名ComboBox.DisplayMember = "业主姓名";
                this.业主姓名ComboBox.ValueMember = "业主编号";
            }
        }

        private void 业主姓名ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {//获取指定业主的编号
            if (this.业主姓名ComboBox.SelectedValue != null && this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                this.业主编号TextBox.Text = this.业主姓名ComboBox.SelectedValue.ToString();
            }
            else
                this.业主姓名ComboBox.Text = string.Empty;
        }

        private void InitCmbBuilding()
        {
            string query = "select * from 楼栋信息";
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            foreach (System.Data.DataRow dRow in dt.Rows)
            {
                this.楼栋名称ComboBox.Items.Add(dRow["楼栋名称"].ToString());
            }
        }

        private void SaveNewStation(string query)
        {
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private bool IsNewAdded(string stationNo)
        {
            string query = string.Format("select * from 车位使用 where 车位编号='{0}'", stationNo);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void SynStation()
        {
            string stationNo = this.车位编号ToolStripTextBox.Text.Trim();
            string query = string.Empty;
            if (!string.IsNullOrEmpty(stationNo))
                query = string.Format("select * from 车位使用 where 车位编号 like '%{0}%'", stationNo);
            else
                query = "select * from 车位使用";
            dtData = DataHelper.GetDataTable(query);
            this.车位使用DataGridView.DataSource = dtData;
        }

        private void 打印ToolStripButton_Click(object sender, EventArgs e)
        {//打印车位使用信息
            string title = this.MyCommunity + "车位使用信息表";
            if (printDialog.ShowDialog() != DialogResult.OK)
                return;
            printDocument.DocumentName = title;
            printDocument.PrinterSettings = printDialog.PrinterSettings;
            printDocument.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
            printDocument.DefaultPageSettings.Margins = new Margins(15, 15, 15, 15);
            print = new DataGridViewPrinter(this.车位使用DataGridView, printDocument, title);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string stationNo = this.车位编号TextBox.Text.Trim();
            string ownerName = this.业主姓名ComboBox.Text.Trim();
            if (string.IsNullOrEmpty(stationNo) || string.IsNullOrEmpty(ownerName))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            }
            string tipInfo = string.Format("{0}(车位编号：{1})", ownerName, stationNo);
            if (new MsgBoxForm("警告", "确定要删除业主 " + tipInfo + " 的车位信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 车位使用 where 车位编号='{0}' and 业主姓名='{1}'", stationNo, ownerName);
                SaveNewStation(query);
                SynStation();
            }
        }

        private void 车位使用DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "楼栋名称", "业主姓名" };
            List<string> dateNames = new List<string> { "启用日期", "停用日期" };
            DataGridViewRow currRow = this.车位使用DataGridView.CurrentRow;
            for (int i = 0; i < this.车位使用DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.车位使用DataGridView.Columns[i].DataPropertyName;
                string columnName = this.车位使用DataGridView.Columns[i].Name;
                string value = Helper.GetCellValue(currRow, columnName);
                if (!comboxNames.Contains(ctrlName) && !dateNames.Contains(ctrlName))
                    Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, value);
                else
                {
                    if (comboxNames.Contains(ctrlName))
                        Helper.SetComBoxCtrlValue(this.Controls, ctrlName, value);
                    if (dateNames.Contains(ctrlName))
                        Helper.SetDateCtrlValue(this.Controls, columnName, value);
                }
            }
            if (currRow != null)
                this.bindingNavigatorDeleteItem.Enabled = true;
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
            }
        }
    }
}