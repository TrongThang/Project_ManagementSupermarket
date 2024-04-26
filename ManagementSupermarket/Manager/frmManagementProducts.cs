using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;
using ComboBox = System.Windows.Forms.ComboBox;
using Image = System.Drawing.Image;

namespace ManagementSupermarket
{
    public partial class frmManagementProducts : Form
    {
        public frmManagementProducts()
        {
            InitializeComponent();
        }
        private void LoadDataComboBoxUnitItem()
        {
            object[] nameUnit = { "Cái", "Hộp", "Lon", "Kg", "Gói", "Chai", "Hủ" };
            cbb_UnitCaculator.Items.AddRange(nameUnit);
            cbb_UnitCaculator.SelectedIndex = 0;
        }
        private void LoadDataComboBoxUnitTime()
        {
            object[] nameUnit = { "Ngày", "Tháng", "Năm" };
            object[] idUnit = { "D", "M", "Y" };
            DataTable tblUnitTime = new DataTable();
            tblUnitTime.Columns.Add("TenNgay");
            tblUnitTime.Columns.Add("MaNgay");

            for (int i = 0; i < nameUnit.Length; i++)
            {
                DataRow newRow = tblUnitTime.NewRow();
                newRow["TenNgay"] = nameUnit[i];
                newRow["MaNgay"] = idUnit[i];
                tblUnitTime.Rows.Add(newRow);
            }

            cbb_UnitTime.DataSource = tblUnitTime;
            cbb_UnitTime.ValueMember = "MaNgay";
            cbb_UnitTime.DisplayMember = "TenNgay";
            cbb_UnitTime.SelectedIndex = 0;
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
            LoadDataComboBoxUnitTime();
            //UNIT ITEM
            LoadDataComboBoxUnitItem();

        }
        private void LoadDataGridView()
        {
            //Create Column to show image
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Hình ảnh";
            imageColumn.Name = "ImageColumn";
            dgv_ListProduct.Columns.Add(imageColumn);   
            
            dgv_ListProduct.DataSource = (new BLL_Product()).GetProduct("MaSP");

            foreach (DataGridViewRow row in dgv_ListProduct.Rows)
            {
                string path = row.Cells["HinhAnh"].Value.ToString();
                string imagePath = Path.Combine(Application.StartupPath, "..", "..", "Image", "Products", path);

                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    row.Cells["ImageColumn"].Value = image;
                }
                else
                {
                    row.Cells["ImageColumn"].Value = null; 
                }
            }
            dgv_ListProduct.Columns["HinhAnh"].Visible = false;
        }
        private void frmManagementProducts_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadDataComboBox();
            cbb_Supplier.SelectedIndex = 0;
            cbb_TypeProduct.SelectedIndex = 0;
            
        }

        //FINISH
        private void dgv_ListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_ListProduct.SelectedRows.Count > 0) {
                DataGridViewCellCollection rowSelected = dgv_ListProduct.SelectedRows[0].Cells;

                pic_Product.ImageLocation = Path.Combine(Application.StartupPath, "..", "..", "Image", "Products", rowSelected["HinhAnh"].Value.ToString());

                txt_ID.Text = rowSelected["MaSP"].Value.ToString();
                    
                string nameSupplier = rowSelected["TenNCC"].Value.ToString();
                cbb_Supplier.SelectedIndex = cbb_Supplier.FindString(nameSupplier);


                txt_NameProduct.Text = rowSelected["TenSP"].Value.ToString();

                string nameTypeProduct = rowSelected["TenLoai"].Value.ToString();
                cbb_TypeProduct.SelectedIndex = cbb_TypeProduct.FindString(nameTypeProduct);

                string unitCaculator = rowSelected["DonViTinh"].Value.ToString();
                cbb_UnitCaculator.SelectedIndex = cbb_UnitCaculator.FindString(unitCaculator);  

                txt_Cost.Text = rowSelected["GiaNhap"].Value.ToString();
                txt_Price.Text = rowSelected["GiaBan"].Value.ToString();

                string date = rowSelected["HanSuDung"].Value.ToString();
                if (date.Length > 0)
                {
                    num_ShelfLife.Value = decimal.Parse(date[0].ToString());
                    string unitTime = date[date.Length - 1].ToString();
                    int index = -1;
                    if (unitTime == "D")
                        index = 0;
                    else if(unitTime == "M")
                        index = 1;
                    else if(unitTime == "Y")
                        index = 2;
                    cbb_UnitTime.SelectedIndex = index;
                }
                else
                {
                    num_ShelfLife.Value = 99;
                    cbb_UnitTime.Text = "";
                }
                num_Count.Text = rowSelected["SoLuong"].Value.ToString();
                chk_Status.Checked = (bool)rowSelected["TrangThai"].Value;

            }
        }
        //FINISH
        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png; *.jpg; *.jpeg) | *.png; *.jpg; *.jpeg";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            DialogResult result = openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;

            if (result == DialogResult.OK && !string.IsNullOrEmpty(fileName))
            {
                string tmp = fileName;
                pic_Product.ImageLocation = tmp;
            }

        }



    }
}
