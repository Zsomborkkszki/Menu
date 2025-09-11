using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            bool ffi = true;
            int age = 0;
            string choice = "";

            do
            {
                Console.Clear();
                Console.Title = "Személyesadatok kezelése";
                Console.WriteLine("1 - Személyes adatok bevitele");
                Console.WriteLine("2 - Személyes adatok kiíratása");
                Console.WriteLine("3 - Kilépés");
                Console.Write("\nVálasszon a menüből: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    
                    Console.WriteLine("\nSikeresen rögzítettük. Enterrel tovább...");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    
                }
                else
                {
                    Console.WriteLine("Rossz gomb, próbáld újra");
                }



            }
            while (choice != "3");
        }
    }
}
