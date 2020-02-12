using System;

namespace AzureDevopsConsole.Subscriptor
{
    public class Notificar : ISubscriptor
    {
        public void notify()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}
