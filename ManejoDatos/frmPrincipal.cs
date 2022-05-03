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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAutores_Click(object sender, EventArgs e)
        {
            frmAutor frm = frmAutor.Crear(this);

            frm.Show();
            frm.BringToFront();
        }

        private void mnuLibros_Click(object sender, EventArgs e)
        {
            frmLibro frm = frmLibro.Crear(this);

            frm.Show();
            frm.BringToFront();
        }

        private void mnuLibrosPorAutor_Click(object sender, EventArgs e)
        {
            frmListadoLibrosPorAutor frm = frmListadoLibrosPorAutor.Crear(this);

            frm.Show();
            frm.BringToFront();
        }

        private void mnuLibroPorISBN_Click(object sender, EventArgs e)
        {
            frmListadoLibrosPorISBN frm = frmListadoLibrosPorISBN.Crear(this);

            frm.Show();
            frm.BringToFront();
        }

        private void mnuLibrosPorNacionalidad_Click(object sender, EventArgs e)
        {
            frmListadoLibrosPorNacionalidad frm = frmListadoLibrosPorNacionalidad.Crear(this);

            frm.Show();
            frm.BringToFront();
        }
    }
}
