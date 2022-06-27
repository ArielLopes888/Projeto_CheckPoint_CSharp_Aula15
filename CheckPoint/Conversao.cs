using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint
{
    static class Conversao
    {
        static private decimal valorFinal;
        static private SortedList moedas = new SortedList();
        static private string[] simbolosMoedas = { "$", "€", "¥", "£", "R$"};


        static public void MenuInicial()
        {
            Moeda();
            Console.WriteLine("Selecione a moeda que deseja trocar:");
            for (int i=0; i<moedas.Count;i++)
            {
                Console.WriteLine($"{i + 1} - {moedas.GetKey(i)}");
            }
            //Console.WriteLine("\n1 - Dolar");
            //Console.WriteLine("2 - Euro");
            //Console.WriteLine("3 - Iene");
            //Console.WriteLine("4 - Libra");
            //Console.WriteLine("5 - Real");
            int opcao = TratarEntradas.PegarEntradaIntDoUsuario();
            Console.WriteLine($"Digite o valor em {moedas.GetKey(opcao-1)}:");
            decimal valorRecebido = TratarEntradas.PegarEntradaDecimalDoUsuario();
            decimal valorFinal = ConverterParaReal(opcao, valorRecebido);

            Console.WriteLine("Selecione a moeda para qual deseja converter:");
            for (int i = 0; i < moedas.Count; i++)
            {
                if(i!=opcao-1)
                    Console.WriteLine($"{i + 1} - {moedas.GetKey(i)}");
            }
            opcao = TratarEntradas.PegarEntradaIntDoUsuario();
            valorFinal = ConverterReal(opcao, valorFinal);
            Console.WriteLine($"O valor em {moedas.GetKey(opcao - 1)} é {simbolosMoedas[opcao - 1]} {valorFinal} ");

        }
        static public void Moeda()
        {
            moedas.Add("dolar", 4.50M);
            moedas.Add("euro", 6.20M);
            moedas.Add("iene", 0.052M);
            moedas.Add("libra", 6.95M);
            moedas.Add("real", 1M);
        }

        static public decimal ConverterReal(int opcao, decimal valorRecebido)
        {
            valorFinal = valorRecebido / (decimal)moedas.GetByIndex(opcao-1);
            return valorFinal;
        }

        static public decimal ConverterParaReal(int opcao, decimal valorRecebido)
        {
            valorFinal = valorRecebido * (decimal)moedas.GetByIndex(opcao - 1);
            return valorFinal;
        }

    }
}
