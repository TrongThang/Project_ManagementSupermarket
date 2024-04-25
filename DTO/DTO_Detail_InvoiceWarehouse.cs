using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Detail_InvoiceWarehouse
    {
        private string s_IdInvoice;
        private string s_IdProduct;
        
        private int i_Count;
        private double d_Price;

        public DTO_Detail_InvoiceWarehouse(string idInvoice , string idProduct, int i_Count, double d_Price)
        {
            s_IdInvoice = idInvoice;
            s_IdProduct = idProduct;
            
            this.i_Count = i_Count;
            this.d_Price = d_Price;
        }

        public string S_IdInvoice { get => s_IdInvoice; set => s_IdInvoice = value; }
        public string S_IdProduct { get => s_IdProduct; set => s_IdProduct = value; }
        
        public int I_Count { get => i_Count; set => i_Count = value; }
        public double D_Price { get => d_Price; set => d_Price = value; }
    }
}
