using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Banco B;

            Console.WriteLine("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor para depósito inicial (R$): ");
                double saldo = double.Parse(Console.ReadLine());
                B = new Banco(numero, titular, saldo);
            }

            else
            {
                B = new Banco(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(B);
            Console.WriteLine();

            Console.WriteLine("Digite o valor para depósito (R$): ");
            double quantia = double.Parse(Console.ReadLine());
            B.Deposito(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(B);

            Console.WriteLine("Digite o valor para saque (R$): ");
            quantia = double.Parse(Console.ReadLine());
            B.Saque(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(B);
        }


    }
}