﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неверный пароль");

            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text);
            double c = Convert.ToInt32(textBox3.Text);

            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                textBox4.Text = "x1 = " + x1 + "x2 =" + x2;
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                textBox4.Text = "x1" + x;
            }
            else
            {
                textBox4.Text = "Нет решения";
            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
