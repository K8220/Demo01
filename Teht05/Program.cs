using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int second, seconds, minutes, hours;

            Console.WriteLine("Gimme seconds >");
            string line = Console.ReadLine();
            second = int.Parse(line);

            // Math, oh my dog!
            hours = second / 3600;
            minutes = (second  % 3600) / 60;
            seconds = (second % 3600) % 60;
            

            Console.WriteLine("Time is " + hours + "hours " + minutes + "minutes " + seconds + "seconds.");

            Console.ReadLine();
        }
    }
}
