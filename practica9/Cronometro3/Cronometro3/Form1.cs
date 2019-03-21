using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro3
{
    public partial class Form1 : Form
    {
        int milSegundos = 0;
        string mostrarMilSegundos = "00";
        int segundos = 0;
        string mostrarSegundos = "00";
        int minutos = 0;
        string mostrarMinutos = "00";
        int horas = 0;
        string mostrarHoras = "00";
        int dias = 0;
        string mostrarDias = "00";
        int semanas = 0;
        string mostrarSemanas = "00";
        string alarma;
        string intervalo;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            alarma = string.Empty;

        }

        private void btnAlarma_Click(object sender, EventArgs e)
        {
            if (txtAlarma.Text == string.Empty || cmbIntervalo.Text == string.Empty)
            {
                MessageBox.Show("Debes establecer un tiempo de alarma");
            }
            else
            {
                switch (cmbIntervalo.SelectedItem.ToString())
                {

                    case "semanas":
                        if (txtAlarma.Text.Length == 1)
                        {
                            alarma = "0" + txtAlarma.Text + " : 00 : 00 : 00 : 00 : 00";
                        }
                        else
                        {
                            alarma = txtAlarma.Text + " : 00 : 00 : 00 : 00 : 00";
                        }
                        intervalo = txtAlarma.Text + " semanas";
                        break;
                    case "dias":
                        if (txtAlarma.Text.Length == 1)
                        {
                            alarma = "00 : 0" + txtAlarma.Text + " : 00 : 00 : 00 : 00";
                        }
                        else
                        {
                            alarma = "00 : " + txtAlarma.Text + " : 00 : 00 : 00 : 00";
                        }
                        intervalo = txtAlarma.Text + " días";
                        break;
                    case "horas":
                        if (txtAlarma.Text.Length == 1)
                        {
                            alarma = "00 : 00: 0" + txtAlarma.Text + " : 00 : 00 : 00";
                        }
                        else
                        {
                            alarma = "00 : 00 : " + txtAlarma.Text + " : 00 : 00 : 00";
                        }
                        intervalo = txtAlarma.Text + " horas";
                        break;
                    case "minutos":
                        if (txtAlarma.Text.Length == 1)
                        {
                            alarma = "00 : 00 : 00 : 0" + txtAlarma.Text + " : 00 : 00";
                        }
                        else
                        {
                            alarma = "00 : 00 : 00 : " + txtAlarma.Text + " : 00 : 00";
                        }
                        intervalo = txtAlarma.Text + " minutos";
                        break;
                    case "segundos":
                        if (txtAlarma.Text.Length == 1)
                        {
                            alarma = "00 : 00 : 00 : 00 : 0" + txtAlarma.Text + " : 00";
                        }
                        else
                        {
                            alarma = "00 : 00 : 00 : 00 : " + txtAlarma.Text + " : 00";
                        }
                        intervalo = txtAlarma.Text + " segundos";
                        break;
                }
                label8.Visible = true;
                label8.Text = "La alarma se estableció " + intervalo + " después del inicio";
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
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
            btnIniciar.Text = "Iniciar";
            label8.Visible = false;
            txtAlarma.Text = string.Empty;
            cmbIntervalo.Text = "";
            timer1.Stop();
            label1.Text = "00 : 00 : 00 : 00 : 00 : 00";
            milSegundos = segundos = minutos = horas = dias = semanas = 0;
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
                        if (horas == 23)
                        {
                            horas = 0;
                            dias = dias + 1;
                            if (dias == 7)
                            {
                                dias = 0;
                                semanas = semanas + 1;
                            }
                            else
                            {
                                dias = dias + 1;
                            }
                        }
                        else
                        {
                            horas = horas + 1;
                        }
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
            if (dias == 0 || dias == 1 || dias == 2 || dias == 3 || dias == 4 || dias == 5 || dias == 6 || dias == 7 || dias == 8 || dias == 9)
            {
                mostrarDias = "0" + dias;
            }
            else
            {
                mostrarDias = dias.ToString();
            }
            if (semanas == 0 || semanas == 1 || semanas == 2 || semanas == 3 || semanas == 4 || semanas == 5 || semanas == 6 || semanas == 7 || semanas == 8 || semanas == 9)
            {
                mostrarSemanas = "0" + semanas;
            }
            else
            {
                mostrarSemanas = semanas.ToString();
            }

            label1.Text = mostrarSemanas+" : "+mostrarDias+" : "+mostrarHoras + " : " + mostrarMinutos + " : " + mostrarSegundos + " : " + mostrarMilSegundos;
            if (label1.Text == alarma)
            {
                MessageBox.Show("Se alcanzó el tiempo de ALARMA","!ALARMA!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
