using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCommunity.Common
{
    public static class Helper
    {
        public static string GetCellValue(DataGridViewRow row, string cellName)
        {
            try
            {
                if (row.Cells[cellName] != null && row.Cells[cellName].Value != null)
                {
                    return row.Cells[cellName].Value.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        public static decimal StringToDecimal(string s)
        {
            if (s == "")
                return 0;
            else
                return Convert.ToDecimal(s);
        }

        public static DateTime StringToDate(string s)
        {
            DateTime dt = DateTime.MinValue;
            if (s == "") return DateTime.MinValue;
            try
            {
                dt = Convert.ToDateTime(s);
            }
            catch (Exception ex) { }
            return dt;
        }

        public static void SetDateCtrlValue(Control.ControlCollection controls, string name, string value)
        {
            try
            {
                name = name + "DateTimePicker";
                if (controls.Find(name, false).Count() > 0)
                {
                    ((System.Windows.Forms.DateTimePicker)(controls.Find(name, false)[0])).Value = StringToDate(value);
                }
            }
            catch (Exception ex) { }
        }

        public static void SetTextBoxCtrlValue(Control.ControlCollection controls, string name, string value)
        {
            try
            {
                name = name + "TextBox";
                if (controls.Find(name, false).Count() > 0)
                {
                    ((System.Windows.Forms.TextBox)(controls.Find(name, false)[0])).Text = value;
                }
            }
            catch (Exception ex) { } 
        }

        public static void SetComBoxCtrlValue(Control.ControlCollection controls, string name, string value)
        {
            try
            {
                name = name + "ComboBox";
                if (controls.Find(name, false).Count() > 0)
                {
                    ((System.Windows.Forms.ComboBox)(controls.Find(name, false)[0])).Text = value;
                }
            }
            catch (Exception ex) { }
        }

        public static string GetDateCtrlValue(Control.ControlCollection controls, string name)
        {
            string value = string.Empty;
            try
            {
                name = name + "DateTimePicker";
                if (controls.Find(name, false).Count() > 0)
                {
                    DateTime dt = ((System.Windows.Forms.DateTimePicker)(controls.Find(name, false)[0])).Value;
                    value = dt.ToString("yyyy-MM-dd");
                }
                return value;
            }
            catch (Exception ex)
            {
                return value;
            }
        }

        public static string GetTextBoxCtrlValue(Control.ControlCollection controls, string name)
        {
            string value = string.Empty;
            try
            {
                name = name + "TextBox";
                if (controls.Find(name, false).Count() > 0)
                {
                    value = ((System.Windows.Forms.TextBox)(controls.Find(name, false)[0])).Text;
                }
                return value;
            }
            catch (Exception ex) {
                return value;
            }
        }

        public static string GetComBoxCtrlValue(Control.ControlCollection controls, string name)
        {
            string value = string.Empty;
            try
            {
                name = name + "ComboBox";
                if (controls.Find(name, false).Count() > 0)
                {
                    value = ((System.Windows.Forms.ComboBox)(controls.Find(name, false)[0])).Text;
                }
                return value;
            }
            catch (Exception ex)
            {
                return value;
            }
        }

        public static string Obj2String(Object obj)
        {
            return obj != null ? obj.ToString() : string.Empty;
        }

        public static short Obj2Int(Object obj)
        {
            short value = 0;
            if (obj != null)
            {
                Int16.TryParse(obj.ToString(), out value);
            }
            return value;
        }

        public static double Obj2Double(Object obj)
        {
            double value = 0;
            if (obj != null)
            {
                double.TryParse(obj.ToString(), out value);
            }
            return value;
        }

        public static double String2Double(string str)
        {
            double value = 0;
            double.TryParse(str, out value);
            return value;
        }
    }
}
