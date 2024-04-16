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
            this.SuspendLayout();
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_NewPassword.Location = new System.Drawing.Point(484, 253);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(347, 36);
            this.txt_NewPassword.TabIndex = 12;
            // 
            // txt_OldPassword
            // 
            this.txt_OldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_OldPassword.Location = new System.Drawing.Point(484, 187);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.Size = new System.Drawing.Size(347, 36);
            this.txt_OldPassword.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(215, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Xác Nhận Mật Khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(285, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mật Khẩu Mới:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(294, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mật Khẩu Cũ:";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(484, 321);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(347, 36);
            this.txt_ConfirmPassword.TabIndex = 12;
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.BackColor = System.Drawing.Color.Green;
            this.btn_ChangePassword.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_ChangePassword.IconColor = System.Drawing.Color.Lime;
            this.btn_ChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ChangePassword.IconSize = 80;
            this.btn_ChangePassword.Location = new System.Drawing.Point(723, 401);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(108, 73);
            this.btn_ChangePassword.TabIndex = 14;
            this.btn_ChangePassword.UseVisualStyleBackColor = false;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(479, 370);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(68, 29);
            this.lbl_Error.TabIndex = 15;
            this.lbl_Error.Text = "Error";
            this.lbl_Error.Visible = false;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 741);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.txt_OldPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmChangePassword";
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
    }
}