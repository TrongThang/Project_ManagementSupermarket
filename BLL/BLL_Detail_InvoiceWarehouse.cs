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
    public  class BLL_Detail_InvoiceWarehouse
    {
        DAL_Detail_InvoiceWarehouse dataDetailInvoice = new DAL_Detail_InvoiceWarehouse();
        public DataTable GetDetailInvoiceImportWareHouse(string keySearch, string value)
        {
            return dataDetailInvoice.GetDetailInvoiceImportWareHouse(keySearch, value);
        }
        public int InsertDetailInvoiceImportWareHouse(DTO_Detail_InvoiceWarehouse invoice)
        {
            return dataDetailInvoice.InsertDetailInvoiceImportWareHouse(invoice);
        }
        public int UpdateDetailInvoiceImportWareHouse(DTO_Detail_InvoiceWarehouse invoice)
        {
            return dataDetailInvoice.UpdateDetailInvoiceImportWareHouse(invoice);
        }
        public int DeleteDetailInvoiceImportWareHouse(string idInvoice, string idProduct = null)
        {
            return dataDetailInvoice.DeleteDetailInvoiceImportWareHouse(idInvoice,idProduct);
        }
    }
}
