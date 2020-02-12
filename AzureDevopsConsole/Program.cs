using AzureDevopsConsole.DevOpsAzure;
using AzureDevopsConsole.Subscriptor;
using System;

namespace AzureDevopsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuMessage = "***********************************************\n" +
                                 "* 1 - Subir Código                            *\n" +
                                 "* 2. Agregar Notificador                      *\n" +
                                 "* 3. Agregar Compilador                       *\n" +
                                 "* 4. Agregar Ejecutador de pruebas unitarias  *\n" +
                                 "* 5. Agregar Instalador                       *\n" +
                                 "* ------------------------------------------- *\n" +
                                 "* 6. Salir de la aplicación                   *\n" +
                                 "***********************************************\n" +
                                 "Selecciona una opción...";

            bool exitAplication = false;
            string option = string.Empty;
            string messageUser = "";
            SubirCodigo subirCodigo = new SubirCodigo();

            while (!exitAplication)
            {
                Console.WriteLine(menuMessage);
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        subirCodigo.SubirCodigoToAzure();
                        break;
                    case "2":
                        subirCodigo.Publicador.Subscrip(new Notificar());
                        break;
                    case "3":
                        subirCodigo.Publicador.Subscrip(new Compilador());
                        break;
                    case "4":
                        subirCodigo.Publicador.Subscrip(new EjecutarPruebas());
                        break;
                    case "5":
                        subirCodigo.Publicador.Subscrip(new Intalador());
                        break;
                    case "6":
                        messageUser = "Adios vaquero...";
                        exitAplication = true;
                        break;
                    default:
                        messageUser = "Selecciona una Opción Valida...";
                        break;
                }

                Console.WriteLine(messageUser);

            }
        }
    }
}
