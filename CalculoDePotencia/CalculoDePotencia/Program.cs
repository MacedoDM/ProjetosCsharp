using System;

namespace CalculoDePotencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números você quer inserir?  ");
            int n = int.Parse(Console.ReadLine());
            int x;
            int y;

            for (int i = 1; i <= n; i++)
            {
                x = i * i;
                y = i * i * i;

                Console.Write(i);
                Console.Write(" " + x);
                Console.WriteLine(" " + y);

            }

        }
    }
}
