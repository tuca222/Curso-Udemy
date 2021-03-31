using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParEImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
                Console.WriteLine("Bom dia!");
            else if (hora < 18)
                Console.WriteLine("Boa tarde!");
            else
                Console.WriteLine("Boa noite!");




            Console.ReadLine();
        }
    }
}
