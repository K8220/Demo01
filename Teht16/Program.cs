using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100); // väliltä 1-100
            int answer;
            int tries = 0;

            do 
            {
                tries++; // +1 per loop
                Console.Write("Arvaa luku > ");
                string line = Console.ReadLine();
                answer = int.Parse(line);

                if (answer > randomNumber)
                {
                    Console.WriteLine("Oikea luku on pienempi.");
                }

                if (answer < randomNumber)
                {
                    Console.WriteLine("Oikea luku on suurempi.");
                }

            } while (answer != randomNumber); // jatkuu kunnes osutaan oikeaan

            Console.WriteLine("Woohoo! Arvasit " + tries + " kertaa.");
            Console.ReadLine();
        }
    }
}
