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
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            Form ViewMenuForm = new Menu();
            ViewMenuForm.ShowDialog(); // dialog no return is very helpful
        }
    }
}
