using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_InvoiceSelling
    {
        DAL_InvoiceSelling dataInvoice = new DAL_InvoiceSelling();
        public DataTable GetInvoiceSelling(string keySearch, string value)
        {
            return dataInvoice.GetInvoiceSelling(keySearch, value);
        }

        public DataTable InsertInvoiceSelling(DTO_InvoiceSelling invoice)
        {
            return dataInvoice.InsertInvoiceSelling(invoice);
        }

        public int UpdateInvoiceSelling(DTO_InvoiceSelling invoice)
        {
            return dataInvoice.UpdateInvoiceSelling(invoice);
        }

        public int DeleteInvoiceSelling(string idInvoice)
        {
            return dataInvoice.DeleteInvoiceSelling(idInvoice);
        }
    }
}