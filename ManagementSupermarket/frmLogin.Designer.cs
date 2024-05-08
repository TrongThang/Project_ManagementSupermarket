namespace ManagementSupermarket
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnShowHidePassword = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(188, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(200, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // txt_Username
            // 
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(339, 164);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(286, 36);
            this.txt_Username.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_Login.ForeColor = System.Drawing.Color.Black;
            this.btn_Login.Location = new System.Drawing.Point(260, 291);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(134, 42);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(249, 251);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(52, 24);
            this.lbl_Error.TabIndex = 7;
            this.lbl_Error.Text = "Error";
            this.lbl_Error.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(188, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tài Khoản:";
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(339, 210);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(234, 36);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(446, 291);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(134, 42);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnShowHidePassword
            // 
            this.btnShowHidePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHidePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnShowHidePassword.IconColor = System.Drawing.Color.Black;
            this.btnShowHidePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowHidePassword.IconSize = 45;
            this.btnShowHidePassword.Location = new System.Drawing.Point(579, 210);
            this.btnShowHidePassword.Name = "btnShowHidePassword";
            this.btnShowHidePassword.Size = new System.Drawing.Size(46, 36);
            this.btnShowHidePassword.TabIndex = 8;
            this.btnShowHidePassword.UseVisualStyleBackColor = false;
            this.btnShowHidePassword.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 461);
            this.Controls.Add(this.btnShowHidePassword);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(845, 512);
            this.MinimumSize = new System.Drawing.Size(845, 512);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Exit;
        private FontAwesome.Sharp.IconButton btnShowHidePassword;
    }
}