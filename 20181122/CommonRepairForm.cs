//文件名：CommonRepairForm.cs
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
    public partial class CommonRepairForm : DevComponents.DotNetBar.Office2007Form
    {
        private System.Data.DataTable dtData = null;
        private string MyCommunity;
        private string MyPrintIcon;
        public CommonRepairForm(string myCommunity, string myPrintIcon)
        {
            this.MyCommunity = myCommunity;
            this.MyPrintIcon = myPrintIcon;
            InitializeComponent();
            InitCommonProperty();
        }
        private void CommonRepairForm_Load(object sender, EventArgs e)
        {
            SynCommonRepair();  
        }
        private void 公共维修BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            string v_维修编号 = string.Format("GW{0}", DateTime.Now.ToString("yyMMddHHmmss"));
            Helper.SetTextBoxCtrlValue(this.Controls, "维修编号", v_维修编号);
            if (string.IsNullOrEmpty(this.维修编号TextBox.Text))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            try
            {
                string v_财产编号 = Helper.GetTextBoxCtrlValue(this.Controls, "财产编号");
                string v_财产名称 = Helper.GetComBoxCtrlValue(this.Controls, "财产名称");
                string v_报修日期 = Helper.GetDateCtrlValue(this.Controls, "报修日期");
                string v_报修人员 = Helper.GetTextBoxCtrlValue(this.Controls, "报修人员");
                string v_故障现象 = Helper.GetTextBoxCtrlValue(this.Controls, "故障现象");
                string v_受理人员 = Helper.GetTextBoxCtrlValue(this.Controls, "受理人员");
                string v_处理意见 = Helper.GetTextBoxCtrlValue(this.Controls, "处理意见");
                string v_修理日期 = Helper.GetDateCtrlValue(this.Controls, "修理日期");
                string v_修理人员 = Helper.GetTextBoxCtrlValue(this.Controls, "修理人员");
                string v_修理费用 = Helper.GetTextBoxCtrlValue(this.Controls, "修理费用");
                string v_材料费用 = Helper.GetTextBoxCtrlValue(this.Controls, "材料费用");
                string v_费用合计 = string.Empty;
                string v_修理结果 = Helper.GetTextBoxCtrlValue(this.Controls, "修理结果");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");
                float repairFee = 0, resFee = 0;
                float.TryParse(v_修理费用, out repairFee);
                float.TryParse(v_材料费用, out resFee);
                v_费用合计 = (repairFee + resFee).ToString();
                string query = string.Empty;
                if (IsNewAdded(v_维修编号))
                {
                    query = string.Format("insert into 公共维修(`维修编号`, `财产编号`, `财产名称`, `报修日期`, `报修人员`, `故障现象`, `受理人员`, `处理意见`, `修理日期`, `修理人员`, `修理费用`, `材料费用`, `费用合计`, `修理结果`,`补充说明`)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                        v_维修编号, v_财产编号, v_财产名称, v_报修日期, v_报修人员, v_故障现象, v_受理人员, v_处理意见, v_修理日期, v_修理人员, v_修理费用, v_材料费用, v_费用合计, v_修理结果, v_补充说明);
                }
                else
                {
                    query = string.Format("update 公共维修 set 财产编号='{0}',财产名称='{1}',报修日期='{2}',报修人员='{3}',故障现象='{4}',受理人员='{4}',处理意见='{6}',修理日期='{7}',修理人员='{8}',修理费用='{9}',材料费用='{10}', 费用合计='{11}', 修理结果='{12}', 补充说明='{13}' where 维修编号='{14}'",
                        v_财产编号, v_财产名称, v_报修日期, v_报修人员, v_故障现象, v_受理人员, v_处理意见, v_修理日期, v_修理人员, v_修理费用, v_材料费用, v_费用合计, v_修理结果, v_补充说明, v_维修编号);
                }
                SaveNewCommonRepair(query);
                SynCommonRepair();
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
            SynCommonRepair();
        }
        private void 财产名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.财产名称ComboBox.SelectedValue != null && this.财产名称ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                this.财产编号TextBox.Text = this.财产名称ComboBox.SelectedValue.ToString();
            }
        }

        private void InitCommonProperty()
        {
            string query = "select * from 公共财产";
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            this.财产名称ComboBox.DataSource = dt;
            this.财产名称ComboBox.DisplayMember = "财产名称";
            this.财产名称ComboBox.ValueMember = "财产编号";
        }

        private void SaveNewCommonRepair(string query)
        {
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private bool IsNewAdded(string repairNo)
        {
            string query = string.Format("select * from 公共维修 where 维修编号='{0}'", repairNo);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void SynCommonRepair()
        {
            string repairNo = this.维修编号ToolStripTextBox.Text.Trim();
            string query = string.Empty;
            if (!string.IsNullOrEmpty(repairNo))
                query = string.Format("select * from 公共维修 where 维修编号 like '%{0}%' order by 维修编号 desc", repairNo);
            else
                query = "select * from 公共维修 order by 维修编号 desc";
            dtData = DataHelper.GetDataTable(query);
            this.公共维修DataGridView.DataSource = dtData;
        }

        private void 打印ToolStripButton_Click(object sender, EventArgs e)
        {//打印公共财产维修单
            this.printPreviewDialog1.Document = this.printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.Icon = new Icon(this.MyPrintIcon);
            this.printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.MyCommunity + "公共财产维修单", new Font("宋体", 20), Brushes.Black, 200, 90);
            e.Graphics.DrawString("维修编号：" + Helper.Obj2String(this.公共维修DataGridView.CurrentRow.Cells[0].Value), new Font("宋体", 10), Brushes.Black, 100, 145);
            e.Graphics.DrawString("打印日期：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), new Font("宋体", 10), Brushes.Black, 515, 145);
            e.Graphics.DrawLine(new Pen(Color.Black,(float)3.00), 100, 165, 720, 165);
            e.Graphics.DrawString("财产编号：" + Helper.Obj2String(this.公共维修DataGridView.CurrentRow.Cells[1].Value), new Font("宋体", 10), Brushes.Black, 100, 175);
            e.Graphics.DrawString("财产名称：" + Helper.Obj2String(this.公共维修DataGridView.CurrentRow.Cells[2].Value), new Font("宋体", 10), Brushes.Black, 300, 175);
            e.Graphics.DrawString("报修日期：" + Helper.Obj2Date(this.公共维修DataGridView.CurrentRow.Cells[3].Value).ToString("yyyy-MM-dd"), new Font("宋体", 10), Brushes.Black, 550, 175);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 195, 720, 195);
            e.Graphics.DrawString("报修人员：" + Helper.Obj2String(this.公共维修DataGridView.CurrentRow.Cells[4].Value), new Font("宋体", 10), Brushes.Black, 100, 200);
            e.Graphics.DrawString("受理人员：" + Helper.Obj2String(this.公共维修DataGridView.CurrentRow.Cells[6].Value), new Font("宋体", 10), Brushes.Black, 300, 200);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 220, 720, 220);
            e.Graphics.DrawString("故障现象：" , new Font("宋体", 10), Brushes.Black, 100, 225);
            e.Graphics.DrawString(Helper.Obj2String(this.公共维修DataGridView.CurrentRow.Cells[5].Value), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 245, 620, 90));
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 335, 720, 335);
            e.Graphics.DrawString("处理意见：", new Font("宋体", 10), Brushes.Black, 100, 340);
            e.Graphics.DrawString(Helper.Obj2String(this.公共维修DataGridView.CurrentRow.Cells[7].Value), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 360, 620, 90));
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 450, 720, 450);
            e.Graphics.DrawString("修理日期：" + Helper.Obj2Date(this.公共维修DataGridView.CurrentRow.Cells[8].Value).ToString("yyyy-MM-dd"), new Font("宋体", 10), Brushes.Black, 100, 455);
            e.Graphics.DrawString("修理人员：" + Helper.Obj2String(this.公共维修DataGridView.CurrentRow.Cells[9].Value), new Font("宋体", 10), Brushes.Black, 250, 455);
            e.Graphics.DrawString("修理费用：" + Helper.Obj2Double(this.公共维修DataGridView.CurrentRow.Cells[10].Value) + "元", new Font("宋体", 10), Brushes.Black, 370, 455);
            e.Graphics.DrawString("材料费用：" + Helper.Obj2Double(this.公共维修DataGridView.CurrentRow.Cells[11].Value) + "元", new Font("宋体", 10), Brushes.Black, 480, 455);
            double My费用合计 = Helper.Obj2Double(this.公共维修DataGridView.CurrentRow.Cells[10].Value) + Helper.Obj2Double(this.公共维修DataGridView.CurrentRow.Cells[11].Value);
            e.Graphics.DrawString("费用合计：" + My费用合计.ToString() + "元", new Font("宋体", 10), Brushes.Black, 590, 455);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 475, 720, 475);
            e.Graphics.DrawString("修理结果：", new Font("宋体", 10), Brushes.Black, 100, 480);
            e.Graphics.DrawString(Helper.Obj2String(this.公共维修DataGridView.CurrentRow.Cells[13].Value), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 500, 620, 240));
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 765, 720, 765);
            e.Graphics.DrawString("补充说明：", new Font("宋体", 10), Brushes.Black, 100, 770);
            e.Graphics.DrawString(Helper.Obj2String(this.公共维修DataGridView.CurrentRow.Cells[14].Value), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 790, 620, 205));
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 1000, 720, 1000);            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string repairNo = this.维修编号TextBox.Text.Trim();
            string propertyName = this.财产名称ComboBox.Text.Trim();
            if (string.IsNullOrEmpty(repairNo) || string.IsNullOrEmpty(propertyName))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            }
            string tipInfo = string.Format("{0}(维修编号：{1})", propertyName, repairNo);
            if (new MsgBoxForm("警告", "确定要删除财产 " + tipInfo + " 的维修信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 公共维修 where 维修编号='{0}' and 财产名称='{1}'", repairNo, propertyName);
                SaveNewCommonRepair(query);
                SynCommonRepair();
            }
        }

        private void 公共维修DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "财产名称" };
            List<string> dateNames = new List<string> { "报修日期", "修理日期" };
            DataGridViewRow currRow = this.公共维修DataGridView.CurrentRow;
            for (int i = 0; i < this.公共维修DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.公共维修DataGridView.Columns[i].DataPropertyName;
                string columnName = this.公共维修DataGridView.Columns[i].Name;
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "财产名称" };
            List<string> dateNames = new List<string> { "报修日期", "修理日期" };
            for (int i = 0; i < this.公共维修DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.公共维修DataGridView.Columns[i].DataPropertyName;
                string columnName = this.公共维修DataGridView.Columns[i].Name;
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
            this.维修编号TextBox.Text = "自动生成";
        }
    }
}