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
    class Player
    {
        public bool player_left;
        public bool player_right;
        private int speed_racket = 3;
        private Form1 form;
        private PictureBox racket;
        public Player(PictureBox racket,Form1 form)
        {
            this.racket = racket;
            this.form = form;
        }
        public void Movement_Speed()
        {
            //Ustawienie szybkości przesuwania się graczy
            var left = form.Width;
            if (player_right && racket.Left <= left - racket.Width)
                racket.Left += speed_racket;
            if (player_left && racket.Left >= 0)
                racket.Left -= speed_racket;
        }
    }
}
