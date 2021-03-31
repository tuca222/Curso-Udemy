using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDadosTrabalhador.Entidades
{
    class ContratoDeHoras
    {
        public DateTime Date { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoDeHoras()
        {

        }

        public ContratoDeHoras(DateTime date, double valorPorHora, int horas)
        {
            Date = date;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return ValorPorHora * Horas;
        }
    }
}
