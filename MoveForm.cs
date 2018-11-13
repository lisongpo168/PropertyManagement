//文件名：MoveForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace MyCommunity
{
    public partial class MoveForm : Form
    {
        public MoveForm()
        {
            InitializeComponent();
            InitCmbBuilding();
        }
        private void 迁出信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.迁出信息BindingSource.EndEdit();
            //this.迁出信息TableAdapter.Update(this.dBCommunityDataSet.迁出信息);
        }
        private void 查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.迁出信息TableAdapter.Fill(this.dBCommunityDataSet.迁出信息, 业主编号ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                
            }
        }
        private void MoveForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dBCommunityDataSet.楼栋信息”中
            //this.楼栋信息TableAdapter.Fill(this.dBCommunityDataSet.楼栋信息);
            try
            {
                //this.迁出信息TableAdapter.Fill(this.dBCommunityDataSet.迁出信息, 业主编号ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
            }
        }
        private void 楼栋名称ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {//获取指定楼栋的业主信息
            string buildName = this.楼栋名称ComboBox.Text;
            if (!string.IsNullOrEmpty(buildName))
            {
                string query = string.Format("SELECT * FROM 业主信息 WHERE (业主编号 NOT IN (SELECT 业主编号 FROM 迁出信息)) AND (楼栋名称='{0}')", buildName);
                System.Data.DataTable dt = DataHelper.GetDataTable(query);
                this.业主姓名ComboBox.DataSource = dt;
                this.业主姓名ComboBox.DisplayMember = "业主姓名";
                this.业主姓名ComboBox.ValueMember = "业主编号";
            }
        }
        private void 业主姓名ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.业主姓名ComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                this.业主编号TextBox.Text = this.业主姓名ComboBox.SelectedValue.ToString();
            }
            else
                this.业主姓名ComboBox.Text = string.Empty;
        }

        private void InitCmbBuilding()
        {
            string query = "select * from 楼栋信息";
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            foreach (System.Data.DataRow dRow in dt.Rows)
            {
                this.楼栋名称ComboBox.Items.Add(dRow["楼栋名称"].ToString());
            }
        }
    }
}