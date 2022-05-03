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
    public partial class frmListadoLibrosPorNacionalidad : Form
    {

        #region "Singleton"

        private static frmListadoLibrosPorNacionalidad frm;

        private frmListadoLibrosPorNacionalidad()
        {
            InitializeComponent();
        }

        public static frmListadoLibrosPorNacionalidad Crear(Form padre)
        {
            if (frmListadoLibrosPorNacionalidad.frm == null)
            {
                frmListadoLibrosPorNacionalidad.frm = new frmListadoLibrosPorNacionalidad();
                frm.MdiParent = padre;
                frm.WindowState = FormWindowState.Maximized;
            }

            return frmListadoLibrosPorNacionalidad.frm;
        }

        private void frmListadoLibroPorNacionalidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmListadoLibrosPorNacionalidad.frm = null;
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoProductos_Load(object sender, EventArgs e)
        {
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Libro> libros;

            libros = this.Filtrar(this.txtPais.Text);
            this.dgvListado.DataSource = null;
            if (libros.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = libros;
            }
        }

        private List<Libro> Filtrar(string pais)
        {
            List<Libro> libros;

            libros = new List<Libro>();
            foreach (var libr in Program.Libros)
            {
                if (libr.Autor.Nacionalidad.Equals(pais) == true || libr.Autor.Nacionalidad.Substring(0, 2).Equals(pais.Substring(0, 2)) == true)
                {
                    libros.Add(libr);
                }
            }
            return libros;
        }

    }
}
