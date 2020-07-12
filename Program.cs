using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Valor binario de entrada 1: ");
            string binario5 = Console.ReadLine();

            Console.WriteLine(" Valor binario de entrada 2: ");
            string binario4 = Console.ReadLine();

            Console.WriteLine(" Valor binario de entrada 3: ");
            string binario3 = Console.ReadLine();

            Console.WriteLine(" Valor binario de entrada 4: ");
            string binario2 = Console.ReadLine();

            Console.WriteLine(" Valor binario de entrada 5: ");
            string binario1 = Console.ReadLine();

            int b0 = Convert.ToInt32(binario1, 2);
            int b1 = Convert.ToInt32(binario5, 2);
            int b2 = Convert.ToInt32(binario4, 2);
            int b3 = Convert.ToInt32(binario3, 2);
            int b4 = Convert.ToInt32(binario2, 2);

            //valores de cada uno
            Console.WriteLine("Input value 0 in base 10: " + b0);
            Console.WriteLine("Input value 1 in base 10: " + b1);
            Console.WriteLine("Input value 2 in base 10: " + b2);
            Console.WriteLine("Input value 3 in base 10: " + b3);
            Console.WriteLine("Input value 4 in base 10: " + b4);
        }
    }
}
