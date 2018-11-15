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
    public partial class Game : Form
    {
        public static bool GameLock = false;
        public static int side = 1;
        public static int[] board = {  -1, -1, -1,
								-1, -1, -1,
                                -1, -1, -1 };

        public void IO(int sq)
        {
            board[sq] = side;
            if (Result.WinCheck())
            {
                GameLock = true;
                if (side == 1)
                    WinDrawText.Text = "X wins";
                else
                    WinDrawText.Text = "O wins";
            }
            else if (Result.DrawCheck())
            {
                WinDrawText.Text = "Oh no, a draw D: !!!";
            }
			side ^= 1;
        }

        public Game()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (button0.Text == "-" && GameLock == false)
            {
                if (side == 1)
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "-" && GameLock == false)
            {
                if (side == 1)
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "-" && GameLock == false)
            {
                if (side == 1)
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
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "-" && GameLock == false)
            {
                if (side == 1)
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
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "-" && GameLock == false)
            {
                if (side == 1)
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
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "-" && GameLock == false)
            {
                if (side == 1)
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
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "-" && GameLock == false)
            {
                if (side == 1)
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
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "-" && GameLock == false)
            {
                if (side == 1)
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
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "-" && GameLock == false)
            {
                if (side == 1)
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
                board[i] = -1;

            button0.Text = "-";
            button1.Text = "-";
            button2.Text = "-";
            button3.Text = "-";
            button4.Text = "-";
            button5.Text = "-";
            button6.Text = "-";
            button7.Text = "-";
            button8.Text = "-";
            side = 1;
            WinDrawText.Text = "";
            GameLock = false;
        }
    }
}
