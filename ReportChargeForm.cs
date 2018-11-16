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
namespace MyCommunity
{
    public partial class ReportChargeForm : Form
    {
        public ReportChargeForm()
        {
            InitializeComponent();
        }
        public string MyCommunity;
        private DataTable dtData = new DataTable();
        private DataGridViewPrinter print = null;
        private void 查询Button_Click(object sender, EventArgs e)
        {//查询收入统计信息
            dtData.Rows.Clear();
            string query = "Select * FROM 费用收据 WHERE (收款日期 BETWEEN '" + this.开始日期DateTimePicker.Value.ToString("yyyy-MM-dd") +
                "' AND '" + this.结束日期DateTimePicker.Value.ToString("yyyy-MM-dd") + "') AND (收款事由 LIKE '%" + this.收款事由TextBox.Text + "%')";
            dtData = DataHelper.GetDataTable(query);
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
            }
        } 
    }
}