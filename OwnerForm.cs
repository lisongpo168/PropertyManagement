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
        private List<string> MeterInfoList = null;
        public OwnerForm()
        {
            InitializeComponent();
            InitCmbCommunity();
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

            if (string.IsNullOrEmpty(this.电表序列TextBox.Text))
            {
                new MsgBoxForm("提示", "电表信息还未输入！").ShowDialog();
                return;
            }
            try
            {
                string v_业主编号 = Helper.GetTextBoxCtrlValue(this.Controls, "业主编号");
                string v_业主姓名 = Helper.GetTextBoxCtrlValue(this.Controls, "业主姓名");
                string v_楼栋名称 = Helper.GetComBoxCtrlValue(this.Controls, "楼栋名称");
                string v_单元名称 = Helper.GetTextBoxCtrlValue(this.Controls, "单元名称");
                string v_房号名称 = Helper.GetTextBoxCtrlValue(this.Controls, "房号名称");
                string v_物业费用 = Helper.GetTextBoxCtrlValue(this.Controls, "物业费用");
                string v_预存金额 = Helper.GetTextBoxCtrlValue(this.Controls, "预存金额");
                string v_联系电话 = Helper.GetTextBoxCtrlValue(this.Controls, "联系电话");
                string v_入住日期 = Helper.GetDateCtrlValue(this.Controls, "入住日期");
                string v_当前状态 = Helper.GetComBoxCtrlValue(this.Controls, "当前状态");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");
                string query = string.Empty;
                float f_物业费用 = 0, f_预存金额 = 0;
                float.TryParse(v_物业费用, out f_物业费用);
                float.TryParse(v_预存金额, out f_预存金额);
                if (f_物业费用 <= 0)
                {
                    new MsgBoxForm("提示", "物业费用未有效输入！").ShowDialog();
                    return;
                }
                if (IsNewAdded(v_业主编号))
                {
                    query = string.Format("insert into 业主信息(`业主编号`, `业主姓名`, `楼栋名称`, `单元名称`, `房号名称`, `物业费用`, `预存金额`, `联系电话`, `入住日期`, `当前状态`, `补充说明`)values('{0}','{1}','{2}','{3}','{4}',{5},{6},'{7}','{8}','{9}','{10}')",
                        v_业主编号, v_业主姓名, v_楼栋名称, v_单元名称, v_房号名称, f_物业费用, f_预存金额, v_联系电话, v_入住日期, v_当前状态, v_补充说明);
                }
                else
                {
                    query = string.Format("update 业主信息 set 业主姓名='{0}',楼栋名称='{1}',单元名称='{2}',房号名称='{3}',物业费用={4},预存金额={5},联系电话='{6}',`入住日期`='{7}', `当前状态`='{8}', `补充说明`='{9}' where 业主编号='{10}'", 
                        v_业主姓名, v_楼栋名称, v_单元名称, v_房号名称, f_物业费用, f_预存金额, v_联系电话, v_入住日期, v_当前状态, v_补充说明, v_业主编号);
                }
                SaveNewOwner(query);
                SaveMeterInfo(v_业主编号);
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

        private void SaveNewOwner(string query)
        {
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private void SaveMeterInfo(string v_业主编号)
        {
            DeleteMeterInfo(v_业主编号);
            foreach (string v_电表编号 in MeterInfoList)
            {
                string query = string.Format("insert into 电表信息(`业主编号`, `电表编号`)values('{0}','{1}')", v_业主编号, v_电表编号);
                DataHelper.UpdateOrDeleteRecord(query);
            }
        }

        private void DeleteMeterInfo(string v_业主编号)
        {
            string query = string.Format("delete from 电表信息 where 业主编号='{0}'", v_业主编号);
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private bool IsNewAdded(string ownerNo)
        {
            string query = string.Format("select 业主编号 from 业主信息 where 业主编号='{0}'", ownerNo);
            DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void SynOwner()
        {
            string ownerNo = this.业主编号ToolStripTextBox.Text.Trim();
            string buildName = this.楼栋名称ComboBox.Text.Trim();
            string query = string.Empty;
            if (!string.IsNullOrEmpty(ownerNo) && !string.IsNullOrEmpty(buildName))
            {
                query = string.Format("select 业主信息.*,楼栋信息.小区名称 from 业主信息 left join 楼栋信息 on 业主信息.楼栋名称=楼栋信息.楼栋名称 where 业主信息.业主编号 like '%{0}%' and 业主信息.楼栋名称='{1}'", ownerNo, buildName);
            }
            else
            {
                if (!string.IsNullOrEmpty(ownerNo))
                {
                    query = string.Format("select 业主信息.*,楼栋信息.小区名称 from 业主信息 left join 楼栋信息 on 业主信息.楼栋名称=楼栋信息.楼栋名称 where 业主信息.业主编号 like '%{0}%'", ownerNo);
                }
                else if (!string.IsNullOrEmpty(buildName))
                {
                    query = string.Format("select 业主信息.*,楼栋信息.小区名称 from 业主信息 left join 楼栋信息 on 业主信息.楼栋名称=楼栋信息.楼栋名称 where 业主信息.楼栋名称='{0}'", buildName);
                }
                else
                {
                    query = "select 业主信息.*,楼栋信息.小区名称 from 业主信息 left join 楼栋信息 on 业主信息.楼栋名称=楼栋信息.楼栋名称";
                }
            }
            dtData = DataHelper.GetDataTable(query);
            this.业主信息DataGridView.Rows.Clear();
            foreach (DataRow dRow in dtData.Rows)
            {
                object[] objs = new object[] { 
                    Helper.Obj2String(dRow["业主编号"]),
                    Helper.Obj2String(dRow["业主姓名"]),
                    Helper.Obj2String(dRow["楼栋名称"]),
                    Helper.Obj2String(dRow["单元名称"]),
                    Helper.Obj2String(dRow["房号名称"]),
                    Helper.Obj2String(dRow["物业费用"]),
                    Helper.Obj2String(dRow["预存金额"]),
                    Helper.Obj2String(dRow["联系电话"]),
                    Helper.Obj2Date(dRow["入住日期"]).ToString("yyyy年M月d日"),
                    Helper.Obj2String(dRow["当前状态"]),
                    Helper.Obj2String(dRow["补充说明"]),
                    Helper.Obj2String(dRow["小区名称"])
                };
                this.业主信息DataGridView.Rows.Add(objs);
            }
            //this.业主信息DataGridView.DataSource = dtData;
        }

        private void 业主信息DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "楼栋名称", "小区名称", "当前状态" };
            List<string> dateNames = new List<string> { "入住日期" };
            DataGridViewRow currRow = this.业主信息DataGridView.CurrentRow;
            for (int i = 0; i < this.业主信息DataGridView.Columns.Count; i++)
            {
                string columnName = this.业主信息DataGridView.Columns[i].Name;
                string value = Helper.GetCellValue(currRow, columnName);
                if (!comboxNames.Contains(columnName) && !dateNames.Contains(columnName))
                    Helper.SetTextBoxCtrlValue(this.Controls, columnName, value);
                else
                {
                    if (comboxNames.Contains(columnName))
                        Helper.SetComBoxCtrlValue(this.Controls, columnName, value);
                    if (dateNames.Contains(columnName))
                        Helper.SetDateCtrlValue(this.Controls, columnName, value);
                }
            }
            if (currRow != null)
            {
                string v_业主编号 = this.业主编号TextBox.Text;
                GetMeterInfo(v_业主编号);
                this.bindingNavigatorDeleteItem.Enabled = true;
            }
        }

        private void GetMeterInfo(string v_业主编号)
        {
            MeterInfoList = new List<string>();
            string query = string.Format("select * from 电表信息 where 业主编号='{0}'", v_业主编号);
            DataTable dt = DataHelper.GetDataTable(query);
            string meterInfoStr = string.Empty;
            foreach (DataRow dRow in dt.Rows)
            {
                string v_电表编号 = Helper.Obj2String(dRow["电表编号"]);
                if (!string.IsNullOrEmpty(v_电表编号) && !MeterInfoList.Contains(v_电表编号))
                {
                    MeterInfoList.Add(v_电表编号);
                    meterInfoStr += v_电表编号 + ",";
                }
            }
            if (MeterInfoList.Count > 0)
            {
                meterInfoStr = meterInfoStr.Substring(0, meterInfoStr.Length - 1);
                this.电表序列TextBox.Text = meterInfoStr;
            }
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
                DeleteMeterInfo(ownerNo);
                SynOwner();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "楼栋名称", "小区名称", "当前状态" };
            List<string> dateNames = new List<string> { "入住日期" };
            DataGridViewRow currRow = this.业主信息DataGridView.CurrentRow;
            for (int i = 0; i < this.业主信息DataGridView.Columns.Count; i++)
            {
                string columnName = this.业主信息DataGridView.Columns[i].Name;
                string value = string.Empty;
                if (!comboxNames.Contains(columnName) && !dateNames.Contains(columnName))
                    Helper.SetTextBoxCtrlValue(this.Controls, columnName, value);
                else
                {
                    if (comboxNames.Contains(columnName))
                        Helper.SetComBoxCtrlValue(this.Controls, columnName, value);
                    if (dateNames.Contains(columnName))
                        Helper.SetDateCtrlValue(this.Controls, columnName, value);
                }
            }
            MeterInfoList = new List<string>();
            this.电表序列TextBox.Text = "";
            this.补充说明TextBox.Text = "暂无";
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

        private void 电表序列Button_Click(object sender, EventArgs e)
        {
            SetMeterForm form = new SetMeterForm(MeterInfoList);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.电表序列TextBox.Text = form.MeterStr;
                this.MeterInfoList = form.MeterInfoList;
            }
        }
    }
}