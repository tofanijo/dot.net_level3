using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite rutulio diametra:");
            double rutulioDiametras = Convert.ToDouble(Console.ReadLine());
            double rutuliospindulys = rutulioDiametras / 2;


            double rutulioPlotas = 4 * Math.PI * Math.Sqrt(rutulioDiametras);
            Console.WriteLine("Rutulio plotas: {0}", rutulioPlotas);
            Console.ReadLine();

        }
    }
}
