namespace ManagementSupermarket.Manager
{
    partial class frmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounts));
            this.btn_ExportExcel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.dgv_Accounts = new System.Windows.Forms.DataGridView();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.cbb_Search = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.chk_Status = new System.Windows.Forms.CheckBox();
            this.chk_Active = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.BackgroundImage = global::ManagementSupermarket.Properties.Resources.png_clipart_microsoft_excel_logo_microsoft_excel_computer_icons_xls_microsoft_angle_text;
            this.btn_ExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExportExcel.Location = new System.Drawing.Point(548, 28);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(89, 70);
            this.btn_ExportExcel.TabIndex = 39;
            this.btn_ExportExcel.UseVisualStyleBackColor = true;
            this.btn_ExportExcel.Click += new System.EventHandler(this.btn_ExportExcel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSearch.Location = new System.Drawing.Point(997, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 36);
            this.txtSearch.TabIndex = 35;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconSearch;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Location = new System.Drawing.Point(1213, 59);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(67, 40);
            this.btn_Search.TabIndex = 34;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconReload;
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.Location = new System.Drawing.Point(641, 29);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(86, 70);
            this.btn_Refresh.TabIndex = 33;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_Accounts
            // 
            this.dgv_Accounts.AllowUserToAddRows = false;
            this.dgv_Accounts.AllowUserToDeleteRows = false;
            this.dgv_Accounts.AllowUserToOrderColumns = true;
            this.dgv_Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Accounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Accounts.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.MatKhau,
            this.TenChucVu,
            this.TrangThai});
            this.dgv_Accounts.Location = new System.Drawing.Point(12, 104);
            this.dgv_Accounts.MultiSelect = false;
            this.dgv_Accounts.Name = "dgv_Accounts";
            this.dgv_Accounts.ReadOnly = true;
            this.dgv_Accounts.RowHeadersWidth = 51;
            this.dgv_Accounts.RowTemplate.Height = 24;
            this.dgv_Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Accounts.Size = new System.Drawing.Size(1268, 615);
            this.dgv_Accounts.TabIndex = 32;
            this.dgv_Accounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Accounts_CellClick);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ChangePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChangePassword.BackgroundImage")));
            this.btn_ChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ChangePassword.Location = new System.Drawing.Point(449, 29);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(94, 70);
            this.btn_ChangePassword.TabIndex = 39;
            this.btn_ChangePassword.UseVisualStyleBackColor = false;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // cbb_Search
            // 
            this.cbb_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbb_Search.FormattingEnabled = true;
            this.cbb_Search.Items.AddRange(new object[] {
            "MaHD",
            "MaNV",
            "MaKH"});
            this.cbb_Search.Location = new System.Drawing.Point(860, 63);
            this.cbb_Search.Name = "cbb_Search";
            this.cbb_Search.Size = new System.Drawing.Size(131, 37);
            this.cbb_Search.TabIndex = 40;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Password.Location = new System.Drawing.Point(14, 63);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(267, 36);
            this.txt_Password.TabIndex = 35;
            // 
            // chk_Status
            // 
            this.chk_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_Status.AutoSize = true;
            this.chk_Status.Checked = true;
            this.chk_Status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Status.ForeColor = System.Drawing.SystemColors.Control;
            this.chk_Status.Location = new System.Drawing.Point(1078, 10);
            this.chk_Status.Name = "chk_Status";
            this.chk_Status.Size = new System.Drawing.Size(202, 43);
            this.chk_Status.TabIndex = 41;
            this.chk_Status.Text = "Hoạt Động";
            this.chk_Status.UseVisualStyleBackColor = true;
            this.chk_Status.CheckedChanged += new System.EventHandler(this.chk_Status_CheckedChanged);
            // 
            // chk_Active
            // 
            this.chk_Active.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_Active.AutoSize = true;
            this.chk_Active.ForeColor = System.Drawing.SystemColors.Control;
            this.chk_Active.Location = new System.Drawing.Point(287, 66);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(156, 33);
            this.chk_Active.TabIndex = 41;
            this.chk_Active.Text = "Trạng Thái";
            this.chk_Active.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mật Khẩu";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.HeaderText = "Chức Vụ";
            this.TenChucVu.MinimumWidth = 6;
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1292, 731);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_Status);
            this.Controls.Add(this.chk_Active);
            this.Controls.Add(this.cbb_Search);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.btn_ExportExcel);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Accounts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAccounts";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ExportExcel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btn_Search;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_Accounts;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.ComboBox cbb_Search;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.CheckBox chk_Status;
        private System.Windows.Forms.CheckBox chk_Active;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
    }
}