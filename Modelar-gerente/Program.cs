using System;
using Modelar_gerente;

namespace Modelar_gerente
{
    internal class Program
    {
        /// <summary>
        /// Aqui empieza el proceso para la ejecucion del programa, se utliliza la peticion del usuario al código, ademas que se agrega una validación del gerente que esta entrevistando
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Gerente gerente = new Gerente();

            Console.WriteLine("Tienes una entrevista programada");
            Console.WriteLine("Escribe s para ver tu entrevista y n para cerrar");
            string texto;
            texto = Console.ReadLine();

            if (texto == "s")
            {
                
                gerente.mostrarDatos();
            }
            else 
            {
                Console.WriteLine("No cuentas con entrevistas programadas");
            }


        }


    }
}
