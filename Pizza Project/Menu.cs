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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        float CalculateToppingsPrice()
        {
            float ToppingTotalPrice = 0;

            if (chkExtraChess.Checked)
                ToppingTotalPrice += Convert.ToSingle(chkExtraChess.Tag);

            if (chkOlives.Checked)
                ToppingTotalPrice += Convert.ToSingle(chkOlives.Tag);
            
            if (chkOnion.Checked)
                ToppingTotalPrice += Convert.ToSingle(chkOnion.Tag);

            if (chkTomatoes.Checked)
                ToppingTotalPrice += Convert.ToSingle(chkTomatoes.Tag);

            if (chkMushrooms.Checked)
                ToppingTotalPrice += Convert.ToSingle(chkMushrooms.Tag);

            if (chkGreenPeppers.Checked)
                ToppingTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);

            return ToppingTotalPrice;
        }


        float GetSelectedCrustPrice()
        {
            if (rdbCrustThin.Checked)
                return Convert.ToSingle(rdbCrustThin.Tag);

            else
                return Convert.ToSingle(rdbCrustThink.Tag);
        }

        float GetSelectedSizePrice()
        {
            if (rdbtnSizeSmall.Checked)
                return Convert.ToSingle(rdbtnSizeSmall.Tag);

            else if (rdbtnSizeMeduim.Checked)
                return Convert.ToSingle(rdbtnSizeMeduim.Tag);

            else
                return Convert.ToSingle(rdbtnSizeLarg.Tag);
        }

        float   CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustPrice() + CalculateToppingsPrice();
        }

        void UpdateTotalPrice()
        {
            lbTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rdbtnSizeSmall.Checked)
            {
                lbSize.Text = " Small ";
                return ;
            }

            if (rdbtnSizeMeduim.Checked)
            {
                lbSize.Text = " Medium";
                return ;
            }

            if (rdbtnSizeLarg.Checked)
            {
                lbSize.Text = " Larg";
                return ;
            }


        }


        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rdbCrustThin.Checked)
            {
                lbCrustType.Text = "thin Crust";
                return ;
            }

            else
            {
                lbCrustType.Text = "think Crust";
                return;
            }

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            List<string> toppings = new List<string>();

            if (chkExtraChess.Checked)
                toppings.Add("Extra Cheese");

            if (chkOnion.Checked)
                toppings.Add("Onion");

            if (chkMushrooms.Checked)
                toppings.Add("Mushrooms");

            if (chkGreenPeppers.Checked)
                toppings.Add("Green Peppers");

            if (chkOlives.Checked)
                toppings.Add("Olives");

            if (chkTomatoes.Checked)
                toppings.Add("Tomatoes");

            if (toppings.Count == 0)
                lbToppings.Text = "No Toppings";
            else
                lbToppings.Text = string.Join("\n", toppings);
        }


        //void UpdateToppings()
        //{
        //    UpdateTotalPrice();

        //    string sToppings = "";

        //    if (chkExtraChess.Checked)
        //    {
        //        sToppings += " Extra Cheese ";
        //    }

        //    if (chkOnion.Checked)
        //    {
        //        sToppings += " Onion ";
        //    }

        //    if (chkMushrooms.Checked)
        //    {
        //        sToppings += " Mushrooms ";
        //    }

        //    if (chkGreenPeppers.Checked)
        //    {
        //        sToppings += " Green Peppers ";
        //    }

        //    if (chkOlives.Checked)
        //    {
        //        sToppings += " Olives ";
        //    }

        //    if (chkTomatoes.Checked)
        //    {
        //        sToppings += " Tomatoes ";
        //    }

        //    if (sToppings == "")
        //        sToppings += "No Toppings ";


        //    lbToppings.Text = sToppings;
        //}

        void UpdateOrderSummary()
        {
            UpdateTotalPrice();
            UpdateCrust();
            UpdateToppings();
            UpdateSize();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            Form new_DeliveryForm = new DeliveryForm();
            new_DeliveryForm.ShowDialog();

        }

        private void btnEatIn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about this?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                MessageBox.Show("Your Welcome table N number : 14", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else

                MessageBox.Show("Okay, your can Conirm order ? ", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrder.Enabled = false;
                gboxCrustType.Enabled = false;
                gboxSize.Enabled = false;
                gboxToppings.Enabled = false;
                gBoxWhere_to_eat.Enabled = false;
            }
            
        }

        private void rdbtnSizeLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void gbOrderSummary_Enter(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdbCrustThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        void ResetForm()
        {
            gbOrderSummary.Enabled = true;
            gboxCrustType.Enabled = true;
            gboxSize.Enabled = true;
            gboxToppings.Enabled = true;

            // Uncheck radio buttons
            rdbCrustThin.Checked = false;
            rdbCrustThink.Checked = false;

            rdbtnSizeLarg.Checked = false;
            rdbtnSizeSmall.Checked = false;
            rdbtnSizeMeduim.Checked = false;

            // Uncheck checkboxes
            chkExtraChess.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;

            lbSize.Enabled = true;
            lbToppings.Enabled = true;
            lbTotalPrice.Enabled = true;
            lbCrustType.Enabled = true;
            
        }


        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
