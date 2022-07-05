using System;

namespace AreaDeTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3;
            Console.WriteLine("Entre com as medidas do 1° triângulo:");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do 2° triângulo:");
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());

            double p = (x1 + x2 + x3) / 2;
            double areax = Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));

            p = (y1 + y2 + y3) / 2;
            double areay = Math.Sqrt(p * (p - y1) * (p - y2) * (p - y3));

            Console.WriteLine("Área de x = " + areax.ToString("F4"));
            Console.WriteLine("Área de y = " + areay.ToString("F4"));

            if (areax > areay)
            {
                Console.WriteLine("Maior área X");
            }
            else
            {
                Console.WriteLine("Maior área Y");
            }

        }
    }
}
