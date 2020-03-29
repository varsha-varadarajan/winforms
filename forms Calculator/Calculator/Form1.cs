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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + "1";
        }        

        private void btnTwo_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + "0";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            if (!(s.ElementAt(s.Length - 1) == '+' || s.ElementAt(s.Length - 1) == '-' || s.ElementAt(s.Length - 1) == '*' || s.ElementAt(s.Length - 1) == '/'))
            ResultDisplay.Text = s + "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            if (!(s.ElementAt(s.Length - 1) == '+' || s.ElementAt(s.Length - 1) == '-' || s.ElementAt(s.Length - 1) == '*' || s.ElementAt(s.Length - 1) == '/'))
            ResultDisplay.Text = s + "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            if (!(s.ElementAt(s.Length - 1) == '+' || s.ElementAt(s.Length - 1) == '-' || s.ElementAt(s.Length - 1) == '*' || s.ElementAt(s.Length - 1) == '/'))
            ResultDisplay.Text = s + "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            if (!(s.ElementAt(s.Length - 1) == '+' || s.ElementAt(s.Length - 1) == '-' || s.ElementAt(s.Length - 1) == '*' || s.ElementAt(s.Length - 1) == '/'))
            ResultDisplay.Text = s + "/";
        }
        /*
        private void btnEqual_Click(object sender, EventArgs e)
        {
            int operatorPosition = 0;
            string s = ResultDisplay.Text;
            char operation = '+';
            if (s.Contains('+'))
            {
                operation = '+';
                operatorPosition = s.IndexOf('+');
            }
            else
                if (s.Contains('-'))
                {
                    operation = '-';
                    operatorPosition = s.IndexOf('-');
                }
                else
                    if (s.Contains('*'))
                    {
                        operation = '*';
                        operatorPosition = s.IndexOf('*');
                    }
                    else
                        if (s.Contains('/'))
                        {
                            operation = '/';
                            operatorPosition = s.IndexOf('/');
                        }
            string operator1 = "";
            string operator2 = "";

            for (int i = 0; i < operatorPosition; i++)
            {
                operator1 += s.ElementAt(i);
            }
            for (int i = operatorPosition+1 ; i < s.Length; i++)
            {
                operator2 += s.ElementAt(i);
            }

            int op1 = int.Parse(operator1);
            int op2 = int.Parse(operator2);
            int result = 0;

            switch (operation)
            {
                case '+': 
                    result = op1+op2;
                    break;
                case '-':
                    result = op1-op2;
                    break;
                case '*':
                    result = op1*op2;
                    break;
                case '/':
                    result = op1/op2;
                    break;
            }
            ResultDisplay.Text = s + "="+ result.ToString();
        } */

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int operatorPosition = 0;
            string s = ResultDisplay.Text;
            char operation = '+';
            if (s.Contains('+'))
            {
                operation = '+';
                operatorPosition = s.IndexOf('+');
            }
            else
                if (s.Contains('-'))
                {
                    operation = '-';
                    operatorPosition = s.IndexOf('-');
                }
                else
                    if (s.Contains('*'))
                    {
                        operation = '*';
                        operatorPosition = s.IndexOf('*');
                    }
                    else
                        if (s.Contains('/'))
                        {
                            operation = '/';
                            operatorPosition = s.IndexOf('/');
                        }
            string operator1 = "";
            string operator2 = "";

            for (int i = 0; i < operatorPosition; i++)
            {
                operator1 += s.ElementAt(i);
            }
            for (int i = operatorPosition + 1; i < s.Length; i++)
            {
                operator2 += s.ElementAt(i);
            }

            float op1 = float.Parse(operator1);
            float op2 = float.Parse(operator2);
            float result = 0;

            switch (operation)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
            }
            ResultDisplay.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResultDisplay.Text = "";            
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            string s = ResultDisplay.Text;
            ResultDisplay.Text = s + ".";
        }
    }
}
