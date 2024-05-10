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

namespace ManagementSupermarket
{

    public partial class frmSuppiler : Form
    {
        public frmSuppiler()
        {
            InitializeComponent();
        }

        BLL_Supplier datasupplier = new BLL_Supplier();
        Event eventConfig = new Event();

        private bool TextboxSupplierIsEmptyOrNull()
        {
            bool flag = false;
            string nameSupplier, phone, address;
            string mess = "không được bỏ trống!";
            nameSupplier = txt_NameSupplier.Text.Trim();
            phone = txt_Phone.Text.Trim();
            address = txt_Address.Text.Trim();

            if( eventConfig.IsNullOrEmpty(nameSupplier) ) {
                lbl_Name.Text = "Tên " + mess;
                lbl_Name.Visible = true;
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(phone))
            {
                lbl_Phone.Text = "Số điện thoại " + mess;
                lbl_Phone.Visible = true;
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(address))
            {
                lbl_Address.Text = "Địa chỉ " + mess;
                lbl_Address.Visible = true;
                flag = true;
            }
            return flag;
        }


        private void LoadData()
        {
            if(chk_StatusDGV.Checked)
            {
                dgv_Supplier.DataSource = datasupplier.GetSupplier("TrangThai", "1");
            }
            else
            {
                dgv_Supplier.DataSource = datasupplier.GetSupplier("TrangThai", "0");
            }
        }
        private void HideLabel()
        {
            lbl_Name.Visible = false;
            lbl_Phone.Visible = false;
            lbl_Address.Visible = false;
        }
        private void frmSuppiler_Load(object sender, EventArgs e)
        {
            LoadData();
            cbb_Search.SelectedIndex = 0;
        }
        private void dgv_Supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, nameSupplier, phone, address;
            DataGridViewRow rowSelected = dgv_Supplier.SelectedRows[0];

            txt_ID.Text = rowSelected.Cells["MaNCC"].Value.ToString();
            txt_NameSupplier.Text = rowSelected.Cells["TenNCC"].Value.ToString();
            txt_Phone.Text = rowSelected.Cells["SDT"].Value.ToString();
            txt_Address.Text = rowSelected.Cells["DiaChi"].Value.ToString();
            chk_Status.Checked = (bool)rowSelected.Cells["TrangThai"].Value;
        }
        private void chk_StatusDGV_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private bool ExistNameOrPhone(string fullName,string phone)
        {
            bool existName = (new BLL_Supplier()).GetSupplier("TenNCC", fullName).Rows.Count > 0;
            bool existPhone = (new BLL_Customer()).GetCustomerTo("SDT", phone).Rows.Count > 0;
            if (existName)
            {
                MessageBox.Show($"Nhà cung cấp có tên: {fullName} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
            else if (existPhone)
            {
                MessageBox.Show($"Nhà cung cấp có SDT: {phone} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return existPhone;
            return existName;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                HideLabel();
                string nameSupplier, phone, address;
                nameSupplier = txt_NameSupplier.Text.Trim();
                phone = txt_Phone.Text.Trim();
                address = txt_Address.Text.Trim();
                bool status = chk_Status.Checked;

                if (TextboxSupplierIsEmptyOrNull())
                {
                    return;
                }
                 if (ExistNameOrPhone(nameSupplier,phone))
                    {
                        return;
                    }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm thông tin nhà cung cấp?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DTO_Supplier supplier = new DTO_Supplier(nameSupplier, phone, address, status);
                   

                    int numOfRows = datasupplier.InsertSupplier(supplier);
                    if (numOfRows > 0)
                    {
                        MessageBox.Show("Thêm thông tin Nhà cung cấp thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin Nhà cung cấp thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Alter_Click(object sender, EventArgs e)
        {
            try
            {
                HideLabel();
                string id = txt_ID.Text.Trim();
                string nameSupplier, phone, address;
                nameSupplier = txt_NameSupplier.Text.Trim();
                phone = txt_Phone.Text.Trim();
                address = txt_Address.Text.Trim();
                bool status = chk_Status.Checked;

                if (TextboxSupplierIsEmptyOrNull())
                {
                    return;
                }

                if (dgv_Supplier.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Vui lòng chọn một NCC trước khi thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn chỉnh sửa thông tin nhà cung cấp?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DTO_Supplier supplier = new DTO_Supplier(nameSupplier, phone, address, status, id);

                    int numOfRows = datasupplier.UpdateSupplier(supplier);
                    if (numOfRows > 0)
                    {
                        MessageBox.Show("Chỉnh sửa thông tin Nhà cung cấp thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa thông tin Nhà cung cấp thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
      
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                HideLabel();
                string id = txt_ID.Text.Trim();

                if (TextboxSupplierIsEmptyOrNull())
                {
                    return;
                }
                if (dgv_Supplier.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Vui lòng chọn một NCC trước khi thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Xoá thông tin nhà cung cấp?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    int numOfRows = datasupplier.UpdateStatusSupplier(id);
                    if (numOfRows > 0)
                    {
                        MessageBox.Show("Xoá thông tin Nhà cung cấp thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Xoá thông tin Nhà cung cấp thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            HideLabel();
            txt_ID.Clear();
            txt_NameSupplier.Clear();
            txt_Phone.Clear();
            txt_Address.Clear();
            chk_Status.Checked = false;
            chk_StatusDGV.Checked = true;

            txt_Search.Clear();
            LoadData();
        }

       
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_Supplier.DataSource = datasupplier.GetSupplier(cbb_Search.Text, txt_Search.Text);
        }
    }
}
