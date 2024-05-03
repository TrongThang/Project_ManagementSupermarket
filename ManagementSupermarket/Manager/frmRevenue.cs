using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using BLL;

namespace ManagementSupermarket.Manager
{
    public partial class frm_Revenue : Form
    {
        public frm_Revenue()
        {
            InitializeComponent();
        }
        private void LoadDataRevenue(DateTime date, string citeria = null)
        {
                //COUNT(DISTINCT HD.MaHD) AS SLHD_Ban,
                //COUNT(DISTINCT NK.MaNK) AS SLHD_Nhap,
                //COUNT(CTHD.MaSP) AS SLSP_Ban,
                //COUNT(CTNK.MaSP) AS SLSP_Nhap,
                //COUNT(DISTINCT KM.MaKM) AS SLKM,
                //COUNT(DISTINCT NK.MaNCC) AS SLNCC,
                //COUNT(DISTINCT HD.MaNV) AS SLNV
            //COUNT REVENUE
            DataTable tblRevenue = BLL_Revenue.GetRevenue(date, citeria);

            if(tblRevenue.Rows.Count > 0) {
                DataRow rowRevenue = tblRevenue.Rows[0];

                lbl_Sell.Text = rowRevenue["SLHD_Ban"].ToString();
                lbl_Import.Text = rowRevenue["SLHD_Nhap"].ToString();
                lbl_ProductSell.Text = rowRevenue["SLSP_Ban"].ToString();
                lbl_ProductImport.Text = rowRevenue["SLSP_Nhap"].ToString();
                lbl_Discount.Text = rowRevenue["SLKM"].ToString();
                lbl_Supplier.Text = rowRevenue["SLNCC"].ToString();
                lbl_Employee.Text = rowRevenue["SLNV"].ToString();
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
        }
    }
}
