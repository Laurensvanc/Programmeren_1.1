using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double seconds = double.Parse(textBox1.Text);

            TimeSpan time = TimeSpan.FromSeconds(seconds);

            string result = time.ToString(@"hh\:mm\:ss");

            label3.Text = result;

        }
    }
}
