using MyCommunity.Common;
//文件名：EventForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCommunity
{
    public partial class EventForm : Form
    {
        private System.Data.DataTable dtData = null;
        public EventForm()
        {
            InitializeComponent();
        }
        public string MyCommunity;
        private void EventForm_Load(object sender, EventArgs e)
        {
            SynEvent();
        }
        private void 突发事件BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            string v_事件编号 = string.Format("TF{0}", DateTime.Now.ToString("yyMMddHHmmss"));
            Helper.SetTextBoxCtrlValue(this.Controls, "事件编号", v_事件编号);
            if (string.IsNullOrEmpty(this.事件编号TextBox.Text))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            try
            {
                string v_发生日期 = Helper.GetDateCtrlValue(this.Controls, "发生日期");
                string v_处理人员 = Helper.GetTextBoxCtrlValue(this.Controls, "处理人员");
                string v_事件主题 = Helper.GetTextBoxCtrlValue(this.Controls, "事件主题");
                string v_事件内容 = Helper.GetTextBoxCtrlValue(this.Controls, "事件内容");
                string v_处理结果 = Helper.GetTextBoxCtrlValue(this.Controls, "处理结果");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");
                string query = string.Empty;
                if (IsNewAdded(v_事件编号))
                {
                    query = string.Format("insert into 突发事件(`事件编号`, `发生日期`, `处理人员`, `事件主题`, `事件内容`, `处理结果`, `补充说明`)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                        v_事件编号, v_发生日期, v_处理人员, v_事件主题, v_事件内容, v_处理结果, v_补充说明);
                }
                else
                {
                    query = string.Format("update 突发事件 set 发生日期='{0}',处理人员='{1}',事件主题='{2}',事件内容='{3}',处理结果='{4}',补充说明='{5}' where 事件编号='{6}'",
                        v_发生日期, v_处理人员, v_事件主题, v_事件内容, v_处理结果, v_补充说明, v_事件编号);
                }
                SaveNewEvent(query);
                SynEvent();
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }
        private void 查询ToolStripButton_Click(object sender, EventArgs e)
        {
            SynEvent();
        }
        private void 打印ToolStripButton_Click(object sender, EventArgs e)
        {//打印突发事件信息单
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.ShowDialog();
        }

        private void SaveNewEvent(string query)
        {
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private bool IsNewAdded(string eventNo)
        {
            string query = string.Format("select * from 突发事件 where 事件编号='{0}'", eventNo);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void SynEvent()
        {
            string eventNo = this.事件编号ToolStripTextBox.Text.Trim();
            string query = string.Empty;
            if (!string.IsNullOrEmpty(eventNo))
                query = string.Format("select * from 突发事件 where 事件编号 like '%{0}%' order by 事件编号 desc", eventNo);
            else
                query = "select * from 突发事件 order by 事件编号 desc";
            dtData = DataHelper.GetDataTable(query);
            this.突发事件DataGridView.DataSource = dtData;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.MyCommunity + "突发事件信息表", new Font("宋体", 20), Brushes.Black, 200, 90);
            e.Graphics.DrawString("事件编号：" + this.突发事件DataGridView.CurrentRow.Cells[0].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 145);
            e.Graphics.DrawString("打印日期：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), new Font("宋体", 10), Brushes.Black, 515, 145);
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 165, 720, 165);
            e.Graphics.DrawString("发生日期：" + DateTime.Parse(this.突发事件DataGridView.CurrentRow.Cells[1].Value.ToString()).ToShortDateString(), new Font("宋体", 10), Brushes.Black, 100, 175);
            e.Graphics.DrawString("处理人员：" + this.突发事件DataGridView.CurrentRow.Cells[2].Value.ToString(), new Font("宋体", 10), Brushes.Black, 450, 175);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 195, 720, 195);
            e.Graphics.DrawString("事件主题：" + this.突发事件DataGridView.CurrentRow.Cells[3].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 200);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 220, 720, 220);
            e.Graphics.DrawString("事件内容：", new Font("宋体", 10), Brushes.Black, 100, 225);
            e.Graphics.DrawString(this.突发事件DataGridView.CurrentRow.Cells[4].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 245, 620, 230));
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 475, 720, 475);
            e.Graphics.DrawString("处理结果：", new Font("宋体", 10), Brushes.Black, 100, 480);
            e.Graphics.DrawString(this.突发事件DataGridView.CurrentRow.Cells[5].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 500, 620, 340));
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 845, 720, 845);
            e.Graphics.DrawString("补充说明：", new Font("宋体", 10), Brushes.Black, 100, 850);
            e.Graphics.DrawString(this.突发事件DataGridView.CurrentRow.Cells[6].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 870, 620, 125));
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 1000, 720, 1000);       
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string eventNo = this.事件编号TextBox.Text.Trim();
            if (string.IsNullOrEmpty(eventNo))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            }
            string tipInfo = string.Format("{0})", eventNo);
            if (new MsgBoxForm("警告", "确定要删除突发事件 " + tipInfo + " 的信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 突发事件 where 事件编号='{0}'", eventNo);
                SaveNewEvent(query);
                SynEvent();
            }
        }

        private void 突发事件DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { };
            List<string> dateNames = new List<string> { "发生日期" };
            DataGridViewRow currRow = this.突发事件DataGridView.CurrentRow;
            for (int i = 0; i < this.突发事件DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.突发事件DataGridView.Columns[i].DataPropertyName;
                string columnName = this.突发事件DataGridView.Columns[i].Name;
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
    }
}