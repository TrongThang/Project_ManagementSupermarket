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
        private DP db = new DP();
        private Dictionary<string, dynamic> createDict(DTO_Employee employee)
        {
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            if(employee.S_ID != null)
            {
                dict.Add("MaNV", employee.S_ID);
            }
            dict.Add("CCCD", employee.S_CCCD);
            dict.Add("HoTen", employee.S_FullName);
            dict.Add("GioiTinh", employee.S_Gender);
            dict.Add("DiaChi", employee.S_Address);
            dict.Add("SDT", employee.S_Phone);
            dict.Add("NgayTao", employee.Dt_CreatedTime);

            DataTable tblRole = (new DAL_Role()).GetRole("TenChucVu", employee.S_Role);
            dict.Add("MaChucVu", tblRole.Rows[0]["MaChucVu"]);
            dict.Add("TrangThai", employee.S_Status);
            return dict;
        }
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
            string sql = "sp_InsertEmployee";
            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            dict = createDict(employee);

            DataTable result = db.queryExecuteAdapter(sql, dict); 
            int numOfRows = result.Rows.Count;
            return numOfRows;
        }
        public int UpdateEmployee(DTO_Employee employee)
        {
            DP db = new DP();
            string sql = "sp_UpdateEmployee";

            Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
            dict = createDict(employee);

            DataTable result = db.queryExecuteAdapter(sql, dict);
            int numOfRows = result.Rows.Count;
            return numOfRows;
        }

        //DELETE EMPLOYEE, BUT ACTUALLY IS UPDATE STATUS FROM 1 TO 0
        public int UpdateStatusEmployee(string id)
        {
            DP db = new DP();
            string sql = "sp_UpdateStatusEmployee";

            db.addParam("MaNV", id);


            DataTable result = db.queryExecuteAdapter(sql);

            int numOfRows = result.Rows.Count;
            return numOfRows;
        }


    }
}