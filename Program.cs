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
            string s1 = Console.ReadLine();

            Console.WriteLine(" Valor binario de entrada 2: ");
            string s2 = Console.ReadLine();

            Console.WriteLine(" Valor binario de entrada 3: ");
            string s3 = Console.ReadLine();

            Console.WriteLine(" Valor binario de entrada 4: ");
            string s4 = Console.ReadLine();

            Console.WriteLine(" Valor binario de entrada 5: ");
            string s5 = Console.ReadLine();

            int b0 = Convert.ToInt32(s5, 2);
            int b1 = Convert.ToInt32(s1, 2);
            int b2 = Convert.ToInt32(s2, 2);
            int b3 = Convert.ToInt32(s3, 2);
            int b4 = Convert.ToInt32(s4, 2);

            //valores de cada uno
            Console.WriteLine("Input value 5 in base 10: " + b0);
            Console.WriteLine("Input value 1 in base 10: " + b1);
            Console.WriteLine("Input value 2 in base 10: " + b2);
            Console.WriteLine("Input value 3 in base 10: " + b3);
            Console.WriteLine("Input value 4 in base 10: " + b4);
        }
    }
}
