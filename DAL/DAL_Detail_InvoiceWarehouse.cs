using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Detail_InvoiceWarehouse
    {
        private DP db = new DP();
        private Dictionary<string, dynamic> createDict(DTO_Detail_InvoiceWarehouse invoice)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            dict.Add("MaNK", invoice.S_IdInvoice);
            dict.Add("MaSP", invoice.S_IdProduct);
            
            dict.Add("SoLuong", invoice.I_Count);
            dict.Add("DonGiaNhap", invoice.D_Price);
            
            return dict;
        }
        public DataTable GetDetailInvoiceImportWareHouse(string keySearch, string value)
        {
            string sql = "sp_GetDetailInvoiceImportWareHouse";
            DataTable tblInvoice = null;
            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            tblInvoice = db.queryExecuteAdapter(sql);

            return tblInvoice;
        }
        public int DeleteProductExpire(string idImport, string idProduct)
        {
            string sql = "sp_DeleteProductExpire";
            DataTable tblInvoice = null;

            db.addParam("MaNK", idImport);
            db.addParam("MaSP", idProduct);
            tblInvoice = db.queryExecuteAdapter(sql);

            return tblInvoice.Rows.Count;
        }
        public int InsertDetailInvoiceImportWareHouse(DTO_Detail_InvoiceWarehouse invoice)
        {
            string sql = "sp_InsertDetailInvoiceImportWareHouse";
            DataTable tblInvoice = db.queryExecuteAdapter(sql, createDict(invoice));
            int numOfRows = tblInvoice.Rows.Count;

            return numOfRows;
        }
        public int UpdateDetailInvoiceImportWareHouse(DTO_Detail_InvoiceWarehouse invoice)
        {
            string sql = "sp_UpdateDetailInvoiceImportWareHouse";
            DataTable tblInvoice = db.queryExecuteAdapter(sql, createDict(invoice));
            int numOfRows = tblInvoice.Rows.Count;

            return numOfRows;

        }
        public int DeleteDetailInvoiceImportWareHouse(string idInvoice, string idProduct=null)
        {
            string sql = " sp_DeleteInvoiceImportWareHouse";

            db.addParam("MaNK", idInvoice);
            if(idProduct != null)
            {
                db.addParam("MaSP", idProduct);
            }

            DataTable tblInvoice = db.queryExecuteAdapter(sql);
            int numOfRows = tblInvoice.Rows.Count;

            return numOfRows;
        }
    }
}
