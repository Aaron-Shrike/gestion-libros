namespace ManejoDatos
{
    partial class frmListadoLibrosPorAutor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cdISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAutor
            // 
            this.cboAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(83, 29);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(377, 21);
            this.cboAutor.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(24, 37);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "&Autor";
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Location = new System.Drawing.Point(466, 27);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
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
            this.cdPais,
            this.cdAño});
            this.dgvListado.Location = new System.Drawing.Point(27, 70);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(514, 331);
            this.dgvListado.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(466, 411);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "C&errar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.cdTitulo.DefaultCellStyle = dataGridViewCellStyle1;
            this.cdTitulo.HeaderText = "Titulo";
            this.cdTitulo.Name = "cdTitulo";
            this.cdTitulo.ReadOnly = true;
            this.cdTitulo.Width = 200;
            // 
            // cdAutor
            // 
            this.cdAutor.DataPropertyName = "NombreAutor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.cdAutor.DefaultCellStyle = dataGridViewCellStyle2;
            this.cdAutor.HeaderText = "Autor";
            this.cdAutor.Name = "cdAutor";
            this.cdAutor.ReadOnly = true;
            this.cdAutor.Width = 200;
            // 
            // cdPais
            // 
            this.cdPais.DataPropertyName = "Pais";
            this.cdPais.HeaderText = "País";
            this.cdPais.Name = "cdPais";
            this.cdPais.ReadOnly = true;
            // 
            // cdAño
            // 
            this.cdAño.DataPropertyName = "Año";
            this.cdAño.HeaderText = "Año";
            this.cdAño.Name = "cdAño";
            this.cdAño.ReadOnly = true;
            // 
            // frmListadoLibrosPorAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 446);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.lblAutor);
            this.Name = "frmListadoLibrosPorAutor";
            this.Text = "Listado de libros dado un autor ordenados por año";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListadoLibrosPorAutor_FormClosed);
            this.Load += new System.EventHandler(this.frmListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdAño;
    }
}