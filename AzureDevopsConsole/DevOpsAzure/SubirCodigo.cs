using AzureDevopsConsole.Publisher;
using System;

namespace AzureDevopsConsole.DevOpsAzure
{
    public class SubirCodigo
    {
        public ElementsMessagePublisher Publicador { get; set; } = new ElementsMessagePublisher();

        public SubirCodigo()
        {
        }

        public SubirCodigo(ElementsMessagePublisher messagePublisher)
        {
            Publicador = messagePublisher;
        }

        public void SubirCodigoToAzure()
        {
            Console.WriteLine("Commit de código version 1.1");

            Publicador.Notify();
        }
    }
}
