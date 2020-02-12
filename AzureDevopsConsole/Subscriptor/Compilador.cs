using System;

namespace AzureDevopsConsole.Subscriptor
{
    public class Compilador : ISubscriptor
    {
        public void notify()
        {
            Console.WriteLine("Se compilo correctamente");
        }
    }
}
