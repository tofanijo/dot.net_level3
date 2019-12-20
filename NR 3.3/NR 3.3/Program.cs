using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pazymis;
            Console.WriteLine("Iveskite egzamino pazymi:");
            if (!int.TryParse(Console.ReadLine(), out pazymis))

            {
                Console.WriteLine("Ivesti neteisingi duomenis");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if((pazymis> 10) || (pazymis < 0))
            {
                Console.WriteLine("Ivesti neteisingi duomenis");
                Console.ReadLine();
                Environment.Exit(0);
            }

            switch (pazymis)
            {
                case 0:
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 1:
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 2:
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 3:
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 4:
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 5:
                    Console.WriteLine("SILPNAI");
                    break;
                case 6:
                    Console.WriteLine("PATENKINAMAI");
                    break;
                case 7:
                    Console.WriteLine("VIDUTINISKAI");
                    break;
                case 8:
                    Console.WriteLine("GERAI");
                    break;
                case 9:
                    Console.WriteLine("LABAI GERAI");
                    break;
                case 10:
                    Console.WriteLine("PUIKIAI");
                    break;
            }
            Console.ReadLine();






            }
        }
    }

