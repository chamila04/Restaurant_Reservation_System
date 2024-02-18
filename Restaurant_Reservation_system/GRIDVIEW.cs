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
                dataGridView1.DataSource = table;
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            EmployeeReg er = new EmployeeReg();
            er.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //    DeleteEmployee delete = new DeleteEmployee();
            //    delete.Show();
            //    this.Hide();
            //}
        }
    }
}
