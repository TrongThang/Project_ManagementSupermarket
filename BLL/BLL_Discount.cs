using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class BLL_Discount
    {
        private DAL_Discount dataDiscount=new DAL_Discount();
        public DataTable GetDiscount(string keySearch, string value = null)
        {
            return dataDiscount.GetDiscount(keySearch, value);
        }
        public DataTable GetDiscountToday()
        {
            return dataDiscount.GetDiscountToday();
        }

        public int InsertDiscount(DTO_Discount discount)
        {
            return dataDiscount.InsertDiscount(discount);
        }
        public int UpdateDiscount(DTO_Discount discount)
        {
            return dataDiscount.UpdateDiscount(discount);
        }
    }
}
