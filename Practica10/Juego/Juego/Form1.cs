using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Juego.Properties;

namespace Juego
{
    public partial class Form1 : Form
    {
        int tiempo = 60;
        int puntos = 0;
        int dificultad = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Menue()
        {
            timer1.Stop();
            timer2.Stop();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            btnPausa.Visible = false;
            btnContinuar.Visible = false;
            btnMenu.Visible = false;
            btnExperto.Visible = true;
            btnGamer.Visible = true;
            btnNovato.Visible = true;
            btnSalir.Visible = true;

        }
        private void Continuar()
        {
            if (dificultad == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (dificultad == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }
            else if (dificultad == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
            ObjetoVolador();

        }
        private void ObjetoVolador()
        {
            Random position = new Random();
            if (dificultad == 1)
            {
                pictureBox1.Location = new Point(position.Next(915), position.Next(530));
            }
            else if (dificultad == 2)
            {
                pictureBox1.Location = new Point(position.Next(915), position.Next(530));
                pictureBox2.Location = new Point(position.Next(915), position.Next(530));
            }
            else if (dificultad == 3)
            {
                pictureBox1.Location = new Point(position.Next(915), position.Next(530));
                pictureBox2.Location = new Point(position.Next(915), position.Next(530));
                pictureBox3.Location = new Point(position.Next(915), position.Next(530));
            }
        }

        private void Empezar(int type)
        {
            btnPausa.Visible = true;
            timer1.Start();
            timer2.Start();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            btnExperto.Visible = false;
            btnGamer.Visible = false;
            btnNovato.Visible = false;
            btnSalir.Visible = false;
            if (type == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                timer2.Interval = 1250;
            }
            else if (type == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                timer2.Interval = 950;
            }
            else if (type == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                timer2.Interval = 650;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo == 0)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Tu puntuación es: " + puntos, "TIEMPO TERMINADO",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                puntos = 0;
                tiempo = 60;

                label1.Text = "Tiempo: " + tiempo;
                label2.Text = "Puntuación: " + puntos;

                timer1.Start();
                timer2.Start();

            }
            else
            {
                tiempo = tiempo - 1;
                label1.Text = "Tiempo: " + tiempo;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.pato;
            pictureBox2.Image = Resources.pato;
            pictureBox3.Image = Resources.pato;
            ObjetoVolador();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Menue();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            this.Close();
        }

        private void btnNovato_Click(object sender, EventArgs e)
        {
            dificultad = 1;
            Empezar(1);
        }

        private void btnGamer_Click(object sender, EventArgs e)
        {
            dificultad = 2;
            Empezar(2);
        }

        private void btnExperto_Click(object sender, EventArgs e)
        {
            dificultad = 3;
            Empezar(3);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            puntos = puntos + 1;
            label2.Text = "Puntos: " + puntos;
            pictureBox3.Image = Resources.pato2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            puntos = puntos + 1;
            label2.Text = "Puntos: " + puntos;
            pictureBox2.Image = Resources.pato2;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            puntos = puntos + 1;
            label2.Text = "Puntos: " + puntos;
            pictureBox1.Image = Resources.pato2;
        }
        private void btnPausa_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label3.Visible = true;
            btnMenu.Visible = true;
            btnContinuar.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("Tu puntuación es: " + puntos, "TIEMPO TERMINADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            puntos = 0;
            tiempo = 60;
            Menue();
           
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            btnContinuar.Visible = false;
            btnMenu.Visible = false;
            timer1.Start();
            timer2.Start();
            label1.Visible = true;
            label2.Visible = true;
            Continuar();
        }
    }
}
