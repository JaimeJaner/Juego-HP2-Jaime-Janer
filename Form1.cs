using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace Juego_Net4._7_Shooter_POO
{
    public partial class Form1 : Form
    {
        // Creamos variables generales dentro del form.

        SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\Sonido\Gasolina1.wav");


        SoundPlayer bala;
        int vidaNave = 100, vidaBoss = 100, speed = 10, bossSpeed = 10, Score=0;
        int banderaBoss=0, banderaBoss2=1;
        bool gameOver;
        


        public Form1()
        {
            InitializeComponent();
            lblGanaste.Visible = false;
            lblPerdiste.Visible = false;
            lblPresionaEnter.Visible = false;

            try
            {

                sonido.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);

            }

        }
//Elegimos el evento del Timer principal del juego, que se va a encargar de ser el 
//Motor gráfico del mismo con su Evento "Tick"

        private void MainTimerEvent(object sender, EventArgs e)
        {
            int xBoss = ptbBoss.Location.X;

            /*Pone el valor de la vida del boss en la barra de progreso.*/
            if(vidaNave>1)
            {
                pgbVidaNave.Value = vidaNave;
            }
            else
            {
                pgbVidaNave.Value = 0;
                gameOver = true;
                tmrMain.Stop();
                tmrDisparosBoss.Stop();
                
                lblPerdiste.Visible = true;
                lblPresionaEnter.Visible = true;

                sonido.SoundLocation = (Application.StartupPath + @"\Sonido\Decepcion.wav");
                sonido.Play();

            }

            if (vidaBoss>1)
            {
                pgbVidaBoss.Value = vidaBoss;

                
                
            }
            else
            {
                pgbVidaBoss.Value = 0;
                gameOver = true;
                tmrMain.Stop();
                tmrDisparosBoss.Stop();
                lblGanaste.Visible = true;
                lblPresionaEnter.Visible = true;

                sonido.SoundLocation = (Application.StartupPath + @"\Sonido\Aguanta.wav");
                sonido.Play();

            }

            if (vidaBoss < 50)
            {
                ptbBoss.Image = Properties.Resources.BossHit;
                tmrMain.Interval = 5;
            }

            /*Crea un movimiento automático del Boss de izquierda a derecha por medio de banderas y límites.
             Es necesario mejorar el mecanismo para diferentes tamaños de pantallas.*/

            if (banderaBoss==0)
            {
                if (ptbBoss.Location.X > 0)
                {
                    ptbBoss.Location = new Point(xBoss - bossSpeed);
                    if (ptbBoss.Location.X==0)
                    {
                        banderaBoss = 1;
                        banderaBoss2 = 0;
                    }
                }
            }
            if(banderaBoss2==0)
            {
                if (ptbBoss.Left < 650)
                {
                    ptbBoss.Location = new Point(xBoss + bossSpeed);
                    if (ptbBoss.Left == 650)
                    {
                        banderaBoss = 0;
                        banderaBoss2 = 1;
                    }
                }
            }

            /*Realiza un foreach dentro del form que se encarga de encontrar todos los controles
             con tag "bullet" que son precisamente las balas, cuando las encuentra, las relaciona con el intercepto
            o la colisión con el Boss, de ser true, disminuye la vida.*/

            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && (string)j.Tag == "bullet")
                {
                    if (j.Bounds.IntersectsWith(ptbBoss.Bounds))
                    {
                        vidaBoss-=10;
                        
                        
                        /*Se elimina el objeto luego de haber interceptado, de lo contrario
                         si continua con su trayectoria, el timer volverá a ejecutar ésta "función" y 
                        seguirá "sumando puntos."*/
                        j.Dispose();
                        
                        
                    }
                }
            }

            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && (string)y.Tag == "bBoss")
                {
                    if (y.Bounds.IntersectsWith(ptbNave.Bounds))
                    {
                        vidaNave -= 35;
                                             
                        y.Dispose();


                    }
                }
            }





        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            /*Crea movimientos con restricciones dentro de la aplicación.*/
            if (e.KeyCode==Keys.Right && (ptbNave.Left + ptbNave.Width<this.ClientSize.Width)&& gameOver==false)
            {
                ptbNave.Left += speed;
            }

            if (e.KeyCode == Keys.Left && ptbNave.Left>0 && gameOver == false)
            {
                ptbNave.Left -= speed;
            }
            /*Al precionar espacio, ejecuta el método de Disparo.*/
            if (e.KeyCode == Keys.Space && gameOver == false)
            {
                ShootBullets();

                //try
                //{
                //    sonido.SoundLocation = (Application.StartupPath + @"\Sonido\Decepcion.mp3");
                //    sonido.Play();

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error: " + ex);

                //}


            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }


        }

        private void tmrDisparosBoss_Tick(object sender, EventArgs e)
        {
            ShootBulletsBoss();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        /*Éste método, crea un nuevo Objeto de la clase Bullets y envía los datos de posición a las variables
        ´públicas de la Clase.*/
        private void ShootBullets()
        {
            Bullets BulletsDisparos = new Bullets();
            BulletsDisparos.bulletLeft = ptbNave.Left +(ptbNave.Width / 2);
            BulletsDisparos.bulletTop = ptbNave.Top +(ptbNave.Height / 2);
            /*MakeBullet, se encarga de crear una bala como control.
             Éste método recibe un parámetro del tipo Form, o sea éste, y desde el método lo agrega.*/
            BulletsDisparos.MakeBullet(this);
        }

        private void ShootBulletsBoss()
        {
            /*Lo mismo del anterior, sólo que éste se encarga de las balas que ssalen disparadas por el Boss.*/
            BulletsBoss BulletsDisparosBoss = new BulletsBoss();
            BulletsDisparosBoss.bulletLeftBoss = ptbBoss.Left + (ptbBoss.Width / 2);
            BulletsDisparosBoss.bulletTopBoss = ptbBoss.Top + (ptbBoss.Height / 2);
            BulletsDisparosBoss.MakeBulletBoss(this);

           
        }

        private void RestartGame()
        {
            
            
            tmrMain.Start();
            tmrDisparosBoss.Start();
            gameOver = false;
            vidaBoss = 100;
            vidaNave = 100;
            ptbBoss.Image = Properties.Resources.Boss;
            lblGanaste.Visible = false;
            lblPerdiste.Visible = false;
            lblPresionaEnter.Visible = false;
            sonido.SoundLocation = (Application.StartupPath + @"\Sonido\Gasolina1.wav");
            sonido.PlayLooping();
            tmrMain.Interval = 20;


        }
    }
}
