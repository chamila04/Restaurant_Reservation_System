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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void foodBtn_Click(object sender, EventArgs e)
        {
            OpenChildFormInPanel(typeof(Food));
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void drinkBtn_Click(object sender, EventArgs e)
        {
            OpenChildFormInPanel(typeof(Drink));
        }

        private void dessertBtn_Click(object sender, EventArgs e)
        {
            OpenChildFormInPanel(typeof(Dessert));
        }

        private void snackBtn_Click(object sender, EventArgs e)
        {
            OpenChildFormInPanel(typeof(Snack));
        }
        private void OpenChildFormInPanel(Type formType)
        {
            // Check if a child form of the specified type is already open
            foreach (Control control in guna2Panel4.Controls)
            {
                if (control.GetType() == formType)
                {
                    // If already open, activate it and return
                    control.BringToFront();
                    return;
                }
            }

            // If not already open, create a new instance of the child form
            Form childForm = (Form)Activator.CreateInstance(formType);

            // Set properties of the child form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add the child form to the panel's Controls collection
            guna2Panel4.Controls.Add(childForm);

            // Show the child form
            childForm.Show();
        }
        public void DisplayOrderFormInPanel()
        {
            // Clear existing controls in the panel
            orderPnl.Controls.Clear();

            // Create an instance of OrderForm
            Order orderForm = new Order();

            // Set OrderForm's Dock property to Fill to make it fill the panel
            orderForm.Dock = DockStyle.Fill;

            // Add OrderForm to the panel
            orderPnl.Controls.Add(orderForm);
        }
    }
}
