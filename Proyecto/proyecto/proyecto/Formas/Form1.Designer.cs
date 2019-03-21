namespace proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rchtxtEditor = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombreArchivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcantidadLineas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcantidadPalabras = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem,
            this.adelanteToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.seleccionarTodoToolStripMenuItem,
            this.borrarTodoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.atrasToolStripMenuItem.Text = "Deshacer";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // adelanteToolStripMenuItem
            // 
            this.adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            this.adelanteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.adelanteToolStripMenuItem.Text = "Rehacer";
            this.adelanteToolStripMenuItem.Click += new System.EventHandler(this.adelanteToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // borrarTodoToolStripMenuItem
            // 
            this.borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            this.borrarTodoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.borrarTodoToolStripMenuItem.Text = "Borrar todo";
            this.borrarTodoToolStripMenuItem.Click += new System.EventHandler(this.borrarTodoToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem1,
            this.colorDeFuenteToolStripMenuItem});
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // fuenteToolStripMenuItem1
            // 
            this.fuenteToolStripMenuItem1.Name = "fuenteToolStripMenuItem1";
            this.fuenteToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.fuenteToolStripMenuItem1.Text = "Fuente";
            this.fuenteToolStripMenuItem1.Click += new System.EventHandler(this.fuenteToolStripMenuItem1_Click);
            // 
            // colorDeFuenteToolStripMenuItem
            // 
            this.colorDeFuenteToolStripMenuItem.Name = "colorDeFuenteToolStripMenuItem";
            this.colorDeFuenteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.colorDeFuenteToolStripMenuItem.Text = "Color de fuente";
            this.colorDeFuenteToolStripMenuItem.Click += new System.EventHandler(this.colorDeFuenteToolStripMenuItem_Click);
            // 
            // rchtxtEditor
            // 
            this.rchtxtEditor.AutoWordSelection = true;
            this.rchtxtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtEditor.HideSelection = false;
            this.rchtxtEditor.Location = new System.Drawing.Point(0, 24);
            this.rchtxtEditor.Name = "rchtxtEditor";
            this.rchtxtEditor.Size = new System.Drawing.Size(736, 346);
            this.rchtxtEditor.TabIndex = 1;
            this.rchtxtEditor.Text = "";
            this.rchtxtEditor.TextChanged += new System.EventHandler(this.rchtxtEditor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abierto: ";
            // 
            // lblnombreArchivo
            // 
            this.lblnombreArchivo.AutoSize = true;
            this.lblnombreArchivo.Location = new System.Drawing.Point(55, 356);
            this.lblnombreArchivo.Name = "lblnombreArchivo";
            this.lblnombreArchivo.Size = new System.Drawing.Size(16, 13);
            this.lblnombreArchivo.TabIndex = 3;
            this.lblnombreArchivo.Text = "- -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lineas:";
            // 
            // lblcantidadLineas
            // 
            this.lblcantidadLineas.AutoSize = true;
            this.lblcantidadLineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadLineas.Location = new System.Drawing.Point(567, 356);
            this.lblcantidadLineas.Name = "lblcantidadLineas";
            this.lblcantidadLineas.Size = new System.Drawing.Size(14, 13);
            this.lblcantidadLineas.TabIndex = 5;
            this.lblcantidadLineas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Palabras:";
            // 
            // lblcantidadPalabras
            // 
            this.lblcantidadPalabras.AutoSize = true;
            this.lblcantidadPalabras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadPalabras.Location = new System.Drawing.Point(659, 356);
            this.lblcantidadPalabras.Name = "lblcantidadPalabras";
            this.lblcantidadPalabras.Size = new System.Drawing.Size(14, 13);
            this.lblcantidadPalabras.TabIndex = 7;
            this.lblcantidadPalabras.Text = "0";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(624, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Salmon;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(562, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 20);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar:";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 370);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblcantidadPalabras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcantidadLineas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnombreArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchtxtEditor);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adelanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorDeFuenteToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rchtxtEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombreArchivo;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcantidadLineas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcantidadPalabras;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}

