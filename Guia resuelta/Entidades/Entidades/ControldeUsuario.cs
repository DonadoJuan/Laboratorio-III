using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Entidades
{
    public class ControldeUsuario : TextBox
    {
        public enum Modo { SoloNumeros, SoloLetras }        
        public Modo modoSeleccionado { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if(this.modoSeleccionado == Modo.SoloNumeros)
            {
                if(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    base.OnKeyPress(e);
                }
                else
                    e.Handled = true;
            }

            if (this.modoSeleccionado == Modo.SoloLetras)
            {
                if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    base.OnKeyPress(e);
                }
                else
                    e.Handled = true;
            }
        }
    }
}
