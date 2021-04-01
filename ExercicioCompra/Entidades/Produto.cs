using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCompra.Entidades
{
    class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        
        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
