using System;

namespace DigitarSenhaCorreta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua senha");
            int x = int.Parse(Console.ReadLine());

            while (x != 2002)
            {
                Console.WriteLine("Senha incorreta, tente novamente");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha correta, bem-vindo");
        }
    }
}
