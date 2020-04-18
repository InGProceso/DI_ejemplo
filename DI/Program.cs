using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        { 
            var notificar = new Notificador(new Correo());
            Console.WriteLine(notificar.Ejecutar());
        }
    }
}
