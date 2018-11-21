//文件名：ManagePaymentForm.cs
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
    public partial class ManagePaymentForm : Form
    {
        public ManagePaymentForm()
        {
            InitializeComponent();
        }
        public string MyCommunity;
        public string MyOperator;
        private DataTable manageTable = new DataTable("物管费用明细表");
        private void ManagePaymentForm_Load(object sender, EventArgs e)
        {
            //这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
            InitCmbBuilding();
            DataColumn[] MyKey = new DataColumn[1];
            DataColumn MyColumn = new DataColumn();
            MyColumn.DataType = System.Type.GetType("System.Int16");
            MyColumn.ColumnName = "序号";
            manageTable.Columns.Add(MyColumn);
            MyKey[0] = MyColumn;
            manageTable.PrimaryKey = MyKey;
            manageTable.Columns.Add("年份", System.Type.GetType("System.Int16"));
            manageTable.Columns.Add("月份", System.Type.GetType("System.Int16"));
            manageTable.Columns.Add("建面", System.Type.GetType("System.Double"));
            manageTable.Columns.Add("套面", System.Type.GetType("System.Double"));
            manageTable.Columns.Add("单价", System.Type.GetType("System.Double"));
            manageTable.Columns.Add("金额", System.Type.GetType("System.Double"));
            manageTable.Columns.Add("备注", System.Type.GetType("System.String"));
            this.明细DataGridView.DataSource = manageTable;
        }

        private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {//获取指定楼栋的业主信息
            string v_楼栋名称 = this.楼栋名称ComboBox.Text;
            string query = "SELECT * FROM 业主信息 WHERE (楼栋名称 = '" + v_楼栋名称 + "')";
            DataTable myTable = DataHelper.GetDataTable(query);
            this.业主姓名ComboBox.DataSource = myTable;
            this.业主姓名ComboBox.DisplayMember = "业主姓名";
            this.业主姓名ComboBox.ValueMember = "业主编号";
        }
        private void 查询Button_Click(object sender, EventArgs e)
        {//查询业主未交费信息
            string v_业主编号 = "";
            string v_业主姓名 = this.业主姓名ComboBox.Text.Trim();
            if (this.业主姓名ComboBox.SelectedValue != null && this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                v_业主编号 = this.业主姓名ComboBox.SelectedValue.ToString();
            }
            string query = "SELECT 自动编号, 计费年份, 计费月份, 建筑面积, 套内面积, 计费单价, 应交金额,补充说明 FROM 物管费用 WHERE (业主编号 ='" + v_业主编号 + "') AND (业主姓名 ='" + v_业主姓名 + "') AND (费用状态='未交费')";
            DataTable myTable = DataHelper.GetDataTable(query);
            this.未交DataGridView.DataSource = myTable;
            this.交款人员TextBox.Text = v_业主姓名;
        }
        
        private void 新增Button_Click(object sender, EventArgs e)
        {//新增收据信息
            this.收据编号TextBox.Text = string.Format("WGF{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            this.收款日期DateTimePicker.Value = DateTime.Now.Date;
            this.收款人员TextBox.Text = this.MyOperator;
            this.收款金额TextBox.Text = "0";
            manageTable.Rows.Clear();
        }
        private void 添加Button_Click(object sender, EventArgs e)
        {//添加交款明细项目
            if ((this.收据编号TextBox.Text.Length > 1) && (this.交款人员TextBox.Text.Length > 1))
            {
                DataRow dRow = manageTable.NewRow();
                int int_序号 = Helper.Obj2Int(this.未交DataGridView.CurrentRow.Cells[0].Value);
                dRow[0] = int_序号;
                dRow["年份"] = Helper.Obj2Int(this.未交DataGridView.CurrentRow.Cells[1].Value);
                dRow["月份"] = Helper.Obj2Int(this.未交DataGridView.CurrentRow.Cells[2].Value);
                dRow["建面"] = Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[3].Value);
                dRow["套面"] = Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[4].Value);
                dRow["单价"] = Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[5].Value);
                dRow["金额"] = Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[6].Value);
                dRow["备注"] = Helper.Obj2String(this.未交DataGridView.CurrentRow.Cells[7].Value);
                if (manageTable.Select("序号=" + int_序号).Length > 0)
                {
                    new MsgBoxForm("提示", "该条费用信息已添加，请另选一条！").ShowDialog();
                    return;
                }
                manageTable.Rows.Add(dRow);
                double myAmount = Helper.String2Double(this.收款金额TextBox.Text.Trim());
                myAmount += Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[6].Value);
                this.收款金额TextBox.Text = myAmount.ToString();
            }
        }
        private void 移除Button_Click(object sender, EventArgs e)
        {//移除交款明细项目
            try
            {
                double myAmount = Helper.String2Double(this.收款金额TextBox.Text.Trim());
                myAmount -= Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[6].Value);
                this.收款金额TextBox.Text = myAmount.ToString();
                manageTable.Rows.RemoveAt(this.明细DataGridView.CurrentRow.Index);
            }
            catch
            {
            }
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

        private void 打印Button_Click(object sender, EventArgs e)
        {//打印物管费用交款收据
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.MyCommunity + "物业管理费交款收据", new Font("宋体", 20), Brushes.Black, 160, 90);
            e.Graphics.DrawString("收据编号：" + this.收据编号TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 145);
            e.Graphics.DrawString("收款日期：" + this.收款日期DateTimePicker.Value.ToString("yyyy-MM-dd"), new Font("宋体", 10), Brushes.Black, 550, 145);
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 165, 720, 165);
            e.Graphics.DrawString("交款人员：" + this.交款人员TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 175);
            e.Graphics.DrawString("收款金额：" + this.收款金额TextBox.Text + "元", new Font("宋体", 10), Brushes.Black, 230, 175);
            e.Graphics.DrawString("收款形式：" + this.收款形式TextBox.Text, new Font("宋体", 10), Brushes.Black, 380, 175);
            e.Graphics.DrawString("收款事由：" + this.收款事由TextBox.Text, new Font("宋体", 10), Brushes.Black, 500, 175);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 195, 720, 195);
            e.Graphics.DrawString("补充说明：" + this.补充说明TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 200);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 220, 720, 220);
            e.Graphics.DrawString("序号", new Font("宋体", 10), Brushes.Black, 100, 225);
            e.Graphics.DrawString("年份", new Font("宋体", 10), Brushes.Black, 140, 225);
            e.Graphics.DrawString("月份", new Font("宋体", 10), Brushes.Black, 180, 225);
            e.Graphics.DrawString("建筑面积(m2)", new Font("宋体", 10), Brushes.Black, 220, 225);
            e.Graphics.DrawString("套内面积(m2)", new Font("宋体", 10), Brushes.Black, 320, 225);
            e.Graphics.DrawString("单价(元)", new Font("宋体", 10), Brushes.Black, 420, 225);
            e.Graphics.DrawString("金额(元)", new Font("宋体", 10), Brushes.Black, 485, 225);
            e.Graphics.DrawString("备注", new Font("宋体", 10), Brushes.Black, 550, 225);
            int MyPosY = 245;
            int MyID = 1;
            foreach (DataRow MyRow in this.manageTable.Rows)
            {
                e.Graphics.DrawString(MyID.ToString(), new Font("宋体", 10), Brushes.Black, 100, MyPosY);
                e.Graphics.DrawString(MyRow[1].ToString(), new Font("宋体", 10), Brushes.Black, 140, MyPosY);
                e.Graphics.DrawString(MyRow[2].ToString(), new Font("宋体", 10), Brushes.Black, 180, MyPosY);
                e.Graphics.DrawString(MyRow[3].ToString(), new Font("宋体", 10), Brushes.Black, 220, MyPosY);
                e.Graphics.DrawString(MyRow[4].ToString(), new Font("宋体", 10), Brushes.Black, 320, MyPosY);
                e.Graphics.DrawString(MyRow[5].ToString(), new Font("宋体", 10), Brushes.Black, 420, MyPosY);
                e.Graphics.DrawString(MyRow[6].ToString(), new Font("宋体", 10), Brushes.Black, 485, MyPosY);
                e.Graphics.DrawString(MyRow[7].ToString(), new Font("宋体", 10), Brushes.Black, 550, MyPosY);
                MyPosY += 20;
                MyID += 1;
            }
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 400, 720, 400);
            e.Graphics.DrawString("收款人员：" + this.收款人员TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 410);
            e.Graphics.DrawString("打印时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), new Font("宋体", 10), Brushes.Black, 500, 410);
        }
        private void 保存Button_Click(object sender, EventArgs e)
        {//保存物管费用交款信息
            string v_收据编号 = Helper.GetTextBoxCtrlValue(this.Controls, "收据编号");
            if (string.IsNullOrEmpty(v_收据编号))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }

            if (new MsgBoxForm("警告", "现在将保存业主交纳的物业管理费数据，是否继续？", true).ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                string v_收款日期 = Helper.GetDateCtrlValue(this.Controls, "收款日期");
                string v_交款人员 = Helper.GetTextBoxCtrlValue(this.Controls, "交款人员");
                string v_收款金额 = Helper.GetTextBoxCtrlValue(this.Controls, "收款金额");
                string v_收款形式 = Helper.GetTextBoxCtrlValue(this.Controls, "收款形式");
                string v_收款人员 = Helper.GetTextBoxCtrlValue(this.Controls, "收款人员");
                string v_收款事由 = Helper.GetTextBoxCtrlValue(this.Controls, "收款事由");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");
                string query = string.Format("INSERT INTO 费用收据(收据编号,收款日期,交款人员,收款金额,收款形式,收款人员,收款事由,补充说明) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    v_收据编号, v_收款日期, v_交款人员, v_收款金额, v_收款形式, v_收款人员, v_收款事由, v_补充说明);
                DataHelper.UpdateOrDeleteRecord(query);

                foreach (DataRow dRow in manageTable.Rows)
                {
                    string v_自动编号 = dRow[0].ToString();
                    string My收据编号 = this.收据编号TextBox.Text;
                    query = "UPDATE 物管费用 SET 费用状态='已交费',收据编号='" + My收据编号 + "' WHERE 自动编号=" + v_自动编号;
                    DataHelper.UpdateOrDeleteRecord(query);
                }
                DataHelper.CommitUpdate();
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            { }
            查询Button_Click(null, null);
            manageTable.Rows.Clear();
        }    
    }
}