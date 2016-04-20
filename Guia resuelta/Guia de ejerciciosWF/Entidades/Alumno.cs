using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Entidades
{
    public class Alumno
    {
        private string _apellido;
        public string apellido { get { return this._apellido; } set { this._apellido = value; } }
        private int _dni;
        public int dni { get { return this._dni; } set { this._dni = value; } }
        private string _fotoAlumno;
        public string fotoAlumno { get { return this._fotoAlumno; } set { this._fotoAlumno = value; } }
        private string _nombre;
        public string nombre { get { return this._nombre; } set { this._nombre = value; } }

        public Alumno(string nombre, string apellido, int dni, string fotoAlumno)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fotoAlumno = fotoAlumno;
        }



    }
}
