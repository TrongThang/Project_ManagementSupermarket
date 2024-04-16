using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ManagementSupermarket
{
    public partial class frmManagementEmployees : Form
    {
        public frmManagementEmployees()
        {
            InitializeComponent();
        }

        private void frmManagementEmployee_Load(object sender, EventArgs e)
        {
            cbb_SearchRole.SelectedIndex = 0;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DAL_Employee employee = new DAL_Employee();
            string text = string.IsNullOrEmpty(txt_Search.Text) ? null : txt_Search.Text;
            
            dgv_ListEmployee.DataSource = employee.GetEmployeeTo(cbb_SearchRole.Text, text);
            dgv_ListEmployee.Refresh();
        }
    }
}
