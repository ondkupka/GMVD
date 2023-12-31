﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] myArray = new int[5, 5];
            int numberToAdd = 1;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i,j] = numberToAdd;
                    numberToAdd++;
                    Console.Write(myArray[i,j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 0;
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.Write(myArray[nRow, j] + " ");
            }
            Console.Write("\n");
            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.Write(myArray[i, nColumn] + " ");
            }
            Console.Write("\n");
            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
      /*      Console.WriteLine("tady");
            int xFirst = 0, yFirst = 0, xSecond = 1, ySecond = 1;
            int temp = myArray[xFirst, yFirst];
            myArray[xFirst, yFirst] = myArray[xSecond, ySecond];
            myArray[xSecond, ySecond] = temp;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.Write("\n");
            } */
            Console.Write("\n");
            //BONUS TODO vypiš prvky hlavní diagonály
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.Write(myArray[i, i] + " ");
            }
            Console.Write("\n");

            //BONUS 2
            for (int i = 4; i >= 0 ; i--)
            {
                Console.Write(myArray[i, myArray.GetLength(0) -i -1] + " ");
            }
            Console.Write("\n");
            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            Console.WriteLine("xxd");
            int nRowSwap = 0;
            int mRowSwap = 1;
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                int tempSwap = myArray[nRowSwap, j];
                myArray[nRowSwap, j] = myArray[mRowSwap, j];
                myArray[mRowSwap, j] = tempSwap;
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.

            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.


            Console.ReadKey();
        }
    }
}
