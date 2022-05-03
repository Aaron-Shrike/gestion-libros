namespace ManejoDatos
{
    partial class frmLibro
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
            this.components = new System.ComponentModel.Container();
            this.gbEntidad = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkVigente = new System.Windows.Forms.CheckBox();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.errError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cdISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdAño2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEntidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEntidad
            // 
            this.gbEntidad.Controls.Add(this.btnCancelar);
            this.gbEntidad.Controls.Add(this.btnAceptar);
            this.gbEntidad.Controls.Add(this.chkVigente);
            this.gbEntidad.Controls.Add(this.nudAño);
            this.gbEntidad.Controls.Add(this.lblAño);
            this.gbEntidad.Controls.Add(this.txtPais);
            this.gbEntidad.Controls.Add(this.lblPais);
            this.gbEntidad.Controls.Add(this.txtTitulo);
            this.gbEntidad.Controls.Add(this.lblTitulo);
            this.gbEntidad.Controls.Add(this.txtISBN);
            this.gbEntidad.Controls.Add(this.lblISBN);
            this.gbEntidad.Controls.Add(this.cboAutor);
            this.gbEntidad.Controls.Add(this.lblAutor);
            this.gbEntidad.Enabled = false;
            this.gbEntidad.Location = new System.Drawing.Point(12, 12);
            this.gbEntidad.Name = "gbEntidad";
            this.gbEntidad.Size = new System.Drawing.Size(362, 298);
            this.gbEntidad.TabIndex = 0;
            this.gbEntidad.TabStop = false;
            this.gbEntidad.Text = "Libro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(258, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(177, 258);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkVigente
            // 
            this.chkVigente.AutoSize = true;
            this.chkVigente.Location = new System.Drawing.Point(19, 216);
            this.chkVigente.Name = "chkVigente";
            this.chkVigente.Size = new System.Drawing.Size(62, 17);
            this.chkVigente.TabIndex = 10;
            this.chkVigente.Text = "&Vigente";
            this.chkVigente.UseVisualStyleBackColor = true;
            // 
            // nudAño
            // 
            this.nudAño.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAño.Location = new System.Drawing.Point(48, 179);
            this.nudAño.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudAño.Minimum = new decimal(new int[] {
            868,
            0,
            0,
            0});
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(82, 20);
            this.nudAño.TabIndex = 9;
            this.nudAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAño.Value = new decimal(new int[] {
            868,
            0,
            0,
            0});
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(16, 181);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 8;
            this.lblAño.Text = "Añ&o";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(49, 142);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(284, 20);
            this.txtPais.TabIndex = 7;
            this.txtPais.Validating += new System.ComponentModel.CancelEventHandler(this.txtPais_Validating);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(16, 145);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 6;
            this.lblPais.Text = "&Pais";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(56, 68);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(277, 20);
            this.txtTitulo.TabIndex = 3;
            this.txtTitulo.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitulo_Validating);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(17, 71);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "&Titulo";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(55, 33);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(278, 20);
            this.txtISBN.TabIndex = 1;
            this.txtISBN.Validating += new System.ComponentModel.CancelEventHandler(this.txtISBN_Validating);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(17, 38);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "&ISBN";
            // 
            // cboAutor
            // 
            this.cboAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(54, 104);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(279, 21);
            this.cboAutor.TabIndex = 5;
            this.cboAutor.Validating += new System.ComponentModel.CancelEventHandler(this.cboCategoria_Validating);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(16, 107);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "A&utor";
            // 
            // gbListado
            // 
            this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Controls.Add(this.btnModificar);
            this.gbListado.Controls.Add(this.btnNuevo);
            this.gbListado.Controls.Add(this.lblTituloLibro);
            this.gbListado.Controls.Add(this.btnListar);
            this.gbListado.Controls.Add(this.txtLibro);
            this.gbListado.Location = new System.Drawing.Point(380, 12);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(471, 367);
            this.gbListado.TabIndex = 1;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdISBN,
            this.cdTitulo,
            this.cdAutor,
            this.cbPais,
            this.cdAño2});
            this.dgvListado.Location = new System.Drawing.Point(11, 68);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(454, 258);
            this.dgvListado.TabIndex = 3;
            this.dgvListado.DoubleClick += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(92, 332);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(11, 332);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.Location = new System.Drawing.Point(14, 38);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(74, 13);
            this.lblTituloLibro.TabIndex = 0;
            this.lblTituloLibro.Text = "Titulo de Libro";
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(390, 33);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtLibro
            // 
            this.txtLibro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLibro.Location = new System.Drawing.Point(94, 36);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(290, 20);
            this.txtLibro.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(776, 395);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "C&errar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errError
            // 
            this.errError.ContainerControl = this;
            // 
            // cdISBN
            // 
            this.cdISBN.DataPropertyName = "ISBN";
            this.cdISBN.HeaderText = "ISBN";
            this.cdISBN.Name = "cdISBN";
            this.cdISBN.ReadOnly = true;
            // 
            // cdTitulo
            // 
            this.cdTitulo.DataPropertyName = "Titulo";
            this.cdTitulo.HeaderText = "Titulo";
            this.cdTitulo.Name = "cdTitulo";
            this.cdTitulo.ReadOnly = true;
            this.cdTitulo.Width = 200;
            // 
            // cdAutor
            // 
            this.cdAutor.DataPropertyName = "NombreAutor";
            this.cdAutor.HeaderText = "Autor";
            this.cdAutor.Name = "cdAutor";
            this.cdAutor.ReadOnly = true;
            this.cdAutor.Width = 250;
            // 
            // cbPais
            // 
            this.cbPais.DataPropertyName = "Pais";
            this.cbPais.HeaderText = "País";
            this.cbPais.Name = "cbPais";
            this.cbPais.ReadOnly = true;
            // 
            // cdAño2
            // 
            this.cdAño2.DataPropertyName = "Año";
            this.cdAño2.HeaderText = "Año";
            this.cdAño2.Name = "cdAño2";
            this.cdAño2.ReadOnly = true;
            this.cdAño2.Width = 70;
            // 
            // frmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(863, 429);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbEntidad);
            this.MinimumSize = new System.Drawing.Size(870, 460);
            this.Name = "frmLibro";
            this.Text = "Gestión de libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProducto_FormClosed);
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.gbEntidad.ResumeLayout(false);
            this.gbEntidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEntidad;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.CheckBox chkVigente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider errError;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdAño2;
    }
}