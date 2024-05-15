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
            this.txt_PriceDiscount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NameDiscount = new System.Windows.Forms.TextBox();
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
            this.dgv_ListDiscount = new System.Windows.Forms.DataGridView();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.chk_DiscountStatus = new System.Windows.Forms.CheckBox();
            this.num_CountTime = new System.Windows.Forms.NumericUpDown();
            this.cbb_SearchRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(12, 246);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(81, 29);
            this.lbl_Name.TabIndex = 28;
            this.lbl_Name.Text = "label4";
            this.lbl_Name.Visible = false;
            // 
            // txt_PriceDiscount
            // 
            this.txt_PriceDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PriceDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PriceDiscount.Location = new System.Drawing.Point(17, 322);
            this.txt_PriceDiscount.Name = "txt_PriceDiscount";
            this.txt_PriceDiscount.Size = new System.Drawing.Size(248, 36);
            this.txt_PriceDiscount.TabIndex = 27;
            this.txt_PriceDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressNumber);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "Giá Khuyến Mãi (%)";
            // 
            // txt_NameDiscount
            // 
            this.txt_NameDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NameDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameDiscount.Location = new System.Drawing.Point(12, 207);
            this.txt_NameDiscount.Name = "txt_NameDiscount";
            this.txt_NameDiscount.Size = new System.Drawing.Size(347, 36);
            this.txt_NameDiscount.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(7, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên Khuyến Mãi";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(11, 103);
            this.txt_ID.MaxLength = 10;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(249, 36);
            this.txt_ID.TabIndex = 23;
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_.Location = new System.Drawing.Point(6, 71);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(464, 36);
            this.lbl_.TabIndex = 22;
            this.lbl_.Text = "Mã Khuyến Mãi (Tối đa10 ký tự)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(15, 391);
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
            this.label4.Location = new System.Drawing.Point(15, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Thời Hạn Khuyến Mãi";
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeStart.Location = new System.Drawing.Point(20, 437);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.Size = new System.Drawing.Size(248, 36);
            this.dtpTimeStart.TabIndex = 29;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.ForeColor = System.Drawing.Color.Red;
            this.lbl_Id.Location = new System.Drawing.Point(12, 142);
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
            this.lbl_PriceDiscount.Location = new System.Drawing.Point(12, 358);
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
            this.lbl_ErrorTimeEnd.Location = new System.Drawing.Point(15, 568);
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
            this.cbb_UnitTime.Location = new System.Drawing.Point(177, 529);
            this.cbb_UnitTime.Name = "cbb_UnitTime";
            this.cbb_UnitTime.Size = new System.Drawing.Size(138, 37);
            this.cbb_UnitTime.TabIndex = 31;
            // 
            // dgv_ListDiscount
            // 
            this.dgv_ListDiscount.AllowUserToAddRows = false;
            this.dgv_ListDiscount.AllowUserToDeleteRows = false;
            this.dgv_ListDiscount.AllowUserToOrderColumns = true;
            this.dgv_ListDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListDiscount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_ListDiscount.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_ListDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKM,
            this.TenKM,
            this.GiaKhuyenMai,
            this.NgayBatDau,
            this.NgayKetThuc});
            this.dgv_ListDiscount.Location = new System.Drawing.Point(401, 78);
            this.dgv_ListDiscount.MultiSelect = false;
            this.dgv_ListDiscount.Name = "dgv_ListDiscount";
            this.dgv_ListDiscount.ReadOnly = true;
            this.dgv_ListDiscount.RowHeadersWidth = 51;
            this.dgv_ListDiscount.RowTemplate.Height = 24;
            this.dgv_ListDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListDiscount.Size = new System.Drawing.Size(879, 641);
            this.dgv_ListDiscount.TabIndex = 32;
            this.dgv_ListDiscount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListDiscount_CellClick);
            // 
            // MaKM
            // 
            this.MaKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaKM.DataPropertyName = "MaKM";
            this.MaKM.Frozen = true;
            this.MaKM.HeaderText = "Mã KM";
            this.MaKM.MinimumWidth = 6;
            this.MaKM.Name = "MaKM";
            this.MaKM.ReadOnly = true;
            this.MaKM.Width = 125;
            // 
            // TenKM
            // 
            this.TenKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenKM.DataPropertyName = "TenKM";
            this.TenKM.Frozen = true;
            this.TenKM.HeaderText = "Tên KM";
            this.TenKM.MinimumWidth = 6;
            this.TenKM.Name = "TenKM";
            this.TenKM.ReadOnly = true;
            this.TenKM.Width = 125;
            // 
            // GiaKhuyenMai
            // 
            this.GiaKhuyenMai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GiaKhuyenMai.DataPropertyName = "GiaKhuyenMai";
            this.GiaKhuyenMai.Frozen = true;
            this.GiaKhuyenMai.HeaderText = "Giá KM";
            this.GiaKhuyenMai.MinimumWidth = 6;
            this.GiaKhuyenMai.Name = "GiaKhuyenMai";
            this.GiaKhuyenMai.ReadOnly = true;
            this.GiaKhuyenMai.Width = 125;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPencil;
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.Location = new System.Drawing.Point(116, 634);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(79, 64);
            this.btn_Alter.TabIndex = 34;
            this.btn_Alter.UseVisualStyleBackColor = true;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPlus;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Add.IconColor = System.Drawing.Color.Black;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.Location = new System.Drawing.Point(16, 634);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 64);
            this.btn_Add.TabIndex = 33;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconReload;
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.Location = new System.Drawing.Point(219, 634);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(79, 64);
            this.btn_Refresh.TabIndex = 36;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconSearch;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Search.IconColor = System.Drawing.Color.Black;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.Location = new System.Drawing.Point(1215, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(65, 47);
            this.btn_Search.TabIndex = 37;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(971, 28);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(238, 45);
            this.txt_Search.TabIndex = 38;
            // 
            // chk_DiscountStatus
            // 
            this.chk_DiscountStatus.AutoSize = true;
            this.chk_DiscountStatus.Checked = true;
            this.chk_DiscountStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_DiscountStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_DiscountStatus.ForeColor = System.Drawing.Color.White;
            this.chk_DiscountStatus.Location = new System.Drawing.Point(401, 31);
            this.chk_DiscountStatus.Name = "chk_DiscountStatus";
            this.chk_DiscountStatus.Size = new System.Drawing.Size(202, 43);
            this.chk_DiscountStatus.TabIndex = 40;
            this.chk_DiscountStatus.Text = "Hoạt Động";
            this.chk_DiscountStatus.UseVisualStyleBackColor = true;
            this.chk_DiscountStatus.CheckedChanged += new System.EventHandler(this.chk_DiscountStatus_CheckedChanged);
            // 
            // num_CountTime
            // 
            this.num_CountTime.Location = new System.Drawing.Point(20, 529);
            this.num_CountTime.Name = "num_CountTime";
            this.num_CountTime.Size = new System.Drawing.Size(134, 36);
            this.num_CountTime.TabIndex = 41;
            this.num_CountTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbb_SearchRole
            // 
            this.cbb_SearchRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_SearchRole.FormattingEnabled = true;
            this.cbb_SearchRole.Items.AddRange(new object[] {
            "MaKM",
            "TenKM"});
            this.cbb_SearchRole.Location = new System.Drawing.Point(834, 34);
            this.cbb_SearchRole.Name = "cbb_SearchRole";
            this.cbb_SearchRole.Size = new System.Drawing.Size(131, 37);
            this.cbb_SearchRole.TabIndex = 42;
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1292, 731);
            this.Controls.Add(this.cbb_SearchRole);
            this.Controls.Add(this.num_CountTime);
            this.Controls.Add(this.chk_DiscountStatus);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_ListDiscount);
            this.Controls.Add(this.cbb_UnitTime);
            this.Controls.Add(this.dtpTimeStart);
            this.Controls.Add(this.lbl_ErrorTimeEnd);
            this.Controls.Add(this.lbl_PriceDiscount);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_PriceDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NameDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDiscount";
            this.Load += new System.EventHandler(this.frmDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_PriceDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NameDiscount;
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
        private System.Windows.Forms.DataGridView dgv_ListDiscount;
        private FontAwesome.Sharp.IconButton btn_Alter;
        private FontAwesome.Sharp.IconButton btn_Add;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.CheckBox chk_DiscountStatus;
        private System.Windows.Forms.NumericUpDown num_CountTime;
        private System.Windows.Forms.ComboBox cbb_SearchRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
    }
}