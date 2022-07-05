using System;

namespace MediaComPesos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos testes você quer inserir?  ");
            int n = int.Parse(Console.ReadLine());

            double a = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os três valores:");
                double n1 = double.Parse(Console.ReadLine());
                double n2 = double.Parse(Console.ReadLine());
                double n3 = double.Parse(Console.ReadLine());

                a = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

                Console.WriteLine("Média " + i + " = " + a);

            }

        }
    }
}
