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

        private object[] obj_IdProduct;
        private double[] d_Discount;
        private int[] i_Count;
        private double[] d_Price;
        private double[] d_Amount;

        private DateTime dt_CreatedTime;
        private double d_TotalPrice;
        private double d_CashCustomer;
        private string s_ChangeCash;


    }
}
