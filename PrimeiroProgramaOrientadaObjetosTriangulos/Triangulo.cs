using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProgramaOrientadaObjetosTriangulos
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double CalcularAreaTriangulo()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
