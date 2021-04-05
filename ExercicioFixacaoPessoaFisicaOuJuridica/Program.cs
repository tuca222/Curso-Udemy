using ExercicioFixacaoPessoaFisicaOuJuridica.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoPessoaFisicaOuJuridica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    TaxPayer individual = new Individual(name, anualIncome, healthExpenditures);
                    taxPayers.Add(individual);
                }
                else if (ch == 'c' || ch == 'C')
                {
                    Console.Write("Number of Employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    TaxPayer company = new Company(name, anualIncome, numberEmployees);
                    taxPayers.Add(company);
                }
                Console.WriteLine();
            }
            Console.WriteLine("TAXES PAID: ");

            double soma = 0;

            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine($"{taxPayer.Name}: R$ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                soma += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
    }
}
