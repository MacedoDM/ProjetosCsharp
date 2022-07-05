using System;
using System.Globalization;

namespace CompraDeDolares
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar?: ");
            double Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares o(a) senhor(a) deseja comprar? ");
            double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double conv = Dados.Conversao(Cotacao, Valor);

            Console.WriteLine("O valor a ser pago em reais é de: " + conv.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
