namespace ManejoDatos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLibrosPorAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLibroPorISBN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLibrosPorNacionalidad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatos,
            this.mnuReportes});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(610, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuDatos
            // 
            this.mnuDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCategorias,
            this.mnuProductos,
            this.mnuSeparador,
            this.mnuSalir});
            this.mnuDatos.Name = "mnuDatos";
            this.mnuDatos.Size = new System.Drawing.Size(49, 20);
            this.mnuDatos.Text = "&Datos";
            // 
            // mnuCategorias
            // 
            this.mnuCategorias.Name = "mnuCategorias";
            this.mnuCategorias.Size = new System.Drawing.Size(115, 22);
            this.mnuCategorias.Text = "&Autores";
            this.mnuCategorias.Click += new System.EventHandler(this.mnuAutores_Click);
            // 
            // mnuProductos
            // 
            this.mnuProductos.Name = "mnuProductos";
            this.mnuProductos.Size = new System.Drawing.Size(115, 22);
            this.mnuProductos.Text = "&Libros";
            this.mnuProductos.Click += new System.EventHandler(this.mnuLibros_Click);
            // 
            // mnuSeparador
            // 
            this.mnuSeparador.Name = "mnuSeparador";
            this.mnuSeparador.Size = new System.Drawing.Size(112, 6);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(115, 22);
            this.mnuSalir.Text = "&Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLibrosPorAutor,
            this.mnuLibroPorISBN,
            this.mnuLibrosPorNacionalidad});
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(65, 20);
            this.mnuReportes.Text = "&Reportes";
            // 
            // mnuLibrosPorAutor
            // 
            this.mnuLibrosPorAutor.Name = "mnuLibrosPorAutor";
            this.mnuLibrosPorAutor.Size = new System.Drawing.Size(434, 22);
            this.mnuLibrosPorAutor.Text = "&Dado un autor mostrar los libros escritos por año";
            this.mnuLibrosPorAutor.Click += new System.EventHandler(this.mnuLibrosPorAutor_Click);
            // 
            // mnuLibroPorISBN
            // 
            this.mnuLibroPorISBN.Name = "mnuLibroPorISBN";
            this.mnuLibroPorISBN.Size = new System.Drawing.Size(434, 22);
            this.mnuLibroPorISBN.Text = "Dad&o un ISBN mostrar el libro correspondiente";
            this.mnuLibroPorISBN.Click += new System.EventHandler(this.mnuLibroPorISBN_Click);
            // 
            // mnuLibrosPorNacionalidad
            // 
            this.mnuLibrosPorNacionalidad.Name = "mnuLibrosPorNacionalidad";
            this.mnuLibrosPorNacionalidad.Size = new System.Drawing.Size(434, 22);
            this.mnuLibrosPorNacionalidad.Text = "Dado &un país listar los libros escritos por autores de esa nacionalidad";
            this.mnuLibrosPorNacionalidad.Click += new System.EventHandler(this.mnuLibrosPorNacionalidad_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 449);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de una Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuDatos;
        private System.Windows.Forms.ToolStripMenuItem mnuCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuProductos;
        private System.Windows.Forms.ToolStripSeparator mnuSeparador;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuLibrosPorAutor;
        private System.Windows.Forms.ToolStripMenuItem mnuLibroPorISBN;
        private System.Windows.Forms.ToolStripMenuItem mnuLibrosPorNacionalidad;
    }
}