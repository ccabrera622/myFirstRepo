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
                    return (x + y).ToString("G10");
                case '-':
                    return (x - y).ToString("G10");
                case 'x':
                    return (x * y).ToString("G10");
                case '/':
                    if (y == 0)
                    {
                        newNum = true;
                        activated = false;
                        return "Error";
                    }
                    else
                    {
                        return (x / y).ToString("G10");
                    }
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
            activated = false;
            textBoxDisplay.Text = "";
            newNum = true;
        }

        private void handleNumberClick(object sender, EventArgs e)
        {
            if (newNum)
            {
                textBoxDisplay.Text = "";
                newNum = false;
            }
            if(textBoxDisplay.Text.Length < 10)
            {
                Button current = (Button)sender;
                textBoxDisplay.Text += current.Text;
            }
            
        }

        private void operationClick(object sender, EventArgs e)
        {
            string s = textBoxDisplay.Text;
            if (s == "Error")
            {
                return;
            }
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
                if (ans != "Error")
                {
                    ONE = Convert.ToDouble(ans);
                }
            }
            Button current = (Button)sender;
            sign = Convert.ToChar(current.Text);

        }

        private void buttonEqu_Click(object sender, EventArgs e)
        {
            string s = textBoxDisplay.Text;
            if (s == "Error")
            {
                return;
            }
            if (s != "" && activated)
            {
                TWO = Convert.ToDouble(s);
                string ans = calculate(ONE, TWO, sign);
                textBoxDisplay.Text = ans;
                if (ans != "Error")
                {
                    ONE = Convert.ToDouble(ans);
                }
                activated = false;
            }
            newNum = true;
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            string s = textBoxDisplay.Text;
            if (s == "Error")
            {
                return;
            }
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
            if (s == "Error")
            {
                return;
            }
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
