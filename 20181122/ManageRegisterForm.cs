//文件名：ManageRegisterForm.cs
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
    public partial class ManageRegisterForm : DevComponents.DotNetBar.Office2007Form
    {
        public ManageRegisterForm()
        {
            InitializeComponent();
        }

        private Dictionary<string, StationFeeInfo> GetStationFeeInfo(string v_楼栋名称)
        {
            Dictionary<string, StationFeeInfo> feeDic = new Dictionary<string, StationFeeInfo>();
            string query = string.Format("select * from 车位使用 where 楼栋名称='{0}'", v_楼栋名称);
            DataTable dt = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in dt.Rows)
            {
                StationFeeInfo feeInfo = new StationFeeInfo();
                string v_车位编号 = Helper.Obj2String(dRow["车位编号"]);
                string v_业主编号 = Helper.Obj2String(dRow["业主编号"]);
                string v_业主姓名 = Helper.Obj2String(dRow["业主姓名"]);
                double v_费用金额 = Helper.Obj2Double(dRow["费用金额"]);
                string key = v_业主编号 + v_业主姓名;
                if (!feeDic.ContainsKey(key))
                    feeDic.Add(key, new StationFeeInfo() { v_车位编号 = v_车位编号, v_费用金额 = v_费用金额 });
                else
                {
                    feeDic[key].v_费用金额 += v_费用金额;
                    feeDic[key].v_车位编号 += "|" + v_车位编号;
                }
            }
            return feeDic;
        }
        private void ManageRegisterForm_Load(object sender, EventArgs e)
        {
            for (int i = 2009; i <= 2099; i++)
            {
                this.计费年份ToolStripComboBox.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                this.计费月份ToolStripComboBox.Items.Add(i.ToString());
            }
            string query = "SELECT * FROM 楼栋信息";
            DataTable myTable = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in myTable.Rows)
            {
                this.楼栋名称ToolStripComboBox.Items.Add(dRow["楼栋名称"].ToString());
            }
        }
        private void 物管费用BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            string v_计费年份 = this.计费年份ToolStripComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ToolStripComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ToolStripComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，楼栋名称等信息！").ShowDialog();
                return;
            }

            try
            {
                Dictionary<string, StationFeeInfo> stationFeeDic = GetStationFeeInfo(v_楼栋名称);
                foreach (DataGridViewRow gridViewRow in this.物管费用DataGridView.Rows)
                {
                    string v_业主编号 = Helper.GetCellValue(gridViewRow, "业主编号");
                    if (string.IsNullOrEmpty(v_业主编号))
                        continue;
                    string v_业主姓名 = Helper.GetCellValue(gridViewRow, "业主姓名");
                    string v_建筑面积 = Helper.GetCellValue(gridViewRow, "建筑面积");
                    string v_计费单价 = Helper.GetCellValue(gridViewRow, "计费单价");
                    string v_表用量 = string.Empty, v_补充说明 = string.Empty;
                    float f_建筑面积, f_计费单价 = 0, f_车位费用 = 0, f_应交金额;
                    float.TryParse(v_建筑面积, out f_建筑面积);
                    float.TryParse(v_计费单价, out f_计费单价);
                    if (f_计费单价 < 0)
                    {
                        new MsgBoxForm("提示", "计费单价不能小于0，请重新输入！").ShowDialog();
                        return;
                    }
                    string dicKey = v_业主编号 + v_业主姓名;
                    if (stationFeeDic.ContainsKey(dicKey))
                    {
                        f_车位费用 = (float)stationFeeDic[dicKey].v_费用金额;
                        v_补充说明 = string.Format("车位:{0} 费用:{1}", stationFeeDic[dicKey].v_车位编号, f_车位费用);

                    }
                    f_应交金额 = f_建筑面积 * f_计费单价 + f_车位费用;
                    string query = "UPDATE 物管费用 SET 计费单价=" + v_计费单价 + ",应交金额=" + f_应交金额 + ",补充说明='" + v_补充说明 + "' WHERE 计费年份=" + v_计费年份 +
                        " AND 计费月份=" + v_计费月份 + " AND 楼栋名称='" + v_楼栋名称 + "' AND 业主编号='" + v_业主编号 + "' AND 业主姓名='" + v_业主姓名 + "'";
                    DataHelper.UpdateOrDeleteRecord(query);
                }
                DataHelper.CommitUpdate();
                SynManageRegisterInfo(v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch(Exception ex)
            {
                new MsgBoxForm("提示", "保存失败，请检查所填数据类型！").ShowDialog();
                LogHelper.LogError(ex);
            }
        } 
        private void 查询ToolStripButton_Click(object sender, EventArgs e)
        {
            string v_计费年份 = this.计费年份ToolStripComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ToolStripComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ToolStripComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，楼栋名称等信息！").ShowDialog();
                return;
            }
            SynManageRegisterInfo(v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
        }

        private void 新增ToolStripButton_Click(object sender, EventArgs e)
        {//新增物管费用信息
            string v_计费年份 = this.计费年份ToolStripComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ToolStripComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ToolStripComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，楼栋名称等信息！").ShowDialog();
                return;
            }
            if (new MsgBoxForm("提示", string.Format("现在将新增 {0}{1}年{2}月物业管理费数据，是否继续？", v_楼栋名称, v_计费年份, v_计费月份), true).ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string query = "Select 自动编号 From 物管费用 WHERE 计费年份=" + v_计费年份 + " AND 计费月份=" + v_计费月份 + " AND 楼栋名称='" + v_楼栋名称 + "'";
            DataTable myTable = DataHelper.GetDataTable(query);
            if (myTable.Rows.Count == 0)
            {
                //插入新月份的物管费用基本信息
                string insertQuery = "INSERT INTO 物管费用 (楼栋名称,业主编号,业主姓名,建筑面积,套内面积) SELECT 楼栋名称,业主编号,业主姓名,建筑面积,套内面积 FROM 业主信息 WHERE (业主编号 NOT IN (SELECT 业主编号 FROM 迁出信息)) AND (楼栋名称='" + v_楼栋名称 + "')";
                DataHelper.UpdateOrDeleteRecord(insertQuery);
                string updateQuery = "UPDATE 物管费用 SET 登记标志='正在登记',计费年份=" + v_计费年份 + ",计费月份=" + v_计费月份 + " WHERE 登记标志 IS NULL AND (楼栋名称='" + v_楼栋名称 + "')";
                DataHelper.UpdateOrDeleteRecord(updateQuery);
                int myLastMonth = Convert.ToInt16(v_计费月份) - 1;
                int myLastYear = Convert.ToInt16(v_计费年份);
                if (myLastMonth == 0)
                {
                    myLastMonth = 12;
                    myLastYear = Convert.ToInt16(v_计费年份) - 1;
                }
                //将上月计费单价作为新月物管费用计费单价
                query = "Select 业主编号,计费单价 FROM 物管费用 WHERE 计费年份=" + myLastYear + " AND 计费月份=" + myLastMonth + " AND 楼栋名称='" + v_楼栋名称 + "' AND 登记标志='完成登记'";
                DataTable myComputeTable = DataHelper.GetDataTable(query);
                foreach (DataRow dRow in myComputeTable.Rows)
                {
                    string v_业主编号 = Helper.Obj2String(dRow[0]);
                    double v_计费单价 = Helper.Obj2Double(dRow[1]);
                    query = "UPDATE 物管费用 SET 计费单价=" + v_计费单价 + " WHERE 计费年份=" + v_计费年份 + " AND 计费月份=" + v_计费月份 + " AND 楼栋名称='" + v_楼栋名称 + "' AND 业主编号='" + v_业主编号 + "'";
                    DataHelper.UpdateOrDeleteRecord(query);
                }
                DataHelper.CommitUpdate();
                SynManageRegisterInfo(v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
            }
            else
            {
                new MsgBoxForm("提示", "当月物业管理费已登记！").ShowDialog();
                return;
            }
        }
        private void 登记ToolStripButton_Click(object sender, EventArgs e)
        {//登记物管费用信息
            string v_计费年份 = this.计费年份ToolStripComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ToolStripComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ToolStripComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，楼栋名称等信息！").ShowDialog();
                return;
            }
            if (new MsgBoxForm("提示", string.Format("现在将登记{0}{1}年{2}月的物业管理费数据,登记前先保存数据,登记后的数据将无法再修改，是否继续？", v_楼栋名称, v_计费年份, v_计费月份), true).ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string query = "UPDATE 物管费用 SET 登记标志='完成登记',费用状态='未交费' WHERE 计费年份=" + v_计费年份 + " AND 计费月份=" + v_计费月份 + "  AND 楼栋名称='" + v_楼栋名称 + "' AND 应交金额>=0";
            int nRet = DataHelper.UpdateOrDeleteRecord(query);
            if (nRet > 0)
            {
                SynManageRegisterInfo(v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
                new MsgBoxForm("提示", "登记成功！").ShowDialog();
            }
            else
            {
                new MsgBoxForm("提示", "登记失败，请确认是否已经保存了费用信息！").ShowDialog();
            }
        }

        private void SynManageRegisterInfo(string v_计费年份, string v_计费月份, string v_楼栋名称, string v_登记标志)
        {
            string query = string.Format("select * from 物管费用 where 计费年份={0} and 计费月份={1} and 楼栋名称='{2}' and 登记标志='{3}'", v_计费年份, v_计费月份, v_楼栋名称, v_登记标志);
            DataTable dt = DataHelper.GetDataTable(query);
            this.物管费用DataGridView.Rows.Clear();
            foreach (DataRow dRow in dt.Rows)
            {
                object[] objs = new object[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string columnName = dt.Columns[i].ColumnName;
                    objs[i] = dRow[columnName].ToString();
                }
                this.物管费用DataGridView.Rows.Add(objs);
            }
            if (dt.Rows.Count > 0)
                this.bindingNavigatorDeleteItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string v_计费年份 = this.计费年份ToolStripComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ToolStripComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ToolStripComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，费用类型，楼栋名称等信息！").ShowDialog();
                return;
            }
            string tipInfo = string.Format("{0}{1}年{2}月的物业管理费", v_楼栋名称, v_计费年份, v_计费月份);
            if (new MsgBoxForm("警告", "确定要删除 " + tipInfo + " 信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 物管费用 where 计费年份={0} and 计费月份={1} and 楼栋名称='{2}' and 登记标志='{3}'", v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
                DataHelper.UpdateOrDeleteRecord(query);
                SynManageRegisterInfo(v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
            }
        }
    }

    public class StationFeeInfo
    {
        public string v_车位编号 { set; get; }
        public double v_费用金额 { set; get; }
    }
}