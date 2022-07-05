using System;

namespace AreaDeTriangulosOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do 1° triângulo:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do 2° triângulo:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2;
            double areax = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            double areay = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

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
