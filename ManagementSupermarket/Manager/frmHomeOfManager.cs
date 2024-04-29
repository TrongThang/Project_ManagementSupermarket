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
        }
        private void btn_Sell_Click(object sender, EventArgs e)
        {
            if (numCurrency == btn_Sell.Tag)
            {
                return;
            }
            numCurrency = btn_Sell.Tag;
            frmOrder frmOrder = new frmOrder();
            frmOrder.MdiParent = this;
            frmOrder.Show();

            if (childForm != null && !childForm.IsDisposed)
            {
                childForm.Close();
            }
            childForm = frmOrder;
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            if (btn_Employee.Tag == numCurrency)
            {
                return;
            }
            numCurrency = btn_Employee.Tag;

            frmManagementEmployees frmEmployee = new frmManagementEmployees();
            frmEmployee.MdiParent = this;
            frmEmployee.Show();

            if (childForm != null && !childForm.IsDisposed)
            {
                childForm.Close();
            }
            this.childForm = frmEmployee;

        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            if (btn_Product.Tag == numCurrency)
            {
                return;
            }
            numCurrency = btn_Product.Tag;

            frmManagementProducts frmProducts = new frmManagementProducts();
            frmProducts.MdiParent = this;
            frmProducts.Show();

            if (childForm != null && !childForm.IsDisposed)
            {
                childForm.Close();
            }
            this.childForm = frmProducts;
        }

        private void btn_Discount_Click(object sender, EventArgs e)
        {
            if (btn_Discount.Tag == numCurrency)
            {
                return;
            }
            numCurrency = btn_Discount.Tag;

            frmDiscount frmDiscount = new frmDiscount();
            frmDiscount.MdiParent = this;
            frmDiscount.Show();

            if (childForm != null && !childForm.IsDisposed)
            {
                childForm.Close();
            }
            this.childForm = frmDiscount;
        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            if (btn_Supplier.Tag == numCurrency)
            {
                return;
            }
            numCurrency = btn_Supplier.Tag;

            frmSuppiler frmSuppiler = new frmSuppiler();
            frmSuppiler.MdiParent = this;
            frmSuppiler.Show();

            if (childForm != null && !childForm.IsDisposed)
            {
                childForm.Close();
            }
            this.childForm = frmSuppiler;
        }

        private void btn_WareHouse_Click(object sender, EventArgs e)
        {
            if (btn_WareHouse.Tag == numCurrency)
            {
                return;
            }
            numCurrency = btn_WareHouse.Tag;

            frmWarehouse frmWarehouse = new frmWarehouse();
            frmWarehouse.MdiParent = this;
            frmWarehouse.Show();

            if (childForm != null && !childForm.IsDisposed)
            {
                childForm.Close();
            }
            this.childForm = frmWarehouse;
        }

        private void btn_TypeProduct_Click(object sender, EventArgs e)
        {
            if (btn_TypeProduct.Tag == numCurrency)
            {
                return;
            }
            numCurrency = btn_TypeProduct.Tag;

            frmTypeProduct frmTypeProduct = new frmTypeProduct();
            frmTypeProduct.MdiParent = this;
            frmTypeProduct.Show();

            if (childForm != null && !childForm.IsDisposed)
            {
                childForm.Close();
            }
            this.childForm = frmTypeProduct;
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            if (btn_Customer.Tag == numCurrency)
            {
                return;
            }
            numCurrency = btn_Customer.Tag;

            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.MdiParent = this;
            frmCustomer.Show();

            if (childForm != null && !childForm.IsDisposed)
            {
                childForm.Close();
            }
            this.childForm = frmCustomer;
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
            if(panel_Avatar.Visible)
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
            frmInfomation frmInfomation = new frmInfomation(this.s_idEmployee);
            frmInfomation.Show();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(this.s_idEmployee);
            frmChangePassword.Show();
        }

       
    }
}
