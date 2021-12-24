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

namespace unrepeatable_read2
{
    public partial class Form1 : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Global.strconnect);
            connection.Open();
            loadData();

            connection.Close();
        }

        private void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaSanPham as Mã_SP,TenSanPham as Tên_Sản_Phẩm,GiaBan as Giá_Bán,PhanLoaiHang as Loại_Hàng from SanPham";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_1.DataSource = table;
        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = dgv_1.CurrentRow.Index;
            txb_MaSP.Text = dgv_1.Rows[i].Cells[0].Value.ToString();
            txb_TenSP.Text = dgv_1.Rows[i].Cells[1].Value.ToString();
            txb_GiaBan.Text = dgv_1.Rows[i].Cells[2].Value.ToString();
            txb_PhanLoai.Text = dgv_1.Rows[i].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void txb_search_TextChanged(object sender, EventArgs e)
        {
            if (txb_search.Text != "")
            {


                command = connection.CreateCommand();
                command.CommandText = "Select MaSanPham as Mã_SP,TenSanPham as Tên_Sản_Phẩm,GiaBan as Giá_Bán,PhanLoaiHang as Loại_Hàng from SanPham where TenSanPham like'" + txb_search.Text.ToString() + "%'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgv_1.DataSource = table;
               
            }
            else
            {
                loadData();
                return;
            }
        }
    }
}

public static class Global
{
    public const string strconnect = @"Data Source=DESKTOP-GFLTFQM\SQLEXPRESS;Initial Catalog=BanHangOnline;Integrated Security=True";
    public static bool IsNumeric(string value)
    {
        return value.All(char.IsNumber);
    }
}

