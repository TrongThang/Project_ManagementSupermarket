namespace ManagementSupermarket
{
    partial class frmSuppiler
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
            this.dgv_Supplier = new System.Windows.Forms.DataGridView();
            this.chk_Status = new System.Windows.Forms.CheckBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NameSupplier = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Supplier
            // 
            this.dgv_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Supplier.Location = new System.Drawing.Point(416, 83);
            this.dgv_Supplier.Name = "dgv_Supplier";
            this.dgv_Supplier.RowHeadersWidth = 51;
            this.dgv_Supplier.RowTemplate.Height = 24;
            this.dgv_Supplier.Size = new System.Drawing.Size(825, 612);
            this.dgv_Supplier.TabIndex = 13;
            // 
            // chk_Status
            // 
            this.chk_Status.AutoSize = true;
            this.chk_Status.ForeColor = System.Drawing.Color.White;
            this.chk_Status.Location = new System.Drawing.Point(13, 452);
            this.chk_Status.Name = "chk_Status";
            this.chk_Status.Size = new System.Drawing.Size(240, 30);
            this.chk_Status.TabIndex = 20;
            this.chk_Status.Text = "Trạng Thái Cung Cấp";
            this.chk_Status.UseVisualStyleBackColor = true;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(13, 315);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(266, 32);
            this.txt_Phone.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(8, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số Điện Thoại";
            // 
            // txt_NameSupplier
            // 
            this.txt_NameSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NameSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameSupplier.Location = new System.Drawing.Point(13, 249);
            this.txt_NameSupplier.Name = "txt_NameSupplier";
            this.txt_NameSupplier.Size = new System.Drawing.Size(347, 32);
            this.txt_NameSupplier.TabIndex = 17;
            // 
            // txt_Address
            // 
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(12, 388);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(266, 32);
            this.txt_Address.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(8, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(7, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Địa Chỉ";
            // 
            // txt_ID
            // 
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(13, 185);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(266, 32);
            this.txt_ID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(8, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã Nhà Cung Cấp";
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(932, 30);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(238, 45);
            this.txt_Search.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chk_Status);
            this.panel1.Controls.Add(this.txt_Phone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_NameSupplier);
            this.panel1.Controls.Add(this.txt_Address);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 707);
            this.panel1.TabIndex = 12;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::ManagementSupermarket.Properties.Resources.pngtree_vector_trash_icon_png_image_865284;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Delete.IconColor = System.Drawing.Color.Black;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.Location = new System.Drawing.Point(587, 13);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(79, 64);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPencil;
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.Location = new System.Drawing.Point(502, 13);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(79, 64);
            this.btn_Alter.TabIndex = 15;
            this.btn_Alter.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPlus;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Add.IconColor = System.Drawing.Color.Black;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.Location = new System.Drawing.Point(417, 13);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 64);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconReload;
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.Location = new System.Drawing.Point(672, 13);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(79, 64);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconSearch;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Search.IconColor = System.Drawing.Color.Black;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.Location = new System.Drawing.Point(1176, 30);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(65, 47);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // frmSuppiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1246, 707);
            this.Controls.Add(this.dgv_Supplier);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSuppiler";
            this.Text = "frmSuppiler";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Supplier;
        private System.Windows.Forms.CheckBox chk_Status;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Alter;
        private FontAwesome.Sharp.IconButton btn_Add;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NameSupplier;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Panel panel1;
    }
}