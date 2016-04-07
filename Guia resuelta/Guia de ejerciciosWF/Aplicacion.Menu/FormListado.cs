using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacion.Menu
{
    public partial class FormListado : Form
    {
        // private List<Usuario> _listBoxPersonas;
        public FormListado(List<Usuario> listadoUsuarios, bool admin)
        {
            InitializeComponent();
                if (admin)
                    foreach (Usuario item in listadoUsuarios)
                        this.lstUsuarios.Items.Add(item._usuario + "-" + item._contraseña + "-" + item._email);
                else
                    foreach (Usuario item in listadoUsuarios)
                        this.lstUsuarios.Items.Add(item._usuario + "-*****-*****");
        }

    }
}
