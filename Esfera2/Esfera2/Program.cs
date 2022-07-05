using System;
using System.Globalization;

namespace Esfera2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Dados.Circunferencia(raio);
            double volume = Dados.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Dados.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
