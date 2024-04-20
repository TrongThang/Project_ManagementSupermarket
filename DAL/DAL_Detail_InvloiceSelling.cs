using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Detail_InvloiceSelling
    {
        private DP db = new DP();

        private Dictionary<string, dynamic> createDict(DTO_Detail_InvoiceSelling invoice)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            dict.Add("MaHD", invoice.S_IdInvoice);
            dict.Add("MaSP", invoice.S_IdProduct);
            dict.Add("MaKM", invoice.S_Discount);

            dict.Add("SoLuong", invoice.I_Count);
            dict.Add("DonGia", invoice.D_Price);

            return dict;
        }

        public DataTable GetDetailInvoiceSelling(string keySearch, string value)
        {
            string sql = "sp_GetDetailInvoiceSelling";

            DataTable tblInvoice = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            tblInvoice = db.queryExecuteAdapter(sql);

            return tblInvoice;
        }

        public int InsertDetailInvoiceSelling(DTO_Detail_InvoiceSelling invoice)
        {
            string sql = "sp_InsertDetailInvoiceSelling";
            DataTable tblInvoice = db.queryExecuteAdapter(sql, createDict(invoice));
            int numOfRows = tblInvoice.Rows.Count;

            return numOfRows;
        }
        public int UpdateDetailInvoiceSelling(DTO_Detail_InvoiceSelling invoice)
        {
            string sql = "sp_UpdateDetailInvoiceSelling";
            DataTable tblInvoice = db.queryExecuteAdapter(sql, createDict(invoice));
            int numOfRows = tblInvoice.Rows.Count;

            return numOfRows;
        }

        public int DeleteDetailInvoiceSelling(string idInvoice, string idProduct = null)
        {
            string sql = "sp_DeleteDetailInvoiceSelling";

            db.addParam("MaHD", idInvoice);
            if (idProduct != null)
            {
                db.addParam("MaSP", idProduct);
            }

            DataTable tblInvoice = db.queryExecuteAdapter(sql);
            int numOfRows = tblInvoice.Rows.Count;

            return numOfRows;
        }
    }
}