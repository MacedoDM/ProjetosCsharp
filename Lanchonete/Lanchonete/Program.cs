using System;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o código do produto e a quantidade");
            string[] produto = Console.ReadLine().Split(' ');
            int codigo = int.Parse(produto[0]);
            int quantidade = int.Parse(produto[1]);
            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.0;
                Console.WriteLine("O produto escolhido foi o cachorro quente");
                Console.WriteLine($"Foram escolhida(s) {quantidade} unidade(s)");

            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
                Console.WriteLine("O produto escolhido foi o X-Salada");
                Console.WriteLine($"Foram escolhida(s) {quantidade} unidade(s)");
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
                Console.WriteLine("O produto escolhido foi o X-Bacon");
                Console.WriteLine($"Foram escolhida(s) {quantidade} unidade(s)");
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
                Console.WriteLine("O produto escolhido foi o Torrada Simples");
                Console.WriteLine($"Foram escolhida(s) {quantidade} unidade(s)");
            }
            else
            {
                total = quantidade * 1.5;
                Console.WriteLine("O produto escolhido foi o Refrigerante");
                Console.WriteLine($"Foram escolhida(s) {quantidade} unidade(s)");
            }

            Console.WriteLine("O total a pagar é de R$ " + total);
            Console.WriteLine("Tenha um bom apetite");

        }
    }
}
