using System;

namespace QuemEMaisVelho
{
    class Program
    {
        static void Main(string[] args)
        {

            Idade x, y;

            x = new Idade();
            y = new Idade();

            Console.Write("Nome da primeira pessoa: ");
            x.nome = Console.ReadLine();
            Console.Write("Entre com a idade de " + x.nome + ": ");
            x.idade = int.Parse(Console.ReadLine());

            Console.Write("Nome da segunda pessoa: ");
            y.nome = Console.ReadLine();
            Console.Write("Entre com a idade de " + y.nome + ": ");
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade)
            {
                Console.WriteLine(x.nome + " é mais velho(a) que " + y.nome);
            }
            else
            {
                Console.WriteLine(y.nome + " é mais velho que " + x.nome);
            }
        }
    }
}
