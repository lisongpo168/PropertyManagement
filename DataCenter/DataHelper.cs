using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCommunity
{
    public class DataHelper
    {
        public static DataTable GetDataTable(string query)
        {
            String conStr = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(conStr))
            { 
                conn.Open(); 
                using (MySqlCommand cmd = conn.CreateCommand()) 
                { 
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query; 
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd); 
                    sda.Fill(dt); 
                } 
            } 
            return dt;
        }

        public static void CommitUpdate()
        {
            UpdateOrDeleteRecord("commit");
        }

        public static int UpdateOrDeleteRecord(string query)
        {
            int nRet = 0;
            String conStr = global::MyCommunity.Properties.Settings.Default.DBCommunityConnectionString;
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(conStr))
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    nRet = cmd.ExecuteNonQuery();
                }
            }
            return nRet;
        }
    }
}
