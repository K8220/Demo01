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
            int[] hyppy;
            hyppy = new int[5];
            int i = 0;
            int j = 0;
            int sum = 0;

            while (i < 5)
            {
                string line = Console.ReadLine();
                hyppy[i] = int.Parse(line);
                i++;
            }

            sum = hyppy[0] + hyppy[1] + hyppy[2] + hyppy[3] + hyppy[4];
            Console.WriteLine(sum);

            for (int y = 0; y < 5; y++)
            {
                for (int x = 1; x < 5; x++)
                {
                    if (hyppy[y] < hyppy[x])
                    {
                        int z = hyppy[y];
                        hyppy[y] = hyppy[x];
                        hyppy[x] = z;
                    }
                }
            }
            Console.WriteLine(hyppy[0] + hyppy[1] + hyppy[2] + hyppy[3] + hyppy[4]);

            int holder = 0;

            if
            (hyppy[0] > hyppy[1] &&
            hyppy[0] > hyppy[2] &&
            hyppy[0] > hyppy[3] &&
            hyppy[0] > hyppy[4])
            {
                holder = hyppy[0];
                hyppy[0] = hyppy[1]
            }

            if
            (hyppy[1] > hyppy[2] &&
            hyppy[1] > hyppy[3] &&
            hyppy[1] > hyppy[4])
            {
                holder = hyppy[1];
                hyppy[1]
            }

            if
            (hyppy[2] > hyppy[3] &&
            hyppy[2] > hyppy[4])
            {
                holder = hyppy[2];
            }

                if
                (hyppy[3] > hyppy[4]) ;
            {
                holder = hyppy[3];
            }




            Console.ReadLine();
        }
    }
}
