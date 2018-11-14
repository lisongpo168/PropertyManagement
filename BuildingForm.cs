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
namespace MyCommunity
{
    public partial class BuildingForm : Form
    {
        private System.Data.DataTable dtData = null;
        public BuildingForm()
        {
            InitializeComponent();
        }
        public string MyCommunity;
        private void 楼栋信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.楼栋信息BindingSource.EndEdit();
            //this.楼栋信息TableAdapter.Update(this.dBCommunityDataSet.楼栋信息);
            if (string.IsNullOrEmpty(this.楼栋名称TextBox.Text))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            try
            {
                string buildName = Helper.GetTextBoxCtrlValue(this.Controls, "楼栋名称");
                string pos = Helper.GetTextBoxCtrlValue(this.Controls, "所处位置");
                string unit = Helper.GetTextBoxCtrlValue(this.Controls, "单元信息");
                string floor = this.楼层信息TextBox.Text;
                string totalRenStr = this.总人口数TextBox.Text;
                string totalHuStr = this.总户数TextBox.Text;
                string ruzhuHuStr = this.入住户数TextBox.Text;
                string zhuzhaiHuStr = this.住宅户数TextBox.Text;
                string admin = this.管理楼长TextBox.Text;
                string adminTel = this.联系电话TextBox.Text;
                string memo = this.补充说明TextBox.Text;
                short totalRen = 0, totalHu = 0, ruzhuHu = 0, zhuzhaiHu = 0;
                int kongHu = 0, shangHu = 0;
                Int16.TryParse(totalRenStr, out totalRen);
                Int16.TryParse(totalHuStr, out totalHu);
                Int16.TryParse(ruzhuHuStr, out ruzhuHu);
                Int16.TryParse(zhuzhaiHuStr, out zhuzhaiHu);
                kongHu = totalHu - ruzhuHu;
                shangHu = totalHu = zhuzhaiHu;
                string query = string.Empty;
                if (IsNewAdded(buildName))
                {
                    query = string.Format("insert into 楼栋信息(`楼栋名称`, `所处位置`, `单元信息`, `楼层信息`, `总人口数`, `总户数`, `入住户数`, `空置户数`, `住宅户数`, `商用户数`, `管理楼长`, `联系电话`, `补充说明`)values('{0}','{1}','{2}','{3}',{4},{5},{6},{7},{8},{9},'{10}','{11}','{12}')", buildName, pos, unit, floor,
                    totalRen, totalHu, ruzhuHu, kongHu, zhuzhaiHu, shangHu, admin, adminTel, memo);
                }
                else
                {
                    query = string.Format("update 楼栋信息 set 所处位置='{0}',单元信息='{1}',楼层信息='{2}',总人口数={3},总户数={4},入住户数={5},空置户数={6},住宅户数={7},商用户数={8},管理楼长='{9}',联系电话='{10}',补充说明='{11}' where 楼栋名称='{12}'", pos, unit, floor,
                    totalRen, totalHu, ruzhuHu, kongHu, zhuzhaiHu, shangHu, admin, adminTel, memo, buildName);
                }
                SaveNewBuilding(query);
                SynBuilding();
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {

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
        private void BuildingForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
            //this.楼栋信息TableAdapter.Fill(this.dBCommunityDataSet.楼栋信息);     
            SynBuilding();
        }
        private void 打印ToolStripButton_Click(object sender, EventArgs e)
        {//打印楼栋信息
            Helper.PrintGridView(dtData, this.MyCommunity + "楼栋信息表");
        }

        private void 楼栋信息DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currRow = this.楼栋信息DataGridView.CurrentRow;
            for (int i = 0; i < this.楼栋信息DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.楼栋信息DataGridView.Columns[i].DataPropertyName;
                string columnName = this.楼栋信息DataGridView.Columns[i].Name;
                string value = Helper.GetCellValue(currRow, columnName);
                Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, value);
            }
            if (currRow != null)
                this.bindingNavigatorDeleteItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string buildName = this.楼栋名称TextBox.Text;
            if (string.IsNullOrEmpty(buildName))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            } 

            if (new MsgBoxForm("警告", "确定要删除该楼幢信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 楼栋信息 where 楼栋名称='{0}'", buildName);
                SaveNewBuilding(query);
                SynBuilding();
            }
        }     
    }
}