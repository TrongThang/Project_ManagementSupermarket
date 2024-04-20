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

namespace ManagementSupermarket
{
    public partial class frmOrder : Form
    {
        private string idEmployee;
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

                cbb_NameProductCreate.Text = itemSelected[0].Text;
                num_CountProductCreate.Text = itemSelected[1].Text;
                txt_Price.Text = itemSelected[2].Text;
                txt_AmountCreate.Text = itemSelected[5].Text;
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
            num_CountProduct.Value = 0;
            txt_Price.Text = "1";

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
            }
            else
            {
                discount = 1;
            }
            amount = price * count * (1 - discount);
            this.TotalMoney += amount;


            ListViewItem item = new ListViewItem(nameProduct);
            item.Name = idProduct;
            item.SubItems.Add(count.ToString());
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(idDiscount);
            item.SubItems.Add($"{discount * 100}%");
            item.SubItems.Add(amount.ToString());

            int indexItemExist = lst_OrderCurrency.Items.IndexOfKey(idProduct);
            if (indexItemExist >= 0)
            {
                ListViewSubItemCollection subItem = lst_OrderCurrency.Items[indexItemExist].SubItems;
                int newCount = int.Parse(subItem[1].Text) + count;
                float newAmount = float.Parse(subItem[5].Text) + amount;

                lst_OrderCurrency.Items[indexItemExist].SubItems[1].Text = newCount.ToString();
                lst_OrderCurrency.Items[indexItemExist].SubItems[5].Text = newAmount.ToString();
            }
            else
            {
                lst_OrderCurrency.Items.Add(item);
            }


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

            string idProduct, idDiscount, nameProduct, price;
            float discount, amount;

            idProduct = cbb_NameProductCreate.SelectedValue.ToString();
            nameProduct = cbb_NameProductCreate.Text;
            price = txt_PriceCreate.Text;

           
            idDiscount = cbb_DiscountCreate.SelectedValue.ToString();
            DataTable tblDiscount = (new BLL_Discount()).GetDiscount("MaKM", idDiscount);

            //Discount price use to show user. Don't Insert Database. Insert Database is Id Discount
            if (tblDiscount.Rows.Count > 0)
            {
                string value = tblDiscount.Rows[0]["GiaKhuyenMai"].ToString();
                discount = float.Parse(value);
            }
            else
            {
                discount = 1;
            }
            amount = float.Parse(price) * count * (1 - discount);

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn sửa thông tin bán hàng của {nameProduct}??", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int indexItemExist = lst_OrderCurrency.Items.IndexOfKey(idProduct);
                if (indexItemExist >= 0)
                {
                    ListViewSubItemCollection subItem = lst_OrderCurrency.Items[indexItemExist].SubItems;

                    lst_OrderCurrency.Items[indexItemExist].SubItems[1].Text = count.ToString();
                    lst_OrderCurrency.Items[indexItemExist].SubItems[2].Text = price.ToString();
                    lst_OrderCurrency.Items[indexItemExist].SubItems[3].Text = idDiscount;
                    lst_OrderCurrency.Items[indexItemExist].SubItems[4].Text = $"{discount * 100}%";
                    lst_OrderCurrency.Items[indexItemExist].SubItems[5].Text = amount.ToString();

                    //Set Total Money after update Product
                    this.TotalMoney = TotalMoney + (float.Parse(lst_OrderCurrency.Items[indexItemExist].SubItems[5].Text) - amount);

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
                    //this.TotalMoney = this.TotalMoney - float.Parse(lst_OrderCurrency.Items[indexItemExist].Text);
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
    }
}
