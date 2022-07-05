using System;

namespace CalculoDeImposto
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva o valor do seu salário");
        Double x = Double.Parse(Console.ReadLine());
        double a;
        double b;
        double c;

        if (x < 0)
        {
            a = 0;
            Console.WriteLine($"Digite um valor válido");

        }
        else if (x <= 2000)
        {
            a = 0;
            Console.WriteLine("Isento");
        }
        else if (x > 2000 && x <= 3000)
        {
            b = x - 2000;
            a = b * 0.08;
            Console.WriteLine($"O imposto pago será de {a} reais");
        }
        else if (x > 3000 && x <= 4500)
        {
            b = x - 3000;
            c = b * 0.18;

            a = 80 + c;

            Console.WriteLine($"O imposto pago será de {a} reais");
        }
        else
        {
            b = x - 4500;
            c = b * 0.28;

            a = 350 + c;

            Console.WriteLine($"O imposto pago será {a} reais");
        }



    }
}
