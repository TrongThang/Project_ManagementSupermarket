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
using static System.Windows.Forms.ListViewItem;
using System.Windows.Documents;
<<<<<<< Updated upstream
=======
using System.Windows.Controls;
using ListViewItem = System.Windows.Forms.ListViewItem;
using System.Windows.Media.Animation;
using System.Diagnostics;
using System.Security.Permissions;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Windows.Markup;
>>>>>>> Stashed changes

namespace ManagementSupermarket
{
    public partial class frmOrder : Form
    {
        private string idEmployee;
        public frmOrder()
        {
            InitializeComponent();
        }
        public frmOrder(string idEmployee)
        {
            this.idEmployee = idEmployee;
            InitializeComponent();
        }

        Event eventConfig = new Event();
        //LOAD DATA COMBO BOX
        private void LoadDataComboBox_NameProduct()
        {
            cbb_NameProductCreate.DataSource = (new BLL_Product()).GetProduct("MaSP");

<<<<<<< Updated upstream
            cbb_NameProductCreate.DisplayMember = "TenSP";
            cbb_NameProductCreate.ValueMember = "MaSP";
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadDataComboBox_NameProduct();
=======
            cbbProduct.DisplayMember = "TenSP";
            cbbProduct.ValueMember = "MaSP";

            if (cbbProduct.Items.Count > 0)
            {
                cbbProduct.SelectedIndex = -1;
                cbbProduct.SelectedIndex = 0;
            }
        }
        private void LoadDataComboBox_Discount(ComboBox cbbDiscount)
        {
            cbbDiscount.DataSource = (new BLL_Discount()).GetDiscountToday();

            cbbDiscount.DisplayMember = "TenKM";
            cbbDiscount.ValueMember = "MaKM";

            if (cbbDiscount.Items.Count > 0)
            {
                cbbDiscount.SelectedIndex = 0;
            }
        }
        private void LoadDataGridView_InvoiceSelling()
        {
            dgv_InvoiceSelling.DataSource = (new BLL_InvoiceSelling()).GetInvoiceSelling("MaHD");
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            tab_HomeInvoiceSelling.SelectedIndex = 1;

            //LOAD DATA TAB 1
            LoadDataComboBox_NameProduct(cbb_NameProductCreate);
            LoadDataComboBox_Discount(cbb_DiscountCreate);

            //LOAD DATA TAB 2
            LoadDataGridView_InvoiceSelling();
>>>>>>> Stashed changes
        }

        private void lst_OrderCurrency_Click(object sender, EventArgs e)
        {
            if (lst_OrderCurrency.SelectedItems.Count > 0)
            {
                ListViewSubItemCollection itemSelected = lst_OrderCurrency.SelectedItems[0].SubItems;

                cbb_NameProductCreate.Text = itemSelected[0].Text;
                num_CountProductCreate.Text = itemSelected[1].Text;
                txt_Price.Text = itemSelected[2].Text;
                cbb_DiscountCreate.Text = itemSelected[3].Text;
                cbb_DiscountCreate.Text = itemSelected[4].Text;
                txt_AmountCreate.Text = itemSelected[5].Text;
            }
        }
<<<<<<< Updated upstream

=======
        private void ClearControl()
        {
            cbb_NameProductCreate.SelectedIndex = 0;
            num_CountProductCreate.Value = 0;
            txt_PriceCreate.Text = "0";
            cbb_DiscountCreate.SelectedIndex = 0;
            txt_AmountCreate.Clear();
            chk_PhoneCustomer.Checked = false;
            txt_CashCustomer.Text = "0";
            txt_ChangeCreate.Text = "0";
            txt_TotalCashCreate.Text = "0";
            lst_OrderCurrency.Items.Clear();
        }
        private void cbb_NameProductCreate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idProduct = cbb_NameProductCreate.SelectedValue.ToString();
            txt_PriceCreate.Text = (new BLL_Product()).GetProduct("MaSP", idProduct).Rows[0]["GiaBan"].ToString();
        }
>>>>>>> Stashed changes
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string idProduct, idDiscount;
            decimal price, count, discount, amount;

            idProduct = cbb_NameProductCreate.SelectedValue.ToString();
            count = num_CountProductCreate.Value;
            //price = (new BLL_Product()).GetProduct("MaSP", idProduct).Rows[0];
            idDiscount = cbb_DiscountCreate.SelectedValue.ToString();
            DataTable tblDiscount =  (new BLL_Discount()).GetDiscount("MaKM", idDiscount);

            if(tblDiscount.Rows.Count > 0)
            {
                discount = (decimal)tblDiscount.Rows[0]["GiaKhuyenMai"];
            }
            else
            {
                discount = 0;
            }
            


        }

        private void cbb_NameProductCreate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedValue = cbb_NameProductCreate.SelectedItem.ToString();

