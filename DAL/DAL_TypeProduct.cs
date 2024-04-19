using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TypeProduct
    {
        private DP db = new DP();

        private Dictionary<string, dynamic> createDict(DTO_TypeProduct typeProduct)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            if (typeProduct.S_id != null)
            {
                dict.Add("MaLoaiSP", typeProduct.S_id);
            }
            dict.Add("TenLoai", typeProduct.S_nameType);
            dict.Add("MoTa", typeProduct.S_desc);
            return dict;
        }
        public DataTable GetTypeProduct(string keySearch, string value = null)
        {
            DP db = new DP();
            string sql = "sp_getTypeProduct";

            DataTable tblTypeProduct = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            tblTypeProduct = db.queryExecuteAdapter(sql);

            return tblTypeProduct;
        }

        public int InsertTypeProduct(DTO_TypeProduct product)
        {
            string sql = "sp_InsertTypeProduct";

            DataTable tblTypeProduct = db.queryExecuteAdapter(sql, createDict(product));
            int numOfRows = tblTypeProduct.Rows.Count;

            return numOfRows;
        }

        public int UpdateTypeProduct(DTO_TypeProduct product)
        {
            DP db = new DP();
            string sql = "sp_UpdateTypeProduct";

            DataTable tblTypeProduct = db.queryExecuteAdapter(sql, createDict(product));
            int numOfRows = tblTypeProduct.Rows.Count;

            return numOfRows;
        }

        public int UpdateStatusTypeProduct(string id)
        {
            DP db = new DP();
            string sql = "sp_UpdateStatusTypeProduct";
            db.addParam("MaLoaiSP", id);

            DataTable tblSupplier = db.queryExecuteAdapter(sql);

            int numOfRows = tblSupplier.Rows.Count;

            return numOfRows;
        }
    }
}
