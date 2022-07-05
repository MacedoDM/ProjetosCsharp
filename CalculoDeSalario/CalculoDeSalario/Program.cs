using System;

namespace CalculoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {

            Dados x;

            x = new Dados();

            Console.Write("Escreva o nome do funcionário: ");
            x.nome = Console.ReadLine();
            Console.Write("Escreva o salário bruto do funcionário: ");
            x.salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Escreva o imposto incidente no salário bruto do funcionário: ");
            x.imposto = double.Parse(Console.ReadLine());

            double y = (x.salarioBruto - x.imposto);

            Console.WriteLine("Nome do funcionário: " + x.nome);
            Console.WriteLine("Salário Bruto: " + x.salarioBruto);
            Console.WriteLine("Salário com o imposto descontado: " + y);
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double z = double.Parse(Console.ReadLine());

            double sf = (z / 100) * x.salarioBruto + y;
            Console.WriteLine("Dados atualizados: " + x.nome + ", " + sf);
        }
    }
}
