using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Bar
{
    public partial class Flappy_Bird : Form
    {
        public Flappy_Bird()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int speed = 8;
        int position = 10;
        int score = 0;
        int highScore = Properties.Settings.Default.HighScore;
        int groundLocation = 0;
        
        private void Flappy_Bird_Load(object sender, EventArgs e)
        {
            PipeDown.Parent = Jungle;
            PipeDown.BackColor = Color.Transparent;
            PipeUp.Parent = Jungle;
            PipeUp.BackColor = Color.Transparent;
            Scoree.Parent = Jungle;
            Scoree.BackColor = Color.Transparent;
            Over.Parent = Jungle; 
            Over.BackColor = Color.Transparent;
            NewScore.Parent = Jungle; 
            NewScore.BackColor = Color.Transparent;

            Hippo.Parent = Jungle;
            Hippo.BackColor = Color.Transparent;
            Hippo.BringToFront();

            NewScore.Visible = true;
            NewScore.Text = "Press enter to start";
        }

        private void GameTime_Tick(object sender, EventArgs e)
        {
            NewScore.Visible = false;
            Hippo.Top += position;
            PipeDown.Left -= speed;
            PipeUp.Left -= speed;
            Scoree.Text = "Score: " + score;
            Ground.Left -= speed;
            groundLocation -= speed;

            if (PipeDown.Left < -150)
            {
                PipeDown.Left = rnd.Next(230, 600);
                ++score;
            }
            if (PipeUp.Left < -180)
            {
                PipeUp.Left = rnd.Next(300, 700);
                ++score;
            }
            if (Ground.Left < -900)
           {
                Ground.Left = 0;
                groundLocation = 0;
            }
            if (Hippo.Bounds.IntersectsWith(PipeDown.Bounds) ||
                    Hippo.Bounds.IntersectsWith(PipeUp.Bounds) ||
                    Hippo.Bounds.IntersectsWith(Ground.Bounds) ||
                    Hippo.Top < -25)
            {
                EndGame();
            }
            if (score > highScore)
            {
                highScore = score;
                Properties.Settings.Default.HighScore = highScore;
                Properties.Settings.Default.Save();
            }
            if (score == 50)
            {
                Winner();
            }
            if (score > 25)
            {
                Jungle.Image = Properties.Resources.night;
                speed = 10;
            }
        }

        private void EndGame()
        {
            GameTime.Stop();
            Over.Visible = true;
            Over.Parent = Jungle;
            Over.BackColor = Color.Transparent;
            Over.Text = "Game Over !!!";

            NewScore.Visible = true;
            NewScore.Parent = Jungle;
            NewScore.BackColor = Color.Transparent;
            NewScore.Text = "High Score: " + highScore;
        }

        private void Winner()
        {
            GameTime.Stop();
            NewScore.Visible = true;
            NewScore.Parent = Jungle;
            NewScore.BackColor = Color.Transparent;
            NewScore.Text = "Congradualtions";
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GameTime.Enabled = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                position = -10;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                position = 10;
            }
        }
    }
}
