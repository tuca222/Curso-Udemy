using ExercicioDadosTrabalhador.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDadosTrabalhador.Entidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoDeHoras> Contrato { get; set; } = new List<ContratoDeHoras>(); // Um trabalhador pode ter varios contratos -> lista

        public Trabalhador()
        {

        }

        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(ContratoDeHoras contrato)
        {
            Contrato.Add(contrato);
        }

        public void RemoverContrato(ContratoDeHoras contrato)
        {
            Contrato.Remove(contrato);
        }

        public double Renda(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (ContratoDeHoras contrato in Contrato)
            {
                if (contrato.Date.Year == ano && contrato.Date.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;

        }



    }
}
