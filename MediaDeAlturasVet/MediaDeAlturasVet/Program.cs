using System;

namespace MediaDeAlturasVet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a quantidade de pessoas que deseja a média: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            Console.WriteLine("Digite as alturas");

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Altura média: " + avg);
        }
    }
}
