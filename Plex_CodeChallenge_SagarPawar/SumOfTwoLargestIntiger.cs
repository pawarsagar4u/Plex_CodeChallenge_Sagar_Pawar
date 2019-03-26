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
    public partial class SumOfTwoLargestIntiger : Form
    {
        public SumOfTwoLargestIntiger()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            bool _isValid = false;
            if(string.IsNullOrEmpty(txtArraySequence.Text))
            {
                MessageBox.Show("Please Enter correct sequence");
                _isValid = false;
            }
            return _isValid;
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            string[] ArrInput = null;
            try
            {
                ArrInput = txtArraySequence.Text.Split(',');
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input not in Proper format.");
            }

            try
            {
                if (ArrInput.Length >= 4)
                {

                    var SequenceArray = ArrInput.Select(s => int.Parse(s)).ToArray();
                    int result = GetSum(SequenceArray);
                    txtOutput.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Enter at least four number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while sum of two largest positive numbers.");
            }
        }

        private int GetSum(int[] SequenceArray)
        {
            int result = 0;
            //Sort Arrayve
            Array.Sort(SequenceArray);
            //Reverse
            Array.Reverse(SequenceArray);

            //SequenceArray.OrderByDescending(x => x).ToArray();

            int _first = SequenceArray[0] > 0 ? SequenceArray[0] : 0 ;

            int _Second = SequenceArray[1] > 0 ? SequenceArray[1] : 0;

            if (_first != _Second)
            {
                result = _first + _Second;
            }
            else
            {
                result = _first;
            }
            return result;
        }
        
    }
}
