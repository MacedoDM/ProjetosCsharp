using System;

namespace PostoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao posto, tecle o código do produto utilizado");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int x = int.Parse(Console.ReadLine());

            while (x != 4)
            {
                if (x == 1)
                {
                    Console.WriteLine("Álcool");
                    alcool = alcool + 1;
                }
                else if (x == 2)
                {
                    Console.WriteLine("Gasolina");
                    gasolina = gasolina + 1;
                }
                else if (x == 3)
                {
                    Console.WriteLine("Diesel");
                    diesel = diesel + 1;
                }

                x = int.Parse(Console.ReadLine());


            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool " + alcool);
            Console.WriteLine("Gasolina " + gasolina);
            Console.WriteLine("Diesel " + diesel);
        }
    }
}
