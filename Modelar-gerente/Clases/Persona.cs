/// <summary>
/// En esta clase se encuentra los datos de persona que va tener entrevista con gerente
/// </summary>

namespace Modelar_gerente
{
    public class Persona
    {
        /// <summary>
        /// Se crea la variable persona con el get y el set para obtener y enviar los datos solcitados para su uso
        /// </summary>
        public string persona { get; set; }

        /// <summary>
        /// El mètodo Persona obtiene los datos de la variable persona que seran ocupados posteriormente
        /// </summary>
        /// <param name="persona"></param>
        public Persona(string persona)
        {
            this.persona = persona;
        }

    }
}
