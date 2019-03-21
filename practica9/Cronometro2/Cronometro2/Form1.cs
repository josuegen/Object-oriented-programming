using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro2
{
    public partial class Form1 : Form
    {
        int minutos = 0;
        string mostrarMinutos = "00";
        int segundos = 0;
        string mostrarSegundos = "00";
        int horas = 0;
        string mostrarHoras = "00";
        int milSegundos = 0;
        string mostrarMilSegundos = "00";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "00 : 00 : 00 : 00";
            milSegundos = segundos = minutos = horas = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (milSegundos == 59)
            {
                milSegundos = 0;
                if (segundos == 59)
                {
                    segundos = 0;
                    if (minutos == 59)
                    {
                        minutos = 0;
                        horas = horas + 1;
                    }
                    else
                    {
                        minutos = minutos + 1;
                    }
                }
                else
                {
                    segundos = segundos + 1;
                }
            }
            else
            {
                milSegundos = milSegundos + 1;
            }
            if (milSegundos == 0 || milSegundos == 1 || milSegundos == 2 || milSegundos == 3 || milSegundos == 4 || milSegundos == 5 || milSegundos == 6 || milSegundos == 7 || milSegundos == 8 || milSegundos == 9)
            {
                mostrarMilSegundos = "0" + milSegundos;
            }
            else
            {
                mostrarMilSegundos = milSegundos.ToString();
            }
            if (segundos == 0 || segundos == 1 || segundos == 2 || segundos == 3 || segundos == 4 || segundos == 5 || segundos == 6 || segundos == 7 || segundos == 8 || segundos == 9)
            {
                mostrarSegundos = "0" + segundos;
            }
            else
            {
                mostrarSegundos = segundos.ToString();
            }
            if (minutos == 0 || minutos == 1 || minutos == 2 || minutos == 3 || minutos == 4 || minutos == 5 || minutos == 6 || minutos == 7 || minutos == 8 || minutos == 9)
            {
                mostrarMinutos = "0" + minutos;
            }
            else
            {
                mostrarMinutos = minutos.ToString();
            }
            if (horas == 0 || horas == 1 || horas == 2 || horas == 3 || horas == 4 || horas == 5 || horas == 6 || horas == 7 || horas == 8 || horas == 9)
            {
                mostrarHoras = "0" + horas;
            }
            else
            {
                mostrarHoras = horas.ToString();
            }

            label1.Text = mostrarHoras + " : " + mostrarMinutos + " : " + mostrarSegundos+" : "+mostrarMilSegundos;
        }
    }
}
