using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IntroducaoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero inteiro N e a altura das N pessoas: ");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            double soma = 0;

            for (int i = 0; i < n; i++) 
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vet[i]; 
            }

            double media = soma / n;

            Console.WriteLine("A média das alturas é igual a "+ media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
