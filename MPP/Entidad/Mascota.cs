using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Mascota : Animal
    {
        private string _nombre;
        private ETipoDeMascota _tipoDeMascota;

        public string nombre { get { return this._nombre; } }
        public ETipoDeMascota tipoDeMascota { get { return this._tipoDeMascota; } }

        public Mascota(string nombre, ETipoDeMascota tipo, int edad) : base(edad)
        {
            this._nombre = nombre;
            this._tipoDeMascota = tipo;
        }

        public static int OrdenarPorEdad(Mascota mascotaUno, Mascota mascotaDos)
        {
            return mascotaUno.Edad - mascotaDos.Edad;
         
        }

        public static int OrdenarPorNombre(Mascota mascotaUno, Mascota mascotaDos)
        {
            return string.Compare(mascotaUno.nombre, mascotaDos.nombre);
   
        }

        public static int OrdenarPorTipo(Mascota mascotaUno, Mascota mascotaDos)
        {
            return string.Compare(mascotaUno.tipoDeMascota.ToString(), mascotaDos.tipoDeMascota.ToString());
        }

        public override string ToString()
        {
            return this.nombre+this.tipoDeMascota.ToString()+base.ToString();
        }


    }
}
