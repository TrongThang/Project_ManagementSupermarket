using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Product
    {
        private DP db = new DP();
        private Dictionary<string, dynamic> createDict(DTO_Product product)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            if (product.S_IDProduct != null)
            {
                dict.Add("MaSP", product.S_IDProduct);
            }
            dict.Add("HinhAnh", product.S_FileNameImage);

            dict.Add("TenSP", product.S_FullNameProduct);
            dict.Add("MaNCC", product.S_IdSupplier);
            dict.Add("MaLoaiSP", product.S_IdTypeProduct);
            dict.Add("GiaNhap", product.D_CostPrice);
            dict.Add("GiaBan", product.D_SellingPrice);
            dict.Add("SoLuong", product.I_Count);
            dict.Add("HanSuDung", product.S_ShelfLife);
            dict.Add("DonViTinh", product.S_Unit);
            dict.Add("TrangThai", product.S_Status);
            return dict;
        }
        public DataTable GetProduct(string keySearch, string value = null, bool? status = null)
        {
            string sql = "sp_getProduct";
            DataTable tblProduct = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            if(status != null)
            {
                db.addParam("TrangThai", status);
            }
            tblProduct = db.queryExecuteAdapter(sql);

            return tblProduct;
        }

        public int InsertProduct(DTO_Product product)
        {
            string sql = "sp_InsertProduct";
            DataTable tblProduct = db.queryExecuteAdapter(sql, createDict(product));
            int numOfRows = tblProduct.Rows.Count;

            return numOfRows;
        }

        public int UpdateProduct(DTO_Product product)
        {
            string sql = "sp_UpdateProduct";
            DataTable tblProduct = db.queryExecuteAdapter(sql, createDict(product));
            int numOfRows = tblProduct.Rows.Count;

            return numOfRows;
        }

        public int UpdateStatusProduct(string id)
        {
            string sql = "sp_UpdateStatusProduct";
            db.addParam("MaSP", id);

            DataTable tblProduct = db.queryExecuteAdapter(sql);

            int numOfRows = tblProduct.Rows.Count;

            return numOfRows;
        }
    }
}