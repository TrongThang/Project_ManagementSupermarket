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
   public class BLL_Customer
    {
        private DAL_Customer dataCustomer = new DAL_Customer();
        public DataTable GetCustomerTo(string keySearch, string value= null)
        {
            return dataCustomer.GetCustomerTo(keySearch, value);
        }
        public int InsertCustomer(DTO_Customer customer)
        {
            return dataCustomer.InsertCustomer(customer);
        }
        public int UpdateCustomer(DTO_Customer customer)
        {
           return dataCustomer.UpdateCustomer(customer);
        }
        //DELETE EMPLOYEE, BUT ACTUALLY IS UPDATE STATUS FROM 1 TO 0
        public int UpdateStatusCustomer(DTO_Customer customer)
        {
           return dataCustomer.UpdateStatusCustomer(customer);
        }
    }
    
}
