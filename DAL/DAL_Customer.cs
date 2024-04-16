using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Customer
    {
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
        public DataTable InsertCustomer(DTO_Customer customer)
        {
            DP db =new DP();
            string sql = "sp_InsertCustomer";

            db.addParam("HoTen", customer.S_FullName);
            db.addParam("CCCD", customer.S_CCCD); 
            db.addParam("GioiTinh", customer.S_Gender);
            db.addParam("DiaChi", customer.S_Address);
            db.addParam("SDT", customer.S_Phone);
            db.addParam("NgayDangKy", customer.Dt_CreatedTime);                    
            db.addParam("TrangThai", customer.S_Status);
            //HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai

            DataTable result =db.queryExecuteAdapter(sql);
            return result;

        }
        public int UpdateCustomer(DTO_Customer customer)
        {
            DP db = new DP();
            string sql = "sp_UpdateCustomer";
            db.addParam("id", customer.S_ID);
            db.addParam("HoTen", customer.S_FullName);
            db.addParam("CCCD", customer.S_CCCD);
            db.addParam("GioiTinh", customer.S_Gender);
            db.addParam("DiaChi", customer.S_Address);
            db.addParam("SDT", customer.S_Phone);
            db.addParam("NgayDangKy", customer.Dt_CreatedTime);
            db.addParam("TrangThai", customer.S_Status);
            int numOfRows = db.queryExecute(sql);
            return numOfRows;
        }
        public int UpdateStatusCustomer(DTO_Customer customer)
        {
            DP db = new DP();
            string sql = "sp_UpdateStatusCustomer";
            db.addParam("id", customer.S_ID);
            int numOfRows = db.queryExecute(sql);
            return numOfRows;
        }
    }
}

