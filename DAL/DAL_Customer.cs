using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class DAL_Customer
    {
        private DP db =new DP();
        private Dictionary<string, dynamic> createDict(DTO_Customer customer)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            if(customer.S_ID != null)
            {
                dict.Add("MaKH", customer.S_ID);
            }
            dict.Add("HoTen", customer.S_FullName);
            dict.Add("CCCD", customer.S_CCCD);
            dict.Add("GioiTinh", customer.S_Gender);
            dict.Add("DiaChi", customer.S_Address);
            dict.Add("SDT", customer.S_Phone);
            dict.Add("NgayDangKy", customer.Dt_CreatedTime);
            dict.Add("TrangThai", customer.S_Status);
            return dict;
        }
        public DataTable GetCustomerTo(String keySearch , string value = null)
        {
            DP db = new DP();
            string sql = "sp_getCustomerTo";
            DataTable tblCustomer = null;
            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch,value);
            tblCustomer = db.queryExecuteAdapter(sql);
            return tblCustomer;
        }
        public DataTable GetCustomerToPhone(string value)
        {
            DP db = new DP();
            string sql = "sp_GetCustomerToPhone";
            DataTable tblCustomer = new DataTable();
            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam("SDT", value);
            tblCustomer = db.queryExecuteAdapter(sql);
            
            return tblCustomer;
        }
        public int  InsertCustomer(DTO_Customer customer)
        {
            string sql = "sp_InsertCustomer";
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            dict = createDict(customer);
            //HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai

            DataTable result = db.queryExecuteAdapter(sql,dict);
            int numOfRows = result.Rows.Count;
            return numOfRows;

        }
        public int UpdateCustomer(DTO_Customer customer)
        {
            DP db = new DP();
            string sql = "sp_UpdateCustomer";
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            dict = createDict(customer);
           
            DataTable result = db.queryExecuteAdapter(sql, dict);
            int numOfRows = result.Rows.Count;
            return numOfRows;
        }
        public int UpdateStatusCustomer(string id)
        {
            DP db = new DP();
            string sql = "sp_UpdateStatusCustomer";
            db.addParam("MaKH", id);

            DataTable result = db.queryExecuteAdapter(sql);
            int numOfRows = result.Rows.Count;
            return numOfRows;
        }
    }
}

