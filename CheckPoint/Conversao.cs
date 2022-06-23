using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint
{
    class Conversao
    {
        private decimal valorFinal;
        private Dictionary<string, decimal> moeda = new Dictionary<string, decimal>();
        public void Moeda()
        {
            moeda.Add("dolar", 4.50M);
            moeda.Add("euro", 6.20M);
            moeda.Add("iene", 0.052M);
            moeda.Add("libra", 6.95M);
        }

        public decimal ConverterReal(int opcao, decimal valorRecebido)
        {
            switch (opcao)
            {
                case 1:
                    valorFinal = valorRecebido / moeda["dolar"];
                    break;
                case 2:
                    valorFinal = valorRecebido / moeda["euro"];
                    break;
                case 3:
                    valorFinal = valorRecebido / moeda["iene"];
                    break;
                case 4:
                    valorFinal = valorRecebido / moeda["libra"];
                    break;
            }
            return valorFinal;
        }

        public decimal ConverterParaReal(int opcao, decimal valorRecebido)
        {
            switch (opcao)
            {
                case 1:
                    valorFinal = valorRecebido * moeda["dolar"];
                    break;
                case 2:
                    valorFinal = valorRecebido * moeda["euro"];
                    break;
                case 3:
                    valorFinal = valorRecebido * moeda["iene"];
                    break;
                case 4:
                    valorFinal = valorRecebido * moeda["libra"];
                    break;
            }
            return valorFinal;
        }

    }
}

