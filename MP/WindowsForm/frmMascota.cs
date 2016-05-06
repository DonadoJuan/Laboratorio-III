using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace WindowsForm
{
    public partial class frmMascota : frmAnimal
    {
        private Mascota _miMascota;

        public Mascota miMascota { get{ return this._miMascota; }}

        public frmMascota()
        {
            InitializeComponent();
            this.comboBox1.Items.Add(ETipoDeMascota.exotica);
            this.comboBox1.Items.Add(ETipoDeMascota.hogareña);
            this.comboBox1.SelectedItem = ETipoDeMascota.exotica;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this._miMascota = new Mascota(this.txtNombre.Text, (ETipoDeMascota)this.comboBox1.SelectedItem, int.Parse(this.txtEdad.Text));
            base.btnAceptar_Click(sender, e);
        }


    }
}
