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
using ComboBox = System.Windows.Forms.ComboBox;

namespace ManagementSupermarket.Manager
{
    public partial class frmWarehouse : Form
    {
        private string idEmployee="NV002";
        private float TotalMoney = 0;
        public frmWarehouse()
        {
            InitializeComponent();
        }
        public frmWarehouse(string idEmployee)
        {
            this.idEmployee=idEmployee;
            InitializeComponent();

        }
        Event eventConfig = new Event();
        
        private void LoadDataComboBox_NameSuppilerCreate()
        {
            cbb_NameSupplierCreate.DataSource = (new BLL_Supplier()).GetSupplier("MaNCC");
            cbb_NameSupplierCreate.DisplayMember = "TenNCC";
            cbb_NameSupplierCreate.ValueMember = "MaNCC";

                
            
        }
        private void LoadDataComboBox_CreateProduct(string idSupllier = null)
        {
            cbb_ProductImportWarehouse.DataSource = (new BLL_Product()).GetProduct("MaNCC", idSupllier);
            cbb_ProductImportWarehouse.DisplayMember = "TenSP";
            cbb_ProductImportWarehouse.ValueMember = "MaSP";
        }
        private void cbb_NameSupplierCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idSupplier = cbb_NameSupplierCreate.SelectedValue.ToString();
            LoadDataComboBox_CreateProduct(idSupplier);


        }
        private void LoadDataComboBox_NameSuppiler()
        {
            cbb_NameSuplier.DataSource = (new BLL_Supplier()).GetSupplier("MaNCC");
            cbb_NameSuplier.DisplayMember = "TenNCC";
            cbb_NameSuplier.ValueMember = "MaNCC";

        }
        private void LoadDataComboBox_NameProduct()
        {
            cbb_NameSuplier.DataSource = (new BLL_Product()).GetProduct("MaSP");
            cbb_NameSuplier.DisplayMember = "TenSP";
            cbb_NameSuplier.ValueMember = "MaSP";

        }
        private void LoadDataGridView_InvoiceWarehouse()
        {
            dgv_ListOrder.DataSource = (new BLL_InvoiceWarehouse()).GetInvoiceImportWareHouse("MaNK");
        }
        private void LoadDataGridView_DetailInvoiceWarehouse(string idInvoice = null)
        {
            dgv_OrderDetail.DataSource = (new BLL_Detail_InvoiceWarehouse()).GetDetailInvoiceImportWareHouse("MaNK", idInvoice);
        }
        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            LoadDataComboBox_NameSuppilerCreate();
            
            LoadDataComboBox_CreateProduct();

