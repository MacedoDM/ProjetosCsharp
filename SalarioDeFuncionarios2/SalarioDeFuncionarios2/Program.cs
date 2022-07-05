using System;
using System.Collections.Generic;

namespace SalarioDeFuncionarios2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dados> list = new List<Dados>();
            Console.Write("How many employees will be registred? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Employee " + i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Dados(id, nome, salario));
                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idincrease = int.Parse(Console.ReadLine());

            Dados emp = list.Find(x => x.ID == idincrease);

            if (emp != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double aumento = double.Parse(Console.ReadLine());
                emp.AumentarSalario(aumento);
            }

            else
            {
                Console.WriteLine("This ID does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Dados obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
