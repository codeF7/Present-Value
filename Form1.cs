using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Present_Value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // ValueInput method converts user input and stores it in arguments.
        // If the conversion is successful, the method returns true. 

        private bool ValidInput(ref double futureValue, ref double rate, ref double years)
        {
            // Flag variable to indicate whether the input is valid.
            bool inputCheck = false;

            // Convert all inputs to double
            if (double.TryParse(futureValueTestBox.Text, out futureValue))
            {
                if (double.TryParse(annualInterestRateTextBox.Text, out rate))
                {
                    if (double.TryParse(numberOfYearsTextBox.Text, out years))
                    {
                        inputCheck = true;
                    }
                    else
                    {
                        // Display an error message for years.
                        MessageBox.Show("Amount of years entered is invalid.");
                    }
                }
                else
                {
                    // Display an error message for annual rate.
                    MessageBox.Show("Annual interest rate is invalid.");
                }
            }
            else
            {
                // Display an error message for desired value.
                MessageBox.Show("Desired or future value entered is invalid.");
            }

            // Return the result.
            return inputCheck;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Variables for future value, rate, years, and present value.
            double futureValue = 0, rate = 0, years = 0, presentValue = 0, ratePercent = 0;

            if (ValidInput(ref futureValue, ref rate, ref years))
            {
                // Calculate the deposit needed.
                
                // Conversion for r, rate, which is a percent.
                ratePercent = rate / 100;

                // Using Math.Pow formula for exponent calculation.
                presentValue = futureValue / Math.Pow((1 + ratePercent), years);
              

                // To.String("c")
                presentValueLabel.Text = presentValue.ToString("c");
            }



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

    }
}
