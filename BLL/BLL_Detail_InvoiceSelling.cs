using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Detail_InvoiceSelling
    {
        private DAL_Detail_InvloiceSelling dataDetailInvoice = new DAL_Detail_InvloiceSelling();
        public DataTable GetDetailInvoiceSelling(string keySearch, string value)
        {
            return dataDetailInvoice.GetDetailInvoiceSelling(keySearch, value);
        }

        public int InsertDetailInvoiceSelling(DTO_Detail_InvoiceSelling invoice)
        {
            return dataDetailInvoice.InsertDetailInvoiceSelling(invoice);
        }
        public int UpdateDetailInvoiceSelling(DTO_Detail_InvoiceSelling invoice)
        {
            return dataDetailInvoice.UpdateDetailInvoiceSelling(invoice);
        }

        public int DeleteDetailInvoiceSelling(string idInvoice, string idProduct = null)
        {
            return dataDetailInvoice.DeleteDetailInvoiceSelling(idInvoice, idProduct);
        }
    }
}