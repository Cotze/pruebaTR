using Modelar_gerente.Interfaces;

/// <summary>
/// Esta clase hereda otro método de la interfaz.
/// El comportamiento de esta clase fungira a la acción que esta realizando el Gerente.
/// </summary>

namespace Modelar_gerente.Clases
{
    internal class Entrevistar : IEntrevistar
    {
        #region Variable
        string entrevistar;
        #endregion

        /// <summary>
        /// Se crea el mètodo entrevista pasandole un string con el objeto entrevista para instanciar la accion
        /// </summary>
        /// <param name="entrevistar"></param>
        public Entrevistar( string entrevistar)
        {
            this.entrevistar = entrevistar;
        }

        /// <summary>
        ///  Este es el mètodo traido de la interfaz IEntrevista se manda la accion a realizar del gerente.
        /// </summary>
        /// <returns></returns>
        public string Entrevista()
        {
            string trabajo = $"{ entrevistar }";
            return trabajo;
        }
    }
}
