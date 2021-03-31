using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioDeFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            byte numeroDeQuartos = byte.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (tudo na mesma linha separados por um espaço):");
            string[] dados = Console.ReadLine().Split(' ');
            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            float altura = float.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.Write($"Seu nome completo: {nome}.");
            Console.WriteLine();
            Console.Write($"Você tem {numeroDeQuartos} quartos em casa.");
            Console.WriteLine();
            Console.Write($"O preço do produto inserido é: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.Write($"Seu ultimo nome é: {ultimoNome}");
            Console.WriteLine();
            Console.Write($"Sua idade: {idade}");
            Console.WriteLine();
            Console.Write($"Sua altura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");






            Console.ReadLine();
        }
    }
}
