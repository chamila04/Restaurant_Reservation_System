using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Reservation_system
{
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void setectBtn1_Click(object sender, EventArgs e)
        {
            string foodName = nameLbl1.Text;
            int quantity = (int)guna2NumericUpDown1.Value;
            int price = 0;
            int tprice = 0;
            string orderinfo = "";

            DbTransactions order = new DbTransactions();
            price = order.orderPrice(foodName);
            tprice = quantity * price;
            orderinfo = foodName + "    " + quantity + " x " + price + " =  " + tprice;
            //MessageBox.Show(orderinfo);

            Order orderin = new Order();
            orderin.OrderInfo(orderinfo);

            Menu menu = new Menu();
            menu.orderFormCall(typeof(Order));
        }
    }
}
