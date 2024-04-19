using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_TypeProduct
    {
        public DAL_TypeProduct dataTypeProduct = new DAL_TypeProduct();
        public DataTable GetTypeProduct(string keySearch, string value = null)
        {
            return dataTypeProduct.GetTypeProduct(keySearch, value);
        }

        public int InsertTypeProduct(DTO_TypeProduct product)
        {
            return dataTypeProduct.InsertTypeProduct(product);
        }

        public int UpdateTypeProduct(DTO_TypeProduct product)
        {
            return dataTypeProduct.UpdateTypeProduct(product);
        }

        public int UpdateStatusTypeProduct(string id)
        {
            return dataTypeProduct.UpdateStatusTypeProduct(id);
        }
    }
}
