//文件名：ReportComplainForm.cs
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
    public partial class ReportComplainForm : Form
    {
        public ReportComplainForm()
        {
            InitializeComponent();
        }
        public string MyCommunity;
        private DataTable dtData = new System.Data.DataTable();
        private DataGridViewPrinter print = null;
        private void 查询Button_Click(object sender, EventArgs e)
        {//查询投诉信息
            dtData.Rows.Clear();          
            string query = "Select * FROM 服务投诉 WHERE (投诉日期 BETWEEN '" + this.开始日期DateTimePicker.Value.ToString("yyyy-MM-dd") + 
                "' AND '" + this.结束日期DateTimePicker.Value.ToString("yyyy-MM-dd") + "') AND (投诉主题 LIKE '%" + this.投诉主题TextBox.Text.Trim() + "%')";
            dtData = DataHelper.GetDataTable(query);
            this.投诉报表DataGridView.DataSource = dtData;
        }
        private void 打印Button_Click(object sender, EventArgs e)
        {//打印投诉信息
            string title = this.MyCommunity + "投诉信息表";
            printDocument.DocumentName = title;
            printDocument.PrinterSettings = printDialog.PrinterSettings;
            printDocument.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
            //太大横向打印
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.DefaultPageSettings.Margins = new Margins(10, 10, 20, 20);
            print = new DataGridViewPrinter(this.投诉报表DataGridView, printDocument, title);
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