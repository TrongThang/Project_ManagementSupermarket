using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Account
    {
        DAL_Account dataAccount = new DAL_Account();
        public DataTable GetAccount(string keySearch = null, string value = null, bool? status = null)
        {
            return dataAccount.GetAccount(keySearch, value, status);
        }
        public int UpdateStatusAccount(string username, bool status)
        {
            return dataAccount.UpdateStatusAccount(username, status);
        }
        public DataTable IsAccount(string username, string password)
        {
            return dataAccount.IsAccount(username, password);
        }

        public bool UpdatePasswordAccount(string username, string password)
        {
           return dataAccount.UpdatePasswordAccount(username, password);
        }
    }
}
