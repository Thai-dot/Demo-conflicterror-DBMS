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

namespace lostupdate1
{
    
    public partial class Lostupdate1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public Lostupdate1()
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
            command.CommandText = "select * from PHIEUGIAOHANG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_1.DataSource = table;
        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_1.CurrentRow.Index;
            txb_MaPG.Text = dgv_1.Rows[i].Cells[0].Value.ToString();
            txb_TaiXe.Text = dgv_1.Rows[i].Cells[1].Value.ToString();
            txb_MaDonHang.Text = dgv_1.Rows[i].Cells[2].Value.ToString();
            txb_MaKH.Text = dgv_1.Rows[i].Cells[3].Value.ToString();
            dt_ngaygiao.Text = dgv_1.Rows[i].Cells[4].Value.ToString();
            txb_TinhTrang.Text = dgv_1.Rows[i].Cells[5].Value.ToString();
            Txb_DiaChi.Text = dgv_1.Rows[i].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txb_MaPG.Text == "" || txb_TinhTrang.Text == "")
            {
                MessageBox.Show("Không được để trống dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection = new SqlConnection(Global.strconnect);
            connection.Open();
            command = new SqlCommand("sp_update_TinhTrangDatHang", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPG", SqlDbType.Int).Value = txb_MaPG.Text;
            command.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = txb_TinhTrang.Text;

            command.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
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