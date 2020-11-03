using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        const double VAT = 0.21;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int startkm = int.Parse(textBox1.Text);
            int endkm = int.Parse(textBox2.Text);
            float pricepkm = float.Parse(textBox3.Text);

            int kmdistance = endkm - startkm;
            float result = kmdistance * pricepkm;
            double VATprice = result * VAT;
            double resultVAT = result + VATprice;
            
            label7.Text = result.ToString("n");
            label8.Text = VATprice.ToString("n");
            label9.Text = resultVAT.ToString("n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }
    }
}
