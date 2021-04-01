using ExercicioCompra.Entidades;
using ExercicioCompra.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCompra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados cliente
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento (DD/MM/YYYY): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Cliente cliente1 = new Cliente(nome, email, dataNascimento);

            //Dados Pedido
            Console.WriteLine("Entre com os dados do pedido: ");
            Console.Write("Status: ");
            StatusPedido status = (StatusPedido)Enum.Parse(typeof(StatusPedido), Console.ReadLine());
            Console.Write("Quantos itens você quer nesse pedido? ");
            int n = int.Parse(Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, status, cliente1);

            //Dados dos itens do pedido
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Entre com os dados do item {(i+1)}: ");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                pedido.AddItens(new ItemPedido(quantidade, precoProduto, new Produto(nomeProduto, precoProduto)));

                Console.WriteLine();
            }

            Console.WriteLine(pedido);





            Console.ReadLine();
        }
    }
}
