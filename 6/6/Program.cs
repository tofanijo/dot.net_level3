using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite grupes pavadinima:");
            string grupersPavadinimas = Console.ReadLine();

            Console.WriteLine("Iveskite grupes nariu skaiciu");
            int nariuSkaiciu = 0;

            if (!int.TryParse(Console.ReadLine(),out nariuSkaiciu))
            {
                Console.WriteLine("Ivestas nekorektiskas skaicius");
                Console.ReadLine();
                Environment.Exit(0);

            }
            Console.WriteLine("Grupes pavadinimas yra: {0}, nariu skaicius yra {1}", grupersPavadinimas, nariuSkaiciu);
            Console.ReadLine();
        }
    }
}
