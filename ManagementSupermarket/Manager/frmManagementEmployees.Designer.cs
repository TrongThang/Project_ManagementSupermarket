namespace ManagementSupermarket
{
    partial class frmManagementEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagementEmployees));
            this.dgv_ListEmployee = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cbb_SearchRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_Female = new System.Windows.Forms.RadioButton();
            this.rad_Male = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_CreatedTime = new System.Windows.Forms.DateTimePicker();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.chk_Status = new System.Windows.Forms.CheckBox();
            this.cbb_Role = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_ErrorName = new System.Windows.Forms.Label();
            this.lbl_ErrorCCCD = new System.Windows.Forms.Label();
            this.lbl_ErrorPhone = new System.Windows.Forms.Label();
            this.lbl_ErrorAddress = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.pic_Avatar = new FontAwesome.Sharp.IconPictureBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_EmployeeStatus = new System.Windows.Forms.CheckBox();
            this.btn_ExportExcel = new System.Windows.Forms.Button();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Alter = new FontAwesome.Sharp.IconButton();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListEmployee
            // 
            this.dgv_ListEmployee.AllowUserToAddRows = false;
            this.dgv_ListEmployee.AllowUserToDeleteRows = false;
            this.dgv_ListEmployee.AllowUserToOrderColumns = true;
            this.dgv_ListEmployee.AllowUserToResizeColumns = false;
            this.dgv_ListEmployee.AllowUserToResizeRows = false;
            this.dgv_ListEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListEmployee.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_ListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.CCCD,
            this.HoTen,
            this.GioiTinh,
            this.DiaChi,
            this.SDT,
            this.NgayTao,
            this.MaChucVu,
            this.TrangThai});
            this.dgv_ListEmployee.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_ListEmployee.Location = new System.Drawing.Point(15, 346);
            this.dgv_ListEmployee.MultiSelect = false;
            this.dgv_ListEmployee.Name = "dgv_ListEmployee";
            this.dgv_ListEmployee.ReadOnly = true;
            this.dgv_ListEmployee.RowHeadersWidth = 51;
            this.dgv_ListEmployee.RowTemplate.Height = 24;
            this.dgv_ListEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListEmployee.Size = new System.Drawing.Size(1264, 373);
            this.dgv_ListEmployee.TabIndex = 1;
            this.dgv_ListEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListEmployee_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.HeaderText = "NgayTao";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Chức Vụ";
            this.MaChucVu.MinimumWidth = 6;
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(974, 295);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(211, 45);
            this.txt_Search.TabIndex = 7;
            // 
            // cbb_SearchRole
            // 
            this.cbb_SearchRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_SearchRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_SearchRole.FormattingEnabled = true;
            this.cbb_SearchRole.Location = new System.Drawing.Point(857, 294);
            this.cbb_SearchRole.Name = "cbb_SearchRole";
            this.cbb_SearchRole.Size = new System.Drawing.Size(111, 46);
            this.cbb_SearchRole.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(638, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "CCCD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(410, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(838, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(208, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "SĐT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Female);
            this.groupBox1.Controls.Add(this.rad_Male);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(415, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rad_Female
            // 
            this.rad_Female.AutoSize = true;
            this.rad_Female.ForeColor = System.Drawing.Color.White;
            this.rad_Female.Location = new System.Drawing.Point(114, 32);
            this.rad_Female.Name = "rad_Female";
            this.rad_Female.Size = new System.Drawing.Size(61, 30);
            this.rad_Female.TabIndex = 1;
            this.rad_Female.TabStop = true;
            this.rad_Female.Text = "Nữ";
            this.rad_Female.UseVisualStyleBackColor = true;
            // 
            // rad_Male
            // 
            this.rad_Male.AutoSize = true;
            this.rad_Male.ForeColor = System.Drawing.Color.White;
            this.rad_Male.Location = new System.Drawing.Point(10, 32);
            this.rad_Male.Name = "rad_Male";
            this.rad_Male.Size = new System.Drawing.Size(80, 30);
            this.rad_Male.TabIndex = 0;
            this.rad_Male.TabStop = true;
            this.rad_Male.Text = "Nam";
            this.rad_Male.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_CreatedTime);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(614, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 76);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày Tạo";
            // 
            // dtp_CreatedTime
            // 
            this.dtp_CreatedTime.CustomFormat = "dd/MM/yyyy";
            this.dtp_CreatedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CreatedTime.Location = new System.Drawing.Point(6, 32);
            this.dtp_CreatedTime.Name = "dtp_CreatedTime";
            this.dtp_CreatedTime.Size = new System.Drawing.Size(181, 32);
            this.dtp_CreatedTime.TabIndex = 11;
            // 
            // txt_FullName
            // 
            this.txt_FullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FullName.Location = new System.Drawing.Point(415, 52);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(203, 32);
            this.txt_FullName.TabIndex = 17;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCCD.Location = new System.Drawing.Point(639, 52);
            this.txt_CCCD.MaxLength = 12;
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(178, 32);
            this.txt_CCCD.TabIndex = 18;
            this.txt_CCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressNumber);
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Location = new System.Drawing.Point(213, 158);
            this.txt_Phone.MaxLength = 10;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(179, 32);
            this.txt_Phone.TabIndex = 19;
            this.txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressNumber);
            // 
            // txt_Address
            // 
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Address.Location = new System.Drawing.Point(843, 52);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(315, 32);
            this.txt_Address.TabIndex = 20;
            // 
            // chk_Status
            // 
            this.chk_Status.AutoSize = true;
            this.chk_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Status.ForeColor = System.Drawing.Color.White;
            this.chk_Status.Location = new System.Drawing.Point(1013, 168);
            this.chk_Status.Name = "chk_Status";
            this.chk_Status.Size = new System.Drawing.Size(179, 40);
            this.chk_Status.TabIndex = 21;
            this.chk_Status.Text = "Hoạt Động";
            this.chk_Status.UseVisualStyleBackColor = true;
            // 
            // cbb_Role
            // 
            this.cbb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Role.FormattingEnabled = true;
            this.cbb_Role.Location = new System.Drawing.Point(827, 169);
            this.cbb_Role.Name = "cbb_Role";
            this.cbb_Role.Size = new System.Drawing.Size(168, 34);
            this.cbb_Role.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(827, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Chức Vụ";
            // 
            // lbl_ErrorName
            // 
            this.lbl_ErrorName.AutoSize = true;
            this.lbl_ErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorName.Location = new System.Drawing.Point(415, 84);
            this.lbl_ErrorName.Name = "lbl_ErrorName";
            this.lbl_ErrorName.Size = new System.Drawing.Size(53, 20);
            this.lbl_ErrorName.TabIndex = 26;
            this.lbl_ErrorName.Text = "label6";
            this.lbl_ErrorName.Visible = false;
            // 
            // lbl_ErrorCCCD
            // 
            this.lbl_ErrorCCCD.AutoSize = true;
            this.lbl_ErrorCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorCCCD.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCCCD.Location = new System.Drawing.Point(634, 84);
            this.lbl_ErrorCCCD.Name = "lbl_ErrorCCCD";
            this.lbl_ErrorCCCD.Size = new System.Drawing.Size(53, 20);
            this.lbl_ErrorCCCD.TabIndex = 26;
            this.lbl_ErrorCCCD.Text = "label6";
            this.lbl_ErrorCCCD.Visible = false;
            // 
            // lbl_ErrorPhone
            // 
            this.lbl_ErrorPhone.AutoSize = true;
            this.lbl_ErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPhone.Location = new System.Drawing.Point(208, 193);
            this.lbl_ErrorPhone.Name = "lbl_ErrorPhone";
            this.lbl_ErrorPhone.Size = new System.Drawing.Size(53, 20);
            this.lbl_ErrorPhone.TabIndex = 26;
            this.lbl_ErrorPhone.Text = "label6";
            this.lbl_ErrorPhone.Visible = false;
            // 
            // lbl_ErrorAddress
            // 
            this.lbl_ErrorAddress.AutoSize = true;
            this.lbl_ErrorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorAddress.Location = new System.Drawing.Point(844, 84);
            this.lbl_ErrorAddress.Name = "lbl_ErrorAddress";
            this.lbl_ErrorAddress.Size = new System.Drawing.Size(53, 20);
            this.lbl_ErrorAddress.TabIndex = 26;
            this.lbl_ErrorAddress.Text = "label6";
            this.lbl_ErrorAddress.Visible = false;
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpInfo.Controls.Add(this.lbl_ErrorAddress);
            this.grpInfo.Controls.Add(this.lbl_ErrorPhone);
            this.grpInfo.Controls.Add(this.lbl_ErrorCCCD);
            this.grpInfo.Controls.Add(this.lbl_ErrorName);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.cbb_Role);
            this.grpInfo.Controls.Add(this.pic_Avatar);
            this.grpInfo.Controls.Add(this.chk_Status);
            this.grpInfo.Controls.Add(this.txt_Address);
            this.grpInfo.Controls.Add(this.txt_Phone);
            this.grpInfo.Controls.Add(this.txt_CCCD);
            this.grpInfo.Controls.Add(this.txt_Id);
            this.grpInfo.Controls.Add(this.txt_FullName);
            this.grpInfo.Controls.Add(this.groupBox2);
            this.grpInfo.Controls.Add(this.groupBox1);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.ForeColor = System.Drawing.Color.Yellow;
            this.grpInfo.Location = new System.Drawing.Point(45, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1198, 240);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin";
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.BackColor = System.Drawing.Color.SlateGray;
            this.pic_Avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Avatar.BackgroundImage")));
            this.pic_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Avatar.ForeColor = System.Drawing.Color.Yellow;
            this.pic_Avatar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pic_Avatar.IconColor = System.Drawing.Color.Yellow;
            this.pic_Avatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pic_Avatar.IconSize = 164;
            this.pic_Avatar.Location = new System.Drawing.Point(20, 52);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Size = new System.Drawing.Size(169, 164);
            this.pic_Avatar.TabIndex = 22;
            this.pic_Avatar.TabStop = false;
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Location = new System.Drawing.Point(212, 52);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(180, 32);
            this.txt_Id.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // chk_EmployeeStatus
            // 
            this.chk_EmployeeStatus.AutoSize = true;
            this.chk_EmployeeStatus.Checked = true;
            this.chk_EmployeeStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_EmployeeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_EmployeeStatus.ForeColor = System.Drawing.Color.White;
            this.chk_EmployeeStatus.Location = new System.Drawing.Point(16, 300);
            this.chk_EmployeeStatus.Name = "chk_EmployeeStatus";
            this.chk_EmployeeStatus.Size = new System.Drawing.Size(328, 40);
            this.chk_EmployeeStatus.TabIndex = 27;
            this.chk_EmployeeStatus.Text = "Nhân Viên Hoạt Động";
            this.chk_EmployeeStatus.UseVisualStyleBackColor = true;
            this.chk_EmployeeStatus.CheckedChanged += new System.EventHandler(this.chk_EmployeeStatus_CheckedChanged);
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.BackgroundImage = global::ManagementSupermarket.Properties.Resources.png_clipart_microsoft_excel_logo_microsoft_excel_computer_icons_xls_microsoft_angle_text;
            this.btn_ExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ExportExcel.Location = new System.Drawing.Point(627, 276);
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            this.btn_ExportExcel.Size = new System.Drawing.Size(82, 64);
            this.btn_ExportExcel.TabIndex = 28;
            this.btn_ExportExcel.UseVisualStyleBackColor = true;
            this.btn_ExportExcel.Click += new System.EventHandler(this.btn_ExportExcel_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconSearch;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Search.IconColor = System.Drawing.Color.Black;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.Location = new System.Drawing.Point(1191, 277);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(88, 64);
            this.btn_Search.TabIndex = 6;
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
            this.btn_Refresh.Location = new System.Drawing.Point(729, 276);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(79, 64);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::ManagementSupermarket.Properties.Resources.pngtree_vector_trash_icon_png_image_865284;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Delete.IconColor = System.Drawing.Color.Black;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.Location = new System.Drawing.Point(542, 276);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(79, 64);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Alter
            // 
            this.btn_Alter.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconPencil;
            this.btn_Alter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Alter.IconColor = System.Drawing.Color.Black;
            this.btn_Alter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Alter.Location = new System.Drawing.Point(459, 276);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(79, 64);
            this.btn_Alter.TabIndex = 3;
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
            this.btn_Add.Location = new System.Drawing.Point(374, 276);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 64);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // frmManagementEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 731);
            this.Controls.Add(this.btn_ExportExcel);
            this.Controls.Add(this.chk_EmployeeStatus);
            this.Controls.Add(this.cbb_SearchRole);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_ListEmployee);
            this.Controls.Add(this.grpInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmManagementEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmManagementEmployee";
            this.Load += new System.EventHandler(this.frmManagementEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ListEmployee;
        private FontAwesome.Sharp.IconButton btn_Add;
        private FontAwesome.Sharp.IconButton btn_Alter;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Refresh;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.ComboBox cbb_SearchRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_Female;
        private System.Windows.Forms.RadioButton rad_Male;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_CreatedTime;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.CheckBox chk_Status;
        private FontAwesome.Sharp.IconPictureBox pic_Avatar;
        private System.Windows.Forms.ComboBox cbb_Role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_ErrorName;
        private System.Windows.Forms.Label lbl_ErrorCCCD;
        private System.Windows.Forms.Label lbl_ErrorPhone;
        private System.Windows.Forms.Label lbl_ErrorAddress;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_EmployeeStatus;
        private System.Windows.Forms.Button btn_ExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
    }
}