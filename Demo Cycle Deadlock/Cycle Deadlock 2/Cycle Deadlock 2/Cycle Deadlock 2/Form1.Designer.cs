
namespace Cycle_Deadlock_2
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
            this.dgv_2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_MaDH = new System.Windows.Forms.TextBox();
            this.txb_TinhTrang = new System.Windows.Forms.TextBox();
            this.txb_MaPG = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demo Cycle Deadlock 2 (Tài xế thực hiện cập nhật tình trạng trên phiếu giao)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Đơn Hàng";
            // 
            // dgv_1
            // 
            this.dgv_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(53, 76);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(1027, 260);
            this.dgv_1.TabIndex = 2;
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgv_2
            // 
            this.dgv_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_2.Location = new System.Drawing.Point(56, 371);
            this.dgv_2.Name = "dgv_2";
            this.dgv_2.RowHeadersWidth = 51;
            this.dgv_2.RowTemplate.Height = 24;
            this.dgv_2.Size = new System.Drawing.Size(1024, 208);
            this.dgv_2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 694);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Phiếu Giao";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 610);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tình Trạng";
            // 
            // txb_MaDH
            // 
            this.txb_MaDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_MaDH.Location = new System.Drawing.Point(290, 607);
            this.txb_MaDH.Name = "txb_MaDH";
            this.txb_MaDH.ReadOnly = true;
            this.txb_MaDH.Size = new System.Drawing.Size(219, 22);
            this.txb_MaDH.TabIndex = 6;
            // 
            // txb_TinhTrang
            // 
            this.txb_TinhTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_TinhTrang.Location = new System.Drawing.Point(711, 610);
            this.txb_TinhTrang.Name = "txb_TinhTrang";
            this.txb_TinhTrang.Size = new System.Drawing.Size(219, 22);
            this.txb_TinhTrang.TabIndex = 7;
            // 
            // txb_MaPG
            // 
            this.txb_MaPG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_MaPG.Location = new System.Drawing.Point(290, 689);
            this.txb_MaPG.Name = "txb_MaPG";
            this.txb_MaPG.ReadOnly = true;
            this.txb_MaPG.Size = new System.Drawing.Size(219, 22);
            this.txb_MaPG.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(711, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 932);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_MaPG);
            this.Controls.Add(this.txb_TinhTrang);
            this.Controls.Add(this.txb_MaDH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_2);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.DataGridView dgv_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_MaDH;
        private System.Windows.Forms.TextBox txb_TinhTrang;
        private System.Windows.Forms.TextBox txb_MaPG;
        private System.Windows.Forms.Button button1;
    }
}

