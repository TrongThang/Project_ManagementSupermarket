using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_InvoiceWarehouse
    {
        private string s_IdInvoice;
        private string s_IdEmployee;
        private string s_IdSupplier;
        private DateTime dt_CreatedTime;
        private double d_TotalPrice;



        //public DTO_InvoiceWarehouse()
        //{
        //    S_IdInvoice = null;
        //    S_IdEmployee = null;
        //    S_IdSupplier = null;
        //    this.Dt_CreatedTime = DateTime.Now;
        //    this.D_TotalPrice = 0;

        //}

        public DTO_InvoiceWarehouse( string idEmployee, string idSupplier, DateTime dt_CreatedTime, double d_TotalPrice, string idInvoice = null)
        {
            S_IdInvoice = idInvoice;
            S_IdEmployee = idEmployee;
            S_IdSupplier = idSupplier;
            this.Dt_CreatedTime = dt_CreatedTime;
            this.D_TotalPrice = d_TotalPrice;

           
        }

        public string S_IdInvoice { get => s_IdInvoice; set => s_IdInvoice = value; }
        public string S_IdEmployee { get => s_IdEmployee; set => s_IdEmployee = value; }
        public string S_IdSupplier { get => s_IdSupplier; set => s_IdSupplier = value; }
        public DateTime Dt_CreatedTime { get => dt_CreatedTime; set => dt_CreatedTime = value; }
        public double D_TotalPrice { get => d_TotalPrice; set => d_TotalPrice = value; }
     
    }
}
