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
    public partial class DangKy_KH : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GFLTFQM\SQLEXPRESS;Initial Catalog=BanHangOnline;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
     
        public DangKy_KH()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KhachHANG KH = new KhachHANG();
            this.Hide();
            KH.Show();
        }

        private void btn_dangky_kh_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Tao_TK_KH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenDN", SqlDbType.Char).Value = tb_TenDN_DK.Text;
                cmd.Parameters.Add("@MK", SqlDbType.Char).Value = tb_MK_DK.Text;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = tb_HoTen_DK.Text;
                cmd.Parameters.Add("@SDTKhachHang", SqlDbType.NVarChar).Value = tb_SDT_DK.Text;
                cmd.Parameters.Add("@DiaChiKh", SqlDbType.NVarChar).Value = tb_DiaChi_KH.Text;
                cmd.Parameters.Add("@EmailKhachHang", SqlDbType.NVarChar).Value = tb_Email_DK.Text;
                Global.Ten_DN = tb_TenDN_DK.Text;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng Ký Thành Công", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            else
            {
                MessageBox.Show("Đăng Ký Thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isValid()
        {
            if (tb_TenDN_DK.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Chưa nhập tên đăng nhập ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(tb_MK_DK.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Chưa có mật khẩu ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tb_NLMK_TK.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Chưa có mật khẩu nhập lại mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tb_HoTen_DK.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Chưa có họ tên ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tb_SDT_DK.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Chưa có số điện thoại ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tb_DiaChi_KH.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Chưa có địa chỉ ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tb_Email_DK.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Chưa có email ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string query = "Select * from TaiKhoan_KH where TenDangNhap = '" + tb_TenDN_DK.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Global.strconnect);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            if (dta.Rows.Count == 1)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tb_MK_DK.Text != tb_NLMK_TK.Text)
            {
                MessageBox.Show("Hai mật khẩu không khớp với nhau ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;

        }
    }
}
