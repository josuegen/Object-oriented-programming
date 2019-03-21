using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace proyecto
{
    public partial class Form1 : Form
    {
        contadordePalabras contador = new contadordePalabras();
        private int palabras = 0;
        private int lineas = 0;
        private string textoCompleto;
        int indiceInicio = 0;
        int largoDePalabra = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchtxtEditor.Clear();
            lblnombreArchivo.Text = "- -";
            txtBuscar.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            OpenFileDialog abrir = new OpenFileDialog();
            StreamReader lector = null;
            abrir.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*";
            abrir.CheckFileExists = true;
            abrir.Title = "Abrir Archivo";
            abrir.ShowDialog(this);
            try
            {

                abrir.OpenFile();
                lblnombreArchivo.Text = abrir.FileName;
                lector = File.OpenText(abrir.FileName);
                rchtxtEditor.Text = lector.ReadToEnd();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: " + e, "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchtxtEditor.Undo();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchtxtEditor.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchtxtEditor.Copy();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchtxtEditor.Cut();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchtxtEditor.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchtxtEditor.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchtxtEditor.Clear();
        }

        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();
            fuente.Font = rchtxtEditor.Font;
            if (fuente.ShowDialog() == DialogResult.OK)
            {
                rchtxtEditor.Font = fuente.Font;
            }
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                rchtxtEditor.ForeColor = color.Color;
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            StreamWriter grabador = null;
            guardar.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|All files(*.*)|*.*";
            guardar.CheckPathExists = true;
            guardar.Title = "Guardar como";
            guardar.ShowDialog(this);
            try
            {
                grabador = File.AppendText(guardar.FileName);
                grabador.Write(rchtxtEditor.Text);
                lblnombreArchivo.Text = guardar.FileName;
                grabador.Flush();

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: " + e, "Error al guardar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rchtxtEditor_TextChanged(object sender, EventArgs e)
        {
            lineas = rchtxtEditor.Lines.Length;
            lblcantidadLineas.Text = lineas.ToString();
            textoCompleto = rchtxtEditor.Text;
            palabras = contador.cantidadDePalabras(textoCompleto);
            lblcantidadPalabras.Text = palabras.ToString();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            indiceInicio = rchtxtEditor.Find(txtBuscar.Text);
            largoDePalabra = txtBuscar.Text.Length;
            rchtxtEditor.Select(indiceInicio, largoDePalabra);
        }
    }
}
