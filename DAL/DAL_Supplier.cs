using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Supplier
    {
        private DP db = new DP();
        public DataTable GetSupplier(string keySearch, string value = null)
        {
            DP db = new DP();
            string sql = "sp_getSupplier";
            DataTable tblSupplier = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            tblSupplier = db.queryExecuteAdapter(sql);

            return tblSupplier;
        }
    }
}
