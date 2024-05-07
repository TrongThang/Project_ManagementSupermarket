namespace ManagementSupermarket.Manager
{
    partial class frm_Revenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbb_Criteria = new System.Windows.Forms.ComboBox();
            this.dtp_Revenue = new System.Windows.Forms.DateTimePicker();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.btn_Revenue = new FontAwesome.Sharp.IconButton();
            this.lbl_Sell = new System.Windows.Forms.Label();
            this.lbl_Import = new System.Windows.Forms.Label();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_ProductSell = new System.Windows.Forms.Label();
            this.lbl_Employee = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_ProductImport = new System.Windows.Forms.Label();
            this.lbl_MoneySell = new System.Windows.Forms.Label();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MoneyImort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbb_Criteria
            // 
            this.cbb_Criteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Criteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbb_Criteria.FormattingEnabled = true;
            this.cbb_Criteria.Items.AddRange(new object[] {
            "Ngày",
            "Tuần",
            "Tháng",
            "Quý",
            "Năm"});
            this.cbb_Criteria.Location = new System.Drawing.Point(841, 16);
            this.cbb_Criteria.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbb_Criteria.Name = "cbb_Criteria";
            this.cbb_Criteria.Size = new System.Drawing.Size(106, 37);
            this.cbb_Criteria.TabIndex = 1;
            this.cbb_Criteria.SelectedIndexChanged += new System.EventHandler(this.cbb_Criteria_SelectedIndexChanged);
            // 
            // dtp_Revenue
            // 
            this.dtp_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Revenue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Revenue.Location = new System.Drawing.Point(959, 16);
            this.dtp_Revenue.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dtp_Revenue.Name = "dtp_Revenue";
            this.dtp_Revenue.Size = new System.Drawing.Size(204, 36);
            this.dtp_Revenue.TabIndex = 2;
            this.dtp_Revenue.ValueChanged += new System.EventHandler(this.dtp_Revenue_ValueChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 100;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton1.Location = new System.Drawing.Point(97, 60);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(348, 168);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "BÁN HÀNG";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Magenta;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 100;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton2.Location = new System.Drawing.Point(455, 60);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(348, 168);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.Text = "NHẬP KHO";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Yellow;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 100;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton3.Location = new System.Drawing.Point(455, 242);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(348, 168);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = "SẢN PHẨM BÁN";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 100;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton4.Location = new System.Drawing.Point(101, 416);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(348, 156);
            this.iconButton4.TabIndex = 7;
            this.iconButton4.Text = "KHUYẾN MÃI";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.PeachPuff;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 100;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton5.Location = new System.Drawing.Point(97, 242);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(348, 168);
            this.iconButton5.TabIndex = 8;
            this.iconButton5.Text = "NHÀ CUNG CẤP";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.Salmon;
            this.iconButton6.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 100;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton6.Location = new System.Drawing.Point(815, 63);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton6.Size = new System.Drawing.Size(348, 168);
            this.iconButton6.TabIndex = 9;
            this.iconButton6.Text = "NHÂN VIÊN";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton7.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 100;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton7.Location = new System.Drawing.Point(815, 242);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton7.Size = new System.Drawing.Size(348, 168);
            this.iconButton7.TabIndex = 10;
            this.iconButton7.Text = "SẢN PHẨM NHẬP";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // btn_Revenue
            // 
            this.btn_Revenue.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Revenue.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Revenue.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.btn_Revenue.IconColor = System.Drawing.Color.Black;
            this.btn_Revenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Revenue.IconSize = 100;
            this.btn_Revenue.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Revenue.Location = new System.Drawing.Point(101, 578);
            this.btn_Revenue.Name = "btn_Revenue";
            this.btn_Revenue.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btn_Revenue.Size = new System.Drawing.Size(1062, 137);
            this.btn_Revenue.TabIndex = 11;
            this.btn_Revenue.Text = "TỔNG DOANH THU CỦA CỬA HÀNG";
            this.btn_Revenue.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Revenue.UseVisualStyleBackColor = false;
            // 
            // lbl_Sell
            // 
            this.lbl_Sell.AutoSize = true;
            this.lbl_Sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sell.Location = new System.Drawing.Point(120, 146);
            this.lbl_Sell.Name = "lbl_Sell";
            this.lbl_Sell.Size = new System.Drawing.Size(54, 58);
            this.lbl_Sell.TabIndex = 12;
            this.lbl_Sell.Text = "0";
            // 
            // lbl_Import
            // 
            this.lbl_Import.AutoSize = true;
            this.lbl_Import.BackColor = System.Drawing.Color.Magenta;
            this.lbl_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Import.Location = new System.Drawing.Point(478, 146);
            this.lbl_Import.Name = "lbl_Import";
            this.lbl_Import.Size = new System.Drawing.Size(54, 58);
            this.lbl_Import.TabIndex = 12;
            this.lbl_Import.Text = "0";
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.Location = new System.Drawing.Point(120, 325);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(54, 58);
            this.lbl_Supplier.TabIndex = 12;
            this.lbl_Supplier.Text = "0";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(115, 639);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(54, 58);
            this.lbl_Total.TabIndex = 12;
            this.lbl_Total.Text = "0";
            // 
            // lbl_ProductSell
            // 
            this.lbl_ProductSell.AutoSize = true;
            this.lbl_ProductSell.BackColor = System.Drawing.Color.Yellow;
            this.lbl_ProductSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductSell.Location = new System.Drawing.Point(478, 325);
            this.lbl_ProductSell.Name = "lbl_ProductSell";
            this.lbl_ProductSell.Size = new System.Drawing.Size(54, 58);
            this.lbl_ProductSell.TabIndex = 12;
            this.lbl_ProductSell.Text = "0";
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.AutoSize = true;
            this.lbl_Employee.BackColor = System.Drawing.Color.Salmon;
            this.lbl_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee.Location = new System.Drawing.Point(838, 146);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(54, 58);
            this.lbl_Employee.TabIndex = 12;
            this.lbl_Employee.Text = "0";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(120, 495);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(54, 58);
            this.lbl_Discount.TabIndex = 12;
            this.lbl_Discount.Text = "0";
            // 
            // lbl_ProductImport
            // 
            this.lbl_ProductImport.AutoSize = true;
            this.lbl_ProductImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_ProductImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductImport.Location = new System.Drawing.Point(842, 325);
            this.lbl_ProductImport.Name = "lbl_ProductImport";
            this.lbl_ProductImport.Size = new System.Drawing.Size(54, 58);
            this.lbl_ProductImport.TabIndex = 12;
            this.lbl_ProductImport.Text = "0";
            // 
            // lbl_MoneySell
            // 
            this.lbl_MoneySell.AutoSize = true;
            this.lbl_MoneySell.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_MoneySell.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoneySell.Location = new System.Drawing.Point(570, 465);
            this.lbl_MoneySell.Name = "lbl_MoneySell";
            this.lbl_MoneySell.Size = new System.Drawing.Size(40, 42);
            this.lbl_MoneySell.TabIndex = 12;
            this.lbl_MoneySell.Text = "0";
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iconButton9.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.iconButton9.IconColor = System.Drawing.Color.Black;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 100;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButton9.Location = new System.Drawing.Point(455, 416);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton9.Size = new System.Drawing.Size(708, 156);
            this.iconButton9.TabIndex = 13;
            this.iconButton9.Text = "TỔNG DOANH THU CỦA CỬA HÀNG";
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton9.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nhập:";
            // 
            // lbl_MoneyImort
            // 
            this.lbl_MoneyImort.AutoSize = true;
            this.lbl_MoneyImort.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_MoneyImort.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoneyImort.Location = new System.Drawing.Point(570, 511);
            this.lbl_MoneyImort.Name = "lbl_MoneyImort";
            this.lbl_MoneyImort.Size = new System.Drawing.Size(40, 42);
            this.lbl_MoneyImort.TabIndex = 12;
            this.lbl_MoneyImort.Text = "0";
            // 
            // frm_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 727);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ProductImport);
            this.Controls.Add(this.lbl_Employee);
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.lbl_ProductSell);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Supplier);
            this.Controls.Add(this.lbl_Import);
            this.Controls.Add(this.lbl_MoneyImort);
            this.Controls.Add(this.lbl_MoneySell);
            this.Controls.Add(this.lbl_Sell);
            this.Controls.Add(this.btn_Revenue);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.iconButton6);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dtp_Revenue);
            this.Controls.Add(this.cbb_Criteria);
            this.Controls.Add(this.iconButton9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frm_Revenue";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.frmRevenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbb_Criteria;
        private System.Windows.Forms.DateTimePicker dtp_Revenue;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton btn_Revenue;
        private System.Windows.Forms.Label lbl_Sell;
        private System.Windows.Forms.Label lbl_Import;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_ProductSell;
        private System.Windows.Forms.Label lbl_Employee;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_ProductImport;
        private System.Windows.Forms.Label lbl_MoneySell;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MoneyImort;
    }
}