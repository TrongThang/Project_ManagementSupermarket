﻿using DAL;
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
    }
}
