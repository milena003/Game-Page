using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Bar
{
    public partial class Tic_Tac_Toe : Form
    {
        char player = 'A';
        short movement = 0;


        public Tic_Tac_Toe()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player = 'A';
            movement = 0;
            b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.White;
            b2.Enabled = true; b2.Text = ""; b2.BackColor = Color.White;
            b3.Enabled = true; b3.Text = ""; b3.BackColor = Color.White;
            b4.Enabled = true; b4.Text = ""; b4.BackColor = Color.White;
            b5.Enabled = true; b5.Text = ""; b5.BackColor = Color.White;
            b6.Enabled = true; b6.Text = ""; b6.BackColor = Color.White;
            b7.Enabled = true; b7.Text = ""; b7.BackColor = Color.White;
            b8.Enabled = true; b8.Text = ""; b8.BackColor = Color.White;
            b9.Enabled = true; b9.Text = ""; b9.BackColor = Color.White;
            tableLayoutPanel1.Enabled = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Enabled = false;
            if (player == 'A')
            {
                button.Text = "A";
                button.BackColor = Color.HotPink;
                if ((b1.Text == b2.Text && b2.Text ==  b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    over.Visible = true;
                    over.Text = $"The winner is {player.ToString()}!";
                    over.ForeColor = Color.HotPink;
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    over.Visible = true;
                    over.Text = "Draw!";
                    over.ForeColor = Color.Black;
                }
                player = 'B';
            }
            else if (player == 'B')
            {
                button.Text = "B";
                button.BackColor = Color.LightPink;
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    over.Visible = true;
                    over.Text = $"The winner is {player.ToString()}!";
                    over.ForeColor = Color.LightPink;
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    over.Visible = true ;
                    over.Text = "Draw!";
                    over.ForeColor = Color.Black;
                }
                player = 'A';
            }
            ++movement;
        }
    }
}