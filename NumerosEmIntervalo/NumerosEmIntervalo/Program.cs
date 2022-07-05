using System;

namespace NumerosEmIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você quer digitar?  ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite o número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 10 && numero <= 20)
                {
                    a = a + 1;
                }
                else
                {
                    b = b + 1;
                }
            }

            Console.WriteLine(a + " IN");
            Console.WriteLine(b + " OUT");
        }
    }
}
