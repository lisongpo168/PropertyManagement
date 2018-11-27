//文件名：GasRegisterForm.cs
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
    public partial class GasRegisterForm : DevComponents.DotNetBar.Office2007Form
    {
        public GasRegisterForm()
        {
            InitializeComponent();
        }

        private void GasRegisterForm_Load(object sender, EventArgs e)
        {
            for (int i = 2009; i <= 2099; i++)
            {
                this.计费年份ToolStripComboBox.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                this.计费月份ToolStripComboBox.Items.Add(i.ToString());
            }
            string query = "select * from 小区信息";
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            foreach (System.Data.DataRow dRow in dt.Rows)
            {
                this.小区名称ToolStripComboBox.Items.Add(dRow["小区名称"].ToString());
            }
        }               
        private void 查询ToolStripButton_Click(object sender, EventArgs e)
        {
            string v_小区名称 = this.小区名称ToolStripComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ToolStripComboBox.Text.Trim();
            string v_计费年份 = this.计费年份ToolStripComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ToolStripComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_小区名称) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，小区名称，楼栋名称等信息！").ShowDialog();
                return;
            }
            SynGasRegisterInfo(v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
        }
        private void 水电气费BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            string v_小区名称 = this.小区名称ToolStripComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ToolStripComboBox.Text.Trim();
            string v_计费年份 = this.计费年份ToolStripComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ToolStripComboBox.Text.Trim();
            string v_费用类型 = "物业费用";
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_小区名称) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，小区名称，楼栋名称等信息！").ShowDialog();
                return;
            }

            try
            {
                PriceInfo priceInfo = PriceHelper.GetPriceInfo();
                foreach (DataGridViewRow gridViewRow in this.水电气费DataGridView.Rows)
                {
                    string v_业主编号 = Helper.GetCellValue(gridViewRow, "业主编号");
                    if (string.IsNullOrEmpty(v_业主编号))
                        continue;
                    string v_业主姓名 = Helper.GetCellValue(gridViewRow, "业主姓名");
                    string v_表编号 = Helper.GetCellValue(gridViewRow, "表编号");
                    string v_上月数 = Helper.GetCellValue(gridViewRow, "上月数");
                    string v_本月数 = Helper.GetCellValue(gridViewRow, "本月数");
                    string v_计费单价 = Helper.GetCellValue(gridViewRow, "计费单价");
                    string v_表用量 = string.Empty, v_补充说明 = string.Empty;
                    float f_表底数 = 0, f_表止数 = 0, f_计费单价 = 0, f_应交金额;
                    float.TryParse(v_上月数, out f_表底数);
                    float.TryParse(v_本月数, out f_表止数);
                    float.TryParse(v_计费单价, out f_计费单价);

                    if (f_表底数 > f_表止数)
                    {
                        new MsgBoxForm("提示", "本月数不能小于上月数，请重新输入！").ShowDialog();
                        return;
                    }
                    if (f_计费单价 < 0)
                    {
                        new MsgBoxForm("提示", "计费单价不能小于0，请重新输入！").ShowDialog();
                        return;
                    }
                    v_表用量 = (f_表止数 - f_表底数).ToString("N2");
                    f_应交金额 = (f_表止数 - f_表底数) * f_计费单价;
                    v_补充说明 = string.Format("含公共照明:{0} 电力损耗:{1}", ((f_表止数 - f_表底数) * priceInfo.d_公共照明价格).ToString("N3"), ((f_表止数 - f_表底数) * priceInfo.d_电力损耗价格).ToString("N3"));
                    string query = "UPDATE 水电气费 SET 上月数=" + v_上月数 + ",本月数=" + v_本月数 + ",表用量=" + v_表用量 + ",计费单价=" + v_计费单价 + ",应交金额=" + f_应交金额 + ",补充说明='" + v_补充说明 + "' WHERE 计费年份=" + v_计费年份 +
                        " AND 计费月份=" + v_计费月份 + " AND 费用类型='" + v_费用类型 + "' AND 楼栋名称='" + v_楼栋名称 + "' AND 业主编号='" + v_业主编号 + "' AND 业主姓名='" + v_业主姓名 + "' AND 表编号='" + v_表编号 + "'";
                    DataHelper.UpdateOrDeleteRecord(query);
                }
                DataHelper.CommitUpdate();
                SynGasRegisterInfo(v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {
                new MsgBoxForm("提示", "保存失败，请检查所填数据类型！").ShowDialog();
                LogHelper.LogError(ex);
            }
        }
        private void 新增ToolStripButton_Click(object sender, EventArgs e)
        {//新增水电气费
            string v_费用类型 = "物业费用";
            string v_小区名称 = this.小区名称ToolStripComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ToolStripComboBox.Text.Trim();
            string v_计费年份 = this.计费年份ToolStripComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ToolStripComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_小区名称) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，小区名称，楼栋名称等信息！").ShowDialog();
                return;
            }
            double d_计费单价 = PriceHelper.GetPrice("电费");
            if (d_计费单价 <= 0)
            {
                new MsgBoxForm("提示", string.Format("{0}计费单价还未设定，请先在小区信息设置界面进行设置！", "电费")).ShowDialog();
                return;
            }
            if (new MsgBoxForm("提示", string.Format("现在将新增{0}-{1}{2}年{3}月的{4}数据，是否继续？", v_小区名称,v_楼栋名称, v_计费年份, v_计费月份, v_费用类型), true).ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string query = string.Format("select 自动编号 from 水电气费 where 计费年份={0} and 计费月份={1} and 费用类型='{2}' and 楼栋名称='{3}'", v_计费年份, v_计费月份, v_费用类型, v_楼栋名称);
            DataTable dt = DataHelper.GetDataTable(query);
            if (dt.Rows.Count == 0)
            {//插入新月份费用的业主基本信息
                string insertQuery = "INSERT INTO 水电气费 (楼栋名称,业主编号,业主姓名,表编号) SELECT 业主信息.楼栋名称,业主信息.业主编号,业主信息.业主姓名,电表信息.电表编号 from 业主信息 right join 电表信息 on 业主信息.业主编号=电表信息.业主编号 WHERE (业主信息.业主编号 NOT IN (SELECT 业主编号 FROM 迁出信息)) AND (业主信息.楼栋名称='" + v_楼栋名称 + "')";
                DataHelper.UpdateOrDeleteRecord(insertQuery);
                string updateQuery = "UPDATE 水电气费 SET 登记标志='正在登记',费用类型='" + v_费用类型 + "',计费年份=" + v_计费年份 + ",计费月份=" + v_计费月份 + " WHERE 登记标志 IS NULL AND (楼栋名称='" + v_楼栋名称 + "')";
                DataHelper.UpdateOrDeleteRecord(updateQuery);
                int MyLastMonth = Convert.ToInt16(v_计费月份) - 1;
                int MyLastYear = Convert.ToInt16(v_计费年份);
                if (MyLastMonth == 0)
                {
                    MyLastMonth = 12;
                    MyLastYear = Convert.ToInt16(v_计费年份) - 1;
                }
                //将上月止数作为新月份底数
                string lastMonthQuery = "Select 楼栋名称,业主编号,业主姓名,计费年份,计费月份,费用类型,表编号,上月数,本月数 FROM 水电气费 WHERE 计费年份=" + MyLastYear + " AND 计费月份=" + MyLastMonth + " AND 费用类型='" + v_费用类型 + "' AND 楼栋名称='" + v_楼栋名称 + "' AND 登记标志='完成登记'";
                DataTable myLastMonthTable = DataHelper.GetDataTable(lastMonthQuery);
                if (myLastMonthTable.Rows.Count > 0)
                {
                    foreach (DataRow dRow in myLastMonthTable.Rows)
                    {
                        string My楼栋名称 = Helper.Obj2String(dRow[0]);
                        string My业主编号 = Helper.Obj2String(dRow[1]);
                        string My计费年份 = Helper.Obj2String(dRow[3]);
                        string My计费月份 = Helper.Obj2String(dRow[4]);
                        string My费用类型 = Helper.Obj2String(dRow[5]);
                        string My表编号 = Helper.Obj2String(dRow[6]);
                        double My上月数 = Helper.Obj2Double(dRow[7]);
                        double My本月数 = Helper.Obj2Double(dRow[8]);
                        updateQuery = "UPDATE 水电气费 SET 上月数=" + My本月数 + ",计费单价=" + d_计费单价 + " WHERE 计费年份=" + v_计费年份 + " AND 计费月份=" + v_计费月份 + " AND 费用类型='" + v_费用类型 + "' AND 楼栋名称='" + v_楼栋名称 + "' AND 业主编号='" + My业主编号 + "' AND 表编号='" + My表编号 + "'";
                        DataHelper.UpdateOrDeleteRecord(updateQuery);
                    }
                }
                else
                {
                    updateQuery = "UPDATE 水电气费 SET 计费单价=" + d_计费单价 + " WHERE 计费年份=" + v_计费年份 + " AND 计费月份=" + v_计费月份 + " AND 费用类型='" + v_费用类型 + "' AND 楼栋名称='" + v_楼栋名称 + "'";
                    DataHelper.UpdateOrDeleteRecord(updateQuery);
                }
                DataHelper.CommitUpdate();
                SynGasRegisterInfo(v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
            }
            else
            {
                new MsgBoxForm("提示", "当月" + v_费用类型 + "已登记！").ShowDialog();
                return;
            }  
        }
        private void 登记ToolStripButton_Click(object sender, EventArgs e)
        {
            string v_费用类型 = "物业费用";
            string v_小区名称 = this.小区名称ToolStripComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ToolStripComboBox.Text.Trim();
            string v_计费年份 = this.计费年份ToolStripComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ToolStripComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_小区名称) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，小区名称，楼栋名称等信息！").ShowDialog();
                return;
            }

            if (new MsgBoxForm("提示", string.Format("现在将登记{0}-{1}{2}年{3}月的{4}数据，登记前先保存数据,登记后本月正在登记的数据将无法再修改，是否继续？", v_小区名称,v_楼栋名称, v_计费年份, v_计费月份, v_费用类型), true).ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string query = "UPDATE 水电气费 SET 登记标志='完成登记',费用状态='未交费' WHERE 计费年份=" + v_计费年份 + " AND 计费月份=" + v_计费月份 + " AND 费用类型='" + v_费用类型 + "' AND 楼栋名称='" + v_楼栋名称 + "' AND 应交金额>=0";
            int nRet = DataHelper.UpdateOrDeleteRecord(query);
            if (nRet > 0)
            {
                SynGasRegisterInfo(v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
                new MsgBoxForm("提示", "登记成功！").ShowDialog();
            }
            else
            {
                new MsgBoxForm("提示", "登记失败，请确认是否已经保存了费用信息！").ShowDialog();
            }
        }

        private void SynGasRegisterInfo(string v_计费年份, string v_计费月份, string v_楼栋名称, string v_登记标志)
        {
            string query = string.Format("select * from 水电气费 where 计费年份={0} and 计费月份={1} and 费用类型='{2}' and 楼栋名称='{3}' and 登记标志='{4}'", v_计费年份, v_计费月份, "物业费用", v_楼栋名称, v_登记标志);
            DataTable dt = DataHelper.GetDataTable(query);
            this.水电气费DataGridView.Rows.Clear();
            foreach (DataRow dRow in dt.Rows)
            {
                object[] objs = new object[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string columnName = dt.Columns[i].ColumnName;
                    objs[i] = dRow[columnName].ToString();
                }
                this.水电气费DataGridView.Rows.Add(objs);
            }
            if (dt.Rows.Count > 0)
                this.bindingNavigatorDeleteItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string v_费用类型 = "物业费用";
            string v_小区名称 = this.小区名称ToolStripComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ToolStripComboBox.Text.Trim();
            string v_计费年份 = this.计费年份ToolStripComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ToolStripComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_小区名称) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，小区名称，楼栋名称等信息！").ShowDialog();
                return;
            }
            string tipInfo = string.Format("{0}-{1}{2}年{3}月的{4}",v_小区名称,v_楼栋名称, v_计费年份, v_计费月份, v_费用类型);
            if (new MsgBoxForm("警告", "确定要删除 " + tipInfo + " 信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 水电气费 where 计费年份={0} and 计费月份={1} and 费用类型='{2}' and 楼栋名称='{3}' and 登记标志='{4}'", v_计费年份, v_计费月份, v_费用类型, v_楼栋名称, "正在登记");
                DataHelper.UpdateOrDeleteRecord(query);
                SynGasRegisterInfo(v_计费年份, v_计费月份, v_楼栋名称, "正在登记");
            }
        }

        private void 小区名称ToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v_小区名称 = this.小区名称ToolStripComboBox.Text;
            string query = "SELECT * FROM 楼栋信息 WHERE (小区名称 = '" + v_小区名称 + "')";
            DataTable myTable = DataHelper.GetDataTable(query);
            this.楼栋名称ToolStripComboBox.Items.Clear();
            foreach (DataRow dRow in myTable.Rows)
            {
                this.楼栋名称ToolStripComboBox.Items.Add(dRow["楼栋名称"].ToString());
            }
        }
   }
}