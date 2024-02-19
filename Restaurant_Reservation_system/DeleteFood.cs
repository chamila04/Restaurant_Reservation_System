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
    public partial class DeleteFood : Form
    {
        public DeleteFood()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = nameText.Text;
            //MessageBox.Show(id);
            
            DbTransactions deletefood = new DbTransactions();
            bool status = deletefood.deleteFood(id);

            if (status == true)
            {
                MessageBox.Show("food deleted succesfully");
                GRIDVIEW gRIDVIEW = new GRIDVIEW();
                gRIDVIEW.Show();
                this.Hide();
            }
            if (status == false)
            {
                MessageBox.Show("food delete failed");
                nameText.Text = "";
                nameText.Focus();
                return;
            }
        }
    }
}
