using System;

namespace ProdutosEmEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados P;

            P = new Dados();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            P.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            P.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            P.Quantidade = int.Parse(Console.ReadLine());

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
