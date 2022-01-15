/// <summary>
/// En el ejemplo no muestra un nombre de alguna empresa donde trabaja el Gerente.
/// Por ello creé este método para futuras referencias y/o utilizaciones.
/// </summary>

namespace Modelar_gerente.Clases
{
    public class Empresa
    {

        #region Variable
        public string nombreEmpresa;
        #endregion

        /// <summary>
        /// En este mètodo se agregara el nombre de la empresa para su uso en la clase vestiemnta
        /// </summary>
        public Empresa()
        {
            this.nombreEmpresa = "EL Economista";
        }

    }
}
