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
            int[] array = new int[9] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            
            for (int i = 0 ; i <=8; i++)
            {
                Console.WriteLine(array[i]);
                if (array[i] % 2 == 0)
                { Console.WriteLine("HEP!!"); }
            }
            Console.ReadLine();
        }
    }
}
