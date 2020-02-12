using System;

namespace AzureDevopsConsole.Subscriptor
{
    public class Intalador : ISubscriptor
    {
        public void notify()
        {
            Console.WriteLine("Se instalo la version 1.1");

        }
    }
}
