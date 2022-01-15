/// <summary>
/// En esta interfaz creo los métodos que se utilizaran en algunas clases.
/// Dada la situación del problema he decidido crear solamente 3 métodos que fungiran el comportamineto del objeto Gerente.
/// </summary>

namespace Modelar_gerente.Interfaces
{
   /// <summary>
   /// Este mètodo sirve para que el objeto gerente realice la accion de vestirse
   /// </summary>
    public interface IVestirse
    {
        string Vestirse();
    }
    /// <summary>
    /// Este mètodo sirve para que el objeto gerente  realice la accion de entrevistar.
    /// </summary>
    public interface IEntrevistar
    {
        string Entrevista();
    }
    /// <summary>
    /// Este mètodo sirve para que se obtenagn los atributos del objeto gerente.
    /// </summary>
    public interface IDatosEmpleado
    {
        string DatosEmpleado();
    }

}
