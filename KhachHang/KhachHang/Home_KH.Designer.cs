
namespace KhachHang
{
    partial class Home_KH
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
            this.dgv_SP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_Search_Home = new System.Windows.Forms.TextBox();
            this.btn_Search_Home = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Buy_Home = new System.Windows.Forms.Button();
            this.tb_TenSP_Home = new System.Windows.Forms.TextBox();
            this.tb_GiaBanSP_Home = new System.Windows.Forms.TextBox();
            this.tb_SoLuongSP_Home = new System.Windows.Forms.TextBox();
            this.tb_TongTien_Home = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_LoaiSP_Home = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_HTTT = new System.Windows.Forms.ComboBox();
            this.tb_DiaChiGH_Home = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SP
            // 
            this.dgv_SP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_SP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SP.Location = new System.Drawing.Point(114, 157);
            this.dgv_SP.Name = "dgv_SP";
            this.dgv_SP.RowHeadersWidth = 51;
            this.dgv_SP.RowTemplate.Height = 29;
            this.dgv_SP.Size = new System.Drawing.Size(972, 365);
            this.dgv_SP.TabIndex = 0;
            this.dgv_SP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SP_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(113, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 81);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::KhachHang.Properties.Resources.log_out;
            this.pictureBox1.Location = new System.Drawing.Point(899, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::KhachHang.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(374, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // tb_Search_Home
            // 
            this.tb_Search_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Search_Home.Location = new System.Drawing.Point(456, 110);
            this.tb_Search_Home.Name = "tb_Search_Home";
            this.tb_Search_Home.Size = new System.Drawing.Size(320, 27);
            this.tb_Search_Home.TabIndex = 4;
            this.tb_Search_Home.TextChanged += new System.EventHandler(this.tb_Search_Home_TextChanged);
            // 
            // btn_Search_Home
            // 
            this.btn_Search_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search_Home.Location = new System.Drawing.Point(826, 110);
            this.btn_Search_Home.Name = "btn_Search_Home";
            this.btn_Search_Home.Size = new System.Drawing.Size(104, 27);
            this.btn_Search_Home.TabIndex = 6;
            this.btn_Search_Home.Text = "Tìm Kiếm";
            this.btn_Search_Home.UseVisualStyleBackColor = true;
            this.btn_Search_Home.Click += new System.EventHandler(this.btn_Search_Home_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá Bán";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(970, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tổng Tiền";
            // 
            // btn_Buy_Home
            // 
            this.btn_Buy_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Buy_Home.Location = new System.Drawing.Point(941, 632);
            this.btn_Buy_Home.Name = "btn_Buy_Home";
            this.btn_Buy_Home.Size = new System.Drawing.Size(134, 51);
            this.btn_Buy_Home.TabIndex = 10;
            this.btn_Buy_Home.Text = "Mua Sản Phẩm";
            this.btn_Buy_Home.UseVisualStyleBackColor = true;
            this.btn_Buy_Home.Click += new System.EventHandler(this.btn_Buy_Home_Click);
            // 
            // tb_TenSP_Home
            // 
            this.tb_TenSP_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_TenSP_Home.Location = new System.Drawing.Point(220, 547);
            this.tb_TenSP_Home.Name = "tb_TenSP_Home";
            this.tb_TenSP_Home.ReadOnly = true;
            this.tb_TenSP_Home.Size = new System.Drawing.Size(176, 27);
            this.tb_TenSP_Home.TabIndex = 11;
            // 
            // tb_GiaBanSP_Home
            // 
            this.tb_GiaBanSP_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_GiaBanSP_Home.Location = new System.Drawing.Point(220, 601);
            this.tb_GiaBanSP_Home.Name = "tb_GiaBanSP_Home";
            this.tb_GiaBanSP_Home.ReadOnly = true;
            this.tb_GiaBanSP_Home.Size = new System.Drawing.Size(176, 27);
            this.tb_GiaBanSP_Home.TabIndex = 12;
            this.tb_GiaBanSP_Home.TextChanged += new System.EventHandler(this.tb_GiaBanSP_Home_TextChanged);
            // 
            // tb_SoLuongSP_Home
            // 
            this.tb_SoLuongSP_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_SoLuongSP_Home.Location = new System.Drawing.Point(650, 547);
            this.tb_SoLuongSP_Home.Name = "tb_SoLuongSP_Home";
            this.tb_SoLuongSP_Home.Size = new System.Drawing.Size(176, 27);
            this.tb_SoLuongSP_Home.TabIndex = 13;
            this.tb_SoLuongSP_Home.TextChanged += new System.EventHandler(this.tb_SoLuongSP_Home_TextChanged);
            // 
            // tb_TongTien_Home
            // 
            this.tb_TongTien_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_TongTien_Home.Location = new System.Drawing.Point(924, 570);
            this.tb_TongTien_Home.Name = "tb_TongTien_Home";
            this.tb_TongTien_Home.ReadOnly = true;
            this.tb_TongTien_Home.Size = new System.Drawing.Size(162, 27);
            this.tb_TongTien_Home.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 653);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Loại Sản Phẩm";
            // 
            // tb_LoaiSP_Home
            // 
            this.tb_LoaiSP_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_LoaiSP_Home.Location = new System.Drawing.Point(220, 653);
            this.tb_LoaiSP_Home.Name = "tb_LoaiSP_Home";
            this.tb_LoaiSP_Home.ReadOnly = true;
            this.tb_LoaiSP_Home.Size = new System.Drawing.Size(176, 27);
            this.tb_LoaiSP_Home.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hình thức thanh toán";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 656);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Địa Chỉ Giao Hàng";
            // 
            // comboBox_HTTT
            // 
            this.comboBox_HTTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_HTTT.FormattingEnabled = true;
            this.comboBox_HTTT.Items.AddRange(new object[] {
            "Master Card",
            "MoMo",
            "Visa",
            "Cod"});
            this.comboBox_HTTT.Location = new System.Drawing.Point(650, 601);
            this.comboBox_HTTT.Name = "comboBox_HTTT";
            this.comboBox_HTTT.Size = new System.Drawing.Size(176, 28);
            this.comboBox_HTTT.TabIndex = 20;
            // 
            // tb_DiaChiGH_Home
            // 
            this.tb_DiaChiGH_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_DiaChiGH_Home.Location = new System.Drawing.Point(650, 656);
            this.tb_DiaChiGH_Home.Name = "tb_DiaChiGH_Home";
            this.tb_DiaChiGH_Home.Size = new System.Drawing.Size(176, 27);
            this.tb_DiaChiGH_Home.TabIndex = 21;
            // 
            // Home_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1196, 771);
            this.Controls.Add(this.tb_DiaChiGH_Home);
            this.Controls.Add(this.comboBox_HTTT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_LoaiSP_Home);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_TongTien_Home);
            this.Controls.Add(this.tb_SoLuongSP_Home);
            this.Controls.Add(this.tb_GiaBanSP_Home);
            this.Controls.Add(this.tb_TenSP_Home);
            this.Controls.Add(this.btn_Buy_Home);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Search_Home);
            this.Controls.Add(this.tb_Search_Home);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_SP);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Home_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SP;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tb_Search_Home;
        private System.Windows.Forms.Button btn_Search_Home;
        private System.Windows.Forms.Button btn_Buy_Home;
        private System.Windows.Forms.TextBox tb_TenSP_Home;
        private System.Windows.Forms.TextBox tb_GiaBanSP_Home;
        private System.Windows.Forms.TextBox tb_SoLuongSP_Home;
        private System.Windows.Forms.TextBox tb_TongTien_Home;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_LoaiSP_Home;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_HTTT;
        private System.Windows.Forms.TextBox tb_DiaChiGH_Home;
    }
}