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
    class AIBot
    {
        private PictureBox racket;
        private Player aiBot;
        private PictureBox ball;
        private Form1 form;
        private List<Ball> ballList;
        public AIBot(PictureBox racket,PictureBox ball,Form1 form,List<Ball> ballList)
        {
            this.racket = racket;
            this.ball = ball;
            this.form = form;
            this.ballList = ballList;
        }
        public void ballFollow() //śledzenie piłki przez bota
        {
            aiBot = new Player(racket,form);
            if (ballList[ballList.Count-1].BallLocationX() > racket.Location.X + racket.Width / 2)
            {
                aiBot.player_left = false;
                aiBot.player_right = true;
                aiBot.Movement_Speed();
            }
            if (ballList[ballList.Count - 1].BallLocationX() < racket.Location.X + racket.Width / 2)
            {
                aiBot.player_left = true;
                aiBot.player_right = false;
                aiBot.Movement_Speed();
            }

        }

    }
}
