﻿using System;
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
            orderLbl.Text = orderLbl.Text + "\n" + orderin;
            
            //Food food = new Food();
            //food.OpenChildFormInPanel(typeof(Food));
            //this.Show();
        }
    }
}
