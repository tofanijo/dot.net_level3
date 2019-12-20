using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandymas
{
    class Program
    {
        static void Main(string[] args)
        { 
        Console.WriteLine("Iveskite darbo valandu skaiciu");
            int darboValandos = 0;
        int neisdirbtosValandos = 0;
        int virsvalandziai = 0;

            if (!int.TryParse(Console.ReadLine(), out darboValandos))
            {
                Console.WriteLine("Ivesti neteisingi duomenys");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (darboValandos< 160)
            {
                neisdirbtosValandos = 160 - darboValandos;
                Console.WriteLine($"Jums liko isdirbti {neisdirbtosValandos} valadu");
            }
            else if (darboValandos == 160)
            {
                Console.WriteLine("Isdirbtas pilnas etatas");
            }
            else if (darboValandos > 160)
            {
                virsvalandziai = darboValandos - 160;
                Console.WriteLine($"Jus isdirbote {virsvalandziai} virsvalandziu");
            }
            else
            {
                Console.WriteLine("Ivesti neteisingi duomenys");
            }

            Console.ReadLine();
        }
    }
}
