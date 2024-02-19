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
            string foodName = nameLbl1.Text;
            int quantity = (int)shawaup.Value;
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

            snpricee1 = (int)shawaup.Value * 300;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel2.Text;
            int quantity = (int)rotiup.Value;
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

            labalroti.Text += "\n" + orderinfo + "\n";

            snpricee2 = (int)rotiup.Value * 250;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel6.Text;
            int quantity = (int)fishup.Value;
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

            labalfish.Text += "\n" + orderinfo + "\n";

            snpricee3 = (int)fishup.Value * 200;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel4.Text;
            int quantity = (int)eggup.Value;
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

            labalegg.Text += "\n" + orderinfo + "\n";

            snpricee4 = (int)eggup.Value * 280;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel10.Text;
            int quantity = (int)nugup.Value;
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

            labalnug.Text += "\n" + orderinfo + "\n";

            snpricee5 = (int)nugup.Value * 350;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string foodName = guna2HtmlLabel8.Text;
            int quantity = (int)vegup.Value;
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

            labalsamo.Text += "\n" + orderinfo + "\n";

            snpricee6 = (int)vegup.Value * 180;

            DbTransactions orderup = new DbTransactions();
            orderup.insertOrder(foodName, quantity, tprice);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Calculate cal = new Calculate();
            cal.Snackprice = snpricee1+snpricee2+snpricee3+snpricee4+snpricee5+snpricee6;
            textot.Text=cal.Snackprice.ToString();

        }
    }
}
