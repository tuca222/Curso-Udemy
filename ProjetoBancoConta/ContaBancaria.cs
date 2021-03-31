using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoConta
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        private int Taxa { get; set; } = 5;

        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial)  
            : this(numeroConta, nome)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor + Taxa;
        }
        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {Nome}, " +
                $"Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
