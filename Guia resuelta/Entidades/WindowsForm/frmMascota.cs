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

namespace WindowsForm
{
    public partial class frmMascota : frmAnimal
    {
        private Mascota _miMascota;
        public Mascota miMascota { get { return this._miMascota; } }
        public frmMascota()
        {
            InitializeComponent();
            this.cboxTipoDeMascota.Items.Add(eTipoDeMascota.exotica);
            this.cboxTipoDeMascota.Items.Add(eTipoDeMascota.hogareña);
            this.cboxTipoDeMascota.SelectedItem = eTipoDeMascota.exotica;
        }

        public frmMascota(Mascota mascota)
        {
            InitializeComponent();
            this.cboxTipoDeMascota.Items.Add(eTipoDeMascota.exotica);
            this.cboxTipoDeMascota.Items.Add(eTipoDeMascota.hogareña);
            this.cboxTipoDeMascota.SelectedItem = mascota.tipoDeMascota;
            this.txtEdad.Text = mascota.Edad.ToString();
            this.txtNombre.Text = mascota.nombre;
        }


        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this._miMascota = new Mascota(this.txtNombre.Text, (eTipoDeMascota)this.cboxTipoDeMascota.SelectedItem, int.Parse(this.txtEdad.Text));
            base.btnAceptar_Click(sender, e);
        }








    }
}
