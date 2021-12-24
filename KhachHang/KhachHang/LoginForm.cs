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
   
    
    public partial class KhachHANG : Form
    {
        SqlConnection connection;
       
      

        public KhachHANG()
        {
            InitializeComponent();
        }

        private void btnexit_KH_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                string query = "Select * from TaiKhoan_KH where TenDangNhap = '" + tb_TaiKhoan_KH.Text.Trim() + "' And MatKhau = '" + tb_MatKhau_KH.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Global.strconnect);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                if(dta.Rows.Count == 1)
                {
                    Home_KH home_KH = new Home_KH();
                    this.Hide();
                    home_KH.Show();
                    Global.Ten_DN = tb_TaiKhoan_KH.Text;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private bool isValid()
        {
            if (tb_TaiKhoan_KH.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Hay nhap ten dang nhap vao truoc", "Error");
                return false;
            }
            else if (tb_MatKhau_KH.Text.TrimStart()==string.Empty){
                MessageBox.Show("Hay nhap mat khau vao truoc", "Error");
                return false;
            }
            return true;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            DangKy_KH dk = new DangKy_KH();
            this.Hide();
            dk.Show();
        }

        
    }
}

public static class Global
{

    public static String Ten_DN = "";
    public static String MaKH = "";
    public const string strconnect = @"Data Source=DESKTOP-GFLTFQM\SQLEXPRESS;Initial Catalog=BanHangOnline;Integrated Security=True";
    public static bool IsNumeric(string value)
    {
        return value.All(char.IsNumber);
    }
}

