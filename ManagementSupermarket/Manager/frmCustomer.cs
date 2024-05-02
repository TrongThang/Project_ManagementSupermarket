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
using static System.Net.Mime.MediaTypeNames;

namespace ManagementSupermarket
{
    public partial class frmCustomer : Form
    {
        Event eventConfig = new Event();
        BLL_Customer dataCustomer = new BLL_Customer();
        public frmCustomer()
        {
            InitializeComponent();
        }
        private void PressNumber(object sender, KeyPressEventArgs e)
        {
            eventConfig.PressNumber(sender, e);
        }
        private  void LoadData()
        {
            if (chk_CustomerStatus.Checked == false)
            {
                dgv_ListCustomer.DataSource = dataCustomer.GetCustomerTo("TrangThai", "0");
                return;
            }
            
            dgv_ListCustomer.DataSource = dataCustomer.GetCustomerTo("MaKH");
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
            cbb_SearchRole.SelectedIndex = 0;
        }
        private bool IsEmptytTextBox(string fullName, string CCCD, string phone , string address)
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

        private void chk_CustomerStatus_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            On_OffLabelError(0);
            string fullName = txt_FullName.Text.Trim();
            string CCCD = txt_CCCD.Text.Trim();
            string phone=txt_Phone.Text.Trim();
            string address = txt_Address.Text.Trim();
            DateTime createdTime = dtp_CreatedTime.Value;
            string gender = rad_Male.Checked ? "Nam" : "Nữ";
            byte status = (byte)(chk_Status.Checked ? 1 : 0);
            bool isEmpty = IsEmptytTextBox(fullName, CCCD, phone, address);
            if (isEmpty)
            {
                return;
            }
            DTO_Customer customer = new DTO_Customer(fullName, CCCD, phone, gender, address, createdTime, status);
            int numOfRows = dataCustomer.InsertCustomer(customer);
            if (numOfRows > 0)
            {
                string mess = "Thêm khách hàng thành công";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string mess = "Thêm khách hàng thất bại";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void dgv_ListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection rowSelected = dgv_ListCustomer.SelectedRows[0].Cells;
            if (rowSelected.Count > 0)
            {
                txt_ID.Text = rowSelected["MaKH"].Value.ToString();
                txt_FullName.Text = rowSelected["HoTen"].Value.ToString();
                txt_CCCD.Text = rowSelected["CCCD"].Value.ToString();
                txt_Phone.Text = rowSelected["SDT"].Value.ToString();
                txt_Address.Text = rowSelected["DiaChi"].Value.ToString();
                rad_Male.Checked = rowSelected["GioiTinh"].Value.ToString() == "Nam" ? true : false;
                rad_Female.Checked = !rad_Male.Checked;
                dtp_CreatedTime.Value = (DateTime)rowSelected["NgayDangKy"].Value;
                chk_Status.Checked = (bool)rowSelected["TrangThai"].Value;
            }
        }

        private void btn_Alter_Click(object sender, EventArgs e)
        {
            On_OffLabelError(0);
            string id = txt_ID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                string mess = "Vui lòng chọn khách hàng muốn chỉnh sửa";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string fullName=txt_FullName.Text.Trim();
            string CCCD = txt_CCCD.Text.Trim();
            string phone = txt_Phone.Text.Trim();
            string address = txt_Address.Text.Trim();
            DateTime createdTime = dtp_CreatedTime.Value;
            string gender = rad_Male.Checked ? "Nam" : "Nữ";
            byte status = (byte)(chk_Status.Checked ? 1 : 0);


            bool isEmpty = IsEmptytTextBox(fullName, CCCD, phone, address);
            if (isEmpty)
            {
                return;
            }
            DTO_Customer customer=new DTO_Customer(fullName,CCCD,phone,gender,address,createdTime,status,id);
            int numOfRows = dataCustomer.UpdateCustomer(customer);
            if(numOfRows > 0)
            {
                string mess = "Chỉnh sửa thông tin khách hàng thành công";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                string mess = "Chỉnh sửa thông tin khách hàng thất bại";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string id=txt_ID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                string mess = "Vui lòng chọn khách hàng muốn chỉnh sửa";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int numOfRows = dataCustomer.UpdateStatusCustomer(id);
            if (numOfRows > 0)
            {
                string mess = "Xoá thông tin khách hàng thành công";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                string mess = "Xoá thông tin khách hàng thất bại";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_FullName.Clear();
            txt_CCCD.Clear();
            txt_ID.Clear();
            txt_Phone.Clear();
            txt_Address.Clear();
            rad_Male.Checked = true;
            dtp_CreatedTime.Value = DateTime.Now;
            chk_Status.Checked = false;
            On_OffLabelError(0);
            chk_CustomerStatus.Checked = true;
           
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string text= string.IsNullOrEmpty(txt_Search.Text) ? null : txt_Search.Text;
            dgv_ListCustomer.DataSource = dataCustomer.GetCustomerTo(cbb_SearchRole.Text,text);
            dgv_ListCustomer.Refresh();
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            DataTable tblCustomer = (DataTable)dgv_ListCustomer.DataSource;
            ConfigExcel_PDF.ExportToExcel(tblCustomer, "Customer");
            return;
        }
    }
}
