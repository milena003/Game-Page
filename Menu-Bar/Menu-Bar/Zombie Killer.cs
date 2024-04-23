using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Menu_Bar
{
    public partial class Zombie_Killer : Form
    {
        bool GoLeft;
        bool GoRight;
        bool GoUp;
        bool GoDown;
        bool GameOver;

        string directoion = "up";
        int healthRatio = 100;
        int speed = 10;
        int ammunition = 10;
        int killCount = 0;
        int zombieSpeed = 3;
        Random random = new Random();

        List<PictureBox> zombies = new List<PictureBox>();

        public Zombie_Killer()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (healthRatio > 1)
            {
                healthProg.Value = Convert.ToInt32(healthRatio);
            }
            else
            {
                Killer.Image = Properties.Resources.dead;
                GameOver = true;
                ZombieTimer.Stop();
            }

            ammos.Text = "Ammunition: " + ammunition;
            killScore.Text = "Kills " + killCount;

            if (healthRatio < 20)
            {
                healthProg.BackColor = Color.Red; 
            }

            // killers movement boundries
            if (GoLeft && Killer.Left > 0)
            {
                Killer.Left -= speed;
            }
            
            if (GoRight && Killer.Left + Killer.Width < this.ClientSize.Width) 
            {
                Killer.Left += speed;
            }

            if (GoUp && Killer.Top > 40)
            {
                Killer.Top -= speed;
            }
            
            if (GoDown && Killer.Top + Killer.Height < this.ClientSize.Height)
            {
                Killer.Top  += speed;
            }

            foreach (Control i in this.Controls)
            {
                //add mamunition (+5)
                if (i is PictureBox && (string)i.Tag == "ammo")
                {
                    if (Killer.Bounds.IntersectsWith(i.Bounds))
                    {
                        this.Controls.Remove(i);
                        ((PictureBox)i).Dispose();
                        ammunition += 5;
                    }
                }

                if (i is PictureBox && (string)i.Tag == "zombie")
                {
                    if (Killer.Bounds.IntersectsWith(i.Bounds))
                    {
                        --healthRatio;
                    }

                    // zombie movement
                    if (i.Left > Killer.Left)
                    {
                        i.Left -= zombieSpeed;
                        ((PictureBox)i).Image = Properties.Resources.zleft;
                    }

                    if (i.Left < Killer.Left)
                    {
                        i.Left += zombieSpeed;
                        ((PictureBox)i).Image = Properties.Resources.zright;
                    }

                    if (i.Top > Killer.Top)
                    {
                        i.Top -= zombieSpeed;
                        ((PictureBox)i).Image = Properties.Resources.zup;
                    }

                    if (i.Top < Killer.Top)
                    {
                        i.Top += zombieSpeed;
                        ((PictureBox)i).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && i is PictureBox && (string)i.Tag == "zombie")
                    {
                        if (i.Bounds.IntersectsWith(j.Bounds))
                        {
                            ++killCount;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();  
                     
                            this.Controls.Remove(i);
                            ((PictureBox)i).Dispose();
                            zombies.Remove(((PictureBox)i));
                            MakeZombie();
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K)
            {
                RestartGame();
            }

            if (e.KeyCode == Keys.Enter && GameOver)
            {
                RestartGame();
            }

            if (GameOver)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                GoLeft = true;
                directoion = "left";
                Killer.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = true;
                directoion = "right";
                Killer.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                GoUp = true;
                directoion = "up";
                Killer.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = true;
                directoion = "down";
                Killer.Image = Properties.Resources.down;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (GameOver)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                GoLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                GoUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = false;
            }

            if (e.KeyCode == Keys.Space && ammunition > 0 && GameOver == false)
            {
                --ammunition;
                ShootBullet(directoion);
            
                if (ammunition < 1)
                {
                    DropAmmoition();
                }
            }
        }

        private void ShootBullet (string dir)
        {
            Bullet shoot = new Bullet();
            shoot.direction = dir;
            shoot.BullletLeft = Killer.Left + (Killer.Width / 2);
            shoot.BullletTop = Killer.Top + (Killer.Height / 2);
            shoot.MakeBullet(this);
        }

        private void MakeZombie ()
        {
            PictureBox zombie = new PictureBox(); 
            zombie.Tag = "zombie"; 
            zombie.Image = Properties.Resources.zdown; 
            zombie.Left = random.Next(0, 900); 
            zombie.Top = random.Next(0, 800); 
            zombie.SizeMode = PictureBoxSizeMode.AutoSize; 
            this.Controls.Add(zombie);
            zombies.Add(zombie);
            Killer.BringToFront();
        }

        private void DropAmmoition ()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = random.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = random.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            Killer.BringToFront();
        }

        private void RestartGame()
        {
            Killer.Image = Properties.Resources.up;

            foreach (PictureBox pic in zombies)
            {
                this.Controls.Remove(pic);
                pic.Dispose();
            }
            zombies.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeZombie();
            }

            GoUp = false;
            GoDown = false;
            GoRight = false;
            GoLeft = false;

            GameOver = false;

            healthRatio = 100;
            killCount = 0;
            ammunition = 10;

            healthProg.Value = healthRatio;
            ammos.Text = "Ammunition: " + ammunition;
            killScore.Text = "Kills: " + killCount;
            healthProg.BackColor = Color.Green;
            ZombieTimer.Start();
        }
    }
}