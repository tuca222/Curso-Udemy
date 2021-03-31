using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Entrada de dados do Usuário:
            Console.Write("Insira seu nome: ");
            string nomeUsuario = Console.ReadLine();
            Console.WriteLine($"Seu nome é {nomeUsuario}");


            //Vetores:
            Console.WriteLine("Escreva o nome de três frutas separadas por espaço.");
            string[] frutas = Console.ReadLine().Split(' ');
            string fruta1 = frutas[0];
            string fruta2 = frutas[1];
            string fruta3 = frutas[2];
            Console.WriteLine($"Você digitou: {frutas[0]} {frutas[1]} {frutas[2]}");
            Console.WriteLine("E foi separado assim: ");
            Console.WriteLine(fruta1);
            Console.WriteLine(fruta2);
            Console.WriteLine(fruta3);



            //int n1 = int.MinValue;
            //int n2 = int.MaxValue;
            //sbyte n3 = sbyte.MinValue;
            //decimal n4 = decimal.MaxValue;
            //double saldo = 100.29381;
            //int idade = 21;
            //string nome = "Arthur";


            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine("Seu saldo é de R$ {0:F2}", saldo);
            //Console.WriteLine("{0} tem {1} anos e tem o saldo igual a R$ {2:F2}", nome, idade, saldo);
            //Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a R$ {saldo:F2}");
            //Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo igual a R$ " + saldo.ToString("F2"));


            Console.ReadLine();
        }
    }
}
