
namespace KhachHang
{
    partial class KhachHANG
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1_KH = new System.Windows.Forms.PictureBox();
            this.label3_KH = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_TaiKhoan_KH = new System.Windows.Forms.TextBox();
            this.tb_MatKhau_KH = new System.Windows.Forms.TextBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btnexit_KH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1_KH
            // 
            this.pictureBox1_KH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1_KH.Image = global::KhachHang.Properties.Resources.login;
            this.pictureBox1_KH.Location = new System.Drawing.Point(614, 1);
            this.pictureBox1_KH.Name = "pictureBox1_KH";
            this.pictureBox1_KH.Size = new System.Drawing.Size(406, 548);
            this.pictureBox1_KH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_KH.TabIndex = 3;
            this.pictureBox1_KH.TabStop = false;
            // 
            // label3_KH
            // 
            this.label3_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3_KH.AutoSize = true;
            this.label3_KH.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3_KH.Location = new System.Drawing.Point(111, 26);
            this.label3_KH.Name = "label3_KH";
            this.label3_KH.Size = new System.Drawing.Size(482, 31);
            this.label3_KH.TabIndex = 4;
            this.label3_KH.Text = "CHÀO MỪNG ĐẾN VỚI CỬA HÀNG ONLINE ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::KhachHang.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(111, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(294, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đăng Nhập";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::KhachHang.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(111, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // tb_TaiKhoan_KH
            // 
            this.tb_TaiKhoan_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_TaiKhoan_KH.Location = new System.Drawing.Point(205, 195);
            this.tb_TaiKhoan_KH.Name = "tb_TaiKhoan_KH";
            this.tb_TaiKhoan_KH.Size = new System.Drawing.Size(291, 27);
            this.tb_TaiKhoan_KH.TabIndex = 1;
            // 
            // tb_MatKhau_KH
            // 
            this.tb_MatKhau_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_MatKhau_KH.Location = new System.Drawing.Point(205, 280);
            this.tb_MatKhau_KH.Name = "tb_MatKhau_KH";
            this.tb_MatKhau_KH.Size = new System.Drawing.Size(291, 27);
            this.tb_MatKhau_KH.TabIndex = 2;
            this.tb_MatKhau_KH.UseSystemPasswordChar = true;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangKy.Location = new System.Drawing.Point(205, 347);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(94, 30);
            this.btn_DangKy.TabIndex = 10;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangNhap.Location = new System.Drawing.Point(393, 347);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(94, 30);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btnexit_KH
            // 
            this.btnexit_KH.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexit_KH.Location = new System.Drawing.Point(273, 440);
            this.btnexit_KH.Name = "btnexit_KH";
            this.btnexit_KH.Size = new System.Drawing.Size(129, 41);
            this.btnexit_KH.TabIndex = 12;
            this.btnexit_KH.Text = "Thoát";
            this.btnexit_KH.UseVisualStyleBackColor = true;
            this.btnexit_KH.Click += new System.EventHandler(this.btnexit_KH_Click);
            // 
            // KhachHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 553);
            this.Controls.Add(this.btnexit_KH);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.tb_MatKhau_KH);
            this.Controls.Add(this.tb_TaiKhoan_KH);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3_KH);
            this.Controls.Add(this.pictureBox1_KH);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "KhachHANG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khach Hang";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1_KH;
        private System.Windows.Forms.Label label3_KH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_TaiKhoan_KH;
        private System.Windows.Forms.TextBox tb_MatKhau_KH;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btnexit_KH;
    }
}

