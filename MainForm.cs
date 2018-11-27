//文件名：MainForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using MyCommunity.Common;
namespace MyCommunity
{
    public partial class MainForm : DevComponents.DotNetBar.Office2007Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.menuStrip1.Renderer = new MyMenuRenderer();
        }
        private string MyBgPhoto;
        private string MySlogan;
        private string MyBgPhotoShow;
        private string MyOperator = "";
        private string MyCompany = "";
        private string MyCommunity;
        private string MyPrintIcon;
        private string MyUserId = "";
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //添加ThreadException事件关联程序
                Application.ThreadException += MyThreadException;
                //if (new SecurityForm().ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                //    this.Close();
                //从小区信息数据表中读取基本信息
                this.GetCommunityInformation();
                //显示登录对话框
                LoginForm MyDlg = new LoginForm();
                MyDlg.Text = "欢迎使用" + MySlogan;
                if (MyDlg.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                    this.Close();
                this.MyOperator = MyDlg.UserName;
                this.MyUserId = MyDlg.UserID;
                //根据用户的操作权限配置系统菜单
                SetUserOperateMenu(MyDlg.UserID);
                //最大化显示系统主窗体
                if (MyOperator.Length > 0)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                //设置系统背景图像信息
                //this.BackgroundImage = Image.FromFile(this.MyBgPhotoShow);
                //this.BackgroundImage = new Bitmap(this.MyBgPhotoShow, true);
                //this.Icon = new Icon(this.MyIcon);
                //设置系统标题栏显示文字
                this.Text = MySlogan;
            }                
            catch
            {
                this.Close();
            }
        }
        public void MyThreadException(Object sender, System.Threading.ThreadExceptionEventArgs e)
        {//系统异常处理代码
            string MyInfo = "错误名称：" + e.Exception.Source + "，错误信息：" + e.Exception.Message;
            LogHelper.LogError(e.Exception);
        }
        protected override void WndProc(ref Message SystemMessage)
        {//实现在系统关闭前给予用户提示        
            switch (SystemMessage.Msg)
            {
                case 0x0112:
                    if (((int)SystemMessage.WParam) == 61536)
                    {
                        退出系统ToolStripMenuItem_Click(null, null);
                    }
                    else
                    {
                        base.WndProc(ref SystemMessage);
                    }
                    break;
                default:
                    base.WndProc(ref SystemMessage);
                    break;
            }
        }
        public void GetCommunityInformation()
        {//从小区信息数据表中读取基本信息
            MySlogan = "智慧管家物业管理系统";
            MyBgPhotoShow = Application.StartupPath + "\\Data\\bk.jpg";
            MyBgPhoto = Application.StartupPath + "\\Data\\bk.jpg";
            MyPrintIcon = Application.StartupPath + "\\Data\\print.ico";
        }
        //根据用户的操作权限配置系统菜单
        public void SetUserOperateMenu(string userId)
        {
            string query = "Select * From 操作用户 Where 用户名称='" + userId + "'";
            DataTable MyTable = DataHelper.GetDataTable(query);
            if ((int)MyTable.Rows[0]["基本管理之业主登记管理"] == 0)
            {
                this.业主登记管理ToolStripMenuItem.Visible = false;
                this.业主登记管理ToolStripSeparator.Visible = false;
                this.业主登记管理ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["基本管理之业主迁出管理"] == 0)
            {
                this.业主迁出管理ToolStripMenuItem.Visible = false;
                this.业主迁出管理ToolStripSeparator.Visible = false;
                this.业主迁出管理ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["基本管理之楼栋信息管理"] == 0)
            {
                this.楼栋信息管理ToolStripMenuItem.Visible = false;
                this.楼栋信息管理ToolStripSeparator.Visible = false;
                this.楼栋信息管理ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["基本管理之公共财产管理"] == 0)
            {
                this.公共财产管理ToolStripMenuItem.Visible = false;
                this.公共财产管理ToolStripButton.Visible = false;
            }
            //if ((int)MyTable.Rows[0]["物业管理之服务投诉管理"] == 0)
            {
                this.服务投诉管理ToolStripMenuItem.Visible = false;
                this.服务投诉管理ToolStripSeparator.Visible = false;
                this.服务投诉管理ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["物业管理之业主维修管理"] == 0)
            {
                this.业主维修管理ToolStripMenuItem.Visible = false;
                this.业主维修管理ToolStripSeparator.Visible = false;
                this.业主维修管理ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["物业管理之公共维修管理"] == 0)
            {
                this.公共维修管理ToolStripMenuItem.Visible = false;
                this.公共维修管理ToolStripSeparator.Visible = false;
                this.公共维修管理ToolStripButton.Visible = false;
            }
            //if ((int)MyTable.Rows[0]["物业管理之车位使用管理"] == 0)
            {
                this.车位使用管理ToolStripMenuItem.Visible = false;
                this.车位使用管理ToolStripSeparator.Visible = false;
                this.车位使用管理ToolStripButton.Visible = false;
            }
            //if ((int)MyTable.Rows[0]["物业管理之突发事件管理"] == 0)
            {
                this.突发事件管理ToolStripMenuItem.Visible = false;
                this.突发事件管理ToolStripButton.Visible = false;
            }


            //if ((int)MyTable.Rows[0]["费用管理之水电气费登记"] == 0)
            {
                this.水电气费登记ToolStripMenuItem.Visible = false;
                this.水电气费登记ToolStripSeparator.Visible = false;
                this.水电气费登记ToolStripButton.Visible = false;
            }
            //if ((int)MyTable.Rows[0]["费用管理之水电气费查询"] == 0)
            {
                this.水电气费查询ToolStripMenuItem.Visible = false;
                this.水电气费查询ToolStripSeparator.Visible = false;
                this.水电气费查询ToolStripButton.Visible = false;
            }
            //if ((int)MyTable.Rows[0]["费用管理之水电气费交纳"] == 0)
            {
                this.水电气费交纳ToolStripMenuItem.Visible = false;
                this.水电气费交纳ToolStripSeparator.Visible = false;
                this.水电气费交纳ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["费用管理之物管费用登记"] == 0)
            {
                this.物管费用登记ToolStripMenuItem.Visible = false;
                this.物管费用登记ToolStripSeparator.Visible = false;
                this.物管费用登记ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["费用管理之物管费用查询"] == 0)
            {
                this.物管费用查询ToolStripMenuItem.Visible = false;
                this.物管费用查询ToolStripSeparator.Visible = false;
                this.物管费用查询ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["费用管理之物管费用交纳"] == 0)
            {
                this.物管费用交纳ToolStripMenuItem.Visible = false;
                this.物管费用交纳ToolStripSeparator.Visible = false;
                this.物管费用交纳ToolStripButton.Visible = false;
            }

            if ((int)MyTable.Rows[0]["费用管理之其他费用交纳"] == 0)
            {
                this.其他费用交纳ToolStripMenuItem.Visible = false;
                this.其他费用交纳ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["报表管理之业主统计报表"] == 0)
            {
                this.业主统计报表ToolStripMenuItem.Visible = false;
                this.业主统计报表ToolStripSeparator.Visible = false;
                this.业主统计报表ToolStripButton.Visible = false;
            }
            //if ((int)MyTable.Rows[0]["报表管理之投诉统计报表"] == 0)
            {
                this.投诉统计报表ToolStripMenuItem.Visible = false;
                this.投诉统计报表ToolStripSeparator.Visible = false;
                this.投诉统计报表ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["报表管理之业主维修报表"] == 0)
            {
                this.业主维修报表ToolStripMenuItem.Visible = false;
                this.业主维修报表ToolStripSeparator.Visible = false;
                this.业主维修报表ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["报表管理之公共维修报表"] == 0)
            {
                this.公共维修报表ToolStripMenuItem.Visible = false;
                this.公共维修报表ToolStripSeparator.Visible = false;
                this.公共维修报表ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["报表管理之收入统计报表"] == 0)
            {
                this.收入统计报表ToolStripMenuItem.Visible = false;
                this.收入统计报表ToolStripButton.Visible = false;
            }
            if ((int)MyTable.Rows[0]["系统管理之分配用户权限"] == 0)
            {
                this.分配用户权限ToolStripMenuItem.Visible = false;
                this.分配用户权限ToolStripSeparator.Visible = false;
                this.分配用户权限ToolStripSeparator.Visible = false;
            }
            if ((int)MyTable.Rows[0]["系统管理之小区信息设置"] == 0)
            {
                this.小区信息设置ToolStripMenuItem.Visible = false;
                this.小区信息设置ToolStripSeparator.Visible = false;
                this.小区信息设置ToolStripSeparator.Visible = false;
            }
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new MsgBoxForm("警告", "您确定现在退出本系统吗？", true).ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void 小区信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommunityForm MyDlg = new CommunityForm();
            MyDlg.ShowDialog();
            //StringBuilder MyTempPath = new StringBuilder(this.MyBgPhotoShow);
            this.GetCommunityInformation();
            this.Text = MySlogan;
            //this.Icon = new Icon(this.MyIcon);
        }
        private void 分配用户权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorForm MyDlg = new OperatorForm();
            MyDlg.ShowDialog();
        }
        private void 修改用户密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserPasswordForm MyDlg = new ChangeUserPasswordForm();
            MyDlg.用户名称TextBox.Text = this.MyUserId;
            MyDlg.ShowDialog();
        }
        private void 系统帮助信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionForm MyDlg = new VersionForm();
            MyDlg.label1.Text = this.MySlogan;
            MyDlg.ShowDialog();
        }
        private void 业主登记管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnerForm MyDlg = new OwnerForm();
            MyDlg.ShowDialog();
        }
        private void 业主迁出管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveForm MyDlg = new MoveForm();
            MyDlg.ShowDialog();
        }
        private void 楼栋信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildingForm MyDlg = new BuildingForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 公共财产管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonPropertyForm MyDlg = new CommonPropertyForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 服务投诉管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplainForm MyDlg = new ComplainForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 业主维修管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnerRepairForm MyDlg = new OwnerRepairForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 公共维修管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonRepairForm MyDlg = new CommonRepairForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 车位使用管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationForm MyDlg = new StationForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 突发事件管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventForm MyDlg = new EventForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 水电气费登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GasRegisterForm MyDlg = new GasRegisterForm();
            MyDlg.ShowDialog();
        }
        private void 水电气费查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GasQueryForm MyDlg = new GasQueryForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 水电气费交纳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GasPaymentForm MyDlg = new GasPaymentForm(this.MyCommunity, this.MyOperator, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 物管费用登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GasRegisterForm MyDlg = new GasRegisterForm();
            MyDlg.ShowDialog();
        }
        private void 物管费用查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GasQueryForm MyDlg = new GasQueryForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 物管费用交纳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GasPaymentForm MyDlg = new GasPaymentForm(this.MyCommunity, this.MyOperator, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 其他费用交纳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherPaymentForm MyDlg = new OtherPaymentForm(this.MyCommunity, this.MyOperator, this.MyCompany, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 业主统计报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportOwnerForm MyDlg = new ReportOwnerForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 投诉统计报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportComplainForm MyDlg = new ReportComplainForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 业主维修报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportOwnerRepairForm MyDlg = new ReportOwnerRepairForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 公共维修报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCommonRepairForm MyDlg = new ReportCommonRepairForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
        private void 收入统计报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportChargeForm MyDlg = new ReportChargeForm(this.MyCommunity, this.MyPrintIcon);
            MyDlg.ShowDialog();
        }
    }
}