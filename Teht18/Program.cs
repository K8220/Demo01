using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey, I'll check your words for palindromes! > ");
            var original = Console.ReadLine();
            var reversed = new string(original.Reverse().ToArray());
            Console.WriteLine();


            Console.WriteLine(original);
            Console.WriteLine(reversed);
            if (original == reversed)
            { Console.WriteLine("Most likely a polydroooni"); }
            else
            { Console.WriteLine("I doubt this one is a polydroooni"); }

            Console.ReadLine();
        }
    }
}
