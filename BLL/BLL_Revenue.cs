using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Revenue
    {
        public static DataTable GetRevenue(DateTime date, string criteria = null)
        {
            return DAL_Revenue.GetRevenue(date, criteria);
        }
    }
}
