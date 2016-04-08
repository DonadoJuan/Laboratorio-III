namespace Aplicacion.CajeroAutomatico
{
    partial class Form1
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpboxCantidad = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtDos = new System.Windows.Forms.TextBox();
            this.txtCinco = new System.Windows.Forms.TextBox();
            this.txtDiez = new System.Windows.Forms.TextBox();
            this.txtVeinte = new System.Windows.Forms.TextBox();
            this.txtCincuenta = new System.Windows.Forms.TextBox();
            this.txtCien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpboxCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(206, 77);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(206, 123);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(206, 238);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // grpboxCantidad
            // 
            this.grpboxCantidad.Controls.Add(this.label7);
            this.grpboxCantidad.Controls.Add(this.groupBox2);
            this.grpboxCantidad.Controls.Add(this.txtIngreso);
            this.grpboxCantidad.Location = new System.Drawing.Point(0, 0);
            this.grpboxCantidad.Name = "grpboxCantidad";
            this.grpboxCantidad.Size = new System.Drawing.Size(200, 74);
            this.grpboxCantidad.TabIndex = 3;
            this.grpboxCantidad.TabStop = false;
            this.grpboxCantidad.Text = "Cantidad a retirar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad a retirar";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 188);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(94, 29);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtIngreso.TabIndex = 4;
            // 
            // txtDos
            // 
            this.txtDos.Enabled = false;
            this.txtDos.Location = new System.Drawing.Point(94, 92);
            this.txtDos.Name = "txtDos";
            this.txtDos.Size = new System.Drawing.Size(100, 20);
            this.txtDos.TabIndex = 5;
            // 
            // txtCinco
            // 
            this.txtCinco.Enabled = false;
            this.txtCinco.Location = new System.Drawing.Point(94, 118);
            this.txtCinco.Name = "txtCinco";
            this.txtCinco.Size = new System.Drawing.Size(100, 20);
            this.txtCinco.TabIndex = 6;
            // 
            // txtDiez
            // 
            this.txtDiez.Enabled = false;
            this.txtDiez.Location = new System.Drawing.Point(94, 144);
            this.txtDiez.Name = "txtDiez";
            this.txtDiez.Size = new System.Drawing.Size(100, 20);
            this.txtDiez.TabIndex = 7;
            // 
            // txtVeinte
            // 
            this.txtVeinte.Enabled = false;
            this.txtVeinte.Location = new System.Drawing.Point(94, 170);
            this.txtVeinte.Name = "txtVeinte";
            this.txtVeinte.Size = new System.Drawing.Size(100, 20);
            this.txtVeinte.TabIndex = 8;
            // 
            // txtCincuenta
            // 
            this.txtCincuenta.Enabled = false;
            this.txtCincuenta.Location = new System.Drawing.Point(94, 196);
            this.txtCincuenta.Name = "txtCincuenta";
            this.txtCincuenta.Size = new System.Drawing.Size(100, 20);
            this.txtCincuenta.TabIndex = 9;
            // 
            // txtCien
            // 
            this.txtCien.Enabled = false;
            this.txtCien.Location = new System.Drawing.Point(94, 222);
            this.txtCien.Name = "txtCien";
            this.txtCien.Size = new System.Drawing.Size(100, 20);
            this.txtCien.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Billete de $10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Billete de $20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Billete de $50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Billete de $100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Billete de $5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Billete de $2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDos);
            this.Controls.Add(this.txtCien);
            this.Controls.Add(this.txtCincuenta);
            this.Controls.Add(this.txtVeinte);
            this.Controls.Add(this.txtDiez);
            this.Controls.Add(this.txtCinco);
            this.Controls.Add(this.grpboxCantidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxCantidad.ResumeLayout(false);
            this.grpboxCantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpboxCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtDos;
        private System.Windows.Forms.TextBox txtCinco;
        private System.Windows.Forms.TextBox txtDiez;
        private System.Windows.Forms.TextBox txtVeinte;
        private System.Windows.Forms.TextBox txtCincuenta;
        private System.Windows.Forms.TextBox txtCien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

