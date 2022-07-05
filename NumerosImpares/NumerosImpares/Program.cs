using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número natural ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine("Fim");
        }
    }
}
