using MyCommunity.Common;
//文件名：OwnerForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCommunity
{
    public partial class OwnerForm : DevComponents.DotNetBar.Office2007Form
    {
        private System.Data.DataTable dtData = null;
        public OwnerForm()
        {
            InitializeComponent();
            InitCmbBuilding();
            this.业主编号ToolStripTextBox.Text = string.Empty;
            this.bindingNavigatorAddNewItem.Enabled = true;
        }

        private void 业主信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
                string v_业主姓名 = Helper.GetTextBoxCtrlValue(this.Controls, "业主姓名");
                string v_身份证号码 = Helper.GetTextBoxCtrlValue(this.Controls, "身份证号码");
                string v_楼栋名称 = Helper.GetComBoxCtrlValue(this.Controls, "楼栋名称");
                string v_单元名称 = Helper.GetTextBoxCtrlValue(this.Controls, "单元名称");
                string v_房号名称 = Helper.GetTextBoxCtrlValue(this.Controls, "房号名称");
                string v_房屋性质 = Helper.GetComBoxCtrlValue(this.Controls, "房屋性质");
                string v_房屋类型 = Helper.GetComBoxCtrlValue(this.Controls, "房屋类型");
                string v_建筑面积 = Helper.GetTextBoxCtrlValue(this.Controls, "建筑面积");
                string v_套内面积 = Helper.GetTextBoxCtrlValue(this.Controls, "套内面积");
                string v_常住人员 = Helper.GetTextBoxCtrlValue(this.Controls, "常住人员");
                string v_联系电话 = Helper.GetTextBoxCtrlValue(this.Controls, "联系电话");
                string v_入住日期 = Helper.GetDateCtrlValue(this.Controls, "入住日期");
                string v_当前状态 = Helper.GetComBoxCtrlValue(this.Controls, "当前状态");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");
                string query = string.Empty;
                if (IsNewAdded(v_业主编号))
                {
                    query = string.Format("insert into 业主信息(`业主编号`, `业主姓名`, `身份证号码`, `楼栋名称`, `单元名称`, `房号名称`, `房屋性质`, `房屋类型`, `建筑面积`, `套内面积`, `常住人员`, `联系电话`, `入住日期`, `当前状态`, `补充说明`)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},{9},'{10}','{11}','{12}','{13}','{14}')",
                        v_业主编号, v_业主姓名, v_身份证号码, v_楼栋名称, v_单元名称, v_房号名称, v_房屋性质, v_房屋类型, v_建筑面积, v_套内面积, v_常住人员, v_联系电话, v_入住日期, v_当前状态, v_补充说明);
                }
                else
                {
                    query = string.Format("update 业主信息 set 业主姓名='{0}',身份证号码='{1}',楼栋名称='{2}',单元名称='{3}',房号名称='{4}',房屋性质='{5}',房屋类型='{6}',建筑面积={7},套内面积={8},常住人员='{9}',联系电话='{10}',`入住日期`='{11}', `当前状态`='{12}', `补充说明`='{13}' where 业主编号='{14}'", 
                        v_业主姓名, v_身份证号码, v_楼栋名称, v_单元名称, v_房号名称, v_房屋性质, v_房屋类型, v_建筑面积, v_套内面积, v_常住人员, v_联系电话, v_入住日期, v_当前状态, v_补充说明, v_业主编号);
                }
                SaveNewOwner(query);
                SynOwner();
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
            SynOwner();
        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {
            SynOwner();
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

        private void SaveNewOwner(string query)
        {
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private bool IsNewAdded(string ownerNo)
        {
            string query = string.Format("select * from 业主信息 where 业主编号='{0}'", ownerNo);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void SynOwner()
        {
            string ownerNo = this.业主编号ToolStripTextBox.Text.Trim();
            string buildName = this.楼栋名称ComboBox.Text.Trim();
            string query = string.Empty;
            if (!string.IsNullOrEmpty(ownerNo) && !string.IsNullOrEmpty(buildName))
            {
                query = string.Format("select * from 业主信息 where 业主编号 like '%{0}%' and 楼栋名称='{1}'", ownerNo, buildName);
            }
            else
            {
                if (!string.IsNullOrEmpty(ownerNo))
                {
                    query = string.Format("select * from 业主信息 where 业主编号 like '%{0}%'", ownerNo);
                }
                else if (!string.IsNullOrEmpty(buildName))
                {
                    query = string.Format("select * from 业主信息 where 楼栋名称='{0}'", buildName);
                }
                else
                {
                    query = "select * from 业主信息";
                }
            }
            dtData = DataHelper.GetDataTable(query);
            this.业主信息DataGridView.DataSource = dtData;
        }

        private void 业主信息DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "楼栋名称", "房屋性质", "房屋类型", "当前状态" };
            List<string> dateNames = new List<string> { "入住日期" };
            DataGridViewRow currRow = this.业主信息DataGridView.CurrentRow;
            for (int i = 0; i < this.业主信息DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.业主信息DataGridView.Columns[i].DataPropertyName;
                string columnName = this.业主信息DataGridView.Columns[i].Name;
                string value = Helper.GetCellValue(currRow, columnName);
                if (!comboxNames.Contains(ctrlName) && !dateNames.Contains(ctrlName))
                    Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, value);
                else
                {
                    if(comboxNames.Contains(ctrlName))
                        Helper.SetComBoxCtrlValue(this.Controls, ctrlName, value);
                    if (dateNames.Contains(ctrlName))
                        Helper.SetDateCtrlValue(this.Controls, ctrlName, value);
                }
            }
            if (currRow != null)
                this.bindingNavigatorDeleteItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string ownerNo = this.业主编号TextBox.Text.Trim();
            string ownerName = this.业主姓名TextBox.Text.Trim();
            string buildName = this.楼栋名称ComboBox.Text.Trim();
            if (string.IsNullOrEmpty(ownerNo) || string.IsNullOrEmpty(buildName))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            }
            string tipInfo = string.Format("{0}({1})", ownerName, ownerNo);
            if (new MsgBoxForm("警告", "确定要删除业主 " + tipInfo + " 的信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 业主信息 where 业主编号='{0}' and 楼栋名称='{1}'", ownerNo, buildName);
                SaveNewOwner(query);
                SynOwner();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "楼栋名称", "房屋性质", "房屋类型", "当前状态" };
            List<string> dateNames = new List<string> { "入住日期" };
            DataGridViewRow currRow = this.业主信息DataGridView.CurrentRow;
            for (int i = 0; i < this.业主信息DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.业主信息DataGridView.Columns[i].DataPropertyName;
                string columnName = this.业主信息DataGridView.Columns[i].Name;
                string value = string.Empty;
                if (!comboxNames.Contains(ctrlName) && !dateNames.Contains(ctrlName))
                    Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, value);
                else
                {
                    if (comboxNames.Contains(ctrlName))
                        Helper.SetComBoxCtrlValue(this.Controls, ctrlName, value);
                    if (dateNames.Contains(ctrlName))
                        Helper.SetDateCtrlValue(this.Controls, ctrlName, value);
                }
            }
        }
    }
}