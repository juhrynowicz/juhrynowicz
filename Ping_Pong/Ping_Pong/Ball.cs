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
            //konstruktor dodający nowy obiekt piłka na bazie istniejącego obiektu
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
        public void Default_stats() //ustawienia domyślne po uderzeniu piłki w górny lub dolny playground
        {
            int[] speed = new int[] { -2, 2 };
            Random r1 = new Random();
            speed_left = speed[r1.Next(0, 2)];
            speed_top = speed[r1.Next(0, 2)];
            ballPictureBox.Top = r1.Next(250, 300);
            ballPictureBox.Left = r1.Next(250, 400);
        }
        public void Movement_ball(PictureBox racket1, PictureBox racket2, Label space, Label score1, Label score2, Timer timer,List<Ball> ballList)
        {
            //metoda ustawiająca poruszanie się piłeczki oraz interakcje z obiektami tj. rakiety oraz boczne ściany playgroundu
            //oczywiście kwestia poruszania się piłeczki zostaje do modyfikacji
            if (timer.Enabled == true)
            {
                ballPictureBox.Visible = true;
                var bottom = form.Height;
                var right = form.Width;
                ballPictureBox.Left += speed_left;
                ballPictureBox.Top += speed_top;
                if (ballPictureBox.Bounds.IntersectsWith(racket1.Bounds))
                {
                    speed_left += 1;
                    speed_top += 1;
                    speed_top = -speed_top;
                }
                if (ballPictureBox.Bounds.IntersectsWith(racket2.Bounds))
                {
                    speed_left -= 1;
                    speed_top -= 1;
                    speed_top = -speed_top;
                }
                if (ballPictureBox.Left <= 0 || ballPictureBox.Right >= right)
                {
                    speed_left = -speed_left;
                }
                    if (ballPictureBox.Location.Y >= bottom) // ustawienie dodawania punktów po uderzeniu w dolny/górny playground
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
        public int BallLocationX() //lokalizacja piłki potrzebna dla bota
        {
            return ballPictureBox.Location.X;
        }
        public void BallIntersectsWithPowerUp(PictureBox powerUp,List<Ball> ballList,List<PowerUps> powersList,Form1 form)
        {
            //interakcja z power-upem dodająca nowy obiekt piłki do listy piłek oraz usunięcie power-up z listy 
            if (powersList.Count > 0)
            {
                if (ballPictureBox.Bounds.IntersectsWith(powersList[powersList.Count - 1].Bounds()))
                {
                    int[] speed = new int[] { -2, 2 };
                    Random r1 = new Random();
                    speed_left = speed[r1.Next(0, 2)];
                    speed_top = speed[r1.Next(0, 2)];
                    ballList.Add(new Ball(ball, form, timer, racket1, racket2, space));
                    ballList[ballList.Count - 1].Default_stats();
                    form.Controls.Remove(powersList[powersList.Count - 1].powerUp);
                    powersList.RemoveAt(powersList.Count - 1);

                }
            }
        }
    }
}
