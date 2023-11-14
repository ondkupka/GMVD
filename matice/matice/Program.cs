using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte rozměry první matice a:");

            Console.Write("Počet řádků: ");
            int aRows = int.Parse(Console.ReadLine());

            Console.Write("Počet sloupců: ");
            int aCols = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte rozměry matice b:");

            Console.Write("Počet řádků: ");
            int bRows = int.Parse(Console.ReadLine());

            Console.Write("Počet sloupců: ");
            int bCols = int.Parse(Console.ReadLine());

            int[,] arrayOne = generate2DArray(aRows, aCols);
            int[,] arrayTwo = generate2DArray(bRows, bCols);
            Console.Write(arrayOne);
            Console.Write("\n");
            Console.Write(arrayTwo);
        }
        static int[,] generate2DArray(int rows, int cols)
        {
            int[,] array = new int[rows, cols];

            Console.WriteLine("Pro naplnění matice náhodnými čísly zvol (1)" + Environment.NewLine + "Pro naplnění od jedničky zvol (2)");
            int choice = int.Parse(Console.ReadLine());

            Random random = new Random();

            if (choice == 1)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array[i, j] = random.Next(1, 10); // Úprava rozsahu podle potřeby
                    }
                }
            }
            else if (choice == 2)
            {
                int value = 1;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array[i, j] = value++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Neplatná volba.");
            }

            return array;
        }
    }
}
