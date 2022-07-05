using System;

namespace NotaDeSemestre
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados X;

            X = new Dados();

            Console.WriteLine("Entre com o nome do aluno:");
            Console.Write("Nome: ");
            X.Nome = Console.ReadLine();
            Console.Write("Entre com a 1° nota: ");
            X.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a 2° nota: ");
            X.Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a 3° nota: ");
            X.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine(X.NotaFinal());


            if (X.Aprovado())
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
                Console.WriteLine("Falta(m) " + X.NotaRestante() + " ponto(s)");
            }

        }
    }
}
