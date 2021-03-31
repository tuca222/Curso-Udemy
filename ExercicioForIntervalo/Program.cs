using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioForIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Números você quer inserir?");
            int n = int.Parse(Console.ReadLine());

            int count_in = 0;
            int count_out = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Entre com os números um em cada linha: ");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    count_in++;
                }
                else
                {
                    count_out++;
                }
            }
            Console.WriteLine($"{count_in} in");
            Console.WriteLine($"{count_out} out");

            Console.ReadLine();
        }
    }
}
