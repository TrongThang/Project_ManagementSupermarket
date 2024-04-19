﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace ManagementSupermarket.Manager
{
    public partial class frmDiscount : Form
    {
        public frmDiscount()
        {
            InitializeComponent();
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
        private int GetDayComboBox(string value, string key)
        {
            int i_value = int.Parse(value);
            int year = dtpTimeStart.Value.Year;
            if (key == "Ngày")
            {
                return i_value;
            }
            else if (key == "Tháng")
            {
                return i_value * getDayWithTime(i_value, year);
            }
            else
            {
                int day =  0;
                if(year % 4 == 0 || (year % 4 == 0 && year % 100 != 0))
                    day = 366;
                else
                    day = 365;

                return day * i_value;
            }
        }


    }
   
}
