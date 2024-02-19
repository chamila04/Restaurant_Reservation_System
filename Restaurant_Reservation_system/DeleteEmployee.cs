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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = nameText.Text;
            //MessageBox.Show(id);

            DbTransactions delete = new DbTransactions();
            bool status = delete.deleteEmployee(id);

            if (status == true)
            {
                MessageBox.Show("employee deleted succesfully");
                GRIDVIEW gRIDVIEW = new GRIDVIEW();
                gRIDVIEW.Show();
                this.Hide();
            }
            if (status == false)
            {
                MessageBox.Show("employee delete failed");
                nameText.Text = "";
                nameText.Focus();
                return;
            }
        }
    }
}
