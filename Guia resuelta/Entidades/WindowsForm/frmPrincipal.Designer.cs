namespace WindowsForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboxOrdenamiento = new System.Windows.Forms.ComboBox();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlta,
            this.btnBaja,
            this.btnModificar,
            this.btnSalir,
            this.mostrarListadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAlta
            // 
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(40, 20);
            this.btnAlta.Text = "Alta";
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(41, 20);
            this.btnBaja.Text = "Baja";
            // 
            // btnModificar
            // 
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 20);
            this.btnModificar.Text = "Modificar";
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 20);
            this.btnSalir.Text = "Salir";
            // 
            // mostrarListadoToolStripMenuItem
            // 
            this.mostrarListadoToolStripMenuItem.Name = "mostrarListadoToolStripMenuItem";
            this.mostrarListadoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mostrarListadoToolStripMenuItem.Text = "Mostrar Listado";
            this.mostrarListadoToolStripMenuItem.Click += new System.EventHandler(this.mostrarListadoToolStripMenuItem_Click);
            // 
            // cboxOrdenamiento
            // 
            this.cboxOrdenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOrdenamiento.FormattingEnabled = true;
            this.cboxOrdenamiento.Location = new System.Drawing.Point(306, 0);
            this.cboxOrdenamiento.Name = "cboxOrdenamiento";
            this.cboxOrdenamiento.Size = new System.Drawing.Size(71, 21);
            this.cboxOrdenamiento.TabIndex = 1;
            this.cboxOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.cboxOrdenamiento_SelectedIndexChanged);
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.Location = new System.Drawing.Point(58, 27);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(284, 238);
            this.lstMascotas.TabIndex = 2;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 261);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.cboxOrdenamiento);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.Text = "ABM Mascotas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAlta;
        private System.Windows.Forms.ToolStripMenuItem btnBaja;
        private System.Windows.Forms.ToolStripMenuItem btnModificar;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ComboBox cboxOrdenamiento;
        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.ToolStripMenuItem mostrarListadoToolStripMenuItem;
    }
}