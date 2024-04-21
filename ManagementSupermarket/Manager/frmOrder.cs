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
using System.Windows.Controls;
using ListViewItem = System.Windows.Forms.ListViewItem;
using System.Windows.Media.Animation;
using System.Diagnostics;
using System.Security.Permissions;

namespace ManagementSupermarket
{
    public partial class frmOrder : Form
    {
        private string idEmployee = "NV002";
        private float TotalMoney = 0;
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

            cbb_NameProductCreate.DisplayMember = "TenSP";
            cbb_NameProductCreate.ValueMember = "MaSP";

            if (cbb_NameProductCreate.Items.Count > 0)
            {
                cbb_NameProductCreate.SelectedIndex = -1;
                cbb_NameProductCreate.SelectedIndex = 0;
            }
        }
        private void LoadDataComboBox_Discount()
        {
            cbb_DiscountCreate.DataSource = (new BLL_Discount()).GetDiscountToday();

            cbb_DiscountCreate.DisplayMember = "TenKM";
            cbb_DiscountCreate.ValueMember = "MaKM";

            if (cbb_DiscountCreate.Items.Count > 0)
            {
                cbb_DiscountCreate.SelectedIndex = 0;
            }
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadDataComboBox_NameProduct();
            LoadDataComboBox_Discount();
        }
        
