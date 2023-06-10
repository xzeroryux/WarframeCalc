using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarframeCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        double N = 16; //Константа всегда равная 16

        double kvant, carmor, armor;

        double punch, piercing, slash, sum,
               punch1, piercing1, slash1,
               punch2, piercing2, slash2,
               punch3, piercing3, slash3;

        double summ; 

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty)
            {

                kvant = Math.Round(Convert.ToDouble(textBox4.Text) / N , 2);

                carmor = Convert.ToDouble(textBox6.Text);//чистая броня
                armor = carmor / (carmor + 300);//сопротивление брони
                ArmorResistance_Text.Text = $"Сопротивление брони: {Math.Round(armor * 100,3)}%";

                punch =    Math.Round(Math.Round(Convert.ToDouble(textBox1.Text) / kvant) * kvant, 2);
                piercing = Math.Round(Math.Round(Convert.ToDouble(textBox2.Text) / kvant) * kvant, 2);
                slash =    Math.Round(Math.Round(Convert.ToDouble(textBox3.Text) / kvant) * kvant, 2);

                if (Infested.Checked == true)
                {
                    InfestedDamage();
                }
                if (Grineer.Checked == true)
                {
                    GrineerDamage();
                }
                if (Corpus.Checked == true)
                {
                    CorpusDamage();
                }
                if (Orokin.Checked == true)
                {
                    OrokinDamage();
                }

            }
            else
            {
                MessageBox.Show("Введите значения","Ошибка");
            }

        }

        void InfestedDamage()
        {
            slash = slash * 1.25;
            sum = Math.Round(punch + piercing + slash);
            textBox1.Text = punch.ToString();
            textBox2.Text = piercing.ToString();
            textBox3.Text = slash.ToString();
            textBox5.Text = sum.ToString();
        }
        void GrineerDamage()
        {
            punch1 = Math.Round(punch * 0.75, 3);
            slash1 = slash * 1.25;
            piercing2 = piercing * 1.5;
            slash2 = slash1 * 0.85;
            punch3 = punch1 * 0.75 * armor;
            piercing3 = piercing2 * 0.5 * armor;
            slash3 = slash2 * 0.85 * armor;
            sum = Math.Round(punch3 + piercing3 + slash3);
            textBox1.Text = punch3.ToString();
            textBox2.Text = piercing3.ToString();
            textBox3.Text = slash3.ToString();
            textBox4.Text = armor.ToString();
            textBox5.Text = sum.ToString();
        }

        void CorpusDamage()
        {

        }

        void OrokinDamage()
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "18";
            textBox2.Text = "144";
            textBox3.Text = "18";
            textBox4.Text = "180";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "0";
            textBox5.Text = string.Empty;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "0";
            }
            textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text));

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.Text = "0";
            }
            textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text));
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                textBox3.Text = "0";
            }
            textBox4.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text));
        }
    }
}
