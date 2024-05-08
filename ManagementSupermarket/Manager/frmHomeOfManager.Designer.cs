﻿namespace ManagementSupermarket
{
    partial class frmHomeOfManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeOfManager));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.panel_Avatar = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Info = new FontAwesome.Sharp.IconButton();
            this.btn_ChangePassword = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Avatar = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FlowPanel_Button = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Sell = new FontAwesome.Sharp.IconButton();
            this.btn_Employee = new FontAwesome.Sharp.IconButton();
            this.btn_Product = new FontAwesome.Sharp.IconButton();
            this.btn_TypeProduct = new FontAwesome.Sharp.IconButton();
            this.btn_Customer = new FontAwesome.Sharp.IconButton();
            this.btn_Supplier = new FontAwesome.Sharp.IconButton();
            this.btn_Discount = new FontAwesome.Sharp.IconButton();
            this.btn_WareHouse = new FontAwesome.Sharp.IconButton();
            this.btn_Revenue = new FontAwesome.Sharp.IconButton();
            this.btn_LogOut = new FontAwesome.Sharp.IconButton();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.btnContact = new FontAwesome.Sharp.IconButton();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_Top.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_Avatar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.FlowPanel_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(150)))));
            this.panel_Top.Controls.Add(this.panel2);
            this.panel_Top.Controls.Add(this.panel1);
            this.panel_Top.Controls.Add(this.pic_Logo);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1542, 146);
            this.panel_Top.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_Home);
            this.panel2.Controls.Add(this.panel_Avatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Sitka Display", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 146);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(579, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 72);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thắng - Quân";
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Sitka Display", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Home.Location = new System.Drawing.Point(3, 16);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(616, 121);
            this.lbl_Home.TabIndex = 7;
            this.lbl_Home.Text = "Siêu thị Mini TQ ";
            // 
            // panel_Avatar
            // 
            this.panel_Avatar.Controls.Add(this.btn_Info);
            this.panel_Avatar.Controls.Add(this.btn_ChangePassword);
            this.panel_Avatar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panel_Avatar.Location = new System.Drawing.Point(918, 15);
            this.panel_Avatar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel_Avatar.Name = "panel_Avatar";
            this.panel_Avatar.Size = new System.Drawing.Size(204, 121);
            this.panel_Avatar.TabIndex = 5;
            this.panel_Avatar.Visible = false;
            // 
            // btn_Info
            // 
            this.btn_Info.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Info.IconColor = System.Drawing.Color.Black;
            this.btn_Info.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Info.Location = new System.Drawing.Point(19, 1);
            this.btn_Info.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(182, 53);
            this.btn_Info.TabIndex = 0;
            this.btn_Info.Tag = "Info";
            this.btn_Info.Text = "Thông tin";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ChangePassword.IconColor = System.Drawing.Color.Black;
            this.btn_ChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ChangePassword.Location = new System.Drawing.Point(19, 56);
            this.btn_ChangePassword.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(182, 53);
            this.btn_ChangePassword.TabIndex = 1;
            this.btn_ChangePassword.Tag = "ChangePass";
            this.btn_ChangePassword.Text = "Đổi mật khẩu";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_Avatar);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1366, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 146);
            this.panel1.TabIndex = 5;
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.Image = global::ManagementSupermarket.Properties.Resources.avartaNam;
            this.pic_Avatar.Location = new System.Drawing.Point(39, 10);
            this.pic_Avatar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Size = new System.Drawing.Size(107, 93);
            this.pic_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Avatar.TabIndex = 3;
            this.pic_Avatar.TabStop = false;
            this.pic_Avatar.Click += new System.EventHandler(this.pic_Avatar_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.lbl_Name.Location = new System.Drawing.Point(3, 106);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(82, 30);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Họ Tên";
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(0, 0);
            this.pic_Logo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(244, 146);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 2;
            this.pic_Logo.TabStop = false;
            // 
            // FlowPanel_Button
            // 
            this.FlowPanel_Button.AutoScroll = true;
            this.FlowPanel_Button.Controls.Add(this.btn_Sell);
            this.FlowPanel_Button.Controls.Add(this.btn_Employee);
            this.FlowPanel_Button.Controls.Add(this.btn_Product);
            this.FlowPanel_Button.Controls.Add(this.btn_TypeProduct);
            this.FlowPanel_Button.Controls.Add(this.btn_Customer);
            this.FlowPanel_Button.Controls.Add(this.btn_Supplier);
            this.FlowPanel_Button.Controls.Add(this.btn_Discount);
            this.FlowPanel_Button.Controls.Add(this.btn_WareHouse);
            this.FlowPanel_Button.Controls.Add(this.btn_Revenue);
            this.FlowPanel_Button.Controls.Add(this.btn_LogOut);
            this.FlowPanel_Button.Controls.Add(this.btn_Exit);
            this.FlowPanel_Button.Controls.Add(this.btnContact);
            this.FlowPanel_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowPanel_Button.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPanel_Button.Location = new System.Drawing.Point(0, 146);
            this.FlowPanel_Button.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanel_Button.Name = "FlowPanel_Button";
            this.FlowPanel_Button.Size = new System.Drawing.Size(250, 731);
            this.FlowPanel_Button.TabIndex = 7;
            this.FlowPanel_Button.WrapContents = false;
            // 
            // btn_Sell
            // 
            this.btn_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sell.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_Sell.IconColor = System.Drawing.Color.Black;
            this.btn_Sell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Sell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sell.Location = new System.Drawing.Point(0, 0);
            this.btn_Sell.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Sell.Size = new System.Drawing.Size(227, 89);
            this.btn_Sell.TabIndex = 15;
            this.btn_Sell.Tag = "Invoice";
            this.btn_Sell.Text = "Bán Hàng";
            this.btn_Sell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sell.UseVisualStyleBackColor = true;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employee.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btn_Employee.IconColor = System.Drawing.Color.Black;
            this.btn_Employee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Employee.Location = new System.Drawing.Point(0, 89);
            this.btn_Employee.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Employee.Size = new System.Drawing.Size(227, 89);
            this.btn_Employee.TabIndex = 8;
            this.btn_Employee.Tag = "Employee";
            this.btn_Employee.Text = "Nhân Viên";
            this.btn_Employee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Employee.UseVisualStyleBackColor = true;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.IconChar = FontAwesome.Sharp.IconChar.Pagelines;
            this.btn_Product.IconColor = System.Drawing.Color.Black;
            this.btn_Product.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product.Location = new System.Drawing.Point(0, 178);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Product.Size = new System.Drawing.Size(227, 89);
            this.btn_Product.TabIndex = 10;
            this.btn_Product.Tag = "Product";
            this.btn_Product.Text = "Sản Phẩm";
            this.btn_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Product.UseVisualStyleBackColor = true;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_TypeProduct
            // 
            this.btn_TypeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TypeProduct.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btn_TypeProduct.IconColor = System.Drawing.Color.Black;
            this.btn_TypeProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_TypeProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TypeProduct.Location = new System.Drawing.Point(0, 267);
            this.btn_TypeProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TypeProduct.Name = "btn_TypeProduct";
            this.btn_TypeProduct.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_TypeProduct.Size = new System.Drawing.Size(227, 89);
            this.btn_TypeProduct.TabIndex = 17;
            this.btn_TypeProduct.Tag = "TypeProduct";
            this.btn_TypeProduct.Text = "Loại Sản Phẩm";
            this.btn_TypeProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TypeProduct.UseVisualStyleBackColor = true;
            this.btn_TypeProduct.Click += new System.EventHandler(this.btn_TypeProduct_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btn_Customer.IconColor = System.Drawing.Color.Black;
            this.btn_Customer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customer.Location = new System.Drawing.Point(0, 356);
            this.btn_Customer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Customer.Size = new System.Drawing.Size(227, 89);
            this.btn_Customer.TabIndex = 18;
            this.btn_Customer.Tag = "Customer";
            this.btn_Customer.Text = "Khách Hàng";
            this.btn_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Supplier
            // 
            this.btn_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Supplier.IconChar = FontAwesome.Sharp.IconChar.BuildingCircleCheck;
            this.btn_Supplier.IconColor = System.Drawing.Color.Black;
            this.btn_Supplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Supplier.Location = new System.Drawing.Point(0, 445);
            this.btn_Supplier.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Supplier.Name = "btn_Supplier";
            this.btn_Supplier.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Supplier.Size = new System.Drawing.Size(227, 89);
            this.btn_Supplier.TabIndex = 12;
            this.btn_Supplier.Tag = "Supplier";
            this.btn_Supplier.Text = "Nhà Cung Cấp";
            this.btn_Supplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Supplier.UseVisualStyleBackColor = true;
            this.btn_Supplier.Click += new System.EventHandler(this.btn_Supplier_Click);
            // 
            // btn_Discount
            // 
            this.btn_Discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Discount.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.btn_Discount.IconColor = System.Drawing.Color.Black;
            this.btn_Discount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Discount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Discount.Location = new System.Drawing.Point(0, 534);
            this.btn_Discount.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Discount.Name = "btn_Discount";
            this.btn_Discount.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Discount.Size = new System.Drawing.Size(227, 89);
            this.btn_Discount.TabIndex = 11;
            this.btn_Discount.Tag = "Discount";
            this.btn_Discount.Text = "Khuyến Mãi";
            this.btn_Discount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Discount.UseVisualStyleBackColor = true;
            this.btn_Discount.Click += new System.EventHandler(this.btn_Discount_Click);
            // 
            // btn_WareHouse
            // 
            this.btn_WareHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WareHouse.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btn_WareHouse.IconColor = System.Drawing.Color.Black;
            this.btn_WareHouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_WareHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_WareHouse.Location = new System.Drawing.Point(0, 623);
            this.btn_WareHouse.Margin = new System.Windows.Forms.Padding(0);
            this.btn_WareHouse.Name = "btn_WareHouse";
            this.btn_WareHouse.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_WareHouse.Size = new System.Drawing.Size(227, 89);
            this.btn_WareHouse.TabIndex = 13;
            this.btn_WareHouse.Tag = "Warehouse";
            this.btn_WareHouse.Text = "Kho Hàng";
            this.btn_WareHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_WareHouse.UseVisualStyleBackColor = true;
            this.btn_WareHouse.Click += new System.EventHandler(this.btn_WareHouse_Click);
            // 
            // btn_Revenue
            // 
            this.btn_Revenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Revenue.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btn_Revenue.IconColor = System.Drawing.Color.Black;
            this.btn_Revenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Revenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Revenue.Location = new System.Drawing.Point(0, 712);
            this.btn_Revenue.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Revenue.Name = "btn_Revenue";
            this.btn_Revenue.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Revenue.Size = new System.Drawing.Size(227, 89);
            this.btn_Revenue.TabIndex = 19;
            this.btn_Revenue.Tag = "revenue";
            this.btn_Revenue.Text = "Thống Kê";
            this.btn_Revenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Revenue.UseVisualStyleBackColor = true;
            this.btn_Revenue.Click += new System.EventHandler(this.btn_Revenue_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_LogOut.IconColor = System.Drawing.Color.Black;
            this.btn_LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LogOut.Location = new System.Drawing.Point(0, 801);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_LogOut.Size = new System.Drawing.Size(227, 89);
            this.btn_LogOut.TabIndex = 14;
            this.btn_LogOut.Text = "Đăng Xuất";
            this.btn_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btn_Exit.IconColor = System.Drawing.Color.Black;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(0, 890);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Exit.Size = new System.Drawing.Size(227, 89);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnContact
            // 
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btnContact.IconColor = System.Drawing.Color.Black;
            this.btnContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(0, 979);
            this.btnContact.Margin = new System.Windows.Forms.Padding(0);
            this.btnContact.Name = "btnContact";
            this.btnContact.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnContact.Size = new System.Drawing.Size(227, 89);
            this.btnContact.TabIndex = 20;
            this.btnContact.Tag = "Contact";
            this.btnContact.Text = "TTLiên Hệ";
            this.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // panel_body
            // 
            this.panel_body.AutoScroll = true;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(250, 146);
            this.panel_body.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1292, 731);
            this.panel_body.TabIndex = 9;
            // 
            // frmHomeOfManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 877);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.FlowPanel_Button);
            this.Controls.Add(this.panel_Top);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "frmHomeOfManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHomeOfManager_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Avatar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.FlowPanel_Button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Button;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox pic_Avatar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Employee;
        private FontAwesome.Sharp.IconButton btn_Product;
        private FontAwesome.Sharp.IconButton btn_Discount;
        private FontAwesome.Sharp.IconButton btn_Supplier;
        private FontAwesome.Sharp.IconButton btn_WareHouse;
        private FontAwesome.Sharp.IconButton btn_LogOut;
        private FontAwesome.Sharp.IconButton btn_Sell;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private FontAwesome.Sharp.IconButton btn_TypeProduct;
        private FontAwesome.Sharp.IconButton btn_Customer;
        private System.Windows.Forms.FlowLayoutPanel panel_Avatar;
        private FontAwesome.Sharp.IconButton btn_Info;
        private FontAwesome.Sharp.IconButton btn_ChangePassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_body;
        private FontAwesome.Sharp.IconButton btn_Revenue;
        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnContact;
    }
}