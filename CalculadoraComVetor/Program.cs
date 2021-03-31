using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] numeros = new double[] { 4, 5, 7, 8, 0, 10 };

            //double s1 = Calculadora.Soma(new double[] { 4, 5, 7, 8, 0, 10 });
            //double s2 = Calculadora.Somar(4, 5, 7, 8, 0, 10);


            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            double a = 10;
            double triplo;
            Calculadora.Triplica(a);
            Console.WriteLine(a);

            Calculadora.Triplicar(ref a);
            Console.WriteLine(a);

            Calculadora.Triple(a, out triplo);
            Console.WriteLine(triplo);



            Console.ReadLine();
        }
    }
}
