using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero de produtos a ser lido, em seguida insira o nome do produto e o preço: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Product(name, price);

                sum += vet[i].Price;
            }

            double mediaPreco = sum / n;
            Console.WriteLine("Preço médio é igual a " + mediaPreco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
