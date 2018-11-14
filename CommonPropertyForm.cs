//文件名：CommonPropertyForm.cs
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
namespace MyCommunity
{
    public partial class CommonPropertyForm : Form
    {
        private System.Data.DataTable dtData = null;
        public CommonPropertyForm()
        {
            InitializeComponent();
        }
        public string MyCommunity;
        private void CommonPropertyForm_Load(object sender, EventArgs e)
        {
            SynCommonProperty();         
        }
        private void 公共财产BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (string.IsNullOrEmpty(this.财产编号TextBox.Text))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            try
            {
                string v_财产编号 = Helper.GetTextBoxCtrlValue(this.Controls, "财产编号");
                string v_财产名称 = Helper.GetTextBoxCtrlValue(this.Controls, "财产名称");
                string v_规格型号 = Helper.GetTextBoxCtrlValue(this.Controls, "规格型号");
                string v_所属类别 = Helper.GetComBoxCtrlValue(this.Controls, "所属类别");
                string v_财产原值 = Helper.GetTextBoxCtrlValue(this.Controls, "财产原值");
                string v_启用日期 = this.启用日期DateTimePicker.Value.ToString("yyyy-MM-dd");
                string v_存放位置 = Helper.GetTextBoxCtrlValue(this.Controls, "存放位置");
                string v_当前状态 = Helper.GetComBoxCtrlValue(this.Controls, "当前状态");
                string v_保管人员 = Helper.GetTextBoxCtrlValue(this.Controls, "保管人员");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");
                string query = string.Empty;
                if (IsNewAdded(v_财产编号))
                {
                    query = string.Format("insert into 公共财产(`财产编号`, `财产名称`, `规格型号`, `所属类别`, `财产原值`, `启用日期`, `存放位置`, `当前状态`, `保管人员`, `补充说明`)values('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}','{9}')",
                        v_财产编号, v_财产名称, v_规格型号, v_所属类别, v_财产原值, v_启用日期, v_存放位置, v_当前状态, v_保管人员, v_补充说明);
                }
                else
                {
                    query = string.Format("update 公共财产 set 财产名称='{0}',规格型号='{1}',所属类别='{2}',财产原值='{3}',启用日期='{4}',存放位置='{5}',当前状态='{6}',保管人员={7},补充说明={8} where 财产编号='{9}'",
                        v_财产名称, v_规格型号, v_所属类别, v_财产原值, v_启用日期, v_存放位置, v_当前状态, v_保管人员, v_补充说明, v_财产编号);
                }
                SaveNewCommonProperty(query);
                SynCommonProperty();
            }
            catch (Exception ex)
            {

            }
        }
        private void 打印ToolStripButton_Click(object sender, EventArgs e)
        {//打印公共财产信息
            Helper.PrintGridView(dtData, this.MyCommunity + "公共财产信息表");
        }

        private void SaveNewCommonProperty(string query)
        {
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private bool IsNewAdded(string propertyNo)
        {
            string query = string.Format("select * from 公共财产 where 财产编号='{0}'", propertyNo);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void SynCommonProperty()
        {
            string query = "select * from 公共财产";
            dtData = DataHelper.GetDataTable(query);
            this.公共财产DataGridView.DataSource = dtData;
        }

        private void 公共财产DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "所属类别", "当前状态" };
            List<string> dateNames = new List<string> { "启用日期" };
            DataGridViewRow currRow = this.公共财产DataGridView.CurrentRow;
            for (int i = 0; i < this.公共财产DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.公共财产DataGridView.Columns[i].DataPropertyName;
                string columnName = this.公共财产DataGridView.Columns[i].Name;
                string value = Helper.GetCellValue(currRow, columnName);
                if (!comboxNames.Contains(ctrlName) && !dateNames.Contains(ctrlName))
                    Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, value);
                else
                {
                    if (comboxNames.Contains(ctrlName))
                        Helper.SetComBoxCtrlValue(this.Controls, ctrlName, value);
                    if (dateNames.Contains(ctrlName))
                        this.启用日期DateTimePicker.Value = Helper.StringToDate(value);
                }
            }
            if (currRow != null)
                this.bindingNavigatorDeleteItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string propertyNo = this.财产编号TextBox.Text.Trim();
            string propertyName = this.财产名称TextBox.Text.Trim();
            if (string.IsNullOrEmpty(propertyNo) || string.IsNullOrEmpty(propertyName))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            }
            string tipInfo = string.Format("{0}({1})", propertyName, propertyNo);
            if (new MsgBoxForm("警告", "确定要删除财产 " + tipInfo + " 的信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 公共财产 where 财产编号='{0}' and 财产名称='{1}'", propertyNo, propertyName);
                SaveNewCommonProperty(query);
                SynCommonProperty();
            }
        }
    }
}