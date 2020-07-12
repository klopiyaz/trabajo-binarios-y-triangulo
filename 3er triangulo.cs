using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("valor w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("valor d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("valor x: ");
            double x = double.Parse(Console.ReadLine());

            //operaciones matemáticas
            double dRad = d * Math.PI / 180;
            double z = w * (Math.Sin(dRad));

            double y = (Math.Sqrt(w*w - z*z)) - x;

            Console.WriteLine("y: " + y);

        }
    }
}
