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
            // loop till i = luku
            for (int i = 0; i < luku; i++)
            {
                // loop till j = i
                for (int j = -1; j < i; j++)
                    Console.Write('*');
                Console.WriteLine();
            } // AGAIN ^^^^
        }
    }
}
