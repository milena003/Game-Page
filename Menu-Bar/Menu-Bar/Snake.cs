using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Bar
{
    public partial class Snake : Form
    {
        private List<Circle> Snakeik = new List<Circle>();
        private Circle Food = new Circle();

        int maxWidth;
        int maxHeight;

        int score = 0;
        int highestScore = 0;

        Random rand = new Random();
        Color[] SnaakeColors = {Color.Indigo, Color.DarkBlue, Color.LawnGreen, Color.LightSkyBlue, Color.MediumBlue,
                              Color.MediumOrchid, Color.MidnightBlue, Color.PaleTurquoise};

        bool DirLeft, DirRight, DirUp, DirDown;

        public Snake()
        {
            InitializeComponent();
            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.Direction != "right")
            {
                DirLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.Direction != "left")
            {
                DirRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.Direction != "down")
            {
                DirUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.Direction != "up")
            {
                DirDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                DirLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                DirRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                DirUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                DirDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void TakeSnapShot(object sender, EventArgs e)
        {
            Label caption = new Label();
            caption.Text = "Score is: " + score + ", and the highest score is: " + highestScore;
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);
            caption.ForeColor = Color.Purple;
            caption.AutoSize = false;
            caption.Width = Land.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            Land.Controls.Add(caption);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake snapshoot";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG i,age file | *.jpg";
            dialog.ValidateNames = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(Land.Width);
                int height = Convert.ToInt32(Land.Height);
                Bitmap btm = new Bitmap(width, height);
                Land.DrawToBitmap(btm, new Rectangle(0, 0, width, height));
                btm.Save(dialog.FileName, ImageFormat.Jpeg);
                Land.Controls.Remove(caption);
            }
        }

        private void TimeEvent(object sender, EventArgs e) //timer
        {
            //set the directions
            if (DirLeft)
            {
                Settings.Direction = "left";
            }
            if (DirRight)
            {
                Settings.Direction = "right";
            }
            if (DirUp)
            {
                Settings.Direction = "up";
            }
            if (DirDown)
            {
                Settings.Direction = "down";
            }
            for (int i = Snakeik.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.Direction) { 
                        case "left":
                            Snakeik[i].X--;
                            break;
                        case "right":
                            Snakeik[i].X++;
                            break;
                        case "down":
                            Snakeik[i].Y++;
                            break;
                        case "up":
                            Snakeik[i].Y--;
                            break;
                    }
                    if (Snakeik[i].X < 0)
                    {
                        Snakeik[i].X = maxWidth;
                    }
                    if (Snakeik[i].X > maxWidth)
                    {
                        Snakeik[i].X = 0;
                    }
                    if (Snakeik[i].Y < 0)
                    {
                        Snakeik[i].Y = maxHeight;
                    }
                    if (Snakeik[i].Y > maxHeight)
                    {
                        Snakeik[i].Y = 0;
                    }

                    if (Snakeik[i].X == Food.X && Snakeik[i].Y == Food.Y)
                    {
                        EatFood();
                    }

                    for (int j = 1; j < Snakeik.Count; ++j)
                    {
                        if (Snakeik[i].X == Snakeik[j].X && Snakeik[i].Y == Snakeik[j].Y)
                        {
                            Over();
                        }
                    }
                }
                else
                {
                    Snakeik[i].X = Snakeik[i - 1].X;
                    Snakeik[i].Y = Snakeik[i - 1].Y;
                }
            }
            Land.Invalidate();
        }

        private void UpdatePBox(object sender, PaintEventArgs e)
        {
            Graphics land = e.Graphics;
            Brush snakeColor;

            for (int i = 0; i < Snakeik.Count; ++i)
            {
                if (i == 0)
                {
                    snakeColor = Brushes.Black;
                }
                else
                {
                    snakeColor = new SolidBrush(Snakeik[i].color);
                }
                land.FillEllipse(snakeColor, new Rectangle
                    (
                        Snakeik[i].X * Settings.Width,
                        Snakeik[i].Y * Settings.Height,
                        Settings.Width, Settings.Height
                    ));        
            }

            land.FillEllipse(Brushes.DarkRed, new Rectangle
            (
                Food.X * Settings.Width,
                Food.Y * Settings.Height,
                Settings.Width, Settings.Height
            ));
        }

        private void RestartGame ()
        {
            maxWidth = Land.Width / Settings.Width - 1;
            maxHeight = Land.Height / Settings.Height - 1;

            Snakeik.Clear();
            startButton.Enabled = false;
            snapButton.Enabled = false;
            score = 0;
            CurrScore.Text = "Score: " + score.ToString();

            Circle head = new Circle { X = 10, Y = 5};
            Snakeik.Add(head);  // head is added to the list

            for (int i = 0; i < 10; ++i)
            {
                Circle body = new Circle();
                Snakeik.Add(body);
            }

            Food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            SnakeTime.Start();
        }

        private void EatFood()
        {
            ++score;
            CurrScore.Text = "Score: " + score;

            Color randColor = SnaakeColors[rand.Next(0, SnaakeColors.Length)];
            Circle newBody = new Circle()
            {
                X = Snakeik[Snakeik.Count - 1].X,
                Y = Snakeik[Snakeik.Count - 1].Y,
                color = randColor,
            };

            Snakeik.Add(newBody);
            Food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void Over ()
        {
            SnakeTime.Stop();
            startButton.Enabled = true;    
            snapButton.Enabled = true;
            if (score > highestScore)
            {
                highestScore = score;
                highScore.Text = "Highest: " + highestScore.ToString();
            }
        }
    }
}
