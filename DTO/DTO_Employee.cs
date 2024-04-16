using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee
    {
        private string s_ID;
        private string s_FileNameImage;
        private string s_CCCD;
        private string s_FullName;
        private string s_Gender;
        private string s_Address;
        private string s_Phone;
        private DateTime dt_CreatedTime;
        private string s_Role;
        private double d_Salary;
        private byte s_Status;

        public DTO_Employee()
        {
            s_ID = null;
            s_FileNameImage = null;
            s_CCCD = null;
            s_FullName = null;
            s_Gender = null;
            s_Address = null;
            s_Phone = null;
            this.dt_CreatedTime = DateTime.Now;
            s_Role = null;
            d_Salary = 0;
            s_Status = 0;
        }

        public DTO_Employee(string iD, string fileNameImage, string CCCD, string fullName, string gender, string address, string phone, DateTime dt_CreatedTime, string role, double d_Salary,byte status)
        {
            s_ID = iD;
            s_FileNameImage = fileNameImage;
            s_CCCD = CCCD ;
            s_FullName = fullName;
            s_Gender = gender;
            s_Address = address;
            s_Phone = phone;
            this.dt_CreatedTime = dt_CreatedTime;
            s_Role = role;
            d_Salary = 0;
            s_Status = status;
        }

        public string S_ID { get => s_ID; set => s_ID = value; }
        public string S_FileNameImage { get => s_FileNameImage; set => s_FileNameImage = value; }
        public string S_CCCD { get => s_CCCD; set => s_CCCD = value; }
        public string S_FullName { get => s_FullName; set => s_FullName = value; }
        public string S_Gender { get => s_Gender; set => s_Gender = value; }
        public string S_Address { get => s_Address; set => s_Address = value; }
        public string S_Phone { get => s_Phone; set => s_Phone = value; }
        public DateTime Dt_CreatedTime { get => dt_CreatedTime; set => dt_CreatedTime = value; }
        public string S_Role { get => s_Role; set => s_Role = value; }
        public double D_Salary { get => d_Salary; set => d_Salary = value; }
        public byte S_Status { get => s_Status; set => s_Status = value; }
    }
}
