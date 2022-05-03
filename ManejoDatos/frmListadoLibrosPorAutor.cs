using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDatos
{
    public partial class frmListadoLibrosPorAutor : Form
    {

        #region "Singleton"

        private static frmListadoLibrosPorAutor frm;

        private frmListadoLibrosPorAutor()
        {
            InitializeComponent();
        }

        public static frmListadoLibrosPorAutor Crear(Form padre)
        {
            if (frmListadoLibrosPorAutor.frm == null)
            {
                frmListadoLibrosPorAutor.frm = new frmListadoLibrosPorAutor();
                frm.MdiParent = padre;
                frm.WindowState = FormWindowState.Maximized;
            }

            return frmListadoLibrosPorAutor.frm;
        }

        private void frmListadoLibrosPorAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmListadoLibrosPorAutor.frm = null;
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoProductos_Load(object sender, EventArgs e)
        {
            this.CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            this.CargarAutores();
        }

        private void CargarAutores()
        {
            this.cboAutor.DataSource = null;
            if (Program.Autores.Count > 0)
            {
                this.cboAutor.DataSource = Program.Autores;
                this.cboAutor.DisplayMember = "NombreCompleto";
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Libro> libros;

            libros = this.Filtrar(this.cboAutor.Text);
            libros = Ordenar(libros);
            this.dgvListado.DataSource = null;
            if (libros.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = libros;
            }
        }

        private List<Libro> Ordenar(List<Libro> libros)
        {
            var librosOrdenados = libros.OrderBy(x => x.Año).ToList();

            return librosOrdenados;
        }

        private List<Libro> Filtrar(string nombreAutor)
        {
            List<Libro> libros;

            libros = new List<Libro>();
            foreach (var libr in Program.Libros)
            {
                if ( libr.Autor.NombreCompleto.Equals(nombreAutor) == true)
                {
                    libros.Add(libr);
                }
            }
            return libros;
        }

    }
}
