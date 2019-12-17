using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_figuriniu_skliaustu__KAIP_NEREIKIA_DARYTI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivesite spalva:");
                string spalva = Console.ReadLine();

            if ((spalva == "geltona") || (spalva == "zalia") || (spalva == "raudona"))
                Console.WriteLine("{0} - tai spalva is trispalves", spalva);

            else
                Console.WriteLine("{0} - spalva nepriklauso trispalvei", spalva);

            Console.ReadLine();
        }
    }
}
