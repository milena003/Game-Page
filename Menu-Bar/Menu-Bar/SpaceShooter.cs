using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Menu_Bar
{
    public partial class SpaceShooter : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shoot;
        WindowsMediaPlayer boom;

        PictureBox[] stars;
        int spped;

        PictureBox[] arsenals;
        int arsenalSpeed;

        PictureBox[] enemies;
        int enemySpeed;

        PictureBox[] enemyArsenals;
        int enemyArsenalSpeed;

        Random rd = new Random();
        int playerSpeed;

        int score;
        int difficulty;
        int level;
        bool pause;
        bool gameOver ;

        public SpaceShooter()
        {
            InitializeComponent();
        }

        private void SpaceShooter_Load(object sender, EventArgs e)
        {
            spped = 4;
            playerSpeed = 4;
            enemySpeed = 4;
            arsenalSpeed = 20;
            enemyArsenalSpeed = 4;

            score = 0;
            difficulty = 9;
            level = 1;
            pause = false;
            gameOver = false;

            arsenals = new PictureBox[3];

            Image enemy1 = Resource.E1;
            Image enemy2 = Resource.E2;
            Image enemy3 = Resource.E3;
            Image boss1 = Resource.Boss1;
            Image boss2 = Resource.Boss2;

            enemies = new PictureBox[10];
            for (int i = 0; i < enemies.Length; ++i)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;

                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point(i * 50, -50);
            }

            enemies[0].Image = boss1;
            enemies[1].Image = enemy2;
            enemies[2].Image = enemy3;
            enemies[3].Image = enemy2;
            enemies[4].Image = enemy3;
            enemies[5].Image = enemy1;
            enemies[6].Image = enemy3;
            enemies[7].Image = enemy2;
            enemies[8].Image = enemy3;
            enemies[9].Image = boss2;

            Image arsenal = Resource.munition;
            for (int i = 0; i < arsenals.Length; ++i)
            {
                arsenals[i] = new PictureBox();
                arsenals[i].Size = new Size(8, 8);
                arsenals[i].Image = arsenal;
                arsenals[i].SizeMode = PictureBoxSizeMode.Zoom;
                arsenals[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(arsenals[i]);
            }

            enemyArsenals = new PictureBox[10];
            for (int i = 0; i < enemyArsenals.Length; ++i)
            {
                enemyArsenals[i] = new PictureBox();
                enemyArsenals[i].Size = new Size(2, 25);
                enemyArsenals[i].Visible = false;
                enemyArsenals[i].BackColor = Color.Yellow;

                int x = rd.Next(0, 10);
                enemyArsenals[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemyArsenals[i]);
            }

            stars = new PictureBox[15];
            for (int i = 0; i < stars.Length; ++i)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rd.Next(20, 580), rd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.White;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }

                this.Controls.Add(stars[i]);
            }

            gameMedia = new WindowsMediaPlayer();
            gameMedia.URL = "GameSong.mp3";

            shoot = new WindowsMediaPlayer();
            shoot.URL = "shoot.mp3";

            boom = new WindowsMediaPlayer();
            boom.URL = "boom.mp3";

            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shoot.settings.volume = 1;
            boom.settings.volume = 6;

            gameMedia.controls.play();
        }

        private void SpaceTime_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; ++i)
            {
                stars[i].Top += spped;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top -= stars[i].Height;
                }
            }

            for (int i = stars.Length / 2; i < stars.Length; ++i)
            {
                stars[i].Top += spped - 2;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }   
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    if (Player.Right < 580)
                    {
                        Player.Left += playerSpeed;
                    }
                }

                if (e.KeyCode == Keys.Left)
                {
                    if (Player.Left > 40)
                    {
                        Player.Left -= playerSpeed;
                    }
                }

                if (e.KeyCode == Keys.Up)
                {
                    if (Player.Top > 10)
                    {
                        Player.Top -= playerSpeed;
                    }
                }

                if (e.KeyCode == Keys.Down)
                {
                    if (Player.Top < 300)
                    {
                        Player.Top += playerSpeed;
                    }
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (!gameOver)
            {
                if (e.KeyCode == Keys.Space) 
                {
                    if (pause)
                    {
                        StartTimer();
                        Result.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }
                    else
                    {
                        Result.Location = new Point(this.Width / 2 - 120, 150);
                        Result.Text = "Paused";
                        Result.Visible = true;
                        gameMedia.controls.pause();
                        StopTimer();
                        pause = true;
                    }
                }
            }
        }


        private void MoveArsenals_Tick(object sender, EventArgs e)
        {
            shoot.controls.play();
            for (int i = 0; i < arsenals.Length; ++i)
            {
                if (arsenals[i].Top > 0)
                {
                    arsenals[i].Visible = true;
                    arsenals[i].Top -= arsenalSpeed;

                    Collision();
                }
                else
                {
                    arsenals[i].Visible = false;
                    arsenals[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemies.Length; ++i)
            {
                enemies[i].Visible = true;
                enemies[i].Top += enemySpeed;

                if (enemies[i].Top > this.Height)
                {
                    enemies[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        private void Collision ()
        {
            for (int i = 0; i < enemies.Length; ++i)
            {
                if (arsenals[0].Bounds.IntersectsWith(enemies[i].Bounds) 
                    || arsenals[1].Bounds.IntersectsWith(enemies[i].Bounds)
                    || arsenals[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    boom.controls.play();
                    ++score;
                    scoreLabel.Text = "Score: " + score.ToString();

                    if (score % 30 == 0)
                    {
                        ++level;
                        lvlLabel.Text = "Level: " + level.ToString();
                        if (enemySpeed <= 10 && enemyArsenalSpeed <= 10 && difficulty >= 0)
                        {
                            difficulty--;
                            enemySpeed++;
                            enemyArsenalSpeed++;
                        }
                        if (level == 10)
                        {
                            GameOver("Nice Done");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }

                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    boom.settings.volume = 30;
                    boom.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        private void EnemyArsenalCollision ()
        {
            for (int i = 0; i < enemyArsenals.Length; ++i)
            {
                if (enemyArsenals[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemyArsenals[i].Visible = false;
                    boom.settings.volume = 30;
                    boom.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        private void GameOver (string str)
        {
            Result.Text = str;
            Result.Location = new Point(120, 120);
            Result.Visible = true;
            Exit.Visible = true;
            Reply.Visible = true;

            gameMedia.controls.stop();
            StopTimer();
        }

        private void StopTimer ()
        {
            SpaceTime.Stop();
            MoveArsenals.Stop();
            EnemyTimer.Stop();
            EnemyArsenal.Stop();
        }

        private void StartTimer ()
        {
            SpaceTime.Start();
            MoveArsenals.Start();
            EnemyTimer.Start();
            EnemyArsenal.Start();   
        }

        private void EnemyArsenal_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < (enemyArsenals.Length - difficulty); ++i)
            {   
                if (enemyArsenals[i].Top < this.Height)
                {
                    enemyArsenals[i].Visible = true;
                    enemyArsenals[i].Top += enemyArsenalSpeed;
                    EnemyArsenalCollision();
                }
                else
                {
                    enemyArsenals[i].Visible = false;               
                    int x = rd.Next(0, 10);
                    enemyArsenals[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }

        private void Reply_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            SpaceShooter_Load(e, e);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
};