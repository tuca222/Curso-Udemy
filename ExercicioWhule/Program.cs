using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile    
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira as duas coordenadas (X, Y): ");
            string[] valores = Console.ReadLine().Split(' ');

            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            while(x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro quadrante");
                }
                else
                {
                    Console.WriteLine("Quarto quadrante");
                }

                Console.WriteLine("Insira outras coordenadas (X, Y)");
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

            }
            Console.ReadLine();
        }
    }
}
