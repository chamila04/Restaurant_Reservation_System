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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        public void inventeryGrid()
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "select * from inventery";
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
        private void Inventory_Load(object sender, EventArgs e)
        {
            inventeryGrid();
        }
        private void Btnnew_Click(object sender, EventArgs e)
        {
            Inventoryadd add = new Inventoryadd();
            add.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //DeleteInventory delete = new DeleteInventory();
            //delete.Show();
            //this.Hide();
        }
    }
}
