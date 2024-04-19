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
    public partial class frmManagementProducts : Form
    {
        public frmManagementProducts()
        {
            InitializeComponent();
        }
        private void LoadDataComboBox()
        {
            BLL_Supplier dataSupplier = new BLL_Supplier();
            BLL_TypeProduct dataTypeProduct = new BLL_TypeProduct();

            //SUPPLIER
            cbb_Supplier.DataSource = dataSupplier.GetSupplier("TrangThai", "1");
            cbb_Supplier.DisplayMember = "TenNCC";
            cbb_Supplier.ValueMember = "MaNCC";
            //TYPE PRODUCT
            cbb_TypeProduct.DataSource = dataTypeProduct.GetTypeProduct("MaLoaiSP");
            cbb_TypeProduct.DisplayMember = "TenLoai";
            cbb_TypeProduct.ValueMember = "MaLoaiSP";
            //UNIT TIME
        }
        private void frmManagementProducts_Load(object sender, EventArgs e)
        {
            LoadDataComboBox();
            cbb_Supplier.SelectedIndex = 0;
            cbb_TypeProduct.SelectedIndex = 0;
        }
    }
}
