using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace maturita_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš číslo jedna");
            string cislo1 = Console.ReadLine();
            int x = int.Parse(cislo1);
            Console.WriteLine("Tebou zadané číslo je: " + x);

            Console.WriteLine("Napiš číslo dva");
            string cislo2 = Console.ReadLine();
            int y = int.Parse(cislo2);
            Console.WriteLine("Tebou zadané číslo je: " + y);

            int sum = x + y;
            int sub = x - y;
            int multiply = x * y;
            float divide = (float)x / y; 
            Console.WriteLine("Součet čísel je " + sum);
            Console.WriteLine("Rozdíl čísel je " + sub);
            Console.WriteLine("Násobek čísel je " + multiply);
            Console.WriteLine("Dělenec čísel je " + divide);
            double z = Math.Pow(x,y);
            double w = Math.Sqrt(x);

            if (sum > 0)
                Console.WriteLine("Součet je kladný");
            else
                Console.WriteLine("Součet je záporný");
            if (sub > multiply)
                Console.WriteLine("Rozdíl je větší než násobek");
            else
                Console.WriteLine("Násobek je větší než rozdíl");
            if (sum > sub && multiply > divide)
                Console.WriteLine("Suma je větší než sub a násobení větší než dělení");
            else
                Console.WriteLine("Není větší");

            int[] pole = new int[50];
            string j = " ";
            while ( j != "stop") {
                j = Console.ReadLine();
            }
            Console.WriteLine("Zadal si stop");

            Console.ReadKey();
        }
    }
}
