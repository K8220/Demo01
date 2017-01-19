using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    class Program
    {
        static void Main(string[] args)

        {
            int luku;

            Console.Write("Anna lugu > ");
            string line = Console.ReadLine();
            luku = int.Parse(line);

            Console.WriteLine();

            for (int i = 0; i < luku; i++)
            {
                for (int j = -1; j < i; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}
