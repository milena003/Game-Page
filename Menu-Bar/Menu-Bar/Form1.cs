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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            label1.FlatStyle = FlatStyle.Flat;
            label1.BackColor = Color.Transparent;
           
            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button5.FlatStyle = FlatStyle.Flat;
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button6.FlatStyle = FlatStyle.Flat;
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button7.FlatStyle = FlatStyle.Flat;
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;

            welcome.Parent = mainMenu;
            welcome.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tic_Tac_Toe ttt = new Tic_Tac_Toe();
            ttt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Flappy_Bird fp = new Flappy_Bird();
            fp.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Snake sn = new Snake();
            sn.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zombie_Killer zk = new Zombie_Killer();
            zk.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Space_Invaders sp = new Space_Invaders();
            sp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SpaceShooter ss = new SpaceShooter();
            ss.Show();
        }
    }
}