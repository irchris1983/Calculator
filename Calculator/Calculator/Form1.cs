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

        private void updateScreen(int val)
        {
            output = output * 10 + val;
            op.Text = output.ToString();
            //print output
        }

        private void clearAll()
        {
            output = 0;
            op.Text = "0";
            temp = 0;
            //print output
        }
    }
}
