using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite atstuma metrais");
            double atstumas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite laika sekundem");
            double laikas = Convert.ToDouble(Console.ReadLine());

            double km = atstumas / 1000;
            double h = laikas / (60 * 60);

            Console.WriteLine("km/h = {0}", km / h);
            Console.ReadLine();


        }
    }
}
