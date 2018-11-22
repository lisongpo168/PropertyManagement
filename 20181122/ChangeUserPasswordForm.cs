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
    public partial class ChangeUserPasswordForm : DevComponents.DotNetBar.Office2007Form
    {
        public ChangeUserPasswordForm()
        {
            InitializeComponent();
        }
        private void 返回系统Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void 修改密码Button_Click(object sender, EventArgs e)
        {
            if (!(this.新密码TextBox.Text == this.再输一次新密码TextBox.Text) || (this.新密码TextBox.Text.Length == 0))
            {
                new MsgBoxForm("提示", "两次密码的输入不一致！").ShowDialog();
                return;
            }
            string MyNewPassword = this.新密码TextBox.Text;            
            string MyNewPW = Helper.EncodePassword(MyNewPassword);
            string MyOldPassword = this.旧密码TextBox.Text;            
            string MyOldPW = Helper.EncodePassword(MyOldPassword);
            string query = "Update  操作用户 Set 用户密码='" + MyNewPW + "' Where 用户名称='" + this.用户名称TextBox.Text.Trim() + "' AND 用户密码='" + MyOldPW + "'";
            int nRet = DataHelper.UpdateOrDeleteRecord(query);
            if (nRet == 1)
            {
                new MsgBoxForm("提示", "修改用户密码操作成功！").ShowDialog();
            }
            else
            {
                new MsgBoxForm("提示", "修改用户密码操作失败！").ShowDialog();
            }
        }
    }
}