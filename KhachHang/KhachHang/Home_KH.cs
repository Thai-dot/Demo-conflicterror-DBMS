using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KhachHang
{
    
    public partial class Home_KH : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Home_KH()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
       
            command = connection.CreateCommand();
            command.CommandText = "Select TenSanPham as Tên_Sản_Phẩm,GiaBan as Giá_Bán,PhanLoaiHang as Loại_Hàng from SanPham";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_SP.DataSource = table;
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có muốn thoát ?","Thoát Đăng Nhập", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                KhachHANG kh = new KhachHANG();
                this.Hide();
                kh.Show();
                Global.MaKH = "";
                Global.Ten_DN = "";
            }
            
        }

        private void Home_KH_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Global.strconnect);
            connection.Open();
            loaddata();

            connection.Close();
        }

        private void dgv_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_SP.CurrentRow.Index;
            tb_TenSP_Home.Text = dgv_SP.Rows[i].Cells[0].Value.ToString();
            tb_GiaBanSP_Home.Text = dgv_SP.Rows[i].Cells[1].Value.ToString();
            tb_LoaiSP_Home.Text = dgv_SP.Rows[i].Cells[2].Value.ToString();

        }

        private void btn_Search_Home_Click(object sender, EventArgs e)
        {
             if(tb_Search_Home.Text=="")
                {
                    loaddata();
                    return;
                }
            load_Search();
            
        }

        private void load_Search()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select TenSanPham as Tên_Sản_Phẩm,GiaBan as Giá_Bán,PhanLoaiHang as Loại_Hàng from SanPham where TenSanPham like'" + tb_Search_Home.Text.ToString() + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_SP.DataSource = table;
        }

        private void tb_Search_Home_TextChanged(object sender, EventArgs e)
        {
            if(tb_Search_Home.Text.ToString() == "")
            {
                loaddata();
            }
        }

        private void btn_Buy_Home_Click(object sender, EventArgs e)
        {
            if(tb_SoLuongSP_Home.Text=="" || tb_DiaChiGH_Home.Text == ""|| comboBox_HTTT.Text == "" ||tb_TenSP_Home.Text=="" || tb_TongTien_Home.Text=="")
            {
                MessageBox.Show("Bạn đang để trống dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            connection = new SqlConnection(Global.strconnect);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select Makh FROM TAIKHOAN_KH WHERE TENDANGNHAP='" + Global.Ten_DN + "'";
            Global.MaKH = command.ExecuteScalar().ToString();
            

            

           
            connection.Close();
        }

        private void tb_SoLuongSP_Home_TextChanged(object sender, EventArgs e)
        {
            if (tb_GiaBanSP_Home.Text == ""||tb_SoLuongSP_Home.Text=="")
            {
                tb_TongTien_Home.Text = "";
            }
            else if(Global.IsNumeric(tb_SoLuongSP_Home.Text) == false)
            {
                tb_TongTien_Home.Text = "";
            }
            else
            {
                float giatien = float.Parse(tb_GiaBanSP_Home.Text) * float.Parse(tb_SoLuongSP_Home.Text);
                tb_TongTien_Home.Text = string.Format("{0:N2}", giatien);
             }
        }

        private void tb_GiaBanSP_Home_TextChanged(object sender, EventArgs e)
        {
            if (tb_GiaBanSP_Home.Text == "" || tb_SoLuongSP_Home.Text == "")
            {
                tb_TongTien_Home.Text = "";
            }
            else
            {
                float giatien = float.Parse(tb_GiaBanSP_Home.Text) * float.Parse(tb_SoLuongSP_Home.Text);
                tb_TongTien_Home.Text = string.Format("{0:N2}", giatien);
            }
        }
    }
}
