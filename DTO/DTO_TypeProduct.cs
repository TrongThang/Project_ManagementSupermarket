using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TypeProduct
    {
        private string s_id;
        private string s_nameType;
        private string s_desc;

        public DTO_TypeProduct()
        {
            this.S_id = null;
            this.S_nameType = null;
            this.S_desc = null;
        }
        public DTO_TypeProduct( string nameType, string desc, string id=null)
        {
            this.S_id = id;
            this.S_nameType = nameType;
            this.S_desc = desc;
        }

        public string S_id { get => s_id; set => s_id = value; }
        public string S_nameType { get => s_nameType; set => s_nameType = value; }
        public string S_desc { get => s_desc; set => s_desc = value; }
    }
}
