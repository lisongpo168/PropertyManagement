using MyCommunity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCommunity
{
    public partial class SecurityForm : DevComponents.DotNetBar.RibbonForm
    {
        private int nSecs = 9;
        private bool bStartTimer = false;
        public SecurityForm()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void SecurityForm_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(CheckSecurity);
            t.IsBackground = true;
            t.Start();
        }

        private void CheckSecurity()
        {
            string appSecurityId = ConfigurationManager.AppSettings["SecurityId"];
            if (!SecurityHelper.CheckSecurityId(appSecurityId))
            {
                bStartTimer = true;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                bStartTimer = false;
                nSecs = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nSecs == 0 && bStartTimer)
            {
                this.timer1.Stop();
                this.Close();
            }
            if (nSecs > 0 && bStartTimer)
            {
                nSecs--;
                if (nSecs > 0)
                {
                    lblInfo.Text = string.Format("当前用户未获得该软件使用权，请联系软件供应商");
                    lblTip.Text = string.Format("获得正式使用权！窗口将在{0}秒后关闭．．．", nSecs);
                }
            }
        }
    }
}
