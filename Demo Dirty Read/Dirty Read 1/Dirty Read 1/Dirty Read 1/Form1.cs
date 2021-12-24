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

namespace Dirty_Read_1
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
            command.CommandText = "select * from DonDatHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = dgv_1.CurrentRow.Index;
            txb_MaDonHang.Text = dgv_1.Rows[i].Cells[0].Value.ToString();
            txb_DiaChi.Text = dgv_1.Rows[i].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txb_MaDonHang.Text == "" || txb_DiaChi.Text == "")
            {
                MessageBox.Show("Không được để trống dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection = new SqlConnection(Global.strconnect);
            connection.Open();
            command = new SqlCommand("sp_CapNhatDiaChiGiaoHang", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDH", SqlDbType.Int).Value = txb_MaDonHang.Text;
            command.Parameters.Add("@DCGH", SqlDbType.NVarChar).Value = txb_DiaChi.Text;

            command.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
            
            connection.Close();
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
