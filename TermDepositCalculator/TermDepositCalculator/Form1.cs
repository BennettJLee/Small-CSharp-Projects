using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermDepositCalculator
{
    //Ben Lee
    //1567783
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            double interestRate = 0;
            double depositValue = 0;
            int numberofYears = 0;
            int year = 0;
            double interest = 0;
            double deposit = 0;
            double newDeposit = 0;

            try
            {
                //get inputs
                interestRate = double.Parse(textBoxInterest.Text) / 100;
                depositValue = double.Parse(textBoxValue.Text);
                numberofYears = int.Parse(textBoxNumYears.Text);

                if (interestRate > 0 && depositValue > 0)
                {
                    for (int i = 1; i <= numberofYears; i++)
                    {
                        year = i;
                        //declared newdeposit value
                        newDeposit = depositValue;
                        //calculates the interest and deposit values
                        interest = newDeposit * interestRate;
                        newDeposit += interest;
                        //sets the new deposit value
                        depositValue = newDeposit;
                        //displays results
                        Console.WriteLine("Year " + year + ": interest = $" + interest.ToString("N2") + " and deposit = $" + newDeposit.ToString("N2"));
                    }
                }
                else
                {
                    //Display error message
                    MessageBox.Show("please insert values over 0");
                    //clear textboxes
                    textBoxNumYears.Clear();
                    textBoxInterest.Clear();
                    textBoxValue.Clear();
                    //reset focus
                    textBoxNumYears.Focus();
                }
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
                //clear textboxes
                textBoxNumYears.Clear();
                textBoxInterest.Clear();
                textBoxValue.Clear();
                //reset focus
                textBoxNumYears.Focus();
            }
        }
    }
}
