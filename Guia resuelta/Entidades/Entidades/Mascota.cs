using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota : Animal
    {
        private string _nombre;
        private eTipoDeMascota _tipoDeMascota;

        public string nombre { get { return this._nombre; } }
        public eTipoDeMascota tipoDeMascota { get { return this._tipoDeMascota; } }

        public Mascota (string nombre, eTipoDeMascota tipoDeMascota, int edad ) :base(edad)
        {
            this._nombre = nombre;
            this._tipoDeMascota = tipoDeMascota;
        }

        public static int OrdenarPorEdad (Mascota mascota1, Mascota mascota2)
        {
            return mascota1.Edad - mascota2.Edad;
        }

        public static int ordenarPorNombre(Mascota mascota1, Mascota mascota2)
        {
            return string.Compare(mascota1.nombre, mascota2.nombre);
        }

        public static int ordenarPorTipo(Mascota mascota1, Mascota mascota2)
        {
            return string.Compare(mascota1.tipoDeMascota.ToString(), mascota2.tipoDeMascota.ToString());
        }

        public override string ToString()
        {
            return base.ToString()+" - "+this._nombre+" - "+this._tipoDeMascota;
        }
    }
}
