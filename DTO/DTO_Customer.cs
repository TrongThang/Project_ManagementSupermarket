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

        public string S_ID { get => s_ID; set => s_ID = value; }
        public string S_FullName { get => s_FullName; set => s_FullName = value; }
        public string S_CCCD { get => s_CCCD; set => s_CCCD = value; }
        public string S_Phone { get => s_Phone; set => s_Phone = value; }
        public string S_Gender { get => s_Gender; set => s_Gender = value; }
        public string S_Address { get => s_Address; set => s_Address = value; }
        public DateTime Dt_CreatedTime { get => dt_CreatedTime; set => dt_CreatedTime = value; }
        public byte S_Status { get => s_Status; set => s_Status = value; }
    }
}
