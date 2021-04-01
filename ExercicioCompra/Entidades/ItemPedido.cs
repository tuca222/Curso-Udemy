using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCompra.Entidades
{
    class ItemPedido
    {
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }
        public Produto Produto { get; private set; }


        public ItemPedido()
        {

        }

        public ItemPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }
        public override string ToString()
        {
            return $"{Produto.Nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantidade: {Quantidade}, Subtotal: {SubTotal().ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }
}
