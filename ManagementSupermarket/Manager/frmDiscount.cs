using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace ManagementSupermarket.Manager
{
    public partial class frmDiscount : Form
    {
        Event eventConfig = new Event();
        BLL_Discount dataDiscount =new BLL_Discount();
        public frmDiscount()
        {
            InitializeComponent();
        }
        private void PressNumber(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số, dấu chấm thập phân và phím Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu thập phân
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu phẩy thập phân
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            // Nếu người dùng nhập dấu phân tách thập phân là dấu chấm, chuyển thành dấu phẩy
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

        }
        private void LoadData()
        {
            if (chk_DiscountStatus.Checked == true)
            {
                dgv_ListDiscount.DataSource = dataDiscount.GetDiscountToday();
                return;
            }
            
                dgv_ListDiscount.DataSource = dataDiscount.GetDiscount("MaKM");
        }

        private int getDayWithTime(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if (year % 4 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
            }
            return 30;
        }
        private int CaculatorDayComboBox(int value, string key)
        {
            int year = dtpTimeStart.Value.Year;
            if (key == "Ngày")
            {
                return value;
            }
            else if (key == "Tháng")
            {
                return value * getDayWithTime(value, year);
            }
            else
            {
                int day = 0;
                for(int i = 0; i < value; i++)
                {
                    if (year % 4 == 0 || (year % 4 == 0 && year % 100 != 0))
                        day += 366;
                    else
                        day += 365;
                }
                return day * value;
            }
        }
        private DateTime CalculateEndDate(DateTime startDate, int duration, string unit)
        {
            DateTime endDate = startDate;

            switch (unit)
            {
                case "Ngày":
                    endDate = startDate.AddDays(duration);
                    break;
                case "Tháng":
                    endDate = startDate.AddMonths(duration);
                    break;
                case "Năm":
                    endDate = startDate.AddYears(duration);
                    break;
                default:
                    break;
            }

            return endDate;
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            LoadData();
            cbb_SearchRole.SelectedIndex = 0;
            cbb_UnitTime.SelectedIndex = 0;
        }
        private bool IsEmptytTextBox(string id, string nameDiscount,double  priceDiscount)
        {
            bool flag = false;
            string notEmpty = " không bỏ trống";
            if (eventConfig.IsNullOrEmpty(id))
            {
                eventConfig.SetErrorLabel(lbl_Id, "Mã khuyến mãi", notEmpty);
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(nameDiscount))
            {
                eventConfig.SetErrorLabel(lbl_Name, "Tên khuyến mãi", notEmpty);
                flag = true;
            }
            if (priceDiscount==0)
            {
                eventConfig.SetErrorLabel(lbl_PriceDiscount, "Giá  khuyến mãi", notEmpty);
                flag = true;
            }
            if(num_CountTime.Value==0)
            {
                eventConfig.SetErrorLabel(lbl_ErrorTimeEnd, "Thời hạn", notEmpty);
                flag = true;
            }

            return flag;
        }
        private void On_OffLabelError(int option)
        {
            if (option == 0)
            {
                lbl_Id.Visible = false;
                lbl_Name.Visible = false;
                lbl_PriceDiscount.Visible = false;
                lbl_ErrorTimeEnd.Visible = false;
                return;
            }
            lbl_Id.Visible = true;
            lbl_Name.Visible = true;
            lbl_PriceDiscount.Visible = true;
            lbl_ErrorTimeEnd.Visible = true;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            On_OffLabelError(0);
            string id = txt_ID.Text.Trim();

            try
            {
                string nameDiscount = txt_NameDiscount.Text.Trim();
                double priceDiscount = 0;
                // Kiểm tra nếu giá khuyến mãi được nhập và có thể chuyển đổi thành double
                if (!string.IsNullOrEmpty(txt_PriceDiscount.Text.Trim()))
                {
                    if (double.TryParse(txt_PriceDiscount.Text.Trim(), out priceDiscount))
                    {
                        // Giá khuyến mãi có thể chuyển đổi thành double
                        priceDiscount = double.Parse(txt_PriceDiscount.Text.Trim());
                    }
                }
                DateTime starDay = dtpTimeStart.Value;

                int thoiHan = (int)num_CountTime.Value;
                string donViThoiHan = cbb_UnitTime.SelectedItem.ToString();
                DateTime endDay = CalculateEndDate(starDay, thoiHan, donViThoiHan);

                bool isEmpty = IsEmptytTextBox(id, nameDiscount, priceDiscount);

                if (isEmpty)
                {
                    return;
                }
                // Gọi phương thức GetDiscount từ đối tượng BLL_Discount để kiểm tra tồn tại mã khuyến mãi
                DataTable dt = dataDiscount.GetDiscount("MaKM", id);

                // Kiểm tra số hàng trong bảng để xác định mã khuyến mãi có tồn tại hay không
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã khuyến mãi đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (priceDiscount == 0)
                {
                    lbl_PriceDiscount.Visible = true;
                }

                DTO_Discount discount = new DTO_Discount(id, nameDiscount, priceDiscount, starDay, endDay);
                int numOfRows = dataDiscount.InsertDiscount(discount);
                if (numOfRows > 0)
                {
                    string mess = "Thêm khuyến mãi thành công";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    string mess = "Thêm khuyến mãi thất bại";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string mess = "Vui lòng chọn khuyến mãi muốn chỉnh sửa";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string nameDiscount = txt_NameDiscount.Text.Trim();
                double priceDiscount = 0;
                // Kiểm tra nếu giá khuyến mãi được nhập và có thể chuyển đổi thành double
                if (!string.IsNullOrEmpty(txt_PriceDiscount.Text.Trim()))
                {
                    if (double.TryParse(txt_PriceDiscount.Text.Trim(), out priceDiscount))
                    {
                        // Giá khuyến mãi có thể chuyển đổi thành double
                        priceDiscount = double.Parse(txt_PriceDiscount.Text.Trim());
                    }
                }
                DateTime starDay = dtpTimeStart.Value;
                //int thoiHan = CaculatorDayComboBox((int)num_CountTime.Value, cbb_UnitTime.SelectedItem.ToString());
                int thoiHan = (int)num_CountTime.Value;
                string donViThoiHan = cbb_UnitTime.SelectedItem.ToString();
                DateTime endDay = CalculateEndDate(starDay, thoiHan, donViThoiHan);
                bool isEmpty = IsEmptytTextBox(id, nameDiscount, priceDiscount);

                if (isEmpty)
                {
                    return;
                }
                DTO_Discount discount = new DTO_Discount(id, nameDiscount, priceDiscount, starDay, endDay);
                int numOfRows = dataDiscount.UpdateDiscount(discount);
                if (numOfRows > 0)
                {
                    string mess = "Chỉnh sửa thông tin khuyến mãi thành công";
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    string mess = "Chỉnh sửa thông tin khuyến mãi thất bại";
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
            txt_NameDiscount.Clear();
            txt_PriceDiscount.Clear();
            dtpTimeStart.Value = DateTime.Now;
            num_CountTime.Value = 0;
            cbb_UnitTime.SelectedIndex = 0;
            On_OffLabelError(0);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string text =string.IsNullOrEmpty(txt_Search.Text)?null:txt_Search.Text;
            dgv_ListDiscount.DataSource = dataDiscount.GetDiscount(cbb_SearchRole.Text, text);
            dgv_ListDiscount.Refresh();
        }

        private void dgv_ListDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCellCollection rowSelected = dgv_ListDiscount.SelectedRows[0].Cells;
                if (rowSelected.Count > 0)
                {
                    txt_ID.Text = rowSelected["MaKM"].Value.ToString();
                    txt_NameDiscount.Text = rowSelected["TenKM"].Value.ToString();
                    txt_PriceDiscount.Text = rowSelected["GiaKhuyenMai"].Value.ToString();
                    dtpTimeStart.Value = DateTime.Parse(rowSelected["NgayBatDau"].Value.ToString());

                    DateTime endDate = DateTime.Parse(rowSelected["NgayKetThuc"].Value.ToString());
                    TimeSpan duration = endDate - dtpTimeStart.Value;
                    int days = (int)duration.TotalDays;

                    if (days > 365)
                    {
                        cbb_UnitTime.SelectedItem = "Năm";
                        num_CountTime.Value = days / 365;
                    }
                    else if (days > 30)
                    {
                        cbb_UnitTime.SelectedItem = "Tháng";
                        num_CountTime.Value = days / 30;
                    }
                    else
                    {
                        cbb_UnitTime.SelectedItem = "Ngày";
                        num_CountTime.Value = days;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void chk_DiscountStatus_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
   
}
