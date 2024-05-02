using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class ConfigExcel_PDF
    {
        public static void ExportToExcel(DataTable tbl, string sheetName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(tbl, sheetName);
                            wb.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public static void ImportToExcel(string path)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //using ()
                        //{
                        
                        //}
                        MessageBox.Show("Nhập thông tin từ file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static void PrintInvoice(Form invoice)
        {
          
        }
    }
}
