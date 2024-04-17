using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using BLL;
using DTO;
namespace ManagementSupermarket
{
    public partial class frmManagementEmployees : Form
    {
        Event eventConfig = new Event();
        BLL_Employee dataEmployee = new BLL_Employee();
        public frmManagementEmployees()
        {
            InitializeComponent();
        }
        private void PressNumber(object sender, KeyPressEventArgs e) {
            eventConfig.PressNumber(sender, e);
        }

       
        private void frmManagementEmployee_Load(object sender, EventArgs e)
        {
            cbb_SearchRole.SelectedIndex = 0;
            BLL_Role dataRole = new BLL_Role();

            DataTable tblRole = dataRole.GetRole("MaChucVu");

            cbb_Role.DataSource = tblRole;
            cbb_Role.DisplayMember = "TenChucVu";
            cbb_Role.ValueMember = "MaChucVu";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            BLL_Employee employee = new BLL_Employee();
            string text = string.IsNullOrEmpty(txt_Search.Text) ? null : txt_Search.Text;
            
            dgv_ListEmployee.DataSource = employee.GetEmployeeTo(cbb_SearchRole.Text, text);
            dgv_ListEmployee.Refresh();
        }

        private bool IsEmptytTextBox(string fullName, string CCCD, string phone, string address)
        {
            bool flag = false;
            string notEmpty = " không được bỏ trống";
            if (eventConfig.IsNullOrEmpty(fullName))
            {
                eventConfig.SetErrorLabel(lbl_ErrorName, "Tên", notEmpty);
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(CCCD))
            {
                eventConfig.SetErrorLabel(lbl_ErrorCCCD, "Căn cước công dân", notEmpty);
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(phone))
            {
                eventConfig.SetErrorLabel(lbl_ErrorPhone, "Số điện thoại", notEmpty);
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(address))
            {
                eventConfig.SetErrorLabel(lbl_ErrorAddress, "Địa chỉ", notEmpty);
                flag = true;
            }
            return flag;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string fullName = txt_FullName.Text.Trim();
            string filePicture = "0";
            string CCCD = txt_CCCD.Text.Trim();
            string phone = txt_Phone.Text.Trim();
            string address = txt_Address.Text.Trim();
            DateTime createdTime = dtp_CreatedTime.Value;
            string gender = rad_Male.Checked ? "Nam" : "Nữ";
            string RoleName = cbb_Role.Text.Trim();
            int salary = string.IsNullOrEmpty(txt_Salary.Text.Trim()) ? 0 : int.Parse(txt_Salary.Text.Trim());
            byte status = (byte)(chk_Status.Checked ? 1 : 0);

            bool isEmpty = IsEmptytTextBox(fullName, CCCD, phone, address);

            if (isEmpty) {
                return;
            }

            DTO_Employee employee = new DTO_Employee(fullName, filePicture, CCCD, gender, address, phone, createdTime, RoleName, salary, status);
            
            int numOfRows = dataEmployee.InsertEmployee(employee);
            if(numOfRows > 0)
            {
                string mess = "Thêm thành công nhân viên";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
