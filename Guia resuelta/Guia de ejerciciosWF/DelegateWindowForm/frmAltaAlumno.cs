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
    public partial class frmAltaAlumno : Form
    {
        private Alumno auxAlumno;
        private string rutaDeArchivo;
        public frmAltaAlumno()
        {
            InitializeComponent();
            this.ConfigurarOpenSaveFileDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.auxAlumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, Int32.Parse(this.txtDni.Text), this.rutaDeArchivo);
            ((Form1)this.Owner).MostrarAlumnoPorDelegado(this.auxAlumno, e);
        }

        private void ConfigurarOpenSaveFileDialog()
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.DefaultExt = ".jpg";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Seleccione una foto...";
        }

        private void txtFoto_TextChanged(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                this.rutaDeArchivo = this.openFileDialog1.FileName;
        }
    }
}
