using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Xml.Serialization;
using BLL;
using DTO;
using static System.Net.Mime.MediaTypeNames;

namespace ManagementSupermarket.Manager
{
    public partial class frmTypeProduct : Form
    {
        Event eventConfig = new Event();
        BLL_TypeProduct dataTypeProduct = new BLL_TypeProduct();
        public frmTypeProduct()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgv_TypeProduct.DataSource = dataTypeProduct.GetTypeProduct("MaLoaiSP");
        }

        private void frmTypeProduct_Load(object sender, EventArgs e)
        {
            LoadData();
            cbb_SearchRole.SelectedIndex = 0;
        }
        private bool IsEmptytTextBox(string nameType, string desc)
        {
            bool flag = false;
            string notEmpty = " không bỏ trống";
            if (eventConfig.IsNullOrEmpty(nameType))
            {
                eventConfig.SetErrorLabel(lbl_ErrorName, "Tên loại sản phẩm", notEmpty);
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(desc))
            {
                eventConfig.SetErrorLabel(lbl_ErrorDescribe, "Mô tả", notEmpty);
                flag = true;
            }
            return flag;

        }
        private void On_OffLabelError(int option)
        {
            if (option == 0)
            {
                lbl_ErrorName.Visible = false;
                lbl_ErrorDescribe.Visible = false;
               
                return;
            }
            lbl_ErrorName.Visible = true;
            lbl_ErrorDescribe.Visible = true;

        }
        private bool ExistName(string NameType)
        {
            bool existName = (new BLL_TypeProduct()).GetTypeProduct("TenLoai", NameType).Rows.Count > 0;
            if (existName)
            {
                MessageBox.Show($"Loại sản phẩm có tên: {NameType} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return existName;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                On_OffLabelError(0);
                string nameType = txt_NameType.Text.Trim();
                string desc = txt_Desc.Text.Trim();
                bool isEmpty = IsEmptytTextBox(nameType, desc);
                if (isEmpty)
                {
                    return;
                }
                else if (ExistName(nameType))
                {
                    return;
                }
                DTO_TypeProduct typeProduct = new DTO_TypeProduct(nameType, desc);
                int numOfRows = dataTypeProduct.InsertTypeProduct(typeProduct);
                if (numOfRows > 0)
                {
                    string mess = "Thêm loại sản phẩm thành công";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    string mess = "Thêm loại sản phẩm thất bại";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgv_TypeProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCellCollection rowSelected = dgv_TypeProduct.SelectedRows[0].Cells;
                if (rowSelected.Count > 0)
                {
                    txt_ID.Text = rowSelected["MaLoaiSP"].Value.ToString();
                    txt_NameType.Text = rowSelected["TenLoai"].Value.ToString();
                    txt_Desc.Text = rowSelected["MoTa"].Value.ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btn_Alter_Click(object sender, EventArgs e)
        {
            try
            {
                On_OffLabelError(0);
                string id = txt_ID.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    string mess = "Vui lòng chọn loại sản phẩm muốn chỉnh sửa";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string nameType = txt_NameType.Text.Trim();
                string desc = txt_Desc.Text.Trim();

                bool isEmpty = IsEmptytTextBox(nameType, desc);
                if (isEmpty)
                {
                    return;

                }
                DTO_TypeProduct typeProduct = new DTO_TypeProduct(nameType, desc, id);
                int numOfRows = dataTypeProduct.UpdateTypeProduct(typeProduct);
                if (numOfRows > 0)
                {
                    string mess = "Chỉnh sửa thông tin loại sản phẩm thành công";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    string mess = "Chỉnh sửa thông tin loại sản phẩm thất bại";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txt_ID.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    string mess = "Vui lòng chọn loại sản phẩm muốn chỉnh sửa";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int numOfRows = dataTypeProduct.UpdateStatusTypeProduct(id);
                if (numOfRows > 0)
                {
                    string mess = "Xoá thông tin loại sản phẩm thành công";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    string mess = "Xoá thông tin loại sản phẩm thất bại";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_ID.Clear();
            txt_NameType.Clear();
            txt_Desc.Clear();
            txt_Search.Clear();
            On_OffLabelError(0);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string text = string.IsNullOrEmpty(txt_Search.Text) ? null : txt_Search.Text;
                dgv_TypeProduct.DataSource = dataTypeProduct.GetTypeProduct(cbb_SearchRole.Text, text);
                dgv_TypeProduct.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
