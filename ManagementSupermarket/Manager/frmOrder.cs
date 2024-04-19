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
    public partial class frmOrder : Form
    {
        private string idEmployee;
        public frmOrder()
        {
            InitializeComponent();
        }
        public frmOrder(string idEmployee)
        {
            this.idEmployee = idEmployee;
            InitializeComponent();
        }


    }
}
