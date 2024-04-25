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
    public class BLL_InvoiceWarehouse
    {
        DAL_InvoiceWarehouse dataInvoice = new DAL_InvoiceWarehouse();
        public DataTable GetInvoiceImportWareHouse(string keySearch, string value=null)
        {
            return dataInvoice.GetInvoiceImportWareHouse(keySearch, value);
        }
        public DataTable InsertInvoiceImportWareHouse(DTO_InvoiceWarehouse invoice)
        {
            return dataInvoice.InsertInvoiceImportWareHouse(invoice);
        }
        public int UpdateInvoiceImportWareHouse(DTO_InvoiceWarehouse invoice)
        {
            return dataInvoice.UpdateInvoiceImportWareHouse(invoice);
        }
        public int DeleteInvoiceImportWareHouse(string idInvoice)
        {
            return dataInvoice.DeleteInvoiceImportWareHouse(idInvoice);
        }
    }
}
