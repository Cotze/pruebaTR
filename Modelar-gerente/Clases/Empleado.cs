using Modelar_gerente.Interfaces;

/// <summary>
/// En esta clase están los objetos que determinan cada una de las caracteristicas que tiene el objeto Gerente.
/// Ademas que en esta clase se hereda uno de los métodos que establecidos en la interfaz.
/// Dado que solamente el nombre lo es pasado por el usuario la estatura ya esta definida.
/// </summary>

namespace Modelar_gerente.Clases
{
    public class Empleado : IDatosEmpleado
    {
        #region Variables
        string nombre;
        double estatura = 1.80;
        #endregion

        /// <summary>
        /// Mètodo del la clase Empleado donde se añadiran el param nombre para el uso dl metodo traido de la interfaz
        /// </summary>
        /// <param name="nombre"></param>
        public Empleado( string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Este mètodo se utiliza para dar funcionalidad a la altura del objeto gerente dado por la variable estatura
        /// </summary>
        /// <returns></returns>
        public double Altura()
        {
            return this.estatura;   
        }

        /// <summary>
        /// Este es el mètodo traido de la interfaz IDatosEmpleado donde se manda el mansaje, el nombre del gerente esta enttrevistando a una persona.
        /// </summary>
        /// <returns></returns>
        public string DatosEmpleado()
        {
            string datos = $"{ nombre } está entrevistando a una persona";
            return datos;
        }
        
    }
}
