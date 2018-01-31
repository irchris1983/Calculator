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
        int val = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            val = 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            val = 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            val = 3;
        }
    }
}
