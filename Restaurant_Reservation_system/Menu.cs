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
            menuFormCall(typeof(Food));

            //orderFormCall(typeof(Order));
        }

        private void drinkBtn_Click(object sender, EventArgs e)
        {
            menuFormCall(typeof(Drink));

            //orderFormCall(typeof(Order));
        }

        private void dessertBtn_Click(object sender, EventArgs e)
        {
            menuFormCall(typeof(Dessert));

            //orderFormCall(typeof(Order));
        }

        private void snackBtn_Click(object sender, EventArgs e)
        {
            menuFormCall(typeof(Snack));

            //orderFormCall(typeof(Order));
        }
        //private void OpenChildFormInPanel(Type formType)
        //{
        //    // Check if a child form of the specified type is already open
        //    foreach (Control control in orderDisPnl.Controls)
        //    {
        //        if (control.GetType() == formType)
        //        {
        //            // If already open, activate it and return
        //            control.BringToFront();
        //            return;
        //        }
        //    }

        //    // If not already open, create a new instance of the child form
        //    Form childForm = (Form)Activator.CreateInstance(formType);

        //    // Set properties of the child form
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;

        //    // Add the child form to the panel's Controls collection
        //    orderDisPnl.Controls.Add(childForm);

        //    // Show the child form
        //    childForm.Show();
        //}
        public void menuFormCall(Type formName)
        {
            foreach (Control control in menuDisPnl.Controls)
            {
                if (control.GetType() == formName)
                {
                    control.BringToFront();
                    return;
                }
            }
                Form childForm = (Form)(Activator.CreateInstance(formName));

                childForm.TopLevel = false;
                childForm.FormBorderStyle= FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                menuDisPnl.Controls.Add(childForm);
                childForm.Show();
        }
        //public void orderFormCall(Type formName)
        //{
        //    foreach (Control control in orderPnl.Controls)
        //    {
        //        if (control.GetType() == formName)
        //        {
        //            control.BringToFront();
        //            return;
        //        }
        //    }
        //    Form childForm = (Form)(Activator.CreateInstance(formName));

        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;

        //    // Show the child form
        //    childForm.Show();
        //}
    }
}
