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
    public partial class frmListadoLibrosPorISBN : Form
    {

        #region "Singleton"

        private static frmListadoLibrosPorISBN frm;

        private frmListadoLibrosPorISBN()
        {
            InitializeComponent();
        }

        public static frmListadoLibrosPorISBN Crear(Form padre)
        {
            if (frmListadoLibrosPorISBN.frm == null)
            {
                frmListadoLibrosPorISBN.frm = new frmListadoLibrosPorISBN();
                frm.MdiParent = padre;
                frm.WindowState = FormWindowState.Maximized;
            }

            return frmListadoLibrosPorISBN.frm;
        }

        private void frmListadoLibroPorISBN_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmListadoLibrosPorISBN.frm = null;
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

            libros = this.Filtrar(this.txtISBN.Text);
            this.dgvListado.DataSource = null;
            if (libros.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = libros;
            }
        }

        private List<Libro> Filtrar(string ISBN)
        {
            List<Libro> libros;

            libros = new List<Libro>();
            foreach (var libr in Program.Libros)
            {
                if ( libr.ISBN.Equals(ISBN) == true)
                {
                    libros.Add(libr);
                }
            }
            return libros;
        }

    }
}
