using System;
using System.Collections.Generic;
using System.Globalization;
namespace Exercicio.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Subscribing> list = new List<Subscribing>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++ )
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("");
                if(type == 'i')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Annual income: ");
                    double annualincome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Expenses health: ");
                    double expenseshealth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Individual individual = new Individual(name, annualincome, expenseshealth);
                    list.Add(individual);
                }
                else if(type == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual income: ");
                    double annualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int employeesnumber = int.Parse(Console.ReadLine());
                    Company company = new Company(name, annualincome, employeesnumber);
                    list.Add(company);
                }

              
            }
            Console.WriteLine("");
            Console.WriteLine("TAXES PAID:");
            Console.WriteLine("");
            foreach (Subscribing payer in list)
            {
                Console.WriteLine(payer.ToString());
            }
        }
    }
}
