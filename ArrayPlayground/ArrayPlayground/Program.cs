using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] value = {1,2,3,4,5};

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            /*    for (int i = 0; i < 5; i++)
                {
                    int x = 0 + i;
                    Console.WriteLine(value[x]);
                } */

        /*    foreach (int x in value) {
                Console.WriteLine(x);
            } 

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = value.Sum();
            Console.WriteLine(sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = sum / value.Length;
            Console.WriteLine(average);


            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = value.Max();
            Console.WriteLine(max);
           

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = value.Min();
            Console.WriteLine(min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int num = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(value, average);
            Console.WriteLine(index);
        
            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            int[] ints = new int[100];
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int rndNum = random.Next(0, 10); // Generuj náhodné číslo od 0 do 9
                ints[i] = rndNum;
            }

            foreach (int y in ints)
            {
                Console.Write(y + " ");
            } 

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            foreach (int z in ints)
            {
                counts[z]++; // Zvýšení počtu výskytů pro dané číslo
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Číslo {i} se vyskytuje {counts[i]} krát");
            } */

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.                                 
            int[] array1 = { 1, 2, 3, 4, 5 };

            // Přehození prvků v původním poli
            Array.Reverse(array1);

            // Vytvoření druhého pole a zkopírování prvků
            int[] array2 = (int[])array1.Clone();

            // Výpis prvního pole
            Console.WriteLine("První pole:");
            foreach (int f in array1)
            {
                Console.Write(f + " ");
            }

            // Výpis druhého pole
            Console.WriteLine("Druhé pole:");
            foreach (int f in array2)
            {
                Console.Write(f + " ");
            }

            Console.ReadKey();
        }
    }
}
