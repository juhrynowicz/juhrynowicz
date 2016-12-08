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
   
    public class PowerUps
    {
        private PictureBox ball;
        public PictureBox powerUp;
        private Form1 form;
        public PowerUps(PictureBox ball,PictureBox pu,Form1 form)
        {
            this.ball = ball;
            this.powerUp = new PictureBox();
            this.powerUp.Size = pu.Size;
            this.powerUp.BackColor = pu.BackColor;
            this.form = form;
            form.Controls.Add(powerUp);
            SetNewLocation();
        }
        public void SetNewLocation() // metoda ustawiająca losową lokalizacje Y dla power-upa
        {
            powerUp.Visible = true;
            Random r1 = new Random();
            Random r2 = new Random();
            int i = r2.Next(0, 2);
            if (i == 0)
                powerUp.Top = form.Height / 4;
            else
                powerUp.Top = 3*form.Height / 4;
            powerUp.Left = r1.Next(form.Width / 4, 3 * form.Width / 4);
        }
        public System.Drawing.Rectangle Bounds() //potrzebne do interakcji w klasie piłka
        {
            return powerUp.Bounds;
        }
    }
}
