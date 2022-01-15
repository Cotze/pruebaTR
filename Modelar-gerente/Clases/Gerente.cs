/// <summary>
/// Como en todas las empresas se manejan diferentes cargos al personal, se necesita establecer que tipo de puesto tiene cada uno
/// por ello existe esta clase con su método dado que se tiene que asignar un puesto al Gerente.
/// </summary>

namespace Modelar_gerente
{
    public class Gerente
    {
        #region Variables
        string puesto;
        #endregion

        /// <summary>
        /// Se crea el mètodo Gerente pasandole un string con el objeto puesto para instanciar el cargo que tiene el objeto
        /// </summary>
        /// <param name="puesto"></param>
        public Gerente(string puesto)
        {
            this.puesto = puesto;
        }
    }

    
}
