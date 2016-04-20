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
    public partial class frmDatosAlumno : frmAltaAlumno
    {
        public frmDatosAlumno() : base()
        {
            InitializeComponent();
        }

        public void actualizarAlumno (Alumno alumno1, EventArgs e)
        {
            this.txtNombre.Text = alumno1.nombre;
            this.txtApellido.Text = alumno1.apellido;
            this.txtDni.Text = alumno1.dni.ToString();
            this.pictureBox1.ImageLocation = alumno1.fotoAlumno;
        }
    }
}
