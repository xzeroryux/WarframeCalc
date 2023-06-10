using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarframeCalc
{
    public partial class Form1 : Form
    {

        double N = 16; //Константа всегда равная 16

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kvant = Math.Round(Convert.ToDouble(textBox4.Text) / N , 2);

            double carmor = Convert.ToDouble(textBox6.Text);//чистая броня
            double armor = carmor / (carmor + 300);//сопротивление брони

            if (radioButton1.Checked == true)
            {
                double punch = Math.Round(Math.Round(Convert.ToDouble(textBox1.Text) / kvant) * kvant, 2);
                double piercing = Math.Round(Math.Round(Convert.ToDouble(textBox2.Text) / kvant) * kvant, 2);
                double slash = Math.Round(Math.Round(Convert.ToDouble(textBox3.Text) / kvant) * kvant, 2);
                slash = slash * 1.25;
                double sum = Math.Round(punch + piercing + slash);
                textBox1.Text = punch.ToString();
                textBox2.Text = piercing.ToString();
                textBox3.Text = slash.ToString();
                textBox5.Text = sum.ToString();
            }
            if (radioButton2.Checked == true)
            {
                double punch = Math.Round(Math.Round(Convert.ToDouble(textBox1.Text) / kvant) * kvant, 2);
                double piercing = Math.Round(Math.Round(Convert.ToDouble(textBox2.Text) / kvant) * kvant, 2);
                double slash = Math.Round(Math.Round(Convert.ToDouble(textBox3.Text) / kvant) * kvant, 2);
                double punch1 = Math.Round(punch * 0.75, 3);
                double slash1 = slash * 1.25;
                double piercing2 = piercing * 1.5;
                double slash2 = slash1 * 0.85;
                double punch3 = punch1 *  0.75 * armor;
                double piercing3 = piercing2 * 0.5 * armor;
                double slash3 = slash2 * 0.85 * armor;
                double sum = Math.Round(punch3 + piercing3 + slash3);
                textBox1.Text = punch3.ToString();
                textBox2.Text = piercing3.ToString();
                textBox3.Text = slash3.ToString();
                textBox5.Text = sum.ToString();
                textBox4.Text = armor.ToString();
            }

            
        }
    }
}
