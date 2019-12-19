using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dane_TextChanged(object sender, EventArgs e)
        {
            double bok;
            if (double.TryParse(Dane.Text, out bok)&&bok>0)
            {
               txtPole.Text = Math.Pow(bok, 2).ToString(); //textBox3-Pole
                txtObwod.Text = (4 * bok).ToString();
                Komunikat.Text = String.Empty;
            }
            else
            {
                Komunikat.Text ="Wprowadź wartość dodatnią";
                txtPole.Text = String.Empty;
                txtObwod.Text = String.Empty;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Komunikat_Click(object sender, EventArgs e)
        {
        
        }

        private void btnWyczsc_Click(object sender, EventArgs e)
        {
                txtPole.Text = String.Empty;
                txtObwod.Text = String.Empty;
                Dane.Text = String.Empty;
            Komunikat.Text = "wpisz wymiar boku";
           
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
