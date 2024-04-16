using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Product
    {
        private string s_IDProduct;
        private string s_FullNameProduct;

        private string s_IdSupplier;
        private string s_NameSupplier;

        private string s_IdTypeProduct;
        private string s_NameTypeProduct;

        private double d_CostPrice;
        private double d_SellingPrice;

        private string s_ShelfLife;
        private string s_Unit;
        private string s_FileNameImage;
        private byte s_Status;

        public DTO_Product()
        {
            s_IDProduct = null;
            s_FullNameProduct = null;
            s_IdSupplier = null;
            s_NameSupplier = null;
            s_IdTypeProduct = null;
            s_NameTypeProduct = null;
            this.d_CostPrice = 0;
            this.d_SellingPrice = 0;
            s_ShelfLife = null;
            s_Unit = null;
            s_FileNameImage = null;
            s_Status = 0;
        }

        public DTO_Product(string iDProduct, string fullNameProduct, string idSupplier, string idTypeProduct, double d_CostPrice, double d_SellingPrice, string shelfLife, string unit, string fileNameImage, byte status)
        {
            s_IDProduct = iDProduct;
            s_FullNameProduct = fullNameProduct;
            s_IdSupplier = idSupplier;
            s_NameSupplier = null;
            s_IdTypeProduct = idTypeProduct;
            s_NameTypeProduct = null;
            this.d_CostPrice = d_CostPrice;
            this.d_SellingPrice = d_SellingPrice;
            s_ShelfLife = shelfLife;
            s_Unit = unit;
            s_FileNameImage = fileNameImage;
            s_Status = status;
        }
    }
}
