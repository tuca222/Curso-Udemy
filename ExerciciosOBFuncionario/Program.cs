using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosOBFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("Dados do primeiros funcionário: ");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalarial = (funcionario1.salario + funcionario2.salario) / 2;
            Console.WriteLine("Salário médio = " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadLine();
        }
    }
}
