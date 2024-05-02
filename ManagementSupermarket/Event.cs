using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSupermarket
{
    internal class Event
    {
        public void PressNumber(object sender, KeyPressEventArgs e)
        {
            bool IsNotNumber = !char.IsDigit(e.KeyChar)
                               && !char.IsControl(e.KeyChar);
            if(IsNotNumber)
            {
                e.Handled = true;
            }
        }

        public bool IsNullOrEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }
        public void SetErrorLabel(Label label, string key, string error)
        {
            label.Text = "*" + key + error;
            label.Visible = true;
        }
        public void CheckTextboxError(TextBox textBox,string error)
        {
            bool isError = string.IsNullOrEmpty(textBox.Text.Trim());

            if(isError)
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string ProcessMoney(string number)
        {
            if(string.IsNullOrEmpty(number) == false)
            {
                double money = double.Parse(number);
                return money.ToString("N", CultureInfo.CreateSpecificCulture("vi-VN"));
            }
            return number;
        }
    }
}
