using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine($"Maior = {resultado}");
            

            Console.ReadLine();
        }

        static int Maior(int a, int b, int c)
        {
            int maior;

            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }
            return maior;
        }

    }
}