            //TAB 2
            LoadDataGridView_InvoiceWarehouse();
            LoadDataGridView_DetailInvoiceWarehouse();
            LoadDataComboBox_NameSuppiler();
        }

        private void lst_ToReceive_Click(object sender, EventArgs e)
        {
            if(lst_ToReceive.SelectedItems.Count > 0)
            {
                ListViewSubItemCollection itemSelected = lst_ToReceive.SelectedItems[0].SubItems;

                cbb_NameSupplierCreate.Text = itemSelected[0].Text;
                cbb_ProductImportWarehouse.Text = itemSelected[1].Text;
                
                num_CountProductCreate.Text = itemSelected[2].Text;
                txt_PriceCreate.Text = itemSelected[3].Text;
                
                dtp_CreatedTime.Text = itemSelected[4].Text;
                txt_IntoMoney.Text = itemSelected[5].Text;

            }
        }
        private void ClearControl()
        {
            cbb_NameSupplierCreate.SelectedIndex = 0;
            cbb_ProductImportWarehouse.SelectedIndex = 0;
            num_CountProductCreate.Value = 0;
            txt_PriceCreate.Text = "0";
            dtp_CreatedTime.Value = DateTime.Now;
            txt_IntoMoney.Clear();
            txt_TotalCashCreate.Clear();
            lst_ToReceive.Items.Clear();



        }

        private void btn_AddCreate_Click(object sender, EventArgs e)
        {
            int count = (int)num_CountProductCreate.Value;
            if (count <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng ít nhất là 1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string idReceive, nameSuppiler, nameProduct;
            float price, amount;
            DateTime createTime;
            nameSuppiler=cbb_NameSupplierCreate.SelectedValue.ToString();
            nameProduct = cbb_ProductImportWarehouse.Text;
            price=float.Parse(txt_PriceCreate.Text);
            createTime = dtp_CreatedTime.Value;
            amount = price * count;
            

            ListViewItem item = new ListViewItem(nameSuppiler);
            item.Name = nameSuppiler;
           
            item.SubItems.Add(nameProduct);
            item.SubItems.Add(count.ToString());
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(createTime.ToString());
            item.SubItems.Add(amount.ToString());

            int indexItemExist = lst_ToReceive.Items.IndexOfKey(nameSuppiler);
            if (indexItemExist >= 0)
            {
                ListViewSubItemCollection subItem = lst_ToReceive.Items[indexItemExist].SubItems;
                int newCount = int.Parse(subItem[3].Text) + count;
                float newPrice =float.Parse(subItem[4].Text)+price;
                float newAmout=float.Parse(subItem[6].Text)+amount;

                lst_ToReceive.Items[indexItemExist].SubItems[3].Text = newCount.ToString();
                lst_ToReceive.Items[indexItemExist].SubItems[4].Text = newPrice.ToString();
                lst_ToReceive.Items[indexItemExist].SubItems[6].Text = newAmout.ToString();


            }
            else
            {
                lst_ToReceive.Items.Add(item);
            }
            this.TotalMoney += amount;
            txt_TotalCashCreate.Text = this.TotalMoney.ToString();


        }

        private void btn_AlterCreate_Click(object sender, EventArgs e)
        {
            int count = (int)num_CountProductCreate.Value;
            if (count < 1)
            {
                btn_DeleteCreate_Click(sender, e);
            }
            string nameSuppiler, nameProduct;
            float price, amount;
            DateTime createTime;
            nameSuppiler = cbb_NameSupplierCreate.SelectedValue.ToString();
            nameProduct = cbb_ProductImportWarehouse.Text;
            price = float.Parse(txt_PriceCreate.Text);
            createTime = dtp_CreatedTime.Value;
            amount =price * count;

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn sửa thông tin nhập kho của {nameProduct}??", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                int indexItemExist = lst_ToReceive.Items.IndexOfKey(nameProduct);
                if (indexItemExist >= 0)
                {
                    ListViewSubItemCollection subItem = lst_ToReceive.Items[indexItemExist].SubItems;

                    //lst_ToReceive.Items[indexItemExist].SubItems[3].Text=count.ToString();
                    //lst_ToReceive.Items[indexItemExist].SubItems[4].Text = price.ToString();
                    //lst_ToReceive.Items[indexItemExist].SubItems[6].Text = amount.ToString();

                    //this.TotalMoney = TotalMoney + (float.Parse(lst_ToReceive.Items[indexItemExist].SubItems[6].Text) - amount);
                    this.TotalMoney = TotalMoney - (int.Parse(subItem[4].Text)-count)*price;
                    subItem[4].Text=count.ToString();
                    subItem[5].Text = price.ToString();
                    subItem[7].Text= amount.ToString();
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
            //txt_IntoMoney.Text=(num_CountProductCreate.Value*decimal.Parse(txt_PriceCreate.Text)).ToString();
        }

        private void btn_DeleteCreate_Click(object sender, EventArgs e)
        {
            string namePeoduct = cbb_ProductImportWarehouse.Text;
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn xoá nhập kho  {cbb_ProductImportWarehouse} khỏi giỏ hàng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int indexItemExist =lst_ToReceive.Items.IndexOfKey(namePeoduct);
                if (indexItemExist >= 0)
                {
                    this.TotalMoney = this.TotalMoney - float.Parse(lst_ToReceive.Items[indexItemExist].SubItems[7].Text);
                    lst_ToReceive.Items.RemoveAt(indexItemExist);
                    MessageBox.Show($"Xoá nhập kho {namePeoduct} khỏi hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Có lỗi trong quá trình xoá {namePeoduct}. Vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txt_TotalCashCreate.Text=this.TotalMoney.ToString();
            }
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            string idReceive, idEmployee, nameSuppiler, nameProduct;
            float totalMoney, price, amout;
            int countProduct;
            DateTime createTime;

            idEmployee = this.idEmployee;
            totalMoney=this.TotalMoney;
            //DTO_InvoiceWarehouse invoiceWarehouse = new DTO_InvoiceWarehouse(idEmployee, nameSuppiler, createdTime, amout);
        }

        private void dgv_ListOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ListOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow rowSelect = dgv_ListOrder.SelectedRows[0];

                txt_IdToReceive.Text = rowSelect.Cells["MaNK"].Value.ToString();
                txt_IdEmployee.Text = rowSelect.Cells["MaNV"].Value.ToString();
                cbb_NameSuplier.Text = (new BLL_Supplier()).GetSupplier("MaNCC", (rowSelect.Cells["MaNCC"].Value.ToString())).Rows[0]["TenNCC"].ToString();
                dtp_CreatedTime_List.Value = (DateTime)rowSelect.Cells["NgayNhapKho"].Value;
                txt_TotalCash.Text = rowSelect.Cells["TongTien"].Value.ToString();

                

            }
        }

        private void cbb_ProductImportWarehouse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idProduct = cbb_ProductImportWarehouse.SelectedValue.ToString();
            txt_PriceCreate.Text = (new BLL_Product()).GetProduct("MaSP", idProduct).Rows[0]["GiaBan"].ToString();
        }

        private void btn_RefreshCreate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn làm mới trang?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ClearControl();
            }
        }
    }
}
