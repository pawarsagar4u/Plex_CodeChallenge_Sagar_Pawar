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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {
           
        }   

        private bool isValid()
        {
            bool _isValid = true;

            if (string.IsNullOrEmpty(txtSequence.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtSequence.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in Sequence textbox");
                _isValid = false;
                return _isValid;
            }


            if (string.IsNullOrEmpty(txtSequence.Text))
            {
                MessageBox.Show("Please Enter correct sequence");
                _isValid = false;
            }

            if (string.IsNullOrEmpty(txtSignature.Text))
            {
                MessageBox.Show("Please Enter correct signature");
                _isValid = false;
            }

            //if (string.IsNullOrEmpty(txtSignature.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtSignature.Text, "[0-9]+(,[0-9]+)*"))
            //{
            //    MessageBox.Show("Please enter only comma separated numbers in Signature textbox");
            //    _isValid = false;
            //}

            return _isValid;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                int n = 0;
                string[] inpurArray = null;
                try
                {
                    n = Convert.ToInt32(txtSequence.Text);

                    //split commasepated input to array
                    inpurArray = txtSignature.Text.Split(',');
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Input not in Proper format.");
                }
                
                try
                {
                    string result = string.Empty;
                    for (int i = inpurArray.Length; i <= n; i++)
                    {
                        if (i == inpurArray.Length)
                        {
                            result = result + string.Join(",", inpurArray) + ",";
                        }
                        else
                        {
                            int[] intarrSes = inpurArray.Select(s => int.Parse(s)).ToArray();
                            //Method Call
                            inpurArray = GetFibonacci(intarrSes);
                            result = result + string.Join(",", inpurArray[inpurArray.Length - 1]) + ",";
                        }
                    }
                    txtOutput.Text = result.TrimEnd(',');

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong while processing Fibonacci sequence.");                    
                }
            }
        }

        private string[]  GetFibonacci( int[]inputArray)
        {
            int[] temp = new int[inputArray.Length];
            //Copy in to temp array
            for (int cnt = 0; cnt < inputArray.Length-1; cnt++)
            {
                temp[cnt] = inputArray[cnt +1];
            }
            //Make sum
            temp[temp.Length - 1] = inputArray.Sum();   
             
            return temp.Select(s => s.ToString()).ToArray();
        }
    }
}
