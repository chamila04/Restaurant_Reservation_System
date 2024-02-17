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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        public void OrderInfo(string orderin)
        {
            orderLbl.Text += "\n" + orderin;

            Food food = new Food();
            this.Show();
        }
        private void Order_Load(object sender, EventArgs e)
        {
            
        }
        public void orderLable(int totprice)
        {
            Food food = new Food();
            //int ftot = food.foodTotal();
            //totpriLbl.Text = food.foodTotal().ToString();

        }
    }
}
