using MyCommunity.Common;
//文件名：ComplainForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCommunity
{
    public partial class ComplainForm : Form
    {
        private System.Data.DataTable dtData = null;
        public ComplainForm()
        {
            InitializeComponent();
            InitCmbBuilding();
        }
        public string MyCommunity;
        private void ComplainForm_Load(object sender, EventArgs e)
        {
            SynComplain();
        }
        private void 服务投诉BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            string v_投诉编号 = string.Format("TS{0}", DateTime.Now.ToString("yyMMddHHmmss"));
            Helper.SetTextBoxCtrlValue(this.Controls, "投诉编号", v_投诉编号);
            if (string.IsNullOrEmpty(this.投诉编号TextBox.Text))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            try
            {
                string v_楼栋名称 = Helper.GetComBoxCtrlValue(this.Controls, "楼栋名称");
                string v_业主编号 = Helper.GetTextBoxCtrlValue(this.Controls, "业主编号");
                string v_业主姓名 = Helper.GetComBoxCtrlValue(this.Controls, "业主姓名");
                string v_投诉日期 = Helper.GetDateCtrlValue(this.Controls, "投诉日期");
                string v_接待人员 = Helper.GetTextBoxCtrlValue(this.Controls, "接待人员");
                string v_投诉主题 = Helper.GetTextBoxCtrlValue(this.Controls, "投诉主题");
                string v_投诉内容 = Helper.GetTextBoxCtrlValue(this.Controls, "投诉内容");
                string v_处理日期 = Helper.GetDateCtrlValue(this.Controls, "处理日期");
                string v_处理人员 = Helper.GetTextBoxCtrlValue(this.Controls, "处理人员");
                string v_处理意见 = Helper.GetTextBoxCtrlValue(this.Controls, "处理意见");
                string v_处理结果 = Helper.GetTextBoxCtrlValue(this.Controls, "处理结果");
                string v_业主反馈 = Helper.GetTextBoxCtrlValue(this.Controls, "业主反馈");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");
                string query = string.Empty;
                if (IsNewAdded(v_投诉编号))
                {
                    query = string.Format("insert into 服务投诉(`投诉编号`, `楼栋名称`, `业主编号`, `业主姓名`, `投诉日期`, `接待人员`, `投诉主题`, `投诉内容`, `处理日期`, `处理人员`, `处理意见`, `处理结果`, `业主反馈`,`补充说明`)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                        v_投诉编号, v_楼栋名称, v_业主编号, v_业主姓名, v_投诉日期, v_接待人员, v_投诉主题, v_投诉内容, v_处理日期, v_处理人员, v_处理意见, v_处理结果, v_业主反馈, v_补充说明);
                }
                else
                {
                    query = string.Format("update 服务投诉 set 楼栋名称='{0}',业主编号='{1}',业主姓名='{2}',投诉日期='{3}',接待人员='{4}',投诉主题='{5}',投诉内容='{6}',处理日期='{7}',处理人员='{8}',处理意见='{9}',处理结果='{10}', 业主反馈='{11}',补充说明='{12}' where 投诉编号='{13}'",
                        v_楼栋名称, v_业主编号, v_业主姓名, v_投诉日期, v_接待人员, v_投诉主题, v_投诉内容, v_处理日期, v_处理人员, v_处理意见, v_处理结果, v_业主反馈, v_补充说明, v_投诉编号);
                }
                SaveNewComplain(query);
                SynComplain();
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }
        private void 查询ToolStripButton_Click(object sender, EventArgs e)
        {
            SynComplain();
        }
        private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {//获取指定楼栋的业主姓名
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
        {//获取指定业主的编号
            if (this.业主姓名ComboBox.SelectedValue != null && this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                this.业主编号TextBox.Text = this.业主姓名ComboBox.SelectedValue.ToString();
            }
            else
                this.业主姓名ComboBox.Text = string.Empty;
        }
        private void 打印ToolStripButton_Click(object sender, EventArgs e)
        {//打印服务投诉处理单
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.ShowDialog();
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

        private void SaveNewComplain(string query)
        {
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private bool IsNewAdded(string complainNo)
        {
            string query = string.Format("select * from 服务投诉 where 投诉编号='{0}'", complainNo);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void SynComplain()
        {
            string complainNo = this.投诉编号ToolStripTextBox.Text.Trim();
            string query = string.Empty;
            if (!string.IsNullOrEmpty(complainNo))
                query = string.Format("select * from 服务投诉 where 投诉编号 like '%{0}%' order by 投诉编号 desc", complainNo);
            else
                query = "select * from 服务投诉 order by 投诉编号 desc";
            dtData = DataHelper.GetDataTable(query);
            this.服务投诉DataGridView.DataSource = dtData;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.MyCommunity + "服务投诉处理单", new Font("宋体", 20), Brushes.Black, 200, 90);
            e.Graphics.DrawString("投诉编号：" + this.服务投诉DataGridView.CurrentRow.Cells[0].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 145);
            e.Graphics.DrawString("打印时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), new Font("宋体", 10), Brushes.Black, 515, 145);
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 165, 720, 165);
            e.Graphics.DrawString("楼栋名称：" + this.服务投诉DataGridView.CurrentRow.Cells[1].Value.ToString(), new Font("宋体", 10), Brushes.Black, 100, 175);
            e.Graphics.DrawString("业主编号：" + this.服务投诉DataGridView.CurrentRow.Cells[2].Value.ToString(), new Font("宋体", 10), Brushes.Black, 250, 175);
            e.Graphics.DrawString("业主姓名：" + this.服务投诉DataGridView.CurrentRow.Cells[3].Value.ToString(), new Font("宋体", 10), Brushes.Black, 450, 175);
            e.Graphics.DrawString("接待人员：" + this.服务投诉DataGridView.CurrentRow.Cells[5].Value.ToString(), new Font("宋体", 10), Brushes.Black, 580, 175);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 195, 720, 195);
            e.Graphics.DrawString("投诉日期：" + DateTime.Parse(this.服务投诉DataGridView.CurrentRow.Cells[4].Value.ToString()).ToShortDateString(), new Font("宋体", 10), Brushes.Black, 100, 200);
            e.Graphics.DrawString("投诉主题：" + this.服务投诉DataGridView.CurrentRow.Cells[6].Value.ToString(), new Font("宋体", 10), Brushes.Black, 250, 200);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 220, 720, 220);
            e.Graphics.DrawString("投诉内容：", new Font("宋体", 10), Brushes.Black, 100, 225);
            e.Graphics.DrawString(this.服务投诉DataGridView.CurrentRow.Cells[7].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 245, 620, 90));
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 335, 720, 335);
            e.Graphics.DrawString("处理意见：", new Font("宋体", 10), Brushes.Black, 100, 340);
            e.Graphics.DrawString(this.服务投诉DataGridView.CurrentRow.Cells[10].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 360, 620, 90));
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 450, 720, 450);
            e.Graphics.DrawString("处理日期：" + DateTime.Parse(this.服务投诉DataGridView.CurrentRow.Cells[8].Value.ToString()).ToShortDateString(), new Font("宋体", 10), Brushes.Black, 100, 455);
            e.Graphics.DrawString("处理人员：" + this.服务投诉DataGridView.CurrentRow.Cells[9].Value.ToString(), new Font("宋体", 10), Brushes.Black, 450, 455);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 475, 720, 475);
            e.Graphics.DrawString("处理结果：", new Font("宋体", 10), Brushes.Black, 100, 480);
            e.Graphics.DrawString(this.服务投诉DataGridView.CurrentRow.Cells[11].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 500, 620, 150));
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 635, 720, 635);
            e.Graphics.DrawString("业主反馈：", new Font("宋体", 10), Brushes.Black, 100, 640);
            e.Graphics.DrawString(this.服务投诉DataGridView.CurrentRow.Cells[12].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 660, 620, 200));
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 845, 720, 845);
            e.Graphics.DrawString("补充说明：", new Font("宋体", 10), Brushes.Black, 100, 850);
            e.Graphics.DrawString(this.服务投诉DataGridView.CurrentRow.Cells[13].Value.ToString(), new Font("宋体", 10), Brushes.Black, new RectangleF(110, 870, 620, 125));
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 1000, 720, 1000);       
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string complainNo = this.投诉编号TextBox.Text.Trim();
            string ownerName = this.业主姓名ComboBox.Text.Trim();
            if (string.IsNullOrEmpty(complainNo) || string.IsNullOrEmpty(ownerName))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            }
            string tipInfo = string.Format("{0}(投诉编号：{1})", ownerName, complainNo);
            if (new MsgBoxForm("警告", "确定要删除业主 " + tipInfo + " 的投诉信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 服务投诉 where 投诉编号='{0}' and 业主姓名='{1}'", complainNo, ownerName);
                SaveNewComplain(query);
                SynComplain();
            }
        }

        private void 服务投诉DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            List<string> comboxNames = new List<string> { "楼栋名称", "业主姓名" };
            List<string> dateNames = new List<string> { "投诉日期", "处理日期" };
            DataGridViewRow currRow = this.服务投诉DataGridView.CurrentRow;
            for (int i = 0; i < this.服务投诉DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.服务投诉DataGridView.Columns[i].DataPropertyName;
                string columnName = this.服务投诉DataGridView.Columns[i].Name;
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