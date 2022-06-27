using System.Globalization;

namespace CheckPoint
{
    internal class Program
    {
        static public CultureInfo ptBR = new CultureInfo("pt-BR");
        static void Main(string[] args)
        {
            Conversao.Moeda();
            Conversao.MenuInicial();
            



        }
    }
}