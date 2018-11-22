//文件名：OperatorForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MyCommunity.Common;
namespace MyCommunity
{
    public partial class OperatorForm : DevComponents.DotNetBar.Office2007Form
    {
        public OperatorForm()
        {
            InitializeComponent();
        }

        private void 操作用户BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.用户名称TextBox.Text))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            try
            {
                string v_用户名称 = Helper.GetTextBoxCtrlValue(this.Controls, "用户名称");
                string v_用户密码 = Helper.GetTextBoxCtrlValue(this.Controls, "用户密码");
                v_用户密码 = Helper.EncodePassword(v_用户密码);
                string v_用户姓名 = Helper.GetTextBoxCtrlValue(this.Controls, "用户姓名");
                string v_所在部门 = Helper.GetTextBoxCtrlValue(this.Controls, "所在部门");
                string v_联系电话 = Helper.GetTextBoxCtrlValue(this.Controls, "联系电话");
                string v_职责说明 = Helper.GetTextBoxCtrlValue(this.Controls, "职责说明");
                string v_基本管理之业主登记管理 = Helper.GetCheckBoxCtrlValue(this.Controls, "基本管理之业主登记管理");
                string v_基本管理之业主迁出管理 = Helper.GetCheckBoxCtrlValue(this.Controls, "基本管理之业主迁出管理");
                string v_基本管理之楼栋信息管理 = Helper.GetCheckBoxCtrlValue(this.Controls, "基本管理之楼栋信息管理");
                string v_基本管理之公共财产管理 = Helper.GetCheckBoxCtrlValue(this.Controls, "基本管理之公共财产管理");
                string v_物业管理之服务投诉管理 = Helper.GetCheckBoxCtrlValue(this.Controls, "物业管理之服务投诉管理");
                string v_物业管理之业主维修管理 = Helper.GetCheckBoxCtrlValue(this.Controls, "物业管理之业主维修管理");
                string v_物业管理之公共维修管理 = Helper.GetCheckBoxCtrlValue(this.Controls, "物业管理之公共维修管理");
                string v_物业管理之车位使用管理 = Helper.GetCheckBoxCtrlValue(this.Controls, "物业管理之车位使用管理");
                string v_物业管理之突发事件管理 = Helper.GetCheckBoxCtrlValue(this.Controls, "物业管理之突发事件管理");
                string v_费用管理之水电气费登记 = Helper.GetCheckBoxCtrlValue(this.Controls, "费用管理之水电气费登记");
                string v_费用管理之水电气费查询 = Helper.GetCheckBoxCtrlValue(this.Controls, "费用管理之水电气费查询");
                string v_费用管理之水电气费交纳 = Helper.GetCheckBoxCtrlValue(this.Controls, "费用管理之水电气费交纳");
                string v_费用管理之物管费用登记 = Helper.GetCheckBoxCtrlValue(this.Controls, "费用管理之物管费用登记");
                string v_费用管理之物管费用查询 = Helper.GetCheckBoxCtrlValue(this.Controls, "费用管理之物管费用查询");
                string v_费用管理之物管费用交纳 = Helper.GetCheckBoxCtrlValue(this.Controls, "费用管理之物管费用交纳");
                string v_费用管理之其他费用交纳 = Helper.GetCheckBoxCtrlValue(this.Controls, "费用管理之其他费用交纳");
                string v_报表管理之业主统计报表 = Helper.GetCheckBoxCtrlValue(this.Controls, "报表管理之业主统计报表");
                string v_报表管理之投诉统计报表 = Helper.GetCheckBoxCtrlValue(this.Controls, "报表管理之投诉统计报表");
                string v_报表管理之业主维修报表 = Helper.GetCheckBoxCtrlValue(this.Controls, "报表管理之业主维修报表");
                string v_报表管理之公共维修报表 = Helper.GetCheckBoxCtrlValue(this.Controls, "报表管理之公共维修报表");
                string v_报表管理之收入统计报表 = Helper.GetCheckBoxCtrlValue(this.Controls, "报表管理之收入统计报表");
                string v_系统管理之分配用户权限 = Helper.GetCheckBoxCtrlValue(this.Controls, "系统管理之分配用户权限");
                string v_系统管理之小区信息设置 = Helper.GetCheckBoxCtrlValue(this.Controls, "系统管理之小区信息设置");
                string query = string.Empty;
                if (IsNewAdded(v_用户名称))
                {
                    query = string.Format("insert into 操作用户(`用户名称`, `用户密码`, `用户姓名`, `所在部门`, `联系电话`, `职责说明`, `基本管理之业主登记管理`, `基本管理之业主迁出管理`, `基本管理之楼栋信息管理`, `基本管理之公共财产管理`, `物业管理之服务投诉管理`, `物业管理之业主维修管理`, `物业管理之公共维修管理`, `物业管理之车位使用管理`, " + 
                        "`物业管理之突发事件管理`, `费用管理之水电气费登记`, `费用管理之水电气费查询`, `费用管理之水电气费交纳`, `费用管理之物管费用登记`, `费用管理之物管费用查询`, `费用管理之物管费用交纳`, `费用管理之其他费用交纳`, `报表管理之业主统计报表`, `报表管理之投诉统计报表`, `报表管理之业主维修报表`, `报表管理之公共维修报表`, " +
                        " `报表管理之收入统计报表`, `系统管理之分配用户权限`, `系统管理之小区信息设置`)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}')",
                        v_用户名称, v_用户密码, v_用户姓名, v_所在部门, v_联系电话, v_职责说明, v_基本管理之业主登记管理, v_基本管理之业主迁出管理, v_基本管理之楼栋信息管理, v_基本管理之公共财产管理, v_物业管理之服务投诉管理, v_物业管理之业主维修管理, v_物业管理之公共维修管理, v_物业管理之车位使用管理, 
                        v_物业管理之突发事件管理, v_费用管理之水电气费登记, v_费用管理之水电气费查询, v_费用管理之水电气费交纳, v_费用管理之物管费用登记, v_费用管理之物管费用查询, v_费用管理之物管费用交纳, v_费用管理之其他费用交纳, v_报表管理之业主统计报表, v_报表管理之投诉统计报表, v_报表管理之业主维修报表, 
                        v_报表管理之公共维修报表, v_报表管理之收入统计报表, v_系统管理之分配用户权限, v_系统管理之小区信息设置);
                }
                else
                {
                    query = string.Format("update 操作用户 set 用户密码='{0}', 用户姓名='{1}', 所在部门='{2}', 联系电话='{3}', 职责说明='{4}', 基本管理之业主登记管理='{5}', 基本管理之业主迁出管理='{6}', 基本管理之楼栋信息管理='{7}', 基本管理之公共财产管理='{8}', 物业管理之服务投诉管理='{9}', 物业管理之业主维修管理='{10}'," + 
                        " 物业管理之公共维修管理='{11}', 物业管理之车位使用管理='{12}', 物业管理之突发事件管理='{13}', 费用管理之水电气费登记='{14}', 费用管理之水电气费查询='{15}', 费用管理之水电气费交纳='{16}', 费用管理之物管费用登记='{17}', 费用管理之物管费用查询='{18}', 费用管理之物管费用交纳='{19}', 费用管理之其他费用交纳='{20}'," + 
                        " 报表管理之业主统计报表='{21}', 报表管理之投诉统计报表='{22}', 报表管理之业主维修报表='{23}', 报表管理之公共维修报表='{24}', 报表管理之收入统计报表='{25}', 系统管理之分配用户权限='{26}', 系统管理之小区信息设置='{27}' where 用户名称='{28}'",
                        v_用户密码, v_用户姓名, v_所在部门, v_联系电话, v_职责说明, v_基本管理之业主登记管理, v_基本管理之业主迁出管理, v_基本管理之楼栋信息管理, v_基本管理之公共财产管理, v_物业管理之服务投诉管理, v_物业管理之业主维修管理, v_物业管理之公共维修管理, v_物业管理之车位使用管理,
                        v_物业管理之突发事件管理, v_费用管理之水电气费登记, v_费用管理之水电气费查询, v_费用管理之水电气费交纳, v_费用管理之物管费用登记, v_费用管理之物管费用查询, v_费用管理之物管费用交纳, v_费用管理之其他费用交纳, v_报表管理之业主统计报表, v_报表管理之投诉统计报表, v_报表管理之业主维修报表,
                        v_报表管理之公共维修报表, v_报表管理之收入统计报表, v_系统管理之分配用户权限, v_系统管理之小区信息设置, v_用户名称);
                }
                DataHelper.UpdateOrDeleteRecord(query);
                SynUserInfo();
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {
                new MsgBoxForm("提示", "保存失败，请检查所填数据类型！").ShowDialog();
                LogHelper.LogError(ex);
            }
        }
        private void OperatorForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dBCommunityDataSet.操作用户”中
            SynUserInfo();
        }

        private void SynUserInfo()
        {
            string query = "select * from 操作用户";
            DataTable dt = DataHelper.GetDataTable(query);
            this.操作用户DataGridView.DataSource = dt;
            this.操作用户DataGridView.Columns["用户密码"].Visible = false;
        }

        private bool IsNewAdded(string userId)
        {
            string query = string.Format("select 用户名称 from 操作用户 where 用户名称='{0}'", userId);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void 操作用户DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<string> checkBoxNames = new List<string> { "基本管理之业主登记管理", "基本管理之业主迁出管理", "基本管理之楼栋信息管理", "基本管理之公共财产管理", 
                "物业管理之服务投诉管理", "物业管理之业主维修管理", "物业管理之公共维修管理", "物业管理之车位使用管理", "物业管理之突发事件管理", "费用管理之水电气费登记", 
                "费用管理之水电气费查询", "费用管理之水电气费交纳", "费用管理之物管费用登记", "费用管理之物管费用查询", "费用管理之物管费用交纳", "费用管理之其他费用交纳", 
                "报表管理之业主统计报表", "报表管理之投诉统计报表", "报表管理之业主维修报表", "报表管理之公共维修报表", "报表管理之收入统计报表", "系统管理之分配用户权限", "系统管理之小区信息设置" };
            DataGridViewRow currRow = this.操作用户DataGridView.CurrentRow;
            for (int i = 0; i < this.操作用户DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.操作用户DataGridView.Columns[i].DataPropertyName;
                string columnName = this.操作用户DataGridView.Columns[i].Name;
                string value = Helper.GetCellValue(currRow, columnName);
                if (!checkBoxNames.Contains(ctrlName))
                {
                    if (ctrlName == "用户密码")
                        value = Helper.DecodePassword(value);
                    Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, value);
                }
                else
                    Helper.SetCheckBoxCtrlValue(this.Controls, ctrlName, value);
            }
            if (currRow != null)
                this.bindingNavigatorDeleteItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string userId = this.用户名称TextBox.Text.Trim();
            string userName = this.用户姓名TextBox.Text.Trim();
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(userName))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            }
            string tipInfo = string.Format("{0}(用户名称：{1})", userName, userId);
            if (new MsgBoxForm("警告", "确定要删除用户 " + tipInfo + " 的信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 操作用户 where 用户名称='{0}' and 用户姓名='{1}'", userId, userName);
                DataHelper.UpdateOrDeleteRecord(query);
                SynUserInfo();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            List<string> checkBoxNames = new List<string> { "基本管理之业主登记管理", "基本管理之业主迁出管理", "基本管理之楼栋信息管理", "基本管理之公共财产管理", 
                "物业管理之服务投诉管理", "物业管理之业主维修管理", "物业管理之公共维修管理", "物业管理之车位使用管理", "物业管理之突发事件管理", "费用管理之水电气费登记", 
                "费用管理之水电气费查询", "费用管理之水电气费交纳", "费用管理之物管费用登记", "费用管理之物管费用查询", "费用管理之物管费用交纳", "费用管理之其他费用交纳", 
                "报表管理之业主统计报表", "报表管理之投诉统计报表", "报表管理之业主维修报表", "报表管理之公共维修报表", "报表管理之收入统计报表", "系统管理之分配用户权限", "系统管理之小区信息设置" };
            for (int i = 0; i < this.操作用户DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.操作用户DataGridView.Columns[i].DataPropertyName;
                string columnName = this.操作用户DataGridView.Columns[i].Name;
                string value = string.Empty;
                if (!checkBoxNames.Contains(ctrlName))
                {
                    Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, value);
                }
                else
                    Helper.SetCheckBoxCtrlValue(this.Controls, ctrlName, value);
            }
        }
    }
}