using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double calculateAvarage(double i1, double i2, double i3)
        {
            double result = (i1 + i2 + i3) / 3;

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i1 = double.Parse(textBox1.Text);
            double i2 = double.Parse(textBox2.Text);
            double i3 = double.Parse(textBox3.Text);

            double result = calculateAvarage(i1, i2, i3);

            result = Math.Round(result, 3);

            label5.Text = result.ToString();
        }
    }
}
