using Modelar_gerente.Interfaces;

/// <summary>
/// Aqui es el codigo de vestimenta dado por la empresa El Economista que todo empleado debe de respetar y cumplir durante su jornada laboral dentro del trabajo.
/// </summary>
namespace Modelar_gerente.Clases
{
    public class Vestimenta : IVestirse
    {

        #region Variables
        /// <summary>
        /// Zona de variables para el uso de esta clase.
        /// </summary>
        private string camisa;
        private string corbata;
        private string pantalon;
        private string calcetines;
        private string zapatos;
        #endregion

        /// <summary>
        /// Se esta integrado los datos de las siguientes clases hermanas para el metodo Vestirse.
        /// </summary>
        Saco saco = new Saco();
        Empresa empresa = new Empresa();

        /// <summary>
        /// Aqui es el metodo de vestimenta que resibira los param nombrados posteriormente.
        /// </summary>
        /// <param name="camisa"></param>
        /// <param name="corbata"></param>
        /// <param name="pantalon"></param>
        /// <param name="calcetines"></param>
        /// <param name="zapatos"></param>
        public Vestimenta(string camisa, string corbata, string pantalon, string calcetines, string zapatos)
        {
            this.camisa = camisa;
            this.corbata = corbata;
            this.pantalon = pantalon;
            this.calcetines = calcetines;
            this.zapatos = zapatos;

        }

        /// <summary>
        /// Este es el metodo traido de la interfaz IVestirse donde se manda un mensaje de como debe ir vestido el trabajador a las officinas.
        /// </summary>
        /// <returns></returns>
        public string Vestirse()
        {
            string ropa = $"El código de vestimenta de {empresa} es de { camisa } con { corbata }, { pantalon } tipo formal, { calcetines } de vestir con { zapatos } formales y con un saco de { saco } botones.";
            return ropa;

        }
    }

}
