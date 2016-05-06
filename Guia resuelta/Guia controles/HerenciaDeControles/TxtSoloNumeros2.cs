using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaDeControles
{
    public enum ETipoDato { Entero, Doble, Binario, Octal, Hexadecimal };
    class TxtSoloNumeros2 : TextBox
    {
        public ETipoDato TipoDeDato { get; set; }

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            switch (TipoDeDato)
            {
                case ETipoDato.Entero: if(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                                            base.OnKeyPress(e);
                                        else
                                            e.Handled = true;
                    break;
                case ETipoDato.Doble:   if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',')
                                            base.OnKeyPress(e);
                                        else
                                            e.Handled = true;
                    break;
                case ETipoDato.Binario: if (e.KeyChar == '0' || e.KeyChar == '1')
                                            base.OnKeyPress(e);
                                        else
                                            e.Handled = true;
                    break;
                case ETipoDato.Octal:   if(Char.IsDigit(e.KeyChar) && e.KeyChar <= 7) 
                                           base.OnKeyPress(e);
                                        else
                                            e.Handled = true;
                    break;
                case ETipoDato.Hexadecimal: if (Char.IsDigit(e.KeyChar) || char.IsUpper(e.KeyChar))
                                                base.OnKeyPress(e);
                                            else
                                                e.Handled = true;
                    break;
                                        
                                        
            }
        }
    }
}
