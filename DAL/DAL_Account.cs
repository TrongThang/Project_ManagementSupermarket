using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account
    {
        public DataTable IsAccount(string username, string password)
        {
            DP db = new DP();
            db.addParam("username", username);
            db.addParam("password", password);

            DataTable result = db.queryExecuteAdapter("sp_checkAccount");

            return result;
        }
    }
}
