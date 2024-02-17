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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // login form error handling

            if (usernameText.Text == "" || usernameText.Text == null)
            {
                MessageBox.Show("username empty !");
                usernameText.Focus();
                return;
            }
            if (passwordText.Text == "" || passwordText.Text == null)
            {
                MessageBox.Show("password empty !");
                passwordText.Focus();
                return;
            }

            // connecting to database

            string username = usernameText.Text.ToString();
            string password = passwordText.Text.ToString();
            string access = "";

            DbTransactions login = new DbTransactions();
            bool status = login.loginCheck(username, password);
            access = login.Access;

            if (status == false)
            {
                MessageBox.Show("Invalid Login");
                usernameText.Text = "";
                passwordText.Text = "";
                usernameText.Focus();
                return;
            }
            if (status == true)
            {
                if (access == "admin")
                {
                    // admin access
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show();
                    this.Hide();
                }
                else if (access == "user")
                {
                    // user access
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("do not have access to software !");
                    usernameText.Text = "";
                    passwordText.Text = "";
                    usernameText.Focus();
                    return;
                }
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