<<<<<<< Updated upstream
            // Thực hiện các hành động cần thiết với giá trị đã chọn
            MessageBox.Show(selectedValue);
=======
        private void chk_PhoneCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_PhoneCustomer.Checked == true)
            {
                txt_PhoneCustomerCreate.Enabled = true;
                txt_PhoneCustomerCreate.BackColor = Color.White;
            }
            else {
                txt_PhoneCustomerCreate.Enabled = false;
                txt_PhoneCustomerCreate.BackColor = Color.Gray;
            }
        }

        //LIST INVOICE
        private void dgv_InvoiceSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_InvoiceSelling.SelectedRows.Count > 0)
            {
                DataGridViewRow rowSelect = dgv_InvoiceSelling.SelectedRows[0];

                txt_IdOrder.Text = rowSelect.Cells["MaHD"].Value.ToString();
                txt_IdEmployee.Text = rowSelect.Cells["MaNV"].Value.ToString();
                txt_IdCustomer.Text = rowSelect.Cells["MaKH"].Value.ToString();

                dtp_CreatedTime.Value = (DateTime)rowSelect.Cells["NgayLapHD"].Value;
                txt_CashCustomer.Text = rowSelect.Cells["TienKhachDua"].Value.ToString();
                txt_Change.Text = rowSelect.Cells["TienTraKhach"].Value.ToString();
                txt_TotalCash.Text = rowSelect.Cells["TongTien"].Value.ToString();
            }
        }

        //INVOICE 
        private void btn_DeleteInvoice_TabList_Click(object sender, EventArgs e)
        {
            if (IsNotIdInvoice())
            {
                return;
            }
            string idInvoice = txt_IdOrder.Text.Trim();

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá hoá đơn {idInvoice}?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        
            if( result == DialogResult.Yes )
            {
                int numAffeted_Detail = (new BLL_Detail_InvoiceSelling()).DeleteDetailInvoiceSelling(idInvoice);
                int numAffeted_Invoice = (new BLL_InvoiceSelling()).DeleteInvoiceSelling(idInvoice);

                if(numAffeted_Detail > 0 && numAffeted_Invoice > 0 )
                {
                    MessageBox.Show($"Đã xoá thành công hoá đơn {idInvoice} !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView_InvoiceSelling();
                    return;
                }
                else
                {
                    MessageBox.Show($"Xoá hoá đơn {idInvoice} thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        private void chk_Update_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Update.Checked) { 
                btn_UpdateInvoice_TabList.Enabled = chk_Update.Checked;
                btn_UpdateInvoice_TabList.BackColor = Color.White;

            }
            else
            {
                btn_UpdateInvoice_TabList.Enabled = false;
                btn_UpdateInvoice_TabList.BackColor = Color.Gray;
            }
        }
        private void btn_UpdateInvoice_TabList_Click(object sender, EventArgs e)
        {
            if (IsNotIdInvoice())
            {
                return;
            }
            string idInvoice = txt_IdOrder.Text.Trim();

            if (string.Compare(txt_CashCustomer.Text, txt_TotalCash.Text) == -1)
            {
                MessageBox.Show("Số tiền của khách hàng nhỏ hơn tổng hoá đơn. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn sửa hoá đơn {idInvoice}?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string idCustomer = string.IsNullOrEmpty(txt_IdCustomer.Text.Trim()) ? null : txt_IdCustomer.Text.Trim();
                string idEmployee = txt_IdEmployee.Text.Trim();
                double totalPrice = double.Parse(txt_TotalCash.Text);
                double cashCustomer = double.Parse(txt_CashCustomer.Text);

                DTO_InvoiceSelling DTO_Invoice = new DTO_InvoiceSelling(idEmployee, totalPrice, cashCustomer, idCustomer, idInvoice);
                
                DTO_Invoice.Dt_CreatedTime = dtp_CreatedTime.Value;

                int numAffeted_Invoice = (new BLL_InvoiceSelling()).UpdateInvoiceSelling(DTO_Invoice);

                if (numAffeted_Invoice > 0)
                {
                    MessageBox.Show($"Đã sửa thành công hoá đơn {idInvoice} !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView_InvoiceSelling();  
                    return;
                }
                else
                {
                    MessageBox.Show($"Sửa hoá đơn {idInvoice} thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void txt_CashCustomer_TextChanged(object sender, EventArgs e)
        {
            //double changeMoney = double.Parse(txt_CashCustomer.Text) - double.Parse(txt_TotalCash.Text);
            //txt_CashCustomer.Text = changeMoney.ToString();

        }

        private bool IsNotIdInvoice()
        {
            string idInvoice = txt_IdOrder.Text.Trim();
            if (string.IsNullOrEmpty(idInvoice))
            {
                MessageBox.Show("Vui lòng chọn Hoá đơn muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        private void btn_Refresh_TabList_Click(object sender, EventArgs e)
        {

>>>>>>> Stashed changes
        }
    }
}
