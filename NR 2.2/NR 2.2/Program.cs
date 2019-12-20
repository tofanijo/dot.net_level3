using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite dirbtas valandas");
            

            int dirbtosValandos = 0;
            int nedadirbtosValandos = 0;
            int virsvalandziai = 0;

            if (!int.TryParse(Console.ReadLine(), out dirbtosValandos))
            {            
                Console.WriteLine("Ivesti neteisingi duomenis");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (dirbtosValandos == 160 )
            {
             
                Console.WriteLine("Pilnas etatas");

            }
            
            else if (dirbtosValandos < 160)

            {
                nedadirbtosValandos = 160 - dirbtosValandos;
                Console.WriteLine($"Nedadirbta valandu {nedadirbtosValandos} h");
            
              

            }
            else if (dirbtosValandos > 160) 
            {
                virsvalandziai = dirbtosValandos - 160;
                Console.WriteLine($"Virsvalandziu {virsvalandziai} h");
                
            }
            else
            {
                Console.WriteLine("Ivestas neteisingas skaicius");
            }


            Console.ReadLine();
        }
    }
}
