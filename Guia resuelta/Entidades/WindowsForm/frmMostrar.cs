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
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        public void actualizarListado(List<Mascota> lista)
        {
            this.lstMostrar.Items.Clear();
            foreach (Mascota item in lista)
            {
                this.lstMostrar.Items.Add(item.ToString());
            }
        }
    }
}
