using System;

namespace SalarioDeFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados X;

            X = new Dados();

            Console.WriteLine("Entre os dados do funcionário:");
            Console.Write("Nome: ");
            X.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            X.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            X.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(X);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());

            X.AumentarSalario(porcent);

            Console.WriteLine(X);

        }
    }
}
