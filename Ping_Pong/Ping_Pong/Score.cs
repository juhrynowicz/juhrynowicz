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
    public class Score
    {
        protected static int score_player1 = 0;
        protected static int score_player2 = 0;
        protected static int max_score = 10;
        public static void MaximumScore(Label space,Label gameOver)
        {
            if (score_player1 >= max_score)
            {
                space.Visible = false;
                gameOver.Visible = true;
                gameOver.Text = "GAME OVER\nPlayer 1 Won!\nPress F1 to restart\nESC to exit";
            }
            if (score_player2 >= max_score)
            {
                space.Visible = false;
                gameOver.Visible = true;
                gameOver.Text = "GAME OVER\nPlayer 2 Won!\nPress F1 to restart\nESC to exit";
            }
        }
        public static bool Player1Won()
        {
            if (score_player1 >= max_score)
                return true;
            else return false;
        }
        public static bool Player2Won()
        {
            if (score_player2 >= max_score)
                return true;
            else return false;
        }
    }
}
