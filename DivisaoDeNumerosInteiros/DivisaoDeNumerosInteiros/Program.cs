using System;

namespace DivisaoDeNumerosInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos pares de números você quer inserir?  ");
            int n = int.Parse(Console.ReadLine());

            double c;

            for (int i = 1; i <= n; i++)
            {

                Console.Write("Digite o primeiro número: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double b = double.Parse(Console.ReadLine());

                if (b != 0)
                {
                    c = a / b;
                    Console.WriteLine("O resultado é " + c);
                }
                else
                {
                    Console.WriteLine("Divisão impossível");
                }



            }
        }
}
