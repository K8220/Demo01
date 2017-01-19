using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut; // = {arvot} <-- mikäli halutaan alustaa. Voi olla myös esim "string[] -nimi-" tai "float[] -nimi-"
            int j = 0;
            int i = 4;
            luvut = new int[5]; // 5 lukua joiden arvo = 0
            Console.WriteLine("Please feed me 5 numbers.");

            while (j < 5)
            {
                string line = Console.ReadLine();
                luvut[j] = int.Parse(line);
                j++;
            }

            Console.WriteLine("You gave me these numbers and I reversed their order:");
            while (i > 0)
            {
                Console.Write(luvut[i] + ", ");
                i--;
            }
            Console.Write(luvut[i] + ".");

            Console.ReadLine();

        }
    }
}
