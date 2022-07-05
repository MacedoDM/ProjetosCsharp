using System;

namespace MediaDeSalarios
{
    class Program
    {
        static void Main(string[] args)
        {

            Cadastro x, y;

            x = new Cadastro();
            y = new Cadastro();

            Console.Write("Nome da primeira pessoa: ");
            x.nome = Console.ReadLine();
            Console.Write("Entre com o salário de " + x.nome + ": ");
            x.salario = int.Parse(Console.ReadLine());

            Console.Write("Nome da segunda pessoa: ");
            y.nome = Console.ReadLine();
            Console.Write("Entre com o salário de " + y.nome + ": ");
            y.salario = int.Parse(Console.ReadLine());

            double media = (x.salario + y.salario) / 2;
            Console.WriteLine("A média de salário é: " + media);
        }
    }
}
