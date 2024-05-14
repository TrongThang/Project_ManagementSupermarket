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
using System.Windows.Markup;
using System.Windows.Media.Media3D;
using BLL;
using DTO;
using static System.Net.Mime.MediaTypeNames;
namespace ManagementSupermarket
{
    public partial class frmManagementEmployees : Form
    {
        private string s_role;
        Event eventConfig = new Event();
        BLL_Employee dataEmployee = new BLL_Employee();
        public frmManagementEmployees()
        {
            InitializeComponent();
        }
        public frmManagementEmployees(string role)
        {
            s_role = role;
            InitializeComponent();
        }

        //PROCESS EVENT
        private void PressNumber(object sender, KeyPressEventArgs e) {
            eventConfig.PressNumber(sender, e);
        }
        private void LoadComboBoxSearch()
        {
            object[] nameSearch = { "Mã NV", "CCCD", "Họ Tên", "Địa Chỉ", "SĐT", "Chức Vụ" };
            object[] idSearch = { "MaNV", "CCCD", "HoTen", "DiaChi", "SDT", "MaChucVu" };
            DataTable tblSearch = new DataTable();
            tblSearch.Columns.Add("NoiDungTimKiem");
            tblSearch.Columns.Add("MaTimKiem");

            for (int i = 0; i < nameSearch.Length; i++)
            {
                DataRow newRow = tblSearch.NewRow();
                newRow["NoiDungTimKiem"] = nameSearch[i];
                newRow["MaTimKiem"] = idSearch[i];
                tblSearch.Rows.Add(newRow);
            }

            cbb_SearchRole.DataSource = tblSearch;
            cbb_SearchRole.ValueMember = "MaTimKiem";
            cbb_SearchRole.DisplayMember = "NoiDungTimKiem";
        }

