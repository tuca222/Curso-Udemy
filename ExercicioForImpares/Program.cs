using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioForImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Par(int n)
            {
                bool resultado = true;
                if (n % 2 == 0)
                {
                    resultado = false;
                }
                return resultado;
            }

            Console.Write("De 1 até que numero você quer saber quais números impares têm no intervalo? :  ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (Par(i) == true)
                {
                    Console.WriteLine(i);
                }
            }






            Console.ReadLine();
        }
    }
}
