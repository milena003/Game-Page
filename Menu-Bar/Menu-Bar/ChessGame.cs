using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu_Bar
{
    public partial class ChessGame : Form
    {
        private Image ChessImage;
        public int CurrPlayer;
        public Button prevButton;
        public bool isMoving = false;

        public int[,] board = new int[8, 8]
        {
            {15, 14, 13, 12, 11, 13, 14, 15},
            {16, 16, 16, 16, 16, 16, 16, 16},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {26, 26, 26, 26, 26, 26, 26, 26},
            {25, 24, 23, 22, 21, 23, 24, 25},
        };
        public Button[,] buttons = new Button[8, 8];

        public ChessGame()
        {
            InitializeComponent();
            ChessImage = new Bitmap(@"C:\Users\student\Desktop\C#");

            Start();
        }

        public void Start()
        {
            board = new int[8, 8]
            {
                {15, 14, 13, 12, 11, 13, 14, 15},
                {16, 16, 16, 16, 16, 16, 16, 16},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {26, 26, 26, 26, 26, 26, 26, 26},
                {25, 24, 23, 22, 21, 23, 24, 25},
            };

            CurrPlayer = 1;
            CreateBoard();
        }

        public void CreateBoard()
        {
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    buttons[i, j] = new Button();
                    Button butt = new Button();
                    butt.Size = new Size(50, 50);
                    butt.Location = new Point(j * 50, i * 50);

                    switch (board[i, j] / 10)
                    {
                        case 1:
                            Image part1 = new Bitmap(50, 50);
                            Graphics graph1 = Graphics.FromImage(part1);
                            graph1.DrawImage(ChessImage, new Rectangle(0, 0, 50, 50), 0 + 150 * (board[i, j] % 10 - 1), 0, 150, 150, GraphicsUnit.Pixel);
                            butt.BackgroundImage = part1;
                            break;
                        case 2:
                            Image part2 = new Bitmap(50, 50);
                            Graphics graph2 = Graphics.FromImage(part2);
                            graph2.DrawImage(ChessImage, new Rectangle(0, 0, 50, 50), 0 + 150 * (board[i, j] % 10 - 1), 150, 150, 150, GraphicsUnit.Pixel);
                            butt.BackgroundImage = part2;
                            break;

                    }
                    if ((i + j) % 2 == 0)
                    {
                        butt.BackColor = Color.Green;
                    }
                    else if ((i + j) % 2 == 1)
                    {
                        butt.BackColor = Color.Beige;
                    }

                    butt.Click += new EventHandler(PressFigue);
                    this.Controls.Add(butt);
                    buttons[i, j] = butt;
                }
            }
        }

        public void PressFigue(object sender, EventArgs e)
        {
            if (prevButton != null)
            {
                prevButton.BackColor = Color.White;
            }
            Button pressedButton = sender as Button;
            pressedButton.Enabled = false;
            if (board[pressedButton.Location.Y / 50, pressedButton.Location.X / 50] != 0 && board[pressedButton.Location.Y / 50, pressedButton.Location.X / 50] / 10 == CurrPlayer)
            {
                pressedButton.BackColor = Color.Red;
                isMoving = true;
            }
            else
            {
                if (isMoving)
                {
                    int tmp = board[pressedButton.Location.Y / 50, pressedButton.Location.X / 50];
                    board[pressedButton.Location.Y / 50, pressedButton.Location.X / 50] = board[prevButton.Location.Y / 50, prevButton.Location.X / 50];
                    board[prevButton.Location.Y / 50, prevButton.Location.X / 50] = tmp;
                    pressedButton.BackgroundImage = prevButton.BackgroundImage;
                    prevButton.BackgroundImage = null;
                    isMoving = false;
                    CloseSteps();
                    ActivateButtons();
                    SwithPlayer();
                }
            }
            prevButton = pressedButton;
        }

        public void SwithPlayer()
        {
            if (CurrPlayer == 1)
            {
                CurrPlayer = 2;
            }
            else
            {
                CurrPlayer = 1;
            }
        }

        private void RestartButt_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        public void ActivateButtons()
        {
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons[i, j].Enabled = true;
                }
            }
        }
        public void DeactivateButtons()
        {
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons[i, j].Enabled = false;
                }
            }
        }
        public void CloseSteps()
        {
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons[i, j].BackColor = Color.White;
                }
            }
        }
        public bool InsideBorder(int indexX, int indexY)
        {
            if (indexX < 0 || indexY < 0 || indexX >= 8 || indexY >= 8)
            {
                return false;
            }
            return true;
        }

        public void ShowSteps(int CurrFigureX, int CurrFigureY, int CurrFigure)
        {
            int dir = CurrPlayer == 1 ? 1 : -1;
            switch (CurrFigure % 10)
            {
                case 6:
                    if (InsideBorder(CurrFigureX + 1 * dir, CurrFigureY))
                    {
                        if (board[CurrFigureX + 1 * dir, CurrFigureY] == 0)
                        {
                            buttons[CurrFigureX + 1 * dir, CurrFigureY].BackColor = Color.Green;
                            buttons[CurrFigureX + 1 * dir, CurrFigureY].Enabled = true;
                            if (InsideBorder(CurrFigureX + 2 * dir, CurrFigureY))
                            {
                                if (board[CurrFigureX + 2 * dir, CurrFigureY] == 0)
                                {
                                    buttons[CurrFigureX + 2 * dir, CurrFigureY].BackColor = Color.Green;
                                    buttons[CurrFigureX + 2 * dir, CurrFigureY].Enabled = true;
                                }
                            }
                        }
                    }

                    if (InsideBorder(CurrFigureX + 1 * dir, CurrFigureY + 1))
                    {
                        if (board[CurrFigureX + 1 * dir, CurrFigureY + 1] != 0 && board[CurrFigureX + 1 * dir, CurrFigureY + 1] / 10 != CurrPlayer)
                        {
                            buttons[CurrFigureX + 1 * dir, CurrFigureY + 1].BackColor = Color.Green;
                            buttons[CurrFigureX + 1 * dir, CurrFigureY + 1].Enabled = true;
                        }
                    }

                    if (InsideBorder(CurrFigureX + 1 * dir, CurrFigureY - 1))
                    {
                        if (board[CurrFigureX + 1 * dir, CurrFigureY - 1] != 0 && board[CurrFigureX + 1 * dir, CurrFigureY - 1] / 10 != CurrPlayer)
                        {
                            buttons[CurrFigureX + 1 * dir, CurrFigureY - 1].BackColor = Color.Green;
                            buttons[CurrFigureX + 1 * dir, CurrFigureY - 1].Enabled = true;
                        }
                    }
                    break;

                    // case 5: 
            }
        }
    }
}
