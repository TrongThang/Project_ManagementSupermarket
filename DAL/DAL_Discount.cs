using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Discount
    {
        private DP db = new DP();
        private Dictionary<string, dynamic> createDict(DTO_Discount discount)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            if (discount.S_ID != null)
            {
                dict.Add("MaKM", discount.S_ID);
            }
            dict.Add("TenKM", discount.S_NameDiscount);
            dict.Add("GiaKhuyenMai", discount.S_DiscountPrice);
            dict.Add("NgayBatDau", discount.Dt_StartDay);
            dict.Add("NgayKetThuc", discount.Dt_EndDay);
            return dict;
        }
        public DataTable GetDiscount(string keySearch, string value = null)
        {
            string sql = "sp_getDiscount";
            DataTable tblDiscount = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            tblDiscount = db.queryExecuteAdapter(sql);
            return tblDiscount;
        }
        public DataTable GetDiscountToday()
        {
            string sql = "sp_getDiscountToDay";
            DataTable tblDiscount = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            
            tblDiscount = db.queryExecuteAdapter(sql);
            return tblDiscount;

           
        }
        public int InsertDiscount(DTO_Discount discount)
        {
            string sql = "sp_InsertDiscount";
            DataTable tblDiscount=db.queryExecuteAdapter(sql,createDict(discount));
            int numOfRows =tblDiscount.Rows.Count;
            return numOfRows;
        }
        public int UpdateDiscount(DTO_Discount discount)
        {
            string sql = "sp_UpdateDiscount";
            DataTable tblDiscount = db.queryExecuteAdapter(sql, createDict(discount));
            int numOfRows = tblDiscount.Rows.Count;
            return numOfRows;
        }
       
    }
}
