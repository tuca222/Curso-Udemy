using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovadoOuReprovado
{
    class Aluno
    {
        public string Name;
        public double Nota1, Nota2, Nota3;

        public double CalcularNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (CalcularNotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double PontuacaoNecessaria()
        {
            return 60 - CalcularNotaFinal();
        }
    }
}
