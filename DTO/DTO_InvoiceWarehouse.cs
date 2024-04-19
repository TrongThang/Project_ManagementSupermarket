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

        private object[] obj_IdProduct;
        private DateTime[] dt_ShelfLife;
        private int[] i_Count;
        private double[] d_Price;
        private double[] d_Amount;

        public DTO_InvoiceWarehouse()
        {
            S_IdInvoice = null;
            S_IdEmployee = null;
            S_IdSupplier = null;
            this.Dt_CreatedTime = DateTime.Now;
            this.D_TotalPrice = 0;
            this.Obj_IdProduct = null;
            this.Dt_ShelfLife = null;
            this.I_Count = null;
            this.D_Price = null;
            this.D_Amount = null;
        }

        public DTO_InvoiceWarehouse(string idInvoice, string idEmployee, string idSupplier, DateTime dt_CreatedTime, double d_TotalPrice, object[] obj_IdProduct, DateTime[] dt_ShelfLife, int[] i_Count, double[] d_Price, double[] d_Amount)
        {
            S_IdInvoice = idInvoice;
            S_IdEmployee = idEmployee;
            S_IdSupplier = idSupplier;
            this.Dt_CreatedTime = dt_CreatedTime;
            this.D_TotalPrice = d_TotalPrice;
            this.Obj_IdProduct = obj_IdProduct;
            this.Dt_ShelfLife = dt_ShelfLife;
            this.I_Count = i_Count;
            this.D_Price = d_Price;
            this.D_Amount = d_Amount;
        }

        public string S_IdInvoice { get => s_IdInvoice; set => s_IdInvoice = value; }
        public string S_IdEmployee { get => s_IdEmployee; set => s_IdEmployee = value; }
        public string S_IdSupplier { get => s_IdSupplier; set => s_IdSupplier = value; }
        public DateTime Dt_CreatedTime { get => dt_CreatedTime; set => dt_CreatedTime = value; }
        public double D_TotalPrice { get => d_TotalPrice; set => d_TotalPrice = value; }
        public object[] Obj_IdProduct { get => obj_IdProduct; set => obj_IdProduct = value; }
        public DateTime[] Dt_ShelfLife { get => dt_ShelfLife; set => dt_ShelfLife = value; }
        public int[] I_Count { get => i_Count; set => i_Count = value; }
        public double[] D_Price { get => d_Price; set => d_Price = value; }
        public double[] D_Amount { get => d_Amount; set => d_Amount = value; }
    }
}
