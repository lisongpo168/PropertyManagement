//文件名：MoveForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using MyCommunity.Common;
namespace MyCommunity
{
    public partial class MoveForm : DevComponents.DotNetBar.Office2007Form
    {
        private System.Data.DataTable dtData = null;
        public MoveForm()
        {
            InitializeComponent();
            InitCmbCommunity();
        }

        private void 迁出信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (string.IsNullOrEmpty(this.业主编号TextBox.Text))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            try
            {
                string v_业主编号 = Helper.GetTextBoxCtrlValue(this.Controls, "业主编号");
                string v_业主姓名 = Helper.GetComBoxCtrlValue(this.Controls, "业主姓名");
                string v_迁出日期 = Helper.GetDateCtrlValue(this.Controls, "迁出日期");
                string v_迁出原因 = Helper.GetTextBoxCtrlValue(this.Controls, "迁出原因");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");
                string query = string.Empty;
                if (IsNewOwnerOutAdded(v_业主编号))
                {
                    query = string.Format("insert into 迁出信息(`业主编号`, `业主姓名`, `迁出日期`, `迁出原因`, `补充说明`)values('{0}','{1}','{2}','{3}','{4}')",
                        v_业主编号, v_业主姓名, v_迁出日期, v_迁出原因, v_补充说明);
                }
                else
                {
                    query = string.Format("update 迁出信息 set 业主姓名='{0}',迁出日期='{1}',迁出原因='{2}',补充说明='{3}'' where 业主编号='{4}'",
                        v_业主姓名, v_迁出日期, v_迁出原因, v_补充说明, v_业主编号);
                }
                SaveNewOwnerOut(query);
                UpdateOwner(v_业主编号, "迁出");
                SynOwnerOut();
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {
                new MsgBoxForm("提示", "保存失败，请检查所填数据类型！").ShowDialog();
                LogHelper.LogError(ex);
            }
        }
        private void 查询ToolStripButton_Click(object sender, EventArgs e)
        {
            SynOwnerOut();
        }
        private void MoveForm_Load(object sender, EventArgs e)
        {
            SynOwnerOut();
        }
        private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {//获取指定楼栋的业主信息
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
        {
            if (this.业主姓名ComboBox.SelectedValue != null && this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                this.业主编号TextBox.Text = this.业主姓名ComboBox.SelectedValue.ToString();
            }
            else
                this.业主姓名ComboBox.Text = string.Empty;
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

        private void SynOwnerOut()
        {
            string ownerNo = this.业主编号ToolStripTextBox.Text.Trim();
            string query = "select * from 迁出信息"; ;
            if (!string.IsNullOrEmpty(ownerNo))
            {
                query = string.Format("select * from 迁出信息 where 业主编号 like '%{0}%'", ownerNo);
            }
            dtData = DataHelper.GetDataTable(query);
            this.迁出信息DataGridView.DataSource = dtData;
        }

        private void SaveNewOwnerOut(string query)
        {
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private void UpdateOwner(string ownerNo, string status)
        {
            string query = string.Format("update 业主信息 set 当前状态='{0}' where 业主编号='{1}'", status, ownerNo);
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private bool IsNewOwnerOutAdded(string ownerNo)
        {
            string query = string.Format("select * from 迁出信息 where 业主编号='{0}'", ownerNo);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void 迁出信息DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "业主姓名" };
            List<string> dateNames = new List<string> { "迁出日期" };
            DataGridViewRow currRow = this.迁出信息DataGridView.CurrentRow;
            for (int i = 0; i < this.迁出信息DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.迁出信息DataGridView.Columns[i].DataPropertyName;
                string columnName = this.迁出信息DataGridView.Columns[i].Name;
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow currRow = this.迁出信息DataGridView.CurrentRow;
            string ownerNo = Helper.GetTextBoxCtrlValue(this.Controls, "业主编号");
            string ownerName = Helper.GetComBoxCtrlValue(this.Controls, "业主姓名");
            if (string.IsNullOrEmpty(ownerNo) || string.IsNullOrEmpty(ownerName))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            }
            string tipInfo = string.Format("{0}({1})", ownerName, ownerNo);
            if (new MsgBoxForm("警告", "确定要删除业主 " + tipInfo + " 的迁出信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 迁出信息 where 业主编号='{0}' and 业主姓名='{1}'", ownerNo, ownerName);
                SaveNewOwnerOut(query);
                UpdateOwner(ownerNo, "已入住");
                SynOwnerOut();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "楼栋名称", "业主姓名" };
            List<string> dateNames = new List<string> { "迁出日期" };
            for (int i = 0; i < this.迁出信息DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.迁出信息DataGridView.Columns[i].DataPropertyName;
                string columnName = this.迁出信息DataGridView.Columns[i].Name;
                string value = string.Empty;
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
        }

        private void 小区名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v_小区名称 = this.小区名称ComboBox.Text;
            string query = "SELECT * FROM 楼栋信息 WHERE (小区名称 = '" + v_小区名称 + "')";
            DataTable myTable = DataHelper.GetDataTable(query);
            this.楼栋名称ComboBox.Text = string.Empty;
            this.楼栋名称ComboBox.DataSource = myTable;
            this.楼栋名称ComboBox.DisplayMember = "楼栋名称";
            this.楼栋名称ComboBox.ValueMember = "楼栋名称";
        }
    }
}