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

        private void clear_Click(object sender, EventArgs e)
        {
            clearAll();
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

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void subtract_Click(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {

        }

        private void divide_Click(object sender, EventArgs e)
        {

        }

        private void updateScreen(int val)
        {
            output = output * 10 + val;
            op.Text = output.ToString();
        }

        private void clearAll()
        {
            output = 0;
            op.Text = "0";
            temp = 0;
        }
    }
}
