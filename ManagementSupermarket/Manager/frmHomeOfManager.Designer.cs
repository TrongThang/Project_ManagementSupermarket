namespace ManagementSupermarket
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Avatar = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Sell = new FontAwesome.Sharp.IconButton();
            this.btn_Employee = new FontAwesome.Sharp.IconButton();
            this.btn_Product = new FontAwesome.Sharp.IconButton();
            this.btn_ImportProduct = new FontAwesome.Sharp.IconButton();
            this.btn_Supplier = new FontAwesome.Sharp.IconButton();
            this.btn_WareHouse = new FontAwesome.Sharp.IconButton();
            this.btn_LogOut = new FontAwesome.Sharp.IconButton();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(150)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pic_Logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 126);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_Avatar);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1006, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 124);
            this.panel1.TabIndex = 5;
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.Image = global::ManagementSupermarket.Properties.Resources.avartaNam;
            this.pic_Avatar.Location = new System.Drawing.Point(45, 9);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Size = new System.Drawing.Size(116, 80);
            this.pic_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Avatar.TabIndex = 3;
            this.pic_Avatar.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.lbl_Name.Location = new System.Drawing.Point(64, 94);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(82, 26);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Họ Tên";
            // 
            // pic_Logo
            // 
            this.pic_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_Logo.Image = global::ManagementSupermarket.Properties.Resources.banhang;
            this.pic_Logo.Location = new System.Drawing.Point(0, 0);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(245, 124);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 2;
            this.pic_Logo.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Sell);
            this.flowLayoutPanel1.Controls.Add(this.btn_Employee);
            this.flowLayoutPanel1.Controls.Add(this.btn_Product);
            this.flowLayoutPanel1.Controls.Add(this.btn_ImportProduct);
            this.flowLayoutPanel1.Controls.Add(this.btn_Supplier);
            this.flowLayoutPanel1.Controls.Add(this.btn_WareHouse);
            this.flowLayoutPanel1.Controls.Add(this.btn_LogOut);
            this.flowLayoutPanel1.Controls.Add(this.btn_Exit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 651);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
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
            this.btn_Sell.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Sell.Size = new System.Drawing.Size(246, 77);
            this.btn_Sell.TabIndex = 15;
            this.btn_Sell.Text = "Bán Hàng";
            this.btn_Sell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sell.UseVisualStyleBackColor = true;
            // 
            // btn_Employee
            // 
            this.btn_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employee.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btn_Employee.IconColor = System.Drawing.Color.Black;
            this.btn_Employee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Employee.Location = new System.Drawing.Point(0, 77);
            this.btn_Employee.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Employee.Size = new System.Drawing.Size(246, 77);
            this.btn_Employee.TabIndex = 8;
            this.btn_Employee.Text = "Nhân Viên";
            this.btn_Employee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Employee.UseVisualStyleBackColor = true;
            // 
            // btn_Product
            // 
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.IconChar = FontAwesome.Sharp.IconChar.Pagelines;
            this.btn_Product.IconColor = System.Drawing.Color.Black;
            this.btn_Product.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product.Location = new System.Drawing.Point(0, 154);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Product.Size = new System.Drawing.Size(246, 77);
            this.btn_Product.TabIndex = 10;
            this.btn_Product.Text = "Sản Phẩm";
            this.btn_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Product.UseVisualStyleBackColor = true;
            // 
            // btn_ImportProduct
            // 
            this.btn_ImportProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportProduct.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.btn_ImportProduct.IconColor = System.Drawing.Color.Black;
            this.btn_ImportProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ImportProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImportProduct.Location = new System.Drawing.Point(0, 231);
            this.btn_ImportProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ImportProduct.Name = "btn_ImportProduct";
            this.btn_ImportProduct.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_ImportProduct.Size = new System.Drawing.Size(246, 77);
            this.btn_ImportProduct.TabIndex = 11;
            this.btn_ImportProduct.Text = "Nhập Hàng";
            this.btn_ImportProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ImportProduct.UseVisualStyleBackColor = true;
            // 
            // btn_Supplier
            // 
            this.btn_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Supplier.IconChar = FontAwesome.Sharp.IconChar.BuildingCircleCheck;
            this.btn_Supplier.IconColor = System.Drawing.Color.Black;
            this.btn_Supplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Supplier.Location = new System.Drawing.Point(0, 308);
            this.btn_Supplier.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Supplier.Name = "btn_Supplier";
            this.btn_Supplier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Supplier.Size = new System.Drawing.Size(246, 77);
            this.btn_Supplier.TabIndex = 12;
            this.btn_Supplier.Text = "Nhà Cung Cấp";
            this.btn_Supplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Supplier.UseVisualStyleBackColor = true;
            // 
            // btn_WareHouse
            // 
            this.btn_WareHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WareHouse.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btn_WareHouse.IconColor = System.Drawing.Color.Black;
            this.btn_WareHouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_WareHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_WareHouse.Location = new System.Drawing.Point(0, 385);
            this.btn_WareHouse.Margin = new System.Windows.Forms.Padding(0);
            this.btn_WareHouse.Name = "btn_WareHouse";
            this.btn_WareHouse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_WareHouse.Size = new System.Drawing.Size(246, 77);
            this.btn_WareHouse.TabIndex = 13;
            this.btn_WareHouse.Text = "Kho Hàng";
            this.btn_WareHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_WareHouse.UseVisualStyleBackColor = true;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_LogOut.IconColor = System.Drawing.Color.Black;
            this.btn_LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LogOut.Location = new System.Drawing.Point(0, 462);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_LogOut.Size = new System.Drawing.Size(246, 77);
            this.btn_LogOut.TabIndex = 14;
            this.btn_LogOut.Text = "Đăng Xuất";
            this.btn_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btn_Exit.IconColor = System.Drawing.Color.Black;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(0, 539);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Exit.Size = new System.Drawing.Size(246, 77);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // frmHomeOfManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 777);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHomeOfManager";
            this.Text = "frmHome";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox pic_Avatar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Employee;
        private FontAwesome.Sharp.IconButton btn_Product;
        private FontAwesome.Sharp.IconButton btn_ImportProduct;
        private FontAwesome.Sharp.IconButton btn_Supplier;
        private FontAwesome.Sharp.IconButton btn_WareHouse;
        private FontAwesome.Sharp.IconButton btn_LogOut;
        private FontAwesome.Sharp.IconButton btn_Sell;
        private FontAwesome.Sharp.IconButton btn_Exit;
    }
}