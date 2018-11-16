//文件名：ManageQueryForm.cs
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
    public partial class ManageQueryForm : Form
    {
        private DataTable dtData = new System.Data.DataTable();
        private DataGridViewPrinter print = null;
        public ManageQueryForm()
        {
            InitializeComponent();
        }
        public string MyCommunity;
        public string MyPrintIcon;
        private void ManageQueryForm_Load(object sender, EventArgs e)
        {
            for (int i = 2009; i <= 2039; i++)
            {
                this.计费年份ComboBox.Items.Add(i.ToString());
            }
            this.计费月份ComboBox.Items.Add("全年");
            for (int i = 1; i <= 12; i++)
            {
                this.计费月份ComboBox.Items.Add(i.ToString());
            }            
            this.楼栋名称ComboBox.Items.Add("全部");
            String MySQLConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
            string query = "SELECT * FROM 楼栋信息";
            DataTable myTable = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in myTable.Rows)
            {
                this.楼栋名称ComboBox.Items.Add(dRow["楼栋名称"].ToString());
            }
            this.业主姓名ComboBox.Items.Add("全部");
            this.费用状态ComboBox.Items.Add("全部");
            this.费用状态ComboBox.Items.Add("已交费");
            this.费用状态ComboBox.Items.Add("未交费");
        }
         
        private void 查询Button_Click(object sender, EventArgs e)
        {
            string v_计费年份 = this.计费年份ComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ComboBox.Text.Trim();
            string v_业主姓名 = this.业主姓名ComboBox.Text.Trim();
            string v_费用状态 = this.费用状态ComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，楼栋名称等信息！").ShowDialog();
                return;
            }
            dtData.Rows.Clear();
            string query = "Select * FROM 物管费用 WHERE (登记标志='完成登记') AND (计费年份= " + v_计费年份 + ")";
            if (v_计费月份 == "全年")
                query += "";
            else
                query += " AND (计费月份=" + v_计费月份 + ")";
            if (v_楼栋名称 == "全部")
                query += "";
            else
                query += " AND (楼栋名称='" + v_楼栋名称 + "')";
            if (v_业主姓名 == "全部")
                query += "";
            else
                query += " AND (业主姓名='" + v_业主姓名 + "')";
            if (v_费用状态 == "全部")
                query += "";
            else
                query += " AND (费用状态='" + v_费用状态 + "')";
            dtData = DataHelper.GetDataTable(query);
            this.物管费用DataGridView.DataSource = dtData;            
        }

        private void 打印Button_Click(object sender, EventArgs e)
        {//打印物管费用信息
            string title = this.MyCommunity + "物管费用信息表";
            printDocument.DocumentName = title;
            printDocument.PrinterSettings = printDialog.PrinterSettings;
            printDocument.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
            printDocument.DefaultPageSettings.Margins = new Margins(10, 10, 20, 20);
            print = new DataGridViewPrinter(this.物管费用DataGridView, printDocument, title);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            printPreviewDialog.Icon = new Icon(this.MyPrintIcon);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
        private void 业主姓名ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.业主姓名ComboBox.Items.Clear();
            this.业主姓名ComboBox.Items.Add("全部");
            String MySQLConnectionString = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
            string query = "SELECT * FROM 业主信息 WHERE (楼栋名称 ='" + this.楼栋名称ComboBox.Text + "')";
            DataTable myTable = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in myTable.Rows)
            {
                this.业主姓名ComboBox.Items.Add(dRow["业主姓名"].ToString());
            }
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