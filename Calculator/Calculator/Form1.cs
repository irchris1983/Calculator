using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int output = 0;
        int temp = 0;
        int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            updateScreen(1);
        }

        private void two_Click(object sender, EventArgs e)
        {
            updateScreen(2);
        }

        private void three_Click(object sender, EventArgs e)
        {
            updateScreen(3);
        }

        
        
        private void four_Click(object sender, EventArgs e)
        {
            updateScreen(4);
        }

        private void five_Click(object sender, EventArgs e)
        {
            updateScreen(5);
        }

        private void six_Click(object sender, EventArgs e)
        {
            updateScreen(6);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            updateScreen(7);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            updateScreen(8);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            updateScreen(9);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            finalOP();
            
            op.Text = output.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            tempStore();
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            tempStore();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            tempStore();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            tempStore();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clear(true);
        }

        private void clearentry_Click(object sender, EventArgs e)
        {
            clear(false);
        }

        private void updateScreen(int val)
        {
            output = output * 10 + val;
            op.Text = output.ToString();
        }

        /// <summary>
        /// Function will zero the screen
        /// </summary>
        /// <param name="all">'all' should be set as True if stored value needs to be removed
        /// </param>
        private void clear(bool all)
        {
            output = 0;
            op.Text = "0";
            if (all == true)
            {
                temp = 0;                                       //if want to clear everything need to also remove stored value
            }
            else
            {                                                   //Don't do anything to temp as only the screen and output values should be removed
            }
            
        }                

        private void tempStore()
        {
            temp = output;
            clear(false);
        }

        private void finalOP()
        {
            output = output + temp;
        }
    }
}
