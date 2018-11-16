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
    public partial class ReportOwnerForm : Form
    {
        private DataTable dtData = new DataTable();
        private DataGridViewPrinter print = null;
        public ReportOwnerForm()
        {
            InitializeComponent();
        }
        public string MyCommunity;
        private void ReportOwnerForm_Load(object sender, EventArgs e)
        {            
            this.房屋性质ComboBox.Items.Add("全部");
            this.房屋性质ComboBox.Items.Add("住宅");
            this.房屋性质ComboBox.Items.Add("商用");
            this.房屋性质ComboBox.Items.Add("其他");
            this.楼栋名称ComboBox.Items.Add("全部");
            string query = "SELECT * FROM 楼栋信息";
            DataTable myTable = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in myTable.Rows)
            {
                this.楼栋名称ComboBox.Items.Add(dRow["楼栋名称"].ToString());
            }
            this.当前状态ComboBox.Items.Add("全部");
            this.当前状态ComboBox.Items.Add("已入住");
            this.当前状态ComboBox.Items.Add("未入住");
            this.当前状态ComboBox.Items.Add("其他");
        }
         
        private void 查询Button_Click(object sender, EventArgs e)
        {//查询业主信息
            dtData.Rows.Clear();
            string v_楼栋名称 = this.楼栋名称ComboBox.Text.Trim();
            string v_单元名称 = this.单元名称TextBox.Text.Trim();
            string v_房屋性质 = this.房屋性质ComboBox.Text.Trim();
            string v_房屋类型 = this.房屋类型TextBox.Text.Trim();
            string v_常住人员 = this.常住人员TextBox.Text.Trim();
            string v_当前状态 = this.当前状态ComboBox.Text.Trim();

            string query = "Select * FROM 业主信息 WHERE (业主编号 NOT IN (Select 业主编号 FROM 迁出信息)) ";
            if (v_楼栋名称 != "全部")
                query += " AND (楼栋名称='" + v_楼栋名称 + "')";
            if (!string.IsNullOrEmpty(v_单元名称))
                query += " AND (单元名称 LIKE '%" + v_单元名称 + "%')";
            if (v_房屋性质 != "全部")
                query += " AND (房屋性质='" + v_房屋性质 + "')";
            if(!string.IsNullOrEmpty(v_房屋类型))
                query += " AND (房屋类型 LIKE '%" + v_房屋类型 + "%')";
            if (!string.IsNullOrEmpty(v_常住人员))
                query += " AND (常住人员 LIKE '%" + v_常住人员 + "%')";
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