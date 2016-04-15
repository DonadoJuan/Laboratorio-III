using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateWindowForm
{
    public partial class Form1 : Form
    {
        public string actualizarNombrePorDelegado { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados auxform = new frmTestDelegados();
            //auxform.Owner = this;
            auxform.Show(this);

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos auxform = new frmDatos();
            //auxform.Owner = this;
            auxform.Show(this);
        }
    }
}
