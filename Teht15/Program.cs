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
            int lines = 0;
            Console.WriteLine("Luku = korkeus");
            string line = Console.ReadLine();
            lines = int.Parse(line);
            // DA TOP
            for (int i = 0; i < lines-2; i++) // loopdyloop minus 2 for TRUNK! ...haha
            {
                for (int j = 0; j < lines - i - 1; j++) // aaaalign the trunk
                {
                    Console.Write(" ");
                }

                for (int y = 0; y < i * 2 + 1; y++) // 1*2+1=3, 2*2+1=5 etc.
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // DA STUMP
            for (int i = 0; i <= 1; i++) // 2 lines tall trunk please (change i <= -whatever- for palm trees.)
            {
                for (int j = 0; j < lines-1; j++ ) // copypasta empty spaces
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*"); // BAM!
            }
            // IF Satan wrote code, I think it would be something like this.
        }
    }

}