using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_InvoiceSelling
    {
        private string s_IdInvoice;
        private string s_IdEmployee;
        private string s_IdCustomer;

        private DateTime dt_CreatedTime = DateTime.Now;

        private double d_TotalPrice;
        private double d_CashCustomer;

        public DTO_InvoiceSelling(string idEmployee, double d_TotalPrice, double d_CashCustomer, string idCustomer = null, string idInvoice = null)
        {
            S_IdInvoice = idInvoice;
            S_IdEmployee = idEmployee;
            S_IdCustomer = idCustomer;
            this.D_TotalPrice = d_TotalPrice;
            this.D_CashCustomer = d_CashCustomer;
        }

        public string S_IdInvoice { get => s_IdInvoice; set => s_IdInvoice = value; }
        public string S_IdEmployee { get => s_IdEmployee; set => s_IdEmployee = value; }
        public string S_IdCustomer { get => s_IdCustomer; set => s_IdCustomer = value; }
        public DateTime Dt_CreatedTime { get => dt_CreatedTime; set => dt_CreatedTime = value; }
        public double D_TotalPrice { get => d_TotalPrice; set => d_TotalPrice = value; }
        public double D_CashCustomer { get => d_CashCustomer; set => d_CashCustomer = value; }
    }
}