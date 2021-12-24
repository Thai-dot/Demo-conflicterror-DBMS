
namespace Conversion_deadlock_2
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
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_MaSP = new System.Windows.Forms.TextBox();
            this.txb_TenSP = new System.Windows.Forms.TextBox();
            this.txb_GiaBan = new System.Windows.Forms.TextBox();
            this.txb_PhanLoai = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion deadlock 2 (Đối tác cập nhật giá sản phẩm)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MaSP";
            // 
            // dgv_1
            // 
            this.dgv_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(88, 107);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(937, 239);
            this.dgv_1.TabIndex = 2;
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên SP";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá Bán";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phân Loại";
            // 
            // txb_MaSP
            // 
            this.txb_MaSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_MaSP.Location = new System.Drawing.Point(240, 390);
            this.txb_MaSP.Name = "txb_MaSP";
            this.txb_MaSP.ReadOnly = true;
            this.txb_MaSP.Size = new System.Drawing.Size(178, 22);
            this.txb_MaSP.TabIndex = 6;
            // 
            // txb_TenSP
            // 
            this.txb_TenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_TenSP.Location = new System.Drawing.Point(240, 463);
            this.txb_TenSP.Name = "txb_TenSP";
            this.txb_TenSP.ReadOnly = true;
            this.txb_TenSP.Size = new System.Drawing.Size(178, 22);
            this.txb_TenSP.TabIndex = 7;
            // 
            // txb_GiaBan
            // 
            this.txb_GiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_GiaBan.Location = new System.Drawing.Point(598, 390);
            this.txb_GiaBan.Name = "txb_GiaBan";
            this.txb_GiaBan.Size = new System.Drawing.Size(178, 22);
            this.txb_GiaBan.TabIndex = 8;
            // 
            // txb_PhanLoai
            // 
            this.txb_PhanLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_PhanLoai.Location = new System.Drawing.Point(598, 463);
            this.txb_PhanLoai.Name = "txb_PhanLoai";
            this.txb_PhanLoai.ReadOnly = true;
            this.txb_PhanLoai.Size = new System.Drawing.Size(178, 22);
            this.txb_PhanLoai.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(896, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cập Nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_PhanLoai);
            this.Controls.Add(this.txb_GiaBan);
            this.Controls.Add(this.txb_TenSP);
            this.Controls.Add(this.txb_MaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_MaSP;
        private System.Windows.Forms.TextBox txb_TenSP;
        private System.Windows.Forms.TextBox txb_GiaBan;
        private System.Windows.Forms.TextBox txb_PhanLoai;
        private System.Windows.Forms.Button button1;
    }
}

