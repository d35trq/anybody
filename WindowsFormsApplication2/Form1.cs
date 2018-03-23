using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
            
        
        public double x = 0;
        public double y = 0;
        public double z = 0;
        public double c = 0;
        public float pi = 3.14f;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = Math.Pow(2, Math.Pow(y, x));
            c += Math.Pow(3, x * y);
            c -= (y * (Math.Atan(z) - pi / 6)) / (Math.Abs(x) + (1 / (Math.Pow(y, 2) + 1)));
            
            x = double.Parse(textBox2.Text);
             y = double.Parse(textBox3.Text);
             z = double.Parse(textBox4.Text);
            textBox1.Text = c.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            x = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             y = double.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            z = double.Parse(textBox4.Text);
        }
    }
}
