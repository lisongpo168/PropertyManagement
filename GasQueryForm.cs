//文件名：GasQueryForm.cs
using System;
using System.Linq;
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
    public partial class GasQueryForm : DevComponents.DotNetBar.Office2007Form
    {
        private DataTable dtData = new DataTable();
        private DataGridViewPrinter print = null;
        private string MyCommunity;
        private string MyPrintIcon;
        public GasQueryForm(string myCommunity, string myPrintIcon)
        {
            this.MyCommunity = myCommunity;
            this.MyPrintIcon = myPrintIcon;
            InitializeComponent();
        }
        private void GasQueryForm_Load(object sender, EventArgs e)
        {
            for (int i = 2009; i <= 2099; i++)
            {
                this.计费年份ComboBox.Items.Add(i.ToString());
            }
            this.计费年份ComboBox.Text = DateTime.Now.Year.ToString();
            this.计费月份ComboBox.Items.Add("全年");
            for (int i = 1; i <= 12; i++)
            {
                this.计费月份ComboBox.Items.Add(i.ToString());
            }
            this.计费月份ComboBox.SelectedIndex = 0;
            this.小区名称ComboBox.Items.Add("全部");
            string query = "SELECT * FROM 小区信息";
            DataTable myTable = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in myTable.Rows)
            {
                this.小区名称ComboBox.Items.Add(dRow["小区名称"].ToString());
            }
            this.小区名称ComboBox.SelectedIndex = 0;
            this.费用状态ComboBox.Items.Add("全部");
            this.费用状态ComboBox.Items.Add("已交费");
            this.费用状态ComboBox.Items.Add("未交费");
            this.费用状态ComboBox.SelectedIndex = 0;
        }
        private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.业主姓名ComboBox.Items.Clear();            
            this.业主姓名ComboBox.Items.Add("全部");            
            string query = "SELECT * FROM 业主信息 WHERE (楼栋名称 ='" + this.楼栋名称ComboBox.Text.Trim() + "')";
            DataTable myTable = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in myTable.Rows)
            {
                this.业主姓名ComboBox.Items.Add(dRow["业主姓名"].ToString());
            }
            this.业主姓名ComboBox.SelectedIndex = 0;
        }
        
        private void 查询Button_Click(object sender, EventArgs e)
        {
            string v_计费年份 = this.计费年份ComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ComboBox.Text.Trim();
            string v_楼栋名称 = this.楼栋名称ComboBox.Text.Trim();
            string v_业主姓名 = this.业主姓名ComboBox.Text.Trim();
            string v_小区名称 = this.小区名称ComboBox.Text.Trim();
            string v_费用状态 = this.费用状态ComboBox.Text.Trim();
            if (string.IsNullOrEmpty(v_计费年份) || string.IsNullOrEmpty(v_计费月份) || string.IsNullOrEmpty(v_小区名称) || string.IsNullOrEmpty(v_楼栋名称))
            {
                new MsgBoxForm("提示", "没有选择正确的计费年份，计费月份，小区名称，楼栋名称等信息！").ShowDialog();
                return;
            }
            dtData.Rows.Clear();
            string query = "Select 楼栋名称,业主编号,业主姓名,计费年份,计费月份,费用状态,收据编号,round(sum(应交金额),2) as 应交金额 FROM 水电气费 WHERE (登记标志='完成登记') AND (计费年份= " + v_计费年份 + ")";
            string ownerQuery = "Select 业主编号,业主姓名,楼栋名称,物业费用,预存金额,联系电话 from 业主信息 WHERE (业主编号 NOT IN (SELECT 业主编号 FROM 迁出信息))";
            string reciptNoQuery = "Select 收据编号 FROM 水电气费 WHERE (登记标志='完成登记') AND (费用状态='已交费') AND (计费年份= " + v_计费年份 + ")";
            if (v_计费月份 == "全年")
                query += "";
            else
            {
                query += " AND (计费月份=" + v_计费月份 + ")";
                reciptNoQuery += " AND (计费月份=" + v_计费月份 + ")";
            }
            if (v_小区名称 == "全部")
                query += "";
            else
            {
                if (v_楼栋名称 == "全部")
                {
                    query += " AND (楼栋名称 in (select 楼栋名称 from 楼栋信息 where 小区名称='" + v_小区名称 + "'))";
                    ownerQuery += " AND (楼栋名称 in (select 楼栋名称 from 楼栋信息 where 小区名称='" + v_小区名称 + "'))";
                    reciptNoQuery += " AND (楼栋名称 in (select 楼栋名称 from 楼栋信息 where 小区名称='" + v_小区名称 + "'))";
                }
                else
                {
                    query += " AND (楼栋名称='" + v_楼栋名称 + "')";
                    ownerQuery += " AND (楼栋名称='" + v_楼栋名称 + "')";
                    reciptNoQuery += " AND (楼栋名称='" + v_楼栋名称 + "')";
                }
            }

            if (v_业主姓名 == "全部")
                query += "";
            else
            {
                query += " AND (业主姓名='" + v_业主姓名 + "')";
                ownerQuery += " AND (业主姓名='" + v_业主姓名 + "')";
                reciptNoQuery += " AND (业主姓名='" + v_业主姓名 + "')";
            }
            if (v_费用状态 == "全部")
                query += "";
            else
                query += " AND (费用状态='" + v_费用状态 + "')";
            query += " group by 业主编号,计费年份,计费月份";
            dtData = DataHelper.GetDataTable(query);
            if (dtData.Rows.Count == 0) return;
            DataTable ownerTable = DataHelper.GetDataTable(ownerQuery);
            string reciptQuery = string.Format("select * from 费用收据 where 收据编号 in ({0})", reciptNoQuery);
            DataTable reciptTable = DataHelper.GetDataTable(reciptQuery);
            RefreshDataGridView(ownerTable, reciptTable);
        }

        private void RefreshDataGridView(DataTable ownerTable, DataTable reciptTable)
        {
            List<OwnerInfo> ownerInfoList = new List<OwnerInfo>();
            foreach(DataRow dRow in ownerTable.Rows)
            {
                ownerInfoList.Add(new OwnerInfo()
                {
                    v_业主编号 = Helper.Obj2String(dRow["业主编号"]),
                    v_业主姓名 = Helper.Obj2String(dRow["业主姓名"]),
                    v_楼栋名称 = Helper.Obj2String(dRow["楼栋名称"]),
                    d_物业费用 = Helper.Obj2Double(dRow["物业费用"]),
                    d_预存金额 = Helper.Obj2Double(dRow["预存金额"]),
                    v_联系电话 = Helper.Obj2String(dRow["联系电话"])
                });
            }

            List<ReciptInfo> reciptInfoList = new List<ReciptInfo>();
            foreach (DataRow dRow in reciptTable.Rows)
            {
                reciptInfoList.Add(new ReciptInfo()
                {
                    v_收据编号 = Helper.Obj2String(dRow["收据编号"]),
                    v_收款日期 = Helper.Obj2Date(dRow["收款日期"]),
                    v_业主姓名 = Helper.Obj2String(dRow["交款人员"]),
                    d_应收金额 = Helper.Obj2Double(dRow["应收金额"]),
                    d_实收金额 = Helper.Obj2Double(dRow["实收金额"]),
                    v_补充说明 = Helper.Obj2String(dRow["补充说明"])
                });
            }

            this.水电气费DataGridView.Rows.Clear();//收据编号,round(sum(应交金额),2) as 应交金额
            foreach (DataRow dRow in dtData.Rows)
            {
                string v_业主编号 = Helper.Obj2String(dRow["业主编号"]);
                string v_业主姓名 = Helper.Obj2String(dRow["业主姓名"]);
                string v_计费年月 = string.Format("{0}年{1}月", Helper.Obj2String(dRow["计费年份"]), Helper.Obj2String(dRow["计费月份"]));
                string v_缴费状态 = Helper.Obj2String(dRow["费用状态"]);
                double d_电费 = Helper.Obj2Double(dRow["应交金额"]);
                OwnerInfo ownerInfo = ownerInfoList.FirstOrDefault(p=>p.v_业主编号 == v_业主编号 && p.v_业主姓名 == v_业主姓名);
                double d_物业费 = ownerInfo != null ? ownerInfo.d_物业费用 : 0;
                double d_预存金额 = ownerInfo != null ? ownerInfo.d_预存金额 : 0;
                string v_电话 = ownerInfo != null ? ownerInfo.v_联系电话 : "";
                string v_备注 = string.Empty;
                double d_应交费 = 0, d_实交费 = 0;
                if (v_缴费状态 == "已交费")
                {
                    string v_收据编号 = Helper.Obj2String(dRow["收据编号"]);
                    ReciptInfo reciptInfo = reciptInfoList.FirstOrDefault(p => p.v_收据编号 == v_收据编号);
                    if (reciptInfo != null)
                    {
                        d_应交费 = reciptInfo.d_应收金额;
                        d_实交费 = reciptInfo.d_实收金额;
                        v_备注 = reciptInfo.v_补充说明;
                    }
                }
                else
                {
                    d_应交费 = d_电费 + d_物业费 - d_预存金额;
                    d_实交费 = Math.Ceiling(d_应交费);
                    v_备注 = string.Format("已扣除上期预存{0}元", d_预存金额.ToString("N2"));
                    d_预存金额 = d_实交费 - d_应交费;
                }
                this.水电气费DataGridView.Rows.Add(new object[] {v_业主编号, v_业主姓名, v_计费年月, d_电费.ToString("N2"), d_物业费.ToString("N2"),
                d_应交费.ToString("N2"), d_实交费.ToString("N2"), d_预存金额.ToString("N2"), v_缴费状态, v_电话, v_备注});
            }
        }

        private void 打印Button_Click(object sender, EventArgs e)
        {//打印水电气费信息
            string v_计费年份 = this.计费年份ComboBox.Text.Trim();
            string v_计费月份 = this.计费月份ComboBox.Text.Trim();
            string title = string.Empty;
            if(v_计费月份 != "全年")
                title = string.Format("{0}{1}年{2}月物业费总清单", this.小区名称ComboBox.Text, v_计费年份, v_计费月份);
            else
                title = string.Format("{0}{1}年全年物业费总清单", this.小区名称ComboBox.Text, v_计费年份);
            printDocument.DocumentName = title;
            printDocument.PrinterSettings = printDialog.PrinterSettings;
            printDocument.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
            printDocument.DefaultPageSettings.Margins = new Margins(6, 6, 10, 10);
            print = new DataGridViewPrinter(this.水电气费DataGridView, printDocument, title);
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