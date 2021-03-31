using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoConta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s / n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());

            if (depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta1 = new ContaBancaria(numero, nome, saldo);
            }
            else 
            {
                conta1 = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta1);
            Console.WriteLine();


            Console.Write("Entre com um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta1.Depositar(valorDeposito);

            
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);
            Console.WriteLine();


            Console.Write("Entre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta1.Sacar(valorSaque);

            
            Console.WriteLine("Dados da conta atualizados: ");
            Console.Write(conta1);

            

            Console.ReadLine();
        }
    }
}
