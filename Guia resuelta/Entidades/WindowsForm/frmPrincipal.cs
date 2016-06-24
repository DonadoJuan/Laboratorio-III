using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;

namespace WindowsForm
{
    public partial class frmPrincipal : Form
    {

        private enum EtipoDeOrdenamiento { PorEdad, PorNombre, PorTipo};
        private List<Mascota> _listaDeMascotas;
        private delegate void delegadoActualizador(List<Mascota> lista);
        private delegadoActualizador actualizarListado;
        public frmPrincipal()
        {
            InitializeComponent();
            this._listaDeMascotas = new List<Mascota>();
            this.cboxOrdenamiento.Items.Add(EtipoDeOrdenamiento.PorEdad);
            this.cboxOrdenamiento.Items.Add(EtipoDeOrdenamiento.PorNombre);
            this.cboxOrdenamiento.Items.Add(EtipoDeOrdenamiento.PorTipo);
        }

        private void MostrarListado()
        {
            this.lstMascotas.Items.Clear();
            foreach(Mascota item in this._listaDeMascotas)
            {
                this.lstMascotas.Items.Add(item.ToString());
            }
        }

        private void cboxOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comparison <Mascota> comparison = null;

            switch (this.cboxOrdenamiento.Text)
            {
                case "PorEdad": comparison = new Comparison<Mascota>(Mascota.OrdenarPorEdad);
                    break;
                case "PorNombre":
                    comparison = new Comparison<Mascota>(Mascota.ordenarPorNombre);
                    break;
                case "PorTipo":
                    comparison = new Comparison<Mascota>(Mascota.ordenarPorTipo);
                    break;
            }

            this._listaDeMascotas.Sort(comparison);
            this.MostrarListado();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmMascota aux = new frmMascota();
            aux.ShowDialog();

            if(aux.DialogResult == DialogResult.OK)
            {
                this._listaDeMascotas.Add(aux.miMascota);
            }

            this.MostrarListado();
            this.actualizarListado(this._listaDeMascotas);        
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstMascotas.SelectedIndexChanged -= this.lstMascotas_SelectedIndexChanged;
            this.btnBaja.Click += new EventHandler(this.manejadorCentral);
            this.btnModificar.Click += new EventHandler(this.manejadorCentral);
        }

        private void manejadorCentral(object sender, EventArgs e)
        {
            if ((ToolStripMenuItem)sender == this.btnBaja)
            {
                int i = lstMascotas.SelectedIndex;
                Mascota miMascota = this._listaDeMascotas[i];
                this._listaDeMascotas.Remove(miMascota);
            }

            if ((ToolStripMenuItem)sender == this.btnModificar)
            {
                int i = lstMascotas.SelectedIndex;
                Mascota miMascota = this._listaDeMascotas[i];
                frmMascota aux = new frmMascota(miMascota);
                aux.ShowDialog();
                
                if(aux.DialogResult == DialogResult.OK)
                {
                    this._listaDeMascotas[i] = aux.miMascota;
                }               
            }

            this.lstMascotas.SelectedIndexChanged += new EventHandler(this.lstMascotas_SelectedIndexChanged);
            this.btnBaja.Click -= this.manejadorCentral;
            this.btnModificar.Click -= this.manejadorCentral;
            this.MostrarListado();
            this.actualizarListado(this._listaDeMascotas);


        }

        private void Salir(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Desea cerrar la aplicacion???", "Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                using (StreamWriter writer = new StreamWriter(Application.CommonAppDataPath+ "'\'listado.txt", true))
                {
                    foreach(Mascota item in this._listaDeMascotas)
                        writer.WriteLine(item.ToString());
                }
                e.Cancel = false;
            }
            e.Cancel = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mostrarListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar aux = new frmMostrar();
            aux.FormBorderStyle = FormBorderStyle.None;
            this.actualizarListado = new delegadoActualizador(aux.actualizarListado);
            aux.Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Salir(sender,e);

        }

    }
}
