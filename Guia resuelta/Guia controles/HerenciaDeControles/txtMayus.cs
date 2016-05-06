using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaDeControles
{
    public class txtMayus : TextBox
    {
        private delegate void ManejadorMayus();
        private event ManejadorMayus AvisarCapsLockEvent;
        ErrorProvider error;

        public txtMayus()
        {
            this.AvisarCapsLockEvent += new ManejadorMayus(this.AvisarCapsLock);
            error = new ErrorProvider();
        }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                this.AvisarCapsLockEvent();
            else
                error.Clear();

            base.OnKeyPress(e);
        }
        private void AvisarCapsLock()
        { 

            error.SetError(this, "La tecla 'capsLock' esta activada");
            
        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

    }
}