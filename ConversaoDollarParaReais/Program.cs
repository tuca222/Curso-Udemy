using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConversaoDollarParaReais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar: ");
            double CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você quer comprar? ");
            double ValorEmReal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ValorConvertido = ConversorDeMoedas.Converter(CotacaoDolar, ValorEmReal);


            Console.Write($"Valor a ser pago em reais = {ValorConvertido.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
