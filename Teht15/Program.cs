using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            int korkeus;
            
            Console.Write("Anna luku > ");
            string line = Console.ReadLine();
            korkeus = int.Parse(line);

            for (int j = 1; j < (korkeus*2); j=j+2)
            {
                for (int i = 1; i+2 <= j; i++)
                { Console.Write("*"); }
                Console.WriteLine();
            }
        }
    }
}
