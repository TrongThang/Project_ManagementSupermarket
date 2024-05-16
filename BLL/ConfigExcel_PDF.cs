using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;
using Paragraph = iTextSharp.text.Paragraph;
using DTO;
using System.Globalization;
using SixLabors.Fonts;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Drawing.Charts;
using DataTable = System.Data.DataTable;
using DocumentFormat.OpenXml.Presentation;
namespace BLL
{
    public class ConfigExcel_PDF
    {
        public static void ExportToExcel(DataTable tbl, string sheetName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel|*.xlsx", FileName = $"List {sheetName}" })
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

        public static string formatPrice(decimal price, string unit = "VNĐ")
        {
            if (price >= 1000)
                return price.ToString("#,##0", new CultureInfo("vi-VN")) + $" {unit}";
            else if (price <= 1000)
                return price.ToString("#,##0", new CultureInfo("vi-VN")) + $" {unit}";
            return Convert.ToInt64(price).ToString() + $" {unit}";
        }

        private static bool GenerateTableExportBill(string idInvoice, PdfPTable tbl)
        {
            //string fontPath = Path.Combine(Application.StartupPath, "..", "..", "Resources", "fonts", "SEGOEUI.TTF");
            string fontPath = Path.Combine(Application.StartupPath, "Resources", "fonts", "SEGOEUI.TTF");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10);
            iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);

            DataTable billDetails = (new BLL_Detail_InvoiceSelling()).GetDetailInvoiceSelling("MaHD", idInvoice);
            int count = 1;
            foreach (DataRow detail in billDetails.Rows)
            {
                tbl.AddCell(new PdfPCell(new Phrase((count++).ToString())) { Border = iTextSharp.text.Rectangle.BOTTOM_BORDER, PaddingBottom = 5f, HorizontalAlignment = 0 });
                tbl.AddCell(new PdfPCell(new Phrase(detail["TenSP"].ToString(), font)) { Border = iTextSharp.text.Rectangle.BOTTOM_BORDER, PaddingBottom = 5f, HorizontalAlignment = 0 });
                tbl.AddCell(new PdfPCell(new Phrase(formatPrice((decimal)(detail["DonGia"]), ""), font)) { Border = iTextSharp.text.Rectangle.BOTTOM_BORDER, PaddingBottom = 5f, HorizontalAlignment = 0 });
                tbl.AddCell(new PdfPCell(new Phrase(detail["SL"].ToString(), font)) { Border = iTextSharp.text.Rectangle.BOTTOM_BORDER, PaddingBottom = 5f, HorizontalAlignment = 1 });
                tbl.AddCell(new PdfPCell(new Phrase(formatPrice((decimal)(detail["ThanhTien"]), ""), font)) { Border = iTextSharp.text.Rectangle.BOTTOM_BORDER, PaddingBottom = 5f, HorizontalAlignment = 2 });
            }
            return true;
        }
        public static bool PrintInvoicePDF(DTO_InvoiceSelling bill)
        {
            bool check = false;
            // Mở hộp thoại để chọn nơi lưu file PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            saveFileDialog.FileName = $"HoaDon_{bill.S_IdInvoice}.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                check = true;
            else
                check = false;

            string filePath = saveFileDialog.FileName;
            if (check && File.Exists(filePath) == false)
            {
                // Tạo file PDF
                FileStream stream = new FileStream(filePath, FileMode.Create);
                Document document = new Document(PageSize.A6, 10f, 10f, 10f, 10f);
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                // Tạo font cho nội dung
                //string fontPath = Path.Combine(Application.StartupPath, "..", "..", "Resources", "fonts", "SEGOEUI.TTF");
                
                string fontPath = Path.Combine(Application.StartupPath, "Resources", "fonts", "SEGOEUI.TTF");

                BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10);
                iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);

                // Thêm tiêu đề
                Paragraph title = new Paragraph("SIÊU THỊ MINI TQ\nHÓA ĐƠN\n\n", font);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // Tạo header
                PdfPTable headerTable = new PdfPTable(2);
                headerTable.WidthPercentage = 100;
                headerTable.SetWidths(new float[] { 4, 6 });
                headerTable.SpacingAfter = 10f;
                headerTable.SpacingBefore = 10f;

                // Lấy Tên NV và Tên KH
                string nameCustomer = "";
                if(bill.S_IdCustomer != null)
                {
                    nameCustomer = ((new BLL_Customer()).GetCustomerTo("MaKH", bill.S_IdCustomer).Rows[0]["HoTen"] ?? "").ToString();
                }
                string nameEmployee = ((new BLL_Employee()).GetEmployeeTo("MaNV", bill.S_IdEmployee).Rows[0]["HoTen"] ?? "").ToString();

