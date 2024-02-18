using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Reservation_system
{
    public partial class FoodReg : Form
    {
        public FoodReg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string category = catCombo.SelectedItem.ToString();
            int price = int.Parse(priceText.Text);

            DbTransactions foodadd = new DbTransactions();
            bool status = foodadd.insertFood(name, category, price);

            if (status == true)
            {
                MessageBox.Show("food added succesfully");
                GRIDVIEW gRIDVIEW = new GRIDVIEW();
                gRIDVIEW.Show();
                this.Hide();
            }
            if (status == false)
            {
                MessageBox.Show("food added fail");
                nameText.Text = "";
                priceText.Text = "";
                nameText.Focus();
                return;
            }
        }
    }
}
