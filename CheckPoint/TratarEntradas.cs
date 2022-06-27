using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint
{
    public class TratarEntradas
    {
        public static double PegarEntradaDoubleDoUsuario()
        {
            string db = Console.ReadLine();
            bool valida = ValidarDouble(db);
            double valor;
            while (!valida)
            {
                Console.Write("Tente de novo: ");
                db = Console.ReadLine();
                valida = ValidarDouble(db);
            }
            valor = double.Parse(db);
            return valor;
        }

        private static bool ValidarDouble(string db)
        {
            double variavel;
            bool valida = true;
            try
            {
                variavel = double.Parse(db);
            }
            catch
            {
                Console.WriteLine("Por favor, digite um valor válido. O valor inserido deve ser um número real.");
                valida = false;
            }
            return valida;
        }

        public static int PegarEntradaIntDoUsuario()
        {
            string db = Console.ReadLine();
            bool valida = ValidarInt(db);
            int valor;
            while (!valida)
            {
                Console.Write("Tente de novo: ");
                db = Console.ReadLine();
                valida = ValidarDouble(db);
            }
            valor = int.Parse(db);
            return valor;
        }

        private static bool ValidarInt(string db)
        {
            int variavel;
            bool valida = true;
            try
            {
                variavel = int.Parse(db);
            }
            catch
            {
                Console.WriteLine("Por favor, digite um valor válido. O valor inserido deve ser um número real.");
                valida = false;
            }
            return valida;
        }
    }
}
