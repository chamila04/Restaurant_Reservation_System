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
            string foodName = nameLbl1.Text;
            int quantity = (int)chocoup.Value;
            int price = 0;
            int tprice = 0;
            string orderinfo = "";
            string tprices = "";

            DbTransactions order = new DbTransactions();
            price = order.orderPrice(foodName);
            tprice = quantity * price;
            tprices = tprice.ToString();
            //MessageBox.Show(tprices);
            orderinfo = foodName + "    " + quantity + " x " + price + " =  " + tprices + "\n";
            //MessageBox.Show(orderinfo);

            orderLbl.Text += "\n" + orderinfo + "\n";

            deprice1 = (int)chocoup.Value * 400;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel2.Text;
            int quantity = (int)pavoup.Value;
            int price = 0;
            int tprice = 0;
            string orderinfo = "";
            string tprices = "";

            DbTransactions order = new DbTransactions();
            price = order.orderPrice(foodName);
            tprice = quantity * price;
            tprices = tprice.ToString();
            //MessageBox.Show(tprices);
            orderinfo = foodName + "    " + quantity + " x " + price + " =  " + tprices + "\n";
            //MessageBox.Show(orderinfo);

            labalfruit.Text += "\n" + orderinfo + "\n";

            deprice2 = (int)pavoup.Value * 350;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel6.Text;
            int quantity = (int)mangoup.Value;
            int price = 0;
            int tprice = 0;
            string orderinfo = "";
            string tprices = "";

            DbTransactions order = new DbTransactions();
            price = order.orderPrice(foodName);
            tprice = quantity * price;
            tprices = tprice.ToString();
            //MessageBox.Show(tprices);
            orderinfo = foodName + "    " + quantity + " x " + price + " =  " + tprices + "\n";
            //MessageBox.Show(orderinfo);

            labalmango.Text += "\n" + orderinfo + "\n";

            deprice3 = (int)mangoup.Value * 300;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel4.Text;
            int quantity = (int)tiraup.Value;
            int price = 0;
            int tprice = 0;
            string orderinfo = "";
            string tprices = "";

            DbTransactions order = new DbTransactions();
            price = order.orderPrice(foodName);
            tprice = quantity * price;
            tprices = tprice.ToString();
            //MessageBox.Show(tprices);
            orderinfo = foodName + "    " + quantity + " x " + price + " =  " + tprices + "\n";
            //MessageBox.Show(orderinfo);

            labaltira.Text += "\n" + orderinfo + "\n";

            deprice4 = (int)tiraup.Value * 450;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel10.Text;
            int quantity = (int)cremeup.Value;
            int price = 0;
            int tprice = 0;
            string orderinfo = "";
            string tprices = "";

            DbTransactions order = new DbTransactions();
            price = order.orderPrice(foodName);
            tprice = quantity * price;
            tprices = tprice.ToString();
            //MessageBox.Show(tprices);
            orderinfo = foodName + "    " + quantity + " x " + price + " =  " + tprices + "\n";
            //MessageBox.Show(orderinfo);

            labalcream.Text += "\n" + orderinfo + "\n";

            deprice5 = (int)cremeup.Value * 380;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel8.Text;
            int quantity = (int)banaup.Value;
            int price = 0;
            int tprice = 0;
            string orderinfo = "";
            string tprices = "";

            DbTransactions order = new DbTransactions();
            price = order.orderPrice(foodName);
            tprice = quantity * price;
            tprices = tprice.ToString();
            //MessageBox.Show(tprices);
            orderinfo = foodName + "    " + quantity + " x " + price + " =  " + tprices + "\n";
            //MessageBox.Show(orderinfo);

            labalbana.Text += "\n" + orderinfo + "\n";

            deprice6 = (int)banaup.Value * 320;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Calculate cal = new Calculate();
            cal.DesertTotal = deprice1+deprice2+deprice3+deprice4+deprice5+deprice6;
            textcal.Text=cal.DesertTotal.ToString();
        }
    }
}
