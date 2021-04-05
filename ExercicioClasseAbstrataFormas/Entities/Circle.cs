using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseAbstrataFormas.Entities
{
    class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius, Color color)
            :base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
