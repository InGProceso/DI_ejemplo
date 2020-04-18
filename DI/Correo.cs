using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    class Correo : IMedioEnvio
    {
        public string Enviar()
        {
            var cadena = "Enviando por medio de Correo";
            return cadena;
        }
    }
}
