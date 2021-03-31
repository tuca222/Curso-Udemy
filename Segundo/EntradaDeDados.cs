using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Segundo
{
    class EntradaDeDados
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu sexo - M (Masculino) ou F (Feminino): ");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Insita um numero ponto flutuante: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(sexo);
            Console.WriteLine(n2);


            Console.Write("Escreva na ordem separado por espaços: Nome, Sexo, Idade, altura: ");
            string[] dadosPessoais1 = Console.ReadLine().Split(' ');
            string nome1 = dadosPessoais1[0];
            char sexo1 = char.Parse(dadosPessoais1[1]);
            int idade1 = int.Parse(dadosPessoais1[2]);
            double altura1 = double.Parse(dadosPessoais1[3], CultureInfo.InvariantCulture);
            Console.WriteLine($"Nome: {nome1}");
            Console.WriteLine($"Sexo: {sexo1}");
            Console.WriteLine($"Idade: {idade1}");
            Console.WriteLine($"Altura: {altura1.ToString("F2",CultureInfo.InvariantCulture)}");






            Console.ReadLine();
        }
    }
}
