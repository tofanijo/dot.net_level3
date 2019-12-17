using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite grupes nariu kieki");
            //int nariukiekis = Convert.ToInt32(Console.ReadLine());
            //int nariukiekis = int.Parse(Console.ReadLine());
            int nariuSkaicius = 1;
            

            if (!int.TryParse(Console.ReadLine(), out nariuSkaicius))
            {
                Console.WriteLine("Nekorektiskas skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (nariuSkaicius == 1)
            {
                Console.WriteLine("Tai solo atlikejas");

            }
            else if (nariuSkaicius == 2)
            {
                Console.WriteLine("Tai duetas");
            }
            else if ((nariuSkaicius > 2) && (nariuSkaicius < 10))
            {
                Console.WriteLine("Tai ansamblis");
            }
            else if (nariuSkaicius > 10)
            {
                Console.WriteLine("Tai kamerinis ansamblis");
            }
            else
            {
                Console.WriteLine("Ivestas neteisingas skaicius");
            }

            Console.ReadLine();
        }
    }
}
