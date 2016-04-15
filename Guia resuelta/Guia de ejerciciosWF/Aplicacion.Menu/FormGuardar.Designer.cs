namespace Aplicacion.Menu
{
    partial class FormGuardar
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRuta = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(12, 25);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(243, 22);
            this.btnRuta.TabIndex = 0;
            this.btnRuta.Text = "Elegir ruta ";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 62);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir carpeta";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(93, 85);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(162, 20);
            this.txtPath.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 102);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormGuardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnRuta);
            this.Name = "FormGuardar";
            this.Text = "FormGuardar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnAceptar;
    }
}