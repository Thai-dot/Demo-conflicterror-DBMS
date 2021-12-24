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

namespace Cycle_Deadlock_2
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = dgv_1.CurrentRow.Index;
            txb_MaDH.Text = dgv_1.Rows[i].Cells[2].Value.ToString();
            txb_MaPG.Text = dgv_1.Rows[i].Cells[0].Value.ToString();
            txb_TinhTrang.Text = dgv_1.Rows[i].Cells[5].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Global.strconnect);
            connection.Open();
            loadData();
            loadData2();
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
        private void loadData2()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from DonDatHang";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dgv_2.DataSource = table2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txb_MaDH.Text == "" || txb_TinhTrang.Text == "")
            {
                MessageBox.Show("Không được để trống dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection = new SqlConnection(Global.strconnect);
            connection.Open();
            command = new SqlCommand("TX_CapNhatTinhTrangGiaoHang", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@reqMaPhieuGiao", SqlDbType.Int).Value = txb_MaPG.Text;
            command.Parameters.Add("@MaDH", SqlDbType.Int).Value = txb_MaDH.Text;
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = txb_TinhTrang.Text;

            command.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
            loadData2();
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
