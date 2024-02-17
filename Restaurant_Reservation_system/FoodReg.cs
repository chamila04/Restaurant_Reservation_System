using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class FoodReg : Form
    {
        public FoodReg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "INSERT INTO food_details(food_name, category, price) VALUES('" + textname + "','" + combocata + "'," + textprice + ")";
                

                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }
    }
}
