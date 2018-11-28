//文件名：GasPaymentForm.cs
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
    public partial class GasPaymentForm : DevComponents.DotNetBar.Office2007Form
    {
        private DataTable dtData = new DataTable("水电气费明细表");
        private Dictionary<string, OwnerInfo> ownerInfoDic = new Dictionary<string, OwnerInfo>();
        private Dictionary<string, string> communityInfoDic = new Dictionary<string, string>();
        private string MyCommunity;
        private string MyOperator;
        private string MyPrintIcon;
        public GasPaymentForm(string myCommunity, string myOperator, string myPrintIcon)
        {
            this.MyCommunity = myCommunity;
            this.MyOperator = myOperator;
            this.MyPrintIcon = myPrintIcon;
            InitializeComponent();
        }
        private void GasPaymentForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
            InitCmbCommunity();
            this.收款形式ComboBox.SelectedIndex = 0;
            DataColumn[] MyKey = new DataColumn[1];
            DataColumn MyColumn = new DataColumn();
            MyColumn.DataType = System.Type.GetType("System.Int16");
            MyColumn.ColumnName = "序号";
            dtData.Columns.Add(MyColumn);
            MyKey[0] = MyColumn;
            dtData.PrimaryKey = MyKey;
            dtData.Columns.Add("年份", System.Type.GetType("System.Int16"));
            dtData.Columns.Add("月份", System.Type.GetType("System.Int16"));
            dtData.Columns.Add("类型", System.Type.GetType("System.String"));
            dtData.Columns.Add("表号", System.Type.GetType("System.String"));
            dtData.Columns.Add("上月数", System.Type.GetType("System.Double"));
            dtData.Columns.Add("本月数", System.Type.GetType("System.Double"));
            dtData.Columns.Add("用量", System.Type.GetType("System.Double"));
            dtData.Columns.Add("单价", System.Type.GetType("System.Double"));
            dtData.Columns.Add("金额", System.Type.GetType("System.Double"));
            dtData.Columns.Add("备注", System.Type.GetType("System.String"));
            this.明细DataGridView.DataSource = dtData;
        }

        private void InitCmbCommunity()
        {
            string query = "select * from 小区信息";
            DataTable dt = DataHelper.GetDataTable(query);
            communityInfoDic.Clear();
            foreach (System.Data.DataRow dRow in dt.Rows)
            {
                string v_小区名称 = Helper.Obj2String(dRow["小区名称"]);
                string v_服务电话 = Helper.Obj2String(dRow["服务电话"]);
                this.小区名称ComboBox.Items.Add(v_小区名称);
                if(!communityInfoDic.ContainsKey(v_小区名称))
                    communityInfoDic.Add(v_小区名称, v_服务电话);
            }
            if (dt.Rows.Count > 0)
                this.小区名称ComboBox.SelectedIndex = 0;
        }

        private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {//获取指定楼栋的业主信息
            string v_楼栋名称 = this.楼栋名称ComboBox.Text;
            string query = "SELECT * FROM 业主信息 WHERE (楼栋名称 = '" + v_楼栋名称 + "')";
            DataTable myTable = DataHelper.GetDataTable(query);
            UpdateOwnerInfoDic(myTable);
            this.业主姓名ComboBox.DataSource = myTable;
            this.业主姓名ComboBox.DisplayMember = "业主姓名";
            this.业主姓名ComboBox.ValueMember = "业主编号";
        }

        private void UpdateOwnerInfoDic(DataTable myTable)
        {
            ownerInfoDic.Clear();
            foreach(DataRow dRow in myTable.Rows)
            {
                string v_业主编号 = Helper.Obj2String(dRow["业主编号"]);
                string v_业主姓名 = Helper.Obj2String(dRow["业主姓名"]);
                double d_物业费用 = Helper.Obj2Double(dRow["物业费用"]);
                double d_预存金额 = Helper.Obj2Double(dRow["预存金额"]);
                if (!ownerInfoDic.ContainsKey(v_业主编号))
                    ownerInfoDic.Add(v_业主编号, new OwnerInfo() { v_业主编号 = v_业主编号, v_业主姓名 = v_业主姓名, d_物业费用 = d_物业费用, d_预存金额 = d_预存金额 });
            }
        }

        private void 查询Button_Click(object sender, EventArgs e)
        {//查询业主未交费信息
            string v_业主编号 = "";
            if (this.业主姓名ComboBox.SelectedValue != null && this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                v_业主编号= this.业主姓名ComboBox.SelectedValue.ToString();
            }
            string query = "SELECT 自动编号, 计费年份, 计费月份, 费用类型, 表编号, 上月数, 本月数, 表用量, 计费单价, 应交金额,补充说明 FROM 水电气费 WHERE (业主编号 ='" + v_业主编号 + "') AND (费用状态='未交费') ORDER BY 业主编号,表编号,计费年份,计费月份";
            DataTable myTable = DataHelper.GetDataTable(query);
            this.未交DataGridView.DataSource = myTable;
            this.交款人员TextBox.Text = this.业主姓名ComboBox.Text;
        }
                
        private void 新增Button_Click(object sender, EventArgs e)
        {//新增收据信息
            string v_业主编号 = "";
            if (this.业主姓名ComboBox.SelectedValue != null && this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                v_业主编号= this.业主姓名ComboBox.SelectedValue.ToString();
            }
            if (this.未交DataGridView.Rows.Count < 1 || string.IsNullOrEmpty(v_业主编号) || !ownerInfoDic.ContainsKey(v_业主编号))
            {
                new MsgBoxForm("提示", "请先查询出一个业主的未缴费信息后再新增！").ShowDialog();
                return;
            }
            OwnerInfo currOwnerInfo = ownerInfoDic[v_业主编号];
            this.收据编号TextBox.Text = string.Format("WYF{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            this.收款日期DateTimePicker.Value  = DateTime.Now.Date;
            this.收款人员TextBox.Text  = this.MyOperator;
            this.应收金额TextBox.Text = (currOwnerInfo.d_物业费用 - currOwnerInfo.d_预存金额).ToString();
            this.补充说明TextBox.Text = string.Format("上期预存已抵扣{0}元", currOwnerInfo.d_预存金额);
            this.实收金额TextBox.Text = "";
            dtData.Rows.Clear();
        }
        private void 添加Button_Click(object sender, EventArgs e)
        {//添加交款明细项目
            if (dtData.Rows.Count >= 36)
            {
                new MsgBoxForm("提示", "收据打印已经到最大条数，请先打印保存后重新添加！").ShowDialog();
                return;
            }
            int nYear = Helper.Obj2Int(this.未交DataGridView.CurrentRow.Cells[1].Value);
            int nMonth = Helper.Obj2Int(this.未交DataGridView.CurrentRow.Cells[2].Value);
            if ((this.收据编号TextBox.Text.Length > 1) && (this.交款人员TextBox.Text.Length > 1))
            {
                DataRow dRow = dtData.NewRow();
                int int_序号 = Helper.Obj2Int(this.未交DataGridView.CurrentRow.Cells[0].Value);
                dRow[0] = int_序号;
                dRow["年份"] = nYear;
                dRow["月份"] = nMonth;
                if (dtData.Select("序号=" + int_序号).Length > 0)
                {
                    new MsgBoxForm("提示", "该条费用信息已添加，请另选一条！").ShowDialog();
                    return;
                }
                if (dtData.Rows.Count > 0)
                {
                    int existingYear = Helper.Obj2Int(dtData.Rows[0]["年份"]);
                    int existingMonth = Helper.Obj2Int(dtData.Rows[0]["月份"]);
                    if (existingYear != nYear || existingMonth != nMonth)
                    {
                        new MsgBoxForm("提示", "一张收费单据只能包含同一年月的收费信息！").ShowDialog();
                        return;
                    }
                }
                dRow["类型"] = Helper.Obj2String(this.未交DataGridView.CurrentRow.Cells[3].Value);
                dRow["表号"] = Helper.Obj2String(this.未交DataGridView.CurrentRow.Cells[4].Value);
                dRow["上月数"] = Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[5].Value);
                dRow["本月数"] = Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[6].Value);
                dRow["用量"] = Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[7].Value);
                dRow["单价"] = Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[8].Value);
                dRow["金额"] = Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[9].Value);
                dRow["备注"] = Helper.Obj2String(this.未交DataGridView.CurrentRow.Cells[10].Value); ;
                
                dtData.Rows.Add(dRow);
                double myAmount = Helper.String2Double(this.应收金额TextBox.Text.Trim());
                myAmount += Helper.Obj2Double(this.未交DataGridView.CurrentRow.Cells[9].Value);
                this.应收金额TextBox.Text = myAmount.ToString();
                RefreshDataGridViewStatus();
            }
            else
            {
                new MsgBoxForm("提示", "请先新增收费内容！").ShowDialog();
            }
        }
        
        private void 移除Button_Click(object sender, EventArgs e)
        {//移除交款明细项目
            try
            {
                if (dtData.Rows.Count > 0)
                {
                    double myAmount = Helper.String2Double(this.应收金额TextBox.Text.Trim());
                    myAmount -= Helper.Obj2Double(this.明细DataGridView.CurrentRow.Cells[9].Value);
                    this.应收金额TextBox.Text = myAmount.ToString();
                    dtData.Rows.RemoveAt(this.明细DataGridView.CurrentRow.Index);
                    RefreshDataGridViewStatus();
                }
                else
                {
                    new MsgBoxForm("提示", "没有项目可以移除了！").ShowDialog();
                }
            }
            catch(Exception ex)
            {
                LogHelper.LogError(ex);
            }
        }
        private void RefreshDataGridViewStatus()
        {
            for (int i = 0; i < this.未交DataGridView.Rows.Count; i++)
            {
                int int_序号 = Helper.Obj2Int(this.未交DataGridView.Rows[i].Cells[0].Value);
                if (dtData.Select("序号=" + int_序号).Length > 0)
                {
                    this.未交DataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                    this.未交DataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void 打印Button_Click(object sender, EventArgs e)
        {//打印水电气费交款收据
            this.printPreviewDialog1.Document = this.printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.Icon = new Icon(this.MyPrintIcon);
            this.printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int currFeeYear = 0, currFeeMonth = 0;
            if (dtData.Rows.Count == 0)
            {
                new MsgBoxForm("提示", "没有要打印的单据！").ShowDialog();
                return;
            }
            else
            {
                currFeeYear = Helper.Obj2Int(dtData.Rows[0]["年份"]);
                currFeeMonth = Helper.Obj2Int(dtData.Rows[0]["月份"]);
            }
            string v_业主编号 = "";
            if (this.业主姓名ComboBox.SelectedValue != null && this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                v_业主编号 = this.业主姓名ComboBox.SelectedValue.ToString();
            }
            string v_应收金额 = this.应收金额TextBox.Text;
            string v_实收金额 = this.实收金额TextBox.Text;
            OwnerInfo ownerInfo = ownerInfoDic.ContainsKey(v_业主编号) ? ownerInfoDic[v_业主编号] : null;
            float f_应收金额 = 0, f_实收金额 = 0, f_预存金额 = 0;
            float.TryParse(v_应收金额, out f_应收金额);
            float.TryParse(v_实收金额, out f_实收金额);
            f_预存金额 = f_实收金额 - f_应收金额;
            if (f_实收金额 < f_应收金额)
            {
                new MsgBoxForm("提示", "实收金额不能小于应收金额！").ShowDialog();
                return;
            }
            PriceInfo priceInfo = PriceHelper.GetPriceInfo();
            e.Graphics.DrawString(string.Format("{0}{1}年{2}月物业管理费明细单", this.MyCommunity, currFeeYear, currFeeMonth), new Font("宋体", 16), Brushes.Black, 180, 20);
            e.Graphics.DrawLine(new Pen(Color.Black, (float)1.00), 50, 45, 770, 45);
            e.Graphics.DrawString("业主姓名：" + this.交款人员TextBox.Text, new Font("宋体", 10), Brushes.Black, 55, 50);
            e.Graphics.DrawString("业主编号：" + v_业主编号, new Font("宋体", 10), Brushes.Black, 550, 50);
            e.Graphics.DrawLine(new Pen(Color.Black), 50, 70, 770, 70);
            e.Graphics.DrawString("电表序列", new Font("宋体", 10), Brushes.Black, 55, 78);
            e.Graphics.DrawString("电单价", new Font("宋体", 10), Brushes.Black, 125, 78);
            e.Graphics.DrawString("上月数", new Font("宋体", 10), Brushes.Black, 180, 78);
            e.Graphics.DrawString("本月数", new Font("宋体", 10), Brushes.Black, 235, 78);
            e.Graphics.DrawString("用量", new Font("宋体", 10), Brushes.Black, 290, 78);
            e.Graphics.DrawString("电费", new Font("宋体", 10), Brushes.Black, 340, 78);
            e.Graphics.DrawString("公共照明", new Font("宋体", 10), Brushes.Black, 400, 78);
            e.Graphics.DrawString("电损", new Font("宋体", 10), Brushes.Black, 470, 78);
            e.Graphics.DrawString("物业费", new Font("宋体", 10), Brushes.Black, 520, 78);
            e.Graphics.DrawString("合计", new Font("宋体", 10), Brushes.Black, 575, 78);
            int MyPosY = 98;
            int MyID=1;
            foreach (DataRow MyRow in this.dtData.Rows)
            {
                string v_物业费 = string.Empty;
                double d_物业费 = 0;
                if (ownerInfo != null && MyID == 1)
                {
                    d_物业费 = ownerInfo.d_物业费用;
                    v_物业费 = d_物业费.ToString("N3");
                }
                double d_电费 = Helper.Obj2Double(MyRow["金额"]);
                double d_合计 = d_电费 + d_物业费;
                e.Graphics.DrawString(MyID.ToString(), new Font("宋体", 10), Brushes.Black, 55, MyPosY);
                e.Graphics.DrawString(priceInfo.d_标准电费价格.ToString("N3"), new Font("宋体", 10), Brushes.Black, 125, MyPosY);
                e.Graphics.DrawString(Helper.Obj2String(MyRow["上月数"]), new Font("宋体", 10), Brushes.Black, 180, MyPosY);
                e.Graphics.DrawString(Helper.Obj2String(MyRow["本月数"]), new Font("宋体", 10), Brushes.Black, 235, MyPosY);
                e.Graphics.DrawString(Helper.Obj2String(MyRow["用量"]), new Font("宋体", 10), Brushes.Black, 290, MyPosY);
                e.Graphics.DrawString(d_电费.ToString("N3"), new Font("宋体", 10), Brushes.Black, 340, MyPosY);
                e.Graphics.DrawString(priceInfo.d_公共照明价格.ToString("N3"), new Font("宋体", 10), Brushes.Black, 400, MyPosY);
                e.Graphics.DrawString(priceInfo.d_电力损耗价格.ToString("N3"), new Font("宋体", 10), Brushes.Black, 470, MyPosY);
                e.Graphics.DrawString(v_物业费, new Font("宋体", 10), Brushes.Black, 520, MyPosY);
                e.Graphics.DrawString(d_合计.ToString("N3"), new Font("宋体", 10), Brushes.Black, 575, MyPosY);
                MyPosY += 20;
                MyID += 1;
            }
            e.Graphics.DrawLine(new Pen(Color.Black), 50, MyPosY, 770, MyPosY);
            e.Graphics.DrawLine(new Pen(Color.Black), 120, 70, 120, MyPosY);
            e.Graphics.DrawLine(new Pen(Color.Black), 175, 70, 175, MyPosY);
            e.Graphics.DrawLine(new Pen(Color.Black), 230, 70, 230, MyPosY);
            e.Graphics.DrawLine(new Pen(Color.Black), 285, 70, 285, MyPosY + 50);
            e.Graphics.DrawLine(new Pen(Color.Black), 335, 70, 335, MyPosY);
            e.Graphics.DrawLine(new Pen(Color.Black), 395, 70, 395, MyPosY);
            e.Graphics.DrawLine(new Pen(Color.Black), 465, 70, 465, MyPosY);
            e.Graphics.DrawLine(new Pen(Color.Black), 515, 70, 515, MyPosY);
            e.Graphics.DrawLine(new Pen(Color.Black), 570, 70, 570, MyPosY + 50);
            e.Graphics.DrawLine(new Pen(Color.Black), 425, MyPosY, 425, MyPosY + 50);
            e.Graphics.DrawString("应收费用：" + f_应收金额.ToString("N2") + "元", new Font("宋体", 10), Brushes.Black, 55, MyPosY + 10);
            e.Graphics.DrawString("实收费用：" + f_实收金额.ToString("N2") + "元", new Font("宋体", 10), Brushes.Black, 290, MyPosY + 10);
            e.Graphics.DrawString("预收费用：" + f_预存金额.ToString("N2") + "元", new Font("宋体", 10), Brushes.Black, 430, MyPosY + 10);
            e.Graphics.DrawString("缴费时间：" + DateTime.Now.ToString("yyyy年M月d日"), new Font("宋体", 10), Brushes.Black, 575, MyPosY + 10);
            e.Graphics.DrawString("备注：" + this.补充说明TextBox.Text, new Font("宋体", 10), Brushes.Black, 55, MyPosY + 30);
            //下边框
            e.Graphics.DrawLine(new Pen(Color.Black, (float)1.00), 50, MyPosY + 50, 770, MyPosY + 50);
            //左边框
            e.Graphics.DrawLine(new Pen(Color.Black, (float)1.00), 50, 45, 50, MyPosY + 50);
            //右边框
            e.Graphics.DrawLine(new Pen(Color.Black, (float)1.00), 770, 45, 770, MyPosY + 50);
            if (communityInfoDic.ContainsKey(this.MyCommunity))
            {
                string v_服务电话 = communityInfoDic[this.MyCommunity];
                if(!string.IsNullOrEmpty(v_服务电话))
                    e.Graphics.DrawString(string.Format("报修、查询费用请拨物业服务电话: {0}", v_服务电话), new Font("宋体", 10), Brushes.Black, 430, MyPosY + 55);
            }
        }
        private void 保存Button_Click(object sender, EventArgs e)
        {//保存水电气费交款信息
            string v_业主编号 = "";
            if (this.业主姓名ComboBox.SelectedValue != null && this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                v_业主编号 = this.业主姓名ComboBox.SelectedValue.ToString();
            }
            string v_楼栋名称 = this.楼栋名称ComboBox.Text;
            string v_收据编号 = Helper.GetTextBoxCtrlValue(this.Controls, "收据编号");
            if (string.IsNullOrEmpty(v_收据编号))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            
            if (new MsgBoxForm("警告", "现在将保存业主交纳的物业费数据，是否继续？", true).ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                string v_收款日期 = Helper.GetDateCtrlValue(this.Controls, "收款日期");
                string v_交款人员 = Helper.GetTextBoxCtrlValue(this.Controls, "交款人员");
                string v_应收金额 = Helper.GetTextBoxCtrlValue(this.Controls, "应收金额");
                string v_实收金额 = Helper.GetTextBoxCtrlValue(this.Controls, "实收金额");
                string v_收款形式 = Helper.GetComBoxCtrlValue(this.Controls, "收款形式");
                string v_收款人员 = Helper.GetTextBoxCtrlValue(this.Controls, "收款人员");
                string v_收款事由 = Helper.GetTextBoxCtrlValue(this.Controls, "收款事由");
                string v_补充说明 = Helper.GetTextBoxCtrlValue(this.Controls, "补充说明");
                if (string.IsNullOrEmpty(v_实收金额))
                {
                    new MsgBoxForm("提示", "请输入实收金额！").ShowDialog();
                    return;
                }
                float f_应收金额 = 0, f_实收金额 = 0, f_预存金额 = 0;
                float.TryParse(v_应收金额, out f_应收金额);
                float.TryParse(v_实收金额, out f_实收金额);
                f_预存金额 = f_实收金额 - f_应收金额;
                if (f_实收金额 < f_应收金额)
                {
                    new MsgBoxForm("提示", "实收金额不能小于应收金额！").ShowDialog();
                    return;
                }
                string query = string.Format("INSERT INTO 费用收据(收据编号,收款日期,交款人员,应收金额,实收金额,收款形式,收款人员,收款事由,补充说明) VALUES('{0}','{1}','{2}',{3},{4},'{5}','{6}','{7}','{8}')",
                    v_收据编号, v_收款日期, v_交款人员, v_应收金额, v_实收金额, v_收款形式, v_收款人员, v_收款事由, v_补充说明);
                DataHelper.UpdateOrDeleteRecord(query);

                foreach (DataRow dRow in dtData.Rows)
                {
                    string v_自动编号 = dRow[0].ToString();
                    string My收据编号 = this.收据编号TextBox.Text;
                    query = "UPDATE 水电气费 SET 费用状态='已交费',收据编号='" + My收据编号 + "' WHERE 自动编号=" + v_自动编号;
                    DataHelper.UpdateOrDeleteRecord(query);
                }

                query = "UPDATE 业主信息 SET 预存金额=" + f_预存金额 + " WHERE 业主编号='" + v_业主编号 + "' AND 楼栋名称='" + v_楼栋名称 + "'";
                int nRet = DataHelper.UpdateOrDeleteRecord(query);
                if(nRet > 0)  //更新预存金额
                {
                    if (ownerInfoDic.ContainsKey(v_业主编号))
                        ownerInfoDic[v_业主编号].d_预存金额 = f_预存金额;
                }
                DataHelper.CommitUpdate();
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {
                new MsgBoxForm("提示", "保存失败，请检查所填数据类型！").ShowDialog();
                LogHelper.LogError(ex);
            }
            查询Button_Click(null, null);
            dtData.Rows.Clear();
        }

        private void 小区名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v_小区名称 = this.小区名称ComboBox.Text.Trim();
            this.楼栋名称ComboBox.Items.Clear();
            this.MyCommunity = v_小区名称;
            string query = string.Format("select * from 楼栋信息 where 小区名称='{0}'", v_小区名称);
            DataTable dt = DataHelper.GetDataTable(query);
            foreach (DataRow dRow in dt.Rows)
            {
                this.楼栋名称ComboBox.Items.Add(dRow["楼栋名称"].ToString());
            }
            if (dt.Rows.Count > 0)
                this.楼栋名称ComboBox.SelectedIndex = 0;
            else
                this.业主姓名ComboBox.DataSource = null;
        }
    }
}