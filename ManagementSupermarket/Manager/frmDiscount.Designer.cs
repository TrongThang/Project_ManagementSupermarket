namespace ManagementSupermarket.Manager
{
    partial class frmDiscount
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NameSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_PriceDiscount = new System.Windows.Forms.Label();
            this.lbl_ErrorTimeEnd = new System.Windows.Forms.Label();
            this.cbb_UnitTime = new System.Windows.Forms.ComboBox();
            this.dgv_Supplier = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.cbb_Search = new System.Windows.Forms.ComboBox();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.chk_StatusDGV = new System.Windows.Forms.CheckBox();
            this.num_CountTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(20, 186);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(81, 29);
            this.lbl_Name.TabIndex = 28;
            this.lbl_Name.Text = "label4";
            this.lbl_Name.Visible = false;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(25, 262);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(248, 36);
            this.txt_Phone.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(20, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Giá Khuyến Mãi";
            // 
            // txt_NameSupplier
            // 
            this.txt_NameSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NameSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameSupplier.Location = new System.Drawing.Point(20, 147);
            this.txt_NameSupplier.Name = "txt_NameSupplier";
            this.txt_NameSupplier.Size = new System.Drawing.Size(347, 36);
            this.txt_NameSupplier.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(15, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên Khuyến Mãi";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(19, 43);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(249, 36);
            this.txt_ID.TabIndex = 23;
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_.Location = new System.Drawing.Point(14, 11);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(189, 29);
            this.lbl_.TabIndex = 22;
            this.lbl_.Text = "Mã Khuyến Mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(23, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ngày Bắt Đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(23, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Thời Hạn Khuyến Mãi";
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeStart.Location = new System.Drawing.Point(28, 377);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.Size = new System.Drawing.Size(248, 36);
            this.dtpTimeStart.TabIndex = 29;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.ForeColor = System.Drawing.Color.Red;
            this.lbl_Id.Location = new System.Drawing.Point(20, 82);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(81, 29);
            this.lbl_Id.TabIndex = 28;
            this.lbl_Id.Text = "label4";
            this.lbl_Id.Visible = false;
            // 
            // lbl_PriceDiscount
            // 
            this.lbl_PriceDiscount.AutoSize = true;
            this.lbl_PriceDiscount.ForeColor = System.Drawing.Color.Red;
            this.lbl_PriceDiscount.Location = new System.Drawing.Point(20, 298);
            this.lbl_PriceDiscount.Name = "lbl_PriceDiscount";
            this.lbl_PriceDiscount.Size = new System.Drawing.Size(81, 29);
            this.lbl_PriceDiscount.TabIndex = 28;
            this.lbl_PriceDiscount.Text = "label4";
            this.lbl_PriceDiscount.Visible = false;
            // 
            // lbl_ErrorTimeEnd
            // 
            this.lbl_ErrorTimeEnd.AutoSize = true;
            this.lbl_ErrorTimeEnd.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorTimeEnd.Location = new System.Drawing.Point(23, 508);
            this.lbl_ErrorTimeEnd.Name = "lbl_ErrorTimeEnd";
            this.lbl_ErrorTimeEnd.Size = new System.Drawing.Size(81, 29);
            this.lbl_ErrorTimeEnd.TabIndex = 28;
            this.lbl_ErrorTimeEnd.Text = "label4";
            this.lbl_ErrorTimeEnd.Visible = false;
            // 
            // cbb_UnitTime
            // 
            this.cbb_UnitTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_UnitTime.FormattingEnabled = true;
            this.cbb_UnitTime.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.cbb_UnitTime.Location = new System.Drawing.Point(185, 469);
            this.cbb_UnitTime.Name = "cbb_UnitTime";
            this.cbb_UnitTime.Size = new System.Drawing.Size(138, 37);
            this.cbb_UnitTime.TabIndex = 31;
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
            this.dgv_Supplier.Location = new System.Drawing.Point(401, 78);
            this.dgv_Supplier.MultiSelect = false;
            this.dgv_Supplier.Name = "dgv_Supplier";
            this.dgv_Supplier.ReadOnly = true;
            this.dgv_Supplier.RowHeadersWidth = 51;
            this.dgv_Supplier.RowTemplate.Height = 24;
            this.dgv_Supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Supplier.Size = new System.Drawing.Size(825, 560);
            this.dgv_Supplier.TabIndex = 32;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::ManagementSupermarket.Properties.Resources.pngtree_vector_trash_icon_png_image_865284;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Delete.IconColor = System.Drawing.Color.Black;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.Location = new System.Drawing.Point(194, 574);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(79, 64);
            this.btn_Delete.TabIndex = 35;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPencil;
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.Location = new System.Drawing.Point(109, 574);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(79, 64);
            this.btn_Alter.TabIndex = 34;
            this.btn_Alter.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPlus;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Add.IconColor = System.Drawing.Color.Black;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.Location = new System.Drawing.Point(24, 574);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 64);
            this.btn_Add.TabIndex = 33;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconReload;
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.Location = new System.Drawing.Point(279, 574);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(79, 64);
            this.btn_Refresh.TabIndex = 36;
            this.btn_Refresh.UseVisualStyleBackColor = true;
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
            this.cbb_Search.Location = new System.Drawing.Point(783, 26);
            this.cbb_Search.Name = "cbb_Search";
            this.cbb_Search.Size = new System.Drawing.Size(131, 46);
            this.cbb_Search.TabIndex = 39;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconSearch;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Search.IconColor = System.Drawing.Color.Black;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.Location = new System.Drawing.Point(1160, 27);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(65, 47);
            this.btn_Search.TabIndex = 37;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(916, 27);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(238, 45);
            this.txt_Search.TabIndex = 38;
            // 
            // chk_StatusDGV
            // 
            this.chk_StatusDGV.AutoSize = true;
            this.chk_StatusDGV.Checked = true;
            this.chk_StatusDGV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_StatusDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_StatusDGV.ForeColor = System.Drawing.Color.White;
            this.chk_StatusDGV.Location = new System.Drawing.Point(401, 31);
            this.chk_StatusDGV.Name = "chk_StatusDGV";
            this.chk_StatusDGV.Size = new System.Drawing.Size(202, 43);
            this.chk_StatusDGV.TabIndex = 40;
            this.chk_StatusDGV.Text = "Hoạt Động";
            this.chk_StatusDGV.UseVisualStyleBackColor = true;
            // 
            // num_CountTime
            // 
            this.num_CountTime.Location = new System.Drawing.Point(28, 469);
            this.num_CountTime.Name = "num_CountTime";
            this.num_CountTime.Size = new System.Drawing.Size(134, 36);
            this.num_CountTime.TabIndex = 41;
            this.num_CountTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1238, 650);
            this.Controls.Add(this.num_CountTime);
            this.Controls.Add(this.chk_StatusDGV);
            this.Controls.Add(this.cbb_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Supplier);
            this.Controls.Add(this.cbb_UnitTime);
            this.Controls.Add(this.dtpTimeStart);
            this.Controls.Add(this.lbl_ErrorTimeEnd);
            this.Controls.Add(this.lbl_PriceDiscount);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NameSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmDiscount";
            this.Text = "frmDiscount";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NameSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTimeStart;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_PriceDiscount;
        private System.Windows.Forms.Label lbl_ErrorTimeEnd;
        private System.Windows.Forms.ComboBox cbb_UnitTime;
        private System.Windows.Forms.DataGridView dgv_Supplier;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Alter;
        private FontAwesome.Sharp.IconButton btn_Add;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private System.Windows.Forms.ComboBox cbb_Search;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.CheckBox chk_StatusDGV;
        private System.Windows.Forms.NumericUpDown num_CountTime;
    }
}