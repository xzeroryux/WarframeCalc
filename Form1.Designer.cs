﻿namespace WarframeCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Infested = new System.Windows.Forms.RadioButton();
            this.Grineer = new System.Windows.Forms.RadioButton();
            this.Corpus = new System.Windows.Forms.RadioButton();
            this.Orokin = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Weapons = new System.Windows.Forms.Label();
            this.Lex_Prime = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ArmorResistance_Text = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.MaximumSize = new System.Drawing.Size(110, 20);
            this.label1.MinimumSize = new System.Drawing.Size(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удар:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.MaximumSize = new System.Drawing.Size(110, 20);
            this.label2.MinimumSize = new System.Drawing.Size(110, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пронзание:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 150);
            this.label3.MaximumSize = new System.Drawing.Size(110, 20);
            this.label3.MinimumSize = new System.Drawing.Size(110, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Разрез:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(19, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Калькулировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 200);
            this.label4.MaximumSize = new System.Drawing.Size(110, 20);
            this.label4.MinimumSize = new System.Drawing.Size(110, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Всего:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(161, 50);
            this.textBox1.MaximumSize = new System.Drawing.Size(160, 27);
            this.textBox1.MinimumSize = new System.Drawing.Size(160, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(161, 100);
            this.textBox2.MaximumSize = new System.Drawing.Size(160, 27);
            this.textBox2.MinimumSize = new System.Drawing.Size(160, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 27);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(161, 150);
            this.textBox3.MaximumSize = new System.Drawing.Size(160, 27);
            this.textBox3.MinimumSize = new System.Drawing.Size(160, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 27);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0";
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(161, 200);
            this.textBox4.MaximumSize = new System.Drawing.Size(160, 27);
            this.textBox4.MinimumSize = new System.Drawing.Size(160, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 27);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "0";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 250);
            this.label5.MaximumSize = new System.Drawing.Size(145, 50);
            this.label5.MinimumSize = new System.Drawing.Size(145, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "Урон после квантования:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(161, 250);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(160, 50);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(432, 50);
            this.label6.MaximumSize = new System.Drawing.Size(110, 20);
            this.label6.MinimumSize = new System.Drawing.Size(110, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Фракция:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Infested
            // 
            this.Infested.Checked = true;
            this.Infested.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Infested.Location = new System.Drawing.Point(548, 50);
            this.Infested.MaximumSize = new System.Drawing.Size(170, 25);
            this.Infested.MinimumSize = new System.Drawing.Size(170, 25);
            this.Infested.Name = "Infested";
            this.Infested.Size = new System.Drawing.Size(170, 25);
            this.Infested.TabIndex = 12;
            this.Infested.TabStop = true;
            this.Infested.Text = "Зараженные (Бегун)";
            this.Infested.UseVisualStyleBackColor = true;
            // 
            // Grineer
            // 
            this.Grineer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Grineer.Location = new System.Drawing.Point(548, 80);
            this.Grineer.MaximumSize = new System.Drawing.Size(170, 25);
            this.Grineer.MinimumSize = new System.Drawing.Size(170, 25);
            this.Grineer.Name = "Grineer";
            this.Grineer.Size = new System.Drawing.Size(170, 25);
            this.Grineer.TabIndex = 13;
            this.Grineer.Text = "Гринир (Тяжелая пулеметчиr Кувы)";
            this.Grineer.UseVisualStyleBackColor = true;
            // 
            // Corpus
            // 
            this.Corpus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Corpus.Location = new System.Drawing.Point(548, 110);
            this.Corpus.MaximumSize = new System.Drawing.Size(170, 25);
            this.Corpus.MinimumSize = new System.Drawing.Size(170, 25);
            this.Corpus.Name = "Corpus";
            this.Corpus.Size = new System.Drawing.Size(170, 25);
            this.Corpus.TabIndex = 14;
            this.Corpus.Text = "Корпус";
            this.Corpus.UseVisualStyleBackColor = true;
            // 
            // Orokin
            // 
            this.Orokin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orokin.Location = new System.Drawing.Point(548, 140);
            this.Orokin.MaximumSize = new System.Drawing.Size(170, 25);
            this.Orokin.MinimumSize = new System.Drawing.Size(170, 25);
            this.Orokin.Name = "Orokin";
            this.Orokin.Size = new System.Drawing.Size(170, 25);
            this.Orokin.TabIndex = 15;
            this.Orokin.Text = "Порабощенные";
            this.Orokin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(432, 186);
            this.label7.MaximumSize = new System.Drawing.Size(0, 20);
            this.label7.MinimumSize = new System.Drawing.Size(110, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Базовая броня:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(652, 183);
            this.textBox6.MaximumSize = new System.Drawing.Size(160, 27);
            this.textBox6.MinimumSize = new System.Drawing.Size(160, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(160, 27);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "500";
            // 
            // Weapons
            // 
            this.Weapons.AutoSize = true;
            this.Weapons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weapons.Location = new System.Drawing.Point(905, 45);
            this.Weapons.Name = "Weapons";
            this.Weapons.Size = new System.Drawing.Size(77, 20);
            this.Weapons.TabIndex = 18;
            this.Weapons.Text = "Оружие:";
            // 
            // Lex_Prime
            // 
            this.Lex_Prime.AutoSize = true;
            this.Lex_Prime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lex_Prime.Location = new System.Drawing.Point(905, 82);
            this.Lex_Prime.Name = "Lex_Prime";
            this.Lex_Prime.Size = new System.Drawing.Size(119, 20);
            this.Lex_Prime.TabIndex = 19;
            this.Lex_Prime.Text = "Лекс Прайм";
            this.Lex_Prime.Click += new System.EventHandler(this.label9_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(19, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ArmorResistance_Text
            // 
            this.ArmorResistance_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArmorResistance_Text.Location = new System.Drawing.Point(432, 328);
            this.ArmorResistance_Text.Name = "ArmorResistance_Text";
            this.ArmorResistance_Text.Size = new System.Drawing.Size(360, 20);
            this.ArmorResistance_Text.TabIndex = 21;
            this.ArmorResistance_Text.Text = "Сопротивление брони:";
            this.ArmorResistance_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(432, 223);
            this.label8.MaximumSize = new System.Drawing.Size(0, 20);
            this.label8.MinimumSize = new System.Drawing.Size(110, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Уровень врага:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(432, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Итоговая броня:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(652, 216);
            this.textBox7.MaximumSize = new System.Drawing.Size(160, 27);
            this.textBox7.MinimumSize = new System.Drawing.Size(160, 27);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(160, 27);
            this.textBox7.TabIndex = 24;
            this.textBox7.Text = "20";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(652, 250);
            this.textBox8.MaximumSize = new System.Drawing.Size(160, 27);
            this.textBox8.MinimumSize = new System.Drawing.Size(160, 27);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(160, 27);
            this.textBox8.TabIndex = 25;
            this.textBox8.Text = "60";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(432, 257);
            this.label10.MaximumSize = new System.Drawing.Size(0, 20);
            this.label10.MinimumSize = new System.Drawing.Size(110, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Текущий уровень врага:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ArmorResistance_Text);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Lex_Prime);
            this.Controls.Add(this.Weapons);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Orokin);
            this.Controls.Add(this.Corpus);
            this.Controls.Add(this.Grineer);
            this.Controls.Add(this.Infested);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор урона";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Infested;
        private System.Windows.Forms.RadioButton Grineer;
        private System.Windows.Forms.RadioButton Corpus;
        private System.Windows.Forms.RadioButton Orokin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Weapons;
        private System.Windows.Forms.Label Lex_Prime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ArmorResistance_Text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
    }
}

