using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("valor de w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("valor de t: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("valor de c: ");
            double c = double.Parse(Console.ReadLine());

            double cRad = c * Math.PI / 180;
            double a = 90 - c;
            double aRad = a * Math.PI / 180;
            double z = t * (Math.Sin(cRad));
            double y = t * (Math.Sin(aRad));

            double x = (Math.Sqrt(w * w - z * z)) - y;

            Console.WriteLine("x: " + x);

        }
    }
}
