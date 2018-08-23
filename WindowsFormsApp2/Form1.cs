using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        static bool GameLock = false;
        static int Side = 1;
        static int[] Board = {  0, 0, 0,
                                0, 0, 0,
                                0, 0, 0 };
        public void IO(int sq)
        {
            Board[sq] = Side;
            if (WinCheck())
            {
                GameLock = true;
                if (Side == 1)
                    WinDrawText.Text = "X wins";
                else
                    WinDrawText.Text = "O wins";
            }
            else if (DrawCheck())
            {
                WinDrawText.Text = "Oh no, a draw D: !!!";
            }
            if (Side == 1)
            {
                Side = 2;
            }
            else
            {
                Side = 1;
            }
        }

        static bool WinCheck()
        {
            if (Board[0] == Side)
            {
                if (Board[1] == Side && Board[2] == Side)
                    return true;
                if (Board[3] == Side && Board[6] == Side)
                    return true;
            }
            if (Board[8] == Side)
            {
                if (Board[7] == Side && Board[6] == Side)
                    return true;
                if (Board[5] == Side && Board[2] == Side)
                    return true;
            }
            if (Board[4] == Side)
            {
                if (Board[3] == Side && Board[5] == Side)
                    return true;
                if (Board[1] == Side && Board[7] == Side)
                    return true;
                if (Board[0] == Side && Board[8] == Side)
                    return true;
                if (Board[2] == Side && Board[6] == Side)
                    return true;
            }

            return false;
        }

        static bool DrawCheck()
        {
            for (int i = 0; i < 9; i++)
            {
                if (Board[i] == 0)
                    return false;
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (button0.Text == "-" && GameLock == false)
            {
                if (Side == 1)
                {
                    button0.Text = "X";
                    IO(0);
                }
                else
                {
                    IO(0);
                    button0.Text = "O";
                }
            } 
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "-" && GameLock == false)
            {
                if (Side == 1)
                {
                    button1.Text = "X";
                    IO(1);
                }
                else
                {
                    IO(1);
                    button1.Text = "O";
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "-" && GameLock == false)
            {
                if (Side == 1)
                {
                    button2.Text = "X";
                    IO(2);
                }
                else
                {
                    IO(2);
                    button2.Text = "O";
                }
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (button3.Text == "-" && GameLock == false)
            {
                if (Side == 1)
                {
                    button3.Text = "X";
                    IO(3);
                }
                else
                {
                    IO(3);
                    button3.Text = "O";
                }
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (button4.Text == "-" && GameLock == false)
            {
                if (Side == 1)
                {
                    button4.Text = "X";
                    IO(4);
                }
                else
                {
                    IO(4);
                    button4.Text = "O";
                }
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (button5.Text == "-" && GameLock == false)
            {
                if (Side == 1)
                {
                    button5.Text = "X";
                    IO(5);
                }
                else
                {
                    IO(5);
                    button5.Text = "O";
                }
            }
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            if (button6.Text == "-" && GameLock == false)
            {
                if (Side == 1)
                {
                    button6.Text = "X";
                    IO(6);
                }
                else
                {
                    IO(6);
                    button6.Text = "O";
                }
            }
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            if (button7.Text == "-" && GameLock == false)
            {
                if (Side == 1)
                {
                    button7.Text = "X";
                    IO(7);
                }
                else
                {
                    IO(7);
                    button7.Text = "O";
                }
            }
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            if (button8.Text == "-" && GameLock == false)
            {
                if (Side == 1)
                {
                    button8.Text = "X";
                    IO(8);                }
                else
                {
                    IO(8);
                    button8.Text = "O";
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
                Board[i] = 0;
            button0.Text = "-";
            button1.Text = "-";
            button2.Text = "-";
            button3.Text = "-";
            button4.Text = "-";
            button5.Text = "-";
            button6.Text = "-";
            button7.Text = "-";
            button8.Text = "-";
            Side = 1;
            WinDrawText.Text = "";
            GameLock = false;
        }
    }
}
