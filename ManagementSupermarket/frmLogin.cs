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

namespace ManagementSupermarket
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if(btnShowHidePassword.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                txt_Password.UseSystemPasswordChar = false;
                btnShowHidePassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else if(btnShowHidePassword.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txt_Password.UseSystemPasswordChar = true;
                btnShowHidePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }
        private bool AutoLogin()
        {
            if(txt_Username.Text == "" && txt_Password.Text == "")
            {
                string role = "QLCC";
                string idEmployee = "NV002";
                frmHomeOfManager frmHomeOfManager = new frmHomeOfManager(idEmployee, role);
                this.Hide();
                frmHomeOfManager.Show();
                return true;
            }
            return false;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim(), password = txt_Password.Text.Trim();

            //Process if username or password empty
            bool isEmpty = string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password);

            BLL_Account account = new BLL_Account();
            DataTable tblAccount = account.IsAccount(username, password);
            bool isNotAccount = true;

            if(tblAccount.Rows.Count > 0) { 
                isNotAccount = false;
            }

            if (isEmpty || isNotAccount)
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "*Tài khoản hoặc mật khẩu không chính xác";
            }
            else
            {
                string role = tblAccount.Rows[0][1].ToString();
                string idEmployee = txt_Username.Text.Trim();
                frmHomeOfManager frmHomeOfManager = new frmHomeOfManager(idEmployee, role);
                this.Hide();
                frmHomeOfManager.Show();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}   
