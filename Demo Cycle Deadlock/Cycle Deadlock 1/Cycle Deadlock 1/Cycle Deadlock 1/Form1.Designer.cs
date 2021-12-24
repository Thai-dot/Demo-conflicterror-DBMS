
namespace Cycle_Deadlock_1
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
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.dgv_2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_MaDH = new System.Windows.Forms.TextBox();
            this.txb_TinhTrangDH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_1
            // 
            this.dgv_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(89, 56);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(859, 238);
            this.dgv_1.TabIndex = 0;
            // 
            // dgv_2
            // 
            this.dgv_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_2.Location = new System.Drawing.Point(89, 322);
            this.dgv_2.Name = "dgv_2";
            this.dgv_2.RowHeadersWidth = 51;
            this.dgv_2.RowTemplate.Height = 24;
            this.dgv_2.Size = new System.Drawing.Size(859, 244);
            this.dgv_2.TabIndex = 1;
            this.dgv_2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_2_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Demo Cycle Deadlock 1 (Nhân viên cập nhật tình trạng đơn hàng)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Đơn Hàng";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tình Trạng Đơn Hàng";
            // 
            // txb_MaDH
            // 
            this.txb_MaDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_MaDH.Location = new System.Drawing.Point(228, 608);
            this.txb_MaDH.Name = "txb_MaDH";
            this.txb_MaDH.ReadOnly = true;
            this.txb_MaDH.Size = new System.Drawing.Size(200, 22);
            this.txb_MaDH.TabIndex = 6;
            // 
            // txb_TinhTrangDH
            // 
            this.txb_TinhTrangDH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_TinhTrangDH.Location = new System.Drawing.Point(671, 608);
            this.txb_TinhTrangDH.Name = "txb_TinhTrangDH";
            this.txb_TinhTrangDH.Size = new System.Drawing.Size(200, 22);
            this.txb_TinhTrangDH.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(433, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cập Nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 763);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_TinhTrangDH);
            this.Controls.Add(this.txb_MaDH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_2);
            this.Controls.Add(this.dgv_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.DataGridView dgv_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_MaDH;
        private System.Windows.Forms.TextBox txb_TinhTrangDH;
        private System.Windows.Forms.Button button1;
    }
}

