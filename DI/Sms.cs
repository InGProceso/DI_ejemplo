using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    class Sms : IMedioEnvio
    {
        public string Enviar()
        {
            var cadena = " por medio de SMS";
            return cadena;
        }
    }
}
