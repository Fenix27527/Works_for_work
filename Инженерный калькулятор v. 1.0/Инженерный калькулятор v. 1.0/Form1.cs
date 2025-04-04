using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Инженерный_калькулятор_v._1._0
{
    public partial class Form1 : Form
    {
        // Объявляем внешние переменные, видимые из всех процедур класса Form1:
        String Znak = String.Empty; // - знак арифметической операции:
                                    // Признак того, что пользователь вводит новое число:
        Boolean Начало_Ввода = true;
        // Первое и второе числа, вводимые пользователем:
        Double Число1, Число2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Калькулятор";
            button1.Text = "1"; button2.Text = "2"; button3.Text = "3";
            button4.Text = "4"; button5.Text = "5"; button6.Text = "6";
            button7.Text = "7"; button8.Text = "8"; button9.Text = "9";
            button10.Text = "0"; button11.Text = "="; button12.Text = "+";
            button13.Text = "-"; button14.Text = "*"; button15.Text = "/";
            button16.Text = "С"; button17.Text = ",";
            button18.Text = "n!"; button19.Text = "x^y"; button20.Text = "Sqrt(x)";
            button21.Text = "x % y"; 
            button22.Text = "log"; button23.Text = "log x(y)"; button24.Text = "lg";
            button25.Text = "sin"; button26.Text = "cos"; button27.Text = "tg";
            button28.Text = "arcsin"; button29.Text = "arccos"; button30.Text = "arctg";
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // Связываем все события "щелчок на кнопках-цифрах"
            // с обработчиком ЦИФРА:
            this.button1.Click += new System.EventHandler(this.ЦИФРА);
            this.button2.Click += new System.EventHandler(this.ЦИФРА);
            this.button3.Click += new System.EventHandler(this.ЦИФРА);
            this.button4.Click += new System.EventHandler(this.ЦИФРА);
            this.button5.Click += new System.EventHandler(this.ЦИФРА);
            this.button6.Click += new System.EventHandler(this.ЦИФРА);
            this.button7.Click += new System.EventHandler(this.ЦИФРА);
            this.button8.Click += new System.EventHandler(this.ЦИФРА);
            this.button9.Click += new System.EventHandler(this.ЦИФРА);
            this.button10.Click += new System.EventHandler(this.ЦИФРА);
            this.button12.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button13.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button14.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button15.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button11.Click += new System.EventHandler(this.РАВНО);
            this.button16.Click += new System.EventHandler(this.ОЧИСТИТЬ);
            this.button17.Click += new System.EventHandler(this.ЗАПЯТАЯ);
            this.button18.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button19.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button20.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button21.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button22.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button23.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button24.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button25.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button26.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button27.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button28.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button29.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button30.Click += new System.EventHandler(this.ОПЕРАЦИЯ);   
        }
        private void ЦИФРА(object sender, EventArgs e)
        {
            // Обработка события нажатия кнопки-цифры.
            // Получить текст, отображаемый на кнопке можно таким образом:
            Button Кнопка = (Button)sender;
            String Digit = Кнопка.Text;
            if (Начало_Ввода == true)
            { // Ввод первой цифры числа:
                textBox1.Text = Digit;
                Начало_Ввода = false; return;
            }
            // "Сцепливаем" полученные цифры в новое число:
            if (Начало_Ввода == false)
                textBox1.Text = textBox1.Text + Digit;
        }
        private void ОПЕРАЦИЯ(object sender, EventArgs e)
        {
            // Обработка события нажатия кнопки арифметической операции:
            Число1 = Double.Parse(textBox1.Text);
            // Получить текст, отображаемый на кнопке можно таким образом:
            Button Кнопка = (Button)sender;
            Znak = Кнопка.Text;
            Начало_Ввода = true; // - ожидаем ввод нового числа
        }
        private void РАВНО(object sender, EventArgs e)
        {
            // Обработка события нажатия клавиши "равно"
            double Результат = 0;
            Число2 = Double.Parse(textBox1.Text);
            if (Znak == "+") Результат = Число1 + Число2;
            if (Znak == "-") Результат = Число1 - Число2;
            if (Znak == "*") Результат = Число1 * Число2;
            if (Znak == "/") Результат = Число1 / Число2;
            if (Znak == "n!")
            {
                Результат = 1;
                for (int i = 1; i <= Число1; i++)
                {
                    double Rez = i;
                    Результат = Результат * Rez;
                }
            }
            if (Znak == "x^y") Результат = Math.Pow(Число1,Число2);
            if (Znak == "Sqrt(x)") Результат = Math.Sqrt(Число1);               
            if (Znak == "x % y") Результат = Число1 * Число2 / 100;    
            if (Znak == "log") Результат = Math.Log(Число1);
            if (Znak == "log x(y)") Результат = Math.Log(Число1,Число2);
            if (Znak == "lg") Результат = Math.Log10(Число1);
            if (Znak == "sin") Результат = Math.Sin(Число1);
            if (Znak == "cos") Результат = Math.Cos(Число1);
            if (Znak == "tg") Результат = Math.Tan(Число1);
            if (Znak == "arcsin") Результат = Math.Asin(Число1);
            if (Znak == "arccos") Результат = Math.Acos(Число1);
            if (Znak == "arctg") Результат = Math.Atan(Число1);
            Znak = null;
            // Отображаем результат в текстовом поле:
            textBox1.Text = Результат.ToString();
            Число1 = Результат; Начало_Ввода = true;
        }
        private void ОЧИСТИТЬ(object sender, EventArgs e)
        {
            // Обработка события нажатия клавиши "Очистить"
            textBox1.Text = "0"; Znak = null; Начало_Ввода = true;
        }
        private void ЗАПЯТАЯ(object sender, EventArgs e)
        {
            // Обработка события нажатия кнопки-цифры.
            // Получить текст, отображаемый на кнопке можно таким образом:
            Button Кнопка = (Button)sender;
            String Digit = Кнопка.Text;
            if (Начало_Ввода == true)
            { // Ввод первой цифры числа:
                textBox1.Text = "0,";
                Начало_Ввода = false; return;
            }
            // "Сцепливаем" полученные цифры в новое число:
            if (Начало_Ввода == false)
                textBox1.Text = textBox1.Text + Digit;
        }
        
    }
}
