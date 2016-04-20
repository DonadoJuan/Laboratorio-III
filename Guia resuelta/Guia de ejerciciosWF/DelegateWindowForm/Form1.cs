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

namespace DelegateWindowForm
{
    public delegate void delegadoActualizador (string nombre);
    public delegate void delegadoActualizador2(Alumno alumno, EventArgs e);
    public partial class Form1 : Form
    {
        private frmTestDelegados auxDelegados;
        private frmDatos auxDatos;
        private frmAltaAlumno auxFrmAltaAlumno;
        private frmDatosAlumno auxFrmDatosAlumno;
        public delegadoActualizador objDelegado;
        public delegadoActualizador objDelegado2;
        public delegadoActualizador2 MostrarAlumnoPorDelegado;
        public Form1()
        {
            InitializeComponent();
            auxDelegados = new frmTestDelegados();
            auxDatos = new frmDatos();
            auxFrmDatosAlumno = new frmDatosAlumno();
            auxFrmAltaAlumno = new frmAltaAlumno();
            objDelegado = new delegadoActualizador(auxDatos.ActualizarNombre);
            objDelegado2 = new delegadoActualizador(auxDatos.ActualizarFoto);
            MostrarAlumnoPorDelegado = new delegadoActualizador2(auxFrmDatosAlumno.actualizarAlumno);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //auxform.Owner = this;
            this.auxDelegados.Show(this);
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.auxFrmAltaAlumno.Show(this);
            //this.MostrarAlumnoPorDelegado(new Alumno("Juan", "DDFSDF", 386231, "RUTALOCA"), e);
        }

        private void mostrarDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.auxDatos.Show(this);
        }

        private void mostrarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            auxFrmDatosAlumno.MdiParent = this;
            auxFrmDatosAlumno.Show();
            
            
        }
    }
}
