namespace Modelar_gerente.Interfaces;
{
    public class Vestimenta
    {
        string camisa;
        string corbata;
        string cinturon;
        string pantalon;
        string calcetines;
        string zapatos;
        string saco;
    }

    public string Vestimenta( string camisa, string corbata, string cinturon, string pantalon, string calcetines, string zapatos, string saco)
    {
        this.camisa = camisa;
        this.corbata = corbata;
        this.cinturon = cinturon;
        this.pantalon = pantalon;
        this.calcetinees = calcetines;
        this.zapatos = zapatos;
        this.saco = saco;
    }
}
