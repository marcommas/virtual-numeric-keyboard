using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virtual_numeric_keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void addNumber(int numero)
        {
            tbNumbers.Text = tbNumbers.Text + numero;
        }

        public void removeNumber()
        {
            int length;
            string text, newText;
            text = tbNumbers.Text;
            length = tbNumbers.TextLength;

            if (tbNumbers.TextLength != 0)
            {
                newText = text.Substring(0, length - 1);
                tbNumbers.Text = newText;
            }
 
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            addNumber(1);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            addNumber(2);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            addNumber(3);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            addNumber(4);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            addNumber(5);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            addNumber(6);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            addNumber(7);
        }

        private void btnEigth_Click(object sender, EventArgs e)
        {
            addNumber(8);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            addNumber(9);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            addNumber(0);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            removeNumber();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbNumbers.Clear();
        }
      


    }
}
