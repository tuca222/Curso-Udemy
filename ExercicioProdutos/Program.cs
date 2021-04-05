using ExercicioProdutos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c' || ch == 'C')
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufatureDate = DateTime.Parse(Console.ReadLine());

                    Product product = new UsedProduct(name, price, manufatureDate);
                    products.Add(product);
                }
                else if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Custons fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product product = new ImportedProduct(name, price, customsFee);
                    products.Add(product);
                }
                Console.WriteLine();
            }
            Console.WriteLine("PRICE TAGS: ");

            foreach(Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }









            Console.ReadLine();
        }
    }
}
