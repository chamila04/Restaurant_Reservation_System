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
            GRIDVIEW gridview = new GRIDVIEW();
            gridview.Show();
            this.Hide();
        }

        private void hungryLbl_Click(object sender, EventArgs e)
        {
            //hungryLbl.Parent = ;
            //hungryLbl.BackColor = Color.Transparent;
        }

        private void menuBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
