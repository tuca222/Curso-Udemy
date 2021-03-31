using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimeiroProgramaOrientadaObjetosTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();

            Console.WriteLine("Entre com os lados do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com os lados do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalcularAreaTriangulo();

            double areaY = y.CalcularAreaTriangulo();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Área = X");
            }
            else
            {
                Console.WriteLine("Maior Área = Y");
            }

            Console.ReadLine();



            Console.ReadLine();
        }
    }
}
