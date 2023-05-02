using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Juego_Net4._7_Shooter_POO
{
    class BulletsBoss
    {

        public int bulletLeftBoss;
        public int bulletTopBoss;

        private int Speed = 20;
        private PictureBox bulletBoss = new PictureBox();
        private Timer bulletTimerBoss = new Timer();

        public void MakeBulletBoss(Form form)
        {
            bulletBoss.BackColor = Color.White;
            bulletBoss.Size = new Size(5, 5);
            bulletBoss.Tag = "bBoss";
            bulletBoss.Left = bulletLeftBoss;
            bulletBoss.Top = bulletTopBoss;
            bulletBoss.BringToFront();

            form.Controls.Add(bulletBoss);

            bulletTimerBoss.Interval = Speed;
            bulletTimerBoss.Tick += new EventHandler(BulletTimerEventBoss);
            bulletTimerBoss.Start();
        }

        private void BulletTimerEventBoss(object sender, EventArgs e)
        {

            bulletBoss.Top += Speed;

            if (bulletBoss.Top > 550)
            {
                bulletTimerBoss.Stop();
                bulletTimerBoss.Dispose();
                bulletBoss.Dispose();
                bulletTimerBoss = null;
                bulletBoss = null;
                
            }

            

        }
    }
}
