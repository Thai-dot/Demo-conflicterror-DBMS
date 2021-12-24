
namespace unrepeatable_read2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.txb_MaSP = new System.Windows.Forms.TextBox();
            this.txb_GiaBan = new System.Windows.Forms.TextBox();
            this.txb_TenSP = new System.Windows.Forms.TextBox();
            this.txb_PhanLoai = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(115, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demo Unrepeatable Read 2 (Khách Hàng Xem Sản Phẩm)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã SP";
            // 
            // dgv_1
            // 
            this.dgv_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(65, 132);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(778, 246);
            this.dgv_1.TabIndex = 3;
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellContentClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá Bán ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phân Loại";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::unrepeatable_read2.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(284, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txb_search
            // 
            this.txb_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_search.Location = new System.Drawing.Point(345, 90);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(211, 22);
            this.txb_search.TabIndex = 7;
            this.txb_search.TextChanged += new System.EventHandler(this.txb_search_TextChanged);
            // 
            // txb_MaSP
            // 
            this.txb_MaSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_MaSP.Location = new System.Drawing.Point(205, 407);
            this.txb_MaSP.Name = "txb_MaSP";
            this.txb_MaSP.ReadOnly = true;
            this.txb_MaSP.Size = new System.Drawing.Size(178, 22);
            this.txb_MaSP.TabIndex = 8;
            // 
            // txb_GiaBan
            // 
            this.txb_GiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_GiaBan.Location = new System.Drawing.Point(508, 410);
            this.txb_GiaBan.Name = "txb_GiaBan";
            this.txb_GiaBan.ReadOnly = true;
            this.txb_GiaBan.Size = new System.Drawing.Size(178, 22);
            this.txb_GiaBan.TabIndex = 9;
            // 
            // txb_TenSP
            // 
            this.txb_TenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_TenSP.Location = new System.Drawing.Point(205, 469);
            this.txb_TenSP.Name = "txb_TenSP";
            this.txb_TenSP.ReadOnly = true;
            this.txb_TenSP.Size = new System.Drawing.Size(178, 22);
            this.txb_TenSP.TabIndex = 10;
            // 
            // txb_PhanLoai
            // 
            this.txb_PhanLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_PhanLoai.Location = new System.Drawing.Point(508, 472);
            this.txb_PhanLoai.Name = "txb_PhanLoai";
            this.txb_PhanLoai.ReadOnly = true;
            this.txb_PhanLoai.Size = new System.Drawing.Size(178, 22);
            this.txb_PhanLoai.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(758, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Load Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(758, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Mua SP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_PhanLoai);
            this.Controls.Add(this.txb_TenSP);
            this.Controls.Add(this.txb_GiaBan);
            this.Controls.Add(this.txb_MaSP);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.TextBox txb_MaSP;
        private System.Windows.Forms.TextBox txb_GiaBan;
        private System.Windows.Forms.TextBox txb_TenSP;
        private System.Windows.Forms.TextBox txb_PhanLoai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

