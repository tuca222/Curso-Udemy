using ExercicioCompra.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCompra.Entidades
{
    class Pedido
    {
        public DateTime MomentoDoPedido { get; set; }
        public StatusPedido Status { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        public Cliente Cliente { get; set; }

        public Pedido()
        {

        }

        public Pedido(DateTime momentoPedido, StatusPedido status, Cliente cliente)
        {
            MomentoDoPedido = momentoPedido;
            Status = status;
            Cliente = cliente;

        }

        public void AddItens(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void RemoveItens(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach (ItemPedido item in Itens)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SUMÁRIO DO PEDIDO: ");
            sb.Append("Momento do pedido: ");
            sb.AppendLine(MomentoDoPedido.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Status do pedido: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Cliente: ");
            sb.Append(Cliente.Nome);
            sb.Append(" (" + Cliente.DataNascimento.ToString("dd/MM/yyyy") + ") - ");
            sb.AppendLine(Cliente.Email);
            sb.AppendLine("Itens do pedido: ");
            foreach(ItemPedido item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço total: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));


            return sb.ToString();
        }
    }
}
