namespace WindowsForm
{
    partial class frmMascota
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
            this.cboxTipoDeMascota = new System.Windows.Forms.ComboBox();
            this.lblMascota = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new Entidades.ControldeUsuario();
            this.SuspendLayout();
            // 
            // cboxTipoDeMascota
            // 
            this.cboxTipoDeMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoDeMascota.FormattingEnabled = true;
            this.cboxTipoDeMascota.Location = new System.Drawing.Point(75, 161);
            this.cboxTipoDeMascota.Name = "cboxTipoDeMascota";
            this.cboxTipoDeMascota.Size = new System.Drawing.Size(121, 21);
            this.cboxTipoDeMascota.TabIndex = 5;
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Location = new System.Drawing.Point(72, 145);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(87, 13);
            this.lblMascota.TabIndex = 6;
            this.lblMascota.Text = "Tipo de Mascota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 113);
            this.txtNombre.modoSeleccionado = Entidades.ControldeUsuario.Modo.SoloLetras;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // frmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.cboxTipoDeMascota);
            this.Name = "frmMascota";
            this.Text = "frmMascota";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtEdad, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.cboxTipoDeMascota, 0);
            this.Controls.SetChildIndex(this.lblMascota, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ComboBox cboxTipoDeMascota;
        protected System.Windows.Forms.Label lblMascota;
        protected System.Windows.Forms.Label label3;
        private Entidades.ControldeUsuario txtNombre;
    }
}