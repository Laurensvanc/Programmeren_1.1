using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment8
{
    public partial class Form1 : Form
    {

        const double VAT = 0.21;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();

            int numberOfShirts = int.Parse(textBox1.Text);
            int numberOfPants = int.Parse(textBox2.Text);

            float totalShirtPrice = numberOfShirts * 30;
            float totalPantsPrice = numberOfPants * 100;

            float totalPrice = totalPantsPrice + totalShirtPrice;
            double VATPrice = totalPrice * VAT;
            double priceInclVAT = VATPrice + totalPrice;

            label6.Text = Math.Round(totalPrice, 2).ToString();
            label8.Text = Math.Round(VATPrice, 2).ToString();
            label10.Text = Math.Round(priceInclVAT, 2).ToString();

        }
    }
}
