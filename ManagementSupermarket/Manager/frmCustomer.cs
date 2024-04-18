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
using BLL;
using DTO;

namespace ManagementSupermarket
{
    public partial class frmCustomer : Form
    {
        Event eventConfig = new Event();
        BLL_Customer dataCustomer = new BLL_Customer();
        public frmCustomer()
        {
            InitializeComponent();
        }
        private void PressNumber(object sender, KeyPressEventArgs e)
        {
            eventConfig.PressNumber(sender, e);
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            
        }
        private bool IsEmptytTextBox(string fullName, string CCCD, string phone , string address)
        {
            bool flag = false;
            string notEmpty = " không được bỏ trống";
            if (eventConfig.IsNullOrEmpty(fullName))
            {
                eventConfig.SetErrorLabel(lbl_ErrorName, "Tên", notEmpty);
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(CCCD))
            {
                eventConfig.SetErrorLabel(lbl_ErrorCCCD, "Căn cước công dân", notEmpty);
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(phone))
            {
                eventConfig.SetErrorLabel(lbl_ErrorPhone, "Số điện thoại", notEmpty);
                flag = true;
            }
            if (eventConfig.IsNullOrEmpty(address))
            {
                eventConfig.SetErrorLabel(lbl_ErrorAddress, "Địa chỉ", notEmpty);
                flag = true;
            }
            return flag;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string fullName = txt_FullName.Text.Trim();
            string CCCD = txt_CCCD.Text.Trim();
            string phone=txt_Phone.Text.Trim();
            string address = txt_Address.Text.Trim();
            DateTime createdTime = dtp_CreatedTime.Value;
            string gender = rad_Male.Checked ? "Nam" : "Nữ";
            byte status = (byte)(chk_Status.Checked ? 1 : 0);
            bool isEmpty = IsEmptytTextBox(fullName, CCCD, phone, address);
            if (isEmpty)
            {
                return;
            }
            DTO_Customer customer = new DTO_Customer(fullName,CCCD,phone,gender,address,createdTime,status);
            int numOfRows = dataCustomer.InsertCustomer(customer);
            if (numOfRows > 0)
            {
                string mess = "Thêm thành công nhân viên";
                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
