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
