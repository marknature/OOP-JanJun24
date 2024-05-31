using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = (int)Convert.ToInt64(textfirst.Text);
            num2 = (int)Convert.ToInt64(textsecnum.Text);
            result = num1 + num2;
            //textresult.Text = Convert.ToString(result);
            textresult.Text = result.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius;
            double area;
            radius = Convert.ToInt32(textBox1.Text);
            area = Math.PI * Math.Pow(radius, 2);
            //area = 3.14 * (radius * raduis);
            //area = 22/7 * (radius * raduis);
            textresult.Text = area.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
