//文件名：OtherPaymentForm.cs
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
    public partial class OtherPaymentForm : DevComponents.DotNetBar.Office2007Form
    {
        private string MyCommunity;
        private string MyOperator;
        private string MyPrintIcon;
        private string MyCompany;
        public OtherPaymentForm(string myCommunity, string myOperator, string myCompany, string myPrintIcon)
        {
            this.MyCommunity = myCommunity;
            this.MyOperator = myOperator;
            this.MyCompany = myCompany;
            this.MyPrintIcon = myPrintIcon;
            InitializeComponent();
        }   
        private void 新增Button_Click(object sender, EventArgs e)
        {//新增其他费用信息
            this.收据编号TextBox.Text = string.Format("QTF{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            this.收款日期DateTimePicker.Value = DateTime.Now.Date;
            this.收款人员TextBox.Text = this.MyOperator; 
        }
        private void 打印Button_Click(object sender, EventArgs e)
        {//打印其他费用交款收据
            this.printPreviewDialog1.Document = this.printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.Icon = new Icon(this.MyPrintIcon);
            this.printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("物业管理服务收费收据", new Font("宋体", 20), Brushes.Black, 150, 90);
            e.Graphics.DrawString("收据编号：" + this.收据编号TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 145);
            e.Graphics.DrawString("收款日期：" + this.收款日期DateTimePicker.Value.ToString("yyyy-MM-dd"), new Font("宋体", 10), Brushes.Black, 550, 145);
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, 165, 720, 165);
            e.Graphics.DrawString("交款人员：" + this.交款人员TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 175);
            e.Graphics.DrawString("收款金额：" + this.收款金额TextBox.Text + "元", new Font("宋体", 10), Brushes.Black, 300, 175);
            e.Graphics.DrawString("收款形式：" + this.收款形式ComboBox.Text, new Font("宋体", 10), Brushes.Black, 500, 175);
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 195, 720, 195);
            e.Graphics.DrawString("收款事由：", new Font("宋体", 10), Brushes.Black, 100, 200);
            e.Graphics.DrawString(this.收款事由TextBox.Text, new Font("宋体", 10), Brushes.Black, new RectangleF(110, 220, 620, 110));            
            e.Graphics.DrawLine(new Pen(Color.Black), 100, 335, 720, 335);
            e.Graphics.DrawString("补充说明：" +this.补充说明TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, 340);
            int nFootPos = 385;
            if (this.MyCompany.Length > 14)
            {
                e.Graphics.DrawString("收款单位(盖章)：" + this.MyCompany.Substring(0, 14), new Font("宋体", 12), Brushes.Black, 380, nFootPos);
                e.Graphics.DrawString(this.MyCompany.Substring(14, this.MyCompany.Length - 14), new Font("宋体", 12), Brushes.Black, 510, nFootPos + 20);
            }
            else
            {
                e.Graphics.DrawString("收款单位(盖章)：" + this.MyCompany, new Font("宋体", 12), Brushes.Black, 380, nFootPos);
            }
            e.Graphics.DrawLine(new Pen(Color.Black, (float)3.00), 100, nFootPos + 80, 720, nFootPos + 80);
            e.Graphics.DrawString("收款人员：" + this.收款人员TextBox.Text, new Font("宋体", 10), Brushes.Black, 100, nFootPos + 88);
            e.Graphics.DrawString("打印时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), new Font("宋体", 10), Brushes.Black, 500, nFootPos + 88);
        }
        private void 保存Button_Click(object sender, EventArgs e)
        {//保存其他收费信息
            if (this.收据编号TextBox.Text.Length < 1 || this.交款人员TextBox.Text.Length < 1 || this.收款人员TextBox.Text.Length < 1
                || this.收款日期DateTimePicker.Text.Length < 1 || this.收款形式ComboBox.Text.Length < 1)
            {
                return;
            }
            if (new MsgBoxForm("警告", "现在将保存业主交纳的物业管理服务收费信息，是否继续？", true).ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                string v_收据编号 = Helper.GetTextBoxCtrlValue(this.Controls, "收据编号");
                string v_收款日期 = Helper.GetDateCtrlValue(this.Controls, "收款日期");
                string v_交款人员 = Helper.GetTextBoxCtrlValue(this.Controls, "交款人员");
                string v_收款金额 = Helper.GetTextBoxCtrlValue(this.Controls, "收款金额");
                string v_收款形式 = Helper.GetComBoxCtrlValue(this.Controls, "收款形式");
                string v_收款人员 = Helper.GetTextBoxCtrlValue(this.Controls, "收款人员");
                string v_收款事由 = Helper.GetTextBoxCtrlValue(this.Controls, "收款事由");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");

                string query = "INSERT INTO 费用收据(收据编号,收款日期,交款人员,应收金额,实收金额,收款形式,收款人员,收款事由,补充说明) VALUES('";
                query += v_收据编号 + "','";
                query += v_收款日期 + "','";
                query += v_交款人员 + "',";
                query += v_收款金额 + ",";
                query += v_收款金额 + ",'";
                query += v_收款形式 + "','";
                query += v_收款人员 + "','";
                query += v_收款事由 + "','";
                query += v_补充说明 + "');";
                DataHelper.UpdateOrDeleteRecord(query);
                this.收据编号TextBox.Text = "";
                this.收款日期DateTimePicker.Value = DateTime.Now.Date;
                this.交款人员TextBox.Text = "";
                this.收款金额TextBox.Text = "";
                this.收款形式ComboBox.Text = "";
                this.收款人员TextBox.Text = "";
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {
                new MsgBoxForm("提示", "保存失败，请检查所填数据类型！").ShowDialog();
                LogHelper.LogError(ex);
            }
        }      
    }
}