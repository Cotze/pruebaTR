using System;

using Modelar_gerente.Clases;

namespace Modelar_gerente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///En esta parte del program se obtienen los datos pasados por el usuario
            ///para este ejercicio concretamente se obtiene el nombre
            ///</summary>
            Console.WriteLine("Escribe el nombre del Gerente");
            string texto;
            texto = Console.ReadLine();
            Console.WriteLine("");

            ///<summary>
            ///Obtenemos los metodos y atributos de la clase empleado donde en esa clase se heredo un mètodo de la interfaz.
            ///Aqui se obtiene el dato del usuario y se imprime el mensaje del mètodo DatosEmpleado que se declaro en la clase Empleado.
            ///</summary>
            Empleado dato = new Empleado( texto );
            Console.WriteLine(dato.DatosEmpleado());

        }

    }
}
