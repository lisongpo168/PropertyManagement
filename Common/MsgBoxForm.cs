using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCommunity.Common
{
    public partial class MsgBoxForm : Form
    {
        public MsgBoxForm(string title, string msg)
        {
            InitializeComponent();
            this.btnOK.Visible = true;
            this.btnCancel.Visible = false;
            this.txtMsg.Text = msg;
            this.Text = title;
        }

        public MsgBoxForm(string title, string msg, bool option)
        {
            InitializeComponent();
            this.btnOK.Visible = true;
            this.btnCancel.Visible = true;
            this.txtMsg.Text = msg;
            this.Text = title;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
