namespace ManagementSupermarket.Manager
{
    partial class frmTypeProduct
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
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NameSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Supplier = new System.Windows.Forms.DataGridView();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_Search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.ForeColor = System.Drawing.Color.Red;
            this.lbl_Phone.Location = new System.Drawing.Point(12, 479);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(81, 29);
            this.lbl_Phone.TabIndex = 26;
            this.lbl_Phone.Text = "label4";
            this.lbl_Phone.Visible = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(12, 366);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(81, 29);
            this.lbl_Name.TabIndex = 27;
            this.lbl_Name.Text = "label4";
            this.lbl_Name.Visible = false;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(12, 440);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(248, 36);
            this.txt_Phone.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(7, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Số Điện Thoại";
            // 
            // txt_NameSupplier
            // 
            this.txt_NameSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NameSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameSupplier.Location = new System.Drawing.Point(12, 327);
            this.txt_NameSupplier.Name = "txt_NameSupplier";
            this.txt_NameSupplier.Size = new System.Drawing.Size(347, 36);
            this.txt_NameSupplier.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(7, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên Nhà Cung Cấp";
            // 
            // dgv_Supplier
            // 
            this.dgv_Supplier.AllowUserToAddRows = false;
            this.dgv_Supplier.AllowUserToDeleteRows = false;
            this.dgv_Supplier.AllowUserToOrderColumns = true;
            this.dgv_Supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Supplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Supplier.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Supplier.Location = new System.Drawing.Point(426, 131);
            this.dgv_Supplier.MultiSelect = false;
            this.dgv_Supplier.Name = "dgv_Supplier";
            this.dgv_Supplier.ReadOnly = true;
            this.dgv_Supplier.RowHeadersWidth = 51;
            this.dgv_Supplier.RowTemplate.Height = 24;
            this.dgv_Supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Supplier.Size = new System.Drawing.Size(939, 605);
            this.dgv_Supplier.TabIndex = 28;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconSearch;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Search.IconColor = System.Drawing.Color.Black;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.Location = new System.Drawing.Point(1299, 80);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(65, 47);
            this.btn_Search.TabIndex = 33;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(1055, 80);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(238, 45);
            this.txt_Search.TabIndex = 34;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::ManagementSupermarket.Properties.Resources.pngtree_vector_trash_icon_png_image_865284;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Delete.IconColor = System.Drawing.Color.Black;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.Location = new System.Drawing.Point(212, 556);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 78);
            this.btn_Delete.TabIndex = 31;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPencil;
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.Location = new System.Drawing.Point(115, 556);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(91, 78);
            this.btn_Alter.TabIndex = 30;
            this.btn_Alter.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPlus;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Add.IconColor = System.Drawing.Color.Black;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.Location = new System.Drawing.Point(12, 556);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(91, 78);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconReload;
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.Location = new System.Drawing.Point(329, 556);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(91, 78);
            this.btn_Refresh.TabIndex = 32;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(11, 232);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(249, 36);
            this.txt_ID.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(6, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Mã Nhà Cung Cấp";
            // 
            // cbb_Search
            // 
            this.cbb_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Search.FormattingEnabled = true;
            this.cbb_Search.Items.AddRange(new object[] {
            "MaNCC",
            "SDT",
            "DiaChi"});
            this.cbb_Search.Location = new System.Drawing.Point(918, 81);
            this.cbb_Search.Name = "cbb_Search";
            this.cbb_Search.Size = new System.Drawing.Size(131, 46);
            this.cbb_Search.TabIndex = 37;
            // 
            // frmTypeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1380, 750);
            this.Controls.Add(this.cbb_Search);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Supplier);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NameSupplier);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmTypeProduct";
            this.Text = "frmTypeProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NameSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Supplier;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Alter;
        private FontAwesome.Sharp.IconButton btn_Add;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_Search;
    }
}