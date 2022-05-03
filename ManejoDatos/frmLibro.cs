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
    public partial class frmLibro : Form
    {
        private Libro Actual;

        #region "Singleton"

        private static frmLibro frm;

        private frmLibro()
        {
            InitializeComponent();
        }

        public static frmLibro Crear(Form padre)
        {
            if (frmLibro.frm == null)
            {
                frmLibro.frm = new frmLibro();
                frm.MdiParent = padre;
                frm.WindowState = FormWindowState.Maximized;
            }

            return frmLibro.frm;
        }

        private void frmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLibro.frm = null;
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
            this.LimpiarControles();
            this.Actual = null;
        }

        private void LimpiarControles()
        {
            this.txtISBN.Text = "";
            this.txtTitulo.Text = "";
            this.cboAutor.SelectedIndex = -1;
            this.txtPais.Text = "";
            this.nudAño.Value = this.nudAño.Minimum;
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void ActivarControles(bool estado)
        {
            this.gbEntidad.Enabled = estado;
            this.gbListado.Enabled = !estado;
            if (estado == true)
            {
                this.txtISBN.Focus();
            }
            else
            {
                this.txtLibro.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            this.CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            this.CargarCategorias();
        }

        private void CargarCategorias()
        {
            this.cboAutor.DataSource = null;
            if (Program.Autores.Count > 0)
            {
                this.cboAutor.DataSource = Program.Autores;
                this.cboAutor.DisplayMember = "NombreCompleto";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Libro libro;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    libro = new Libro();
                    Program.Libros.Add(libro);
                    libro.Codigo = Program.Libros.Count;
                }
                else
                {
                    libro = this.Actual;
                }
                
                libro.ISBN = this.txtISBN.Text;
                libro.Titulo = this.txtTitulo.Text;
                libro.Autor = (Autor)this.cboAutor.SelectedItem;
                libro.Pais = this.txtPais.Text;
                libro.Año = (int)this.nudAño.Value;
                libro.Vigente = this.chkVigente.Checked;
                this.ActivarControles(false);
                this.btnListar.PerformClick();
                this.AutoValidate = AutoValidate.Disable;
            }
            else
            {
                this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Libro> productos;

            productos = this.Filtrar(this.txtLibro.Text);
            this.dgvListado.DataSource = null;
            if (productos.Count > 0){
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = productos;
            }
        }
        private List<Libro> Filtrar(string nombreBuscar)
        {
            List<Libro> productos ;

            if (string.IsNullOrEmpty(nombreBuscar) == true)
            {
                return Program.Libros;
            }

            productos = new List<Libro>();
            foreach (var libr in Program.Libros){
                if ( libr.Titulo.Length >= nombreBuscar.Length 
                        && libr.Titulo.Substring(0, nombreBuscar.Length).Equals(nombreBuscar) == true){
                    
                    productos.Add(libr);
                }
            }
            return productos;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Libro)(this.dgvListado.CurrentRow.DataBoundItem);
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            this.txtISBN.Text = this.Actual.ISBN;
            this.txtTitulo.Text = this.Actual.Titulo;
            this.cboAutor.SelectedItem = this.Actual.Autor;
            this.txtPais.Text = this.Actual.Pais;
            this.nudAño.Value = this.Actual.Año;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.chkVigente.Enabled = true;
            this.ActivarControles(true);
        }

        private void cboCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboAutor.SelectedIndex > -1)
            {
                this.errError.SetError(this.cboAutor, "");
            }
            else
            {
                this.errError.SetError(this.cboAutor, "Debe seleccionar un Autor");
                e.Cancel = true;
            }
        }

        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {
            if (isbnUnico(this.txtISBN.Text) || (this.Actual != null && this.Actual.ISBN.Equals(txtISBN.Text)))
            {
                this.errError.SetError(this.txtISBN, "");
            }
            else
            {
                this.errError.SetError(this.txtISBN, "EL ISBN se repite");
                e.Cancel = true;
                return;
            }

            if (string.IsNullOrEmpty(this.txtISBN.Text) == false)
            {
                this.errError.SetError(this.txtISBN, "");
            }
            else
            {
                this.errError.SetError(this.txtISBN, "Debe indicar el ISBN");
                e.Cancel = true;
                return;
            }
        }

        private bool isbnUnico(string isbn)
        {
            foreach (var libr in Program.Libros)
            {
                if (libr.ISBN.Equals(isbn) == true)
                {
                    return false;
                }
            }

            return true;
        }

        private void txtTitulo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtTitulo.Text) == false)
            {
                this.errError.SetError(this.txtTitulo, "");
            }
            else
            {
                this.errError.SetError(this.txtTitulo, "Debe indicar el titulo");
                e.Cancel = true;
            }
        }

        private void txtPais_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPais.Text) == false)
            {
                this.errError.SetError(this.txtPais, "");
            }
            else
            {
                this.errError.SetError(this.txtPais, "Debe indicar el pais");
                e.Cancel = true;
            }
        }

    }
}
