using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
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

        public static void PrintGridView(System.Data.DataTable dtData, string title)
        {
            try
            {
                ApplicationClass MyExcel;
                Workbooks MyWorkBooks;
                Workbook MyWorkBook;
                Worksheet MyWorkSheet;
                char MyColumns;
                Range MyRange;
                Object[,] MyData = new Object[500, 35];
                int i, j;
                MyExcel = new ApplicationClass();
                MyExcel.Visible = true;
                if (MyExcel == null)
                {
                    new MsgBoxForm("提示", "Excel程序无法启动！").ShowDialog();
                    return;
                }
                MyWorkBooks = MyExcel.Workbooks;
                MyWorkBook = MyWorkBooks.Add(Missing.Value);
                MyWorkSheet = (Worksheet)MyWorkBook.Worksheets[1];
                MyColumns = (char)(dtData.Columns.Count + 64);
                MyRange = MyWorkSheet.get_Range("A5", MyColumns.ToString() + "5");
                int Count = 0;
                for (int m = 0; m < dtData.Columns.Count; m++)
                {
                    MyData[0, Count] = dtData.Columns[m].ColumnName;
                    Count = Count + 1;
                }
                j = 1;
                //输出数据库记录
                foreach (System.Data.DataRow MyRow in dtData.Rows)
                {
                    for (i = 0; i < dtData.Columns.Count; i++)
                    {
                        MyData[j, i] = MyRow[i].ToString();
                    }
                    j++;
                }
                MyRange = MyRange.get_Resize(dtData.Rows.Count + 1, dtData.Columns.Count);
                MyRange.Borders.LineStyle = 1;
                MyRange.Value2 = MyData;
                MyRange.EntireColumn.AutoFit();
                MyWorkSheet.Cells[2, 2] = title;
                Range MyRange22 = MyWorkSheet.get_Range("B2", "B2");
                MyRange22.Font.Bold = true;
                MyRange22.Font.Size = "20";
                MyWorkSheet.Cells[4, 1] = "打印时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                MyWorkSheet.PageSetup.LeftMargin = 0.1;
                MyWorkSheet.PageSetup.RightMargin = 0.1;
                MyWorkSheet.PageSetup.Zoom = false;
                MyWorkSheet.PageSetup.FitToPagesWide = 1;
                MyWorkSheet.PageSetup.FitToPagesTall = false;
                MyWorkSheet.PrintPreview();
                MyExcel.Quit();
            }
            catch (Exception ex)
            { }
        }
    }
}
