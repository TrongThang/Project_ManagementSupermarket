﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL
{
    public class DAL_InvoiceSelling
    {
        private DP db = new DP();

        private Dictionary<string, dynamic> createDict(DTO_InvoiceSelling invoice)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            if (invoice.S_IdEmployee != null)
            {
                dict.Add("MaNV", invoice.S_IdEmployee);
            }

            if (invoice.S_IdInvoice != null)
            {
                dict.Add("MaHD", invoice.S_IdInvoice);
            }
            if (invoice.S_IdCustomer != null)
            {
                dict.Add("MaKH", invoice.S_IdCustomer);
            }

            if(invoice.Dt_CreatedTime == null)
            {
                dict.Add("NgayLapHD", invoice.Dt_CreatedTime);
            }
            dict.Add("TongTien", invoice.D_TotalPrice);
            dict.Add("TienKhachDua", invoice.D_CashCustomer);
            return dict;
        }

        public DataTable GetInvoiceSelling(string keySearch, string value = null)
        {
            string sql = "sp_GetInvoiceSelling";

            DataTable tblInvoice = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            tblInvoice = db.queryExecuteAdapter(sql);

            return tblInvoice;
        }

        public DataTable InsertInvoiceSelling(DTO_InvoiceSelling invoice)
        {
            string sql = "sp_InsertInvoiceSelling";
            DataTable tblInvoice = db.queryExecuteAdapter(sql, createDict(invoice));

            
            return tblInvoice;
        }

        public int UpdateInvoiceSelling(DTO_InvoiceSelling invoice)
        {
            string sql = "sp_UpdateInvoiceSelling";
            DataTable tblInvoice = db.queryExecuteAdapter(sql, createDict(invoice));
            int numOfRows = tblInvoice.Rows.Count;

            return numOfRows;
        }
<<<<<<< HEAD

        public int DeleteInvoiceSelling(string idInvoice)
        {   
            string sql = "sp_UpdateInvoiceSelling";

            db.addParam("MaHD", idInvoice);

            DataTable tblInvoice = db.queryExecuteAdapter(sql);
            int numOfRows = tblInvoice.Rows.Count;

            return numOfRows;
        }
=======
>>>>>>> origin/Quan_Warehouse
    }
}