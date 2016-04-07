namespace Aplicacion.Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formStandarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiposDeToolStripMenuItem
            // 
            this.tiposDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formStandarToolStripMenuItem,
            this.dialogToolStripMenuItem,
            this.mdiChildToolStripMenuItem,
            this.ownerToolStripMenuItem,
            this.RegToolStripMenuItem,
            this.verListadoToolStripMenuItem,
            this.logInToolStripMenuItem1});
            this.tiposDeToolStripMenuItem.Name = "tiposDeToolStripMenuItem";
            this.tiposDeToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.tiposDeToolStripMenuItem.Text = "Tipos de formularios";
            // 
            // formStandarToolStripMenuItem
            // 
            this.formStandarToolStripMenuItem.Name = "formStandarToolStripMenuItem";
            this.formStandarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formStandarToolStripMenuItem.Text = "Form standar";
            this.formStandarToolStripMenuItem.Click += new System.EventHandler(this.formStandarToolStripMenuItem_Click);
            // 
            // dialogToolStripMenuItem
            // 
            this.dialogToolStripMenuItem.Name = "dialogToolStripMenuItem";
            this.dialogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dialogToolStripMenuItem.Text = "Dialog";
            this.dialogToolStripMenuItem.Click += new System.EventHandler(this.dialogToolStripMenuItem_Click);
            // 
            // mdiChildToolStripMenuItem
            // 
            this.mdiChildToolStripMenuItem.Name = "mdiChildToolStripMenuItem";
            this.mdiChildToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mdiChildToolStripMenuItem.Text = "Mdi child";
            this.mdiChildToolStripMenuItem.Click += new System.EventHandler(this.mdiChildToolStripMenuItem_Click);
            // 
            // ownerToolStripMenuItem
            // 
            this.ownerToolStripMenuItem.Name = "ownerToolStripMenuItem";
            this.ownerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ownerToolStripMenuItem.Text = "Owner";
            this.ownerToolStripMenuItem.Click += new System.EventHandler(this.ownerToolStripMenuItem_Click);
            // 
            // RegToolStripMenuItem
            // 
            this.RegToolStripMenuItem.Name = "RegToolStripMenuItem";
            this.RegToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RegToolStripMenuItem.Text = "Registrarse";
            this.RegToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // verListadoToolStripMenuItem
            // 
            this.verListadoToolStripMenuItem.Name = "verListadoToolStripMenuItem";
            this.verListadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verListadoToolStripMenuItem.Text = "Ver listado";
            this.verListadoToolStripMenuItem.Click += new System.EventHandler(this.verListadoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem1
            // 
            this.logInToolStripMenuItem1.Name = "logInToolStripMenuItem1";
            this.logInToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.logInToolStripMenuItem1.Text = "Log in";
            this.logInToolStripMenuItem1.Click += new System.EventHandler(this.logInToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formStandarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mdiChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ownerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem1;
    }
}

