
namespace Juego_Net4._7_Shooter_POO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ptbBoss = new System.Windows.Forms.PictureBox();
            this.ptbNave = new System.Windows.Forms.PictureBox();
            this.pgbVidaBoss = new System.Windows.Forms.ProgressBar();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tmrDisparosBoss = new System.Windows.Forms.Timer(this.components);
            this.pgbVidaNave = new System.Windows.Forms.ProgressBar();
            this.lblVidaNave = new System.Windows.Forms.Label();
            this.lblPerdiste = new System.Windows.Forms.Label();
            this.lblGanaste = new System.Windows.Forms.Label();
            this.lblPresionaEnter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNave)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbBoss
            // 
            this.ptbBoss.BackColor = System.Drawing.Color.Transparent;
            this.ptbBoss.Image = global::Juego_Net4._7_Shooter_POO.Properties.Resources.Boss;
            this.ptbBoss.Location = new System.Drawing.Point(320, 41);
            this.ptbBoss.Name = "ptbBoss";
            this.ptbBoss.Size = new System.Drawing.Size(191, 144);
            this.ptbBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBoss.TabIndex = 0;
            this.ptbBoss.TabStop = false;
            this.ptbBoss.Tag = "boss";
            // 
            // ptbNave
            // 
            this.ptbNave.BackColor = System.Drawing.Color.Transparent;
            this.ptbNave.Image = global::Juego_Net4._7_Shooter_POO.Properties.Resources.Nave;
            this.ptbNave.Location = new System.Drawing.Point(379, 433);
            this.ptbNave.Name = "ptbNave";
            this.ptbNave.Size = new System.Drawing.Size(72, 47);
            this.ptbNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNave.TabIndex = 1;
            this.ptbNave.TabStop = false;
            // 
            // pgbVidaBoss
            // 
            this.pgbVidaBoss.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pgbVidaBoss.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.pgbVidaBoss.Location = new System.Drawing.Point(12, 12);
            this.pgbVidaBoss.Name = "pgbVidaBoss";
            this.pgbVidaBoss.Size = new System.Drawing.Size(810, 23);
            this.pgbVidaBoss.TabIndex = 2;
            this.pgbVidaBoss.Value = 100;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 20;
            this.tmrMain.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // tmrDisparosBoss
            // 
            this.tmrDisparosBoss.Enabled = true;
            this.tmrDisparosBoss.Interval = 1000;
            this.tmrDisparosBoss.Tick += new System.EventHandler(this.tmrDisparosBoss_Tick);
            // 
            // pgbVidaNave
            // 
            this.pgbVidaNave.Location = new System.Drawing.Point(12, 380);
            this.pgbVidaNave.Name = "pgbVidaNave";
            this.pgbVidaNave.Size = new System.Drawing.Size(100, 23);
            this.pgbVidaNave.TabIndex = 4;
            // 
            // lblVidaNave
            // 
            this.lblVidaNave.AutoSize = true;
            this.lblVidaNave.BackColor = System.Drawing.Color.Transparent;
            this.lblVidaNave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidaNave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVidaNave.Location = new System.Drawing.Point(41, 364);
            this.lblVidaNave.Name = "lblVidaNave";
            this.lblVidaNave.Size = new System.Drawing.Size(36, 13);
            this.lblVidaNave.TabIndex = 5;
            this.lblVidaNave.Text = "VIDA";
            // 
            // lblPerdiste
            // 
            this.lblPerdiste.AutoSize = true;
            this.lblPerdiste.BackColor = System.Drawing.Color.Transparent;
            this.lblPerdiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerdiste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerdiste.Location = new System.Drawing.Point(144, 240);
            this.lblPerdiste.Name = "lblPerdiste";
            this.lblPerdiste.Size = new System.Drawing.Size(563, 42);
            this.lblPerdiste.TabIndex = 6;
            this.lblPerdiste.Text = "FELICITACIONES, PERDISTE.";
            // 
            // lblGanaste
            // 
            this.lblGanaste.AutoSize = true;
            this.lblGanaste.BackColor = System.Drawing.Color.Transparent;
            this.lblGanaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanaste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGanaste.Location = new System.Drawing.Point(144, 240);
            this.lblGanaste.Name = "lblGanaste";
            this.lblGanaste.Size = new System.Drawing.Size(555, 42);
            this.lblGanaste.TabIndex = 7;
            this.lblGanaste.Text = "FELICITACIONES, GANASTE.";
            // 
            // lblPresionaEnter
            // 
            this.lblPresionaEnter.AutoSize = true;
            this.lblPresionaEnter.BackColor = System.Drawing.Color.Transparent;
            this.lblPresionaEnter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPresionaEnter.Location = new System.Drawing.Point(332, 295);
            this.lblPresionaEnter.Name = "lblPresionaEnter";
            this.lblPresionaEnter.Size = new System.Drawing.Size(169, 13);
            this.lblPresionaEnter.TabIndex = 8;
            this.lblPresionaEnter.Text = "Presiona enter para jugar otra vez.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Juego_Net4._7_Shooter_POO.Properties.Resources.Espacio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 492);
            this.Controls.Add(this.lblPresionaEnter);
            this.Controls.Add(this.lblGanaste);
            this.Controls.Add(this.lblPerdiste);
            this.Controls.Add(this.lblVidaNave);
            this.Controls.Add(this.pgbVidaNave);
            this.Controls.Add(this.pgbVidaBoss);
            this.Controls.Add(this.ptbNave);
            this.Controls.Add(this.ptbBoss);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Juego";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbBoss;
        private System.Windows.Forms.PictureBox ptbNave;
        private System.Windows.Forms.ProgressBar pgbVidaBoss;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Timer tmrDisparosBoss;
        private System.Windows.Forms.ProgressBar pgbVidaNave;
        private System.Windows.Forms.Label lblVidaNave;
        private System.Windows.Forms.Label lblPerdiste;
        private System.Windows.Forms.Label lblGanaste;
        private System.Windows.Forms.Label lblPresionaEnter;
    }
}

