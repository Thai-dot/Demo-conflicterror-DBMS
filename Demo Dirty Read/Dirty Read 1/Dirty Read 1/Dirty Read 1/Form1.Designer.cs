
namespace Dirty_Read_1
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
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_MaDonHang = new System.Windows.Forms.TextBox();
            this.txb_DiaChi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demo Dirty Read 1 (Khách Hàng nhập địa chỉ giao hàng)";
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(51, 100);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(854, 273);
            this.dgv_1.TabIndex = 1;
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Đơn Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // txb_MaDonHang
            // 
            this.txb_MaDonHang.Location = new System.Drawing.Point(199, 407);
            this.txb_MaDonHang.Name = "txb_MaDonHang";
            this.txb_MaDonHang.Size = new System.Drawing.Size(258, 22);
            this.txb_MaDonHang.TabIndex = 4;
            // 
            // txb_DiaChi
            // 
            this.txb_DiaChi.Location = new System.Drawing.Point(199, 489);
            this.txb_DiaChi.Name = "txb_DiaChi";
            this.txb_DiaChi.Size = new System.Drawing.Size(258, 22);
            this.txb_DiaChi.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_DiaChi);
            this.Controls.Add(this.txb_MaDonHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_1);
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
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_MaDonHang;
        private System.Windows.Forms.TextBox txb_DiaChi;
        private System.Windows.Forms.Button button1;
    }
}

