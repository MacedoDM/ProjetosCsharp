using System;

namespace EstoqueDeProdutos2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dados P = new Dados("TV 4K", 1000.00, 10);
            Console.WriteLine(P.Nome);

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + P);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            Console.WriteLine();
            P.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados do produto: " + P);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            Console.WriteLine();
            P.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados do produto: " + P);

        }
    }
}
