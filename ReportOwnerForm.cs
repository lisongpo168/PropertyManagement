//文件名：ReportOwnerForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;
using MyCommunity.Common;
using System.Drawing.Printing;
namespace MyCommunity
{
    public partial class ReportOwnerForm : DevComponents.DotNetBar.Office2007Form
    {
        private DataTable dtData = new DataTable();
        private DataGridViewPrinter print = null;
        private string MyCommunity;
        private string MyPrintIcon;
        public ReportOwnerForm(string myCommunity, string myPrintIcon)
        {
            this.MyCommunity = myCommunity;
            this.MyPrintIcon = myPrintIcon;
            InitializeComponent();
        }
        private void ReportOwnerForm_Load(object sender, EventArgs e)
        {            
            this.小区名称ComboBox.Items.Add("全部");
            string query = "SELECT * FROM 小区信息";
            DataTable myTable = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in myTable.Rows)
            {
                this.小区名称ComboBox.Items.Add(dRow["小区名称"].ToString());
            }
            this.小区名称ComboBox.SelectedIndex = 0;
            this.当前状态ComboBox.Items.Add("全部");
            this.当前状态ComboBox.Items.Add("已入住");
            this.当前状态ComboBox.Items.Add("未入住");
            this.当前状态ComboBox.Items.Add("其它");
            this.当前状态ComboBox.SelectedIndex = 0;
        }
         
        private void 查询Button_Click(object sender, EventArgs e)
        {//查询业主信息
            dtData.Rows.Clear();
            string v_楼栋名称 = this.楼栋名称ComboBox.Text.Trim();
            string v_小区名称 = this.小区名称ComboBox.Text.Trim();
            string v_当前状态 = this.当前状态ComboBox.Text.Trim();

            string query = "Select * FROM 业主信息 WHERE (业主编号 NOT IN (Select 业主编号 FROM 迁出信息)) ";
            if (v_小区名称 != "全部")
            {
                if (v_楼栋名称 != "全部")
                    query += " AND (楼栋名称='" + v_楼栋名称 + "')";
                else
                    query += " AND (楼栋名称 in (select 楼栋名称 from 楼栋信息 where 小区名称='" + v_小区名称 + "'))";
            }
            if (v_当前状态 != "全部")
                query += " AND (当前状态='" + v_当前状态 + "')";
            query += " ORDER BY 楼栋名称";
            dtData = DataHelper.GetDataTable(query);
            this.业主报表DataGridView.DataSource = dtData;        
        }
        private void 打印Button_Click(object sender, EventArgs e)
        {//打印业主报表信息
            string title = this.MyCommunity + "业主信息表";
            printDocument.DocumentName = title;
            printDocument.PrinterSettings = printDialog.PrinterSettings;
            printDocument.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
            //太大横向打印
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.DefaultPageSettings.Margins = new Margins(10, 10, 20, 20);
            print = new DataGridViewPrinter(this.业主报表DataGridView, printDocument, title);
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

        private void 小区名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.楼栋名称ComboBox.Items.Clear();
            this.楼栋名称ComboBox.Items.Add("全部");
            string v_小区名称 = this.小区名称ComboBox.Text;
            string query = "SELECT * FROM 楼栋信息 WHERE (小区名称 = '" + v_小区名称 + "')";
            DataTable myTable = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in myTable.Rows)
            {
                this.楼栋名称ComboBox.Items.Add(dRow["楼栋名称"].ToString());
            }
            this.楼栋名称ComboBox.SelectedIndex = 0;
        }
    }
}