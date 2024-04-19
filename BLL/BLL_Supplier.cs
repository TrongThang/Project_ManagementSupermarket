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
    public class BLL_Supplier
    {
        private DAL_Supplier dataSupplier = new DAL_Supplier();
        public DataTable GetSupplier(string keySearch, string value = null)
        {
            return dataSupplier.GetSupplier(keySearch, value);
        }
        public int InsertSupplier(DTO_Supplier supplier)
        {
            return dataSupplier.InsertSupplier(supplier);
        }
        public int UpdateSupplier(DTO_Supplier supplier) {  return dataSupplier.UpdateSupplier(supplier); }
        public int UpdateStatusSupplier(string idSupplier) { return dataSupplier.UpdateStatusSupplier(idSupplier); }
    }
}
