using System;

using Modelar_gerente.Clases;

namespace Modelar_gerente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el nombre del Gerente");
            string texto;
            texto = Console.ReadLine();

            Empleado dato = new Empleado( texto );
            Console.WriteLine(dato.DatosEmpleado());
            

        }

    }
}
