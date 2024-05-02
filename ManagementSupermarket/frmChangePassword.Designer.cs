namespace ManagementSupermarket
{
    partial class frmChangePassword
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
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.txt_OldPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.btn_ChangePassword = new FontAwesome.Sharp.IconButton();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btnShowHideNewPassword = new FontAwesome.Sharp.IconButton();
            this.btnShowHideConfirmPassword = new FontAwesome.Sharp.IconButton();
            this.btnShowHideOldPassword = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_NewPassword.Location = new System.Drawing.Point(550, 289);
            this.txt_NewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(393, 45);
            this.txt_NewPassword.TabIndex = 12;
            this.txt_NewPassword.UseSystemPasswordChar = true;
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_OldPassword.Location = new System.Drawing.Point(550, 207);
            this.txt_OldPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.Size = new System.Drawing.Size(393, 45);
            this.txt_OldPassword.TabIndex = 13;
            this.txt_OldPassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(169, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(330, 39);
            this.label10.TabIndex = 9;
            this.label10.Text = "Xác Nhận Mật Khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(277, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mật Khẩu Mới:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(289, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mật Khẩu Cũ:";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(550, 373);
            this.txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(393, 45);
            this.txt_ConfirmPassword.TabIndex = 12;
            this.txt_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.BackColor = System.Drawing.Color.Green;
            this.btn_ChangePassword.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_ChangePassword.IconColor = System.Drawing.Color.Lime;
            this.btn_ChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ChangePassword.IconSize = 80;
            this.btn_ChangePassword.Location = new System.Drawing.Point(821, 495);
            this.btn_ChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(122, 91);
            this.btn_ChangePassword.TabIndex = 14;
            this.btn_ChangePassword.UseVisualStyleBackColor = false;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(544, 433);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(82, 36);
            this.lbl_Error.TabIndex = 15;
            this.lbl_Error.Text = "Error";
            this.lbl_Error.Visible = false;
            // 
            // btnShowHideNewPassword
            // 
            this.btnShowHideNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHideNewPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnShowHideNewPassword.IconColor = System.Drawing.Color.Black;
            this.btnShowHideNewPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnShowHideNewPassword.IconSize = 45;
            this.btnShowHideNewPassword.Location = new System.Drawing.Point(891, 289);
            this.btnShowHideNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowHideNewPassword.Name = "btnShowHideNewPassword";
            this.btnShowHideNewPassword.Size = new System.Drawing.Size(52, 48);
            this.btnShowHideNewPassword.TabIndex = 16;
            this.btnShowHideNewPassword.UseVisualStyleBackColor = false;
            this.btnShowHideNewPassword.Click += new System.EventHandler(this.btnShowHideNewPassword_Click);
            // 
            // btnShowHideConfirmPassword
            // 
            this.btnShowHideConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHideConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnShowHideConfirmPassword.IconColor = System.Drawing.Color.Black;
            this.btnShowHideConfirmPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnShowHideConfirmPassword.IconSize = 45;
            this.btnShowHideConfirmPassword.Location = new System.Drawing.Point(891, 373);
            this.btnShowHideConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowHideConfirmPassword.Name = "btnShowHideConfirmPassword";
            this.btnShowHideConfirmPassword.Size = new System.Drawing.Size(52, 48);
            this.btnShowHideConfirmPassword.TabIndex = 17;
            this.btnShowHideConfirmPassword.UseVisualStyleBackColor = false;
            this.btnShowHideConfirmPassword.Click += new System.EventHandler(this.btnShowHideConfirmPassword_Click);
            // 
            // btnShowHideOldPassword
            // 
            this.btnShowHideOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHideOldPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnShowHideOldPassword.IconColor = System.Drawing.Color.Black;
            this.btnShowHideOldPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnShowHideOldPassword.IconSize = 45;
            this.btnShowHideOldPassword.Location = new System.Drawing.Point(891, 207);
            this.btnShowHideOldPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowHideOldPassword.Name = "btnShowHideOldPassword";
            this.btnShowHideOldPassword.Size = new System.Drawing.Size(52, 48);
            this.btnShowHideOldPassword.TabIndex = 18;
            this.btnShowHideOldPassword.UseVisualStyleBackColor = false;
            this.btnShowHideOldPassword.Click += new System.EventHandler(this.btnShowHideOldPassword_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1274, 684);
            this.Controls.Add(this.btnShowHideOldPassword);
            this.Controls.Add(this.btnShowHideConfirmPassword);
            this.Controls.Add(this.btnShowHideNewPassword);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.txt_OldPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.TextBox txt_OldPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private FontAwesome.Sharp.IconButton btn_ChangePassword;
        private System.Windows.Forms.Label lbl_Error;
        private FontAwesome.Sharp.IconButton btnShowHideNewPassword;
        private FontAwesome.Sharp.IconButton btnShowHideConfirmPassword;
        private FontAwesome.Sharp.IconButton btnShowHideOldPassword;
    }
}