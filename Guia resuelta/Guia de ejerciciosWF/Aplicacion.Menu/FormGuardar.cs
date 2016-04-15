using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacion.Menu
{
    public partial class FormGuardar : Form
    {
        public string RutaDeGuardado { get { return this.txtPath.Text; } }
        public FormGuardar()
        {
            InitializeComponent();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Length > 0)
                System.Diagnostics.Process.Start(txtPath.Text);
            else
                MessageBox.Show("Debes elegir una ruta antes de continuar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtPath.Clear();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Length > 0)
                this.DialogResult = DialogResult.OK;
        }
    }
}
