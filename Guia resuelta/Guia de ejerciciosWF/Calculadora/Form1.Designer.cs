namespace Calculadora
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.grpNumeros = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpOperadores = new System.Windows.Forms.GroupBox();
            this.grpNumeros.SuspendLayout();
            this.grpOperadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Location = new System.Drawing.Point(12, 30);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(187, 20);
            this.txtDisplay.TabIndex = 0;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(20, 48);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(26, 23);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(20, 105);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(92, 23);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(16, 104);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(20, 77);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(26, 23);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn2.Location = new System.Drawing.Point(52, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(28, 23);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(52, 48);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(28, 23);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(16, 77);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(52, 77);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(28, 23);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(84, 77);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(28, 23);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(16, 19);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 10;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(16, 48);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 23);
            this.btnResta.TabIndex = 11;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(86, 48);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(26, 23);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(18, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(28, 23);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(86, 19);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(26, 23);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(182, 210);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 23);
            this.btnIgual.TabIndex = 15;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            // 
            // grpNumeros
            // 
            this.grpNumeros.Controls.Add(this.btn5);
            this.grpNumeros.Controls.Add(this.btn4);
            this.grpNumeros.Controls.Add(this.btn3);
            this.grpNumeros.Controls.Add(this.btn0);
            this.grpNumeros.Controls.Add(this.btn1);
            this.grpNumeros.Controls.Add(this.btn7);
            this.grpNumeros.Controls.Add(this.btn6);
            this.grpNumeros.Controls.Add(this.btn2);
            this.grpNumeros.Controls.Add(this.btn8);
            this.grpNumeros.Controls.Add(this.btn9);
            this.grpNumeros.Location = new System.Drawing.Point(12, 84);
            this.grpNumeros.Name = "grpNumeros";
            this.grpNumeros.Size = new System.Drawing.Size(135, 139);
            this.grpNumeros.TabIndex = 16;
            this.grpNumeros.TabStop = false;
            this.grpNumeros.Text = "Numeros";
            // 
            // grpOperadores
            // 
            this.grpOperadores.Controls.Add(this.btnDivision);
            this.grpOperadores.Controls.Add(this.btnSuma);
            this.grpOperadores.Controls.Add(this.btnResta);
            this.grpOperadores.Controls.Add(this.btnMultiplicar);
            this.grpOperadores.Location = new System.Drawing.Point(166, 65);
            this.grpOperadores.Name = "grpOperadores";
            this.grpOperadores.Size = new System.Drawing.Size(106, 139);
            this.grpOperadores.TabIndex = 17;
            this.grpOperadores.TabStop = false;
            this.grpOperadores.Text = "Operadores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grpOperadores);
            this.Controls.Add(this.grpNumeros);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = " CalculadoraBasica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNumeros.ResumeLayout(false);
            this.grpOperadores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.GroupBox grpNumeros;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpOperadores;
    }
}

