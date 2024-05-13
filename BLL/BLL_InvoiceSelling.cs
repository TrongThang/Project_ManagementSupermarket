using DAL;
using DocumentFormat.OpenXml.Wordprocessing;
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
        public DataTable GetInvoiceSelling(string keySearch, string value = null)
        {
            return dataInvoice.GetInvoiceSelling(keySearch, value);
        }
        public DataTable GetInvoiceSellingToEmployee(string idEmployee, string keySearch, string value = null)
        {
            return dataInvoice.GetInvoiceSellingToEmployee(idEmployee, keySearch, value);
        }

        public DataTable GetRevenue(string criteria, int value = 0)
        {

            return (new DAL_InvoiceSelling()).GetRevenue(criteria, value);
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