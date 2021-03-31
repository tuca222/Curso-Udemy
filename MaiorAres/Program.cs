using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MaiorAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoXa, ladoXb, ladoXc;
            double ladoYa, ladoYb, ladoYc;


            Console.WriteLine("Entre com as medidas do triângulo X: ");
            ladoXa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ladoXb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ladoXc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            ladoYa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ladoYb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ladoYc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (ladoXa + ladoXb + ladoXc) / 2;
            double areaX = Math.Sqrt(pX * (pX - ladoXa) * (pX - ladoXb) * (pX - ladoXc));

            double pY = (ladoYa + ladoYb + ladoYc) / 2;
            double areaY = Math.Sqrt(pY * (pY - ladoYa) * (pY - ladoYb) * (pY - ladoYc));

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
        }
    }
}
