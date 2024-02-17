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
        int fprice1;
        int fprice2;
        int fprice3;
        int fprice4;
        int fprice5;
        int fprice6;
        int ftotal;
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
            string tprices = "";

            DbTransactions order = new DbTransactions();
            price = order.orderPrice(foodName);
            fprice1 = quantity * price;
            tprices = tprice.ToString();
            //tprice = fprice1;
            orderinfo = foodName + "    " + quantity + " x " + price + " =  " + tprices;
            //MessageBox.Show(orderinfo);

            Order orderin = new Order();
            orderin.OrderInfo(orderinfo);

            orderin.orderLable(ftotal);

            
        }
        public int foodTotal() 
        {
            ftotal = fprice1 + fprice2 + fprice3 + fprice4 + fprice5 + fprice6;
            MessageBox.Show(ftotal.ToString());
            return ftotal;
        }
    }
}
