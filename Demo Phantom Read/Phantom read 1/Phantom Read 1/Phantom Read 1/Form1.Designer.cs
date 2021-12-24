
namespace Phantom_Read_1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_MST = new System.Windows.Forms.TextBox();
            this.txb_MaDT = new System.Windows.Forms.TextBox();
            this.txb_ChiNhanh = new System.Windows.Forms.TextBox();
            this.txb_PhiKichHoat = new System.Windows.Forms.TextBox();
            this.date_TGHL = new System.Windows.Forms.DateTimePicker();
            this.date_TGKT = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(157, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demo Phantom Read 1 (Nhân Viên thực hiện đăng ký 1 HĐ mới)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Số Thuế";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Đối Tác";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Chi Nhánh";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phí Kích Hoạt";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời Gian Hiệu Lực";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thời Gian Hết Hạn";
            // 
            // txb_MST
            // 
            this.txb_MST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_MST.Location = new System.Drawing.Point(289, 178);
            this.txb_MST.Name = "txb_MST";
            this.txb_MST.Size = new System.Drawing.Size(131, 22);
            this.txb_MST.TabIndex = 8;
            // 
            // txb_MaDT
            // 
            this.txb_MaDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_MaDT.Location = new System.Drawing.Point(289, 227);
            this.txb_MaDT.Name = "txb_MaDT";
            this.txb_MaDT.Size = new System.Drawing.Size(131, 22);
            this.txb_MaDT.TabIndex = 9;
            // 
            // txb_ChiNhanh
            // 
            this.txb_ChiNhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_ChiNhanh.Location = new System.Drawing.Point(289, 294);
            this.txb_ChiNhanh.Name = "txb_ChiNhanh";
            this.txb_ChiNhanh.Size = new System.Drawing.Size(131, 22);
            this.txb_ChiNhanh.TabIndex = 10;
            // 
            // txb_PhiKichHoat
            // 
            this.txb_PhiKichHoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_PhiKichHoat.Location = new System.Drawing.Point(628, 178);
            this.txb_PhiKichHoat.Name = "txb_PhiKichHoat";
            this.txb_PhiKichHoat.Size = new System.Drawing.Size(131, 22);
            this.txb_PhiKichHoat.TabIndex = 11;
            this.txb_PhiKichHoat.TextChanged += new System.EventHandler(this.txb_PhiKichHoat_TextChanged);
            // 
            // date_TGHL
            // 
            this.date_TGHL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_TGHL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_TGHL.Location = new System.Drawing.Point(628, 230);
            this.date_TGHL.Name = "date_TGHL";
            this.date_TGHL.Size = new System.Drawing.Size(131, 22);
            this.date_TGHL.TabIndex = 12;
            // 
            // date_TGKT
            // 
            this.date_TGKT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_TGKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_TGKT.Location = new System.Drawing.Point(628, 296);
            this.date_TGKT.Name = "date_TGKT";
            this.date_TGKT.Size = new System.Drawing.Size(131, 22);
            this.date_TGKT.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(405, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tạo Hợp Đồng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_TGKT);
            this.Controls.Add(this.date_TGHL);
            this.Controls.Add(this.txb_PhiKichHoat);
            this.Controls.Add(this.txb_ChiNhanh);
            this.Controls.Add(this.txb_MaDT);
            this.Controls.Add(this.txb_MST);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_MST;
        private System.Windows.Forms.TextBox txb_MaDT;
        private System.Windows.Forms.TextBox txb_ChiNhanh;
        private System.Windows.Forms.TextBox txb_PhiKichHoat;
        private System.Windows.Forms.DateTimePicker date_TGHL;
        private System.Windows.Forms.DateTimePicker date_TGKT;
        private System.Windows.Forms.Button button1;
    }
}

