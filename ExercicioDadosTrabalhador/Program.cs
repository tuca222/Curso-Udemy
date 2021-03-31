using ExercicioDadosTrabalhador.Entidades;
using ExercicioDadosTrabalhador.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioDadosTrabalhador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados:
            Console.Write("Entre com o nome do departamento: ");
            Departamento departamento = new Departamento(Console.ReadLine());

            Console.WriteLine("Entre com os dados do trabalhador: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível (Junior/Pleno/Senior): ");
            NivelTrabalhador nivel = (NivelTrabalhador)Enum.Parse(typeof(NivelTrabalhador), Console.ReadLine()); // Convertendo a string para Enum

            Console.Write("Salario base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Trabalhador trabalhador1 = new Trabalhador(nome, nivel, salarioBase, departamento);

            Console.Write("Quantos contratos tem esse trabalhador: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Entre com os dados do contrato #{(i + 1)}");
                Console.Write("Data (DD/MM/YYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duração (Horas): ");
                int horas = int.Parse(Console.ReadLine());

                trabalhador1.Contrato.Add(new ContratoDeHoras(date, valorHora, horas));
                Console.WriteLine();
            }

            Console.Write("Entre com o mes e o ano para calcular a renda (MM/YYYY): ");
            DateTime dateRenda = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("nome: " + trabalhador1.Nome);
            Console.WriteLine("Departamento: " + trabalhador1.Departamento.Nome);
            Console.WriteLine($"Renda de {dateRenda.ToString("MM/yyyy")}: " +
                $"R$ {trabalhador1.Renda(dateRenda.Year, dateRenda.Month).ToString("F2", CultureInfo.InvariantCulture)}");





            Console.ReadLine();
        }
    }
}
