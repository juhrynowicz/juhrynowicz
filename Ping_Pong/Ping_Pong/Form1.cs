using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Media;
namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        Player p1, p2;
        AIBot bot;
        public List<Ball> ballList;
        public List<PowerUps> powerList;
        bool menu1, menu2, menu3;
        public static string data = null;
        public Form1()
        {
            InitializeComponent();
            ObjectsColors();
            p1 = new Player(Racket1,this);
            p2 = new Player(Racket2,this);
            powerList = new List<PowerUps>();
            ballList = new List<Ball>();
            ballList.Add(new Ball(aBall, this, Timer, Racket1, Racket2, spaceLabel));
            bot = new AIBot(Racket2, aBall, this, ballList);
            Timer.Enabled = true;           
            this.Controls.Remove(aBall); //usunięcie piłeczki bazowej
            this.Controls.Remove(powerUp); //usunięcie bazowego power-upa
        }
        private void ObjectsColors() //kolory obiektów
        {
            this.scoreLabel1.ForeColor = SystemColors.ButtonFace;
            this.scoreLabel2.ForeColor = SystemColors.ButtonFace;
            this.scoreLabel3.ForeColor = SystemColors.ButtonFace;
            this.scoreLabel4.ForeColor = SystemColors.ButtonFace;
            this.spaceLabel.ForeColor = SystemColors.ButtonFace;
            this.Racket1.BackColor = SystemColors.HotTrack;
            this.Racket2.BackColor = SystemColors.HotTrack;
            this.powerUp.BackColor = System.Drawing.Color.Red;
            this.aBall.BackColor = SystemColors.HotTrack;
            this.goLabel.ForeColor = SystemColors.ButtonFace;
            this.com1Menu.ForeColor = SystemColors.ButtonFace;
            this.vsBot.ForeColor = SystemColors.ButtonFace;
            this.networkMenu.ForeColor = SystemColors.ButtonFace;
        }
        private void MenuGame() //widoczność napisów w menu
        {
            com1Menu.Left = this.Width/2 - com1Menu.Width/2;
            networkMenu.Left = this.Width / 2 - networkMenu.Width/2 ;
            vsBot.Left = this.Width / 2 - vsBot.Width/2;
            if (com1Menu.Visible == true || networkMenu.Visible == true)
            {
                powerUp.Visible = false;
                Racket1.Visible = false;
                Racket2.Visible = false;
                aBall.Visible = false;
                scoreLabel1.Visible = false;
                scoreLabel2.Visible = false;
                scoreLabel3.Visible = false;
                scoreLabel4.Visible = false;
                Timer.Enabled = false;
            }
        }
        private void MenuVisible() //widoczność obiektów po kliknięciu jednego z opcji w menu
        {
            powerUp.Visible = true;
            Racket1.Visible = true;
            Racket2.Visible = true;
            aBall.Visible = true;
            scoreLabel1.Visible = true;
            scoreLabel2.Visible = true;
            scoreLabel3.Visible = true;
            scoreLabel4.Visible = true;
            Timer.Enabled = true;
            com1Menu.Visible = false;
            networkMenu.Visible = false;
            vsBot.Visible = false;
        }
        private void Start_New_Game() //dodanie nowej piłki oraz ustawienie domyślnych pozycji rakiet
        {
            ballList.Add(new Ball(aBall, this, Timer, Racket1, Racket2, spaceLabel));
            Racket1.Left = 250;
            Racket2.Left = 250;
            Timer.Enabled = true;
            spaceLabel.Visible = false;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            MenuGame();
            BallHitGround();
            p1.Movement_Speed();
            if (menu1 == true)
            {
                p2.Movement_Speed();
            }
            if (menu3 == true)
            {
                bot.ballFollow();
            }
            if (ballList.Count == 0)
            {
                Start_New_Game();
            }          
            for(int i = ballList.Count - 1; i >= 0; i--) 
            {
                ballList[i].Movement_ball(Racket1, Racket2, spaceLabel, scoreLabel3, scoreLabel4, Timer, ballList);
                ballList[i].BallIntersectsWithPowerUp(powerUp, ballList, powerList,this);
                if (ballList[i].hitGround == true)
                {
                    this.Controls.Remove(ballList[i].ballPictureBox);
                    ballList.RemoveAt(i);                    
                }
                if (ballList.Count == 1 && powerList.Count == 0 && Timer.Enabled == true)//dodanie nowego power-upa kiedy jest jedynie jedna piłeczka oraz nie ma innego power-upa
                {
                    powerList.Add(new PowerUps(aBall, powerUp, this));
                }
            }
            Score.MaximumScore(spaceLabel,goLabel);
        }

        private void BallHitGround() //ustawienie pozycji napisów kontynuacji gry
        {
            spaceLabel.Left = (this.Width / 2) - (spaceLabel.Width / 2);
            spaceLabel.Top = (this.Height / 2) - (spaceLabel.Height / 2);
            spaceLabel.Visible = false;
            goLabel.Left = (this.Width / 2) - (goLabel.Width / 2);
            goLabel.Top = (this.Height / 2) - (goLabel.Height / 2);
            goLabel.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeysCheck(e,true);
        }

        private void KeysCheck(KeyEventArgs e, bool isDown) //przycisnki kontrolowanie rakiet oraz wyłączające bądź kontynuujące rozgrywke
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            switch (e.KeyCode)
            {
                case Keys.A:
                    p2.player_left = isDown;
                    break;
                case Keys.Left:
                    p1.player_left = isDown;
                    break;
                case Keys.D:
                    p2.player_right = isDown;
                    break;
                case Keys.Right:
                    p1.player_right = isDown;
                    break;
            }
            if (e.KeyCode == Keys.Space && Timer.Enabled == false)
            {
                Start_New_Game();
            }
            if (e.KeyCode == Keys.F1 && Timer.Enabled == false && (Score.Player1Won() || Score.Player2Won()))
            {
                Start_New_Game();
                goLabel.Visible = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            KeysCheck(e, false);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            menu1 = true;
            MenuVisible();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //nettext1.visible = true;
            //nettext2.visible = true;
            //nettext3.visible = true;
            //nettext4.visible = true;
            //netbutton2.visible = true;
            //netbutton.visible = true;
            //com1menu.visible = false;
            //networkmenu.visible = false;
            //nethost1.visible = true;
            //netport1.visible = true;
            //nethost2.visible = true;
            //netport2.visible = true;
            MessageBox.Show("Przegrana walka z socketami\nNadal do nauczenia");
        }

        private void button1_click(object sender, EventArgs e)
        {
        }

        private void netbutton_click(object sender, EventArgs e)
        {
        }

        private void vsBot_Click(object sender, EventArgs e)
        {
            menu3 = true;
            MenuVisible();
        }
       
        
    }
}
