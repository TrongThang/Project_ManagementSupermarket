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
    public partial class frmHomeOfManager : Form
    {
        private string s_role;
        public frmHomeOfManager(string role)
        {
            s_role = role;
            InitializeComponent();
        }
        public frmHomeOfManager()
        {
            InitializeComponent();
        }
    }
}
