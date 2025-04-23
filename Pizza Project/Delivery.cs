using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void btnDeliveryBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeliveryConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about this order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            
                MessageBox.Show("Your order has been successfully placed!", "Order Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
             else

                MessageBox.Show("Okay, your order has been canceled.", "Order Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
