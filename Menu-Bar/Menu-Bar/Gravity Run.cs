using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Bar
{
    public partial class Gravity_Run : Form
    {
        int gravity;
        int gravityValue = 8;
        int obstacleSpeed = 10;
        int scoree = 0;
        int hScore = 0;
        bool gameOver = false;
        Random random = new Random();

        public Gravity_Run()
        {
            InitializeComponent();
        }

        private void RunTimeEvent(object sender, EventArgs e)
        {
            RunScore.Text = "Score: " + scoree;
            HScore.Text = "High Score: " + hScore;
            Runner.Top += gravity;

            if (Runner.Top > 456)
            {
                gravity = 0;
                Runner.Top = 456;
                Runner.Image = Properties.Resources.run_down0;
            }
            else if (Runner.Top < 36)
            {
                gravity = 0;
                Runner.Top = 36;
                Runner.Image = Properties.Resources.run_up0;
            }

            foreach (Control i in this.Controls)
            {
                if ( i is PictureBox && (string)i.Tag == "obstacle")
                {
                    i.Left -= obstacleSpeed;

                    if (i.Left < -100)
                    {
                        i.Left = random.Next(1200, 3000);
                        ++scoree;
                    }

                    if (i.Bounds.IntersectsWith(Runner.Bounds))
                    {
                        RunTime.Stop();
                        RunScore.Text += "   Game over! Press Enter to Restart";
                        gameOver = true;

                        if (scoree > hScore)
                        {
                            hScore = scoree;
                        }
                    }
                }
            }

            if (scoree > 10)
            {
                obstacleSpeed = 20;
                gravityValue = 12;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K)
            {
                RestartGame();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (Runner.Top == 456)
                {
                    Runner.Top -= 10;
                    gravity = (-gravityValue);
                }
                else if (Runner.Top == 36)
                {
                    Runner.Top += 10;
                    gravity = gravityValue;
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
    
        private void RestartGame ()
        {
            Runner.Location = new Point(240, 323);
            Runner.Image = Properties.Resources.run_down0;

            scoree = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 10;

            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && (string)i.Tag == "obstacle")
                {
                    i.Left = random.Next(1000, 1500);
                }
            }

            RunTime.Start();
        }

        private void Gravity_Run_Load(object sender, EventArgs e)
        {
            RunScore.Parent = groundTop;
            RunScore.BackColor = Color.Transparent;
            HScore.Parent = groundButtom;
            HScore.BackColor = Color.Transparent;
            HScore.Top = 0;
        }
    }
}