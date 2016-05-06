namespace test
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
            this.txtSoloNumeros1 = new HerenciaDeControles.TxtSoloNumeros();
            this.txtMayus1 = new HerenciaDeControles.txtMayus();
            this.SuspendLayout();
            // 
            // txtSoloNumeros1
            // 
            this.txtSoloNumeros1.Location = new System.Drawing.Point(119, 36);
            this.txtSoloNumeros1.Name = "txtSoloNumeros1";
            this.txtSoloNumeros1.Size = new System.Drawing.Size(100, 20);
            this.txtSoloNumeros1.TabIndex = 0;
            // 
            // txtMayus1
            // 
            this.txtMayus1.Location = new System.Drawing.Point(119, 85);
            this.txtMayus1.Name = "txtMayus1";
            this.txtMayus1.Size = new System.Drawing.Size(100, 20);
            this.txtMayus1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtMayus1);
            this.Controls.Add(this.txtSoloNumeros1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HerenciaDeControles.TxtSoloNumeros txtSoloNumeros1;
        private HerenciaDeControles.txtMayus txtMayus1;
    }
}

