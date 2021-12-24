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

namespace dirty_read_2
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

        private void loadSearch()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from DonDatHang where MaDonHang ='"+txb_MaDH.Text+"'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txb_MaDH.Text == "" )
            {
                MessageBox.Show("Không được để trống dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection = new SqlConnection(Global.strconnect);
            connection.Open();
            command = new SqlCommand("sp_XemDonHang", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDH", SqlDbType.Int).Value = txb_MaDH.Text;


            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_1.DataSource = table;

            

            connection.Close();
        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = dgv_1.CurrentRow.Index;
            txb_MaDH.Text = dgv_1.Rows[i].Cells[0].Value.ToString();
           
        }

        private void txb_MaDH_TextChanged(object sender, EventArgs e)
        {
            if (txb_MaDH.Text == "")
            {
                loadData();
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

