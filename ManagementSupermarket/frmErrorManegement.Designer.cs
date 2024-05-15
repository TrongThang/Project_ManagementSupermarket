namespace ManagementSupermarket
{
    partial class frmErrorManegement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmErrorManegement));
            this.dgv_Errors = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTriLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chk_StatusListError = new System.Windows.Forms.CheckBox();
            this.btn_Fix = new FontAwesome.Sharp.IconButton();
            this.chk_StatusOfError = new System.Windows.Forms.CheckBox();
            this.grp_Error = new System.Windows.Forms.GroupBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_Refresh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Errors)).BeginInit();
            this.grp_Error.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Errors
            // 
            this.dgv_Errors.AllowUserToAddRows = false;
            this.dgv_Errors.AllowUserToDeleteRows = false;
            this.dgv_Errors.AllowUserToOrderColumns = true;
            this.dgv_Errors.AllowUserToResizeColumns = false;
            this.dgv_Errors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Errors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Errors.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_Errors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Errors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenLoi,
            this.ViTriLoi,
            this.ThoiGian,
            this.TrangThai});
            this.dgv_Errors.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Errors.Location = new System.Drawing.Point(12, 125);
            this.dgv_Errors.MultiSelect = false;
            this.dgv_Errors.Name = "dgv_Errors";
            this.dgv_Errors.ReadOnly = true;
            this.dgv_Errors.RowHeadersWidth = 51;
            this.dgv_Errors.RowTemplate.Height = 24;
            this.dgv_Errors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Errors.Size = new System.Drawing.Size(1250, 547);
            this.dgv_Errors.TabIndex = 10;
            this.dgv_Errors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Errors_CellClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // TenLoi
            // 
            this.TenLoi.DataPropertyName = "TenLoi";
            this.TenLoi.HeaderText = "Lỗi";
            this.TenLoi.MinimumWidth = 6;
            this.TenLoi.Name = "TenLoi";
            this.TenLoi.ReadOnly = true;
            // 
            // ViTriLoi
            // 
            this.ViTriLoi.DataPropertyName = "ViTriLoi";
            this.ViTriLoi.HeaderText = "Vị Trí Lỗi";
            this.ViTriLoi.MinimumWidth = 6;
            this.ViTriLoi.Name = "ViTriLoi";
            this.ViTriLoi.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời Gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
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
            // chk_StatusListError
            // 
            this.chk_StatusListError.AutoSize = true;
            this.chk_StatusListError.Checked = true;
            this.chk_StatusListError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_StatusListError.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_StatusListError.ForeColor = System.Drawing.Color.White;
            this.chk_StatusListError.Location = new System.Drawing.Point(992, 49);
            this.chk_StatusListError.Name = "chk_StatusListError";
            this.chk_StatusListError.Size = new System.Drawing.Size(270, 52);
            this.chk_StatusListError.TabIndex = 18;
            this.chk_StatusListError.Text = "Lỗi Cần Sửa";
            this.chk_StatusListError.UseVisualStyleBackColor = true;
            this.chk_StatusListError.CheckedChanged += new System.EventHandler(this.chk_StatusListError_CheckedChanged);
            // 
            // btn_Fix
            // 
            this.btn_Fix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Fix.BackgroundImage")));
            this.btn_Fix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Fix.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Fix.IconColor = System.Drawing.Color.Black;
            this.btn_Fix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Fix.Location = new System.Drawing.Point(243, 26);
            this.btn_Fix.Name = "btn_Fix";
            this.btn_Fix.Size = new System.Drawing.Size(91, 63);
            this.btn_Fix.TabIndex = 19;
            this.btn_Fix.UseVisualStyleBackColor = true;
            this.btn_Fix.Click += new System.EventHandler(this.btn_Fix_Click);
            // 
            // chk_StatusOfError
            // 
            this.chk_StatusOfError.AutoSize = true;
            this.chk_StatusOfError.Checked = true;
            this.chk_StatusOfError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_StatusOfError.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_StatusOfError.ForeColor = System.Drawing.Color.White;
            this.chk_StatusOfError.Location = new System.Drawing.Point(18, 41);
            this.chk_StatusOfError.Name = "chk_StatusOfError";
            this.chk_StatusOfError.Size = new System.Drawing.Size(221, 46);
            this.chk_StatusOfError.TabIndex = 18;
            this.chk_StatusOfError.Text = "Trạng Thái";
            this.chk_StatusOfError.UseVisualStyleBackColor = true;
            // 
            // grp_Error
            // 
            this.grp_Error.Controls.Add(this.btn_Fix);
            this.grp_Error.Controls.Add(this.chk_StatusOfError);
            this.grp_Error.ForeColor = System.Drawing.Color.Yellow;
            this.grp_Error.Location = new System.Drawing.Point(12, 12);
            this.grp_Error.Name = "grp_Error";
            this.grp_Error.Size = new System.Drawing.Size(344, 100);
            this.grp_Error.TabIndex = 20;
            this.grp_Error.TabStop = false;
            this.grp_Error.Text = "Quản Lý Lỗi";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(403, 44);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(454, 42);
            this.lbl_Error.TabIndex = 21;
            this.lbl_Error.Text = "⚠️Có Lỗi Cần Chỉnh Sửa";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Error.Visible = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackgroundImage = global::ManagementSupermarket.Properties.Resources.iconReload;
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Refresh.IconColor = System.Drawing.Color.Black;
            this.btn_Refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Refresh.Location = new System.Drawing.Point(907, 37);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(79, 64);
            this.btn_Refresh.TabIndex = 22;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frmErrorManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1274, 684);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.grp_Error);
            this.Controls.Add(this.chk_StatusListError);
            this.Controls.Add(this.dgv_Errors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmErrorManegement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmErrorManegement";
            this.Load += new System.EventHandler(this.frmErrorManegement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Errors)).EndInit();
            this.grp_Error.ResumeLayout(false);
            this.grp_Error.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Errors;
        private System.Windows.Forms.CheckBox chk_StatusListError;
        private FontAwesome.Sharp.IconButton btn_Fix;
        private System.Windows.Forms.CheckBox chk_StatusOfError;
        private System.Windows.Forms.GroupBox grp_Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTriLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
        private System.Windows.Forms.Label lbl_Error;
        private FontAwesome.Sharp.IconButton btn_Refresh;
    }
}