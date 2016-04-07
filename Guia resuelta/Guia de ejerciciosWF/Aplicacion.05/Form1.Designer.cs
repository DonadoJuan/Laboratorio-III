namespace Aplicacion._05
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textIngreso = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPar = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtImpar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Numeros = new System.Windows.Forms.GroupBox();
            this.lstDivisores = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Numeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textIngreso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero:";
            // 
            // textIngreso
            // 
            this.textIngreso.Location = new System.Drawing.Point(110, 22);
            this.textIngreso.Name = "textIngreso";
            this.textIngreso.Size = new System.Drawing.Size(55, 20);
            this.textIngreso.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtImpar);
            this.groupBox2.Controls.Add(this.txtCant);
            this.groupBox2.Controls.Add(this.txtMenor);
            this.groupBox2.Controls.Add(this.txtPar);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtMayor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 172);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de cifras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cifra menor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Suma de sifras impares";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Suma de cifras pares";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Suma total de cifras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cifra mayor";
            // 
            // txtMayor
            // 
            this.txtMayor.Enabled = false;
            this.txtMayor.Location = new System.Drawing.Point(127, 125);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(38, 20);
            this.txtMayor.TabIndex = 6;
            // 
            // txtMenor
            // 
            this.txtMenor.Enabled = false;
            this.txtMenor.Location = new System.Drawing.Point(127, 151);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(38, 20);
            this.txtMenor.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(127, 99);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(38, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // txtPar
            // 
            this.txtPar.Enabled = false;
            this.txtPar.Location = new System.Drawing.Point(127, 73);
            this.txtPar.Name = "txtPar";
            this.txtPar.Size = new System.Drawing.Size(38, 20);
            this.txtPar.TabIndex = 9;
            // 
            // txtCant
            // 
            this.txtCant.Enabled = false;
            this.txtCant.Location = new System.Drawing.Point(127, 19);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(38, 20);
            this.txtCant.TabIndex = 10;
            // 
            // txtImpar
            // 
            this.txtImpar.Enabled = false;
            this.txtImpar.Location = new System.Drawing.Point(127, 47);
            this.txtImpar.Name = "txtImpar";
            this.txtImpar.Size = new System.Drawing.Size(38, 20);
            this.txtImpar.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(197, 45);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(197, 16);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(184, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Numeros
            // 
            this.Numeros.Controls.Add(this.lstDivisores);
            this.Numeros.Location = new System.Drawing.Point(190, 74);
            this.Numeros.Name = "Numeros";
            this.Numeros.Size = new System.Drawing.Size(88, 182);
            this.Numeros.TabIndex = 14;
            this.Numeros.TabStop = false;
            this.Numeros.Text = "Divisores";
            // 
            // lstDivisores
            // 
            this.lstDivisores.FormattingEnabled = true;
            this.lstDivisores.Location = new System.Drawing.Point(6, 16);
            this.lstDivisores.Name = "lstDivisores";
            this.lstDivisores.Size = new System.Drawing.Size(79, 160);
            this.lstDivisores.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 266);
            this.Controls.Add(this.Numeros);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Numeros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtImpar;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.TextBox txtPar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox Numeros;
        private System.Windows.Forms.ListBox lstDivisores;
    }
}

