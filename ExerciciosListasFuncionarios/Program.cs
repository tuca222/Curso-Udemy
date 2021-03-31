using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosListasFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados?  ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            
            


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário #" + (i + 1) + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());


                var empregado = new Funcionario(id, nome, salario);
                
                funcionarios.Add(empregado);
                Console.WriteLine();

            }

            Console.Write("Insira o id do funcionário que terá aumento no salário: ");
            int procurarID = int.Parse(Console.ReadLine());

            Funcionario funcionarioAumento = funcionarios.Find(x => x.Id == procurarID);
            if (funcionarioAumento != null)
            {
                Console.Write("Insira a porcentagem: ");
                double aumento = double.Parse(Console.ReadLine());
                funcionarioAumento.AumentarSalario(aumento);
            }
            else
            {
                Console.WriteLine("Este ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach(Funcionario dados in funcionarios)
            {
                Console.WriteLine(dados);
            }


            Console.ReadLine();
        }
    }
}
