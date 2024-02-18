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
    

    public partial class Dessert : Form
    {
        int deprice1;
        int deprice2;
        int deprice3;
        int deprice4;
        int deprice5;
        int deprice6;

        public Dessert()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void setectBtn1_Click(object sender, EventArgs e)
        {
            deprice1 = (int)chocoup.Value * 400;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            deprice2 = (int)pavoup.Value * 350;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            deprice3 = (int)mangoup.Value * 300;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            deprice4 = (int)tiraup.Value * 450;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            deprice5 = (int)cremeup.Value * 380;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            deprice6 = (int)banaup.Value * 320;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Calculate cal = new Calculate();
            cal.DesertTotal = deprice1+deprice2+deprice3+deprice4+deprice5+deprice6;
            textcal.Text=cal.DesertTotal.ToString();
        }
    }
}
