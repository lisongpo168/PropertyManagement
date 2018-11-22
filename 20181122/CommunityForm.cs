using MyCommunity.Common;
//文件名：CommunityForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyCommunity
{
    public partial class CommunityForm : DevComponents.DotNetBar.Office2007Form
    {
        public CommunityForm()
        {
            InitializeComponent();
        }
        private void CommunityForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dBCommunityDataSet.小区信息”中
            SynCommunity();                
        }
        private void 小区信息BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (string.IsNullOrEmpty(this.小区名称TextBox.Text))
            {
                new MsgBoxForm("提示", "没有输入正确的信息！").ShowDialog();
                return;
            }
            try
            {
                string v_小区名称 = Helper.GetTextBoxCtrlValue(this.Controls, "小区名称");
                string v_总负责人 = Helper.GetTextBoxCtrlValue(this.Controls, "总负责人");
                string v_小区地址 = Helper.GetTextBoxCtrlValue(this.Controls, "小区地址");
                string v_邮政编码 = Helper.GetTextBoxCtrlValue(this.Controls, "邮政编码");
                string v_服务电话 = Helper.GetTextBoxCtrlValue(this.Controls, "服务电话");
                string v_电子信箱 = Helper.GetTextBoxCtrlValue(this.Controls, "电子信箱");
                string v_小区网站 = Helper.GetTextBoxCtrlValue(this.Controls, "小区网站");
                string v_首页图像 = "";
                string v_背景图像 = Helper.GetTextBoxCtrlValue(this.Controls, "背景图像");
                string v_物业公司 = Helper.GetTextBoxCtrlValue(this.Controls, "物业公司");
                string v_系统名称 = Helper.GetTextBoxCtrlValue(this.Controls, "系统名称");
                string v_优先级 = Helper.GetTextBoxCtrlValue(this.Controls, "优先级");
                string query = string.Empty;
                if (IsNewAdded(v_小区名称))
                {
                    query = string.Format("insert into 小区信息(`小区名称`, `总负责人`,`小区地址`, `邮政编码`, `服务电话`, `电子信箱`, `小区网站`, `首页图像`, `背景图像`,`物业公司`,`系统名称`,`优先级`)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                        v_小区名称, v_总负责人, v_小区地址, v_邮政编码, v_服务电话, v_电子信箱, v_小区网站, v_首页图像, v_背景图像, v_物业公司, v_系统名称, v_优先级);
                }
                else
                {
                    query = string.Format("update 小区信息 set 总负责人='{0}',小区地址='{1}',邮政编码='{2}',服务电话='{3}',电子信箱='{4}',小区网站='{5}',首页图像='{6}',背景图像='{7}',物业公司='{8}',系统名称='{9}',优先级='{10}' where 小区名称='{11}'",
                        v_总负责人, v_小区地址, v_邮政编码, v_服务电话, v_电子信箱, v_小区网站, v_首页图像, v_背景图像, v_物业公司, v_系统名称, v_优先级, v_小区名称);
                }
                DataHelper.UpdateOrDeleteRecord(query);
                SynCommunity();
                new MsgBoxForm("提示", "保存成功！").ShowDialog();
            }
            catch (Exception ex)
            {
                new MsgBoxForm("提示", "保存失败，请检查所填数据类型！").ShowDialog();
                LogHelper.LogError(ex);
            }
        }
        private void 浏览图像Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog MyDlg = new OpenFileDialog();
            MyDlg.Title = "选择图像";
            MyDlg.Filter = "JPEG图像文件(*.jpg)|*.jpg|所有图像文件(JPeg, Gif, Bmp, etc.)|*.jpg;*.jpeg; *.gif;*.bmp;*.tif; *.tiff; *.png|所有文件(*.*)|*.*";
            if (MyDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.背景图像TextBox.Text = System.IO.Path.GetFileName(MyDlg.FileName);
                    string MySrcPath = MyDlg.FileName;
                    string MyDestPath = Application.StartupPath + "\\Data\\" + this.背景图像TextBox.Text;
                    System.IO.File.Copy(MySrcPath, MyDestPath);
                }
                catch (Exception ex)
                {
                    LogHelper.LogError(ex);
                }
            }   
        }

        private void SynCommunity()
        {
            string query = "select * from 小区信息";
            DataTable dt = DataHelper.GetDataTable(query);
            this.小区信息DataGridView.DataSource = dt;
        }

        private bool IsNewAdded(string comName)
        {
            string query = string.Format("select * from 小区信息 where 小区名称='{0}'", comName);
            System.Data.DataTable dt = DataHelper.GetDataTable(query);
            return dt.Rows.Count < 1;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string comName = this.小区名称TextBox.Text.Trim();
            if (string.IsNullOrEmpty(comName))
            {
                new MsgBoxForm("提示", "没有选择正确的要删除的记录！").ShowDialog();
                return;
            }

            if (new MsgBoxForm("警告", "确定要删除小区 " + comName + " 的信息吗？ 删除后将无法恢复！", true).ShowDialog() == DialogResult.OK)
            {
                string query = string.Format("delete from 小区信息 where 小区名称='{0}'", comName);
                DataHelper.UpdateOrDeleteRecord(query);
                SynCommunity();
            }
        }

        private void 小区信息DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currRow = this.小区信息DataGridView.CurrentRow;
            for (int i = 0; i < this.小区信息DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.小区信息DataGridView.Columns[i].DataPropertyName;
                string columnName = this.小区信息DataGridView.Columns[i].Name;
                string value = Helper.GetCellValue(currRow, columnName);
                 Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, value);
            }
            if (currRow != null)
                this.bindingNavigatorDeleteItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.小区信息DataGridView.Columns.Count; i++)
            {
                string ctrlName = this.小区信息DataGridView.Columns[i].DataPropertyName;
                Helper.SetTextBoxCtrlValue(this.Controls, ctrlName, string.Empty);
            }
        }
    }
}