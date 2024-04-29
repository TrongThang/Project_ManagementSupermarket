using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace ManagementSupermarket.Manager
{
    public partial class frmRevenue : Form
    {
        public frmRevenue()
        {
            InitializeComponent();
        }
        private void LoadCriteria_Week()
        {
        }
        private string IsMoney(string key, int value)
        {
            DataTable res = (new BLL_InvoiceSelling()).GetRevenue(key, value);

            string money = "0";
            if(res.Rows.Count > 0)
            {
                money = res.Rows[0][0].ToString();
            }
            return money;
        }
        private void LoadCriteria_Month()
        {
            for (int i = 0; i < 11; i++)
            {
                string money = IsMoney("Tháng", i + 1);
              
                chart_Revenue.Series["Salary"].Points.AddXY($"Tháng {i + 1}", money);
            }
        }
        private void LoadCriteria_Quarter()
        {
            for (int i = 0; i < 4; i++)
            {
                string money = IsMoney("Quý", i + 1);

                chart_Revenue.Series["Salary"].Points.AddXY($"Quý {i + 1}", money);
            }
        }
        private void cbb_Criteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_Criteria.Text == "Tháng")
            {
                LoadCriteria_Month();
            }else if(cbb_Criteria.Text == "Quý")
            {
                LoadCriteria_Quarter();
            }
        }

        private void frmRevenue_Load(object sender, EventArgs e)
        {

        }
    }
}
