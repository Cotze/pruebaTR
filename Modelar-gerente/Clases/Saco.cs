using Modelar_gerente.Interfaces;

/// <summary>
/// Aqui en esta clase Se le integra la interfaz de vestirse 
/// </summary>
namespace Modelar_gerente.Clases
{
    public class Saco 
    {
        #region Variables
        public int botones;
        #endregion

        /// <summary>
        /// En este metodo se le asigna el valor que necesita la variable botones para su uso en la clase vestimenta
        /// </summary>
        public Saco()
        {
            botones = 3;
        }
      
    }
}
