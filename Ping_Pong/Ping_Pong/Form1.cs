using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        private int speed_left = 2;
        private int speed_top = 2;
        private bool Player_Left1;
        private bool Player_Right1;
        private bool Player_Left2;
        private bool Player_Right2;
        private int score_player1=0;
        private int score_player2=0;
        private int max_score = 10;
        private int speed_racket = 4;
        private void Default_stats()
        {
            int[] speed = new int[] { -2, 2 };
            Random rnd = new Random();
            this.speed_left = speed[rnd.Next(0, 2)];
            this.speed_top = speed[rnd.Next(0, 2)];
            Ball.Top = rnd.Next(250, 300);
            Ball.Left = rnd.Next(250, 400);
            Racket1.Left = 250;
            Racket2.Left = 250;
            Timer.Enabled = true;
            Space.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
            Timer.Enabled = true;
            Cursor.Hide();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Space.Left = (playground.Width / 2) - (Space.Width/2);
            Space.Top = (playground.Height / 2) - (Space.Height/2);
            Space.Visible = false;
            gmOver.Left = (playground.Width / 2) - (gmOver.Width / 2);
            gmOver.Top = (playground.Height / 2) - (gmOver.Height / 2);
            gmOver.Visible = false;
            //Ustawienie szybkości przesuwania się graczy
            if (Player_Right1 && Racket1.Left <= playground.Width - Racket1.Width)
                Racket1.Left += speed_racket;
            if (Player_Left1 && Racket1.Left >= 0)
                Racket1.Left -= speed_racket;
            if (Player_Right2 && Racket2.Left <= playground.Width - Racket1.Width)
                Racket2.Left += speed_racket;
            if (Player_Left2 && Racket2.Left >= 0)
                Racket2.Left -= speed_racket;
            Ball.Left += speed_left;
            Ball.Top += speed_top;
            if (Ball.Bounds.IntersectsWith(Racket1.Bounds))
            {
                speed_left += 1;
                speed_top += 1;
                speed_top = -speed_top;
            }
            if (Ball.Bounds.IntersectsWith(Racket2.Bounds))
            {
                speed_left -= 1;
                speed_top -= 1;
                speed_top = -speed_top;
            }
            if (Ball.Left <= playground.Left || Ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (Ball.Bottom <= playground.Top)
            {
                this.score_player2 += 1;
                this.label3.Text = score_player2.ToString();
                Timer.Enabled = false;
                Space.Visible = true;
            }
            if (Ball.Top >= playground.Bottom - 100)
            {
                this.score_player1 += 1;
                this.label2.Text = score_player1.ToString();
                Timer.Enabled = false;
                Space.Visible = true;
            }
            if (score_player1 == max_score)
            {
                Space.Visible = false;
                gmOver.Visible = true;
                this.gmOver.Text = "GAME OVER\nPlayer 1 Won!\nPress F1 to restart\nESC to exit";
            }
            if (score_player2 == max_score)
            {
                Space.Visible = false;
                gmOver.Visible = true;
                this.gmOver.Text = "GAME OVER\nPlayer 2 Won!\nPress F1 to restart\nESC to exit";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            //Ustawienie przycisku wyjścia z gry "ESC"
            if (e.KeyCode == Keys.Escape)
                this.Close();
            switch (e.KeyCode)
            {
                case Keys.A:
                    Player_Right2 = false;
                    Player_Left2 = true;
                    break;
                case Keys.Left:
                    Player_Right1 = false;
                    Player_Left1 = true;
                    break;
                case Keys.D:
                    Player_Left2 = false;
                    Player_Right2 = true;
                    break;
                case Keys.Right:
                    Player_Left1 = false;
                    Player_Right1 = true;
                    break;
            }
            if (e.KeyCode == Keys.Space && Timer.Enabled == false)
            {
                Default_stats();
            }
            if (e.KeyCode == Keys.F1 && Timer.Enabled == false && (score_player1 == max_score || score_player2 == max_score))
            {
                Default_stats();
                gmOver.Visible = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    Player_Left2 = false;
                    break;
                case Keys.Left:
                    Player_Left1 = false;
                    break;
                case Keys.D:
                    Player_Right2 = false;
                    break;
                case Keys.Right:
                    Player_Right1 = false;
                    break;
            }
        }
    }
}
