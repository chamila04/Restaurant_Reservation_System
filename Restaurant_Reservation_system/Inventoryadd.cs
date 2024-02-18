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
    public partial class Inventoryadd : Form
    {
        public Inventoryadd()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            int quantity = int.Parse(qtyText.Text);
            int price = int.Parse(priceText.Text);

            DbTransactions inventory = new DbTransactions();
            bool status = inventory.insertInventory(name, quantity, price);

            if (status == true)
            {
                MessageBox.Show("item added succesfully");
                Inventory inv = new Inventory();
                inv.Show();
                this.Hide();
            }
            if (status == false)
            {
                MessageBox.Show("item added fail");
                nameText.Text = "";
                qtyText.Text = "";
                priceText.Text = "";
                nameText.Focus();
                return;
            }
        }
    }
}
