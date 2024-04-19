using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Supplier
    {
        private DP db = new DP();
        private Dictionary<string, dynamic> createDict(DTO_Supplier supplier)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            if (supplier.S_ID != null)
            {
                dict.Add("MaNCC", supplier.S_ID);
            }
            dict.Add("TenNCC", supplier.S_FullName);
            dict.Add("SDT", supplier.S_Phone);
            dict.Add("DiaChi", supplier.S_Address);
            dict.Add("TrangThai", supplier.S_Status);
            return dict;
        }
        public DataTable GetSupplier(string keySearch, string value = null)
        {
            string sql = "sp_getSupplier";
            DataTable tblSupplier = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            tblSupplier = db.queryExecuteAdapter(sql);

            return tblSupplier;
        }

        public int InsertSupplier(DTO_Supplier supplier)
        {
            string sql = "sp_InsertSupplier";
            DataTable tblSupplier = db.queryExecuteAdapter(sql, createDict(supplier));
            int numOfRows = tblSupplier.Rows.Count;

            return numOfRows;
        }

        public int UpdateSupplier(DTO_Supplier supplier) {
            string sql = "sp_UpdateSupplier";
            DataTable tblSupplier = db.queryExecuteAdapter(sql, createDict(supplier));
            int numOfRows = tblSupplier.Rows.Count;

            return numOfRows;
        }

        public int UpdateStatusSupplier(string id)
        {
            string sql = "sp_UpdateStatusSupplier";
            db.addParam("MaNCC", id);

            DataTable tblSupplier = db.queryExecuteAdapter(sql);

            int numOfRows = tblSupplier.Rows.Count;

            return numOfRows;
        }
    }
}
