//文件名：ChangeUserPasswordForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MyCommunity.Common;
namespace MyCommunity
{
    public partial class SetMeterForm : DevComponents.DotNetBar.Office2007Form
    {
        public string MeterStr = string.Empty;
        public List<string> MeterInfoList = new List<string>();
        public SetMeterForm(List<string> meterInfoList)
        {
            InitializeComponent();
            if (meterInfoList != null && meterInfoList.Count > 0)
            {
                for (int i = 0; i < meterInfoList.Count; i++)
                {
                    object[] objs = new object[] { i + 1, meterInfoList[i] };
                    this.电表信息DataGridView.Rows.Add(objs);
                }
            }
        }

        private void 返回系统Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void 修改电表Button_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow viewRow in this.电表信息DataGridView.Rows)
                {
                    string meterNo = Helper.GetCellValue(viewRow, "电表编号");
                    if (!string.IsNullOrEmpty(meterNo) && !MeterInfoList.Contains(meterNo))
                    {
                        MeterInfoList.Add(meterNo);
                        MeterStr += meterNo + ",";
                    }
                }
                if (MeterInfoList.Count > 0)
                {
                    MeterStr = MeterStr.Substring(0, MeterStr.Length - 1);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    new MsgBoxForm("提示", "请至少填写一个电表编号！").ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
            }
            this.Close();
        }
    }
}