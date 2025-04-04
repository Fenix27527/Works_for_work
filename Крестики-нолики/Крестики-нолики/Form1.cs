using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_нолики
{
    public partial class Form1 : Form
    {
        int a = 0;
        bool but11 = false, but12 = false;
        bool pk1_1 = false, pk1_2 = false, pk1_3 = false, pk1_4 = false, pk1_5 = false;
        bool pk2_1 = false, pk2_2 = false, pk2_3 = false, pk2_4 = false;
        String win1 = "Победил игрок 1";
        String win2 = "Победил игрок 2";
        String winPK = "Победил компьютер";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Крестики-нолики";
            label1.Text = "Ходит игрок 1";
            button10.Text = "Restart";
            button11.Text = "Компьютер первый";
            button12.Text = "Компьютер второй";
            button1.Text = " "; button2.Text = " "; button3.Text = " ";
            button4.Text = " "; button5.Text = " "; button6.Text = " ";
            button7.Text = " "; button8.Text = " "; button9.Text = " ";
            this.button1.Click += new System.EventHandler(this.ИГРА1);
            this.button2.Click += new System.EventHandler(this.ИГРА2);
            this.button3.Click += new System.EventHandler(this.ИГРА3);
            this.button4.Click += new System.EventHandler(this.ИГРА4);
            this.button5.Click += new System.EventHandler(this.ИГРА5);
            this.button6.Click += new System.EventHandler(this.ИГРА6);
            this.button7.Click += new System.EventHandler(this.ИГРА7);
            this.button8.Click += new System.EventHandler(this.ИГРА8);
            this.button9.Click += new System.EventHandler(this.ИГРА9);
            this.button10.Click += new System.EventHandler(this.CLEAR);

            this.button1.Click += new System.EventHandler(this.WIN);
            this.button2.Click += new System.EventHandler(this.WIN);
            this.button3.Click += new System.EventHandler(this.WIN);
            this.button4.Click += new System.EventHandler(this.WIN);
            this.button5.Click += new System.EventHandler(this.WIN);
            this.button6.Click += new System.EventHandler(this.WIN);
            this.button7.Click += new System.EventHandler(this.WIN);
            this.button8.Click += new System.EventHandler(this.WIN);
            this.button9.Click += new System.EventHandler(this.WIN);
            
            this.button11.Click += new System.EventHandler(this.PK1_1);
            this.button1.Click += new System.EventHandler(this.PK1_2);
            this.button2.Click += new System.EventHandler(this.PK1_2);
            this.button3.Click += new System.EventHandler(this.PK1_2);
            this.button4.Click += new System.EventHandler(this.PK1_2);
            this.button6.Click += new System.EventHandler(this.PK1_2);
            this.button7.Click += new System.EventHandler(this.PK1_2);
            this.button8.Click += new System.EventHandler(this.PK1_2);
            this.button9.Click += new System.EventHandler(this.PK1_2);
           
            this.button1.Click += new System.EventHandler(this.PK1_3);
            this.button2.Click += new System.EventHandler(this.PK1_3);
            this.button3.Click += new System.EventHandler(this.PK1_3);
            this.button4.Click += new System.EventHandler(this.PK1_3);
            this.button6.Click += new System.EventHandler(this.PK1_3);
            this.button7.Click += new System.EventHandler(this.PK1_3);
            this.button8.Click += new System.EventHandler(this.PK1_3);
            this.button9.Click += new System.EventHandler(this.PK1_3);
            
            this.button1.Click += new System.EventHandler(this.PK1_4);
            this.button2.Click += new System.EventHandler(this.PK1_4);
            this.button3.Click += new System.EventHandler(this.PK1_4);
            this.button4.Click += new System.EventHandler(this.PK1_4);
            this.button6.Click += new System.EventHandler(this.PK1_4);
            this.button7.Click += new System.EventHandler(this.PK1_4);
            this.button8.Click += new System.EventHandler(this.PK1_4);
            this.button9.Click += new System.EventHandler(this.PK1_4);

            this.button1.Click += new System.EventHandler(this.PK1_5);
            this.button2.Click += new System.EventHandler(this.PK1_5);
            this.button3.Click += new System.EventHandler(this.PK1_5);
            this.button4.Click += new System.EventHandler(this.PK1_5);
            this.button6.Click += new System.EventHandler(this.PK1_3);
            this.button7.Click += new System.EventHandler(this.PK1_5);
            this.button8.Click += new System.EventHandler(this.PK1_5);
            this.button9.Click += new System.EventHandler(this.PK1_5);
            


            //this.button12.Click += new System.EventHandler(this.PK2_1);
        }
        private void ИГРА1(object sender, EventArgs e)
        {
            if (a == 0 & button1.Text == " ")
            {
                button1.Text = "x";
                label1.Text = "Ходит игрок 2";
                a = 1;
            }
            else if(a == 1 & button1.Text == " ")
            {
                button1.Text = "o";
                label1.Text = "Ходит игрок 1";
                a = 0;
            }
        }
        private void ИГРА2(object sender, EventArgs e)
        {
            if (a == 0 & button2.Text == " ")
            {
                button2.Text = "x";
                label1.Text = "Ходит игрок 2";
                a = 1;
            }
            else if (a == 1 & button2.Text == " ")
            {
                button2.Text = "o";
                label1.Text = "Ходит игрок 1";
                a = 0;
            }
        }
        private void ИГРА3(object sender, EventArgs e)
        {
            if (a == 0 & button3.Text == " ")
            {
                button3.Text = "x";
                label1.Text = "Ходит игрок 2";
                a = 1;
            }
            else if (a == 1 & button3.Text == " ")
            {
                button3.Text = "o";
                label1.Text = "Ходит игрок 1";
                a = 0;
            }
        }
        private void ИГРА4(object sender, EventArgs e)
        {
            if (a == 0 & button4.Text == " ")
            {
                button4.Text = "x";
                label1.Text = "Ходит игрок 2";
                a = 1;
            }
            else if (a == 1 & button4.Text == " ")
            {
                button4.Text = "o";
                label1.Text = "Ходит игрок 1";
                a = 0;
            }
        }
        private void ИГРА5(object sender, EventArgs e)
        {
            if (a == 0 & button5.Text == " ")
            {
                button5.Text = "x";
                label1.Text = "Ходит игрок 2";
                a = 1;
            }
            else if (a == 1 & button5.Text == " ")
            {
                button5.Text = "o";
                label1.Text = "Ходит игрок 1";
                a = 0;
            }
        }
        private void ИГРА6(object sender, EventArgs e)
        {
            if (a == 0 & button6.Text == " ")
            {
                button6.Text = "x";
                label1.Text = "Ходит игрок 2";
                a = 1;
            }
            else if (a == 1 & button6.Text == " ")
            {
                button6.Text = "o";
                label1.Text = "Ходит игрок 1";
                a = 0;
            }
        }
        private void ИГРА7(object sender, EventArgs e)
        {
            if (a == 0 & button7.Text == " ")
            {
                button7.Text = "x";
                label1.Text = "Ходит игрок 2";
                a = 1;
            }
            else if (a == 1 & button7.Text == " ")
            {
                button7.Text = "o";
                label1.Text = "Ходит игрок 1";
                a = 0;
            }
        }
        private void ИГРА8(object sender, EventArgs e)
        {
            if (a == 0 & button8.Text == " ")
            {
                button8.Text = "x";
                label1.Text = "Ходит игрок 2";
                a = 1;
            }
            else if (a == 1 & button8.Text == " ")
            {
                button8.Text = "o";
                label1.Text = "Ходит игрок 1";
                a = 0;
            }
        }
        private void ИГРА9(object sender, EventArgs e)
        {
            if (a == 0 & button9.Text == " ")
            {
                button9.Text = "x";
                label1.Text = "Ходит игрок 2";
                a = 1;
            }
            else if (a == 1 & button9.Text == " ")
            {
                button9.Text = "o";
                label1.Text = "Ходит игрок 1";
                a = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке :)");
        }

        private void CLEAR(object sender, EventArgs e)
        {
            label1.Text = "Ходит игрок 1";
            button1.Text = " "; button2.Text = " "; button3.Text = " ";
            button4.Text = " "; button5.Text = " "; button6.Text = " ";
            button7.Text = " "; button8.Text = " "; button9.Text = " ";
            a = 0;
            but11 = false;
            but12 = false;
            pk1_1 = false; pk1_2 = false; pk1_3 = false; pk1_4 = false; pk1_5 = false;
            pk2_1 = false; pk2_2 = false; pk2_3 = false; pk2_4 = false;
        }
        private void WIN(object sender, EventArgs e)
        {
            if (button1.Text == "x" & button2.Text == "x" & button3.Text == "x") MessageBox.Show(String.Format(win1));
            if (button4.Text == "x" & button5.Text == "x" & button6.Text == "x") MessageBox.Show(String.Format(win1));
            if (button7.Text == "x" & button8.Text == "x" & button9.Text == "x") MessageBox.Show(String.Format(win1));
            if (button1.Text == "x" & button4.Text == "x" & button7.Text == "x") MessageBox.Show(String.Format(win1));
            if (button2.Text == "x" & button5.Text == "x" & button8.Text == "x") MessageBox.Show(String.Format(win1));
            if (button3.Text == "x" & button6.Text == "x" & button9.Text == "x") MessageBox.Show(String.Format(win1));
            if (button1.Text == "x" & button5.Text == "x" & button9.Text == "x") MessageBox.Show(String.Format(win1));
            if (button3.Text == "x" & button5.Text == "x" & button7.Text == "x") MessageBox.Show(String.Format(win1));

            if (button1.Text == "o" & button2.Text == "o" & button3.Text == "o") MessageBox.Show(String.Format(win2));
            if (button4.Text == "o" & button5.Text == "o" & button6.Text == "o") MessageBox.Show(String.Format(win2));
            if (button7.Text == "o" & button8.Text == "o" & button9.Text == "o") MessageBox.Show(String.Format(win2));
            if (button1.Text == "o" & button4.Text == "o" & button7.Text == "o") MessageBox.Show(String.Format(win2));
            if (button2.Text == "o" & button5.Text == "o" & button8.Text == "o") MessageBox.Show(String.Format(win2));
            if (button3.Text == "o" & button6.Text == "o" & button9.Text == "o") MessageBox.Show(String.Format(win2));
            if (button1.Text == "o" & button5.Text == "o" & button9.Text == "o") MessageBox.Show(String.Format(win2));
            if (button3.Text == "o" & button5.Text == "o" & button7.Text == "o") MessageBox.Show(String.Format(win2));
        }

        
        private void PK1_1(object sender, EventArgs e)
        {
                if (button5.Text == " " & a == 0)
                {
                    button5.Text = "x";
                    a = 1;
                    label1.Text = "Ходит игрок 2";
                    but11 = true;
                    pk1_1 = true;
                }
        }
        private void PK1_2(object sender, EventArgs e)
        {
            //углы
            if (a == 0 & button1.Text == "o" & but11 == true & pk1_1 == true & pk1_2 == false)
            {
                button3.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_2 = true;
            }
            if (a == 0 & button3.Text == "o" & but11 == true & pk1_1 == true & pk1_2 == false)
            {
                button1.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_2 = true;
            }
            if (a == 0 & button7.Text == "o" & but11 == true & pk1_1 == true & pk1_2 == false)
            {
                button9.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_2 = true;
            }
            if (a == 0 & button9.Text == "o" & but11 == true & pk1_1 == true & pk1_2 == false)
            {
                button7.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_2 = true;
            }
            //не углы
            if (a == 0 & button2.Text == "o" & but11 == true & pk1_1 == true & pk1_2 == false)
            {
                button3.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_2 = true;
            }
            if (a == 0 & button4.Text == "o" & but11 == true & pk1_1 == true & pk1_2 == false)
            {
                button1.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_2 = true;
            }
            if (a == 0 & button6.Text == "o" & but11 == true & pk1_1 == true & pk1_2 == false)
            {
                button3.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_2 = true;
            }
            if (a == 0 & button8.Text == "o" & but11 == true & pk1_1 == true & pk1_2 == false)
            {
                button7.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_2 = true;
            }
            
        }
        private void PK1_3(object sender, EventArgs e)
        {
            if (a == 0 & button1.Text == "o" & button7.Text == "o" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button4.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
            }
            else if (a == 0 & button1.Text == "o" & button7.Text == " " & button3.Text == "x" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button7.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button4.Text == "o" & button9.Text == "o" & button7.Text != "x" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button2.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
            }
            else if (a == 0 & button4.Text == "o" & button9.Text == " " & button1.Text == "x" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button9.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button7.Text == "o" & button1.Text == "o" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button4.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
            }
            else if (a == 0 & button7.Text == "o" & button1.Text == " " & button9.Text == "x" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button1.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
                MessageBox.Show(String.Format(winPK));
            }

            if (a == 0 & button2.Text == "o" & button7.Text == "o" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button6.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
            }
            else if (a == 0 & button2.Text == "o" & button7.Text == " " & button3.Text == "x" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button7.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button3.Text == "o" & button9.Text == "o" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button6.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
            }
            else if (a == 0 & button3.Text == "o" & button9.Text == " " & button1.Text == "x" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button9.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button6.Text == "o" & button7.Text == "o" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button2.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
            }
            else if (a == 0 & button6.Text == "o" & button7.Text == " " & button3.Text == "x" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button7.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button8.Text == "o" & button3.Text == "o" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button4.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
            }
            else if (a == 0 & button8.Text == "o" & button3.Text == " " & button7.Text == "x" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button3.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button9.Text == "o" & button7.Text == "o" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button4.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
            }
            else if (a == 0 & button9.Text == "o" & button3.Text == " " & button7.Text == "x" & but11 == true & pk1_2 == true & pk1_3 == false)
            {
                button3.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_3 = true;
                MessageBox.Show(String.Format(winPK));
            }
        }
        private void PK1_4(object sender, EventArgs e)
        {
            //не углы
            if (a == 0 & button1.Text == "o" & button7.Text == "o" & button6.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button8.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button1.Text == "o" & button7.Text == "o" & button6.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button6.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button4.Text == "o" & button9.Text == "o" & button3.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button8.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button4.Text == "o" & button9.Text == "o" & button3.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button3.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button4.Text == "o" & button9.Text == "o" & button8.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button3.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button4.Text == "o" & button9.Text == "o" & button8.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button8.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button7.Text == "o" & button1.Text == "o" & button6.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button2.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button7.Text == "o" & button1.Text == "o" & button6.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button6.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button2.Text == "o" & button7.Text == "o" & button4.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button9.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button2.Text == "o" & button7.Text == "o" & button4.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button4.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button2.Text == "o" & button7.Text == "o" & button9.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button4.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button2.Text == "o" & button7.Text == "o" & button9.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button9.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button3.Text == "o" & button9.Text == "o" & button4.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button8.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button3.Text == "o" & button9.Text == "o" & button4.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button4.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button6.Text == "o" & button7.Text == "o" & button1.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button8.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button6.Text == "o" & button7.Text == "o" & button1.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button1.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button8.Text == "o" & button7.Text == "o" & button6.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button1.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button8.Text == "o" & button7.Text == "o" & button6.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button6.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button1.Text == "o" & button8.Text == "o" & button3.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button6.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button1.Text == "o" & button8.Text == "o" & button3.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button3.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button8.Text == "o" & button3.Text == "o" & button6.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button1.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button8.Text == "o" & button3.Text == "o" & button6.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button6.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button9.Text == "o" & button3.Text == "o" & button1.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button6.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button9.Text == "o" & button3.Text == "o" & button1.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button1.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button9.Text == "o" & button3.Text == "o" & button6.Text == "o" & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button1.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
            }
            else if (a == 0 & button9.Text == "o" & button3.Text == "o" & button6.Text == " " & but11 == true & pk1_3 == true & pk1_4 == false)
            {
                button6.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_4 = true;
                MessageBox.Show(String.Format(winPK));
            }
        }
        private void PK1_5(object sender, EventArgs e)
        {
            //ничья
            if (a == 0 & button1.Text == "o" & button7.Text == "o" & button6.Text == "o" & button2.Text == "o" & but11 == true & pk1_4 == true & pk1_5 == false)
            {
                button9.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_5 = true;
            }
            else if (a == 0 & button2.Text == " " & button8.Text == "x"  & but11 == true & pk1_4 == true & pk1_5 == false)
            {
                button2.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_5 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button1.Text == "o" & button7.Text == "o" & button6.Text == "o" & button8.Text == "o" & but11 == true & pk1_4 == true & pk1_5 == false)
            {
                button3.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_5 = true;
            }
            else if (a == 0 & button2.Text == " " & button8.Text == "x" & but11 == true & pk1_4 == true & pk1_5 == false)
            {
                button2.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_5 = true;
                MessageBox.Show(String.Format(winPK));
            }
            if (a == 0 & button3.Text == "o" & button9.Text == "o" & button4.Text == "o" & button2.Text == "o" & but11 == true & pk1_4 == true & pk1_5 == false)
            {
                button7.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_5 = true;
            }
            if (a == 0 & button2.Text == " " & button8.Text == "x" & but11 == true & pk1_4 == true & pk1_5 == false)
            {
                button2.Text = "x";
                a = 1;
                label1.Text = "Ходит игрок 2";
                pk1_5 = true;
                MessageBox.Show(String.Format(winPK));
            }
        }


        private void PK2_1(object sender, EventArgs e)
        {
            pk2_1 = true;
        }
        
    }
}
