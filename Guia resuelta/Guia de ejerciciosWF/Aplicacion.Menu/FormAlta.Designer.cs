namespace Aplicacion.Menu
{
    partial class FormAlta
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistrar = new System.Windows.Forms.Button();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.chboxAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(120, 120);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(120, 72);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(120, 22);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese mail";
            // 
            // txtRegistrar
            // 
            this.txtRegistrar.Location = new System.Drawing.Point(12, 226);
            this.txtRegistrar.Name = "txtRegistrar";
            this.txtRegistrar.Size = new System.Drawing.Size(75, 23);
            this.txtRegistrar.TabIndex = 6;
            this.txtRegistrar.Text = "Registrar";
            this.txtRegistrar.UseVisualStyleBackColor = true;
            this.txtRegistrar.Click += new System.EventHandler(this.txtRegistrar_Click);
            // 
            // txtCancelar
            // 
            this.txtCancelar.Location = new System.Drawing.Point(197, 226);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(75, 23);
            this.txtCancelar.TabIndex = 7;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = true;
            this.txtCancelar.Click += new System.EventHandler(this.txtCancelar_Click);
            // 
            // chboxAdmin
            // 
            this.chboxAdmin.AutoSize = true;
            this.chboxAdmin.Location = new System.Drawing.Point(120, 168);
            this.chboxAdmin.Name = "chboxAdmin";
            this.chboxAdmin.Size = new System.Drawing.Size(89, 17);
            this.chboxAdmin.TabIndex = 9;
            this.chboxAdmin.Text = "Administrador";
            this.chboxAdmin.UseVisualStyleBackColor = true;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chboxAdmin);
            this.Controls.Add(this.txtCancelar);
            this.Controls.Add(this.txtRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtMail);
            this.Name = "FormAlta";
            this.Text = "FormAlta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtRegistrar;
        private System.Windows.Forms.Button txtCancelar;
        private System.Windows.Forms.CheckBox chboxAdmin;
    }
}