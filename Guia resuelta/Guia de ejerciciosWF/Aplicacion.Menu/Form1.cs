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
    public partial class Form1 : Form
    {
        private List<Usuario> _listaUsuarios;
        private bool _admin;
        private bool _logged;
        public List<Usuario> listaUsuario { get { return this._listaUsuarios; } set { this._listaUsuarios = value; } }
        public Form1()
        {
            InitializeComponent();
            this._admin = false;
            this._logged = false;
            if (this.deserializar() == null)
                this._listaUsuarios = new List<Usuario>();
            else
                this._listaUsuarios = (List<Usuario>)this.deserializar();
        }

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulariostandard = new Form();
            formulariostandard.Show(this);
        }

        private void formStandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulariostandard = new Form();
            formulariostandard.Show();
        }

        private void dialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulariostandard = new Form();
            formulariostandard.ShowDialog(this);
        }

        private void mdiChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulariostandard = new Form();
            this.IsMdiContainer = true;
            formulariostandard.MdiParent = this;
            formulariostandard.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlta formaux = new FormAlta();
            formaux.ShowDialog(this);
            this._listaUsuarios.Add(formaux.nuevoUsuario);
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._logged)
            {
                FormListado formListado = new FormListado(this._listaUsuarios, this._admin);
                formListado.ShowDialog(this);
            }
            else
                MessageBox.Show("Debe logearse para ver el listado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool serializar()
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(@"D:\Usuarios.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Usuario>));
                    serializador.Serialize(escritor, this._listaUsuarios);
                    return true;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la serializacion");
                return false;
            }
        }

        private object deserializar()
        {
            try
            {
                using (XmlTextReader lector = new XmlTextReader(@"D:\Usuarios.xml"))
                {
                    XmlSerializer deserializador = new XmlSerializer(typeof(List<Usuario>));
                    return deserializador.Deserialize(lector);

                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.serializar())
                MessageBox.Show("Los cambios se guardaron exitosamente");
            this.Dispose();
        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLogin formlogin = new FormLogin(this._listaUsuarios);
            formlogin.ShowDialog();
            if (formlogin.DialogResult == DialogResult.OK)
            {
                this._logged = true;
                this._admin = formlogin.admin;
            }
                
        }
    }
}
