using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Supplier
    {
        private string s_ID;
        private string s_FullName;
        private string s_Phone;
        private string s_Address;
        private bool s_Status;

        public DTO_Supplier()
        {
            S_ID = null;
            S_FullName = null;
            S_Phone = null;
            S_Address = null;
            S_Status = false;
        }

        public DTO_Supplier(string fullName, string phone, string address, bool status, string iD = null)
        {
            S_ID = iD;
            S_FullName = fullName;
            S_Phone = phone;
            S_Address = address;
            S_Status = status;
        }

        public string S_ID { get => s_ID; set => s_ID = value; }
        public string S_FullName { get => s_FullName; set => s_FullName = value; }
        public string S_Phone { get => s_Phone; set => s_Phone = value; }
        public string S_Address { get => s_Address; set => s_Address = value; }
        public bool S_Status { get => s_Status; set => s_Status = value; }
    }
}
