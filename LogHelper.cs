using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCommunity.Common
{
    public static class LogHelper
    {
        private static string LogErrorFilePath
        {
            get {
                    string dirPath = Application.StartupPath + "\\log\\";
                    try
                    {
                        if (!Directory.Exists(dirPath))
                            Directory.CreateDirectory(dirPath);

                    }
                    catch (Exception ex)
                    {
                    }
                    return dirPath + string.Format("{0}_Error.log", DateTime.Now.Date.ToString("yyyyMMdd")); 
                }
        }

        public static void LogError(Exception ex)
        {
            string message = "Error:";
            message += ex.Message + Environment.NewLine + ex.StackTrace;
            if (ex.InnerException != null)
            {
                message += Environment.NewLine + ex.InnerException;
            }
            WriteLog(message, LogErrorFilePath);
        }

        private static void WriteLog(string logMsg, string filePath)
        {
            string timeStamp = DateTime.Now.ToString("HH:mm:ss");
            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(filePath, FileMode.Append), Encoding.UTF8))
                {
                    sw.Write(timeStamp + ": " + logMsg + "\r\n");
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
