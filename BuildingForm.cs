//文件名：BuildingForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using Microsoft.Office.Core;
namespace MyCommunity
{
    public partial class BuildingForm : Form
    {
        public BuildingForm()
        {
            InitializeComponent();
        }
        public string MyCommunity;
        private void 楼栋信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.楼栋信息BindingSource.EndEdit();
            //this.楼栋信息TableAdapter.Update(this.dBCommunityDataSet.楼栋信息);
            if (string.IsNullOrEmpty(this.楼栋名称TextBox.Text))
            {
                MessageBox.Show("没有输入正确的信息！");
                return;
            }
            try
            {
                string buildName = this.楼栋名称TextBox.Text;
                string pos = this.所处位置TextBox.Text;
                string unit = this.单元信息TextBox.Text;
                string floor = this.楼层信息TextBox.Text;
                string totalRenStr = this.总人口数TextBox.Text;
                string totalHuStr = this.总户数TextBox.Text;
                string ruzhuHuStr = this.入住户数TextBox.Text;
                string zhuzhaiHuStr = this.住宅户数TextBox.Text;
                string admin = this.管理楼长TextBox.Text;
                string adminTel = this.联系电话TextBox.Text;
                string memo = this.补充说明TextBox.Text;
                short totalRen = 0, totalHu = 0, ruzhuHu = 0, zhuzhaiHu = 0;
                int kongHu = 0, shangHu = 0;
                Int16.TryParse(totalRenStr, out totalRen);
                Int16.TryParse(totalHuStr, out totalHu);
                Int16.TryParse(ruzhuHuStr, out ruzhuHu);
                Int16.TryParse(zhuzhaiHuStr, out zhuzhaiHu);
                kongHu = totalHu - ruzhuHu;
                shangHu = totalHu = zhuzhaiHu;
                string query = string.Empty;
                if (IsNewAdded(buildName))
                {
                    query = string.Format("insert into 楼栋信息(`楼栋名称`, `所处位置`, `单元信息`, `楼层信息`, `总人口数`, `总户数`, `入住户数`, `空置户数`, `住宅户数`, `商用户数`, `管理楼长`, `联系电话`, `补充说明`)values('{0}','{1}','{2}','{3}',{4},{5},{6},{7},{8},{9},'{10}','{11}','{12}')", buildName, pos, unit, floor,
                    totalRen, totalHu, ruzhuHu, kongHu, zhuzhaiHu, shangHu, admin, adminTel, memo);
                }
                else
                {
                    query = string.Format("update 楼栋信息 set 所处位置='{0}',单元信息='{1}',楼层信息='{2}',总人口数={3},总户数={4},入住户数={5},空置户数={6},住宅户数={7},商用户数={8},管理楼长='{9}',联系电话='{10}',补充说明='{11}' where 楼栋名称='{12}')", pos, unit, floor,
                    totalRen, totalHu, ruzhuHu, kongHu, zhuzhaiHu, shangHu, admin, adminTel, memo, buildName);
                }
                SaveNewBuilding(query);
                SynBuilding();
            }
            catch (Exception ex)
            {
 
            }
        }

        private void SaveNewBuilding(string query)
        {
            DataHelper.UpdateOrDeleteRecord(query);
        }

        private bool IsNewAdded(string buildName)
        {
            string query = string.Format("select * from 楼栋信息 where 楼栋名称='{0}'", buildName);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count <= 1;
        }

        private void SynBuilding()
        {
            string query = "select * from 楼栋信息";
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            this.楼栋信息DataGridView.DataSource = dt;
        }

        private void BuildingForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
            //this.楼栋信息TableAdapter.Fill(this.dBCommunityDataSet.楼栋信息); 
            SynBuilding();
        }
        private void 打印ToolStripButton_Click(object sender, EventArgs e)
        {//打印楼栋信息
            ApplicationClass MyExcel;
            Workbooks MyWorkBooks;
            Workbook MyWorkBook;
            Worksheet MyWorkSheet;
            char MyColumns;
            Range MyRange;
            Object[,] MyData = new Object[500, 35];
            int i, j;
            MyExcel = new ApplicationClass();
            MyExcel.Visible = true;
            if (MyExcel == null)
            {
                MessageBox.Show("Excel程序无法启动！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MyWorkBooks = MyExcel.Workbooks;
            MyWorkBook = MyWorkBooks.Add(Missing.Value);
            MyWorkSheet = (Worksheet)MyWorkBook.Worksheets[1];
            MyColumns = (char)(this.dBCommunityDataSet.楼栋信息.Columns.Count + 64);
            MyRange = MyWorkSheet.get_Range("A5", MyColumns.ToString() + "5");
            int Count = 0;
            foreach (DataColumn MyNewColumn in this.dBCommunityDataSet.楼栋信息.Columns)
            {
                MyData[0, Count] = MyNewColumn.ColumnName;
                Count = Count + 1;
            }
            j = 1;
            //输出数据库记录
            foreach (DataRow MyRow in this.dBCommunityDataSet.楼栋信息.Rows)
            {
                for (i = 0; i < this.dBCommunityDataSet.楼栋信息.Columns.Count; i++)
                {
                    MyData[j, i] = MyRow[i].ToString();
                }
                j++;
            }
            MyRange = MyRange.get_Resize(this.dBCommunityDataSet.楼栋信息.Rows.Count + 1, this.dBCommunityDataSet.楼栋信息.Columns.Count);
            MyRange.Value2 = MyData;
            MyRange.EntireColumn.AutoFit();
            MyWorkSheet.Cells[2, 2] = this.MyCommunity+ "楼栋信息表";
            Range MyRange22 = MyWorkSheet.get_Range("B2", "B2");
            MyRange22.Font.Bold = true;
            MyRange22.Font.Size = "20";
            MyWorkSheet.Cells[4, 1] = "打印日期：" + DateTime.Now.ToShortDateString();
        }

        private void 楼栋信息DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = this.楼栋信息DataGridView.CurrentRow;

        }   
    }
}