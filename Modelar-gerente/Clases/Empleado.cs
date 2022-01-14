using System;

using Modelar_gerente.Interfaces;




namespace Modelar_gerente.Clases
{
    public class Empleado : IDatosEmpleado
    {

        string nombre;
        float estatura;

        public Empleado( string nombre)
        {
            this.nombre = nombre;
        }

        public string DatosEmpleado()
        {
            string datos = $"{ nombre } está entrevistando a una persona";
            return datos;
        }
        
    }
}
