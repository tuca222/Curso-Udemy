using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCompra.Entidades
{
    class Cliente
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email, DateTime nascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = nascimento;
        }

    }
}
