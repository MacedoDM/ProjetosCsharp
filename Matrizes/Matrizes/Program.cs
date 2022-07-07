using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira as linhas e colunas que você deseja na matriz:");
            string[] line = Console.ReadLine().Split(' ');
            int L = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int[,] array = new int[L, C];

            Console.WriteLine("Digite os valores da matriz");

            for (int i = 0; i < L; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    array[L, C] = int.Parse(values[j]);
                }

            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (array[L, C] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (j > 0)
                        {
                            Console.WriteLine("Left " + array[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + array[i - 1, j]);
                        }
                        if (j < C - 1)
                        {
                            Console.WriteLine("Right: " + array[i, j + 1]);
                        }
                        if (i < L - 1)
                        {
                            Console.WriteLine("Down: " + array[i + 1, j]);
                        }
                    }
                }
            }




        }
    }
}

