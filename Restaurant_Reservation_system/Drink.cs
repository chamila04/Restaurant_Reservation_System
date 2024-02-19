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
            string foodName = nameLbl1.Text;
            int quantity = (int)orangeup.Value;
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

            price1 = (int)orangeup.Value * 200;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel2.Text;
            int quantity = (int)cappup.Value;
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

            labalcapp.Text += "\n" + orderinfo + "\n";

            price2 = (int)cappup.Value * 250;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel6.Text;
            int quantity = (int)mojiup.Value;
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

            labalmoji.Text += "\n" + orderinfo + "\n";

            price3 = (int)mojiup.Value * 180;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel4.Text;
            int quantity = (int)smooup.Value;
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

            labalsmoo.Text += "\n" + orderinfo + "\n";

            price4 = (int)smooup.Value * 220;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel10.Text;
            int quantity = (int)lemonup.Value;
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

            laballemon.Text += "\n" + orderinfo + "\n";

            price5 = (int)lemonup.Value * 150;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel8.Text;
            int quantity = (int)avoup.Value;
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

            labalavo.Text += "\n" + orderinfo + "\n";

            price6 = (int)avoup.Value * 280;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Calculate cal = new Calculate();
            cal.DrinkTotal= price1+price2+price3+price4+price5+price6;
            textot.Text=cal.DrinkTotal.ToString();
        }
    }
}
