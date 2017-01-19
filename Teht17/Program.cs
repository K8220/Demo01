using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kympit = new int[5] { 10, 20, 30, 40, 50 };
            int[] vitoset = new int[5] { 5, 15, 25, 35, 45 };

            int[] valmis = new int[10];

            // Vaatiiko sorttaus loopin?

            int a = -1;
            for (int i = 0; i <= 9; i=i+2)
            {
                a++;
                    valmis[i] = vitoset[a];
            }

            int b = -1;
            for (int i = 1; i <= 9; i = i + 2)
            {
                b++;
                valmis[i] = kympit[b];
            }

            foreach (int item in valmis)
            { Console.WriteLine(item.ToString()); }


        }
    }
}
