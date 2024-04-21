namespace ManagementSupermarket
{
    partial class frmOrder
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
            this.tab_HomeInvoiceSelling = new System.Windows.Forms.TabControl();
            this.tab_FormCreateInvoice = new System.Windows.Forms.TabPage();
            this.chk_PhoneCustomer = new System.Windows.Forms.CheckBox();
            this.lbl_ErrorCashCustomer = new System.Windows.Forms.Label();
            this.btn_RefreshCreate = new FontAwesome.Sharp.IconButton();
            this.txt_ChangeCreate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PhoneCustomerCreate = new System.Windows.Forms.TextBox();
            this.txt_CashCustomerCreate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TotalCashCreate = new System.Windows.Forms.TextBox();
            this.btn_FinishOrder = new FontAwesome.Sharp.IconButton();
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.lst_OrderCurrency = new System.Windows.Forms.ListView();
            this.MaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaKM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaKM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txt_AmountCreate = new System.Windows.Forms.TextBox();
            this.cbb_DiscountCreate = new System.Windows.Forms.ComboBox();
            this.cbb_NameProductCreate = new System.Windows.Forms.ComboBox();
            this.num_CountProductCreate = new System.Windows.Forms.NumericUpDown();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.txt_PriceCreate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_AlterList = new FontAwesome.Sharp.IconButton();
            this.btn_AddList = new FontAwesome.Sharp.IconButton();
            this.btn_RefreshList = new FontAwesome.Sharp.IconButton();
            this.btn_DeleteList = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_NameProduct = new System.Windows.Forms.ComboBox();
            this.cbb_Discount = new System.Windows.Forms.ComboBox();
            this.iconButton14 = new FontAwesome.Sharp.IconButton();
            this.num_CountProduct = new System.Windows.Forms.NumericUpDown();
            this.txt_Amonut = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.dgv_InvoiceSelling = new System.Windows.Forms.DataGridView();
            this.dgv_Detail_InvoiceSelling = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TotalCash = new System.Windows.Forms.TextBox();
            this.iconButton13 = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_CreatedTime = new System.Windows.Forms.DateTimePicker();
            this.txt_IdEmployee = new System.Windows.Forms.TextBox();
            this.txt_Change = new System.Windows.Forms.TextBox();
            this.txt_CashCustomer = new System.Windows.Forms.TextBox();
            this.txt_IdCustomer = new System.Windows.Forms.TextBox();
            this.txt_IdOrder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tab_HomeInvoiceSelling.SuspendLayout();
            this.tab_FormCreateInvoice.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountProductCreate)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InvoiceSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail_InvoiceSelling)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_HomeInvoiceSelling
            // 
            this.tab_HomeInvoiceSelling.Controls.Add(this.tab_FormCreateInvoice);
            this.tab_HomeInvoiceSelling.Controls.Add(this.tabPage2);
            this.tab_HomeInvoiceSelling.Location = new System.Drawing.Point(-1, -2);
            this.tab_HomeInvoiceSelling.Name = "tab_HomeInvoiceSelling";
            this.tab_HomeInvoiceSelling.SelectedIndex = 0;
            this.tab_HomeInvoiceSelling.Size = new System.Drawing.Size(1193, 734);
            this.tab_HomeInvoiceSelling.TabIndex = 0;
            // 
            // tab_FormCreateInvoice
            // 
            this.tab_FormCreateInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.tab_FormCreateInvoice.Controls.Add(this.chk_PhoneCustomer);
            this.tab_FormCreateInvoice.Controls.Add(this.lbl_ErrorCashCustomer);
            this.tab_FormCreateInvoice.Controls.Add(this.btn_RefreshCreate);
            this.tab_FormCreateInvoice.Controls.Add(this.txt_ChangeCreate);
            this.tab_FormCreateInvoice.Controls.Add(this.label4);
            this.tab_FormCreateInvoice.Controls.Add(this.txt_PhoneCustomerCreate);
            this.tab_FormCreateInvoice.Controls.Add(this.txt_CashCustomerCreate);
            this.tab_FormCreateInvoice.Controls.Add(this.label1);
            this.tab_FormCreateInvoice.Controls.Add(this.txt_TotalCashCreate);
            this.tab_FormCreateInvoice.Controls.Add(this.btn_FinishOrder);
            this.tab_FormCreateInvoice.Controls.Add(this.btn_Alter);
            this.tab_FormCreateInvoice.Controls.Add(this.btn_Delete);
            this.tab_FormCreateInvoice.Controls.Add(this.lst_OrderCurrency);
            this.tab_FormCreateInvoice.Controls.Add(this.grpInfo);
            this.tab_FormCreateInvoice.Location = new System.Drawing.Point(4, 35);
            this.tab_FormCreateInvoice.Name = "tab_FormCreateInvoice";
            this.tab_FormCreateInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tab_FormCreateInvoice.Size = new System.Drawing.Size(1185, 695);
            this.tab_FormCreateInvoice.TabIndex = 0;
            this.tab_FormCreateInvoice.Text = "Lập Hoá Đơn";
            // 
            // chk_PhoneCustomer
            // 
            this.chk_PhoneCustomer.AutoSize = true;
            this.chk_PhoneCustomer.BackColor = System.Drawing.Color.Transparent;
            this.chk_PhoneCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_PhoneCustomer.ForeColor = System.Drawing.Color.White;
            this.chk_PhoneCustomer.Location = new System.Drawing.Point(727, 211);
            this.chk_PhoneCustomer.Name = "chk_PhoneCustomer";
            this.chk_PhoneCustomer.Size = new System.Drawing.Size(273, 29);
            this.chk_PhoneCustomer.TabIndex = 34;
            this.chk_PhoneCustomer.Text = "Số Điện Thoại Khách Hàng";
            this.chk_PhoneCustomer.UseVisualStyleBackColor = false;
            this.chk_PhoneCustomer.CheckedChanged += new System.EventHandler(this.chk_PhoneCustomer_CheckedChanged);
            // 
            // lbl_ErrorCashCustomer
            // 
            this.lbl_ErrorCashCustomer.AutoSize = true;
            this.lbl_ErrorCashCustomer.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCashCustomer.Location = new System.Drawing.Point(722, 396);
            this.lbl_ErrorCashCustomer.Name = "lbl_ErrorCashCustomer";
            this.lbl_ErrorCashCustomer.Size = new System.Drawing.Size(82, 26);
            this.lbl_ErrorCashCustomer.TabIndex = 33;
            this.lbl_ErrorCashCustomer.Text = "label18";
            this.lbl_ErrorCashCustomer.Visible = false;
            // 
            // btn_RefreshCreate
            // 
            this.btn_RefreshCreate.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconReload;
            this.btn_RefreshCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RefreshCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_RefreshCreate.IconColor = System.Drawing.Color.Black;
            this.btn_RefreshCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RefreshCreate.Location = new System.Drawing.Point(280, 153);
            this.btn_RefreshCreate.Name = "btn_RefreshCreate";
            this.btn_RefreshCreate.Size = new System.Drawing.Size(79, 64);
            this.btn_RefreshCreate.TabIndex = 26;
            this.btn_RefreshCreate.UseVisualStyleBackColor = true;
            this.btn_RefreshCreate.Click += new System.EventHandler(this.btn_RefreshCreate_Click);
            // 
            // txt_ChangeCreate
            // 
            this.txt_ChangeCreate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_ChangeCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ChangeCreate.Enabled = false;
            this.txt_ChangeCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_ChangeCreate.Location = new System.Drawing.Point(727, 455);
            this.txt_ChangeCreate.Name = "txt_ChangeCreate";
            this.txt_ChangeCreate.ReadOnly = true;
            this.txt_ChangeCreate.Size = new System.Drawing.Size(273, 45);
            this.txt_ChangeCreate.TabIndex = 30;
            this.txt_ChangeCreate.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(722, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tiền Thối";
            // 
            // txt_PhoneCustomerCreate
            // 
            this.txt_PhoneCustomerCreate.BackColor = System.Drawing.Color.Gray;
            this.txt_PhoneCustomerCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PhoneCustomerCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_PhoneCustomerCreate.Location = new System.Drawing.Point(727, 246);
            this.txt_PhoneCustomerCreate.Name = "txt_PhoneCustomerCreate";
            this.txt_PhoneCustomerCreate.Size = new System.Drawing.Size(273, 45);
            this.txt_PhoneCustomerCreate.TabIndex = 31;
            this.txt_PhoneCustomerCreate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PhoneCustomerCreate_KeyPress);
            // 
            // txt_CashCustomerCreate
            // 
            this.txt_CashCustomerCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CashCustomerCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_CashCustomerCreate.Location = new System.Drawing.Point(727, 348);
            this.txt_CashCustomerCreate.Name = "txt_CashCustomerCreate";
            this.txt_CashCustomerCreate.Size = new System.Drawing.Size(273, 45);
            this.txt_CashCustomerCreate.TabIndex = 32;
            this.txt_CashCustomerCreate.Text = "0";
            this.txt_CashCustomerCreate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CashCustomerCreate_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(722, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tiền Khách Đưa";
            // 
            // txt_TotalCashCreate
            // 
            this.txt_TotalCashCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.txt_TotalCashCreate.Location = new System.Drawing.Point(717, 609);
            this.txt_TotalCashCreate.Name = "txt_TotalCashCreate";
            this.txt_TotalCashCreate.ReadOnly = true;
            this.txt_TotalCashCreate.Size = new System.Drawing.Size(283, 68);
            this.txt_TotalCashCreate.TabIndex = 25;
            this.txt_TotalCashCreate.Text = "0";
            // 
            // btn_FinishOrder
            // 
            this.btn_FinishOrder.BackColor = System.Drawing.Color.Transparent;
            this.btn_FinishOrder.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btn_FinishOrder.IconColor = System.Drawing.Color.Black;
            this.btn_FinishOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_FinishOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FinishOrder.Location = new System.Drawing.Point(1012, 609);
            this.btn_FinishOrder.Name = "btn_FinishOrder";
            this.btn_FinishOrder.Size = new System.Drawing.Size(154, 67);
            this.btn_FinishOrder.TabIndex = 24;
            this.btn_FinishOrder.Text = "Tổng Tiền";
            this.btn_FinishOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_FinishOrder.UseVisualStyleBackColor = false;
            this.btn_FinishOrder.Click += new System.EventHandler(this.btn_FinishOrder_Click);
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPencil;
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.Location = new System.Drawing.Point(18, 156);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(85, 59);
            this.btn_Alter.TabIndex = 22;
            this.btn_Alter.UseVisualStyleBackColor = true;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::ManagementSupermarket.Properties.Resources.pngtree_vector_trash_icon_png_image_865284;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Delete.IconColor = System.Drawing.Color.Black;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.Location = new System.Drawing.Point(147, 156);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(81, 59);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lst_OrderCurrency
            // 
            this.lst_OrderCurrency.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSP,
            this.TenSP,
            this.SL,
            this.Gia,
            this.MaKM,
            this.GiaKM,
            this.ThanhTien});
            this.lst_OrderCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lst_OrderCurrency.FullRowSelect = true;
            this.lst_OrderCurrency.GridLines = true;
            this.lst_OrderCurrency.HideSelection = false;
            this.lst_OrderCurrency.Location = new System.Drawing.Point(18, 219);
            this.lst_OrderCurrency.MultiSelect = false;
            this.lst_OrderCurrency.Name = "lst_OrderCurrency";
            this.lst_OrderCurrency.Size = new System.Drawing.Size(687, 469);
            this.lst_OrderCurrency.TabIndex = 21;
            this.lst_OrderCurrency.UseCompatibleStateImageBehavior = false;
            this.lst_OrderCurrency.View = System.Windows.Forms.View.Details;
            this.lst_OrderCurrency.Click += new System.EventHandler(this.lst_OrderCurrency_Click);
            // 
            // MaSP
            // 
            this.MaSP.Text = "Mã Sản Phẩm";
            this.MaSP.Width = 130;
            // 
            // TenSP
            // 
            this.TenSP.Text = "Tên Sản Phẩm";
            this.TenSP.Width = 135;
            // 
            // SL
            // 
            this.SL.Text = "SL";
            this.SL.Width = 57;
            // 
            // Gia
            // 
            this.Gia.Text = "Giá";
            this.Gia.Width = 95;
            // 
            // MaKM
            // 
            this.MaKM.Text = "Mã KM";
            this.MaKM.Width = 83;
            // 
            // GiaKM
            // 
            this.GiaKM.Text = "Giá KM";
            this.GiaKM.Width = 93;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Th.Tiền";
            this.ThanhTien.Width = 132;
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpInfo.Controls.Add(this.txt_AmountCreate);
            this.grpInfo.Controls.Add(this.cbb_DiscountCreate);
            this.grpInfo.Controls.Add(this.cbb_NameProductCreate);
            this.grpInfo.Controls.Add(this.num_CountProductCreate);
            this.grpInfo.Controls.Add(this.btn_Add);
            this.grpInfo.Controls.Add(this.txt_PriceCreate);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label12);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.ForeColor = System.Drawing.Color.Yellow;
            this.grpInfo.Location = new System.Drawing.Point(19, -1);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1147, 141);
            this.grpInfo.TabIndex = 20;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin";
            // 
            // txt_AmountCreate
            // 
            this.txt_AmountCreate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_AmountCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AmountCreate.Location = new System.Drawing.Point(767, 75);
            this.txt_AmountCreate.Name = "txt_AmountCreate";
            this.txt_AmountCreate.ReadOnly = true;
            this.txt_AmountCreate.Size = new System.Drawing.Size(210, 32);
            this.txt_AmountCreate.TabIndex = 34;
            // 
            // cbb_DiscountCreate
            // 
            this.cbb_DiscountCreate.DisplayMember = " ";
            this.cbb_DiscountCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_DiscountCreate.FormattingEnabled = true;
            this.cbb_DiscountCreate.Location = new System.Drawing.Point(574, 74);
            this.cbb_DiscountCreate.Name = "cbb_DiscountCreate";
            this.cbb_DiscountCreate.Size = new System.Drawing.Size(154, 34);
            this.cbb_DiscountCreate.TabIndex = 33;
            // 
            // cbb_NameProductCreate
            // 
            this.cbb_NameProductCreate.FormattingEnabled = true;
            this.cbb_NameProductCreate.Location = new System.Drawing.Point(27, 74);
            this.cbb_NameProductCreate.Name = "cbb_NameProductCreate";
            this.cbb_NameProductCreate.Size = new System.Drawing.Size(207, 34);
            this.cbb_NameProductCreate.TabIndex = 33;
            this.cbb_NameProductCreate.SelectionChangeCommitted += new System.EventHandler(this.cbb_NameProductCreate_SelectionChangeCommitted);
            // 
            // num_CountProductCreate
            // 
            this.num_CountProductCreate.Location = new System.Drawing.Point(253, 76);
            this.num_CountProductCreate.Name = "num_CountProductCreate";
            this.num_CountProductCreate.Size = new System.Drawing.Size(139, 32);
            this.num_CountProductCreate.TabIndex = 18;
            this.num_CountProductCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_CountProductCreate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_CountProductCreate.ValueChanged += new System.EventHandler(this.num_CountProductCreate_ValueChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPlus;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Add.IconColor = System.Drawing.Color.Black;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.Location = new System.Drawing.Point(1044, 48);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 64);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_PriceCreate
            // 
            this.txt_PriceCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PriceCreate.Location = new System.Drawing.Point(413, 76);
            this.txt_PriceCreate.Name = "txt_PriceCreate";
            this.txt_PriceCreate.ReadOnly = true;
            this.txt_PriceCreate.Size = new System.Drawing.Size(139, 32);
            this.txt_PriceCreate.TabIndex = 14;
            this.txt_PriceCreate.Text = " 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Sản Phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(762, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Thành Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(248, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(569, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khuyến Mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(408, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn Giá";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.tabPage2.Controls.Add(this.iconButton1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.iconButton3);
            this.tabPage2.Controls.Add(this.iconButton4);
            this.tabPage2.Controls.Add(this.dgv_InvoiceSelling);
            this.tabPage2.Controls.Add(this.dgv_Detail_InvoiceSelling);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1185, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh Sách Hoá Đơn";
            // 
            // iconButton1
            // 
            this.iconButton1.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPencil;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(8, 314);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(55, 55);
            this.iconButton1.TabIndex = 17;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_AlterList);
            this.groupBox4.Controls.Add(this.btn_AddList);
            this.groupBox4.Controls.Add(this.btn_RefreshList);
            this.groupBox4.Controls.Add(this.btn_DeleteList);
            this.groupBox4.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox4.Location = new System.Drawing.Point(591, 178);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox4.Size = new System.Drawing.Size(497, 87);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // btn_AlterList
            // 
            this.btn_AlterList.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPencil;
            this.btn_AlterList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AlterList.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_AlterList.IconColor = System.Drawing.Color.Black;
            this.btn_AlterList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AlterList.Location = new System.Drawing.Point(89, 26);
            this.btn_AlterList.Name = "btn_AlterList";
            this.btn_AlterList.Size = new System.Drawing.Size(55, 55);
            this.btn_AlterList.TabIndex = 13;
            this.btn_AlterList.UseVisualStyleBackColor = true;
            // 
            // btn_AddList
            // 
            this.btn_AddList.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPlus;
            this.btn_AddList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddList.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_AddList.IconColor = System.Drawing.Color.Black;
            this.btn_AddList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AddList.Location = new System.Drawing.Point(14, 26);
            this.btn_AddList.Name = "btn_AddList";
            this.btn_AddList.Size = new System.Drawing.Size(55, 55);
            this.btn_AddList.TabIndex = 12;
            this.btn_AddList.UseVisualStyleBackColor = true;
            // 
            // btn_RefreshList
            // 
            this.btn_RefreshList.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconReload;
            this.btn_RefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RefreshList.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_RefreshList.IconColor = System.Drawing.Color.Black;
            this.btn_RefreshList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_RefreshList.Location = new System.Drawing.Point(230, 26);
            this.btn_RefreshList.Name = "btn_RefreshList";
            this.btn_RefreshList.Size = new System.Drawing.Size(55, 55);
            this.btn_RefreshList.TabIndex = 15;
            this.btn_RefreshList.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteList
            // 
            this.btn_DeleteList.BackgroundImage = global::ManagementSupermarket.Properties.Resources.pngtree_vector_trash_icon_png_image_865284;
            this.btn_DeleteList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DeleteList.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_DeleteList.IconColor = System.Drawing.Color.Black;
            this.btn_DeleteList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DeleteList.Location = new System.Drawing.Point(159, 26);
            this.btn_DeleteList.Name = "btn_DeleteList";
            this.btn_DeleteList.Size = new System.Drawing.Size(55, 55);
            this.btn_DeleteList.TabIndex = 14;
            this.btn_DeleteList.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbb_NameProduct);
            this.groupBox2.Controls.Add(this.cbb_Discount);
            this.groupBox2.Controls.Add(this.iconButton14);
            this.groupBox2.Controls.Add(this.num_CountProduct);
            this.groupBox2.Controls.Add(this.txt_Amonut);
            this.groupBox2.Controls.Add(this.txt_Price);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(591, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 171);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hoá Đơn";
            // 
            // cbb_NameProduct
            // 
            this.cbb_NameProduct.FormattingEnabled = true;
            this.cbb_NameProduct.Location = new System.Drawing.Point(20, 53);
            this.cbb_NameProduct.Name = "cbb_NameProduct";
            this.cbb_NameProduct.Size = new System.Drawing.Size(194, 34);
            this.cbb_NameProduct.TabIndex = 34;
            // 
            // cbb_Discount
            // 
            this.cbb_Discount.FormattingEnabled = true;
            this.cbb_Discount.Location = new System.Drawing.Point(20, 121);
            this.cbb_Discount.Name = "cbb_Discount";
            this.cbb_Discount.Size = new System.Drawing.Size(194, 34);
            this.cbb_Discount.TabIndex = 29;
            // 
            // iconButton14
            // 
            this.iconButton14.BackColor = System.Drawing.Color.Transparent;
            this.iconButton14.FlatAppearance.BorderSize = 0;
            this.iconButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iconButton14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.iconButton14.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.iconButton14.IconColor = System.Drawing.Color.Lime;
            this.iconButton14.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton14.IconSize = 30;
            this.iconButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton14.Location = new System.Drawing.Point(436, 114);
            this.iconButton14.Name = "iconButton14";
            this.iconButton14.Size = new System.Drawing.Size(122, 43);
            this.iconButton14.TabIndex = 28;
            this.iconButton14.Text = "Thành Tiền";
            this.iconButton14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton14.UseVisualStyleBackColor = false;
            // 
            // num_CountProduct
            // 
            this.num_CountProduct.Location = new System.Drawing.Point(238, 55);
            this.num_CountProduct.Name = "num_CountProduct";
            this.num_CountProduct.Size = new System.Drawing.Size(129, 32);
            this.num_CountProduct.TabIndex = 16;
            // 
            // txt_Amonut
            // 
            this.txt_Amonut.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Amonut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Amonut.Location = new System.Drawing.Point(238, 122);
            this.txt_Amonut.Name = "txt_Amonut";
            this.txt_Amonut.ReadOnly = true;
            this.txt_Amonut.Size = new System.Drawing.Size(192, 32);
            this.txt_Amonut.TabIndex = 13;
            // 
            // txt_Price
            // 
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price.Location = new System.Drawing.Point(387, 55);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(185, 32);
            this.txt_Price.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(382, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Đơn giá";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(15, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 25);
            this.label17.TabIndex = 5;
            this.label17.Text = "Khuyến Mãi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(15, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Sản Phẩm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(233, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Số Lượng";
            // 
            // iconButton3
            // 
            this.iconButton3.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconReload;
            this.iconButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(149, 314);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(55, 55);
            this.iconButton3.TabIndex = 19;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.BackgroundImage = global::ManagementSupermarket.Properties.Resources.pngtree_vector_trash_icon_png_image_865284;
            this.iconButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(78, 314);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(55, 55);
            this.iconButton4.TabIndex = 18;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // dgv_InvoiceSelling
            // 
            this.dgv_InvoiceSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InvoiceSelling.Location = new System.Drawing.Point(6, 374);
            this.dgv_InvoiceSelling.MultiSelect = false;
            this.dgv_InvoiceSelling.Name = "dgv_InvoiceSelling";
            this.dgv_InvoiceSelling.ReadOnly = true;
            this.dgv_InvoiceSelling.RowHeadersWidth = 51;
            this.dgv_InvoiceSelling.RowTemplate.Height = 24;
            this.dgv_InvoiceSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_InvoiceSelling.Size = new System.Drawing.Size(570, 317);
            this.dgv_InvoiceSelling.TabIndex = 5;
            this.dgv_InvoiceSelling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_InvoiceSelling_CellClick);
            // 
            // dgv_Detail_InvoiceSelling
            // 
            this.dgv_Detail_InvoiceSelling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Detail_InvoiceSelling.ColumnHeadersHeight = 29;
            this.dgv_Detail_InvoiceSelling.Location = new System.Drawing.Point(591, 273);
            this.dgv_Detail_InvoiceSelling.MultiSelect = false;
            this.dgv_Detail_InvoiceSelling.Name = "dgv_Detail_InvoiceSelling";
            this.dgv_Detail_InvoiceSelling.ReadOnly = true;
            this.dgv_Detail_InvoiceSelling.RowHeadersWidth = 51;
            this.dgv_Detail_InvoiceSelling.RowTemplate.Height = 24;
            this.dgv_Detail_InvoiceSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Detail_InvoiceSelling.Size = new System.Drawing.Size(588, 419);
            this.dgv_Detail_InvoiceSelling.TabIndex = 4;
            this.dgv_Detail_InvoiceSelling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Detail_InvoiceSelling_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_TotalCash);
            this.groupBox1.Controls.Add(this.iconButton13);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txt_IdEmployee);
            this.groupBox1.Controls.Add(this.txt_Change);
            this.groupBox1.Controls.Add(this.txt_CashCustomer);
            this.groupBox1.Controls.Add(this.txt_IdCustomer);
            this.groupBox1.Controls.Add(this.txt_IdOrder);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 307);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hoá Đơn";
            // 
            // txt_TotalCash
            // 
            this.txt_TotalCash.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_TotalCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_TotalCash.Location = new System.Drawing.Point(53, 248);
            this.txt_TotalCash.Name = "txt_TotalCash";
            this.txt_TotalCash.ReadOnly = true;
            this.txt_TotalCash.Size = new System.Drawing.Size(234, 45);
            this.txt_TotalCash.TabIndex = 27;
            // 
            // iconButton13
            // 
            this.iconButton13.BackColor = System.Drawing.Color.Transparent;
            this.iconButton13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.iconButton13.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.iconButton13.IconColor = System.Drawing.Color.Lime;
            this.iconButton13.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton13.Location = new System.Drawing.Point(298, 243);
            this.iconButton13.Name = "iconButton13";
            this.iconButton13.Size = new System.Drawing.Size(166, 53);
            this.iconButton13.TabIndex = 26;
            this.iconButton13.Text = "Tổng Tiền";
            this.iconButton13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton13.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_CreatedTime);
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(292, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 76);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngày Tạo";
            // 
            // dtp_CreatedTime
            // 
            this.dtp_CreatedTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtp_CreatedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CreatedTime.Location = new System.Drawing.Point(6, 31);
            this.dtp_CreatedTime.Name = "dtp_CreatedTime";
            this.dtp_CreatedTime.Size = new System.Drawing.Size(243, 32);
            this.dtp_CreatedTime.TabIndex = 11;
            // 
            // txt_IdEmployee
            // 
            this.txt_IdEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdEmployee.Location = new System.Drawing.Point(292, 54);
            this.txt_IdEmployee.Name = "txt_IdEmployee";
            this.txt_IdEmployee.Size = new System.Drawing.Size(220, 32);
            this.txt_IdEmployee.TabIndex = 17;
            // 
            // txt_Change
            // 
            this.txt_Change.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Change.Location = new System.Drawing.Point(292, 198);
            this.txt_Change.Name = "txt_Change";
            this.txt_Change.Size = new System.Drawing.Size(233, 32);
            this.txt_Change.TabIndex = 14;
            // 
            // txt_CashCustomer
            // 
            this.txt_CashCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CashCustomer.Location = new System.Drawing.Point(26, 198);
            this.txt_CashCustomer.Name = "txt_CashCustomer";
            this.txt_CashCustomer.Size = new System.Drawing.Size(233, 32);
            this.txt_CashCustomer.TabIndex = 14;
            // 
            // txt_IdCustomer
            // 
            this.txt_IdCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdCustomer.Location = new System.Drawing.Point(20, 120);
            this.txt_IdCustomer.Name = "txt_IdCustomer";
            this.txt_IdCustomer.Size = new System.Drawing.Size(233, 32);
            this.txt_IdCustomer.TabIndex = 14;
            // 
            // txt_IdOrder
            // 
            this.txt_IdOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdOrder.Location = new System.Drawing.Point(20, 54);
            this.txt_IdOrder.Name = "txt_IdOrder";
            this.txt_IdOrder.Size = new System.Drawing.Size(240, 32);
            this.txt_IdOrder.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mã Hoá Đơn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(287, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tiền Thối Khách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(287, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mã Nhân Viên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(21, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tiền Khách Đưa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mã Khách Hàng";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 735);
            this.Controls.Add(this.tab_HomeInvoiceSelling);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.tab_HomeInvoiceSelling.ResumeLayout(false);
            this.tab_FormCreateInvoice.ResumeLayout(false);
            this.tab_FormCreateInvoice.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountProductCreate)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InvoiceSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail_InvoiceSelling)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_HomeInvoiceSelling;
        private System.Windows.Forms.TabPage tab_FormCreateInvoice;
        private FontAwesome.Sharp.IconButton btn_RefreshCreate;
        private System.Windows.Forms.TextBox txt_ChangeCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PhoneCustomerCreate;
        private System.Windows.Forms.TextBox txt_CashCustomerCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TotalCashCreate;
        private FontAwesome.Sharp.IconButton btn_FinishOrder;
        private FontAwesome.Sharp.IconButton btn_Alter;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private System.Windows.Forms.ListView lst_OrderCurrency;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader SL;
        private System.Windows.Forms.ColumnHeader MaKM;
        private System.Windows.Forms.ColumnHeader Gia;
        private System.Windows.Forms.ColumnHeader GiaKM;
        private System.Windows.Forms.GroupBox grpInfo;
        private FontAwesome.Sharp.IconButton btn_Add;
        private System.Windows.Forms.TextBox txt_PriceCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_CreatedTime;
        private System.Windows.Forms.TextBox txt_IdEmployee;
        private System.Windows.Forms.TextBox txt_IdCustomer;
        private System.Windows.Forms.TextBox txt_IdOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_InvoiceSelling;
        private System.Windows.Forms.DataGridView dgv_Detail_InvoiceSelling;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_RefreshList;
        private FontAwesome.Sharp.IconButton btn_DeleteList;
        private FontAwesome.Sharp.IconButton btn_AlterList;
        private FontAwesome.Sharp.IconButton btn_AddList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Change;
        private System.Windows.Forms.TextBox txt_CashCustomer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_TotalCash;
        private FontAwesome.Sharp.IconButton iconButton13;
        private FontAwesome.Sharp.IconButton iconButton14;
        private System.Windows.Forms.NumericUpDown num_CountProduct;
        private System.Windows.Forms.TextBox txt_Amonut;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown num_CountProductCreate;
        private System.Windows.Forms.ComboBox cbb_Discount;
        private System.Windows.Forms.ComboBox cbb_NameProductCreate;
        private System.Windows.Forms.ComboBox cbb_DiscountCreate;
        private System.Windows.Forms.TextBox txt_AmountCreate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.Label lbl_ErrorCashCustomer;
        private System.Windows.Forms.ColumnHeader MaSP;
        private System.Windows.Forms.CheckBox chk_PhoneCustomer;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.ComboBox cbb_NameProduct;
    }
}