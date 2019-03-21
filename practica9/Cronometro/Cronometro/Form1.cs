using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        int minutos = 0;
        string mostrarMinutos = "00";
        int segundos = 0;
        string mostrarSegundos="00";
        int horas = 0;
        string mostrarHoras = "00";
   
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                timer1.Start();
                btnIniciar.Text = "Pausar";
            }
            else
            {
                timer1.Stop();
                btnIniciar.Text = "Iniciar";
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnIniciar.Text = "Iniciar";
            label2.Text = "00 : 00 : 00";
            segundos = minutos = horas = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
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

            label2.Text = mostrarHoras + " : " + mostrarMinutos + " : " + mostrarSegundos;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
