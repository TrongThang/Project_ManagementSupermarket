using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using BLL;
using FontAwesome.Sharp;

namespace ManagementSupermarket.Manager
{
    public partial class frm_Revenue : Form
    {
        public frm_Revenue()
        {
            InitializeComponent();
        }
        public static string formatPrice(decimal price, string unit = "VNĐ")
        {
            if (price >= 1000)
                return price.ToString("#,##0", new CultureInfo("vi-VN")) + $" {unit}";
            else if(price <= 1000)
                return price.ToString("#,##0", new CultureInfo("vi-VN")) + $" {unit}";
            return Convert.ToInt64(price).ToString() + $" {unit}";
        }

        private string TextIsNullOrEmpty(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "0";
            }
            return str;
        }
        private void ChangedIconChar(decimal dec)
        {
            if (dec < 0)
            {
                btn_Revenue.IconChar = IconChar.CaretDown;
            }else if(dec == 0) { 
                btn_Revenue.IconChar = IconChar.Buffer;
            }
            else
            {
                btn_Revenue.IconChar= IconChar.CaretUp;
            }
            
        }
        private void LoadDataRevenue(DateTime date, string citeria = null)
        {
            //DoanhThu, TienBanSP, TienNhapSPSLHD_Ban, SLHD_Nhap, SLSP_Ban, SLSP_Nhap, SLKM, SLNCC, SLNV
            //COUNT REVENUE
            try
            {
                DataTable tblRevenue = BLL_Revenue.GetRevenue(date, citeria);

                if (tblRevenue.Rows.Count > 0)
                {
                    DataRow rowRevenue = tblRevenue.Rows[0];

                    lbl_Sell.Text = (rowRevenue["SLHD_Ban"] != null ? rowRevenue["SLHD_Ban"] : 0).ToString();
                    lbl_Import.Text = (rowRevenue["SLHD_Nhap"] != null ? rowRevenue["SLHD_Nhap"] : 0).ToString();
                    lbl_ProductSell.Text = (rowRevenue["SLSP_Ban"] != null ? rowRevenue["SLHD_Ban"] : 0).ToString();
                    lbl_ProductImport.Text = (rowRevenue["SLSP_Nhap"] != null ? rowRevenue["SLSP_Nhap"] : 0).ToString();
                    lbl_Discount.Text = (rowRevenue["SLKM"] != null ? rowRevenue["SLKM"] : 0).ToString();
                    lbl_Supplier.Text = (rowRevenue["SLNCC"] != null ? rowRevenue["SLNCC"] : 0).ToString();
                    lbl_Employee.Text = (rowRevenue["SLNV"] != null ? rowRevenue["SLNV"] : 0).ToString();

                    decimal totalSell = decimal.Parse(TextIsNullOrEmpty(rowRevenue["TienBanSP"].ToString()));
                    decimal totalImport = decimal.Parse(TextIsNullOrEmpty(rowRevenue["TienNhapSP"] .ToString()));
                    decimal revenue = totalSell - totalImport;

                    lbl_Total.Text = formatPrice(revenue);
                    lbl_MoneySell.Text = formatPrice(totalSell);
                    lbl_MoneyImort.Text = formatPrice(totalImport);

                    ChangedIconChar(revenue);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtp_Revenue_ValueChanged(object sender, EventArgs e)
        {
            LoadDataRevenue(dtp_Revenue.Value, cbb_Criteria.Text);
        }

        private void cbb_Criteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataRevenue(dtp_Revenue.Value, cbb_Criteria.Text);
        }

        private void frmRevenue_Load(object sender, EventArgs e)
        {
            LoadDataRevenue(DateTime.Now, "Ngày");
            cbb_Criteria.SelectedIndex = 0;
        }
    }
}
