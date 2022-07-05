using System;

namespace CoordenadaQuadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite suas cordenadas");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro quadrante");
                    Console.WriteLine("Digite novas coordenadas");

                }

                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                    Console.WriteLine("Digite novas coordenadas");

                }

                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                    Console.WriteLine("Digite novas coordenadas");

                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto Quadrante");
                    Console.WriteLine("Digite novas coordenadas");

                }
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Coordenada nula");
        }
    }
}
