using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDollarParaReais
{
    class ConversorDeMoedas
    {

        public static double Imposto = 0.06;

        public static double Multiplicador(double x, double y)
        {
            return x * y;
        }
            
        public static double Converter(double CotacaoDolar, double ValorEmReal)
        {
            double total = Multiplicador(ValorEmReal, CotacaoDolar);
            return total + (total * Imposto);
        }


    }
}
