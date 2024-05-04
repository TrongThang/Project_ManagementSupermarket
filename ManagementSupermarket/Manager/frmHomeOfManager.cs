using BLL;
using FontAwesome.Sharp;
using ManagementSupermarket.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSupermarket
{
    public partial class frmHomeOfManager : Form
    {
        private string s_role;
        private string s_idEmployee;
        private Form frmChild;
        private IconButton lastClickedButton;
        public frmHomeOfManager(string idEmployee, string role)
        {
            s_idEmployee = idEmployee;
            s_role = role;
            InitializeComponent();
        }
        private Form childForm;
        private object numCurrency;

        private void RoleAccess()
        {
            if (s_role == "NV")
            {
                btn_Employee.Visible = false;
                btn_Customer.Visible = false;
                btn_Product.Visible = false;
                btn_Discount.Visible = false;
                btn_Supplier.Visible = false;
                btn_WareHouse.Visible = false;
                btn_TypeProduct.Visible = false;
            }
        }
        private void frmHomeOfManager_Load(object sender, EventArgs e)
        {
            RoleAccess();
            lbl_Name.Text = (new BLL_Employee()).GetEmployeeTo("MaNV", s_idEmployee).Rows[0]["HoTen"].ToString();
        }
        private void OpenfrmChild(Form Child, IconButton btn)
        {
            if (frmChild != null)
            {
                frmChild.Close();
            }
            frmChild = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            panel_body.Controls.Add(Child);
            panel_body.Tag = Child;
            Child.BringToFront();
            Child.Show();

            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.FromArgb(255, 255, 255);
                lastClickedButton.ForeColor = Color.Black;
                lastClickedButton.IconColor = Color.Black;
            }
            IconButton clickedButton = btn;
            if (clickedButton != null)
            {
                clickedButton.BackColor = Color.FromArgb(57, 65, 107);
                clickedButton.ForeColor = Color.Yellow;
                clickedButton.IconColor = Color.White;
                // Lưu trữ tham chiếu của nút mới được nhấn vào biến theo dõi
                lastClickedButton = clickedButton;
            }
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frmOrder(), btn);
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frmManagementEmployees(), btn);

        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frmManagementProducts(), btn);
        }

        private void btn_Discount_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frmDiscount(), btn);
        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frmSuppiler(), btn);
        }

        private void btn_WareHouse_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frmWarehouse(), btn);
        }

        private void btn_TypeProduct_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frmTypeProduct(), btn);
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frmCustomer(), btn);
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đăng xuất phần mềm?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pic_Avatar_Click(object sender, EventArgs e)
        {
            if (panel_Avatar.Visible)
            {
                panel_Avatar.Visible = false;
            }
            else
            {
                panel_Avatar.Visible = true;
            }
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frmInfomation(), btn);
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frmChangePassword(this.s_idEmployee), btn);
        }

        private void btn_Revenue_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            OpenfrmChild(new frm_Revenue(), btn);
        }
    }
}
