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
    public partial class DeleteInventory : Form
    {
        public DeleteInventory()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = nameText.Text;

            DbTransactions delete = new DbTransactions();
            bool status = delete.deleteInventory(id);

            if (status == true)
            {
                MessageBox.Show("item deleted succesfully");
                GRIDVIEW gRIDVIEW = new GRIDVIEW();
                gRIDVIEW.Show();
                this.Hide();
            }
            if (status == false)
            {
                MessageBox.Show("item delete failed");
                nameText.Text = "";
                nameText.Focus();
                return;
            }
        }
    }
}
