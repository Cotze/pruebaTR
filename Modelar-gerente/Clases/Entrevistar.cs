using Modelar_gerente.Interfaces;

namespace Modelar_gerente.Clases
{
    internal class Entrevistar : IEntrevistar
    {
        string entrevistar;

        public Entrevistar( string entrevistar)
        {
            this.entrevistar = entrevistar;
        }

        public string Entrevista()
        {
            string trabajo = $"{ entrevistar }";
            return trabajo;
        }
    }
}
