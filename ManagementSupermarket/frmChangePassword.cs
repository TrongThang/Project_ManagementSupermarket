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

namespace ManagementSupermarket
{
    public partial class frmChangePassword : Form
    {
        private string idEmployee = "NV001";
        BLL_Account account = new BLL_Account();
        Event eventConfig = new Event();
        public frmChangePassword()
        {
            InitializeComponent();
        }
        public frmChangePassword(string id)
        {
            InitializeComponent();
            idEmployee = id;
        }
        private bool TextboxIsNullOrEmpty()
        {
            string oldPassword,newPassword, confirmNewPassword;
            oldPassword = txt_OldPassword.Text.Trim();
            newPassword = txt_NewPassword.Text.Trim();
            confirmNewPassword = txt_ConfirmPassword.Text.Trim();
            bool IsEmpty = string.IsNullOrEmpty(oldPassword) 
                        || string.IsNullOrEmpty(newPassword) 
                        || string.IsNullOrEmpty(confirmNewPassword);
            if (IsEmpty)
            {
                return true;
            }
            return false;
        }
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword, newPassword, confirmNewPassword;
            oldPassword = txt_OldPassword.Text.Trim();
            newPassword = txt_NewPassword.Text.Trim();
            confirmNewPassword = txt_ConfirmPassword.Text.Trim();

            bool passwordIsNotSame = string.Compare(newPassword, confirmNewPassword) != 0 ? true : false;
            
            if (TextboxIsNullOrEmpty())
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "*Vui lòng nhập đầy đủ thông tin";
                return;
            }
            
            if(passwordIsNotSame)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "*Mật khẩu mới và mật khẩu xác nhận khác nhau";
                return;
            }
            DataTable tblAccount = account.IsAccount(idEmployee, oldPassword);

            if (tblAccount.Rows.Count <= 0) {
                lbl_Error.Text = "*Mật khẩu cũ không chính xác";
                lbl_Error.Visible = true;
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                bool finsihUpdate = account.UpdatePasswordAccount(idEmployee, newPassword);
                if (finsihUpdate)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void ShowHidePassword(FontAwesome.Sharp.IconButton btn, TextBox txt)
        {
            if (btn.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                txt.UseSystemPasswordChar = false;
                btn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else if (btnShowHideOldPassword.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txt.UseSystemPasswordChar = true;
                btn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }
        private void btnShowHideOldPassword_Click(object sender, EventArgs e)
        {
            ShowHidePassword(btnShowHideOldPassword, txt_OldPassword);
        }
        private void btnShowHideNewPassword_Click(object sender, EventArgs e)
        {
            ShowHidePassword(btnShowHideNewPassword, txt_NewPassword);
        }
        private void btnShowHideConfirmPassword_Click(object sender, EventArgs e)
        {
            ShowHidePassword(btnShowHideConfirmPassword, txt_ConfirmPassword);
        }

        
    }
}
