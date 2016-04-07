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
    public partial class FormLogin : Form
    {
        private List<Usuario> _listaUsuarios;
        private bool _admin;
        private bool _logged;
        public bool admin { get { return this._admin; } }
        public FormLogin(List<Usuario> listausuarios)
        {
            InitializeComponent();
            this._listaUsuarios = listausuarios;
            this._logged = false;
            this._admin = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            foreach (Usuario item in this._listaUsuarios) {
                if (item._usuario == txtUsuario.Text && item._contraseña == txtContraseña.Text) {
                    if (item._admin) { 
                        this._admin = true;
                    }
                    this._logged = true;
                    this.DialogResult = DialogResult.OK;
                    break;
                }
            }
            if(!this._logged)
            MessageBox.Show("Error en los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
