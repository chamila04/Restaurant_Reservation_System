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
    public partial class EmployeeReg : Form
    {
        public EmployeeReg()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string fname = fnameText.Text;
            string lname = lnameText.Text;
            string username = usernameText.Text;
            string password = passwordText.Text;
            string access = accessCom.SelectedItem.ToString();

            DbTransactions insert = new DbTransactions();
            bool status= insert.insertEmployee(fname,lname,username,password,access);

            if (status  == true)
            {
                MessageBox.Show("employee registerd succesfully");
                GRIDVIEW gRIDVIEW = new GRIDVIEW();
                gRIDVIEW.Show();
                this.Hide();
            }
            if (status == false)
            {
                MessageBox.Show("employee registeration fail");
                fnameText.Text = "";
                lnameText.Text = "";
                usernameText.Text = "";
                passwordText.Text = "";
                fnameText.Focus();
                return;
            }
        }

        private void accessCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
