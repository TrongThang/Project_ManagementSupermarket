using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Role
    {
        private DAL_Role dataRole = new DAL_Role();
        public DataTable GetRole(string keySearch, string value = null)
        {
            return dataRole.GetRole(keySearch, value);
        }
    }
}
