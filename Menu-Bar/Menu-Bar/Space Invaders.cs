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
    public partial class Space_Invaders : Form
    {
        bool GoLeft;
        bool GoRight;
        int Score = 0;
        int PlayerSpeed = 12;
        int EnemySpeed = 5;
        int EnemyBullet = 300;

        PictureBox[] Invaders;
        bool shooting;
        bool gameOver;

        public Space_Invaders()
        {
            InitializeComponent();
            GameSetup();
        }

        private void ShootingEvent(object sender, EventArgs e)
        {
            ScoreLabel.Text = "Score: " + Score;

            if (GoLeft)
            {
                Triangle.Left -= PlayerSpeed;
            }

            if (GoRight)
            {
                Triangle.Left += PlayerSpeed;
            }

            EnemyBullet -= 10;
            if (EnemyBullet < 1)
            {
                EnemyBullet = 300;
                makeBullet("sadbullet");
            }

            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && (string)i.Tag == "sad")
                {
                    i.Left += EnemySpeed;

                    if (i.Left > 860)
                    {
                        i.Top += 65;
                        i.Left = -80;
                    }

                    if (i.Bounds.IntersectsWith(Triangle.Bounds))
                    {
                        GameOver("Sad inviders killed you");
                    }

                    foreach (Control j in this.Controls)
                    {
                        if (j is PictureBox && (string)j.Tag == "bullet")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                this.Controls.Remove(i);
                                this.Controls.Remove(j);
                                ++Score;
                                shooting = false;

                            }
                        }
                    }
                }
                
                if (i is PictureBox && (string)i.Tag == "bullet")
                {
                    i.Top -= 20;

                    if (i.Top < 15)
                    {
                        this.Controls.Remove(i);
                        shooting = false;
                    }
                }

                if (i is PictureBox && (string)i.Tag == "sadbullet")
                {
                    i.Top += 20;

                    if (i.Top > 620)
                    {
                        this.Controls.Remove(i);
                    } 

                    if (i.Bounds.IntersectsWith(Triangle.Bounds))
                    {
                        this.Controls.Remove(i);
                        GameOver("Oops, You're sad forever!!");
                    }
                }
            }

            if (Score > 8)
            {
                EnemySpeed = 9;
            }

            if (Score == Invaders.Length)
            {
                GameOver("You win, you found happiness");
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                GoRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                GoRight = false;
            }

            if (e.KeyCode == Keys.Space && shooting == false) 
            {
                shooting = true;
                makeBullet("bullet");
            }

            if (e.KeyCode == Keys.Enter && gameOver)
            {
                RemoveItems();
                GameSetup();
            }
        }

        private void MakeInviders ()
        {
            Invaders = new PictureBox[15];

            int left = 0;
            for (int i = 0; i < Invaders.Length; i++)
            {
                Invaders[i] = new PictureBox();
                Invaders[i].Size = new Size(60, 50);
                Invaders[i].Image = Properties.Resources.sadFace;
                Invaders[i].Top = 5;
                Invaders[i].Tag = "sad";
                Invaders[i].Left = left;
                Invaders[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(Invaders[i]);
                left -= 80;
            }
        }

        private void GameSetup ()
        {
            Score = 0;
            ScoreLabel.Text = "Score: " + Score;

            EnemyBullet = 300;
            EnemySpeed = 5;
            shooting = false;

            MakeInviders();
            ShootTime.Start();
        }

        private void GameOver (string message)
        {
            gameOver = true;
            ShootTime.Stop();
            ScoreLabel.Text = message;
        }

        private void RemoveItems()
        {
            foreach (PictureBox i in Invaders)
            {
                this.Controls.Remove(i);
            }

            foreach (Control i in this.Controls)
            {
                if (i is PictureBox)
                {
                    if ((string)i.Tag == "bullet" || (string)i.Tag == "bullet")
                    {
                        this.Controls.Remove(i);
                    }
                }
            }
        }

        private void makeBullet (string blletTag)
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet;
            bullet.Size = new Size (5, 20);
            bullet.Tag = blletTag;
            bullet.Left = Triangle.Left + Triangle.Width / 2;

            if ((string)bullet.Tag == "bullet")
            {
                bullet.Top = Triangle.Top - 20;
            }
            else if ((string)bullet.Tag == "sadbullet") 
            {
                bullet.Top = -100;
            }
            
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
    }
}
