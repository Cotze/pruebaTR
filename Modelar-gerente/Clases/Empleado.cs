using Modelar_gerente.Interfaces;




namespace Modelar_gerente.Clases
{
    public class Empleado : IDatosEmpleado
    {


        string nombre;
        float estatura;

        Gerente gerente = new Gerente();
        Empresa empresa = new Empresa();

        public Empleado( string nombre, float estatura)
        {
            this.nombre = nombre;
            this.estatura = estatura;
        }

        public string DatosEmpleado()
        {
            string datos = $"El { gerente } de la { empresa } es un empleado que mide { estatura } m, se llama { nombre }";
            return datos;
        }
        
    }
}
