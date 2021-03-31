using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p;

            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);

            //p = new Point();
            //Console.WriteLine(p);

            //p = new Point(20, 54);
            //Console.WriteLine(p);

            //Nuablle

            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)
            //{
            //    Console.WriteLine(x.Value);
            //}
            //else
            //{
            //    Console.WriteLine("X is null");
            //}

            //if (y.HasValue)
            //{
            //    Console.WriteLine(y.Value);

            //}
            //else
            //{
            //    Console.WriteLine("Y is null");
            //}

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(a);
            Console.WriteLine(b);



            Console.ReadLine();
        }
    }
}
