using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DTO
{
    public class DTO_Supplier
    {
        private string s_ID;
        private string s_FullName;
        private string s_Phone;
        private string s_Address;
        private byte s_Status;

        public DTO_Supplier()
        {
            s_ID = null;
            s_FullName = null;
            s_Phone = null;
            s_Address = null;
            s_Status = 0;
        }

        public DTO_Supplier(string iD, string fullName, string phone, string address, byte status)
        {
            s_ID = iD;
            s_FullName = fullName;
            s_Phone = phone;
            s_Address = address;
            s_Status = status;
        }
    }
}
