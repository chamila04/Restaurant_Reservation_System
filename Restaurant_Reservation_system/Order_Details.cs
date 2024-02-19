using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Reservation_system
{
    public partial class Order_Details : Form
    {
        public Order_Details()
        {
            InitializeComponent();
        }
        public void orderGrid()
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "select * from order_details";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(rdr);
                dataGridView1.DataSource = table;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Order_Details_Load(object sender, EventArgs e)
        {
            orderGrid();
        }
    }
}
