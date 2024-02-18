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
    public partial class Drink : Form
    {
        int price1;
        int price2;
        int price3;
        int price4;
        int price5;
        int price6;
        public Drink()
        {
            InitializeComponent();
        }

        private void setectBtn1_Click(object sender, EventArgs e)
        {
            price1 = (int)orangeup.Value * 200;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            price2 = (int)cappup.Value * 250;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            price3 = (int)mojiup.Value * 180;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            price4 = (int)smooup.Value * 220;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            price5 = (int)lemonup.Value * 150;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            price6 = (int)avoup.Value * 280;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Calculate cal = new Calculate();
            cal.DrinkTotal= price1+price2+price3+price4+price5+price6;
            textot.Text=cal.DrinkTotal.ToString();
        }
    }
}
