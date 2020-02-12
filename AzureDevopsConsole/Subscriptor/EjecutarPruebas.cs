using System;

namespace AzureDevopsConsole.Subscriptor
{
    public class EjecutarPruebas : ISubscriptor
    {
        public void notify()
        {
            Console.WriteLine("Se Ejecutaron las pruebas unitarias");
        }
    }
}
