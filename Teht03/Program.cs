using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, sum, avg;
            Console.WriteLine("Give 3 values >");
            string line1 = Console.ReadLine();
            num1 = int.Parse(line1);
            string line2 = Console.ReadLine();
            num2 = int.Parse(line2);
            string line3 = Console.ReadLine();
            num3 = int.Parse(line3);

            sum = num1 + num2 + num3; // summa
            avg = sum / 3; // using sum to get average

            Console.WriteLine("Summa = " + sum);
            Console.WriteLine("Keskiarvo = " + avg);

            Console.ReadLine();
        }
    }
}
