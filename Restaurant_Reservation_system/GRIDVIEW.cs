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
    public partial class GRIDVIEW : Form
    {
        public GRIDVIEW()
        {
            InitializeComponent();
        }
        public void loginGrid()
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
                dataGridView2.DataSource = table;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GRIDVIEW_Load(object sender, EventArgs e)
        {
            loginGrid();
        }
    }
}
