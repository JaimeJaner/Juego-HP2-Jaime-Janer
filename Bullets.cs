using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Juego_Net4._7_Shooter_POO
{/*Clase Bullets, que se encarga de crear nuevas balas.*/
    class Bullets
    {
        /*Crea variables publicas para poder acceder a los métodos privados de las clases 
         por motivos de encapsulamiento.*/
        public int bulletLeft;
        public int bulletTop;

        /*Crea variables privadas y objetos.*/
        private int Speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        /*Recibe un formulario como argumento. Dentro del método, le da características 
         al objeto creado anteriormente. Finalmente, lo añade al formulario recibido, cada vez que es ejecutado, 
        AÑADE un instanciamiento del evento TICK para que las balas continuen su trayectoria como objetos únicos.*/
        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.White;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = Speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        /*Éste es el evento del Timer que va a ejecutar cada bala puesta en el escenario.*/
        private void BulletTimerEvent (object sender, EventArgs e)
        {
            /*Desplaza a la bala en dirección superior con la velocidad establecida globalmente en ésta clase.*/
            bullet.Top -= Speed;
            /*En caso de que la bala atraviese cierto umbral en el cliente, se destruye y desaparece del form.*/


            if(bullet.Top<10)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
      
            }


            

        }

        //public void ElimineBala()
        //{
        //    bulletTimer.Stop();
        //    bulletTimer.Dispose();
        //    bullet.Dispose();
        //    bulletTimer = null;
        //    bullet = null;
        //}

    }
}
