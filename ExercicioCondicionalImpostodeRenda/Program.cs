using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioCondicionalImpostodeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o seu salário para o imposto de rendar ser calculado: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000) * 0.8;
            }
            else if (salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (imposto == 0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine($"O seu imposto de renda é R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }




            Console.ReadLine();
        }
    }
}
