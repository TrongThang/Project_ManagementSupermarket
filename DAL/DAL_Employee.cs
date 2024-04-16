using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{

    public class DAL_Employee
    {    
        //public DataTable GetEmployee(string id = null)
        //{
        //    DP db = new DP();
        //    string sql = "sp_getEmployee";
        //    DataTable tblEmployee = null;

        //    if (id == null)
        //    {
        //        tblEmployee = db.queryExecuteAdapter(sql);
        //    }
        //    else
        //    {
        //        db.addParam("id", id);
        //        tblEmployee = db.queryExecuteAdapter(sql);
        //    }
        //    return tblEmployee;
        //}

        public DataTable GetEmployeeTo(string keySearch, string value = null)
        {
            DP db = new DP();
            string sql = "sp_getEmployeeTo";
            DataTable tblEmployee = null;

            //keySearch: is Text in ComboBox Search user choice
            //Value: Text in TextBox user input
            db.addParam(keySearch, value);
            tblEmployee = db.queryExecuteAdapter(sql);
            
            return tblEmployee;
        }


        public int InsertEmployee(DTO_Employee employee)
        {
            DP db = new DP();
            string sql = "sp_InsertEmployee";

            db.addParam("HinhAnh", employee.S_FileNameImage);
            db.addParam("CCCD", employee.S_CCCD);
            db.addParam("HoTen", employee.S_FullName);
            db.addParam("GioiTinh", employee.S_Gender);
            db.addParam("DiaChi", employee.S_Address);
            db.addParam("SDT", employee.S_Phone);
            db.addParam("NgayTao", employee.Dt_CreatedTime);
            db.addParam("MaChucVu", employee.S_Role);
            db.addParam("Luong", employee.D_Salary);
            db.addParam("TrangThai", employee.S_Status);

            int numOfRows = db.queryExecute(sql);
            return numOfRows;
        }
        public int UpdateEmployee(DTO_Employee employee)
        {
            DP db = new DP();
            string sql = "sp_UpdateEmployee";

            db.addParam("id", employee.S_ID);
            db.addParam("HinhAnh", employee.S_FileNameImage);
            db.addParam("CCCD", employee.S_CCCD);
            db.addParam("HoTen", employee.S_FullName);
            db.addParam("GioiTinh", employee.S_Gender);
            db.addParam("DiaChi", employee.S_Address);
            db.addParam("SDT", employee.S_Phone);
            db.addParam("NgayTao", employee.Dt_CreatedTime);
            db.addParam("MaChucVu", employee.S_Role);
            db.addParam("Luong", employee.D_Salary);
            db.addParam("TrangThai", employee.S_Status);

            int numOfRows = db.queryExecute(sql);
            return numOfRows;
        }

        //DELETE EMPLOYEE, BUT ACTUALLY IS UPDATE STATUS FROM 1 TO 0
        public int UpdateStatusEmployee(DTO_Employee employee)
        {
            DP db = new DP();
            string sql = "sp_UpdateStatusEmployee";

            db.addParam("id", employee.S_ID);


            int numOfRows = db.queryExecute(sql);
            return numOfRows;
        }


    }
}