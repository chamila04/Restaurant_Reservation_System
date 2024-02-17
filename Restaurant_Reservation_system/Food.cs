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
        public int fprice1 = 0;
        public int fprice2 = 0;
        public int fprice3 = 0;
        public int fprice4 = 0;
        public int fprice5 = 0;
        public int fprice6 = 0;
        public int ftotal = 0;
        public string ftotals = "";
        public Food()
        {
            InitializeComponent();
        }
        public string foodTotal(int fprice1)
        {
            ftotal = fprice1 + fprice2 + fprice3 + fprice4 + fprice5 + fprice6;
            ftotals = ftotal.ToString();
            //MessageBox.Show(ftotal.ToString());
            return ftotals;
        }
        private void setectBtn1_Click(object sender, EventArgs e)
        {
            string foodName = nameLbl1.Text;
            int quantity = (int)biriup.Value;
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
            tprice = fprice1;
            totpriLbl.Text = foodTotal(fprice1);
            fprice1= (int)biriup.Value * 700;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fprice2 = (int)seaup.Value*650;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            fprice3 = (int)kottuup.Value*750;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            fprice4 = (int)grillup.Value * 850;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            fprice5 = (int)vegup.Value * 600;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            fprice6 = (int)sefup.Value * 800;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Calculate cal = new Calculate();
            cal.Total = fprice1 + fprice2 + fprice3 + fprice4 + fprice5+fprice6;
            texttot.Text=cal.Total.ToString();
        }
    }
}
