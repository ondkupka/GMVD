using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyber si jestli chceš kámen, nůžky nebo papír");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(4);

            if (computerChoice == 1)
            {
                if (userChoice == "kámen")
                {
                    Console.WriteLine("Počítač vybral kámen");
                    Console.WriteLine("Je to remíza ");
                }
                else if (userChoice == "papír")
                {
                    Console.WriteLine("Počítač vybral papír");
                    Console.WriteLine("Je to remíza ");

                }
                else if (userChoice == "nůžky")
                {
                    Console.WriteLine("Počítač vybral nůžky");
                    Console.WriteLine("Je to remíza ");
                }
                else
                {
                    Console.WriteLine("Nevybral jsi kámen, nůžky nebo papír!");

                }

            }

            else if (computerChoice == 2)
            {
                if (userChoice == "kámen")
                {
                    Console.WriteLine("Počítač zvolil papír");
                    Console.WriteLine("Prohrál jsi, papír zabalí kámen");

                }
                else if (userChoice == "papír")
                {
                    Console.WriteLine("Počítač zvolil nůžky");
                    Console.WriteLine("Prohrál jsi, nůžky rozstřihnou papír");

                }
                else if (userChoice == "nůžky")
                {
                    Console.WriteLine("Počítač zvolil kámen");
                    Console.WriteLine("Prohrál jsi, kámen ztupil nůžky");
                }
                else
                {
                    Console.WriteLine("Musíš vybrat kámen, nůžky nebo papír!");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "kámen")
                {
                    Console.WriteLine("Počítač vybral nůžky");
                    Console.WriteLine("Vyhrál jsi, kámen ztupil nůžky");

                }
                else if (userChoice == "papír")
                {
                    Console.WriteLine("Počítač vybral kámen");
                    Console.WriteLine("Vyhrál jsi, papír zabalil kámen");

                }
                else if (userChoice == "nůžky")
                {
                    Console.WriteLine("Počítač vybral papír");
                    Console.WriteLine("Vyhrál jsi, nůžky rozstřihli papír");

                }
                else
                {
                    Console.WriteLine("Musíš vybrat kámen, nůžky nebo papír!");

                }

            }

            Console.ReadLine();
        }
    }
}
