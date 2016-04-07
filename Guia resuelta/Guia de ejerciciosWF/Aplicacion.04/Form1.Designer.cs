namespace Aplicacion._04
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.listNum = new System.Windows.Forms.ListBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.radbtnAscendente = new System.Windows.Forms.RadioButton();
            this.radiobtnDescente = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIngreso);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar un nuevo numero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listNum);
            this.groupBox2.Location = new System.Drawing.Point(143, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de numeros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.radiobtnDescente);
            this.groupBox3.Controls.Add(this.radbtnAscendente);
            this.groupBox3.Location = new System.Drawing.Point(12, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orden";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(16, 71);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(81, 28);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Agregar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // listNum
            // 
            this.listNum.FormattingEnabled = true;
            this.listNum.Location = new System.Drawing.Point(6, 19);
            this.listNum.Name = "listNum";
            this.listNum.Size = new System.Drawing.Size(117, 212);
            this.listNum.TabIndex = 1;
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(6, 35);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(100, 18);
            this.txtIngreso.TabIndex = 1;
            // 
            // radbtnAscendente
            // 
            this.radbtnAscendente.AutoSize = true;
            this.radbtnAscendente.Location = new System.Drawing.Point(6, 19);
            this.radbtnAscendente.Name = "radbtnAscendente";
            this.radbtnAscendente.Size = new System.Drawing.Size(82, 17);
            this.radbtnAscendente.TabIndex = 0;
            this.radbtnAscendente.TabStop = true;
            this.radbtnAscendente.Text = "Ascendente";
            this.radbtnAscendente.UseVisualStyleBackColor = true;
            this.radbtnAscendente.CheckedChanged += new System.EventHandler(this.radbtnAscendente_CheckedChanged);
            // 
            // radiobtnDescente
            // 
            this.radiobtnDescente.AutoSize = true;
            this.radiobtnDescente.Location = new System.Drawing.Point(6, 68);
            this.radiobtnDescente.Name = "radiobtnDescente";
            this.radiobtnDescente.Size = new System.Drawing.Size(89, 17);
            this.radiobtnDescente.TabIndex = 1;
            this.radiobtnDescente.TabStop = true;
            this.radiobtnDescente.Text = "Descendente";
            this.radiobtnDescente.UseVisualStyleBackColor = true;
            this.radiobtnDescente.CheckedChanged += new System.EventHandler(this.radiobtnDescente_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 102);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ordenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox listNum;
        private System.Windows.Forms.RadioButton radiobtnDescente;
        private System.Windows.Forms.RadioButton radbtnAscendente;
        private System.Windows.Forms.Button button1;
    }
}

