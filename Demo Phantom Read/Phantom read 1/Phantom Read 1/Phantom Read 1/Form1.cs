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

namespace Phantom_Read_1
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txb_MaDT.Text == "" || txb_MST.Text == ""||txb_ChiNhanh.Text==""||txb_PhiKichHoat.Text==""||date_TGHL.Text==""||date_TGKT.Text=="")
            {
                MessageBox.Show("Không được để trống dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection = new SqlConnection(Global.strconnect);
            connection.Open();
            command = new SqlCommand("sp_HDMoi", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Mathue", SqlDbType.NVarChar).Value = txb_MST.Text;
            command.Parameters.Add("@MaDT", SqlDbType.Int).Value = txb_MaDT.Text;
            command.Parameters.Add("@SoCN", SqlDbType.Int).Value = txb_ChiNhanh.Text;
            command.Parameters.Add("@Phi", SqlDbType.Float).Value = txb_PhiKichHoat.Text;
            command.Parameters.Add("@TGHL", SqlDbType.Date).Value = date_TGHL.Text;
            command.Parameters.Add("@TGHH", SqlDbType.Date).Value = date_TGKT.Text;


            command.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            connection.Close();
        }

        private void txb_PhiKichHoat_TextChanged(object sender, EventArgs e)
        {

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