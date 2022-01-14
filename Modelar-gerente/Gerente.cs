using Modelar_gerente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelar_gerente
{
    public class Gerente
    {
        Persona persona = new Persona();
        
        string nombre;

        public string Nombre { get => Nombre; set => Nombre = value; }


        public Gerente()
        {
            
        }

        public Gerente(String nom)
        {
            this.nombre = nom;
        }
        /// <summary>
        /// Metodo para escribir el nombre del gerente solicitado por el usuario e imprimido en consola
        /// </summary>
        public void mostrarDatos()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Escribir el nombre del gerente que te entrevistara: ");
            this.nombre = Console.ReadLine();
            Console.WriteLine("");
         
            Console.WriteLine($"{nombre} esta entrevistando a {persona.Nombre}" );

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Favor de revisar la plataforma mas tarde");
            
        }
    }
}
