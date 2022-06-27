using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CheckPoint
{
    public class TratarEntradas
    {
        public static decimal PegarEntradaDecimalDoUsuario()
        {
            string db = Console.ReadLine();
            if (db.Contains('.'))
                db = db.Replace('.', ',');
            bool valida = ValidarDecimal(db);
            decimal valor;
            while (!valida)
            {
                Console.Write("Tente de novo: ");
                db = Console.ReadLine();
                valida = ValidarDecimal(db);
            }
            valor = decimal.Parse(db);
            return valor;
        }

        private static bool ValidarDecimal(string db)
        {
            decimal variavel;
            bool valida = true;
            try
            {
                variavel = decimal.Parse(db);
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
                valida = ValidarInt(db);
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

                if (variavel < 1 || variavel > 5)
                    throw new Exception();

            }
            catch
            {
                Console.WriteLine("Por favor, digite um valor válido. O valor inserido deve ser um número inteiro entre 1 e 5.");
                valida = false;
            }
            return valida;
        }

        public static int TratarSegundaEntradaInt(int opcao)
        {
            int input;
            input = PegarEntradaIntDoUsuario();
            while (opcao == input)
            {
                Console.WriteLine("Digite um dos valores válidos deste menu:");
                input = PegarEntradaIntDoUsuario();
            } 
            return input;
            
        }
    }
}
