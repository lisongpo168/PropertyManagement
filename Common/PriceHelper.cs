using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyCommunity.Common
{
    public static class PriceHelper
    {
        public static PriceInfo GetPriceInfo()
        {
            PriceInfo princeInfo = new PriceInfo();
            try
            {
                DataTable dt = DataHelper.GetDataTable("select * from 费用价格");
                foreach (DataRow dRow in dt.Rows)
                {
                    string type = Helper.Obj2String(dRow["费用类型"]);
                    double value = Helper.Obj2Double(dRow["费用价格"]);
                    value = Math.Round(value, 3);
                    if (type == "标准电费价格")
                        princeInfo.d_标准电费价格 = value;
                    if (type == "公共照明价格")
                        princeInfo.d_公共照明价格 = value;
                    if (type == "电力损耗价格")
                        princeInfo.d_电力损耗价格 = value;
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
            }
            return princeInfo;
        }

        public static void SetPriceInfo(PriceInfo princeInfo)
        {
            DataHelper.UpdateOrDeleteRecord("delete from 费用价格");
            string query1 = string.Format("insert into 费用价格(`费用类型`, `费用价格`)values('{0}',{1})", "标准电费价格", princeInfo.d_标准电费价格);
            DataHelper.UpdateOrDeleteRecord(query1);
            string query2 = string.Format("insert into 费用价格(`费用类型`, `费用价格`)values('{0}',{1})", "公共照明价格", princeInfo.d_公共照明价格);
            DataHelper.UpdateOrDeleteRecord(query2);
            string query3 = string.Format("insert into 费用价格(`费用类型`, `费用价格`)values('{0}',{1})", "电力损耗价格", princeInfo.d_电力损耗价格);
            DataHelper.UpdateOrDeleteRecord(query3);
        }

        public static double GetPrice(string feeType)
        {
            double feePrice = 0;
            PriceInfo priceInfo = PriceHelper.GetPriceInfo();
            switch(feeType)
            {
                case "电费":
                    feePrice = priceInfo.d_标准电费价格 + priceInfo.d_公共照明价格 + priceInfo.d_电力损耗价格;
                    break;
            }
            
            return feePrice;
        }
    }

    public class PriceInfo
    {
        public double d_标准电费价格 { set; get; }
        public double d_公共照明价格 { set; get; }
        public double d_电力损耗价格 { set; get; }
    }

    public class OwnerInfo
    {
        public string v_业主编号 { set; get; }
        public string v_业主姓名 { set; get; }
        public double d_物业费用 { set; get; }
        public double d_预存金额 { set; get; }
        public string v_楼栋名称 { set; get; }
        public string v_联系电话 { set; get; }
    }

    public class ReciptInfo
    {
        public string v_收据编号 { set; get; }
        public DateTime v_收款日期 { set; get; }
        public string v_业主姓名 { set; get; }
        public double d_应收金额 { set; get; }
        public double d_实收金额 { set; get; }
        public string v_补充说明 { set; get; }
    }
}
