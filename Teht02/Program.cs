using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.Write ("Give score between 0-12");
            string line = Console.ReadLine();
            score = int.Parse(line);
            switch (score)
                // CASE CLOSED
            {
                case 0:
                case 1: Console.WriteLine("Grade is 0");
                    break;

                case 2:
                case 3:
                    Console.WriteLine("Grade is 1");
                    break;

                case 4:
                case 5:
                    Console.WriteLine("Grade is 2");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Grade is 3");
                    break;

                case 8:
                case 9:
                    Console.WriteLine("Grade is 4");
                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Grade is 5");
                    break;
            }
        }
    }
}