        private void lst_OrderCurrency_Click(object sender, EventArgs e)
        {
            if (lst_OrderCurrency.SelectedItems.Count > 0)
            {

                ListViewSubItemCollection itemSelected = lst_OrderCurrency.SelectedItems[0].SubItems;

                cbb_NameProductCreate.Text = itemSelected[1].Text;

                DataTable tblDiscount = (new BLL_Discount()).GetDiscount("MaKM", itemSelected[4].Text);
                bool issetNameDiscount = tblDiscount.Rows.Count > 0;
                if (issetNameDiscount)
                {
                    cbb_DiscountCreate.Text = tblDiscount.Rows[0]["TenKM"].ToString();
                }
                else
                {
                    cbb_DiscountCreate.Text = "";
                }
                num_CountProductCreate.Text = itemSelected[2].Text;
                txt_PriceCreate.Text = itemSelected[3].Text;
                txt_AmountCreate.Text = itemSelected[6].Text;
            }
        }
        private bool IssetCash()
        {
            bool isSetCash = string.IsNullOrEmpty(txt_CashCustomerCreate.Text.Trim()) ? false : true;
            if (isSetCash == false)
            {
                lbl_ErrorCashCustomer.Visible = true;
                lbl_ErrorCashCustomer.Text = "Vui lòng nhập số tiền của khách hàng!";
            }
            return isSetCash;
        }
        private void codeWhenClick_InputInvoice()
        {
            //if (IssetCash() == false)
            //{
            //    return false;
            //}

            ////MONEY -- CUSTOMER
            //cashCustomer = float.Parse(txt_CashCustomerCreate.Text);
            ////SET MONEY CUSTOMER
            //changeMoney = this.TotalMoney - cashCustomer;
            //txt_ChangeCreate.Text = changeMoney.ToString();
        }
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
        private void btn_Add_Click(object sender, EventArgs e)
        {
            int count = (int)num_CountProductCreate.Value;
            if (count <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng ít nhất là 1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lbl_ErrorCashCustomer.Visible = false;

            string idProduct, idDiscount, nameProduct;
            float price, discount, amount;

            idProduct = cbb_NameProductCreate.SelectedValue.ToString();
            nameProduct = cbb_NameProductCreate.Text;
            price = float.Parse(txt_PriceCreate.Text);


            idDiscount = cbb_DiscountCreate.SelectedValue.ToString();
            DataTable tblDiscount = (new BLL_Discount()).GetDiscount("MaKM", idDiscount);

            //Discount price use to show user. Don't Insert Database. Insert Database is Id Discount
            if (tblDiscount.Rows.Count > 0)
            {
                string value = tblDiscount.Rows[0]["GiaKhuyenMai"].ToString();
                discount = float.Parse(value);
                amount = price * count * (1 - discount);
            }
            else
            {
                discount = 1;
                amount = price * count;
            }

            ListViewItem item = new ListViewItem(idProduct);
            item.Name = idProduct;
            item.SubItems.Add(nameProduct);
            item.SubItems.Add(count.ToString());
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(idDiscount);
            item.SubItems.Add($"{discount * 100}%");
            item.SubItems.Add(amount.ToString());

            //Check If have product, sum Product old and new
            int indexItemExist = lst_OrderCurrency.Items.IndexOfKey(idProduct);
            if (indexItemExist >= 0)
            {
                ListViewSubItemCollection subItem = lst_OrderCurrency.Items[indexItemExist].SubItems;
                int newCount = int.Parse(subItem[2].Text) + count;
                float newAmount = float.Parse(subItem[6].Text) + amount;

                lst_OrderCurrency.Items[indexItemExist].SubItems[2].Text = newCount.ToString();
                lst_OrderCurrency.Items[indexItemExist].SubItems[6].Text = newAmount.ToString();
            }
            else
            {
                lst_OrderCurrency.Items.Add(item);
            }
            
            this.TotalMoney += amount;
            txt_TotalCashCreate.Text = this.TotalMoney.ToString();
        }
        private void btn_Alter_Click(object sender, EventArgs e)
        {
            int count = (int)num_CountProductCreate.Value;
            if (count < 1)
            {
                btn_Delete_Click(sender, e);
            }

            lbl_ErrorCashCustomer.Visible = false;

            string idProduct, idDiscount, nameProduct;
            float price, discount, amount;

            idProduct = cbb_NameProductCreate.SelectedValue.ToString();
            nameProduct = cbb_NameProductCreate.Text;
            price = float.Parse(txt_PriceCreate.Text);

           
            idDiscount = cbb_DiscountCreate.SelectedValue.ToString();
            DataTable tblDiscount = (new BLL_Discount()).GetDiscount("MaKM", idDiscount);

            //Discount price use to show user. Don't Insert Database. Insert Database is Id Discount
            if (tblDiscount.Rows.Count > 0)
            {
                string value = tblDiscount.Rows[0]["GiaKhuyenMai"].ToString();
                discount = 1 - float.Parse(value);
                amount = price * count * discount;
            }
            else
            {
                discount = 0;
                amount = price * count;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn sửa thông tin bán hàng của {nameProduct}??", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int indexItemExist = lst_OrderCurrency.Items.IndexOfKey(idProduct);
                if (indexItemExist >= 0)
                {
                    ListViewSubItemCollection subItem = lst_OrderCurrency.Items[indexItemExist].SubItems;
                    
                    this.TotalMoney = TotalMoney - (int.Parse(subItem[2].Text) - count) * price * (discount == 0 ? 1 : discount);

                    subItem[2].Text = count.ToString();
                    subItem[3].Text = price.ToString();
                    subItem[5].Text = $"{discount * 100}%";
                    subItem[6].Text = amount.ToString();

                    //Set Total Money after update Product
                    MessageBox.Show($"Chỉnh sửa thông tin {nameProduct} thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Có lõi trong quá trình chỉnh sửa thông tin {nameProduct}. Vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txt_TotalCashCreate.Text = this.TotalMoney.ToString();

            }
        }

        private void num_CountProductCreate_ValueChanged(object sender, EventArgs e)
        {
            txt_AmountCreate.Text = (num_CountProductCreate.Value * decimal.Parse(txt_PriceCreate.Text)).ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string idProduct = cbb_NameProductCreate.SelectedValue.ToString();
            string nameProduct = cbb_NameProductCreate.Text;

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn xoá sản phẩm {nameProduct} khỏi giỏ hàng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int indexItemExist = lst_OrderCurrency.Items.IndexOfKey(idProduct);
                if (indexItemExist >= 0)
                {
                    this.TotalMoney = this.TotalMoney - float.Parse(lst_OrderCurrency.Items[indexItemExist].SubItems[6].Text);
                    lst_OrderCurrency.Items.RemoveAt(indexItemExist);

                    MessageBox.Show($"Xoá sản phẩm {nameProduct} khỏi giỏ hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Có lõi trong quá trình xoá {nameProduct}. Vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txt_TotalCashCreate.Text = this.TotalMoney.ToString();
            }

        }

        private void txt_PhoneCustomerCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventConfig.PressNumber(sender, e);
        }
        private void txt_CashCustomerCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsNotNumber = !char.IsDigit(e.KeyChar)
                               && !char.IsControl(e.KeyChar);
            if (IsNotNumber)
            {
                e.Handled = true;
                return;
            }

            if(txt_CashCustomerCreate.Text == "0" && txt_CashCustomerCreate.Text.Count() == 1)
            {
                e.Handled = true;
                txt_CashCustomerCreate.Text = e.KeyChar.ToString();
            }else if(txt_CashCustomerCreate.Text.Count() >= 1 && char.IsDigit(e.KeyChar))
            {
                float moneyCash = float.Parse(txt_CashCustomerCreate.Text) - float.Parse(txt_TotalCashCreate.Text);
            }
        }

        private void btn_FinishOrder_Click(object sender, EventArgs e)
        {
            string idInvoice, idProduct, idDiscount, idEmployee, idCustomer = null,nameProduct, phone;
            float price, discount, amount, totalMoney, cashCustomer;
            int countProduct;

            //Process: Insert Invoice => Get Id Invoice => Check Condition Insert Invoice => Before Use Loop To Insert Detail Invoice

            //@MaNV varchar(10),
            //@MaKH varchar(10) = null,
            //@TongTien decimal,
            //@TienKhachDua decimal = 0
            idEmployee = this.idEmployee;
            if (chk_PhoneCustomer.Checked)
            {
                phone = txt_PhoneCustomerCreate.Text.Trim();
                DataTable tblCustomer = (new BLL_Customer()).GetCustomerTo("SDT", phone);
                if (tblCustomer.Rows.Count > 0)
                {
                    idCustomer = tblCustomer.Rows[0]["MaKH"].ToString();

                }                
            }

            totalMoney = this.TotalMoney;
            
            cashCustomer = float.Parse(txt_CashCustomerCreate.Text);

            DTO_InvoiceSelling invoiceSelling = new DTO_InvoiceSelling(idEmployee, totalMoney, cashCustomer, idCustomer);
            idInvoice = (new BLL_InvoiceSelling()).InsertInvoiceSelling(invoiceSelling).Rows[0][0].ToString();
            //FINISH INSERT INVOICE

            int countInsertDetail = 0;
            foreach (ListViewItem row in lst_OrderCurrency.Items)
            {
                //PROCES Insert Invoice
                //@MaHD varchar(10),
                //@MaSP varchar(20) = null,
                //@MaKM varchar(10) = null,
                //@SoLuong int = 0,
                //@DonGia decimal = 0
                idProduct = row.SubItems[0].Text;
                countProduct = int.Parse(row.SubItems[2].Text);
                idDiscount = string.IsNullOrEmpty(row.SubItems[4].Text) ? null : row.SubItems[4].Text;

                countInsertDetail += countProduct;

                price = int.Parse(row.SubItems[3].Text);

                DTO_Detail_InvoiceSelling detailInvoice = new DTO_Detail_InvoiceSelling(idInvoice, idProduct, idDiscount, countProduct, price);
                int numOfRows = (new BLL_Detail_InvoiceSelling()).InsertDetailInvoiceSelling(detailInvoice);
                if(numOfRows > 0)
                {
                    countInsertDetail++;
                }
            }

            if(countInsertDetail > 0)
            {
                MessageBox.Show($"Đã bán {countInsertDetail} sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_RefreshCreate_Click(sender, e);
                return;
            }

            MessageBox.Show($"Xảy ra sai sót trong quá trình bán hàng. Vui lòng thử lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

            

        }

        private void btn_RefreshCreate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn làm mới trang?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ClearControl();
            }
        }

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
    }
}
