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
    public partial class employee_details : Form
    {
        public employee_details()
        {
            InitializeComponent();
        }
        public void employeeGrid()
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "select * from login_details";
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
        private void employee_details_Load(object sender, EventArgs e)
        {
            employeeGrid();
        }
    }
}
