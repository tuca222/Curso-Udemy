using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com três valores com ponto flutuante separados por espaço: ");
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double areaTriangulo = a * c / 2.0;
            double areaCirculo = 3.14159 * c * c;
            double areaTrapezio = (a + b) * (c / 2);
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.Write($"Área Triângulo: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.Write($"Área Circulo: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.Write($"Área Trapézio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.Write($"Área Quadrado: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.Write($"Área Retângulo: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}"); 




            Console.ReadLine();
        }
    }
}
