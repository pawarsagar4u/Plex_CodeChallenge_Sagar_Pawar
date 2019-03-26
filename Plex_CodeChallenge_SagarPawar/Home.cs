using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plex_CodeChallenge_SagarPawar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fibonacci fib = new Fibonacci();
            fib.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SumOfTwoLargestIntiger sumInt = new SumOfTwoLargestIntiger();
            sumInt.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
