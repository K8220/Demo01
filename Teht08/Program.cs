using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;

            Console.WriteLine("Gimme number > ");
            string line1 = Console.ReadLine();
            luku1 = int.Parse(line1);

            string line2 = Console.ReadLine();
            luku2 = int.Parse(line2);

            string line3 = Console.ReadLine();
            luku3 = int.Parse(line3);

            //IFIFIFIFIFIF
            if (luku1 > luku2 && luku1 > luku3)
                Console.WriteLine(luku1 + " on suurin.");
            else if (luku2 > luku1 && luku2 > luku3)
                Console.WriteLine(luku2 + " on suurin.");
            else if (luku3 > luku1 && luku3 > luku2)
                Console.WriteLine(luku3 + " on suurin.");
            else
                Console.WriteLine("Useampi luku on yhtä iso.");

            Console.ReadLine();

        }
    }
}
