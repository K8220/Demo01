using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh07
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;

            Console.WriteLine("Syötä vuosi > ");
            string line = Console.ReadLine();
            vuosi = int.Parse(line);

            // Check year
            if (vuosi % 400 == 0)
            {
                Console.WriteLine(vuosi + " on karkausvuosi.");
            }

            // countering them false ones
            else if (vuosi % 4 == 0 && vuosi % 100 ==  0)
            {
                Console.WriteLine(vuosi + " ei ole karkausvuosi.");
            }

            else if (vuosi % 4 == 0)
            {
                Console.WriteLine(vuosi + " on karkausvuosi.");
            }

            else
            {
                Console.WriteLine(vuosi + " ei ole karkausvuosi.");
            }
        }
    }
}
