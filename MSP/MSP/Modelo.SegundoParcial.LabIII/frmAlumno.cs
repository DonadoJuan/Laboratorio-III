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
namespace Modelo.SegundoParcial.LabIII
{
    public partial class frmAlumno : Form
    {
        private Alumno _MiAlumno;
        public Alumno MiAlumno { get { return this._MiAlumno; } }

        public frmAlumno()
        {
            InitializeComponent();
            this._MiAlumno = null;
            this.cboxCurso.Items.Add("Matematica");
            this.cboxCurso.Items.Add("Geografia");
            this.cboxCurso.Items.Add("Biologia");
        }

        public frmAlumno(string legajo, string apellido, string codCurso) : this()
        {
            this.txtLegajo.Text = legajo;
            this.txtApellido.Text = apellido;
            //this.cboxCurso.Text = codCurso;

            switch (codCurso)
            {
                case "1000":
                    this.cboxCurso.SelectedItem = "Matematica";
                    break;
                case "1005":
                    this.cboxCurso.SelectedItem = "Geografia";
                    break;
                case "1010":
                    this.cboxCurso.SelectedItem = "Biologia";
                    break;
                default:
                    MessageBox.Show("Error en CONSTRUCTOR");
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int codCurso = 0000;
            switch ((String) this.cboxCurso.SelectedItem)
            {
                case "Matematica":  codCurso = 1000;
                break;
                case "Geografia":  codCurso = 1005;
                break;
                case "Biologia":  codCurso = 1010;
                break;
                default: MessageBox.Show("Error en BTNACEPTAR");
                break;           
            }
            this._MiAlumno = new Alumno(this.txtApellido.Text, codCurso , Int32.Parse(this.txtLegajo.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            if (this.Text == "Modificacion")
                this.txtLegajo.ReadOnly = true;
        }
    }
}
