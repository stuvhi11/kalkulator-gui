using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace implementasi
{
    public partial class Form1 : Form
    {
        private decimal number1 = 0.0m;
        private decimal number2 = 0.0m;
        private decimal hasil = 0.0m;
        private string operasi = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textinput.Text == "0")
            {
                textinput.Text = "7";
            }
            else
            {
                textinput.Text += "7";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textinput.Text == "0")
            {
                textinput.Text = "0";
            }
            else
            {
                textinput.Text += "0";
            }
        }

        private void tiga_Click(object sender, EventArgs e)
        {
            if (textinput.Text == "0")
            {
                textinput.Text = "3";
            }
            else
            {
                textinput.Text += "3";
            }
        }

        private void enam_Click(object sender, EventArgs e)
        {
            if (textinput.Text == "0")
            {
                textinput.Text = "6";
            }
            else
            {
                textinput.Text += "6";
            }
        }

        private void koma_Click(object sender, EventArgs e)
        {
            if (!textinput.Text.Contains("."))
            {
                textinput.Text += ".";
            }
        }

        private void dua_Click(object sender, EventArgs e)
        {
            if (textinput.Text == "0")
            {
                textinput.Text = "2";
            }
            else
            {
                textinput.Text += "2";
            }
        }

        private void satu_Click(object sender, EventArgs e)
        {
            if (textinput.Text == "0")
            {
                textinput.Text = "1";
            }
            else
            {
                textinput.Text += "1";
            }
        }

        private void empat_Click(object sender, EventArgs e)
        {
            if (textinput.Text == "0")
            {
                textinput.Text = "4";
            }
            else
            {
                textinput.Text += "4";
            }
        }

        private void lima_Click(object sender, EventArgs e)
        {
            if (textinput.Text == "0")
            {
                textinput.Text = "5";
            }
            else
            {
                textinput.Text += "5";
            }
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            if (textinput.Text == "0")
            {
                textinput.Text = "8";
            }
            else
            {
                textinput.Text += "8";
            }
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            if (textinput.Text == "0")
            {
                textinput.Text = "9";
            }
            else
            {
                textinput.Text += "9";
            }
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(textinput.Text);
            textinput.Clear();
            operasi = "+";
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(textinput.Text);
            textinput.Clear();
            operasi = "/";
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(textinput.Text);
            textinput.Clear();
            operasi = "-";
        }

        private void kali_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(textinput.Text);
            textinput.Clear();
            operasi = "*";
        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            switch (operasi)
            {
                case "+":
                    number2 = decimal.Parse(textinput.Text);
                    hasil = number1 + number2;
                    textinput.Text = hasil.ToString();
                    break;
                case "-":
                    number2 = decimal.Parse(textinput.Text);
                    hasil = number1 - number2;
                    textinput.Text = hasil.ToString();
                    break;
                case "*":
                    number2 = decimal.Parse(textinput.Text);
                    hasil = number1 * number2;
                    textinput.Text = hasil.ToString();
                    break;
                case "/":
                    number2 = decimal.Parse(textinput.Text);
                    hasil = number1 / number2;
                    textinput.Text = hasil.ToString();
                    break;
            }
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            number1 = 0.0m;
            number2 = 0.0m;
            textinput.Text = "0";
        }
    }
}
