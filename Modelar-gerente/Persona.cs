using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelar_gerente
{
    public class Persona
    {
        public string Nombre { get; set; }

        /// <summary>
        /// Variable asignada para el uso en la clse gerente
        /// </summary>
        public Persona()
        {
            Nombre = "Carlos";
        }
    }
}
