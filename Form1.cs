using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double N = 0.0;

        int mode = 0; //0 - nomode
                      //1 - add(+)
                      //2 - sub(-)
                      //3 - mul(*)
                      //4 - div(/)
                      // новая ветка

        
        
        
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                mode = 1;
                N = Convert.ToDouble(textBox1.Text);
                Num1.Text = textBox1.Text + " +";
                textBox1.Text = "";
            }

            catch
            {
                res.Text = "напиши число";
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            try
            {
                mode = 2;
                N = Convert.ToDouble(textBox1.Text);
                Num1.Text = textBox1.Text + " -";
                textBox1.Text = "";
            }

            catch
            {
                res.Text = "напиши число";
            }
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            try
            {
                mode = 3;
                N = Convert.ToDouble(textBox1.Text);
                Num1.Text = textBox1.Text + " *";
                textBox1.Text = "";
            }

            catch
            {
                res.Text = "напиши число";
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            try
            {
                mode = 4;
                N = Convert.ToDouble(textBox1.Text);
                Num1.Text = textBox1.Text + " /";
                textBox1.Text = "";
            }

            catch
            {
                res.Text = "напиши число";
            }
        }


        private void Result_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                res.Text = "напиши число";
                return;
            }
            switch (mode)
            {
                case 0:
                    res.Text = "выбери операцию";
                    break;

                case 1:
                    
                    res.Text = (N + Convert.ToDouble(textBox1.Text)).ToString();
                    Num1.Text += $" {textBox1.Text} =";
                    textBox1.Text = "";
                    mode = 0;
                    break;

                case 2:
                    res.Text = (N - Convert.ToDouble(textBox1.Text)).ToString();
                    Num1.Text += $" {textBox1.Text} =";
                    textBox1.Text = "";
                    mode = 0;
                    break;

                case 3:
                    res.Text = (N * Convert.ToDouble(textBox1.Text)).ToString();
                    Num1.Text += $" {textBox1.Text} =";
                    textBox1.Text = "";
                    mode = 0;
                    break;

                case 4:
                    if (Convert.ToDouble(textBox1.Text) == 0)
                    {
                        res.Text = "деление на 0";
                        break;
                    }
                    res.Text = (N / Convert.ToDouble(textBox1.Text)).ToString();
                    Num1.Text += $" {textBox1.Text} =";
                    textBox1.Text = "";
                    mode = 0;
                    break;
            }



        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
    }
}
