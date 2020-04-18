using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    class Notificador
    {
        
        public Notificador(IMedioEnvio metodoEnvio)
        {
            _metodoEnvio = metodoEnvio;
        }

        private IMedioEnvio _metodoEnvio;

        public string Ejecutar()
        {
            return _metodoEnvio.Enviar();
        }
    }
}

