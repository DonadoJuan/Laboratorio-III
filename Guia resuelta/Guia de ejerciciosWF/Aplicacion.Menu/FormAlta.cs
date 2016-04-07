using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Aplicacion.Menu
{
    public partial class FormAlta : Form
    {
        private Usuario _nuevoUsuario;
        public Usuario nuevoUsuario { get { return this._nuevoUsuario; } }

        public FormAlta()
        {
            InitializeComponent();
            
        }

        private void txtRegistrar_Click(object sender, EventArgs e)
        {         
               this._nuevoUsuario = new Usuario(txtUsuario.Text, txtContraseña.Text, txtMail.Text, chboxAdmin.Checked);
               this.DialogResult = DialogResult.OK;
        }
        private void txtCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
    
}
