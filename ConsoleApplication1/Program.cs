using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Gimme your age >");
            string line = Console.ReadLine();
            age = int.Parse(line);

            //self explanatory
            if (age < 18)
                Console.WriteLine("Underage");

            else if (age >= 18 && age <= 65)
                Console.WriteLine("Adult");

            else if (age > 65)
                Console.WriteLine("Senior");
        }
    }
}
