using System;

namespace NovoCalculoDeTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos x, y;

            x = new Calculos();
            y = new Calculos();

            Console.WriteLine("Entre com as medidas do 1° triângulo:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do 2° triângulo:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areax = x.Area();

            double areay = y.Area();

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