        private void LoadData()
        {
            if(chk_EmployeeStatus.Checked == false)
            {
                dgv_ListEmployee.DataSource = dataEmployee.GetEmployeeTo("TrangThai", "0");
                return;
            }

            dgv_ListEmployee.DataSource = dataEmployee.GetEmployeeTo("MaNV");
        }
        private bool IsMaster(string idEmployee)
        {
            bool isMaster = (new BLL_Employee()).GetEmployeeTo("MaNV", idEmployee).Rows[0]["MaChucVu"].ToString() == "QLCC";
            if(isMaster )
            {
                return true;
            }
            return false;
        }
        private bool CanNotAddRole()
        {
            if (string.Equals(s_role, "QL") && string.Equals(cbb_Role.SelectedValue, "QLCC"))
            {
                MessageBox.Show("Bạn không có quyền tuỳ chỉnh chức vụ Quản lý cao cấp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void frmManagementEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxSearch();
            cbb_SearchRole.SelectedIndex = 0;

            DataTable tblRole = (new BLL_Role()).GetRole("MaChucVu");

            cbb_Role.DataSource = tblRole;
            cbb_Role.DisplayMember = "TenChucVu";
            cbb_Role.ValueMember = "MaChucVu";
        }
        private bool IsEmptytTextBox(string fullName, string CCCD, string phone, string address)
        {
            bool flag = false;
            string notEmpty = " không bỏ trống";
            if (eventConfig.IsNullOrEmpty(fullName))
            {
                eventConfig.SetErrorLabel(lbl_ErrorName, "Tên", notEmpty);
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(CCCD))
            {
                eventConfig.SetErrorLabel(lbl_ErrorCCCD, "CCCD", notEmpty);
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
        private void On_OffLabelError(int option)
        {
            if (option == 0)
            {
                lbl_ErrorName.Visible = false;
                lbl_ErrorCCCD.Visible = false;
                lbl_ErrorPhone.Visible = false;
                lbl_ErrorAddress.Visible = false;
                return;
            }
            lbl_ErrorName.Visible = true;
            lbl_ErrorCCCD.Visible = true;
            lbl_ErrorPhone.Visible = true;
            lbl_ErrorAddress.Visible = true;
        }
        private void chk_EmployeeStatus_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_ListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCellCollection rowSelected = dgv_ListEmployee.SelectedRows[0].Cells;

                if (rowSelected.Count > 0)
                {
                    txt_Id.Text = rowSelected["MaNV"].Value.ToString();
                    txt_FullName.Text = rowSelected["HoTen"].Value.ToString();
                    txt_CCCD.Text = rowSelected["CCCD"].Value.ToString();
                    txt_Phone.Text = rowSelected["SDT"].Value.ToString();
                    txt_Address.Text = rowSelected["DiaChi"].Value.ToString();

                    dtp_CreatedTime.Value = (DateTime)rowSelected["NgayTao"].Value;
                    //ERROR
                    cbb_Role.SelectedItem = cbb_Role.Items.IndexOf(rowSelected["MaChucVu"].Value.ToString());
                    rad_Male.Checked = rowSelected["GioiTinh"].Value.ToString() == "Nam" ? true : false;
                    rad_Female.Checked = !rad_Male.Checked;
                    chk_Status.Checked = (bool)rowSelected["TrangThai"].Value;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ExistCCCD(string CCCD)
        {
            bool existCCCD = (new BLL_Customer()).GetCustomerTo("CCCD", CCCD).Rows.Count > 0;
            if (existCCCD)
            {
                MessageBox.Show($"CCCD: {CCCD} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return existCCCD;
        }

        //BUTTON
        private void btn_Add_Click(object sender, EventArgs e)
        {
            On_OffLabelError(0);
            if (CanNotAddRole())
            {
                return;
            }
            string fullName = txt_FullName.Text.Trim();
            string CCCD = txt_CCCD.Text.Trim();
            string phone = txt_Phone.Text.Trim();
            string address = txt_Address.Text.Trim();

            bool isEmpty = IsEmptytTextBox(fullName, CCCD, phone, address);

            if (isEmpty)
            {
                return;
            }
            else if (ExistCCCD(CCCD))
            {
                return;
            }

            DateTime createdTime = dtp_CreatedTime.Value;
            string gender = rad_Male.Checked ? "Nam" : "Nữ";
            string RoleName = cbb_Role.Text.Trim();
            byte status = (byte)(chk_Status.Checked ? 1 : 0);


            try
            {
                DTO_Employee employee = new DTO_Employee(fullName, CCCD, gender, address, phone, createdTime, RoleName, status);

                int numOfRows = dataEmployee.InsertEmployee(employee);
                if (numOfRows > 0)
                {
                    string mess = "Thêm nhân viên thành công";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    string mess = "Thêm nhân viên thất bại";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Alter_Click(object sender, EventArgs e)
        {
            On_OffLabelError(0);
            if (CanNotAddRole())
            {
                return;
            }
            string id = txt_Id.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                string mess = "Vui lòng chọn nhân viên muốn chỉnh sửa";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string fullName = txt_FullName.Text.Trim();
            string CCCD = txt_CCCD.Text.Trim();
            string phone = txt_Phone.Text.Trim();
            string address = txt_Address.Text.Trim();

            bool isEmpty = IsEmptytTextBox(fullName, CCCD, phone, address);

            if (isEmpty)
            {
                return;
            }

            DateTime createdTime = dtp_CreatedTime.Value;
            string gender = rad_Male.Checked ? "Nam" : "Nữ";
            string RoleName = cbb_Role.Text.Trim();
            byte status = (byte)(chk_Status.Checked ? 1 : 0);

            DTO_Employee employee = new DTO_Employee(fullName, CCCD, gender, address, phone, createdTime, RoleName, status, id);

            int numOfRows = dataEmployee.UpdateEmployee(employee);
            if (numOfRows > 0)
            {
                string mess = "Chỉnh sửa thông tin nhân viên thành công";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                string mess = "Chỉnh sửa thông tin nhân viên thất bại";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string id = txt_Id.Text.Trim();
            if (IsMaster(id))
            {
                MessageBox.Show("Không thể xoá quản lý cao cấp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(id))
            {
                string mess = "Vui lòng chọn nhân viên muốn chỉnh sửa";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult res = MessageBox.Show($"Bạn chắc chắn muốn xoá nhân viên với mã số {id}?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                try
                {
                    int numOfRows = dataEmployee.UpdateStatusEmployee(id);

                    if (numOfRows > 0)
                    {
                        string mess = "Xoá thông tin nhân viên thành công";
                        MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        string mess = "Xoá thông tin nhân viên thất bại";
                        MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_FullName.Clear();
            txt_CCCD.Clear();
            txt_Id.Clear();
            txt_Phone.Clear();

            txt_Address.Clear();

            txt_Search.Clear();
            cbb_Role.SelectedItem = 0;
            rad_Male.Checked = true;
            dtp_CreatedTime.Value = DateTime.Now;

            chk_Status.Checked = false;
            On_OffLabelError(0);
            chk_EmployeeStatus.Checked = true;

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string text = string.IsNullOrEmpty(txt_Search.Text) ? null : txt_Search.Text;

            dgv_ListEmployee.DataSource = dataEmployee.GetEmployeeTo(cbb_SearchRole.SelectedValue.ToString(), text);
            dgv_ListEmployee.Refresh();
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            DataTable tblEmployee = (DataTable)dgv_ListEmployee.DataSource;
            ConfigExcel_PDF.ExportToExcel(tblEmployee, "Employee");
            return;
        }
    }
}
