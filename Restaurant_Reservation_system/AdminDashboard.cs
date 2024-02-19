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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            
        }
        private void menuBtn_Click(object sender, EventArgs e)
        {

        }

        private void hungryLbl_Click(object sender, EventArgs e)
        {
            //hungryLbl.Parent = ;
            //hungryLbl.BackColor = Color.Transparent;
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            GRIDVIEW gridview = new GRIDVIEW();
            gridview.Show();
            this.Hide();
        }
        private void foodBtn_Click_1(object sender, EventArgs e)
        {
            food_details food_details = new food_details();
            food_details.Show();
            this.Hide();
        }

        private void inventeryBtn_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Order_Details od = new Order_Details();
            od.Show();
            this.Hide();
        }
    }
}
