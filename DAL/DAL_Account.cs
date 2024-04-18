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
            db.addParam("MaNV", username);
            db.addParam("MatKhau", password);

            DataTable result = db.queryExecuteAdapter("sp_checkAccount");

            return result;
        }

        public bool UpdatePasswordAccount(string username, string password)
        {
            DP db = new DP();
            db.addParam("MaNV", username);
            db.addParam("MatKhau", password);

            DataRow row = db.queryExecuteAdapter("sp_UpdatePasswordAccount").Rows[0];

            bool result = (int)row[0] > 0 ? true : false;
            return result;
        }
    }
}
