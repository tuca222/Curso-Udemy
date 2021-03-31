using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor de x e de y: ");
            string[] xy = Console.ReadLine().Split(' ');

            double x = double.Parse(xy[0]);
            double y = double.Parse(xy[1]);




            
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine("Eixo X");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}
