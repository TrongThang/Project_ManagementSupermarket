using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_Employee
    {
        private DAL_Employee dataEmployee = new DAL_Employee();
        public DataTable GetEmployeeTo(string keySearch, string value = null)
        {
            return dataEmployee.GetEmployeeTo(keySearch, value);
        }

        public int InsertEmployee(DTO_Employee employee)
        {
            return dataEmployee.InsertEmployee(employee);
        }
        public int UpdateEmployee(DTO_Employee employee)
        {
            return dataEmployee.UpdateEmployee(employee);
        }

        //DELETE EMPLOYEE, BUT ACTUALLY IS UPDATE STATUS FROM 1 TO 0
        public int UpdateStatusEmployee(string id)
        {
            return dataEmployee.UpdateStatusEmployee(id);
        }
    }
}
