using Org.BouncyCastle.Math;
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
    public partial class Snack : Form
    {
        int snpricee1;
        int snpricee2;
        int snpricee3;
        int snpricee4;
        int snpricee5;
        int snpricee6;
        public Snack()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setectBtn1_Click(object sender, EventArgs e)
        {
            snpricee1 = (int)shawaup.Value * 300;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            snpricee2 = (int)rotiup.Value * 250;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            snpricee3 = (int)fishup.Value * 200;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            snpricee4 = (int)eggup.Value * 280;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            snpricee5 = (int)nugup.Value * 350;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            snpricee6 = (int)vegup.Value * 180;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Calculate cal = new Calculate();
            cal.Snackprice = snpricee1+snpricee2+snpricee3+snpricee4+snpricee5+snpricee6;
            textot.Text=cal.Snackprice.ToString();

        }
    }
}
