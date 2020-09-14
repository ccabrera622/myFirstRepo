using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public double ONE;
        public double TWO;
        public char sign;
        bool newNum = false;
        bool activated = false;

        public Form1()
        {
            InitializeComponent();
        }

        private string calculate(double x, double y, char op)
        {
            switch (op)
            {
                case '+':
                    return Convert.ToString(x + y);
                case '-':
                    return Convert.ToString(x - y);
                case 'x':
                    return Convert.ToString(x * y);
                case '/':
                    return Convert.ToString(x / y);
                default:
                    return "0";
                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "1234567890";
            newNum = true;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {         
            textBoxDisplay.Text = "";
            newNum = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            textBoxDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            textBoxDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            textBoxDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            textBoxDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            textBoxDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            textBoxDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            textBoxDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            textBoxDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            textBoxDisplay.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            textBoxDisplay.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            string s = textBoxDisplay.Text;
            sign = '+';
            newNum = true;
            if (s != "" && !activated)
            {
                ONE = Convert.ToDouble(s);
                activated = true;
            }
            else if (s != "" && activated)
            {
                TWO = Convert.ToDouble(s);
                string ans = calculate(ONE, TWO, sign);
                textBoxDisplay.Text = ans;
                ONE = Convert.ToDouble(ans);
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            string s = textBoxDisplay.Text;
            sign = '-';
            newNum = true;
            if (s != "" && !activated)
            {
                ONE = Convert.ToDouble(s);
                activated = true;
            }
            else if (s != "" && activated)
            {
                TWO = Convert.ToDouble(s);
                string ans = calculate(ONE, TWO, sign);
                textBoxDisplay.Text = ans;
                ONE = Convert.ToDouble(ans);
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            string s = textBoxDisplay.Text;
            sign = 'x';
            newNum = true;
            if (s != "" && !activated)
            {
                ONE = Convert.ToDouble(s);
                activated = true;
            }
            else if (s != "" && activated)
            {
                TWO = Convert.ToDouble(s);
                string ans = calculate(ONE, TWO, sign);
                textBoxDisplay.Text = ans;
                ONE = Convert.ToDouble(ans);
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            string s = textBoxDisplay.Text;
            sign = '/';
            newNum = true;
            if (s != "" && !activated)
            {
                ONE = Convert.ToDouble(s);
                activated = true;
            }
            else if (s != "" && activated)
            {
                TWO = Convert.ToDouble(s);
                string ans = calculate(ONE, TWO, sign);
                textBoxDisplay.Text = ans;
                ONE = Convert.ToDouble(ans);
            }

        }

        private void buttonEqu_Click(object sender, EventArgs e)
        {
            string s = textBoxDisplay.Text;
            if (s != "" && activated)
            {
                TWO = Convert.ToDouble(s);
                string ans = calculate(ONE, TWO, sign);
                textBoxDisplay.Text = ans;
                ONE = Convert.ToDouble(ans);
                activated = false;
            }
            newNum = true;
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            string s = textBoxDisplay.Text;
            if (!s.Contains("."))
            {
                if (newNum)
                {
                    textBoxDisplay.Text = "0";
                    newNum = false;
                }
                textBoxDisplay.Text += ".";

            }

        }

        private void buttonNeg_Click(object sender, EventArgs e)
        {
            string s = textBoxDisplay.Text;
            if (s.Contains("-"))
            {
                textBoxDisplay.Text = s.Substring(1);
            }
            else
            {
                textBoxDisplay.Text = "-" + textBoxDisplay.Text;
            }

        }
    }
}
