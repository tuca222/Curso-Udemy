using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o preço: ");
            double preco = double.Parse(Console.ReadLine());


            //double desconto;
            //if (preco < 20)
            //{
            //    desconto = preco * 0.1;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //}

            //Usando condicional ternário ao inves de if / else;
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine("Desconto: " + desconto);

            Console.ReadLine();
        }
    }
}
