using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Deathroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Player = 1000; //Počet drahokamů uživatele jako hráče
            int Computer = 100000; //Počet drahokamů počítače 
            int bid; //sázka
            int value; 
            int round = 0;

            while (Player > 0 && Computer > 0)
            {
                Console.Clear();
                Console.WriteLine("Tvůj aktuální zůstatek je: " + Player + " drahokamů" + Environment.NewLine + "Nyní zadej svou sázku");
                while (!int.TryParse(Console.ReadLine(), out bid))
                {
                    Console.WriteLine("Zadej prosím platnou sázku:");
                }
                Console.Clear();
                Console.WriteLine("Sázka je " + bid.ToString());
                if (bid > Player)
                {
                    Console.Clear();
                    Console.WriteLine("Na takovou sázku nemáš dostatek drahokamů, tvůj počet drahokamů je: " + Player + Environment.NewLine + "Pro pokračkování zmáčkni enter");
                }
                else
                {
                    Console.WriteLine("Zvol počáteční hodnotu");
                    value = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Zadaná hodnota je " + value.ToString());
                    while (value != 1)
                    {
                        value = random.Next(1, value);
                        if (round % 2 != 0)
                        {
                            Console.WriteLine("Hráč rollnul číslo " + value.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Počítač rollnul číslo " + value.ToString());
                            Console.WriteLine("Nyní je řada na tobě. Pro pokračování zmáčkni enter!");
                            Console.ReadKey();
                        }
                        round++;
                    }
                    if (round % 2 != 0)
                    {
                        Console.WriteLine("Hráč vyhrál " + bid.ToString() + " drahokamů");
                        Player += bid;
                        Computer -= bid;
                    }
                    else
                    {
                        Console.WriteLine("Počítač vyhrál " + bid.ToString() + " drahokamů");
                        Player -= bid;
                        Computer += bid;
                    }
                    Console.WriteLine("Stav drahokamů hráče je: " + Player + " počítače: " + Computer);
                }
                Console.ReadKey();
            }
            Console.WriteLine("Nedostatečný počet drahokamů jednoho z hráčů");
            Console.ReadKey();

            // ONDŘEJ KUPKA 4.D
        }
    }
}
