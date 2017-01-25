using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht19
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = ("Ananas");
            string l1a = "F";
            string l2a = "R";
            string l3a = "U";
            string l4a = "I";
            string l5a = "T";
            string l6a = "0";

            string l1 = "_";
            string l2 = "_";
            string l3 = "_";
            string l4 = "_";
            string l5 = "_";
            string l6 = "_";

            int scorer = 0;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Progress: " + l1 + l2 + l3 + l4 + l5);
                Console.WriteLine("Guess a letter for the word; hint: it's a fruit.");
                string arvaus = Console.ReadLine();

                if (arvaus == l1a)
                {
                    l1 = l1a;
                    scorer++;
                }
                if (arvaus == l2a)
                {
                    l2 = l2a;
                    scorer++;
                }
                if (arvaus == l3a)
                {
                    l3 = l3a;
                    scorer++;
                }
                if (arvaus == l4a)
                {
                    l4 = l4a;
                    scorer++;
                }
                if (arvaus == l5a)
                {
                    l5 = l5a;
                    scorer++;
                }
                /*if (arvaus == l6a)
                {
                    l6 = l6a;
                    scorer++;
                }*/

                if (scorer == 5)
                {
                    Console.WriteLine("You did it, woo! No hanging today.");
                    Console.ReadLine();
                    break;
                    
                }

                if (i == 10)
                {
                    Console.WriteLine("Welp, if we had a hanging tree, you would be hanging from it right about now.");
                }
            }

            Console.ReadLine();


        }
    }
}
