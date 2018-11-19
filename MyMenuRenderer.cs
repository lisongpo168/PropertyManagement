using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCommunity.Common
{
    public class MyMenuRenderer : ToolStripProfessionalRenderer
    {
        public MyMenuRenderer() : base(new MyMenuColors()) { }
    }
    public class MyMenuColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(194, 217, 247); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(194, 217, 247); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(194, 217, 247); }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.FromArgb(194, 217, 247); }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(194, 217, 247); }
        }
    }
}
