using Modelar_gerente.Interfaces;
using Modelar_gerente.Clases;

namespace Modelar_gerente.Clases
{
    internal class Saco : IVestirse
    {
        
        int botones;
        string vestimenta : Vestimenta


        public Saco( int botones, string vestimenta)
        { 
            this.botones = botones;
            this.vestimenta = vestimenta;
        }

        public string Vestirse()
        {
            string vestirse = $"{botones}";
            return vestirse;
        }
    }
}
