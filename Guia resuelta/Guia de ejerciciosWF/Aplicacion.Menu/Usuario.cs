using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion.Menu
{
    public class Usuario
    {
        public string _usuario;
        public string _contraseña;
        public string _email;
        public bool _admin;

        public Usuario()
        { }
        public Usuario(string usuario, string contraseña, string email, bool admin)
        {
            this._usuario = usuario;
            this._contraseña = contraseña;
            this._email = email;
            this._admin = admin;
        }


    }
}
