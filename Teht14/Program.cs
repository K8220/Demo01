using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arvio = new int[10];
            int tarkistus = 0;
            int nolla = 0, yksi = 0, kaksi = 0, kolme = 0, nelja = 0, viisi = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Arvosana 0-5, 10 lukua > ");
                do
                {
                    string line = Console.ReadLine();
                    arvio[i] = int.Parse(line);
                    tarkistus = arvio[i];
                    if (tarkistus > 5 || tarkistus < 0)
                        Console.WriteLine("Why?");

                    if (tarkistus == 0)
                        nolla++;
                    if (tarkistus == 1)
                        yksi++;
                    if (tarkistus == 2)
                        kaksi++;
                    if (tarkistus == 3)
                        kolme++;
                    if (tarkistus == 4)
                        nelja++;
                    if (tarkistus == 5)
                        viisi++;
                }
                while (tarkistus > 5 || tarkistus < 0);
            }
            // for and for and fooooorever
            Console.WriteLine("Arvosanat:");
            /////
            Console.Write("0:");
            for (int j = 1; j <= nolla; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            /////
            Console.Write("1:");
            for (int j = 1; j <= yksi; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            /////
            Console.Write("2:");
            for (int j = 1; j <= kaksi; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            /////
            Console.Write("3:");
            for (int j = 1; j <= kolme; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            /////
            Console.Write("4:");
            for (int j = 1; j <= nelja; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            /////
            Console.Write("5:");
            for (int j = 1; j <= viisi; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
