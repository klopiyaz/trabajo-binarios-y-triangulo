using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("valor b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("valor z: ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("valor y: ");
            double y = double.Parse(Console.ReadLine());

            double bRad = b * Math.PI / 180;

            double c = Math.Atan(z / y);
            double e = 180 - c;
            double d = 180 - b - e;
            double dRad = d * Math.PI / 180;
            double w = z / (Math.Sin(dRad));
            double x = (Math.Sqrt(w * w - z * z)) - y;

            Console.WriteLine("x: " + x);

        }
    }
}
