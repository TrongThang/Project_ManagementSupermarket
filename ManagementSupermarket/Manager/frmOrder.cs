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

            cbb_NameProductCreate.DisplayMember = "TenSP";
            cbb_NameProductCreate.ValueMember = "MaSP";
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadDataComboBox_NameProduct();
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
            //string selectedValue = cbb_NameProductCreate.SelectedItem.ToString();

            // Thực hiện các hành động cần thiết với giá trị đã chọn
            //MessageBox.Show(selectedValue);
        }
    }
}
