using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Product
    {

        private string s_FileNameImage;

        private string s_IDProduct;
        private string s_FullNameProduct;

        private string s_IdSupplier;
        private string s_NameSupplier;

        private string s_IdTypeProduct;
        private string s_NameTypeProduct;

        private double d_CostPrice;
        private double d_SellingPrice;

        private int i_Count;

        private string s_ShelfLife;
        private string s_Unit;
        private byte s_Status;

        public DTO_Product()
        {
            S_IDProduct = null;
            S_FullNameProduct = null;
            S_IdSupplier = null;
            S_NameSupplier = null;
            S_IdTypeProduct = null;
            S_NameTypeProduct = null;
            this.D_CostPrice = 0;
            this.D_SellingPrice = 0;
            I_Count = 0;
            S_ShelfLife = null;
            S_Unit = null;
            S_FileNameImage = null;
            S_Status = 0;
        }

        public DTO_Product(string fileNameImage, string fullNameProduct, string idSupplier, string idTypeProduct, double d_CostPrice, double d_SellingPrice, int i_Count, string shelfLife, string unit, byte status, string iDProduct = null)
        {
            S_IDProduct = iDProduct;
            S_FullNameProduct = fullNameProduct;
            S_IdSupplier = idSupplier;
            S_NameSupplier = null;
            S_IdTypeProduct = idTypeProduct;
            S_NameTypeProduct = null;
            this.D_CostPrice = d_CostPrice;
            this.D_SellingPrice = d_SellingPrice;
            this.I_Count = i_Count;
            S_ShelfLife = shelfLife;
            S_Unit = unit;
            S_FileNameImage = fileNameImage;
            S_Status = status;
        }


        public string S_IDProduct { get => s_IDProduct; set => s_IDProduct = value; }
        public string S_FullNameProduct { get => s_FullNameProduct; set => s_FullNameProduct = value; }
        public string S_IdSupplier { get => s_IdSupplier; set => s_IdSupplier = value; }
        public string S_NameSupplier { get => s_NameSupplier; set => s_NameSupplier = value; }
        public string S_IdTypeProduct { get => s_IdTypeProduct; set => s_IdTypeProduct = value; }
        public string S_NameTypeProduct { get => s_NameTypeProduct; set => s_NameTypeProduct = value; }
        public double D_CostPrice { get => d_CostPrice; set => d_CostPrice = value; }
        public double D_SellingPrice { get => d_SellingPrice; set => d_SellingPrice = value; }
        public string S_ShelfLife { get => s_ShelfLife; set => s_ShelfLife = value; }
        public string S_Unit { get => s_Unit; set => s_Unit = value; }
        public string S_FileNameImage { get => s_FileNameImage; set => s_FileNameImage = value; }
        public byte S_Status { get => s_Status; set => s_Status = value; }
        public int I_Count { get => i_Count; set => i_Count = value; }
    }
}