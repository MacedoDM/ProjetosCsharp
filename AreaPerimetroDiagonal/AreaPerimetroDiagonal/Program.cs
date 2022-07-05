using System;

namespace AreaPerimetroDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {

            Dados x, y;

            x = new Dados();

            Console.Write("Escreva a largura do retângulo: ");
            x.largura = double.Parse(Console.ReadLine());
            Console.Write("Escreva a altura do retângulo: ");
            x.altura = double.Parse(Console.ReadLine());


            double area = (x.largura * x.altura);
            double perimetro = ((2 * x.largura) + (2 * x.altura));
            double diagonal = Math.Sqrt((x.largura * x.largura) + (x.altura * x.altura));
            Console.WriteLine("A área do retângulo é: " + area);
            Console.WriteLine("O perímetro do retângulo é: " + perimetro);
            Console.WriteLine("A diagonal do retângulo é: " + diagonal);
        }
    }
}
