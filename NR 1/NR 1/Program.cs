using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_1
{
    class Program
    {
        static void Main(string[] args)
        {
           char simbolis1;
           char simbolis2;
           char simbolis3;

            Console.WriteLine("Iveskite pima simboli");
            simbolis1 = Console.ReadKey().KeyChar;
            Console.WriteLine("");

            Console.WriteLine("Iveskite antra simboli");
            simbolis2 = Console.ReadKey().KeyChar;
            Console.WriteLine("");

            Console.WriteLine("Iveskite trecia simboli");
            simbolis3 = Console.ReadKey().KeyChar;
            Console.WriteLine("");

            Console.WriteLine("Ivesti simboliai atvirkstine tvarka: {0} {1} {2}", simbolis3, simbolis2, simbolis1 );

            Console.ReadLine();



        }
    }
}
