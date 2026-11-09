using System;
using System.Windows.Forms;

namespace Forms_I_307__4_
{
    public partial class Calculator : Form
    {
        
        double num1 = 0;       
        double num2 = 0;      
        string znak = "";      
        double result = 0;    
        bool flag = true;      

        public Calculator()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag) { textBox1.Text = "1"; flag = false; }
            else { textBox1.Text = textBox1.Text + "1"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag) { textBox1.Text = "2"; flag = false; }
            else { textBox1.Text = textBox1.Text + "2"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag) { textBox1.Text = "3"; flag = false; }
            else { textBox1.Text = textBox1.Text + "3"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag) { textBox1.Text = "4"; flag = false; }
            else { textBox1.Text = textBox1.Text + "4"; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag) { textBox1.Text = "5"; flag = false; }
            else { textBox1.Text = textBox1.Text + "5"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (flag) { textBox1.Text = "6"; flag = false; }
            else { textBox1.Text = textBox1.Text + "6"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag) { textBox1.Text = "7"; flag = false; }
            else { textBox1.Text = textBox1.Text + "7"; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (flag) { textBox1.Text = "8"; flag = false; }
            else { textBox1.Text = textBox1.Text + "8"; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (flag) { textBox1.Text = "9"; flag = false; }
            else { textBox1.Text = textBox1.Text + "9"; }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (flag) { textBox1.Text = "0"; flag = false; }
            else { textBox1.Text = textBox1.Text + "0"; }
        }

        
        private void button18_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = "0.";
                flag = false;
            }
            else if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = double.Parse(textBox1.Text.Replace(".", ","));
                znak = "+";
                textBox1.Text = "";
                flag = true;
            }
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = double.Parse(textBox1.Text.Replace(".", ","));
                znak = "-";
                textBox1.Text = "";
                flag = true;
            }
        }

       
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = double.Parse(textBox1.Text.Replace(".", ","));
                znak = "*";
                textBox1.Text = "";
                flag = true;
            }
        }

       
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = double.Parse(textBox1.Text.Replace(".", ","));
                znak = "/";
                textBox1.Text = "";
                flag = true;
            }
        }

       
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && znak != "")
            {
                num2 = double.Parse(textBox1.Text.Replace(".", ","));

                if (znak == "+") { result = num1 + num2; }
                else if (znak == "-") { result = num1 - num2; }
                else if (znak == "*") { result = num1 * num2; }
                else if (znak == "/")
                {
                    if (num2 == 0)
                    {
                        textBox1.Text = "Ошибка";
                        return;
                    }
                    result = num1 / num2;
                }

                textBox1.Text = result.ToString();
                flag = true;
            }
        }

     
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num2 = double.Parse(textBox1.Text.Replace(".", ","));
                result = num2 / 100;
                textBox1.Text = result.ToString();
                flag = true;
            }
        }

      
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            num1 = 0;
            num2 = 0;
            znak = "";
            result = 0;
            flag = true;
        }
    }
}