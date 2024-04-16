using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        private string s_ID;
        private string s_FullName;
        private string s_CCCD;
        private string s_Phone;
        private string s_Gender;
        private string s_Address;
        private DateTime dt_CreatedTime;
        private byte s_Status;

        public DTO_Customer()
        {
            s_ID = null;
            s_FullName = null;
            s_CCCD = null;
            s_Phone = null;
            s_Gender = null;
            s_Address = null;
            this.dt_CreatedTime = DateTime.Now;
            s_Status = 0;
        }

        public DTO_Customer(string iD, string fullName, string CCCD, string phone, string gender, string address, DateTime dt_CreatedTime, byte status)
        {
            s_ID = iD;
            s_FullName = fullName;
            s_CCCD = CCCD;
            s_Phone = phone;
            s_Gender = gender;
            s_Address = address;
            this.dt_CreatedTime = dt_CreatedTime;
            s_Status = status;
        }
    }
}
