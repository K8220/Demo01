using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 0, sum = 0;

            do
            {
                Console.Write("Gimme your numbers > ");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                sum = sum + luku;
            } while (luku != 0);

            Console.WriteLine(sum);
        }
    }
}
