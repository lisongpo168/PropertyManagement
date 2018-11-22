//文件名：LoginForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Security.Principal;
using System.Data.SqlClient;
using MyCommunity.Common;
namespace MyCommunity
{
    public partial class LoginForm : DevComponents.DotNetBar.Office2007Form
    {
        public string UserName, UserID;
        public LoginForm()
        {
            InitializeComponent();
            InitUserCmb();
        }

        private void InitUserCmb()
        {
            string query = "select * from 操作用户";
            DataTable dt = DataHelper.GetDataTable(query);
            this.用户名称ComboBox.DataSource = dt;
            this.用户名称ComboBox.DisplayMember = "用户姓名";
            this.用户名称ComboBox.ValueMember = "用户名称";
            if (dt.Rows.Count > 0)
                this.用户名称ComboBox.SelectedIndex = 0;
        }
        //记录用户登录次数
        private int MyTryCount = 0;
        private void 登录系统Button_Click(object sender, EventArgs e)
        {//从app.config文件中读取数据库连接字符串信息
            UserName = this.用户名称ComboBox.Text.Trim();
            UserID = this.用户名称ComboBox.SelectedValue.ToString();
            string MyPassword = this.用户密码TextBox.Text;
            string encodedPass = Helper.EncodePassword(MyPassword);
            string query = string.Format("Select * From 操作用户 Where 用户名称='{0}' AND 用户密码='{1}'", UserID, encodedPass);
            DataTable dt = DataHelper.GetDataTable(query);
            int MyCount = dt.Rows.Count;
            if (MyCount == 1)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                this.MyTryCount += 1;
                if (this.MyTryCount != 3)
                {
                    int MyDoCount = 3 - this.MyTryCount;
                    MessageBox.Show("用户密码或用户名称有错，还有" + MyDoCount + "次机会！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.用户密码TextBox.Text = "";
                    this.用户名称ComboBox.Text = "";
                }
                else
                {
                    退出系统Button_Click(null, null);
                }
            }
        }
        private void 退出系统Button_Click(object sender, EventArgs e)
        {
            MainForm MyDlg = (MainForm)this.Owner;
            MyDlg.Close();
        }
    }
}