using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double litra, hinta;
            Console.WriteLine("Matka? > ");
            string line = Console.ReadLine();
            matka = int.Parse(line);

            litra = (7.02 / 100) * matka;
            hinta = litra * 1.595;

            Console.WriteLine("Bensaa menee " + litra + " litraa, joka maksaa " + hinta + " euroa.");
        }
    }
}
