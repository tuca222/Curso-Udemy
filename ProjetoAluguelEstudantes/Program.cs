using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluguelEstudantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crianção de vetor tamanho 10 -> todos os campos nulls;
            Estudante[] estudantes = new Estudante[10];

            Console.Write("Quantos quartos serão alugados?  ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1) + ":");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                estudantes[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine($"{i}: {estudantes[i]}");
                }
            }

            Console.ReadLine();
        }
    }
}
