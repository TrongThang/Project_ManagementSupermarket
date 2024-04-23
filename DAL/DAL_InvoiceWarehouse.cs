using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL
{
    public class DAL_InvoiceWarehouse
    {
        private DP db = new DP();
        private Dictionary<string, dynamic> createDict(DTO_InvoiceWarehouse invoice)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            if(invoice.S_IdInvoice != null)
            {
                dict.Add("MaNK",invoice.S_IdInvoice);
            }
            if(invoice.S_IdSupplier != null)
            {
                dict.Add("MaNCC",invoice.S_IdSupplier);
            }
            if (invoice.S_IdEmployee != null)
            {
                dict.Add("MaNV", invoice.S_IdEmployee);
            }
            if (invoice.Dt_CreatedTime != null)
            {
                dict.Add("NgayNhapKho", invoice.Dt_CreatedTime);
            }
            dict.Add("TongTien", invoice.D_TotalPrice);
            return dict;
        }
        public DataTable GetInvoiceImportWareHouse(string keySearch, string value=null)
        {
            string sql = "sp_GetInvoiceImportWareHouse";
            DataTable tblInvoice = null;
            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            tblInvoice = db.queryExecuteAdapter(sql);

            return tblInvoice;

        }
        public DataTable InsertInvoiceImportWareHouse(DTO_InvoiceWarehouse invoice)
        {
            string sql = "sp_InsertInvoiceImportWareHouse";
            DataTable tblInvoice = db.queryExecuteAdapter(sql, createDict(invoice));
            //int numOfRows = tblInvoice.Rows.Count;

            return tblInvoice;
        }
        public int UpdateInvoiceImportWareHouse(DTO_InvoiceWarehouse invoice)
        {
            string sql = "sp_UpdateInvoiceImportWareHouse";
            DataTable tblInvoice = db.queryExecuteAdapter(sql, createDict(invoice));
            int numOfRows = tblInvoice.Rows.Count;

            return numOfRows;

        }
        public int DeleteInvoiceImportWareHouse(string idInvoice)
        {
            string sql = " sp_DeleteInvoiceImportWareHouse";

            db.addParam("MaNK", idInvoice);

            DataTable tblInvoice = db.queryExecuteAdapter(sql);
            int numOfRows = tblInvoice.Rows.Count;

            return numOfRows;
        }

    }
}
