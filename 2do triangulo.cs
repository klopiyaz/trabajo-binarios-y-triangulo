using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2da_tarea_triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valor de b: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("valor de d: ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("valor y: ");
            double y = double.Parse(Console.ReadLine());

            double b = bGrados * (Math.PI / 180.0);
            double d = dGrados * (Math.PI / 180.0);

            double a = Math.PI - (Math.PI / 2) - b - d;
            double aGrados = a * (Math.PI / 180.0);
            double z = y / Math.Tan(a);

            Console.WriteLine("z: " + z);
        }
    }
}
