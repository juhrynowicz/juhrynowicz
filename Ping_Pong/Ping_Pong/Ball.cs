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
    public class Ball: Score
    {
        private int speed_left = 3;
        private int speed_top = 3;
        //private int RandoMin = 4;
        //private int RandoMax = 6;
        private PictureBox ball,racket1,racket2;
        public PictureBox ballPictureBox;
        private Form1 form;
        private Timer timer;
        private Label space;
        public bool hitGround;
        public Ball(PictureBox ball, Form1 form,Timer timer,PictureBox racket1,PictureBox racket2,Label space)
        {
            this.form = form;
            this.ball = ball;
            this.ballPictureBox = new PictureBox();
            this.ballPictureBox.Size = ball.Size;
            this.ballPictureBox.BackColor = ball.BackColor;
            this.racket1 = racket1;
            this.racket2 = racket2;
            this.timer = timer;
            this.space = space;
            form.Controls.Add(ballPictureBox);
            Default_stats();
        }
        public void Default_stats()
        {
            int[] speed = new int[] { -2, 2 };
            Random rnd = new Random();
            speed_left = speed[rnd.Next(0, 2)];
            speed_top = speed[rnd.Next(0, 2)];
            ballPictureBox.Top = rnd.Next(250, 300);
            ballPictureBox.Left = rnd.Next(250, 400);
        }
        public void Movement_ball(PictureBox racket1, PictureBox racket2, Label space, Label score1, Label score2, Timer timer,List<Ball> ballList)
        {
            if (timer.Enabled == true)
            {
                ballPictureBox.Visible = true;
                var bottom = form.Height;
                var right = form.Width;
                ballPictureBox.Left += speed_left;
                ballPictureBox.Top += speed_top;
                if (ballPictureBox.Bounds.IntersectsWith(racket1.Bounds) || ballPictureBox.Bounds.IntersectsWith(racket2.Bounds))
                {
                    speed_top = -speed_top;
                }
                if (ballPictureBox.Left <= 0 || ballPictureBox.Right >= right)
                {
                    speed_left = -speed_left;
                }
                    if (ballPictureBox.Location.Y >= bottom)
                    {
                        score_player1 += 1;
                        score1.Text = score_player1.ToString();
                        hitGround = true;
                        if (ballList.Count == 1)
                        {
                            space.Visible = true;
                            timer.Enabled = false;
                        }
                    }
                    if (ballPictureBox.Location.Y <= 50)
                    {
                        score_player2 += 1;
                        score2.Text = score_player2.ToString();
                        hitGround = true;
                        if (ballList.Count == 1)
                            {
                            space.Visible = true;
                            timer.Enabled = false;
                            }
                    }
                
            }
            else
            {
                ballPictureBox.Visible = false;
            }
        }
        public int BallLocationX()
        {
            return ballPictureBox.Location.X;
        }
        public void BallIntersectsWithPowerUp(PictureBox powerUp,List<Ball> ballList,List<PowerUps> powersList,Form1 form)
        {
            if (powersList.Count > 0)
            {
                if (ballPictureBox.Bounds.IntersectsWith(powersList[powersList.Count - 1].Bounds()))
                {
                    ballList.Add(new Ball(ball, form, timer, racket1, racket2, space));
                    ballList[ballList.Count - 1].Default_stats();
                    form.Controls.Remove(powersList[powersList.Count - 1].powerUp);
                    powersList.RemoveAt(powersList.Count - 1);

                }
            }
        }
    }
}
