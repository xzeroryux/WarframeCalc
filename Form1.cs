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

        double kvant, carmor, armor, baselvl, currentlvl, MultiplierArmor, finarmor;

        double punch, piercing, slash, sum,
               punch1, piercing1, slash1,
               punch2, piercing2, slash2,
               punch3, piercing3, slash3;
        double tt, ss;
        private void button3_Click(object sender, EventArgs e)
        {
            baselvl = Convert.ToInt32(textBox7.Text);
            currentlvl = Convert.ToInt32(textBox8.Text);
            CalcArmor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            kvant = Math.Round(Convert.ToDouble(textBox4.Text) / N , 2);

            baselvl = Convert.ToDouble(textBox7.Text);
            currentlvl = Convert.ToDouble(textBox8.Text);

            CalcArmor();

            punch =    Math.Round(Math.Round(Convert.ToDouble(textBox1.Text) / kvant) * kvant, 2);
            piercing = Math.Round(Math.Round(Convert.ToDouble(textBox2.Text) / kvant) * kvant, 2);
            slash =    Math.Round(Math.Round(Convert.ToDouble(textBox3.Text) / kvant) * kvant, 2);

            if (Infested.Checked == true)
            {
                InfestedDamage();
            }
            else if (Grineer.Checked == true)
            {
                GrineerDamage();
            }
            else if (Corpus.Checked == true)
            {
                CorpusDamage();
            }
            else if (Orokin.Checked == true)
            {
                OrokinDamage();
            }


        }

        void CalcArmor()
        {
            carmor = Convert.ToDouble(textBox6.Text);
            //чистая броня

            MultiplierArmor = ArmorF1(currentlvl, baselvl) * (1 - S1(currentlvl,baselvl)) + ArmorF2(currentlvl,baselvl) * S1(currentlvl, baselvl);
            finarmor = Math.Round(carmor * MultiplierArmor); 
            //Финальная броня

            armor = finarmor / (finarmor + 300);
            //сопротивление брони

            label9.Text = $"Итоговая броня: {Math.Round(finarmor, 2)}";
            ArmorResistance_Text.Text = $"Сопротивление брони: {Math.Round(armor * 100, 2)}%";
            label11.Text = $" Множитель брони: {Math.Round(MultiplierArmor, 2)}";

        }

        double T(double x, double y)
        {
            tt = (x - y - 70) / 10;
            return tt;
        }

        double S1(double x, double y)
        {
            if (x - y < 70)
            {
                ss = 0;
            }
            else if (70 <= x - y && x - y <= 80)
            {
                ss = 3 * Math.Pow(T(x, y),2) - 2 * Math.Pow(T(x, y), 3);
            }
            else if (x - y > 80)
            {
                ss = 1;
            }
            return ss;
        }

        double ArmorF2(double x, double y)
        {
            MultiplierArmor = 1 + (0.4 * Math.Pow((x - y), 0.75));
            //Множитель брони до 70 лвл

            return MultiplierArmor;
        }
        double ArmorF1(double x, double y)
        {
            MultiplierArmor = 1 + (0.005 * Math.Pow((x - y), 1.75));
            //Множитель брони от 70 до 79 лвл

            return MultiplierArmor;
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

            double piercingarmor = Math.Round((finarmor * 0.5)/((finarmor * 0.5)+300),3);

            punch1 = Math.Round(punch * 0.75, 3);
            slash1 = slash * 1.25;

            piercing2 = piercing * 1.5;
            slash2 = slash1 * 0.85;

            punch3 = Math.Round(punch1 * (1 - armor),2);
            piercing3 = Math.Round(piercing2 * 1.5 * (1 - piercingarmor),2);
            slash3 = Math.Round(slash2 * (1 - armor),2);

            sum = Math.Round(punch3 + piercing3 + slash3);



            textBox1.Text = punch3.ToString();
            textBox2.Text = piercing3.ToString();
            textBox3.Text = slash3.ToString();
            textBox4.Text = sum.ToString();

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
