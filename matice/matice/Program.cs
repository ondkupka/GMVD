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
            Console.Clear();

            Console.WriteLine("Zadejte rozměry matice b:");

            Console.Write("Počet řádků: ");
            int bRows = int.Parse(Console.ReadLine());
            Console.Write("Počet sloupců: ");
            int bCols = int.Parse(Console.ReadLine());
            Console.Clear();

            int[,] arrayOne = generateArray(aRows, aCols);
            int[,] arrayTwo = generateArray(bRows, bCols);

            Console.WriteLine("Matice A:");
            printArray(arrayOne);

            Console.WriteLine("Matice B:");
            printArray(arrayTwo);

            Console.WriteLine("Kterou operaci chceš s maticemi provést? add, multiply, summed, multiplyarrays, maindiagonalswap, sidediagonalswap, transposition, max, min, multiplyrow, multiplycolumn");
            string operation = Console.ReadLine();
            while (operation != "add" && operation != "multiply" && operation != "summed" && operation != "multiplyarrays" && operation != "maindiagonalswap" && operation != "sidediagonalswap" && operation != "subtract" && operation != "transposition" && operation != "max" && operation !="min" && operation != "multiplyrow" && operation != "multiplycolumn")
            {
                Console.WriteLine("napiš možnou operaci");
                operation = Console.ReadLine();
            }

            switch (operation) //prohazuje mezi zvolenými operacemi
            {
                case "add":                                                            
                    int[,] result = addArrays(arrayOne, arrayTwo);
                    printArray(result);
                    break;
                case "multiply":
                    int num;
                    Console.WriteLine("Kterým číslem chceš násobit pole?");
                    while (!int.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("Zadej platné číslo");
                    }
                    multiplyArray(arrayOne,num);
                    printArray(arrayOne);
                    break;
                case "summed":                                                                         
                    int summed = 0;
                    summed = summedArray(arrayOne, summed);
                    Console.WriteLine("součet všech polí v matici je: " + summed);
                    break;
                case "multiplyarrays":
                    if (aCols != bRows)
                    {
                        Console.WriteLine("Nelze násobit matice s těmito rozměry.");
                    }
                    else
                    {
                        int[,] resultArray = new int[aRows, bCols];
                        multiplyArrays(arrayOne, arrayTwo, resultArray);
                        Console.WriteLine("Výsledek násobení matic je:");
                        printArray(resultArray);
                    }
                    break;
                case "maindiagonalswap":         
                        mainDiagonalSwap(arrayOne, aRows, aCols);
                        Console.WriteLine("Matice po výměně hlavní diagonály:");
                        printArray(arrayOne);
                    break;
                case "sidediagonalswap":
                        sideDiagonalSwap(arrayOne, aRows, aCols);
                        Console.WriteLine("Matice po výměně vedlejší diagonály:");
                        printArray(arrayOne);
                    break;
                case "subtract": 
                    subtract(arrayOne, arrayTwo, aRows, bCols);
                    Console.WriteLine("Výsledek odčítání matic je:");
                    printArray(arrayOne);
                    break;
                case "transposition":
                     transposition(arrayOne, aRows, aCols); 
                     Console.WriteLine("Matice po výměně hlavní diagonály:");
                     printArray(arrayOne);
                    break;
                case "max":
                    int max = findMax(arrayOne);
                    Console.WriteLine("Největší číslo v matici je: " + max);
                    break;
                case "min":
                    int min = findMin(arrayOne);
                    Console.WriteLine("Nejmenší číslo v matici je: " + min);
                    break;
                case "multiplyrow":
                    Console.WriteLine("Který řádek chceš násobit?");
                    int rowToMultiply = int.Parse(Console.ReadLine());

                    if (rowToMultiply >= 0 && rowToMultiply < aRows)
                    {
                        int number;
                        Console.WriteLine("Kterým číslem chceš násobit řádek?");
                        while (!int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine("Zadej platné číslo");
                        }
                        multiplyRow(arrayOne, rowToMultiply, num);
                        printArray(arrayOne);
                    }
                    else
                    {
                        Console.WriteLine("Neplatný řádek.");
                    }
                    break;
                case "multiplycolumn":
                    Console.WriteLine("Který sloupec chceš násobit?");
                    int columnToMultiply = int.Parse(Console.ReadLine());

                    if (columnToMultiply >= 0 && columnToMultiply < aCols)
                    {
                        int number;
                        Console.WriteLine("Kterým číslem chceš násobit sloupec?");
                        while (!int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine("Zadej platné číslo");
                        }
                        multiplyColumn(arrayOne, columnToMultiply, num);
                        printArray(arrayOne);
                    }
                    else
                    {
                        Console.WriteLine("Neplatný sloupec.");
                    }
                    break;
            }


            Console.ReadLine();
        }
        static int[,] generateArray(int rows, int cols)
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
        } //naplňí pole náhodnými čísly nebo od jedničky
        static void printArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        } //vypíše pole
        static int[,] addArrays(int[,] arrayOne, int[,] arrayTwo)
        {
            int rows = arrayOne.GetLength(0);
            int cols = arrayOne.GetLength(1);

            if (rows != arrayTwo.GetLength(0) || cols != arrayTwo.GetLength(1))
            {
                Console.WriteLine("Nelze sčítat matice, které mají různé rozměry.");
                return null;
            }

            int[,] resultAdd = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultAdd[i, j] = arrayOne[i, j] + arrayTwo[i, j];
                }
            }

            return resultAdd;
        } //sčítaní polí 
        static void multiplyArray(int[,] arrayOne, int num)
        {

            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOne.GetLength(1); j++)
                {
                    arrayOne[i, j] = num * arrayOne[i, j];
                }
            }
        } //vynásobí matici libovolným celým číslem
        static int summedArray(int[,] arrayOne, int summed)
        {
            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOne.GetLength(1); j++)
                {
                    summed += arrayOne[i, j];
                }
            }
            return summed;
        } //sečte všechny prvky v matici
        static void multiplyArrays(int[,] arrayOne, int[,] arrayTwo, int[,] resultArray)
        {
            int aRows = arrayOne.GetLength(0);
            int aCols = arrayOne.GetLength(1);
            int bCols = arrayTwo.GetLength(1);

            for (int i = 0; i < aRows; i++)
            {
                for (int j = 0; j < bCols; j++)
                {
                    for (int k = 0; k < aCols; k++)
                    {
                        resultArray[i, j] += arrayOne[i, k] * arrayTwo[k, j];
                    }
                }
            }
        } //násobí dvě matice mezi sebou, inspirace chatgtp a https://www.itnetwork.cz/
        static void mainDiagonalSwap(int[,] arrayOne, int aRows, int aCols) //převrácení hlavní diagonály
        {
            if (aRows != aCols)
            {
                Console.WriteLine("Toto převrácení lze použít jen ve čtvercovích maticích");
                return;
            }

            for (int i = 0; i < aRows; i++)
            {
                int temp = arrayOne[i, i];
                arrayOne[i, i] = arrayOne[i, aCols - 1 - i];
                arrayOne[i, aCols - 1 - i] = temp;
            }
        }
        static void sideDiagonalSwap(int[,] arrayOne, int aRows, int aCols) //převrácení vedlejší diagonály
        {
            if (aRows != aCols)
            {
                Console.WriteLine("Toto převrácení lze použít jen ve čtvercovích maticích");
                return;
            }

            for (int i = 0; i < aRows; i++)
            {
                int temp = arrayOne[i, i];
                arrayOne[i, i] = arrayOne[aRows - 1 - i, aRows - 1 - i];
                arrayOne[aRows - 1 - i, aRows - 1 - i] = temp;
            }
        }
        static void subtract(int[,] arrayOne, int[,] arrayTwo, int aRows, int bCols) //odečtení matic 
        {
            if (aRows != arrayTwo.GetLength(0) || bCols != arrayTwo.GetLength(1))
            {
                Console.WriteLine("Nelze odečítat matice, které mají různé rozměry.");
                return;
            }

            for (int i = 0; i < aRows; i++)
            {
                for (int j = 0; j < bCols; j++)
                {
                    arrayOne[i, j] -= arrayTwo[i, j];
                }
            }
        }
        static void transposition(int[,] arrayOne, int aRows, int aCols) // transpozice matice
        {
            if (aRows != aCols)
            {
                Console.WriteLine("Toto převrácení lze použít jen ve čtvercovích maticích");
                return;
            }

            for (int i = 0; i < aRows; i++)
            {
                for (int j = i + 1; j < aCols; j++)
                {
                    int temp = arrayOne[i, j];
                    arrayOne[i, j] = arrayOne[j, i];
                    arrayOne[j, i] = temp;
                }
            }
        }
        static int findMax(int[,] arrayOne) //najde největší číslo v matici 
        {
            int max = arrayOne[0, 0];

            foreach (int num in arrayOne)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }
        static int findMin(int[,] array) //najde nejmenší číslo v matici 
        {
            int min = array[0, 0];

            foreach (int num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
        static void multiplyRow(int[,] array, int rowIndex, int multiplier)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[rowIndex, j] *= multiplier;
            }
        } //násobí zvolený řádek 
        static void multiplyColumn(int[,] array, int colIndex, int multiplier)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, colIndex] *= multiplier;
            }
        } //násobí zvolený sloupec
    }
}
