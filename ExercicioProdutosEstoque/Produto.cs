using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProdutosEstoque
{
    class Produto
    {
        //Ordem:
        //Atributos Privativos
        private string _name;

        //Auto Properties
        public double Price { get; private set; }
        public int Amount { get; private set; }

        //Contrutores
        public Produto()
        {

        }

        public Produto(string name, double price, int amount)
        {
            _name = name;
            Price = price;
            Amount = amount;
        }

        //Custom Properties
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        //Methods
        public double ValueInventory()
        {
            return Price * Amount;
        }

        public void AddProducts(int quantity)
        {
            Amount += quantity;
        }

        public void RemoveProdcts(int quantity)
        {
            Amount -= quantity;
        }


        public override string ToString()
        {
            return $"Nome: {_name}, Preço unidade: R${Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantidade: {Amount} unidades, " +
                $"Valor total do estoque: R${ValueInventory().ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
