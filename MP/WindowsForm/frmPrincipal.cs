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
    public partial class frmPrincipal : Form
    {
        private enum ETipoDeOrdenamiento { PorEdad, PorNombre, PorTipo };
        private List<Mascota> _listaDeMascotas;

        public frmPrincipal()
        {
            InitializeComponent();
            this._listaDeMascotas = new List<Mascota>();
            this.cbxOrden.Items.Add(ETipoDeOrdenamiento.PorEdad);
            this.cbxOrden.Items.Add(ETipoDeOrdenamiento.PorNombre);
            this.cbxOrden.Items.Add(ETipoDeOrdenamiento.PorTipo);

        }

        private void cbxOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comparison<Mascota> comparison = null;

            switch (this.cbxOrden.Text)
            {
                case "PorEdad": comparison = new Comparison<Mascota>(Mascota.OrdenarPorEdad);
                    break;
            }
        }


    }
}
