//文件名：ReportChargeForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;
using System.Drawing.Printing;
using MyCommunity.Common;
namespace MyCommunity
{
    public partial class ReportChargeForm : DevComponents.DotNetBar.Office2007Form
    {
        private DataTable dtData = new DataTable();
        private DataGridViewPrinter print = null;
        private string MyCommunity;
        private string MyPrintIcon;
        public ReportChargeForm(string myCommunity, string myPrintIcon)
        {
            this.MyCommunity = myCommunity;
            this.MyPrintIcon = myPrintIcon;
            InitializeComponent();
            this.开始日期DateTimePicker.Value = DateTime.Now.Date;
            this.结束日期DateTimePicker.Value = DateTime.Now.Date;
        }
        private void 查询Button_Click(object sender, EventArgs e)
        {//查询收入统计信息
            dtData.Rows.Clear();
            string queryBordy = "FROM 费用收据 WHERE (收款日期 BETWEEN '" + this.开始日期DateTimePicker.Value.ToString("yyyy-MM-dd") +
                "' AND '" + this.结束日期DateTimePicker.Value.ToString("yyyy-MM-dd") + "') AND (收款事由 LIKE '%" + this.收款事由TextBox.Text + "%') ORDER BY 收款日期";
            string query = "Select * " + queryBordy;
            dtData = DataHelper.GetDataTable(query);
            query = "Select sum(应收金额) as 应收金额, sum(实收金额) as 实收金额 " + queryBordy;
            DataTable dt = DataHelper.GetDataTable(query);
            if (dtData.Rows.Count > 0 && dt.Rows.Count > 0)
            {
                DataRow dRow = dtData.NewRow();
                dRow["交款人员"] = "收款总计";
                dRow["应收金额"] = Helper.Obj2Double(dt.Rows[0]["应收金额"]).ToString("N2");
                dRow["实收金额"] = Helper.Obj2Double(dt.Rows[0]["实收金额"]).ToString("N2");
                dtData.Rows.Add(dRow);
            }
            this.收入统计报表DataGridView.DataSource = dtData;
        }
        private void 打印Button_Click(object sender, EventArgs e)
        {//打印收入统计信息
            string title = this.MyCommunity + "收入统计信息表";
            printDocument.DocumentName = title;
            printDocument.PrinterSettings = printDialog.PrinterSettings;
            printDocument.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
            printDocument.DefaultPageSettings.Margins = new Margins(10, 10, 20, 20);
            print = new DataGridViewPrinter(this.收入统计报表DataGridView, printDocument, title);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            printPreviewDialog.Icon = new Icon(this.MyPrintIcon);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                bool more = print.DrawDataGridView(e.Graphics);
                if (more == true)
                    e.HasMorePages = true;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
            }
        } 
    }
}