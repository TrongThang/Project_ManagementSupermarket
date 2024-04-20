using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class DTO_Discount
    {
        private string s_ID;
        private string s_NameDiscount;
        private double d_DiscountPrice;
        private DateTime dt_StartDay;
        private DateTime dt_EndDay;

        public DTO_Discount()
        {
            s_ID = null;
            s_NameDiscount = null;
            d_DiscountPrice = 0;
            this.dt_StartDay = DateTime.Now;
            this.dt_EndDay = DateTime.Now;

        }
        public DTO_Discount(string id, string nameDiscount, double discountPrice, DateTime dt_startDay, DateTime dt_endDay)
        {
            s_ID = id;
            s_NameDiscount = nameDiscount;
            d_DiscountPrice = discountPrice;
            this.dt_StartDay = dt_startDay;
            this.dt_EndDay = dt_endDay;

            
        }

        public string S_ID { get => s_ID; set => s_ID = value; }
        public string S_NameDiscount { get => s_NameDiscount; set => s_NameDiscount = value; }
        public double S_DiscountPrice { get => d_DiscountPrice; set => d_DiscountPrice = value; }
        public DateTime Dt_StartDay { get => dt_StartDay; set => dt_StartDay = value; }
        public DateTime Dt_EndDay { get => dt_EndDay; set => dt_EndDay = value; }
    }
}
