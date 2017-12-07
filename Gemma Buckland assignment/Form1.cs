using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gemma_Buckland_assignment
{
    public partial class Form1 : Form
    {
        Decimal total_pound;//Global Variable to declare
        int total_pence;//Global Variable
        int credit;// The amount of credit generated
        int value;//The value gathered



       


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_1p.Text);// This will hold the number and change "label_1p"
                hold_number = hold_number + 1; // Once the 1p is clicked it will increase by +1.
                label_1p.Text = hold_number.ToString();
                total_pence += 1;// For this i have added 1 to txt_value
                txt_value.Text = total_pence.ToString(); // For this i have displayed the variable into the text box, txt_value

                total_pound += 0.01m;// For this i have added 0.01 to txt_value2
                txt_value2.Text = total_pound.ToString();

            }
        }

        private void txt_credit_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_2p_Click(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_2p.Text);// This will hold the number and change "label_2p"
                hold_number = hold_number + 1; // Once the 2p is clicked it will increase by +2.
                label_2p.Text = hold_number.ToString();
                total_pence += 2;// For this i have added 2 to txt_value
                txt_value.Text = total_pence.ToString();

                total_pound += 0.02m;// For this i have added 0.02 to txt_value2
                txt_value2.Text = total_pound.ToString();
            }
        }

        private void pic_5_Click(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_5p.Text);// This will hold the number and change "label_5p"
                hold_number = hold_number + 1; // Once the 5p is clicked it will increase by +1.
                label_5p.Text = hold_number.ToString();
                total_pence += 5;// For this i have added 5 to txt_value
                txt_value.Text = total_pence.ToString();

                total_pound += 0.05m;// For this i have added 0.05 to txt_value2
                txt_value2.Text = total_pound.ToString();
            }

        }
        
        private void RESET_Click(object sender, EventArgs e)
        {
            txt_value.Text = "0"; // I have cleared all the text boxes
            txt_value2.Text = "0";
            txt_credit.Text = "0";
            txt_nocredit.Text = "0";
            label_1p.Text = "0"; // I have set all the labels to the value "0"
            label_2p.Text = "0";
            label_5p.Text = "0";
            label_10p.Text = "0";
            label_20p.Text = "0";
            label_50p.Text = "0";
            label_100p.Text = "0";
            label_200p.Text = "0";
        }

        private void pic_10p_Click_1(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_10p.Text);// This will hold the number and change "label_10p"
                hold_number = hold_number + 1; // Once the 10p is clicked it will increase by +1.
                label_10p.Text = hold_number.ToString();
                total_pence += 10;// For this i have added 10 to txt_value
                txt_value.Text = total_pence.ToString();

                total_pound += 0.10m;// For this i have added 0.10 to txt_value2
                txt_value2.Text = total_pound.ToString();

            }
        }

        private void pic_20p_Click_1(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_20p.Text);// This will hold the number and change "label_20p"
                hold_number = hold_number + 1; // Once the 20p is clicked it will increase by +1.
                label_20p.Text = hold_number.ToString();
                total_pence += 20;// For this i have added 20 to txt_value
                txt_value.Text = total_pence.ToString();

                total_pound += 0.20m;// For this i have added 0.20 to txt_value2
                txt_value2.Text = total_pound.ToString();
            }
        }

        private void pic_50p_Click_1(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_50p.Text);// This will hold the number and change "label_50p"
                hold_number = hold_number + 1; // Once the 50p is clicked it will increase by +1.
                label_50p.Text = hold_number.ToString();
                total_pence += 50;// For this i have added 50 to txt_value
                txt_value.Text = total_pence.ToString();

                total_pound += 0.50m;// For this i have added 0.50 to txt_value2
                txt_value2.Text = total_pound.ToString();
            }
        }

        private void pic_100p_Click_1(object sender, EventArgs e)
        {

            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_100p.Text);// This will hold the number and change "label_100p"
                hold_number = hold_number + 1; // Once the 100p is clicked it will increase by +1.
                label_100p.Text = hold_number.ToString();
                total_pound += 1.00m;// For this i have added 1.00 to txt_value2
                txt_value2.Text = total_pound.ToString();

                total_pence += 100;// For this i have added 100 to txt_value
                txt_value.Text = total_pence.ToString();
            }
        }

        private void pic_200p_Click_1(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_200p.Text);// This will hold the number and change "label_200p"
                hold_number = hold_number + 1; // Once the 200p is clicked it will increase by +1.
                label_200p.Text = hold_number.ToString();
                total_pound += 2.00m;// For this i have added 2.00 to txt_value2
                txt_value2.Text = total_pound.ToString();

                total_pence += 200;// For this i have added 200 to txt_value
                txt_value.Text = total_pence.ToString();
            }
        }
    }
}

