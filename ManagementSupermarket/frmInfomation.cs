using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.IO;
namespace ManagementSupermarket
{
    public partial class frmInfomation : Form
    {
        private string idEmployee;
        private Event eventConfig = new Event();
        BLL_Employee dataEmployee = new BLL_Employee();
        private string nameForm = "Form Infomation";

        public frmInfomation()
        {
            InitializeComponent();
        }
        public frmInfomation(string id)
        {
            InitializeComponent();
            idEmployee = id;
        }

        private void frmInfomation_Load(object sender, EventArgs e)
        {
            try
            {
                DataRow employee = dataEmployee.GetEmployeeTo("MaNV", idEmployee).Rows[0];
                lbl_ID.Text = idEmployee;

                string RoleId = employee["MaChucVu"].ToString();
                string roleName = (new BLL_Role()).GetRole("MaChucVu", RoleId).Rows[0]["TenChucVu"].ToString();
                lbl_RoleName.Text = roleName;

                txt_FullName.Text = employee["HoTen"].ToString();
                txt_CCCD.Text = employee["CCCD"].ToString();

                bool isMale = employee["GioiTinh"].ToString() == "Nam";
                if (isMale)
                {
                    rad_Male.Checked = true;
                    pic_Avatar.ImageLocation = Path.Combine(Application.StartupPath, "Resources", "Image", "Icon", "avatarDefaultMale.png");
                }
                else
                {
                    rad_Female.Checked = true;
                    pic_Avatar.ImageLocation = Path.Combine(Application.StartupPath, "Resources", "Image", "Icon", "avatarDefaultFemale.png");
                }

                txt_Address.Text = employee["DiaChi"].ToString();
                txt_Phone.Text = employee["SDT"].ToString();


                rad_Male.Checked = employee["GioiTinh"].ToString() == "Nam" ? true : false;
                rad_Female.Checked = !rad_Male.Checked;
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BLL_ManagementError.InsertError(err.Message, nameForm + " - Load Form");
            }
        }

        private bool IsEmptytTextBox(string fullName, string CCCD, string phone, string address)
        {
            bool flag = false;
            string notEmpty = " không bỏ trống";
            if (eventConfig.IsNullOrEmpty(fullName))
            {
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(CCCD))
            {
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(phone))
            {
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(address))
            {
                flag = true;
            }
            return flag;
        }
        private void CheckPhoneAndCCD()
        {
            if(txt_Phone.TextLength < 10)
            {
                string mess = "Số điện thoại phải đủ 10 số";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if(txt_CCCD.TextLength < 12)
            {
                string mess = "Căn cước công dân phải đủ 12 số";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_Alter_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname, CCCD, phone, address, gender, roleName;
                string id = idEmployee;
                fullname = txt_FullName.Text;
                CCCD = txt_CCCD.Text;
                phone = txt_Phone.Text;
                address = txt_Address.Text;

                DataRow employee = dataEmployee.GetEmployeeTo("MaNV", idEmployee).Rows[0];

                bool isEmpty = IsEmptytTextBox(fullname, CCCD, phone, address);

                DateTime createdTime = (DateTime)employee["NgayTao"];
                gender = rad_Male.Checked ? "Nam" : "Nữ";
                roleName = lbl_RoleName.Text;

                if (isEmpty)
                {
                    return;
                }

                DTO_Employee DTO_employee = new DTO_Employee(fullname, CCCD, gender, address, phone, createdTime, roleName, 1, id);

                int numOfRows = dataEmployee.UpdateEmployee(DTO_employee);
                if (numOfRows > 0)
                {
                    string mess = "Chỉnh sửa thông tin nhân viên thành công";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmInfomation_Load(sender, e);
                }
                else
                {
                    string mess = "Chỉnh sửa thông tin nhân viên thất bại";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BLL_ManagementError.InsertError(err.Message, nameForm + " - Nút cập nhật thông tin");
            }
        }

        private void txt_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsNotNumber = !char.IsDigit(e.KeyChar)
                              && !char.IsControl(e.KeyChar);
            if (IsNotNumber)
            {
                e.Handled = true;
            }
        }
    }
}
