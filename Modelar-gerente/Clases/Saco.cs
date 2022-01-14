using Modelar_gerente.Interfaces;

namespace Modelar_gerente.Clases
{
    internal class Saco : IVestirse
    {
        
        int botones;

        public Saco( int botones)
        { 
            this.botones = botones;
        }

        public string Vestirse()
        {
            string vestirse = $"{botones}";
            return vestirse;
        }
    }
}
