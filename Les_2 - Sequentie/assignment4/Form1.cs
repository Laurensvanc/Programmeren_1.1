using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        const double VAT = 0.21;

        public Form1()
        {
            InitializeComponent();
        }

        static Tuple<double, double> VATCalculator(double Input)
        {
            double VATCosts = Input * VAT;

            double result = VATCosts + Input;
            return Tuple.Create(result, VATCosts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Price = double.Parse(textBox1.Text);

            var values = VATCalculator(Price);

            label7.Text = Price.ToString("n");
            label6.Text = values.Item2.ToString("n");
            label5.Text = values.Item1.ToString("n");
        }
    }
}
