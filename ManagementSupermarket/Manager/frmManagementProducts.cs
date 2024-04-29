using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        private void AddColumnImageDGV()
        {
            //Create Column to show image
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Hình ảnh";
            imageColumn.Name = "ImageColumn";
            dgv_ListProduct.Columns.Add(imageColumn);
        }
        private void LoadDataGridView(string nameProdut = null)
        {
            dgv_ListProduct.DataSource = (new BLL_Product()).GetProduct("TenSP", nameProdut);
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
            //dgv_ListProduct.Columns["HinhAnh"].Visible = false;

        }
        private void frmManagementProducts_Load(object sender, EventArgs e)
        {
            AddColumnImageDGV();
            LoadDataGridView();
            LoadDataComboBox();
            cbb_Supplier.SelectedIndex = 0;
            cbb_TypeProduct.SelectedIndex = 0;
            cbb_UnitCaculator.SelectedIndex = 0;    
            cbb_UnitTime.SelectedIndex = 0;
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
        private void CopyImageToFolderProject(string pathImage)
        {
            string destFolder = Path.Combine(Application.StartupPath, "..", "..", "Image", "Products");
            string destFileName = Path.Combine(destFolder, Path.GetFileName(pathImage));

            if (!File.Exists(destFileName))
            {
                File.Copy(pathImage, destFileName);
            }
        }
        
        //CHECK ERROR INPUT
        private bool IsErrorInput()
        {
            bool errorName = string.IsNullOrEmpty(txt_NameProduct.Text.Trim());
            bool errorEmptyMoney = string.IsNullOrEmpty(txt_Cost.Text.Trim()) || string.IsNullOrEmpty(txt_Price.Text.Trim());
            bool errorCost_Larger_Price = int.Parse(txt_Cost.Text) > int.Parse(txt_Price.Text);

            string mess = "";
            if (errorName)
            {
                mess = "Tên không được để trống!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }else if (errorEmptyMoney)
            {
                mess = "Giá nhập và giá bán không được để trống!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if(errorCost_Larger_Price)
            {
                mess = "Giá bán phải lớn hơn giá nhập!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }
        private double GetNumberShelfLife(string shelfLife)
        {
            string num = "";
            for (int i = 0; i < shelfLife.Length - 1; i++)
            {
                num += shelfLife[i];
            }
            return double.Parse(num);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (IsErrorInput())
            {
                return;
            }
            string pathImage, nameProduct, idSupplier, idType, unitItem, unitTime, shelfLife;
            double cost, price;
            int count;
            byte status;

            pathImage = Path.GetFileName(pic_Product.ImageLocation);
            idSupplier = cbb_Supplier.SelectedValue.ToString();
            nameProduct = txt_NameProduct.Text.Trim();
            idType = cbb_TypeProduct.SelectedValue.ToString();
            unitItem = cbb_UnitCaculator.Text.ToString();
            unitTime = cbb_UnitTime.SelectedValue.ToString();

            cost = double.Parse(txt_Cost.Text);
            price = double.Parse(txt_Price.Text);
            shelfLife = num_ShelfLife.Text + unitTime;

            count = (int)num_Count.Value;
            status = (byte)(chk_Status.Checked ? 1 : 0);

            DTO_Product product = new DTO_Product(pathImage, nameProduct, idSupplier, idType, cost, price, count, shelfLife, unitItem, status);

            int affectedRows = (new BLL_Product()).InsertProduct(product);

            string mess = "";
            if (affectedRows > 0)
            {
                mess = $"Thêm sản phẩm {nameProduct} thành công!!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();

                CopyImageToFolderProject(pathImage);
                return;
            }
            else
            {
                mess = $"Thêm sản phẩm {nameProduct} thất bại. Vui lòng thử lại!!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private bool IsNotId()
        {
            if(dgv_ListProduct.SelectedRows.Count > 0) { 
                return false;
            }
            MessageBox.Show("Vui lòng chọn sản phẩm cần thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return true;
        }

        private void btn_Alter_Click(object sender, EventArgs e)
        {
            if (IsNotId())
            {
                return;
            }else if (IsErrorInput())
            {
                return;
            }

            string pathImage, idProduct, nameProduct, idSupplier, idType, unitItem, unitTime, shelfLife;
            double cost, price;
            int count;
            byte status;

            pathImage = Path.GetFileName(pic_Product.ImageLocation);
            idProduct = txt_ID.Text;
            nameProduct = txt_NameProduct.Text.Trim();
            idSupplier = cbb_Supplier.SelectedValue.ToString();
            idType = cbb_TypeProduct.SelectedValue.ToString();
            unitItem = cbb_UnitCaculator.Text.ToString();
            unitTime = cbb_UnitTime.SelectedValue.ToString();

            cost = double.Parse(txt_Cost.Text);
            price = double.Parse(txt_Price.Text);
            shelfLife = num_ShelfLife.Text + unitTime;

            count = (int)num_Count.Value;
            status = (byte)(chk_Status.Checked ? 1 : 0);

            DTO_Product product = new DTO_Product(pathImage, nameProduct, idSupplier, idType, cost, price, count, shelfLife, unitItem, status, idProduct);

            int affectedRows = (new BLL_Product()).UpdateProduct(product);

            string mess = "";
            if (affectedRows > 0)
            {
                mess = $"Chỉnh sủa thông tin sản phẩm {nameProduct} thành công!!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
                CopyImageToFolderProject(pathImage);
                return;
            }
            else
            {
                mess = $"Chỉnh sủa thông tin sản phẩm {nameProduct} thất bại. Vui lòng thử lại!!";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (IsNotId())
            {
                return;
            }
            string idProduct, nameProduct;
            idProduct = txt_ID.Text;
            nameProduct = txt_NameProduct.Text;

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá sản phẩm {nameProduct}?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int affectedRows = (new BLL_Product()).UpdateStatusProduct(idProduct);
                    string mess = "";
                    if (affectedRows > 0)
                    {
                        mess = $"Xoá sản phẩm {nameProduct} thành công!!";
                        MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGridView();
                        return;
                    }
                    else
                    {
                        mess = $"Xoá sản phẩm {nameProduct} thất bại. Vui lòng thử lại!!";
                        MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            pic_Product.ImageLocation = null;
            txt_ID.Clear();
            txt_NameProduct.Clear();
            cbb_Supplier.SelectedIndex = 0;
            cbb_TypeProduct.SelectedIndex = 0;
            cbb_UnitCaculator.SelectedIndex = 0;
            cbb_UnitTime.SelectedIndex = 0;

            txt_Cost.Clear();
            txt_Price.Clear();
            

            num_Count.Value = 0;
            chk_Status.Checked = true;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string nameProduct = txt_Search.Text.Trim();
            LoadDataGridView(nameProduct);
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            DataTable tblProduct = (DataTable)dgv_ListProduct.DataSource;
            ConfigExcel_PDF.ExportToExcel(tblProduct, "Product");
            return;
        }
    }
}
