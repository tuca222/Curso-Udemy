using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForQuadradoECubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga o numero de linha do programa: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int quadrado = i * i;
                int cubo = i * i * i;
    
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
            Console.ReadLine();
        }
    }
}
