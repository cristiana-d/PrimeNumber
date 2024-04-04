using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumber
{
    public partial class PrimeNumber : Form
    {
        public PrimeNumber()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool isNumber = Int32.TryParse(PrimeNumberTextBox.Text, out result);
            if (isNumber)
            {
                bool isPrime = true;
                for (int i = 2; i <= result / 2; i++)
                {
                    if (result % i == 0)
                        isPrime = false;
                }
                if (isPrime)
                {
                    this.BackColor = Color.Green;
                    historyLabel.BorderStyle = BorderStyle.FixedSingle;
                    historyLabel.Text = historyLabel.Text + " "+ PrimeNumberTextBox.Text;
                    PrimeNumberTextBox.Text = string.Empty;
                }
                else
                {
                    this.BackColor = Color.Red;
                }

            }
            else
            {
                MessageBox.Show("S-a introdus un text");
            };
        }
    }
}