                // Thêm đoạn văn bản vào các ô của bảng
                headerTable.AddCell(new PdfPCell(new Phrase($"MÃ HÓA ĐƠN: {bill.S_IdInvoice}", font)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                headerTable.AddCell(new PdfPCell(new Phrase($"NGÀY LẬP: {bill.Dt_CreatedTime.ToString("dd/MM/yyyy HH:mm:ss")}", font)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                // Thêm bảng vào tài liệu
                document.Add(headerTable);
                
                Paragraph user = new Paragraph($"Nhân viên lập: {nameEmployee}\n", font);
                document.Add(user);

                Paragraph customer = new Paragraph($"Tên khách hàng: {nameCustomer}", font);
                document.Add(customer);


                // Tạo bảng chi tiết hóa đơn
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 1, 4, 2, 1, 2 });
                table.SpacingAfter = 10f;
                table.SpacingBefore = 10f;

                // Tạo cell cho header cột
                table.AddCell(new PdfPCell(new Phrase("STT", font)) { Border = iTextSharp.text.Rectangle.BOTTOM_BORDER, PaddingBottom = 5f, HorizontalAlignment = 0 });
                table.AddCell(new PdfPCell(new Phrase("Tên sản phẩm", font)) { Border = iTextSharp.text.Rectangle.BOTTOM_BORDER, PaddingBottom = 5f, HorizontalAlignment = 0 });
                table.AddCell(new PdfPCell(new Phrase("Đơn giá", font)) { Border = iTextSharp.text.Rectangle.BOTTOM_BORDER, PaddingBottom = 5f, HorizontalAlignment = 0 });
                table.AddCell(new PdfPCell(new Phrase("SL", font)) { Border = iTextSharp.text.Rectangle.BOTTOM_BORDER, PaddingBottom = 5f, HorizontalAlignment = 1 });
                table.AddCell(new PdfPCell(new Phrase("Thành tiền", font)) { Border = iTextSharp.text.Rectangle.BOTTOM_BORDER, PaddingBottom = 5f, HorizontalAlignment = 2 });

                // Thêm dữ liệu vào bảng
                GenerateTableExportBill(bill.S_IdInvoice , table);

                document.Add(table);

                //Thêm footer
                PdfPTable footerTable = new PdfPTable(5);
                footerTable.SetWidths(new float[] { 1, 4, 2, 1, 2 });
                footerTable.WidthPercentage = 100;

                footerTable.AddCell(new PdfPCell(new Phrase("Tổng tiền:", font)) { Border = iTextSharp.text.Rectangle.NO_BORDER, Colspan = 3, HorizontalAlignment = 2, FixedHeight = 15f });
                footerTable.AddCell(new PdfPCell(new Phrase($"{formatPrice((decimal)bill.D_TotalPrice)}", font)) { Border = iTextSharp.text.Rectangle.NO_BORDER, Colspan = 2, HorizontalAlignment = 2, FixedHeight = 15f });
                footerTable.AddCell(new PdfPCell(new Phrase("Tiền gửi:", font)) { Border = iTextSharp.text.Rectangle.NO_BORDER, Colspan = 3, HorizontalAlignment = 2, FixedHeight = 15f });
                footerTable.AddCell(new PdfPCell(new Phrase($"{formatPrice((decimal)(bill.D_CashCustomer))}", font)) { Border = iTextSharp.text.Rectangle.NO_BORDER, Colspan = 2, HorizontalAlignment = 2, FixedHeight = 15f });
                footerTable.AddCell(new PdfPCell(new Phrase("Tiền thừa:", font)) { Border = iTextSharp.text.Rectangle.NO_BORDER, Colspan = 3, HorizontalAlignment = 2, FixedHeight = 15f });
                footerTable.AddCell(new PdfPCell(new Phrase($"{formatPrice( (decimal)(bill.D_CashCustomer - bill.D_TotalPrice) )}", font)) { Border = iTextSharp.text.Rectangle.NO_BORDER, Colspan = 2, HorizontalAlignment = 2, FixedHeight = 15f });

                document.Add(footerTable);
                //Thêm kết bill
                Paragraph wish = new Paragraph("\n---------------------------------------------\nChúc quý khách vui vẻ, hẹn gặp lại!", font);
                wish.Alignment = Element.ALIGN_CENTER;

                document.Add(wish);

                document.Close();
            }
            return check;
        }
    }
}
