namespace EjercicioDataTable
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDataST = new System.Windows.Forms.Button();
            this.btnRelaciones = new System.Windows.Forms.Button();
            this.btnLocalidades = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mostrar = new System.Windows.Forms.GroupBox();
            this.btnProveedoresLocTxtFiltro = new System.Windows.Forms.Button();
            this.btnProveedorLocQuilmes = new System.Windows.Forms.Button();
            this.btnProductoProvLoc = new System.Windows.Forms.Button();
            this.btnProveedorLocalidad = new System.Windows.Forms.Button();
            this.btnProductoProveedor = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.grvLista = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Mostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDataST
            // 
            this.btnDataST.Location = new System.Drawing.Point(23, 19);
            this.btnDataST.Name = "btnDataST";
            this.btnDataST.Size = new System.Drawing.Size(172, 35);
            this.btnDataST.TabIndex = 0;
            this.btnDataST.Text = "Crear DataSet y DataTable ";
            this.btnDataST.UseVisualStyleBackColor = true;
            // 
            // btnRelaciones
            // 
            this.btnRelaciones.Location = new System.Drawing.Point(23, 75);
            this.btnRelaciones.Name = "btnRelaciones";
            this.btnRelaciones.Size = new System.Drawing.Size(172, 38);
            this.btnRelaciones.TabIndex = 1;
            this.btnRelaciones.Text = "Crear Relaciones";
            this.btnRelaciones.UseVisualStyleBackColor = true;
            // 
            // btnLocalidades
            // 
            this.btnLocalidades.Location = new System.Drawing.Point(23, 130);
            this.btnLocalidades.Name = "btnLocalidades";
            this.btnLocalidades.Size = new System.Drawing.Size(172, 38);
            this.btnLocalidades.TabIndex = 2;
            this.btnLocalidades.Text = "Crear Localidades";
            this.btnLocalidades.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(23, 184);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(172, 38);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Cargar Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(23, 238);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(172, 38);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Cargar Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDataST);
            this.groupBox1.Controls.Add(this.btnProductos);
            this.groupBox1.Controls.Add(this.btnProveedores);
            this.groupBox1.Controls.Add(this.btnLocalidades);
            this.groupBox1.Controls.Add(this.btnRelaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 289);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicializacion";
            // 
            // Mostrar
            // 
            this.Mostrar.Controls.Add(this.grvLista);
            this.Mostrar.Controls.Add(this.txtFiltro);
            this.Mostrar.Controls.Add(this.btnProveedoresLocTxtFiltro);
            this.Mostrar.Controls.Add(this.btnProveedorLocQuilmes);
            this.Mostrar.Controls.Add(this.btnProductoProvLoc);
            this.Mostrar.Controls.Add(this.btnProveedorLocalidad);
            this.Mostrar.Controls.Add(this.btnProductoProveedor);
            this.Mostrar.Location = new System.Drawing.Point(239, 12);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(485, 289);
            this.Mostrar.TabIndex = 6;
            this.Mostrar.TabStop = false;
            this.Mostrar.Text = "Mostrar";
            // 
            // btnProveedoresLocTxtFiltro
            // 
            this.btnProveedoresLocTxtFiltro.Location = new System.Drawing.Point(6, 238);
            this.btnProveedoresLocTxtFiltro.Name = "btnProveedoresLocTxtFiltro";
            this.btnProveedoresLocTxtFiltro.Size = new System.Drawing.Size(226, 38);
            this.btnProveedoresLocTxtFiltro.TabIndex = 5;
            this.btnProveedoresLocTxtFiltro.Text = "5 - Mostrar proveedores de la localidad ingresada en el TxtFiltro";
            this.btnProveedoresLocTxtFiltro.UseVisualStyleBackColor = true;
            // 
            // btnProveedorLocQuilmes
            // 
            this.btnProveedorLocQuilmes.Location = new System.Drawing.Point(260, 61);
            this.btnProveedorLocQuilmes.Name = "btnProveedorLocQuilmes";
            this.btnProveedorLocQuilmes.Size = new System.Drawing.Size(219, 36);
            this.btnProveedorLocQuilmes.TabIndex = 6;
            this.btnProveedorLocQuilmes.Text = "4 - Mostrar proveedores de la Localidad \"Quilmes\"";
            this.btnProveedorLocQuilmes.UseVisualStyleBackColor = true;
            // 
            // btnProductoProvLoc
            // 
            this.btnProductoProvLoc.Location = new System.Drawing.Point(6, 61);
            this.btnProductoProvLoc.Name = "btnProductoProvLoc";
            this.btnProductoProvLoc.Size = new System.Drawing.Size(226, 36);
            this.btnProductoProvLoc.TabIndex = 7;
            this.btnProductoProvLoc.Text = "3 - Mostrar productos con Proveedor con su Localidad";
            this.btnProductoProvLoc.UseVisualStyleBackColor = true;
            // 
            // btnProveedorLocalidad
            // 
            this.btnProveedorLocalidad.Location = new System.Drawing.Point(260, 18);
            this.btnProveedorLocalidad.Name = "btnProveedorLocalidad";
            this.btnProveedorLocalidad.Size = new System.Drawing.Size(219, 36);
            this.btnProveedorLocalidad.TabIndex = 8;
            this.btnProveedorLocalidad.Text = "2 - Mostrar Proveedor con su Localidad ";
            this.btnProveedorLocalidad.UseVisualStyleBackColor = true;
            // 
            // btnProductoProveedor
            // 
            this.btnProductoProveedor.Location = new System.Drawing.Point(6, 19);
            this.btnProductoProveedor.Name = "btnProductoProveedor";
            this.btnProductoProveedor.Size = new System.Drawing.Size(226, 36);
            this.btnProductoProveedor.TabIndex = 9;
            this.btnProductoProveedor.Text = "1 - Mostrar Productos con su Proveedor";
            this.btnProductoProveedor.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(260, 238);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(219, 38);
            this.txtFiltro.TabIndex = 10;
            // 
            // grvLista
            // 
            this.grvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLista.Location = new System.Drawing.Point(6, 103);
            this.grvLista.Name = "grvLista";
            this.grvLista.Size = new System.Drawing.Size(473, 129);
            this.grvLista.TabIndex = 11;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 313);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Frm Principal";
            this.groupBox1.ResumeLayout(false);
            this.Mostrar.ResumeLayout(false);
            this.Mostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDataST;
        private System.Windows.Forms.Button btnRelaciones;
        private System.Windows.Forms.Button btnLocalidades;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Mostrar;
        private System.Windows.Forms.DataGridView grvLista;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnProveedoresLocTxtFiltro;
        private System.Windows.Forms.Button btnProveedorLocQuilmes;
        private System.Windows.Forms.Button btnProductoProvLoc;
        private System.Windows.Forms.Button btnProveedorLocalidad;
        private System.Windows.Forms.Button btnProductoProveedor;
    }
}

