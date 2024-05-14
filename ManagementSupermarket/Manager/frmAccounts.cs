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
using System.Windows.Media.Media3D;

namespace ManagementSupermarket.Manager
{
    public partial class frmAccounts : Form
    {
        private string s_role;

        public frmAccounts()
        {
            InitializeComponent();
        }
        public frmAccounts(string role)
        {
            this.s_role = role;
            InitializeComponent();
        }
        private void LoadDataSearch()
        {
            object[] nameSearch = { "Mã NV", "Họ Tên" };
            object[] idSearch = { "MaNV", "HoTen" };
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

            cbb_Search.DataSource = tblSearch;
            cbb_Search.ValueMember = "MaTimKiem";
            cbb_Search.DisplayMember = "NoiDungTimKiem";
        }
        private void LoadDataGridView(string keySearch = null, string value = null,  bool? status = null)
        {
            dgv_Accounts.DataSource = (new BLL_Account()).GetAccount(keySearch, value, status);
        }
        private void frmAccounts_Load(object sender, EventArgs e)
        {
            LoadDataSearch();
            LoadDataGridView(status: chk_Status.Checked);
        }
        

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            string mess = "";
            
            if (dgv_Accounts.SelectedRows.Count <= 0)
            {
                mess = "Vui lòng chọn một nhân viên muốn thay đổi mật khẩu trong bảng dữ liệu!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newPass = txt_Password.Text.Trim();
            if (string.IsNullOrEmpty(newPass))
            {
                mess = "Vui lòng nhập mật khẩu đầy đủ!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow rowSelected = dgv_Accounts.SelectedRows[0];
            string name, id;
            id = rowSelected.Cells["MaNV"].Value.ToString();
            name = rowSelected.Cells["HoTen"].Value.ToString();
            string roleSelect = rowSelected.Cells["ChucVu"].ToString();
            if (s_role != "QLCC" && roleSelect == "QLCC")
            {
                mess = "Bạn không có quyền thay đổi quản lý cấp cao!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowsAffected = (new BLL_Account()).UpdateStatusAccount(id, chk_Active.Checked);
            
            DialogResult result = MessageBox.Show($"Cập nhật tài khoản của nhân viên {name} với mã số {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool changePasswordSuccess = (new BLL_Account()).UpdatePasswordAccount(id, newPass);
                if (changePasswordSuccess)
                {
                    mess = "Đổi mật khẩu thành công! ";
                }
                else
                {
                    mess = "Đổi mật khẩu thất bại! ";
                }
                if (rowsAffected > 0)
                {
                    mess += " Cập nhật trạng thái thành công! ";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView(status: chk_Status.Checked);
                    return;
                }
                else
                {
                    mess += " Cập nhật trạng thái thất bại! ";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tblAccouts = (DataTable)dgv_Accounts.DataSource;
                ConfigExcel_PDF.ExportToExcel(tblAccouts, $"Accounts");
                return;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_Status_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView(status: chk_Status.Checked);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string keySearch = cbb_Search.SelectedValue.ToString();
            string valueSearch = txtSearch.Text.ToString();

            LoadDataGridView(keySearch, valueSearch, chk_Status.Checked);
        }

        private void dgv_Accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_Accounts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_Accounts.SelectedRows[0];
                txt_Password.Text = row.Cells["MatKhau"].Value.ToString();
                chk_Active.Checked = (bool)row.Cells["TrangThai"].Value;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView(status: chk_Status.Checked);
            txt_Password.Text = "";
            chk_Status.Checked = true;
        }
    }
}
