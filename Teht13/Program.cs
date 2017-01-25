using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pisteet = new int[5];
            Console.WriteLine("Give me 5 scores > ");
            for (int i = 0; i <= 4; i++)
            {
                string line = Console.ReadLine();
                pisteet[i] = int.Parse(line);
            }

            Array.Sort(pisteet); // handy dandy sortti

            Console.WriteLine("These are the 3 mid range values:");
            Console.Write(pisteet[1] + " " + pisteet[2] + " " + pisteet[3]);
            Console.ReadLine();
        }
    }
}
