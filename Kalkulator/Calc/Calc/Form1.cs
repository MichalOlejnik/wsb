using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void ONE_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
                result.Clear();
            Button b = (Button)sender;      //przekazanie info- jaki obiekt jest 
            result.Text += b.Text;          //text z buttona, przekazany do pola tekstowego
        }

        private void CE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void PLUS_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(result.Text);
            Operation = "+";
            result.Clear();
        }

        private void DOT_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + ".";
        }

        private void MINUS_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(result.Text);
            Operation = "-";
            result.Clear();
        }
        
        private void MUL_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(result.Text);
            Operation = "*";
            result.Clear();
        }

        private void DIV_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(result.Text);
            Operation = "/";
            result.Clear();
        }

        private void wynik_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Wynik;

            SecondNumber = Convert.ToDouble(result.Text);

            if (Operation == "+")
            {
                Wynik = (FirstNumber + SecondNumber);
                result.Text = Convert.ToString(Wynik);
                FirstNumber = Wynik;
            }
            if (Operation == "-")
            {
                Wynik = (FirstNumber - SecondNumber);
                result.Text = Convert.ToString(Wynik);
                FirstNumber = Wynik;
            }
            if (Operation == "*")
            {
                Wynik = (FirstNumber - SecondNumber);
                result.Text = Convert.ToString(Wynik);
                FirstNumber = Wynik;
            }
            if (Operation == "/")
            {
                Wynik = (FirstNumber - SecondNumber);
                result.Text = Convert.ToString(Wynik);
                FirstNumber = Wynik;
            }

        }

    }
}
