using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
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
            DateTime dt = DateTime.Now.Date;
            if (s == "") return dt;
            try
            {
                dt = Convert.ToDateTime(s);
            }
            catch (Exception ex) 
            {
                LogHelper.LogError(ex);
            }
            return dt;
        }

        public static void SetDateCtrlValue(Control.ControlCollection controls, string name, string value)
        {
            try
            {
                name = name + "DateTimePicker";
                if (controls.Find(name, false).Count() > 0)
                {
                    ((DevComponents.Editors.DateTimeAdv.DateTimeInput)(controls.Find(name, false)[0])).Value = StringToDate(value);
                }
            }
            catch (Exception ex) {
                LogHelper.LogError(ex);
            }
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
            catch (Exception ex) {
                LogHelper.LogError(ex);
            } 
        }

        public static void SetComBoxCtrlValue(Control.ControlCollection controls, string name, string value)
        {
            try
            {
                name = name + "ComboBox";
                if (controls.Find(name, false).Count() > 0)
                {
                    ((DevComponents.DotNetBar.Controls.ComboBoxEx)(controls.Find(name, false)[0])).Text = value;
                }
            }
            catch (Exception ex) {
                LogHelper.LogError(ex);
            }
        }

        public static void SetCheckBoxCtrlValue(Control.ControlCollection controls, string name, string value)
        {
            try
            {
                name = name + "CheckBox";
                if (controls.Find(name, false).Count() > 0)
                {
                    if(value.StartsWith("1"))
                        ((System.Windows.Forms.CheckBox)(controls.Find(name, false)[0])).Checked = true;
                    else
                        ((System.Windows.Forms.CheckBox)(controls.Find(name, false)[0])).Checked = false;
                }
            }
            catch (Exception ex) {
                LogHelper.LogError(ex);
            }
        }

        public static string GetDateCtrlValue(Control.ControlCollection controls, string name)
        {
            string value = string.Empty;
            try
            {
                name = name + "DateTimePicker";
                if (controls.Find(name, false).Count() > 0)
                {
                    DateTime dt = ((DevComponents.Editors.DateTimeAdv.DateTimeInput)(controls.Find(name, false)[0])).Value;
                    value = dt.ToString("yyyy-MM-dd");
                }
                return value;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
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
                LogHelper.LogError(ex);
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
                    value = ((DevComponents.DotNetBar.Controls.ComboBoxEx)(controls.Find(name, false)[0])).Text;
                }
                return value;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
                return value;
            }
        }

        public static string GetCheckBoxCtrlValue(Control.ControlCollection controls, string name)
        {
            string value = string.Empty;
            try
            {
                name = name + "CheckBox";
                if (controls.Find(name, false).Count() > 0)
                {
                    bool bCheck = ((System.Windows.Forms.CheckBox)(controls.Find(name, false)[0])).Checked;
                    value = bCheck ? "1" : "0";
                }
                return value;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
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

        public static DateTime Obj2Date(Object obj)
        {
            DateTime value = DateTime.Now.Date;
            if (obj != null)
            {
                DateTime.TryParse(obj.ToString(), out value);
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

        public static string EncodePassword(string text)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(text);
                using (var memoryStream = new MemoryStream())
                {
                    using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
                    {
                        gZipStream.Write(buffer, 0, buffer.Length);
                    }
                    memoryStream.Position = 0;
                    var compressedData = new byte[memoryStream.Length];
                    memoryStream.Read(compressedData, 0, compressedData.Length);

                    var gZipBuffer = new byte[compressedData.Length + 4];
                    Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
                    Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
                    return Convert.ToBase64String(gZipBuffer);
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
                return string.Empty;
            }
        }

        /// <summary>
        /// Decompresses the string.
        /// </summary>
        /// <param name="compressedText">The compressed text.</param>
        /// <returns></returns>
        public static string DecodePassword(string compressedText)
        {
            try
            {
                byte[] gZipBuffer = Convert.FromBase64String(compressedText);
                using (var memoryStream = new MemoryStream())
                {
                    int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                    memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

                    var buffer = new byte[dataLength];
                    memoryStream.Position = 0;
                    using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                    {
                        gZipStream.Read(buffer, 0, buffer.Length);
                    }
                    return Encoding.UTF8.GetString(buffer);
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
                return string.Empty;
            }
        }
    }
}
