using System;

namespace IntervaloDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número");
            Double x = Double.Parse(Console.ReadLine());

            if (x <= 25 && x >= 0)
            {
                Console.WriteLine("O número escolhido pertence ao intervalo [0,25]");

            }
            else if (x <= 50 && x > 25)
            {
                Console.WriteLine("O número escolhido pertence ao intervalo (25,50]");
            }
            else if (x <= 75 && x > 50)
            {
                Console.WriteLine("O número escolhido pertence ao intervalo (50,75]");
            }
            else if (x <= 100 && x > 75)
            {
                Console.WriteLine("O número escolhido pertence ao intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }



        }
    }
}
