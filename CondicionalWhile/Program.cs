using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CondicionalWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcula a raiz quadrada até alguem inserir um número negativo

            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"Raiz quadrada = {raiz.ToString("F2", CultureInfo.InvariantCulture)}");

                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Numero negativo!");
            



            Console.ReadLine();
        }
    }
}
