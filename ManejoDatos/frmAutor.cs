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
    public partial class frmAutor : Form
    {

        #region "Singleton"

        private static frmAutor frm;

        private frmAutor()
        {
            InitializeComponent();
        }

        public static frmAutor Crear(Form padre)
        {
            if (frmAutor.frm == null)
            {
                frmAutor.frm = new frmAutor();
                frmAutor.frm.MdiParent = padre;
                frmAutor.frm.WindowState = FormWindowState.Maximized;
            }

            return frmAutor.frm;
        }

        private void frmCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAutor.frm = null;
        }

        #endregion

        private Autor Actual;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.ActivarControles(true);
            this.LimpiarControles();
            this.Actual = null;
        }

        private void ActivarControles(bool p)
        {
            this.gbEntidad.Enabled = p;
            this.gbListado.Enabled = !p;
            if (p == true)
            {
                this.txtNombre.Focus();
            }
            else
            {
                this.btnListar.Focus();
            }

        }

        private void LimpiarControles()
        {
            this.txtNombre.Text = "";
            this.txtApellidoPaterno.Text = "";
            this.txtApellidoMaterno.Text = "";
            this.txtNacionalidad.Text = "";
            this.chkVigente.Checked = true;
            this.chkVigente.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Autor aut;

            if (this.ValidateChildren() == true)
            {
                if (this.Actual == null)
                {
                    aut = new Autor();
                    Program.Autores.Add(aut);
                    aut.Codigo = Program.Autores.Count;
                }
                else
                {
                    aut = this.Actual;
                }

                aut.Nombre = this.txtNombre.Text;
                aut.ApellidoPaterno = this.txtApellidoPaterno.Text;
                aut.ApellidoMaterno = this.txtApellidoMaterno.Text;
                aut.Nacionalidad = this.txtNacionalidad.Text;
                aut.Vigente = this.chkVigente.Checked;

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
            this.dgvListado.DataSource = null;
            if (Program.Autores.Count > 0)
            {
                this.dgvListado.AutoGenerateColumns = false;
                this.dgvListado.DataSource = Program.Autores;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.dgvListado.CurrentRow != null)
            {
                this.Actual = (Autor)this.dgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvListado.Focus();
            }
        }

        private void PresentarDatos()
        {
            this.txtNombre.Text = this.Actual.Nombre;
            this.txtApellidoPaterno.Text = this.Actual.ApellidoPaterno;
            this.txtApellidoMaterno.Text = this.Actual.ApellidoMaterno;
            this.txtNacionalidad.Text = this.Actual.Nacionalidad;
            this.chkVigente.Checked = this.Actual.Vigente;
            this.chkVigente.Enabled = true;
            this.ActivarControles(true);
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            this.txtNombre.Text = this.txtNombre.Text.Trim();
            if (this.txtNombre.Text.Length > 2)
            {
                this.errMensaje.SetError(this.txtNombre, "");
            }
            else
            {
                e.Cancel = true;
                this.errMensaje.SetError(this.txtNombre, "El nombre debe tener al menos 02 caracteres");
            }
        }

        private void txtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            this.txtApellidoPaterno.Text = this.txtApellidoPaterno.Text.Trim();
            if (this.txtApellidoPaterno.Text.Length > 2)
            {
                this.errMensaje.SetError(this.txtApellidoPaterno, "");
            }
            else
            {
                e.Cancel = true;
                this.errMensaje.SetError(this.txtApellidoPaterno, "El apellido paterno debe tener al menos 02 caracteres");
            }
        }

        private void txtNacionalidad_Validating(object sender, CancelEventArgs e)
        {
            this.txtNacionalidad.Text = this.txtNacionalidad.Text.Trim();
            if (this.txtNacionalidad.Text.Length > 2)
            {
                this.errMensaje.SetError(this.txtNacionalidad, "");
            }
            else
            {
                e.Cancel = true;
                this.errMensaje.SetError(this.txtNacionalidad, "La nacionalidad debe tener al menos 02 caracteres");
            }
        }

    }
}
