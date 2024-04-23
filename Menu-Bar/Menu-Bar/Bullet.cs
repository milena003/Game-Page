using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Menu_Bar
{
    internal class Bullet
    {
        public string direction;
        public int BullletLeft;
        public int BullletTop;


        public int bulletSpeed = 20;
        PictureBox bullet = new PictureBox();
        Timer bulletTime = new Timer();

        public void MakeBullet (Form form)
        {
            bullet.BackColor = Color.Yellow;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = BullletLeft;
            bullet.Top = BullletTop;
            bullet.BringToFront();  

            form.Controls.Add(bullet);

            bulletTime.Interval = bulletSpeed;
            bulletTime.Tick += new EventHandler(BulletTimerEvent);
            bulletTime.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                bullet.Left -= bulletSpeed;
            }

            if (direction == "right")
            {
                bullet.Left += bulletSpeed;
            }

            if (direction == "up")
            {
                bullet.Top -= bulletSpeed;
            }

            if (direction == "down")
            {
                bullet.Top += bulletSpeed;
            }

            if (bullet.Left < 10 || bullet.Left > 860 || bullet.Top < 10 || bullet.Top > 600)
            {
                bulletTime.Stop();
                bulletTime.Dispose();
                bulletTime = null;

                bullet.Dispose();
                bullet = null;
            }
        }
    }
}